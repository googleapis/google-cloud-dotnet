// Copyright 2016 Google Inc. All Rights Reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace Google.Pubsub.V1.Demo
{
    /// <summary>
    /// Command line application to demonstrate features of the Google Cloud Pub/Sub library.
    /// This class is only an entry point; see <see cref="DemoCommands"/> for the real Pub/Sub code.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Entry point for the application.
        /// </summary>
        public static int Main(string[] args)
        {
            var commands = typeof(DemoCommands).GetTypeInfo().DeclaredMethods;

            var command = commands.FirstOrDefault(c => string.Equals(c.Name, args.FirstOrDefault(), StringComparison.InvariantCultureIgnoreCase));
            if (command == null)
            {
                Console.WriteLine("Available commands:");
                foreach (var candidate in commands)
                {
                    PrintCommand(candidate);
                }
                return 1;
            }
            var parameters = command.GetParameters();
            var objectArgs = args.Skip(1).ToArray<object>();
            if (parameters.SelectMany(p => p.CustomAttributes).Any(attr => attr.AttributeType == typeof(ParamArrayAttribute)))
            {
                // Convert all trailing arguments to a single array.
                // TODO: Handle non-string[] parameter arrays
                objectArgs = objectArgs.Take(parameters.Length - 1)
                    .Concat(new object[] { objectArgs.Skip(parameters.Length - 1).Cast<string>().ToArray() })
                    .ToArray();
            }
            if (parameters.Length != objectArgs.Length)
            {
                Console.WriteLine("Got {0} messages", objectArgs.Length);
                Console.WriteLine("Invalid argument for command - incorrect number of arguments.");
                PrintCommand(command);
                return 1;
            }
            var arguments = objectArgs.Zip(parameters, (arg, param) => Convert.ChangeType(arg, param.ParameterType)).ToArray();
            command.Invoke(null, arguments);
            return 0;
        }

        private static void PrintCommand(MethodInfo command)
        {
            Console.WriteLine($"{command.Name}: {string.Join(", ", command.GetParameters().Select(p => p.Name))}");
        }
    }
}
