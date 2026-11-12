// Copyright 2026 Google LLC
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

using Google.Apis.Auth.OAuth2;

namespace Google.Cloud.BuiltInMetrics;

/// <summary>
/// Options for enabling Google Cloud client built-in metrics collection.
/// </summary>
public sealed class BuiltInMetricsOptions
{
    /// <summary>
    /// The credential that exports metrics, or <c>null</c> to use Application Default Credentials.
    /// </summary>
    /// <remarks>
    /// If the credential requires scopes, this library applies the
    /// <c>https://www.googleapis.com/auth/monitoring.write</c> scope to it.
    /// The credential must have permission to write metrics to every project that the client libraries use.
    /// </remarks>
    public GoogleCredential GoogleCredential { get; set; }
}
