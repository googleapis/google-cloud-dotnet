// Copyright 2016 Google Inc. All Rights Reserved.
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

using static Google.Apis.Bigquery.v2.DatasetsResource;
using System;

namespace Google.Cloud.BigQuery.V2
{
    /// <summary>
    /// Options for <c>CreateDatasetOptions</c> operations. Currently  no options are
    /// available, but this class exists to provide consistency and extensibility.
    /// </summary>
    public sealed class CreateDatasetOptions
    {
        /// <summary>
        /// Optional action to perform after preparing the request. If this property is non-null,
        /// the <see cref="InsertRequest"/> used for a request will be passed to the delegate
        /// before the request is executed. This allows for fine-grained modifications which aren't
        /// otherwise directly supported in this options type.
        /// </summary>
        public Action<InsertRequest> RequestModifier { get; set; }

        internal void ModifyRequest(InsertRequest request) => RequestModifier?.Invoke(request);
    }
}
