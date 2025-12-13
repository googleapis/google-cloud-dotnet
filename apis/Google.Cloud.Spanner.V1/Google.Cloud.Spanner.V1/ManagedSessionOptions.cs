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

namespace Google.Cloud.Spanner.V1;

/// <summary>
/// Options which can be set on the managed session
/// </summary>
public class ManagedSessionOptions
{
    private TimeSpan _timeout = TimeSpan.FromSeconds(60);

    /// <summary>
    /// Constructs a new <see cref="ManagedSessionOptions"/> with default values.
    /// </summary>
    public ManagedSessionOptions()
    {
    }

    /// <summary>
    /// The total time allowed for a network call to the Cloud Spanner server, including retries. This setting
    /// is applied to calls to create session as well as beginning transactions.
    /// </summary>
    /// <remarks>
    /// <para>
    /// This value must be positive. The default value is one minute.
    /// </para>
    /// </remarks>
    public TimeSpan Timeout
    {
        get => _timeout;
        set => _timeout = CheckPositiveTimeSpan(value);
    }

    // TODO: Move to GAX if we find we need it in other libraries. (We have CheckNonNegative already.)
    private static TimeSpan CheckPositiveTimeSpan(TimeSpan value)
    {
        if (value.Ticks <= 0)
        {
            throw new ArgumentOutOfRangeException("value", "Value must be a positive TimeSpan");
        }
        return value;
    }
}
