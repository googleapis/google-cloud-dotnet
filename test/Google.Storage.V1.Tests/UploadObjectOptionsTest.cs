// Copyright 2015 Google Inc. All Rights Reserved.
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

using System;
using Xunit;

namespace Google.Storage.V1.Tests
{
    public class UploadObjectOptionsTest
    {
        [Theory]
        [InlineData(UploadObjectOptions.MinimumChunkSize)]
        [InlineData(UploadObjectOptions.MinimumChunkSize * 2)]
        [InlineData(UploadObjectOptions.MinimumChunkSize * 1000)]
        public void ValidChunkSize(int chunkSize)
        {
            // ToString call used as a constructor call isn't a statement expression
            new UploadObjectOptions { ChunkSize = chunkSize }.ToString();
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-UploadObjectOptions.MinimumChunkSize)]
        [InlineData(UploadObjectOptions.MinimumChunkSize / 2)]
        public void InvalidChunkSize(int chunkSize)
        {
            // ToString call used as a constructor call isn't a statement expression
            Assert.Throws<ArgumentException>(() => new UploadObjectOptions { ChunkSize = chunkSize }.ToString());
        }
    }
}
