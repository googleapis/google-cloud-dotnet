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
using Google.Apis.Storage.v1.Data;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using System;

namespace Google.Cloud.Storage.V1
{
    public sealed partial class StorageClientImpl
    {
        /// <inheritdoc />
        public override IDictionary<string, string> ModifyBucketLabels(string bucket, IDictionary<string, string> labels, ModifyBucketLabelsOptions options = null)
        {
            ValidateBucketName(bucket);
            GaxPreconditions.CheckNotNull(labels, nameof(labels));

            int retries = options?.Retries ?? ModifyBucketLabelsOptions.DefaultRetries;
            var getOptions = new GetBucketOptions { IfMetagenerationMatch = options?.IfMetagenerationMatch };

            while (true)
            {
                // Outside the catch, as we don't need to retry if *this* fails the precondition.
                // If the bucket originally has the "right" version but then changes before we patch it, we'll end up retrying this
                // part as well, and it will immediately fail.
                var bucketMetadata = GetBucket(bucket, getOptions);
                try
                {
                    var existingLabels = bucketMetadata.Labels ?? new Dictionary<string, string>();

                    var differences = GetDifferences(labels, existingLabels);
                    // If everything's already as we want it to be, we don't need to patch.
                    if (differences.Count != 0)
                    {
                        var patchOptions = new PatchBucketOptions { IfMetagenerationMatch = bucketMetadata.Metageneration };
                        PatchBucket(new Bucket { Name = bucketMetadata.Name, Labels = differences }, patchOptions);
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
        public override IDictionary<string, string> ClearBucketLabels(string bucket, ModifyBucketLabelsOptions options = null)
        {
            ValidateBucketName(bucket);

            int retries = options?.Retries ?? ModifyBucketLabelsOptions.DefaultRetries;
            var getOptions = new GetBucketOptions { IfMetagenerationMatch = options?.IfMetagenerationMatch };

            while (true)
            {
                // Outside the catch, as we don't need to retry if *this* fails the precondition.
                // If the bucket originally has the "right" version but then changes before we patch it, we'll end up retrying this
                // part as well, and it will immediately fail.
                var bucketMetadata = GetBucket(bucket, getOptions);
                try
                {
                    var existingLabels = bucketMetadata.Labels;
                    if (existingLabels == null || existingLabels.Count == 0)
                    {
                        return new Dictionary<string, string>();
                    }
                    var patchOptions = new PatchBucketOptions { IfMetagenerationMatch = bucketMetadata.Metageneration };

                    var labels = existingLabels.Keys.ToDictionary(key => key, key => (string) null);
                    PatchBucket(new Bucket { Name = bucketMetadata.Name, Labels = labels }, patchOptions);

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
        public override async Task<IDictionary<string, string>> ModifyBucketLabelsAsync(string bucket, IDictionary<string, string> labels, ModifyBucketLabelsOptions options = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            ValidateBucketName(bucket);
            GaxPreconditions.CheckNotNull(labels, nameof(labels));

            int retries = options?.Retries ?? ModifyBucketLabelsOptions.DefaultRetries;
            var getOptions = new GetBucketOptions { IfMetagenerationMatch = options?.IfMetagenerationMatch };

            while (true)
            {
                // Outside the catch, as we don't need to retry if *this* fails the precondition.
                // If the bucket originally has the "right" version but then changes before we patch it, we'll end up retrying this
                // part as well, and it will immediately fail.
                var bucketMetadata = await GetBucketAsync(bucket, getOptions, cancellationToken).ConfigureAwait(false);
                try
                {
                    var existingLabels = bucketMetadata.Labels ?? new Dictionary<string, string>();

                    var differences = GetDifferences(labels, existingLabels);
                    // If everything's already as we want it to be, we don't need to patch.
                    if (differences.Count != 0)
                    {
                        var patchOptions = new PatchBucketOptions { IfMetagenerationMatch = bucketMetadata.Metageneration };
                        await PatchBucketAsync(new Bucket { Name = bucketMetadata.Name, Labels = differences }, patchOptions, cancellationToken).ConfigureAwait(false);
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
        public override async Task<IDictionary<string, string>> ClearBucketLabelsAsync(string bucket, ModifyBucketLabelsOptions options = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            ValidateBucketName(bucket);

            int retries = options?.Retries ?? ModifyBucketLabelsOptions.DefaultRetries;
            var getOptions = new GetBucketOptions { IfMetagenerationMatch = options?.IfMetagenerationMatch };

            while (true)
            {
                // Outside the catch, as we don't need to retry if *this* fails the precondition.
                // If the bucket originally has the "right" version but then changes before we patch it, we'll end up retrying this
                // part as well, and it will immediately fail.
                var bucketMetadata = await GetBucketAsync(bucket, getOptions, cancellationToken).ConfigureAwait(false);
                try
                {
                    var existingLabels = bucketMetadata.Labels;
                    if (existingLabels == null || existingLabels.Count == 0)
                    {
                        return new Dictionary<string, string>();
                    }
                    var patchOptions = new PatchBucketOptions { IfMetagenerationMatch = bucketMetadata.Metageneration };

                    var labels = existingLabels.Keys.ToDictionary(key => key, key => (string)null);
                    await PatchBucketAsync(new Bucket { Name = bucketMetadata.Name, Labels = labels }, patchOptions, cancellationToken).ConfigureAwait(false);

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
