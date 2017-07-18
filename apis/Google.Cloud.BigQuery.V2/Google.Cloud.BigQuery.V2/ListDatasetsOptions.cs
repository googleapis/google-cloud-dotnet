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

using Google.Api.Gax;
using Google.Apis.Bigquery.v2;
using System.Collections.Generic;

namespace Google.Cloud.BigQuery.V2
{
    /// <summary>
    /// Options used when listing datasets. Details TBD.
    /// </summary>
    public sealed class ListDatasetsOptions
    {
        /// <summary>
        /// The number of results to return per page. (This modifies the per-request page size;
        /// it does not affect the total number of results returned.)
        /// </summary>
        public int? PageSize { get; set; }

        /// <summary>
        /// The filter to apply when listing datasets. See https://cloud.google.com/bigquery/docs/labeling-datasets#filtering_datasets_using_labels
        /// for more details. Filters for labels can be created easily using the <see cref="Filters"/> class.
        /// </summary>
        public string Filter { get; set; }

        /// <summary>
        /// Whether to include hidden datasets, equivalent to the "all" parameter of
        /// the REST API. By default, hidden datasets will not be included.
        /// </summary>
        public bool? IncludeHidden { get; set; }

        internal void ModifyRequest(DatasetsResource.ListRequest request)
        {
            if (PageSize != null)
            {
                request.MaxResults = PageSize;
            }
            if (Filter != null)
            {
                request.Filter = Filter;
            }
            if (IncludeHidden != null)
            {
                request.All = IncludeHidden;
            }
        }
    }
}
