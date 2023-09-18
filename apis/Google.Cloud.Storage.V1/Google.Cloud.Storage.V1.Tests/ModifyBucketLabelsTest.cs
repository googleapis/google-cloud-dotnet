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

using NSubstitute;
using NSubstitute.Extensions;
using System.Collections.Generic;
using System.Linq;
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
            var mock = Substitute.ForPartsOf<StorageClient>();
            mock.Configure().ModifyBucketLabels(bucketName, CreateMatcher(key, newValue), options)
                .Returns(new Dictionary<string, string> { { key, oldValue } });

            var actual = mock.SetBucketLabel(bucketName, key, newValue, options);
            Assert.Equal(oldValue, actual);
            mock.Received(1).ModifyBucketLabels(bucketName, CreateMatcher(key, newValue), options);
        }

        [Fact]
        public void RemoveLabel()
        {
            var bucketName = "bucket";
            var key = "key";
            var options = new ModifyBucketLabelsOptions();
            var mock = Substitute.ForPartsOf<StorageClient>();
            mock.Configure().ModifyBucketLabels(bucketName, CreateMatcher(key, null), options)
                .Returns(new Dictionary<string, string> { { key, null } });

            var actual = mock.RemoveBucketLabel(bucketName, key, options);
            Assert.Null(actual);
            mock.Received(1).ModifyBucketLabels(bucketName, CreateMatcher(key, null), options);
        }

        [Fact]
        public async Task SetLabelAsync()
        {
            var bucketName = "bucket";
            var key = "key";
            var oldValue = "old-value";
            var newValue = "new-value";
            var options = new ModifyBucketLabelsOptions();
            var token = new CancellationTokenSource().Token;
            var mock = Substitute.ForPartsOf<StorageClient>();
            mock.Configure().ModifyBucketLabelsAsync(bucketName, CreateMatcher(key, newValue), options, token)
                .Returns(Task.FromResult<IDictionary<string, string>>(new Dictionary<string, string> { { key, oldValue } }));

            // The task should already have completed, but it's simplest just to await it to prevent xUnit complaining.
            var actual = await mock.SetBucketLabelAsync(bucketName, key, newValue, options, token);
            Assert.Equal(oldValue, actual);
            _ = mock.Received(1).ModifyBucketLabelsAsync(bucketName, CreateMatcher(key, newValue), options, token);
        }

        [Fact]
        public async Task RemoveLabelAsync()
        {
            var bucketName = "bucket";
            var key = "key";
            var options = new ModifyBucketLabelsOptions();
            var token = new CancellationTokenSource().Token;
            var mock = Substitute.ForPartsOf<StorageClient>();
            mock.Configure().ModifyBucketLabelsAsync(bucketName, CreateMatcher(key, null), options, token)
                .Returns(Task.FromResult<IDictionary<string, string>>(new Dictionary<string, string> { { "key", null } }));

            // The task should already have completed, but it's simplest just to await it to prevent xUnit complaining.
            var actual = await mock.RemoveBucketLabelAsync(bucketName, key, options, token);
            Assert.Null(actual);
            _ = mock.Received(1).ModifyBucketLabelsAsync(bucketName, CreateMatcher(key, null), options, token);
        }

        // This is more awkward than it *looks* like it should be, due to Arg.Is accepting an expression tree not a delegate.
        private Dictionary<string, string> CreateMatcher(string key, string value) =>
            Arg.Is<Dictionary<string, string>>(dict => DictionaryMatches(dict, key, value));

        private bool DictionaryMatches(Dictionary<string, string> dict, string key, string value) =>
                dict.Count == 1 && dict.Keys.Single() == key && dict.Values.Single() == value;
    }
}
