// Copyright 2026 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License"):
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Google.Cloud.Spanner.Data.CommonTesting;
using System;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Spanner.Data.IntegrationTests;

[Collection(nameof(MutationsQueueFixture))]
public class QueueTests
{
    private readonly MutationsQueueFixture _queueFixture;

    public QueueTests(MutationsQueueFixture dmlQueueFixture) => _queueFixture = dmlQueueFixture;

    [Trait(Constants.SupportedOnEmulator, Constants.No)]
    [Fact]
    public async Task QueueIsLeftWithNoMessagesAfterAck_Basic()
    {
        using var connection = _queueFixture.GetConnection();
        var key = KeyFromLongPair(1, 1);

        var payload = new SpannerParameter("Payload", SpannerDbType.FromClrType(typeof(Rectangle)), new Rectangle
        {
            TopRight = new Point { X = 1, Y = 1 },
            Width = 10,
            Height = 5,
        });

        // Send Message
        using var sendCommand = connection.CreateSendCommand(_queueFixture.QueueName, key, payload);
        await sendCommand.ExecuteNonQueryAsync();

        // Ack messages
        var ackCommand = connection.CreateAckCommand(_queueFixture.QueueName, key);
        await ackCommand.ExecuteNonQueryAsync();

        // Queue is left with no messages after Ack
        var selectCommand = connection.CreateSelectCommand(_queueFixture.QueueName);
        selectCommand.CommandText = $"SELECT COUNT(*) FROM {_queueFixture.QueueName};";
        var count = await selectCommand.ExecuteScalarAsync();

        Assert.Equal(0L, (long) count);
    }

    [Trait(Constants.SupportedOnEmulator, Constants.No)]
    [Fact]
    public async Task QueueIsLeftWithNoMessagesAfterAck_DeliveryTimeSpecified_Streamed()
    {
        using var connection = _queueFixture.GetConnection();
        var key = KeyFromLongPair(1, 1);
        var payload = new SpannerParameter("Payload", SpannerDbType.Bytes, Encoding.UTF8.GetBytes("Hello World"));
        int deliveryDelay = 10;

        // Send Message
        using var sendCommand = connection.CreateSendCommand(_queueFixture.QueueName, key, payload, DateTime.UtcNow.AddSeconds(deliveryDelay));
        await sendCommand.ExecuteNonQueryAsync();
        Stopwatch sw = Stopwatch.StartNew();

        using var receiveCommand = connection.CreateSelectCommand($"SELECT UserId, MessageId FROM RECEIVE_{_queueFixture.QueueName}(max_duration => '15s')");
        using var reader = await receiveCommand.ExecuteReaderAsync();

        Assert.True(await reader.ReadAsync());
        // Add a buffer to compensate for the stopwatch starting after we get the response back
        int adjustedDeliveryDelay = deliveryDelay - 1;
        Assert.True(sw.Elapsed.TotalSeconds > adjustedDeliveryDelay, $"Expected to receive message after {adjustedDeliveryDelay} seconds, instead was {sw.Elapsed.TotalSeconds}");
    }

    [Trait(Constants.SupportedOnEmulator, Constants.No)]
    [Fact]
    public async Task QueueIsLeftWithNoMessagesAfterAck_Streaming()
    {
        using var connection = _queueFixture.GetConnection();

        // Send Messages
        for (long i = 0; i < 10; i++)
        {
            var key = KeyFromLongPair(1L, i);
            var payloadAsBytes = new SpannerParameter("Payload", SpannerDbType.Bytes, Encoding.UTF8.GetBytes("Hello World"));

            using var sendCommand = connection.CreateSendCommand(_queueFixture.QueueName, key, payloadAsBytes);
            await sendCommand.ExecuteNonQueryAsync();
        }

        using var receiveCommand = connection.CreateSelectCommand($"SELECT UserId, MessageId FROM RECEIVE_{_queueFixture.QueueName}(max_duration => '10s')");
        using (var reader = await receiveCommand.ExecuteReaderAsync())
        {
            while (await reader.ReadAsync())
            {
                long userId = reader.GetFieldValue<long>("UserId");
                long messageId = reader.GetFieldValue<long>("MessageId");

                var ackCommand = connection.CreateAckCommand(_queueFixture.QueueName, KeyFromLongPair(userId, messageId));
                await ackCommand.ExecuteNonQueryAsync();
            }
        }

        // Queue is left with no messages after Ack
        var selectCommand = connection.CreateSelectCommand(_queueFixture.QueueName);
        selectCommand.CommandText = $"SELECT COUNT(*) FROM {_queueFixture.QueueName};";
        var count = await selectCommand.ExecuteScalarAsync();

        Assert.Equal(0L, (long) count);
    }

    [Trait(Constants.SupportedOnEmulator, Constants.No)]
    [Fact]
    public async Task AckAMissingMessage_IgnoreNotFound_ThrowsException()
    {
        using var connection = _queueFixture.GetConnection();
        var key = KeyFromLongPair(1, 1);

        // Ack messages
        var ackCommand = connection.CreateAckCommand(_queueFixture.QueueName, key, ignoreNotFound: false);
        await Assert.ThrowsAsync<SpannerException>(ackCommand.ExecuteNonQueryAsync);
    }

    [Trait(Constants.SupportedOnEmulator, Constants.No)]
    [Fact]
    public async Task AckAMissingMessage_IgnoreFound_Ok()
    {
        using var connection = _queueFixture.GetConnection();
        var key = KeyFromLongPair(1, 1);

        // Ack messages
        var ackCommand = connection.CreateAckCommand(_queueFixture.QueueName, key, ignoreNotFound: true);
        await ackCommand.ExecuteNonQueryAsync();
    }

    private static Key KeyFromLongPair(long long1, long long2) => new(
            new SpannerParameterCollection([
                new SpannerParameter("UserId", SpannerDbType.Int64, value: long1),
                new SpannerParameter("MessageId", SpannerDbType.Int64, value: long2),
            ])
        );
}
