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

using Google.Apis.Http;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.BigQuery.V2.IntegrationTests
{
    [Collection(nameof(BigQueryFixture))]
    public class DatasetsLabelsTest
    {
        private readonly BigQueryFixture _fixture;

        public DatasetsLabelsTest(BigQueryFixture fixture)
        {
            _fixture = fixture;
        }

        [Theory]
        [InlineData(false)]
        [InlineData(true)]
        public void ModifyDatasetLabels_Simple(bool runAsync)
        {
            // Test several things:
            // - lab1: Existing label not mentioned in the request
            // - lab2: Existing label with same value in request
            // - lab3: Existing label with different value in request
            // - lab4: Existing label to be deleted in request
            // - lab5: New label in request
            // - lab6: Non-existent label to be deleted in request
            var client = BigQueryClient.Create(_fixture.ProjectId);
            var datasetId = _fixture.LabelsDatasetId;
            _fixture.SetUpLabels(new Dictionary<string, string> { ["lab1"] = "o1", ["lab2"] = "o2", ["lab3"] = "o3", ["lab4"] = "o4" });

            var newLabels = new Dictionary<string, string>
            {
                ["lab2"] = "o2", // Same value
                ["lab3"] = "n3", // New value
                ["lab4"] = null, // To be deleted
                ["lab5"] = "n5", // Didn't exist
                ["lab6"] = null, // Didn't exist, would delete if it did
            };

            var result = RunMaybeAsync(runAsync,
                () => client.ModifyDatasetLabels(datasetId, newLabels),
                () => client.ModifyDatasetLabelsAsync(datasetId, newLabels));

            var expectedResult = new Dictionary<string, string>
            {
                ["lab2"] = "o2",
                ["lab3"] = "o3",
                ["lab4"] = "o4",
                ["lab5"] = null,
                ["lab6"] = null,
            };

            Assert.Equal(expectedResult, result);

            var finalLabels = client.GetDataset(datasetId).Resource.Labels;
            var expectedFinalLabels = new Dictionary<string, string>
            {
                ["lab1"] = "o1",
                ["lab2"] = "o2",
                ["lab3"] = "n3",
                ["lab5"] = "n5",
            };

            Assert.Equal(expectedFinalLabels, finalLabels);
        }

        [Theory]
        [InlineData(false)]
        [InlineData(true)]
        public void ClearDatasetLabels_Simple(bool runAsync)
        {
            var client = BigQueryClient.Create(_fixture.ProjectId);
            var datasetId = _fixture.LabelsDatasetId;
            _fixture.SetUpLabels(new Dictionary<string, string> { ["lab1"] = "o1", ["lab2"] = "o2" });

            var previousLabels = RunMaybeAsync(runAsync,
                () => client.ClearDatasetLabels(datasetId),
                () => client.ClearDatasetLabelsAsync(datasetId));
            var expected = new Dictionary<string, string> { ["lab1"] = "o1", ["lab2"] = "o2" };
            Assert.Equal(expected, previousLabels);

            var finalLabels = client.GetDataset(datasetId).Resource.Labels;
            Assert.Null(finalLabels);
        }

        [Theory]
        [InlineData(false)]
        [InlineData(true)]
        public void ModifyDatasetLabels_RetrySucceeds(bool runAsync)
        {
            var evilClient = BigQueryClient.Create(_fixture.ProjectId);
            var independentClient = BigQueryClient.Create(_fixture.ProjectId);
            var datasetId = _fixture.LabelsDatasetId;
            _fixture.SetUpLabels(new Dictionary<string, string> { { "label", "before" } });

            // Just before the "set-it-to-after" patch call is made, we modify the label ourselves,
            // which will change the metageneration and cause a conflict response to the patch.
            // We only do this twice though - on the third time, the read/modify/write cycle will work
            // - but we'll be able to tell that it *did* intercept twice, as the "old" value will be
            // the one set by the final intercept.
            var interceptor = new PatchFoilingInterceptor(2, count => independentClient.SetDatasetLabel(datasetId, "label", $"intercept{count}"));
            evilClient.Service.HttpClient.MessageHandler.AddExecuteInterceptor(interceptor);

            var options = new ModifyLabelsOptions { Retries = 2 };
            var result = RunMaybeAsync(runAsync,
                () => evilClient.SetDatasetLabel(datasetId, "label", "after", options),
                () => evilClient.SetDatasetLabelAsync(datasetId, "label", "after", options));
            Assert.Equal("intercept2", result);

            var finalLabels = independentClient.GetDataset(datasetId).Resource.Labels;
            Assert.Equal("after", finalLabels["label"]);
        }

        [Theory]
        [InlineData(false)]
        [InlineData(true)]
        public void ModifyDatasetLabels_RetryFails(bool runAsync)
        {
            var evilClient = BigQueryClient.Create(_fixture.ProjectId);
            var independentClient = BigQueryClient.Create(_fixture.ProjectId);
            var datasetId = _fixture.LabelsDatasetId;
            _fixture.SetUpLabels(new Dictionary<string, string> { { "label", "before" } });

            // Just before the "set-it-to-after" patch call is made, we modify the label ourselves,
            // which will change the metageneration and cause a conflict response to the patch.
            // We do this three times - which is why the overall result is failure.
            var interceptor = new PatchFoilingInterceptor(3, count => independentClient.SetDatasetLabel(datasetId, "label", $"intercept{count}"));
            evilClient.Service.HttpClient.MessageHandler.AddExecuteInterceptor(interceptor);

            var options = new ModifyLabelsOptions { Retries = 2 };
            var exception = AssertThrowsMaybeAsync<GoogleApiException>(runAsync,
                () => evilClient.SetDatasetLabel(datasetId, "label", "after", options),
                () => evilClient.SetDatasetLabelAsync(datasetId, "label", "after", options));
            Assert.Equal(HttpStatusCode.PreconditionFailed, exception.HttpStatusCode);
        }

        [Theory]
        [InlineData(false)]
        [InlineData(true)]
        public void ModifyDatasetLabels_ExplicitPreconditionFail(bool runAsync)
        {
            var client = BigQueryClient.Create(_fixture.ProjectId);
            var datasetId = _fixture.LabelsDatasetId;
            var dataset = client.GetDataset(datasetId);

            var options = new ModifyLabelsOptions { ETag = "wrong-" + dataset.Resource.ETag };
            var exception = AssertThrowsMaybeAsync<GoogleApiException>(runAsync,
                () => client.SetDatasetLabel(datasetId, "label", "value", options),
                () => client.SetDatasetLabelAsync(datasetId, "label", "value", options));
            Assert.Equal(HttpStatusCode.PreconditionFailed, exception.HttpStatusCode);
        }

        [Theory]
        [InlineData(false)]
        [InlineData(true)]
        public void ClearDatasetLabels_RetrySucceeds(bool runAsync)
        {
            var evilClient = BigQueryClient.Create(_fixture.ProjectId);
            var independentClient = BigQueryClient.Create(_fixture.ProjectId);
            var datasetId = _fixture.LabelsDatasetId;
            _fixture.SetUpLabels(new Dictionary<string, string> { { "label", "before" } });

            // Just before the "set-it-to-after" patch call is made, we modify the label ourselves,
            // which will change the metageneration and cause a conflict response to the patch.
            // We only do this twice though - on the third time, the read/modify/write cycle will work
            // - but we'll be able to tell that it *did* intercept twice, as the "old" value will be
            // the one set by the final intercept.
            var interceptor = new PatchFoilingInterceptor(2, count => independentClient.SetDatasetLabel(datasetId, "label", $"intercept{count}"));
            evilClient.Service.HttpClient.MessageHandler.AddExecuteInterceptor(interceptor);

            var options = new ModifyLabelsOptions { Retries = 2 };
            var result = RunMaybeAsync(runAsync,
                () => evilClient.ClearDatasetLabels(datasetId, options),
                () => evilClient.ClearDatasetLabelsAsync(datasetId, options));
            Assert.Equal(new Dictionary<string, string> { { "label", "intercept2" } }, result);

            Assert.Null(independentClient.GetDataset(datasetId).Resource.Labels);
        }

        [Theory]
        [InlineData(false)]
        [InlineData(true)]
        public void ClearDatasetLabels_RetryFails(bool runAsync)
        {
            var evilClient = BigQueryClient.Create(_fixture.ProjectId);
            var independentClient = BigQueryClient.Create(_fixture.ProjectId);
            var datasetId = _fixture.LabelsDatasetId;
            _fixture.SetUpLabels(new Dictionary<string, string> { { "label", "before" } });

            // Just before the "set-it-to-after" patch call is made, we modify the label ourselves,
            // which will change the metageneration and cause a conflict response to the patch.
            // We do this three times - which is why the overall result is failure.
            var interceptor = new PatchFoilingInterceptor(3, count => independentClient.SetDatasetLabel(datasetId, "label", $"intercept{count}"));
            evilClient.Service.HttpClient.MessageHandler.AddExecuteInterceptor(interceptor);

            var options = new ModifyLabelsOptions { Retries = 2 };
            var exception = AssertThrowsMaybeAsync<GoogleApiException>(runAsync,
                () => evilClient.ClearDatasetLabels(datasetId, options),
                () => evilClient.ClearDatasetLabelsAsync(datasetId, options));

            Assert.Equal(HttpStatusCode.PreconditionFailed, exception.HttpStatusCode);
        }

        [Theory]
        [InlineData(false)]
        [InlineData(true)]
        public void ClearDatasetLabels_ExplicitPreconditionFail(bool runAsync)
        {
            var client = BigQueryClient.Create(_fixture.ProjectId);
            var datasetId = _fixture.LabelsDatasetId;
            var dataset = client.GetDataset(datasetId);

            var options = new ModifyLabelsOptions { ETag = "wrong-" + dataset.Resource.ETag };
            var exception = AssertThrowsMaybeAsync<GoogleApiException>(runAsync,
                () => client.ClearDatasetLabels(datasetId, options),
                () => client.ClearDatasetLabelsAsync(datasetId, options));
            Assert.Equal(HttpStatusCode.PreconditionFailed, exception.HttpStatusCode);
        }

        [Theory]
        [InlineData(false)]
        [InlineData(true)]
        public void RemoveDatasetLabel_NoLabelsBefore(bool runAsync)
        {
            var client = BigQueryClient.Create(_fixture.ProjectId);
            var datasetId = _fixture.LabelsDatasetId;
            client.ClearDatasetLabels(datasetId);
            var result = RunMaybeAsync(runAsync,
                () => client.RemoveDatasetLabel(datasetId, "label"),
                () => client.RemoveDatasetLabelAsync(datasetId, "label"));
            Assert.Null(result);
        }

        [Theory]
        [InlineData(false)]
        [InlineData(true)]
        public void ClearDatasetLabels_NoLabelsBefore(bool runAsync)
        {
            var client = BigQueryClient.Create(_fixture.ProjectId);
            var datasetId = _fixture.LabelsDatasetId;
            client.ClearDatasetLabels(datasetId);
            var result = RunMaybeAsync(runAsync,
                () => client.ClearDatasetLabels(datasetId),
                () => client.ClearDatasetLabelsAsync(datasetId));
            Assert.Empty(result);
        }

        // TODO: Move these somewhere common, if this proves a useful pattern.
        private static T RunMaybeAsync<T>(bool runAsync, Func<T> sync, Func<Task<T>> async)
            // Run the async func separately to explicitly avoid synchronization etc.
            => runAsync ? Task.Run(() => async().Result).Result : sync();

        private static TException AssertThrowsMaybeAsync<TException>(bool runAsync, Action sync, Func<Task> async)
            where TException : Exception =>
            runAsync
                ? Task.Run(() => Assert.ThrowsAsync<TException>(async).Result).Result
                : Assert.Throws<TException>(sync);

        private class PatchFoilingInterceptor : IHttpExecuteInterceptor
        {
            private int interceptCount;
            private readonly int maxIntercepts;
            private readonly Action<int> action;

            public PatchFoilingInterceptor(int maxIntercepts, Action<int> action)
            {
                this.maxIntercepts = maxIntercepts;
                this.action = action;
            }

            public Task InterceptAsync(HttpRequestMessage request, CancellationToken cancellationToken)
            {
                if (request.Method.Method == "PATCH" && interceptCount < maxIntercepts)
                {
                    interceptCount++;
                    // Avoid quota issues.
                    Thread.Sleep(2500);
                    action(interceptCount);
                }
                return Task.FromResult(0);
            }
        }
    }
}
