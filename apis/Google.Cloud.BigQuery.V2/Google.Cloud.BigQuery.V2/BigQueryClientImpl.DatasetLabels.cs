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

using Google.Api.Gax;
using Google.Apis.Bigquery.v2.Data;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.BigQuery.V2
{
    public partial class BigQueryClientImpl
    {
        // Convenience methods which delegate to ModifyDatasetLabels

        /// <inheritdoc />
        public override string RemoveDatasetLabel(DatasetReference datasetReference, string labelName, ModifyLabelsOptions options = null)
        {
            GaxPreconditions.CheckNotNull(datasetReference, nameof(DatasetReference));
            GaxPreconditions.CheckNotNull(labelName, nameof(labelName));
            var newLabels = new Dictionary<string, string> { [labelName] = null };
            var oldLabels = ModifyDatasetLabels(datasetReference, newLabels, options);
            return oldLabels[labelName];
        }

        /// <inheritdoc />
        public override async Task<string> RemoveDatasetLabelAsync(DatasetReference datasetReference, string labelName, ModifyLabelsOptions options = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            GaxPreconditions.CheckNotNull(datasetReference, nameof(DatasetReference));
            GaxPreconditions.CheckNotNull(labelName, nameof(labelName));
            var newLabels = new Dictionary<string, string> { [labelName] = null };
            var oldLabels = await ModifyDatasetLabelsAsync(datasetReference, newLabels, options, cancellationToken).ConfigureAwait(false);
            return oldLabels[labelName];
        }

        /// <inheritdoc />
        public override string SetDatasetLabel(DatasetReference datasetReference, string labelName, string labelValue, ModifyLabelsOptions options = null)
        {
            GaxPreconditions.CheckNotNull(datasetReference, nameof(DatasetReference));
            GaxPreconditions.CheckNotNull(labelName, nameof(labelName));
            GaxPreconditions.CheckNotNull(labelValue, nameof(labelValue));
            var newLabels = new Dictionary<string, string> { [labelName] = labelValue };
            var oldLabels = ModifyDatasetLabels(datasetReference, newLabels, options);
            return oldLabels[labelName];
        }

        /// <inheritdoc />
        public override async Task<string> SetDatasetLabelAsync(DatasetReference datasetReference, string labelName, string labelValue, ModifyLabelsOptions options = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            GaxPreconditions.CheckNotNull(datasetReference, nameof(DatasetReference));
            GaxPreconditions.CheckNotNull(labelName, nameof(labelName));
            GaxPreconditions.CheckNotNull(labelValue, nameof(labelValue));
            var newLabels = new Dictionary<string, string> { [labelName] = labelValue };
            var oldLabels = await ModifyDatasetLabelsAsync(datasetReference, newLabels, options, cancellationToken).ConfigureAwait(false);
            return oldLabels[labelName];
        }

        // Most of the work is done here...

        /// <inheritdoc />
        public override IDictionary<string, string> ModifyDatasetLabels(DatasetReference datasetReference, IDictionary<string, string> labels, ModifyLabelsOptions options = null)
        {
            GaxPreconditions.CheckNotNull(datasetReference, nameof(datasetReference));
            GaxPreconditions.CheckNotNull(labels, nameof(labels));

            int retries = options?.Retries ?? ModifyLabelsOptions.DefaultRetries;
            var getOptions = new GetDatasetOptions { ETag = options?.ETag };

            while (true)
            {
                // Outside the catch, as we don't need to retry if *this* fails the precondition.
                // If the dataset originally has the "right" version but then changes before we patch it, we'll end up retrying this
                // part as well, and it will immediately fail.
                var dataset = GetDataset(datasetReference, getOptions);
                try
                {
                    var existingLabels = dataset.Resource.Labels ?? new Dictionary<string, string>();

                    var differences = GetDifferences(labels, existingLabels);
                    // If everything's already as we want it to be, we don't need to patch.
                    if (differences.Count != 0)
                    {
                        dataset.Patch(new Dataset { Labels = differences }, matchETag: true);
                    }

                    var oldValues = new Dictionary<string, string>();
                    foreach (var entry in labels)
                    {
                        existingLabels.TryGetValue(entry.Key, out string existingValue);
                        oldValues[entry.Key] = existingValue; // May be null
                    }
                    return oldValues;
                }
                catch (GoogleApiException e) when (retries > 0 && e.HttpStatusCode == HttpStatusCode.PreconditionFailed)
                {
                    retries--;
                    // No delay here: we're only trying to catch the case where another change is made between Get/Patch.
                }
            }
        }

        /// <inheritdoc />
        public override async Task<IDictionary<string, string>> ModifyDatasetLabelsAsync(DatasetReference datasetReference, IDictionary<string, string> labels, ModifyLabelsOptions options = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            GaxPreconditions.CheckNotNull(datasetReference, nameof(datasetReference));
            GaxPreconditions.CheckNotNull(labels, nameof(labels));

            int retries = options?.Retries ?? ModifyLabelsOptions.DefaultRetries;
            var getOptions = new GetDatasetOptions { ETag = options?.ETag };

            while (true)
            {
                // Outside the catch, as we don't need to retry if *this* fails the precondition.
                // If the dataset originally has the "right" version but then changes before we patch it, we'll end up retrying this
                // part as well, and it will immediately fail.
                var dataset = await GetDatasetAsync(datasetReference, getOptions, cancellationToken).ConfigureAwait(false);
                try
                {
                    var existingLabels = dataset.Resource.Labels ?? new Dictionary<string, string>();

                    var differences = GetDifferences(labels, existingLabels);
                    // If everything's already as we want it to be, we don't need to patch.
                    if (differences.Count != 0)
                    {
                        await dataset.PatchAsync(new Dataset { Labels = differences }, matchETag: true, cancellationToken: cancellationToken).ConfigureAwait(false);
                    }

                    var oldValues = new Dictionary<string, string>();
                    foreach (var entry in labels)
                    {
                        existingLabels.TryGetValue(entry.Key, out string existingValue);
                        oldValues[entry.Key] = existingValue; // May be null
                    }
                    return oldValues;
                }
                catch (GoogleApiException e) when (retries > 0 && e.HttpStatusCode == HttpStatusCode.PreconditionFailed)
                {
                    retries--;
                    // No delay here: we're only trying to catch the case where another change is made between Get/Patch.
                }
            }
        }

        /// <inheritdoc />
        public override IDictionary<string, string> ClearDatasetLabels(DatasetReference datasetReference, ModifyLabelsOptions options = null)
        {
            GaxPreconditions.CheckNotNull(datasetReference, nameof(datasetReference));

            int retries = options?.Retries ?? ModifyLabelsOptions.DefaultRetries;
            var getOptions = new GetDatasetOptions { ETag = options?.ETag };

            while (true)
            {
                // Outside the catch, as we don't need to retry if *this* fails the precondition.
                // If the dataset originally has the "right" version but then changes before we patch it, we'll end up retrying this
                // part as well, and it will immediately fail.
                var dataset = GetDataset(datasetReference, getOptions);
                try
                {
                    var existingLabels = dataset.Resource.Labels;
                    if (existingLabels == null || existingLabels.Count == 0)
                    {
                        return new Dictionary<string, string>();
                    }
                    var labels = existingLabels.Keys.ToDictionary(key => key, key => (string)null);
                    dataset.Patch(new Dataset { Labels = labels }, matchETag: true);

                    return existingLabels;
                }
                catch (GoogleApiException e) when (retries > 0 && e.HttpStatusCode == HttpStatusCode.PreconditionFailed)
                {
                    retries--;
                    // No delay here: we're only trying to catch the case where another change is made between Get/Patch.
                }
            }
        }

        /// <inheritdoc />
        public override async Task<IDictionary<string, string>> ClearDatasetLabelsAsync(DatasetReference datasetReference, ModifyLabelsOptions options = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            GaxPreconditions.CheckNotNull(datasetReference, nameof(datasetReference));

            int retries = options?.Retries ?? ModifyLabelsOptions.DefaultRetries;
            var getOptions = new GetDatasetOptions { ETag = options?.ETag };

            while (true)
            {
                // Outside the catch, as we don't need to retry if *this* fails the precondition.
                // If the dataset originally has the "right" version but then changes before we patch it, we'll end up retrying this
                // part as well, and it will immediately fail.
                var dataset = await GetDatasetAsync(datasetReference, getOptions, cancellationToken).ConfigureAwait(false);
                try
                {
                    var existingLabels = dataset.Resource.Labels;
                    if (existingLabels == null || existingLabels.Count == 0)
                    {
                        return new Dictionary<string, string>();
                    }
                    var labels = existingLabels.Keys.ToDictionary(key => key, key => (string)null);
                    await dataset.PatchAsync(new Dataset { Labels = labels }, matchETag: true, cancellationToken: cancellationToken).ConfigureAwait(false);

                    return existingLabels;
                }
                catch (GoogleApiException e) when (retries > 0 && e.HttpStatusCode == HttpStatusCode.PreconditionFailed)
                {
                    retries--;
                    // No delay here: we're only trying to catch the case where another change is made between Get/Patch.
                }
            }
        }

        private static IDictionary<string, string> GetDifferences(IDictionary<string, string> requested, IDictionary<string, string> existing)
        {
            // The handling of null values makes it trickier to do this with LINQ.
            var result = new Dictionary<string, string>();
            foreach (var pair in requested)
            {
                existing.TryGetValue(pair.Key, out string existingValue);
                if (pair.Value != existingValue)
                {
                    result[pair.Key] = pair.Value;
                }
            }
            return result;
        }
    }
}
