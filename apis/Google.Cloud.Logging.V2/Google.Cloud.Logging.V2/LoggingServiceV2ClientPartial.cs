// Copyright 2018 Google LLC
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

// This file can be removed when the equivalent code is generated.

using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using scg = System.Collections.Generic;

namespace Google.Cloud.Logging.V2
{
    public abstract partial class LoggingServiceV2Client
    {
        /// <summary>
        /// Lists log entries.  Use this method to retrieve log entries from
        /// Stackdriver Logging.  For ways to export log entries, see
        /// [Exporting Logs](/logging/docs/export).
        /// </summary>
        /// <param name="resourceNames">
        /// Required. Names of one or more parent resources from which to
        /// retrieve log entries:
        ///
        ///     "projects/[PROJECT_ID]"
        ///     "organizations/[ORGANIZATION_ID]"
        ///     "billingAccounts/[BILLING_ACCOUNT_ID]"
        ///     "folders/[FOLDER_ID]"
        ///
        /// Projects listed in the `project_ids` field are added to this list.
        /// </param>
        /// <param name="filter">
        /// Optional. A filter that chooses which log entries to return.  See [Advanced
        /// Logs Filters](/logging/docs/view/advanced_filters).  Only log entries that
        /// match the filter are returned.  An empty filter matches all log entries in
        /// the resources listed in `resource_names`. Referencing a parent resource
        /// that is not listed in `resource_names` will cause the filter to return no
        /// results.
        /// The maximum length of the filter is 20000 characters.
        /// </param>
        /// <param name="orderBy">
        /// Optional. How the results should be sorted.  Presently, the only permitted
        /// values are `"timestamp asc"` (default) and `"timestamp desc"`. The first
        /// option returns entries in order of increasing values of
        /// `LogEntry.timestamp` (oldest first), and the second option returns entries
        /// in order of decreasing timestamps (newest first).  Entries with equal
        /// timestamps are returned in order of their `insert_id` values.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request.
        /// A value of <c>null</c> or an empty string retrieves the first page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller.
        /// A value of <c>null</c> or 0 uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="LogEntry"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListLogEntriesResponse, LogEntry> ListLogEntriesAsync(
            scg::IEnumerable<string> resourceNames,
            string filter,
            string orderBy,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListLogEntriesAsync(
                new ListLogEntriesRequest
                {
                    ResourceNames = { gax::GaxPreconditions.CheckNotNull(resourceNames, nameof(resourceNames)) },
                    Filter = filter ?? "", // Optional
                    OrderBy = orderBy ?? "", // Optional
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists log entries.  Use this method to retrieve log entries from
        /// Stackdriver Logging.  For ways to export log entries, see
        /// [Exporting Logs](/logging/docs/export).
        /// </summary>
        /// <param name="resourceNames">
        /// Required. Names of one or more parent resources from which to
        /// retrieve log entries:
        ///
        ///     "projects/[PROJECT_ID]"
        ///     "organizations/[ORGANIZATION_ID]"
        ///     "billingAccounts/[BILLING_ACCOUNT_ID]"
        ///     "folders/[FOLDER_ID]"
        ///
        /// Projects listed in the `project_ids` field are added to this list.
        /// </param>
        /// <param name="filter">
        /// Optional. A filter that chooses which log entries to return.  See [Advanced
        /// Logs Filters](/logging/docs/view/advanced_filters).  Only log entries that
        /// match the filter are returned.  An empty filter matches all log entries in
        /// the resources listed in `resource_names`. Referencing a parent resource
        /// that is not listed in `resource_names` will cause the filter to return no
        /// results.
        /// The maximum length of the filter is 20000 characters.
        /// </param>
        /// <param name="orderBy">
        /// Optional. How the results should be sorted.  Presently, the only permitted
        /// values are `"timestamp asc"` (default) and `"timestamp desc"`. The first
        /// option returns entries in order of increasing values of
        /// `LogEntry.timestamp` (oldest first), and the second option returns entries
        /// in order of decreasing timestamps (newest first).  Entries with equal
        /// timestamps are returned in order of their `insert_id` values.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request.
        /// A value of <c>null</c> or an empty string retrieves the first page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller.
        /// A value of <c>null</c> or 0 uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="LogEntry"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ListLogEntriesResponse, LogEntry> ListLogEntries(
            scg::IEnumerable<string> resourceNames,
            string filter,
            string orderBy,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListLogEntries(
                new ListLogEntriesRequest
                {
                    ResourceNames = { gax::GaxPreconditions.CheckNotNull(resourceNames, nameof(resourceNames)) },
                    Filter = filter ?? "", // Optional
                    OrderBy = orderBy ?? "", // Optional
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);
    }
}
