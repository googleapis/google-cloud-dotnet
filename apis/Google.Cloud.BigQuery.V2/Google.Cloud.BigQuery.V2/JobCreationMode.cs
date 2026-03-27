// Copyright 2026 Google LLC
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

namespace Google.Cloud.BigQuery.V2;

/// <summary>
/// Specifies whether a job is required to be created.
/// </summary>
public enum JobCreationMode
{
    /// <summary>
    /// If unspecified JOB_CREATION_REQUIRED is the default.
    /// </summary>
    [ApiValue("JOB_CREATION_MODE_UNSPECIFIED")]
    Unspecified,

    /// <summary>
    /// A Job will always be created.
    /// </summary>
    [ApiValue("JOB_CREATION_REQUIRED")]
    Required,

    /// <summary>
    /// A Job will only be created if it is required.
    /// </summary>
    [ApiValue("JOB_CREATION_OPTIONAL")]
    Optional
}
