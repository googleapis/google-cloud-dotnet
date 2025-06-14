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

using Google.Apis.Bigquery.v2.Data;
using System;

namespace Google.Cloud.BigQuery.V2
{
    /// <summary>
    /// Options for <c>CreateCopyJob</c> operations.
    /// </summary>
    public sealed class CreateCopyJobOptions : JobCreationOptions
    {
        /// <summary>
        /// The behavior if the destination table doesn't exist. If this
        /// is unspecified, the default is to create a new table.
        /// </summary>
        public CreateDisposition? CreateDisposition { get; set; }

        /// <summary>
        /// Specifies the behavior if the destination table exists.
        /// If not set, this is effectively <see cref="WriteDisposition.WriteIfEmpty"/>.
        /// </summary>
        public WriteDisposition? WriteDisposition { get; set; }

        /// <summary>
        /// The encryption configuration to apply to the destination table, if any.
        /// </summary>
        public EncryptionConfiguration DestinationEncryptionConfiguration { get; set; }

        /// <summary>
        /// Specifies the operation type for the job, if any.
        /// </summary>
        public CopyOperationType? OperationType { get; set; }

        /// <summary>
        /// Optional action to perform after preparing the request. If this property is non-null,
        /// the <see cref="JobConfigurationTableCopy"/> used for a request will be passed to the delegate
        /// before the request is executed. This allows for fine-grained modifications which aren't
        /// otherwise directly supported by the properties in this options type.
        /// </summary>
        /// <remarks>
        /// Prefer the properties on this type over this modifier to prepare the request.
        /// Only use this modifier to configure aspects for which there are no properties available.
        /// This modifier is applied to the request after all properties on this type have been applied.
        /// The delegate is only called once per operation, even if the request is automatically retried.
        /// </remarks>
        public Action<JobConfigurationTableCopy> ConfigurationModifier { get; set; }

        ///<summary>
        /// The reservation that job would use. User can specify a reservation to execute the
        /// job.If reservation is not set, reservation is determined based on the rules defined by the
        /// reservation assignments.The expected format is
        /// `projects/{project}/locations/{location}/reservations/{reservation}`.
        /// </summary>
        public string Reservation { get; set; }

        internal void ModifyRequest(JobConfigurationTableCopy copy)
        {
            if (CreateDisposition != null)
            {
                copy.CreateDisposition = EnumMap.ToApiValue(CreateDisposition.Value);
            }
            if (WriteDisposition != null)
            {
                copy.WriteDisposition = EnumMap.ToApiValue(WriteDisposition.Value);
            }
            if (DestinationEncryptionConfiguration != null)
            {
                copy.DestinationEncryptionConfiguration = DestinationEncryptionConfiguration;
            }
            if (OperationType != null)
            {
                copy.OperationType = EnumMap.ToApiValue(OperationType.Value);
            }
            ConfigurationModifier?.Invoke(copy);
        }
    }
}
