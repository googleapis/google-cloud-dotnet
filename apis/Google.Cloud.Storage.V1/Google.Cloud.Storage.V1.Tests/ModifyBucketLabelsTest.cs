// Copyright 2017 Google Inc. All Rights Reserved.
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

using Moq;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Storage.V1.Tests
{
    public class ModifyBucketLabelsTest
    {
        [Fact]
        public void SetLabel()
        {
            var bucketName = "bucket";
            var key = "key";
            var oldValue = "old-value";
            var newValue = "new-value";
            var options = new ModifyBucketLabelsOptions();
            var mock = new Mock<StorageClient> { CallBase = true };
            mock.Setup(obj => obj.ModifyBucketLabels(bucketName, new Dictionary<string, string> { { key, newValue } }, options))
                .Returns(new Dictionary<string, string> { { key, oldValue } });

            var actual = mock.Object.SetBucketLabel(bucketName, key, newValue, options);
            Assert.Equal(oldValue, actual);
            mock.VerifyAll();
        }

        [Fact]
        public void RemoveLabel()
        {
            var bucketName = "bucket";
            var key = "key";
            var options = new ModifyBucketLabelsOptions();
            var mock = new Mock<StorageClient> { CallBase = true };
            mock.Setup(obj => obj.ModifyBucketLabels(bucketName, new Dictionary<string, string> { { key, null } }, options))
                .Returns(new Dictionary<string, string> { { key, null } });

            var actual = mock.Object.RemoveBucketLabel(bucketName, key, options);
            Assert.Null(actual);
            mock.VerifyAll();
        }

        [Fact]
        public void SetLabelAsync()
        {
            var bucketName = "bucket";
            var key = "key";
            var oldValue = "old-value";
            var newValue = "new-value";
            var options = new ModifyBucketLabelsOptions();
            var token = new CancellationTokenSource().Token;
            var mock = new Mock<StorageClient> { CallBase = true };
            mock.Setup(obj => obj.ModifyBucketLabelsAsync(bucketName, new Dictionary<string, string> { { key, newValue } }, options, token))
                .Returns(Task.FromResult<IDictionary<string, string>>(new Dictionary<string, string> { { key, oldValue } }));

            var actual = mock.Object.SetBucketLabelAsync(bucketName, key, newValue, options, token).Result;
            Assert.Equal(oldValue, actual);
            mock.VerifyAll();
        }

        [Fact]
        public void RemoveLabelAsync()
        {
            var bucketName = "bucket";
            var key = "key";
            var options = new ModifyBucketLabelsOptions();
            var token = new CancellationTokenSource().Token;
            var mock = new Mock<StorageClient> { CallBase = true };
            mock.Setup(obj => obj.ModifyBucketLabelsAsync(bucketName, new Dictionary<string, string> { { "key", null } }, options, token))
                .Returns(Task.FromResult<IDictionary<string, string>>(new Dictionary<string, string> { { "key", null } }));

            var actual = mock.Object.RemoveBucketLabelAsync(bucketName, key, options, token).Result;
            Assert.Null(actual);
            mock.VerifyAll();
        }
    }
}
