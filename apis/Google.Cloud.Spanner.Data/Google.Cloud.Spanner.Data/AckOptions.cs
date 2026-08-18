// Copyright 2025 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License"):
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

using System;
using System.Collections.Generic;
using System.Text;

namespace Google.Cloud.Spanner.Data;

/// <summary>
/// Optional configurations for Ack mutations.
/// </summary>
public class AckOptions
{
    /// <summary>
    /// When true, the Ack will succeed even if the message is not found.
    /// </summary>
    public bool? IgnoreNotFound {  get; set; }

    /// <summary>
    /// Creates a Cloned copy of this object.
    /// </summary>
    /// <returns>Cloned copy</returns>
    public AckOptions Clone() => new() { IgnoreNotFound = IgnoreNotFound };
}
