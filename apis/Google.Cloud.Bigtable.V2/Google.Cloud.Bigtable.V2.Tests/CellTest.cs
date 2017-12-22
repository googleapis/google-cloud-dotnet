// Copyright 2017 Google Inc. All rights reserved.
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

namespace Google.Cloud.Bigtable.V2.Tests
{
    public class CellTest
    {
        [Theory]
        [InlineData(1000)]
        [InlineData(long.MaxValue)]
        public void Version(long micros)
        {
            var cell = new Cell { TimestampMicros = micros };
            Assert.Equal(micros, cell.Version.Micros);
            Assert.Equal(micros / 1000, cell.Version.Value);
        }
    }
}
