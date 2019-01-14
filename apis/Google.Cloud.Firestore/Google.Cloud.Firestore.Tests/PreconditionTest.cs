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
    public class PreconditionTest
    {
        [Fact]
        public void None()
        {
            var precondition = Precondition.None;
            Assert.Null(precondition.Exists);
            Assert.Null(precondition.LastUpdateTime);
            Assert.Null(precondition.Proto);
        }

        [Fact]
        public void MustExist()
        {
            var precondition = Precondition.MustExist;
            Assert.True(precondition.Exists);
            Assert.Null(precondition.LastUpdateTime);
            Assert.Equal(new V1.Precondition { Exists = true }, precondition.Proto);
        }

        [Fact]
        public void MustNotExist()
        {
            var precondition = Precondition.MustNotExist;
            Assert.False(precondition.Exists);
            Assert.Null(precondition.LastUpdateTime);
            Assert.Equal(new V1.Precondition { Exists = false }, precondition.Proto);
        }

        [Fact]
        public void LastUpdated()
        {
            var timestamp = new Timestamp(1, 5);
            var precondition = Precondition.LastUpdated(timestamp);
            Assert.Null(precondition.Exists);
            Assert.Equal(timestamp, precondition.LastUpdateTime);
            Assert.Equal(new V1.Precondition { UpdateTime = CreateProtoTimestamp(1, 5) }, precondition.Proto);
        }        
    }
}
