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
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.Storage.V1
{
    public abstract partial class StorageClient
    {
        /// <summary>
        /// Sets the value for a single label on a bucket. The label will be added if it does
        /// not exist, or updated if it already exists.
        /// </summary>
        /// <remarks>
        /// This method is implemented by creating a single-element dictionary which is passed to
        /// <see cref="ModifyBucketLabels(string, IDictionary{string, string}, ModifyBucketLabelsOptions)"/>.
        /// </remarks>
        /// <param name="bucket">The name of the bucket. Must not be null.</param>
        /// <param name="labelName">The name of the label to set. Must not be null.</param>
        /// <param name="labelValue">The value of the label to set. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <returns>The previous value of the label, or null if the label did not previously exist.</returns>
        public virtual string SetBucketLabel(string bucket, string labelName, string labelValue, ModifyBucketLabelsOptions options = null)
        {
            StorageClientImpl.ValidateBucketName(bucket);
            GaxPreconditions.CheckNotNull(labelName, nameof(labelName));
            GaxPreconditions.CheckNotNull(labelValue, nameof(labelValue));
            var newLabels = new Dictionary<string, string> { [labelName] = labelValue };
            var oldLabels = ModifyBucketLabels(bucket, newLabels, options);
            return oldLabels[labelName];
        }

        /// <summary>
        /// Removes a label from a bucket, if it previously existed. It is not an error to
        /// attempt to remove a label that doesn't already exist.
        /// </summary>
        /// <remarks>
        /// This method is implemented by creating a single-element dictionary which is passed to
        /// <see cref="ModifyBucketLabels(string, IDictionary{string, string}, ModifyBucketLabelsOptions)"/>.
        /// </remarks>
        /// <param name="bucket">The name of the bucket. Must not be null.</param>
        /// <param name="labelName">The name of the label to remove. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <returns>The previous value of the label, or null if the label did not previously exist.</returns>
        public virtual string RemoveBucketLabel(string bucket, string labelName, ModifyBucketLabelsOptions options = null)
        {
            StorageClientImpl.ValidateBucketName(bucket);
            GaxPreconditions.CheckNotNull(labelName, nameof(labelName));
            var newLabels = new Dictionary<string, string> { [labelName] = null };
            var oldLabels = ModifyBucketLabels(bucket, newLabels, options);
            return oldLabels[labelName];
        }

        /// <summary>
        /// Sets or removes one or more labels on a bucket.
        /// </summary>
        /// <remarks>
        /// Each entry in <paramref name="labels"/> is treated as a label to set or remove. If the value is null,
        /// it will be removed from the bucket; otherwise, it will be set/added. Labels which do not have an entry
        /// in the dictionary will be ignored.
        /// </remarks>
        /// <param name="bucket">The name of the bucket. Must not be null.</param>
        /// <param name="labels">The labels to set. Must contain at least one entry; keys must not be null, but values
        /// may be (indicating label removal).</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <returns>A dictionary with the same keys as <paramref name="labels"/>, and values indicating the corresponding label value
        /// before this operation completed. Labels which weren't present on the bucket before the modification have corresponding
        /// null values in the returned dictionary.</returns>
        public virtual IDictionary<string, string> ModifyBucketLabels(string bucket, IDictionary<string, string> labels, ModifyBucketLabelsOptions options = null) =>
            throw new NotImplementedException();

        /// <summary>
        /// Clears all labels on a bucket.
        /// </summary>
        /// <param name="bucket">The name of the bucket. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <returns>A dictionary with the labels on the bucket before they were cleared.</returns>
        public virtual IDictionary<string, string> ClearBucketLabels(string bucket, ModifyBucketLabelsOptions options = null) =>
            throw new NotImplementedException();

        /// <summary>
        /// Sets the value for a single label on a bucket asynchronously. The label will be added if it does
        /// not exist, or updated if it already exists.
        /// </summary>
        /// <remarks>
        /// This method is implemented by creating a single-element dictionary which is passed to
        /// <see cref="ModifyBucketLabelsAsync(string, IDictionary{string, string}, ModifyBucketLabelsOptions, CancellationToken)"/>.
        /// </remarks>
        /// <param name="bucket">The name of the bucket. Must not be null.</param>
        /// <param name="labelName">The name of the label to set. Must not be null.</param>
        /// <param name="labelValue">The value of the label to set. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>The previous value of the label, or null if the label did not previously exist.</returns>
        public virtual async Task<string> SetBucketLabelAsync(string bucket, string labelName, string labelValue, ModifyBucketLabelsOptions options = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            StorageClientImpl.ValidateBucketName(bucket);
            GaxPreconditions.CheckNotNull(labelName, nameof(labelName));
            GaxPreconditions.CheckNotNull(labelValue, nameof(labelValue));
            var newLabels = new Dictionary<string, string> { [labelName] = labelValue };
            var oldLabels = await ModifyBucketLabelsAsync(bucket, newLabels, options, cancellationToken).ConfigureAwait(false);
            return oldLabels[labelName];
        }

        /// <summary>
        /// Removes a label from a bucket, if it previously existed, asynchronously. It is not an error to
        /// attempt to remove a label that doesn't already exist.
        /// </summary>
        /// <remarks>
        /// This method is implemented by creating a single-element dictionary which is passed to
        /// <see cref="ModifyBucketLabelsAsync(string, IDictionary{string, string}, ModifyBucketLabelsOptions, CancellationToken)"/>.
        /// </remarks>
        /// <param name="bucket">The name of the bucket. Must not be null.</param>
        /// <param name="labelName">The name of the label to remove. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>The previous value of the label, or null if the label did not previously exist.</returns>
        public virtual async Task<string> RemoveBucketLabelAsync(string bucket, string labelName, ModifyBucketLabelsOptions options = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            StorageClientImpl.ValidateBucketName(bucket);
            GaxPreconditions.CheckNotNull(labelName, nameof(labelName));
            var newLabels = new Dictionary<string, string> { [labelName] = null };
            var oldLabels = await ModifyBucketLabelsAsync(bucket, newLabels, options, cancellationToken).ConfigureAwait(false);
            return oldLabels[labelName];
        }

        /// <summary>
        /// Sets or removes one or more labels on a bucket asynchronously.
        /// </summary>
        /// <remarks>
        /// Each entry in <paramref name="labels"/> is treated as a label to set or remove. If the value is null,
        /// it will be removed from the bucket; otherwise, it will be set/added. Labels which do not have an entry
        /// in the dictionary will be ignored.
        /// </remarks>
        /// <param name="bucket">The name of the bucket. Must not be null.</param>
        /// <param name="labels">The labels to set. Must contain at least one entry; keys must not be null, but values
        /// may be (indicating label removal).</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A dictionary with the same keys as <paramref name="labels"/>, and values indicating the corresponding label value
        /// before this operation completed. Labels which weren't present on the bucket before the modification have corresponding
        /// null values in the returned dictionary.</returns>
        public virtual Task<IDictionary<string, string>> ModifyBucketLabelsAsync(
            string bucket, IDictionary<string, string> labels,
            ModifyBucketLabelsOptions options = null,
            CancellationToken cancellationToken = default(CancellationToken)) =>
            throw new NotImplementedException();

        /// <summary>
        /// Clears all labels on a bucket asynchronously.
        /// </summary>
        /// <param name="bucket">The name of the bucket. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A dictionary with the labels on the bucket before they were cleared.</returns>
        public virtual Task<IDictionary<string, string>> ClearBucketLabelsAsync(string bucket, ModifyBucketLabelsOptions options = null, CancellationToken cancellationToken = default(CancellationToken)) =>
            throw new NotImplementedException();
    }
}
