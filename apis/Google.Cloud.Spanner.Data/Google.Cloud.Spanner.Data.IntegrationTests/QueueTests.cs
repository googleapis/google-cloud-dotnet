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

[Collection(nameof(SpannerQueueFixture))]
public class QueueTests
{
    private readonly SpannerQueueFixture _queueFixture;

    public QueueTests(SpannerQueueFixture queueFixture) => _queueFixture = queueFixture;

    private static readonly byte[] s_payloadBytes = Encoding.UTF8.GetBytes("Hello, World");

    [Trait(Constants.SupportedOnEmulator, Constants.No)]
    [Fact(Skip = "b/571556192")]
    public async Task SendsAndAcksMessageToQueue_Mutations()
    {
        using var connection = _queueFixture.GetConnection();
        (string userId, string messageId) = (IdGenerator.FromGuid(), IdGenerator.FromGuid());

        // Send Message
        using var sendCommand = connection.CreateSendCommand(_queueFixture.QueueName, ParametersForKeyAndPayload(userId, messageId, s_payloadBytes));
        int affected = await sendCommand.ExecuteNonQueryAsync();
        Assert.Equal(1, affected);

        // Ack messages
        var ackCommand = connection.CreateAckCommand(_queueFixture.QueueName, ParametersForKey(userId, messageId));
        affected = await ackCommand.ExecuteNonQueryAsync();
        Assert.Equal(1, affected);
    }

    [Trait(Constants.SupportedOnEmulator, Constants.No)]
    [Fact(Skip = "b/571556192")]
    public async Task SendsAndAcksMessageToQueue_CommandConstructor()
    {
        using var connection = _queueFixture.GetConnection();
        (string userId, string messageId) = (IdGenerator.FromGuid(), IdGenerator.FromGuid());

        // Insert Message via SpannerCommand string constructor
        using var insertCommand = new SpannerCommand(
            $"INSERT INTO {_queueFixture.QueueName} (UserId, MessageId, Payload) VALUES (@UserId, @MessageId, @Payload)",
            connection,
            parameters: ParametersForKeyAndPayload(userId, messageId, s_payloadBytes));
        int insertedCount = await insertCommand.ExecuteNonQueryAsync();
        Assert.Equal(1, insertedCount);

        // Delete Message via SpannerCommand string constructor
        using var deleteCommand = new SpannerCommand(
            $"DELETE FROM {_queueFixture.QueueName} WHERE UserId = @UserId AND MessageId = @MessageId",
            connection,
            parameters: ParametersForKey(userId, messageId));
        int deletedCount = await deleteCommand.ExecuteNonQueryAsync();
        Assert.Equal(1, deletedCount);
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
