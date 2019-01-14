// Copyright 2017, Google Inc. All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Xunit;
using static Google.Cloud.Firestore.Tests.ProtoHelpers;

namespace Google.Cloud.Firestore.Tests
{
    public class WriteResultTest
    {
        [Fact]
        public void FromProto_TimestampInProto()
        {
            var commitTime = CreateProtoTimestamp(20, 30);
            var proto = new V1.WriteResult { UpdateTime = CreateProtoTimestamp(10, 20) };
            var result = WriteResult.FromProto(proto, commitTime);
            Assert.Equal(new Timestamp(10, 20), result.UpdateTime);
        }

        [Fact]
        public void FromProto_TimestampNotInProto()
        {
            var commitTime = CreateProtoTimestamp(20, 30);
            var proto = new V1.WriteResult();
            var result = WriteResult.FromProto(proto, commitTime);
            Assert.Equal(new Timestamp(20, 30), result.UpdateTime);
        }
    }
}
