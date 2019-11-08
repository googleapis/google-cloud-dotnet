// Copyright 2019 Google LLC
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

using Google.Cloud.Tools.VersionCompat.CecilUtils;
using Mono.Cecil;
using System.Collections.Generic;
using System.Linq;

namespace Google.Cloud.Tools.VersionCompat.Detectors
{
    internal class Struct
    {
        public static IEnumerable<Diff> Diffs(TypeDefinition o, TypeDefinition n)
        {
            var classStructInterface = new ClassStructInterface(o, n);
            // TODO: Check (instance) constructors
            return Enumerable.Empty<Diff>()
                .Concat(classStructInterface.ImplementedInterfaces())
                .Concat(classStructInterface.GenericConstraints())
                .Concat(classStructInterface.Ctors(TypeType.Struct))
                .Concat(classStructInterface.Methods(TypeType.Struct))
                .Concat(classStructInterface.Properties(TypeType.Struct))
                .Concat(classStructInterface.Obsoleteness());
        }
    }
}
