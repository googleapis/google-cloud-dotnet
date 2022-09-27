// Copyright 2022 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License").
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at 
//
// https://www.apache.org/licenses/LICENSE-2.0 
//
// Unless required by applicable law or agreed to in writing, software 
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and 
// limitations under the License.

namespace Google.Cloud.Spanner.Data.CommonTesting;

/// <summary>
/// This class defines the string constants used in the test classes for specifying the trait names and values.
/// </summary>
public static class Constants
{
    /// <summary>
    /// The constant string representing the trait name to determine if the test is supported on the emulator.
    /// </summary>
    public const string SupportedOnEmulator = nameof(SupportedOnEmulator);

    /// <summary>
    /// The constant string representing the value of "No".
    /// </summary>
    public const string No = nameof(No);

    /// <summary>
    /// The constant string representing the value of "Yes".
    /// </summary>
    public const string Yes = nameof(Yes);
}
