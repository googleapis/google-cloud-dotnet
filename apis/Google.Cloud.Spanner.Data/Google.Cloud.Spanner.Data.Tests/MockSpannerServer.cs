using Castle.DynamicProxy.Generators.Emitters.SimpleAST;
using Google.Api.Gax.Grpc.GrpcCore;
using Google.Cloud.Spanner.Common.V1;
using Google.Cloud.Spanner.V1;
using Google.Protobuf;
using Google.Protobuf.WellKnownTypes;
using Google.Rpc;
using Grpc.Core;
using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Status = Google.Rpc.Status;

namespace Google.Cloud.Spanner.Data.Tests
{
    public class StatementResult
    {
        public enum StatementResultType
        {
            RESULT_SET,
            UPDATE_COUNT,
            EXCEPTION
        }

        public StatementResultType Type { get; }
        public ResultSet ResultSet { get; }
        public long UpdateCount { get; }
        public Exception Exception { get; }

        internal static StatementResult CreateQuery(ResultSet resultSet)
        {
            return new StatementResult(resultSet);
        }

        internal static StatementResult CreateUpdateCount(long count)
        {
            return new StatementResult(count);
        }

        internal static StatementResult CreateException(Exception exception)
        {
            return new StatementResult(exception);
        }

        internal static StatementResult CreateSelect1ResultSet()
        {
            return CreateSingleColumnResultSet(SpannerConversionOptions.Default, SpannerDbType.Int64, "COL1", 1);
        }

        internal static StatementResult CreateSingleColumnResultSet(SpannerDbType type, String col, params object[] values)
        {
            return CreateSingleColumnResultSet(SpannerConversionOptions.Default, type, col, values);
        }

        internal static StatementResult CreateSingleColumnResultSet(SpannerConversionOptions options, SpannerDbType type, String col, params object[] values)
        {
            ResultSet rs = new ResultSet();
            rs.Metadata = new ResultSetMetadata
            {
                RowType = new StructType()
            };
            rs.Metadata.RowType.Fields.Add(new StructType.Types.Field
            {
                Name = col,
                Type = new V1.Type
                {
                    Code = type.ToProtobufType().Code
                }
            });
            foreach (object val in values)
            {
                ListValue row = new ListValue();
                row.Values.Add(type.ToProtobufValue(val, options));
                rs.Rows.Add(row);
            }
            return CreateQuery(rs);
        }

        private StatementResult(ResultSet resultSet)
        {
            Type = StatementResultType.RESULT_SET;
            ResultSet = resultSet;
        }

        private StatementResult(long updateCount)
        {
            Type = StatementResultType.UPDATE_COUNT;
            UpdateCount = updateCount;
        }

        private StatementResult(Exception exception)
        {
            Type = StatementResultType.EXCEPTION;
            Exception = exception;
        }
    }

    public class ExecutionTime
    {
        private readonly int _executionTime;
        // TODO: Support multiple exceptions
        private Exception _exception;
        private readonly int _exceptionStreamIndex;

        internal bool HasExceptionAtIndex(int index)
        {
            return _exception != null && _exceptionStreamIndex == index;
        }

        internal Exception PopExceptionAtIndex(int index)
        {
            Exception res = _exceptionStreamIndex == index ? _exception : null;
            if (res != null)
            {
                _exception = null;
            }
            return res;
        }

        internal static ExecutionTime StreamException(Exception exception, int streamIndex)
        {
            return new ExecutionTime(0, exception, streamIndex);
        }

        private ExecutionTime(int executionTime, Exception exception, int exceptionStreamIndex)
        {
            _executionTime = executionTime;
            _exception = exception;
            _exceptionStreamIndex = exceptionStreamIndex;
        }
    }

    public class MockSpannerService : Google.Cloud.Spanner.V1.Spanner.SpannerBase
    {
        class PartialResultSetsEnumerable : IEnumerable<PartialResultSet>
        {
            private readonly ResultSet _resultSet;
            public PartialResultSetsEnumerable(ResultSet resultSet)
            {
                this._resultSet = resultSet;
            }

            public IEnumerator<PartialResultSet> GetEnumerator()
            {
                return new PartialResultSetsEnumerator(_resultSet);
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return new PartialResultSetsEnumerator(_resultSet);
            }
        }

        class PartialResultSetsEnumerator : IEnumerator<PartialResultSet>
        {
            private static readonly int MAX_ROWS_IN_CHUNK = 1;

            private readonly ResultSet _resultSet;
            private bool _first = true;
            private int _currentRow = 0;
            private PartialResultSet _current;

            public PartialResultSetsEnumerator(ResultSet resultSet)
            {
                this._resultSet = resultSet;
            }

            PartialResultSet IEnumerator<PartialResultSet>.Current => _current;

            object IEnumerator.Current => _current;

            public bool MoveNext()
            {
                _current = new PartialResultSet();
                _current.ResumeToken = ByteString.CopyFromUtf8($"{_currentRow}");
                if (_first)
                {
                    _current.Metadata = _resultSet.Metadata;
                    _first = false;
                } else if (_currentRow == _resultSet.Rows.Count)
                {
                    return false;
                }
                int recordCount = 0;
                while (recordCount < MAX_ROWS_IN_CHUNK && _currentRow < _resultSet.Rows.Count)
                {
                    _current.Values.Add(_resultSet.Rows.ElementAt(_currentRow).Values);
                    recordCount++;
                    _currentRow++;
                }
                return true;
            }

            public void Reset()
            {
                throw new NotImplementedException();
            }

            public void Dispose()
            {
            }
        }


        private static readonly Empty EMPTY = new Empty();
        private static readonly TransactionOptions SINGLE_USE = new TransactionOptions { ReadOnly = new TransactionOptions.Types.ReadOnly { Strong = true, ReturnReadTimestamp = false } };

        private ConcurrentDictionary<string, StatementResult> _results = new ConcurrentDictionary<string, StatementResult>();
        private ConcurrentQueue<IMessage> _requests = new ConcurrentQueue<IMessage>();
        private int _sessionCounter;
        private int _transactionCounter;
        private ConcurrentDictionary<SessionName, Session> _sessions = new ConcurrentDictionary<SessionName, Session>();
        private ConcurrentDictionary<ByteString, Transaction> _transactions = new ConcurrentDictionary<ByteString, Transaction>();
        private ConcurrentDictionary<ByteString, TransactionOptions> _transactionOptions = new ConcurrentDictionary<ByteString, TransactionOptions>();
        private ConcurrentDictionary<ByteString, bool> _abortedTransactions = new ConcurrentDictionary<ByteString, bool>();
        private ConcurrentDictionary<string, ExecutionTime> _executionTimes = new ConcurrentDictionary<string, ExecutionTime>();

        public void AddOrUpdateStatementResult(string sql, StatementResult result)
        {
            _results.AddOrUpdate(sql,
                result,
                (string sql, StatementResult existing) => result
            );
        }

        public void AddOrUpdateExecutionTime(string method, ExecutionTime executionTime)
        {
            _executionTimes.AddOrUpdate(method,
                executionTime,
                (string method, ExecutionTime existing) => executionTime
            );
        }

        internal void AbortTransaction(ByteString id)
        {
            _abortedTransactions.TryAdd(id, true);
        }

        public List<IMessage> Requests()
        {
            return new List<IMessage>(_requests);
        }

        public void Reset()
        {
            _requests = new ConcurrentQueue<IMessage>();
        }

        public override Task<Transaction> BeginTransaction(BeginTransactionRequest request, ServerCallContext context)
        {
            _requests.Enqueue(request);
            TryFindSession(request.SessionAsSessionName);
            Transaction tx = new Transaction();
            var id = Interlocked.Increment(ref _transactionCounter);
            tx.Id = ByteString.CopyFromUtf8($"{request.SessionAsSessionName}/transactions/{id}");
            _transactions.TryAdd(tx.Id, tx);
            return Task.FromResult(tx);
        }

        public override Task<CommitResponse> Commit(CommitRequest request, ServerCallContext context)
        {
            _requests.Enqueue(request);
            TryFindSession(request.SessionAsSessionName);
            if (request.TransactionCase == CommitRequest.TransactionOneofCase.TransactionId)
            {
                TryFindTransaction(request.TransactionId, true);
            }
            CommitResponse response = new CommitResponse();
            Timestamp ts = Timestamp.FromDateTime(DateTime.UtcNow);
            response.CommitTimestamp = ts;
            return Task.FromResult(response);
        }

        private Session CreateSession(DatabaseName database)
        {
            var id = Interlocked.Increment(ref _sessionCounter);
            Session session = new Session { SessionName = new SessionName(database.ProjectId, database.InstanceId, database.DatabaseId, $"session-{id}") };
            if (!_sessions.TryAdd(session.SessionName, session))
            {
                throw new RpcException(new Grpc.Core.Status(StatusCode.AlreadyExists, $"Session with id session-{id} already exists"));
            }
            return session;
        }

        static internal RpcException CreateAbortedException()
        {
            return new RpcException(new Grpc.Core.Status(StatusCode.Aborted, "Transaction aborted"));
        }

        private Transaction TryFindTransaction(ByteString id, Boolean remove = false)
        {
            bool aborted;
            if (_abortedTransactions.TryGetValue(id, out aborted) && aborted)
            {
                throw CreateAbortedException();
            }
            Transaction tx;
            if (remove ? _transactions.TryRemove(id, out tx) : _transactions.TryGetValue(id, out tx))
            {
                return tx;
            }
            throw new RpcException(new Grpc.Core.Status(StatusCode.NotFound, $"Transaction not found: {id.ToBase64()}"));
        }

        private Transaction FindOrBeginTransaction(SessionName session, TransactionSelector selector)
        {
            if (selector == null)
            {
                return BeginTransaction(session, SINGLE_USE, true);
            }
            // TODO: Check that the selected transaction actually belongs to the given session.
            switch (selector.SelectorCase)
            {
                case TransactionSelector.SelectorOneofCase.SingleUse:
                    return BeginTransaction(session, selector.SingleUse, true);
                case TransactionSelector.SelectorOneofCase.Begin:
                    return BeginTransaction(session, selector.Begin, false);
                case TransactionSelector.SelectorOneofCase.Id:
                    return TryFindTransaction(selector.Id);
                case TransactionSelector.SelectorOneofCase.None:
                default:
                    return null;
            }
        }

        private Transaction BeginTransaction(SessionName session, TransactionOptions options, bool singleUse)
        {
            Transaction tx = new Transaction();
            var id = Interlocked.Increment(ref _transactionCounter);
            tx.Id = ByteString.CopyFromUtf8($"{session}/transactions/{id}");
            if (options.ModeCase == TransactionOptions.ModeOneofCase.ReadOnly && options.ReadOnly.ReturnReadTimestamp)
            {
                tx.ReadTimestamp = Timestamp.FromDateTime(DateTime.Now);
            }
            if (!singleUse)
            {
                _transactions.TryAdd(tx.Id, tx);
                _transactionOptions.TryAdd(tx.Id, options);
            }
            return tx;
        }

        public override Task<BatchCreateSessionsResponse> BatchCreateSessions(BatchCreateSessionsRequest request, ServerCallContext context)
        {
            _requests.Enqueue(request);
            var database = request.DatabaseAsDatabaseName;
            BatchCreateSessionsResponse response = new BatchCreateSessionsResponse();
            for (int i = 0; i < request.SessionCount; i++)
            {
                response.Session.Add(CreateSession(database));
            }
            return Task.FromResult(response);
        }

        public override Task<Session> CreateSession(CreateSessionRequest request, ServerCallContext context)
        {
            _requests.Enqueue(request);
            var database = request.DatabaseAsDatabaseName;
            return Task.FromResult(CreateSession(database));
        }

        public override Task<Session> GetSession(GetSessionRequest request, ServerCallContext context)
        {
            _requests.Enqueue(request);
            return Task.FromResult(TryFindSession(request.SessionName));
        }

        public override Task<ListSessionsResponse> ListSessions(ListSessionsRequest request, ServerCallContext context)
        {
            _requests.Enqueue(request);
            ListSessionsResponse response = new ListSessionsResponse();
            foreach (Session session in _sessions.Values)
            {
                response.Sessions.Add(session);
            }
            return Task.FromResult(response);
        }

        public override Task<Empty> DeleteSession(DeleteSessionRequest request, ServerCallContext context)
        {
            _requests.Enqueue(request);
            _sessions.TryRemove(request.SessionName, out _);
            return Task.FromResult(EMPTY);
        }

        private Session TryFindSession(SessionName name)
        {
            Session session;
            if (_sessions.TryGetValue(name, out session))
            {
                return session;
            }
            throw new RpcException(new Grpc.Core.Status(StatusCode.NotFound, $"Session not found: {name}"));
        }

        public override Task<ExecuteBatchDmlResponse> ExecuteBatchDml(ExecuteBatchDmlRequest request, ServerCallContext context)
        {
            _requests.Enqueue(request);
            Session session = TryFindSession(request.SessionAsSessionName);
            Transaction tx = FindOrBeginTransaction(request.SessionAsSessionName, request.Transaction);
            ExecuteBatchDmlResponse response = new ExecuteBatchDmlResponse();
            // TODO: Return other statuses based on the mocked results.
            response.Status = new Status();
            response.Status.Code = (int) StatusCode.OK;
            int index = 0;
            foreach (var statement in request.Statements)
            {
                if (response.Status.Code != (int) StatusCode.OK)
                {
                    break;
                }
                StatementResult result;
                if (_results.TryGetValue(statement.Sql, out result))
                {
                    switch (result.Type)
                    {
                        case StatementResult.StatementResultType.RESULT_SET:
                            throw new RpcException(new Grpc.Core.Status(StatusCode.InvalidArgument, $"ResultSet is not a valid result type for BatchDml"));
                        case StatementResult.StatementResultType.UPDATE_COUNT:
                            response.ResultSets.Add(CreateUpdateCountResultSet(result.UpdateCount));
                            break;
                        case StatementResult.StatementResultType.EXCEPTION:
                            if (index == 0)
                            {
                                throw result.Exception;
                            }
                            response.Status = StatusFromException(result.Exception);
                            break;
                        default:
                            throw new RpcException(new Grpc.Core.Status(StatusCode.InvalidArgument, $"Invalid result type {result.Type} for {statement.Sql}"));
                    }
                }
                else
                {
                    throw new RpcException(new Grpc.Core.Status(StatusCode.InvalidArgument, $"No result found for {statement.Sql}"));
                }
                index++;
            }
            return Task.FromResult(response);
        }

        private Status StatusFromException(Exception e)
        {
            if (e is RpcException) {
                RpcException rpc = (RpcException)e;
                return new Status { Code = (int) rpc.StatusCode, Message = e.Message };
            }
            return new Status { Code = (int) StatusCode.Unknown, Message = e.Message };
        }

        public override Task<ResultSet> ExecuteSql(ExecuteSqlRequest request, ServerCallContext context)
        {
            return base.ExecuteSql(request, context);
        }

        public override async Task ExecuteStreamingSql(ExecuteSqlRequest request, IServerStreamWriter<PartialResultSet> responseStream, ServerCallContext context)
        {
            _requests.Enqueue(request);
            ExecutionTime executionTime;
            _executionTimes.TryGetValue(nameof(ExecuteStreamingSql), out executionTime);
            Session session = TryFindSession(request.SessionAsSessionName);
            Transaction tx = FindOrBeginTransaction(request.SessionAsSessionName, request.Transaction);
            StatementResult result;
            if (_results.TryGetValue(request.Sql, out result))
            {
                switch (result.Type)
                {
                    case StatementResult.StatementResultType.RESULT_SET:
                        await WriteResultSet(result.ResultSet, responseStream, executionTime);
                        break;
                    case StatementResult.StatementResultType.UPDATE_COUNT:
                        await WriteUpdateCount(result.UpdateCount, responseStream);
                        break;
                    case StatementResult.StatementResultType.EXCEPTION:
                        throw result.Exception;
                    default:
                        throw new RpcException(new Grpc.Core.Status(StatusCode.InvalidArgument, $"Invalid result type {result.Type} for {request.Sql}"));
                }
            }
            else
            {
                throw new RpcException(new Grpc.Core.Status(StatusCode.InvalidArgument, $"No result found for {request.Sql}"));
            }
        }

        private async Task WriteResultSet(ResultSet resultSet, IServerStreamWriter<PartialResultSet> responseStream, ExecutionTime executionTime)
        {
            int index = 0;
            PartialResultSetsEnumerable enumerator = new PartialResultSetsEnumerable(resultSet);
            foreach (PartialResultSet prs in enumerator)
            {
                Exception e = executionTime?.PopExceptionAtIndex(index);
                if (e != null)
                {
                    throw e;
                }
                await responseStream.WriteAsync(prs);
                index++;
            }
        }

        private async Task WriteUpdateCount(long updateCount, IServerStreamWriter<PartialResultSet> responseStream)
        {
            PartialResultSet prs = new PartialResultSet();
            prs.Stats = new ResultSetStats { RowCountExact = updateCount };
            await responseStream.WriteAsync(prs);
        }

        private ResultSet CreateUpdateCountResultSet(long updateCount)
        {
            ResultSet rs = new ResultSet();
            rs.Stats = new ResultSetStats { RowCountExact = updateCount };
            return rs;
        }

        public override Task<PartitionResponse> PartitionQuery(PartitionQueryRequest request, ServerCallContext context)
        {
            return base.PartitionQuery(request, context);
        }

        public override Task<PartitionResponse> PartitionRead(PartitionReadRequest request, ServerCallContext context)
        {
            return base.PartitionRead(request, context);
        }

        public override Task<ResultSet> Read(ReadRequest request, ServerCallContext context)
        {
            return base.Read(request, context);
        }

        public override Task<Empty> Rollback(RollbackRequest request, ServerCallContext context)
        {
            return base.Rollback(request, context);
        }

        public override Task StreamingRead(ReadRequest request, IServerStreamWriter<PartialResultSet> responseStream, ServerCallContext context)
        {
            return base.StreamingRead(request, responseStream, context);
        }
    }
}
