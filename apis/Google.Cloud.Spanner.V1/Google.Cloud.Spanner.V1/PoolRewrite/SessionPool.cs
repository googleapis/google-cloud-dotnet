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

namespace Google.Cloud.Spanner.V1.PoolRewrite
{
    /// <summary>
    /// A pool of sessions associated with a SpannerClient.
    /// Sessions can be acquired by specifying the desired transaction options, if any.
    /// A session/transaction pair is then returned, which should be returned to the pool when
    /// it is no longer required. Sessions are kept alive automatically, and retired if they
    /// are expired by the server.
    /// </summary>
    public sealed partial class SessionPool
    {
    }
}
