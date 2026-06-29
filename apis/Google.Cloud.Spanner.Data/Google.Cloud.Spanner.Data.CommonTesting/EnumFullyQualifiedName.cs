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
/// This class defines the string representation of an Enum with FQN for testing
/// </summary>
public static class EnumFullyQualifiedName
{
    /// <summary>
    /// The string representing the FQN of the CharacterClass enum in the `fantasy` package
    /// This is not readily available from the C# compiled proto class
    /// </summary>
    public const string CharacterClassFQN = "fantasy.Character.CharacterClass";
}
