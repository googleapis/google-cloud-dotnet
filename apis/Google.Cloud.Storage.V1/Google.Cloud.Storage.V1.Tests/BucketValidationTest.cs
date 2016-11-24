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

namespace Google.Cloud.Storage.V1.Tests
{
    public class BucketValidationTest
    {
        [Theory]
        [InlineData("justtext")]
        [InlineData("dots.dashes-and_underscores")]
        [InlineData("numbers012346789")]
        public void ValidBucketNames(string bucket)
        {
            StorageClientImpl.ValidateBucketName(bucket);
        }

        [Theory]
        [InlineData("")]
        [InlineData("UPPERCASE")]
        [InlineData("spaces in name")]
        [InlineData("invalid-punctuation1!")]
        [InlineData("invalid-punctuation2/")]
        [InlineData("invalid-punctuation3\\")]
        [InlineData("invalid-punctuation4\"")]
        [InlineData("invalid-punctuation5$")]
        [InlineData("invalid-punctuation6%")]
        public void InvalidBucketNames(string bucket)
        {
            var exception = Assert.ThrowsAny<ArgumentException>(() => StorageClientImpl.ValidateBucketName(bucket));
            Assert.Equal("bucket", exception.ParamName);
            Assert.Contains(bucket, exception.Message);
        }
    }
}
