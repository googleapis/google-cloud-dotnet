// Copyright 2021 Google LLC
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

using System.Collections.Generic;
using System.Linq;

namespace Google.Cloud.Tools.DocfxMetadata
{
    /// <summary>
    /// Simplified representation of a metadata item. (This can be added to
    /// as required; we could use the Microsoft.DocAsCode.DataContracts.ManagedReference
    /// package if we really needed the full representation.)
    /// </summary>
    public class MetadataItem
    {
        private static readonly ItemType[] s_typeItems =
        {
            ItemType.Class, ItemType.Struct, ItemType.Interface, ItemType.Delegate
        };

        public string Uid { get; set; }
        public string Name { get; set; }
        public ItemType Type { get; set; }
        public List<string> Assemblies { get; set; }
        public string Parent { get; set; }
        public List<string> Children { get; set; }

        public bool IsType => s_typeItems.Contains(Type);
    }
}
