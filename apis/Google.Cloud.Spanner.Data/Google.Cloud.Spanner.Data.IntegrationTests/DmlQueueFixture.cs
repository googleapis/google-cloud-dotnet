// Copyright 2026 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
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
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Xunit;

namespace Google.Cloud.Spanner.Data.IntegrationTests
{
    [CollectionDefinition(nameof(DmlQueueFixture))]
    public class DmlQueueFixture : SpannerQueueFixture, ICollectionFixture<DmlQueueFixture>
    {
        public DmlQueueFixture() : base("DmlTest")
        {
        }

        protected override void CreateQueue() =>
            ExecuteDdl($@"CREATE QUEUE {QueueName} (
                UserId        INT64 NOT NULL,
                MessageId     INT64 NOT NULL,
                Payload       BYTES(MAX) NOT NULL,
                ) PRIMARY KEY(UserId, MessageId),
                OPTIONS(receive_mode= ""PULL"")");
    }
}
