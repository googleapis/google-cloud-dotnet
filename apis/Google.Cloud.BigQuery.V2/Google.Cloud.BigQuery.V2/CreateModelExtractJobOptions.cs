// Copyright 2021 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Google.Apis.Bigquery.v2.Data;
using System;

namespace Google.Cloud.BigQuery.V2
{
    /// <summary>
    /// Options for <c>CreateModelExtractJob</c> operations.
    /// </summary>
    public sealed class CreateModelExtractJobOptions : JobCreationOptions
    {
        /// <summary>
        /// The model format to use for output. If this is unspecified,
        /// the default is to create a Tensorflow SavedModel.
        /// </summary>
        public ModelFormat? DestinationFormat { get; set; }

        /// <summary>
        /// Optional action to perform after preparing the request. If this property is non-null,
        /// the <see cref="JobConfigurationExtract"/> used for a request will be passed to the delegate
        /// before the request is executed. This allows for fine-grained modifications which aren't
        /// otherwise directly supported by the properties in this options type.
        /// </summary>
        /// <remarks>
        /// Prefer the properties on this type over this modifier to prepare the request.
        /// Only use this modifier to configure aspects for which there are no properties available.
        /// This modifier is applied to the request after all properties on this type have been applied.
        /// The delegate is only called once per operation, even if the request is automatically retried.
        /// </remarks>
        public Action<JobConfigurationExtract> ConfigurationModifier { get; set; }

        internal void ModifyRequest(JobConfigurationExtract extract)
        {
            if (DestinationFormat != null)
            {
                extract.DestinationFormat = EnumMap.ToApiValue(DestinationFormat.Value);
            }
            ConfigurationModifier?.Invoke(extract);
        }
    }
}
