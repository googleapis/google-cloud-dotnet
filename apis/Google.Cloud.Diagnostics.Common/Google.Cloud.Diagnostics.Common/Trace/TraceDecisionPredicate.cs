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

using System;
using Google.Api.Gax;

#if NET45
using System.Web;
#else
using Microsoft.AspNetCore.Http;
#endif

namespace Google.Cloud.Diagnostics.Common
{
    /// <summary>
    /// Used to determine if an <see cref="HttpRequest"/> should be traced. This will not override
    /// a decision by the trace header. 
    /// </summary>
    public sealed class TraceDecisionPredicate
    {
        private readonly Func<HttpRequest, bool?> _traceDecisionPredicate;
        private readonly bool _ignoreHealthChecks;

        private TraceDecisionPredicate(
            Func<HttpRequest, bool?> traceDecisionPredicate, bool ignoreHealthChecks)
        {
            _traceDecisionPredicate = traceDecisionPredicate;
            _ignoreHealthChecks = ignoreHealthChecks;
        }

        /// <summary>
        /// A <see cref="TraceDecisionPredicate"/> that does not have any effect on
        /// trace decisions and does not disable tracing health checks.
        /// </summary>
        public static TraceDecisionPredicate DoNothing => new TraceDecisionPredicate(null, false);

        /// <summary>
        /// A default <see cref="TraceDecisionPredicate"/> that only disables tracing health checks.
        /// </summary>
        public static TraceDecisionPredicate Default => new TraceDecisionPredicate(null, true);

        /// <summary>
        /// Creates a <see cref="TraceDecisionPredicate"/>.
        /// </summary>
        /// <remarks>
        /// Ignoring of health checks (<paramref name="ignoreHealthChecks"/>) takes precedence over the
        /// predicate (<paramref name="traceDecisionPredicate"/>).  If <paramref name="ignoreHealthChecks"/>
        /// is true and the request is a health check <paramref name="traceDecisionPredicate"/> will not
        /// be called.
        /// </remarks>
        /// <param name="traceDecisionPredicate">Used to determine if a request should be traced.
        /// Takes an <see cref="HttpRequest"/>.  It should return true if the request should be traced,
        /// false if the request should not be traced and null if the decision should be left to other
        /// sampling mechanisms. Cannot be null.</param>
        /// <param name="ignoreHealthChecks">Optional. True if Google App Engine health check requests should
        /// not be traced. Defaults to true.</param>
        public static TraceDecisionPredicate Create(
            Func<HttpRequest, bool?> traceDecisionPredicate, bool ignoreHealthChecks = true)
        {
            GaxPreconditions.CheckNotNull(traceDecisionPredicate, nameof(traceDecisionPredicate));
            return new TraceDecisionPredicate(traceDecisionPredicate, ignoreHealthChecks);
        }

        /// <summary>
        /// Used to determine if a request should be traced.  This will not override a trace header
        /// decision.
        /// </summary>
        /// <param name="request">The http request to check.</param>
        /// <returns>True if the request should be traced, false if the request should not be traced
        /// and null if the decision should be left to other sampling mechanisms.</returns>
        public bool? ShouldTrace(HttpRequest request)
        {
            if (_ignoreHealthChecks && IsHealthCheck(request))
            {
                return false;
            }

            return _traceDecisionPredicate?.Invoke(request);
        }

        /// <summary>Returns true if the request for a GAE health check.</summary>
        private bool IsHealthCheck(HttpRequest request) => request.Path == "/_ah/health";
    }
}
