// Copyright 2017 Google Inc. All Rights Reserved.
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
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using Xunit.Sdk;

namespace Google.Cloud.ClientTesting
{
    /// <summary>
    /// Attribute to redirect standard output to a file for tests it's applied to.
    /// </summary>
    public class SnippetOutputCollectorAttribute : BeforeAfterTestAttribute
    {
        private static readonly string s_projectDirectory = FindOutputDirectory();
        private static readonly HashSet<Type> s_encounteredTypes = new HashSet<Type>();

        private static readonly StringBuilder s_builder = new StringBuilder();
        private static TextWriter s_originalOutput;

        /// <summary>
        /// Redirects standard output 
        /// </summary>
        /// <param name="methodUnderTest"></param>
        public override void Before(MethodInfo methodUnderTest)
        {
            if (s_projectDirectory == null)
            {
                return;
            }
            s_builder.Clear();
            s_originalOutput = Console.Out;
            Console.SetOut(new StringWriter(s_builder));
        }

        public override void After(MethodInfo methodUnderTest)
        {
            if (s_projectDirectory == null)
            {
                return;
            }
            var type = methodUnderTest.DeclaringType;
            string file = Path.Combine(s_projectDirectory, $"{type.FullName}.txt");
            lock (s_encounteredTypes)
            {
                if (s_encounteredTypes.Add(type))
                {
                    File.Delete(file);
                }
            }
            string content = s_builder.ToString();
            content = $"---- {methodUnderTest.Name} output ----{Environment.NewLine}{content}";
            File.AppendAllText(file, content);
            Console.SetOut(s_originalOutput);
        }
        
        private static string FindOutputDirectory()
        {
            // First find the root directory
            var currentDirectory = Path.GetFullPath(".");
            var directory = new DirectoryInfo(currentDirectory);
            while (directory != null &&
                (!File.Exists(Path.Combine(directory.FullName, "LICENSE"))
                || !Directory.Exists(Path.Combine(directory.FullName, "apis"))))
            {
                directory = directory.Parent;
            }
            if (directory == null)
            {
                return null;
            }
            // Then an output directory under it, creating it if necessary.
            string output = Path.Combine(directory.FullName, "snippetoutput");
            Directory.CreateDirectory(output);
            return output;
        }
    }
}
