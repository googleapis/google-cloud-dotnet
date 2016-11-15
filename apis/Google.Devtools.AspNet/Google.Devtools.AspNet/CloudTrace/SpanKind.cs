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

using Google.Devtools.Cloudtrace.V1;

namespace Google.Devtools.AspNet
{
    /// <summary>
    /// An enum value representing span kinds.
    /// </summary>
    public enum SpanKind
    {
        Unspecified,
        RpcClient,
        RpcServer,
    }

    public static class Extensions
    {
        /// <summary>
        /// Converts a <see cref="Google.Devtools.AspNet.SpanKind"/> to a <see cref="TraceSpan.Types.SpanKind"/>.
        /// </summary>
        /// <param name="kind"></param>
        /// <returns></returns>
        public static TraceSpan.Types.SpanKind Convert(this SpanKind kind)
        {
            switch (kind)
            {
                case SpanKind.RpcClient:
                    return TraceSpan.Types.SpanKind.RpcClient;
                case SpanKind.RpcServer:
                    return TraceSpan.Types.SpanKind.RpcServer;
                default:
                    return TraceSpan.Types.SpanKind.Unspecified;
            }
        }
    }
}