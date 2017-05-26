// Copyright 2017, Google Inc. All rights reserved.
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

using System;
using Google.Api.Gax;
using Google.Api.Gax.Grpc;
using Grpc.Core;
// ReSharper disable UnusedParameterInPartialMethod

namespace Google.Cloud.Spanner.V1
{
    public partial class SpannerClient
    {
        /// <summary>
        /// Executes an SQL Query on Spanner returning the results as a set of partialresult streams.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="callSettings"></param>
        /// <returns></returns>
        internal virtual AsyncServerStreamingCall<PartialResultSet> ExecuteSqlStream(ExecuteSqlRequest request, CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Executes an SQL Query on Spanner returning the results as a set of partialresult streams.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="session"></param>
        /// <returns></returns>
        internal virtual ReliableStreamReader GetSqlStreamReader(ExecuteSqlRequest request, Session session)
        {
            throw new NotImplementedException();
        }
    }

    public partial class SpannerClientImpl
    {
        private ApiServerStreamingCall<ExecuteSqlRequest, PartialResultSet> _callExecuteSqlStream;

        private CallSettings ExecuteSqlStreamSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromTimeout(TimeSpan.FromSeconds(60)));

        partial void OnConstruction(Spanner.SpannerClient grpcClient, SpannerSettings effectiveSettings, ClientHelper clientHelper)
        {
            _callExecuteSqlStream = clientHelper.BuildApiCall<ExecuteSqlRequest, PartialResultSet>(
                GrpcClient.ExecuteStreamingSql, null);
        }

        /// <summary>
        /// Executes an SQL Query on Spanner returning the results as a set of partialresult streams.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="callSettings"></param>
        /// <returns></returns>
        internal override AsyncServerStreamingCall<PartialResultSet> ExecuteSqlStream(ExecuteSqlRequest request, CallSettings callSettings = null)
        {
            Modify_ExecuteSqlRequest(ref request, ref callSettings);
            return _callExecuteSqlStream.Call(request, callSettings);
        }

        /// <summary>
        /// Executes an SQL Query on Spanner returning the results as a set of partialresult streams.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="session"></param>
        /// <returns></returns>
        internal override ReliableStreamReader GetSqlStreamReader(ExecuteSqlRequest request, Session session)
        {
            return new ReliableStreamReader(this, request, session);
        }
    }
}
