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

using System.Web;

namespace Google.Cloud.Diagnostics.AspNet
{
    /// <summary>
    /// Used to determine if an <see cref="HttpRequest"/> should be traced. This
    /// will not override a decision by the trace header. If the function returns
    /// true the request will be traced, if false is returned the trace will not
    /// be traced and if null is returned it will not affect the trace decision.
    /// </summary>
    internal static class TraceDecisionPredicate
    {
        /// <summary>
        /// Default decision predicate to determine if an <see cref="HttpRequest"/>
        /// should be traced. If the request path is "/_ah/health" false will be
        /// returned otherwise null is returned.
        /// </summary>
        public static bool? Default(HttpRequest request) =>
            request.Path == "/_ah/health" ? false : (bool?)null;
    }
}