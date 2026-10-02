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
/// Optional configurations for Send mutations.
/// </summary>
public class SendOptions
{
    /// <summary>
    /// Earliest time for which the message may be delivered.
    /// </summary>
    public DateTime? DeliverAt { get; set; }

    /// <summary>
    /// Creates a Cloned copy of this object.
    /// </summary>
    /// <returns>Cloned copy</returns>
    public SendOptions Clone() => new() { DeliverAt = DeliverAt };
}
