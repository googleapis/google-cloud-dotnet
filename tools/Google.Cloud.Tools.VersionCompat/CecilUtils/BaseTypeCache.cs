// Copyright 2026 Google LLC
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

using Mono.Cecil;
using SharpCompress.Compressors.ZStandard.Unsafe;
using System.Collections.Concurrent;
using System.Linq;

namespace Google.Cloud.Tools.VersionCompat.CecilUtils;
internal class BaseTypeCache
{
    public static BaseTypeCache Instance { get; } = new BaseTypeCache();

    private readonly ConcurrentDictionary<string, TypeDefinition> _baseTypes = new();

    public TypeDefinition GetBaseType(TypeDefinition type)
        => _baseTypes.GetOrAdd(type.FullName, GetBaseTypeDefinitionUncached(type));

    private static TypeDefinition GetBaseTypeDefinitionUncached(TypeDefinition type) => type.BaseType?.Resolve();
}
