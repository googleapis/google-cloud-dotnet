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

using System;
using System.Reflection;
using Google.Protobuf.Reflection;

namespace Google.Cloud.Compute.V1.EnumConstantGenerator
{
    /// <summary>
    /// Generates (to stdout) a static class (with nested static classes) to provide
    /// string constants for the wire representations of enum values.
    /// </summary>
    public class Program
    {
        private static int Main(string[] args)
        {
            if (args.Length != 1)
            {
                Console.WriteLine("Required argument: path to Compute DLL");
                return 1;
            }
            var asm = Assembly.LoadFile(args[0]);
            var type = asm.GetType("Google.Cloud.Compute.V1.ComputeReflection");
            var descriptor = (FileDescriptor) type.GetProperty("Descriptor").GetValue(null);

            var rootContainer = new EnumContainer(null, descriptor.EnumTypes, descriptor.MessageTypes);

            var writer = Console.Out;
            writer.WriteLine(
$@"// Copyright {DateTime.UtcNow.Year} Google LLC
//
// Licensed under the Apache License, Version 2.0 (the ""License"");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an ""AS IS"" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

namespace Google.Cloud.Compute.V1
{{");
            rootContainer.Generate(writer, "    ", asm.GetType("Google.Cloud.Compute.V1.ComputeEnumHelpers"));
            writer.WriteLine("}");
            return 0;
        }
    }
}
