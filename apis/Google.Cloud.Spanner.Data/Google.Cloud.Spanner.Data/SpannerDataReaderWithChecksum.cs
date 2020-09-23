using Google.Api.Gax;
using Google.Cloud.Spanner.V1;
using Google.Cloud.Spanner.V1.Internal.Logging;
using Google.Protobuf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.Spanner.Data
{
    /// <summary>
    /// Reads a forward-only stream of rows from a data source and keeps track of a running
    /// checksum for all data that have been seen.
    /// </summary>
    public sealed class SpannerDataReaderWithChecksum : SpannerDataReader, IRetriableStatement
    {
        private readonly RetriableSpannerTransaction _transaction;
        private readonly ExecuteSqlRequest _request;
        private int _numberOfReadCalls;
        private byte[] _currentChecksum = new byte[0];
        private SpannerException _firstException;

        internal SpannerDataReaderWithChecksum(
            RetriableSpannerTransaction transaction,
            ExecuteSqlRequest request,
            Logger logger,
            ReliableStreamReader resultSet,
            IDisposable resourceToClose,
            SpannerConversionOptions conversionOptions,
            bool provideSchemaTable,
            int readTimeoutSeconds) : base(
                logger,
                resultSet,
                resourceToClose,
                conversionOptions,
                provideSchemaTable,
                readTimeoutSeconds
            )
        {
            _transaction = transaction;
            _request = request;
        }

        /// <inheritdoc />
        public override bool Read() => Task.Run(() => ReadAsync(CancellationToken.None)).ResultWithUnwrappedExceptions();

        /// <inheritdoc />
        public override Task<bool> ReadAsync(CancellationToken cancellationToken) =>
            ExecuteHelper.WithErrorTranslationAndProfiling(async () =>
            {
                while (true)
                {
                    try
                    {
                        bool res = await base.ReadAsync(cancellationToken).ConfigureAwait(false);
                        if (res)
                        {
                            _currentChecksum = CalculateNextChecksum(this, _currentChecksum);
                        }
                        _numberOfReadCalls++;
                        return res;
                    } catch (SpannerException e) when (e.ErrorCode == ErrorCode.Aborted)
                    {
                        // Retry the transaction and then retry the ReadAsync call.
                        await _transaction.RetryAsync(cancellationToken).ConfigureAwait(false);
                    } catch (SpannerException e)
                    {
                        if (_firstException == null)
                        {
                            _firstException = e;
                        }
                        _numberOfReadCalls++;
                        throw e;
                    }
                }
            }, "SpannerDataReaderWithChecksum.Read", Logger);

        internal static byte[] CalculateNextChecksum(SpannerDataReader reader, byte[] currentChecksum)
        {
            int size = currentChecksum.Length;
            for(int i=0; i<reader.FieldCount; i++)
            {
                size += reader.GetJsonValue(i).CalculateSize();
            }
            using (MemoryStream ms = new MemoryStream(size))
            {
                ms.Write(currentChecksum, 0, currentChecksum.Length);
                using (CodedOutputStream cos = new CodedOutputStream(ms))
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        reader.GetJsonValue(i).WriteTo(cos);
                    }
                    // Flush the protobuf stream so everything is written to the memory stream.
                    cos.Flush();
                    // Then reset the memory stream to the start so the hash is calculated over all the bytes in the buffer.
                    ms.Position = 0;
                    SHA256 checksum = SHA256.Create();
                    return checksum.ComputeHash(ms);
                }
            }
        }

        async Task IRetriableStatement.Retry(RetriableSpannerTransaction transaction, CancellationToken cancellationToken, int timeoutSeconds)
        {
            ReliableStreamReader streamReader = await transaction.DoExecuteQueryAsync(_request, cancellationToken, timeoutSeconds).ConfigureAwait(false);
            SpannerDataReader reader = new SpannerDataReader(Logger, streamReader, null, ConversionOptions, false, timeoutSeconds);
            int counter = 0;
            bool read = true;
            byte[] newChecksum = new byte[0];
            SpannerException newException = null;
            while (counter < _numberOfReadCalls && read)
            {
                try
                {
                    read = await reader.ReadAsync().ConfigureAwait(false);
                    if (read)
                    {
                        newChecksum = CalculateNextChecksum(reader, newChecksum);
                    }
                    counter++;
                }
                catch (SpannerException e) when (e.ErrorCode == ErrorCode.Aborted)
                {
                    // Propagate Aborted errors to trigger a new retry.
                    throw e;
                }
                catch (SpannerException e)
                {
                    newException = e;
                    counter++;
                    break;
                }
            }
            if (counter == _numberOfReadCalls
                && newChecksum.SequenceEqual(_currentChecksum)
                && RetriableSpannerTransaction.SpannerExceptionsEqualForRetry(newException, _firstException))
            {
                // Checksum is ok, we only need to replace the delegate result set if it's still open.
                if (IsClosed)
                {
                    reader.Close();
                }
                else
                {
                    ResultSet = streamReader;
                }
            }
            else
            {
                // The results are not equal, there is an actual concurrent modification, so we cannot
                // continue the transaction.
                throw new SpannerAbortedDueToConcurrentModificationException();
            }
        }
    }
}
