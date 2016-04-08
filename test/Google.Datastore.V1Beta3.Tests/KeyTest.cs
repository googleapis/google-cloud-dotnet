// Copyright 2016 Google Inc
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//      http: *www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Xunit;

namespace Google.Datastore.V1Beta3.Tests
{
    public class KeyTest
    {
        [Fact]
        public void ToDelete()
        {
            // Not actually a valid key, as there are no path elements, but we're not doing full
            // validation.
            var key = new Key { PartitionId = new PartitionId { ProjectId = "project" } };
            Assert.Equal(new Mutation { Delete = key }, key.ToDelete());
        }
    }
}
