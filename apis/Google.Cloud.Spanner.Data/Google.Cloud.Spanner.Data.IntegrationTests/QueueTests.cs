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

using Google.Cloud.ClientTesting;
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

    private readonly byte[] _payloadBytes = Encoding.UTF8.GetBytes("Hello, World");
    private static int DeliveryDelay => 10;
    private static Func<int, DateTime> GetTimeFromNow => (int delay) => DateTime.UtcNow.AddSeconds(delay);
    private static SendOptions DeliverAfterDelayFromNow => new() { DeliverAt = GetTimeFromNow(DeliveryDelay) };

    [Trait(Constants.SupportedOnEmulator, Constants.No)]
    [Fact]
    public async Task QueueIsLeftWithNoMessagesAfterAck_Basic()
    {
        using var connection = _queueFixture.GetConnection();
        (string userId, string messageId) = (IdGenerator.FromGuid(), IdGenerator.FromGuid());

        // Send Message
        using var sendCommand = connection.CreateSendCommand(_queueFixture.QueueName, ParametersForKeyAndPayload(userId, messageId, _payloadBytes));
        await sendCommand.ExecuteNonQueryAsync();

        // Ack messages
        var ackCommand = connection.CreateAckCommand(_queueFixture.QueueName, ParametersForKey(userId, messageId));
        await ackCommand.ExecuteNonQueryAsync();

        // Queue is left with no messages after Ack
        var selectCommand = connection.CreateSelectCommand(_queueFixture.QueueName);
        selectCommand.CommandText = $"SELECT COUNT(*) FROM {_queueFixture.QueueName};";
        var count = await selectCommand.ExecuteScalarAsync();

        Assert.Equal(0L, (long) count);
    }

    [Trait(Constants.SupportedOnEmulator, Constants.No)]
    [Fact]
    public async Task QueueIsLeftWithNoMessagesAfterAck_Streaming()
    {
        using var connection = _queueFixture.GetConnection();

        // Send Messages
        for (long i = 0; i < 10; i++)
        {
            string userId = IdGenerator.FromGuid();
            string messageId = IdGenerator.FromGuid();
            using var sendCommand = connection.CreateSendCommand(_queueFixture.QueueName, ParametersForKeyAndPayload(userId, messageId, _payloadBytes));
            await sendCommand.ExecuteNonQueryAsync();
        }

        using var receiveCommand = connection.CreateSelectCommand($"SELECT UserId, MessageId FROM RECEIVE_{_queueFixture.QueueName}(max_duration => '10s')");
        using (var reader = await receiveCommand.ExecuteReaderAsync())
        {
            while (await reader.ReadAsync())
            {
                string userId = reader.GetFieldValue<string>("UserId");
                string messageId = reader.GetFieldValue<string>("MessageId");

                var ackCommand = connection.CreateAckCommand(_queueFixture.QueueName, ParametersForKey(userId, messageId));
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
    public async Task QueueIsLeftWithNoMessagesAfterDmlInsertThenDelete_Basic()
    {
        using var connection = _queueFixture.GetConnection();
        (string userId, string messageId) = (IdGenerator.FromGuid(), IdGenerator.FromGuid());

        // Insert Message via DML
        using var insertCommand = connection.CreateDmlCommand(
            $"INSERT INTO {_queueFixture.QueueName} (UserId, MessageId, Payload) VALUES (@UserId, @MessageId, @Payload)",
            ParametersForKeyAndPayload(userId, messageId, _payloadBytes));
        int insertedCount = await insertCommand.ExecuteNonQueryAsync();
        Assert.Equal(1, insertedCount);

        // Delete Message via DML
        using var deleteCommand = connection.CreateDmlCommand(
            $"DELETE FROM {_queueFixture.QueueName} WHERE UserId = @UserId AND MessageId = @MessageId",
            ParametersForKey(userId, messageId));
        int deletedCount = await deleteCommand.ExecuteNonQueryAsync();
        Assert.Equal(1, deletedCount);

        // Assert Queue is left with no messages after Delete
        using var selectCommand = connection.CreateSelectCommand($"SELECT COUNT(*) FROM {_queueFixture.QueueName};");
        var count = await selectCommand.ExecuteScalarAsync();
        Assert.Equal(0L, (long) count);
    }

    [Trait(Constants.SupportedOnEmulator, Constants.No)]
    [Fact]
    public async Task QueueIsLeftWithNoMessagesAfterDmlInsertThenDelete_CommandConstructor()
    {
        using var connection = _queueFixture.GetConnection();
        (string userId, string messageId) = (IdGenerator.FromGuid(), IdGenerator.FromGuid());

        // Insert Message via SpannerCommand string constructor
        using var insertCommand = new SpannerCommand(
            $"INSERT INTO {_queueFixture.QueueName} (UserId, MessageId, Payload) VALUES (@UserId, @MessageId, @Payload)",
            connection,
            parameters: ParametersForKeyAndPayload(userId, messageId, _payloadBytes));
        int insertedCount = await insertCommand.ExecuteNonQueryAsync();
        Assert.Equal(1, insertedCount);

        // Delete Message via SpannerCommand string constructor
        using var deleteCommand = new SpannerCommand(
            $"DELETE FROM {_queueFixture.QueueName} WHERE UserId = @UserId AND MessageId = @MessageId",
            connection,
            parameters: ParametersForKey(userId, messageId));
        int deletedCount = await deleteCommand.ExecuteNonQueryAsync();
        Assert.Equal(1, deletedCount);

        // Assert Queue is left with no messages after Delete
        using var selectCommand = connection.CreateSelectCommand($"SELECT COUNT(*) FROM {_queueFixture.QueueName};");
        var count = await selectCommand.ExecuteScalarAsync();
        Assert.Equal(0L, (long) count);
    }

    private static SpannerParameterCollection ParametersForKey(string str1, string str2)
        => new([
            new SpannerParameter("UserId", SpannerDbType.String, value: str1),
            new SpannerParameter("MessageId", SpannerDbType.String, value: str2),
        ]);

    private static SpannerParameter PayloadParameterForBytes(byte[] bytes)
        => new("Payload", SpannerDbType.Bytes, bytes);

    private static SpannerParameterCollection ParametersForKeyAndPayload(string str1, string str2, byte[] bytes)
        => [.. ParametersForKey(str1, str2), PayloadParameterForBytes(bytes)];
}
