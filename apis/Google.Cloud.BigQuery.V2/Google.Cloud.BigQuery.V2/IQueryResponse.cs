// Copyright 2026 Google Inc. All Rights Reserved.
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
using System.Collections.Generic;

namespace Google.Cloud.BigQuery.V2
{
    /// <summary>
    /// Internal interface to unify GetQueryResultsResponse and QueryResponse.
    /// </summary>
    internal interface IQueryResponse
    {
        IList<TableRow> Rows { get; }
        TableSchema Schema { get; }
        JobReference JobReference { get; }
        string PageToken { get; }
        ulong? TotalRows { get; }
        long? NumDmlAffectedRows { get; }
        bool? CacheHit { get; }
        bool? JobComplete { get; }
        IList<ErrorProto> Errors { get; }
        string QueryId { get; }
    }

    internal sealed class GetQueryResultsResponseWrapper : IQueryResponse
    {
        private readonly GetQueryResultsResponse _response;
        internal GetQueryResultsResponseWrapper(GetQueryResultsResponse response) => _response = response;

        public IList<TableRow> Rows => _response.Rows;
        public TableSchema Schema => _response.Schema;
        public JobReference JobReference => _response.JobReference;
        public string PageToken => _response.PageToken;
        public ulong? TotalRows => _response.TotalRows;
        public long? NumDmlAffectedRows => _response.NumDmlAffectedRows;
        public bool? CacheHit => _response.CacheHit;
        public bool? JobComplete => _response.JobComplete;
        public IList<ErrorProto> Errors => _response.Errors;
        public string QueryId => null;
    }

    internal sealed class QueryResponseWrapper : IQueryResponse
    {
        private readonly QueryResponse _response;
        internal QueryResponseWrapper(QueryResponse response) => _response = response;

        public IList<TableRow> Rows => _response.Rows;
        public TableSchema Schema => _response.Schema;
        public JobReference JobReference => _response.JobReference;
        public string PageToken => _response.PageToken;
        public ulong? TotalRows => _response.TotalRows;
        public long? NumDmlAffectedRows => _response.NumDmlAffectedRows;
        public bool? CacheHit => _response.CacheHit;
        public bool? JobComplete => _response.JobComplete;
        public IList<ErrorProto> Errors => _response.Errors;
        public string QueryId => _response.QueryId;
    }
}
