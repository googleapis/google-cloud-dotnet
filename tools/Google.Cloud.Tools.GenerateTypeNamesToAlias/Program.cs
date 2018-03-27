using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Google.Cloud.Tools.GenerateTypeNamesToAlias
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 1)
            {
                Console.WriteLine("Usage: GenerateTypeNamesToAlias <output file>");
                Console.WriteLine();
                Console.WriteLine("    The output-file is overwritten with the complete");
                Console.WriteLine("    Java source code for the set of type-names that");
                Console.WriteLine("    must be namespace qualified.");
                Console.WriteLine();
                return;
            }

            // Example types that must be aliased.
            // Must include all possible namespaces, and all possible assemblies.
            var exampleTypes = new[]
            {
                 typeof(System.Console),
                 typeof(System.Exception),
                 typeof(System.Threading.CancellationToken),
                 typeof(System.Threading.Tasks.Task),
                 typeof(System.Collections.Queue),
                 typeof(System.Collections.Generic.List<>),
                 typeof(System.Collections.Generic.IAsyncEnumerable<>),
                 typeof(System.Collections.ObjectModel.ReadOnlyCollection<>),
                 typeof(Google.Api.Gax.Expiration),
                 typeof(Google.Api.Gax.Grpc.BackoffSettings),
                 typeof(Google.LongRunning.Operation),
                 typeof(Google.Cloud.Iam.V1.IAMPolicy),
                 typeof(Google.Protobuf.IMessage),
                 typeof(Google.Protobuf.WellKnownTypes.Any),
                 typeof(Moq.Mock),
                 typeof(Xunit.Assert),
            };

            var namespaces = exampleTypes
                .Select(x => x.Namespace)
                .ToHashSet();

            var types = exampleTypes
                .Select(x => x.Assembly)
                .Distinct()
                .SelectMany(assembly => assembly.GetExportedTypes())
                .Where(x => namespaces.Contains(x.Namespace) && !x.IsGenericType && !x.IsNested)
                .GroupBy(x => x.Name)
                .OrderBy(x => x.Key);

            var setAddLines = types
                .Select(x =>
                {
                    var namespaceList = string.Join(", ", x.Select(y => $"\"{y.Namespace}\""));
                    return $"      .put(\"{x.Key}\", ImmutableList.of({namespaceList}))";
                });

            var lines = PreLines()
                .Concat(setAddLines)
                .Concat(PostLines());

            File.WriteAllLines(args[0], lines);
            Console.WriteLine("Done");
        }

        private static IEnumerable<string> PreLines()
        {
            var lines = @"
/* Copyright 2018 Google LLC
 *
 * Licensed under the Apache License, Version 2.0(the ""License"");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * https://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an ""AS IS"" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

// Generated code. DO NOT EDIT!

package com.google.api.codegen.util.csharp;

import com.google.common.collect.ImmutableList;
import com.google.common.collect.ImmutableMap;
import java.util.List;
import java.util.Map;

public class CSharpImports {
  // Type names that must be aliased when used as a user-defined message type.
  public static Map<String, List<String>> typeNamesToAlias = ImmutableMap.<String, List<String>>builder()
";
            return lines.Trim().Replace('\r', '\n').Replace("\n\n", "\n").Split('\n');
        }

        private static IEnumerable<string> PostLines()
        {
            var lines = @"
      .build();
}
";
            return lines.Trim().Replace('\r', '\n').Replace("\n\n", "\n").Split('\n');
        }
    }
}
