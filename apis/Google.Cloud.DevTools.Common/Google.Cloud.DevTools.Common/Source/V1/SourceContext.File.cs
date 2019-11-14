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

using Google.Protobuf;
using System;
using System.IO;
using System.Security;

namespace Google.Cloud.DevTools.Source.V1
{
    // Partial class to SourceContext proto.
    // This code reads the source-context.json file from the application root directory.
    public sealed partial class SourceContext
    {
        private const string SourceContextFileName = "source-context.json";
        private static Lazy<string> s_filePath;
        private static Lazy<SourceContext> s_sourceContext;

        /// <summary>
        /// The func that reads file all text. Can be overridden by unit tests.
        /// </summary>
        internal static Func<string, string> s_fileReadAllTextFunc = File.ReadAllText;

        /// <summary>
        /// The func that tests if file exists. Can be overridden by unit tests.
        /// </summary>
        internal static Func<string, bool> s_fileExistsFunc = File.Exists;

        /// <summary>
        /// Gets the custom log label of Stackdriver Logging entry to set Git revision id.
        /// When writing a Stackdriver Logging entry, the user should add this custom label,
        /// with a value of the git revision id for the source code.
        /// This enables Google Cloud Tools for Visual Studio to locate the source file revision
        /// of the log entry. 
        /// </summary>
        public const string GitRevisionIdLogLabel = "git_revision_id";

        /// <summary>
        /// Gets the <seealso cref="SourceContext"/> for the application.
        /// </summary>
        /// <exception cref="InvalidProtocolBufferException">
        /// The source context file is valid JSON, but is not valid as a SourceContext.
        /// </exception>
        /// <exception cref="InvalidJsonException">
        /// The source context file is not valid JSON.
        /// </exception>
        /// <exception cref="SecurityException">
        /// The application does not have permission to read the file.
        /// </exception>
        /// <exception cref="UnauthorizedAccessException">
        /// The application is not authorized to access the file.
        /// </exception>
        public static SourceContext AppSourceContext => s_sourceContext.Value;

        static SourceContext()
        {
            ResetAppSourceContext();
        }

        /// <summary>
        /// Open the source context file and parses it (as JSON) to a <seealso cref="SourceContext"/> proto.
        /// </summary>
        /// <returns>
        /// A <seealso cref="SourceContext"/> object if the file is read and parsed successfully, or
        /// null if there is an error reading/parsing the file or the source context file is not found.
        /// </returns>
        private static SourceContext OpenParseFile()
        {
            string sourceContext = Read();
            if (sourceContext == null)
            {
                return null;
            }
            return JsonParser.Default.Parse<SourceContext>(sourceContext);
        }

        /// <summary>
        /// Finds the source context file and reads the content as a string.
        /// </summary>
        private static string Read()
        {
            if (s_filePath.Value == null)
            {
                return null;
            }
            try
            {
                return s_fileReadAllTextFunc(s_filePath.Value);
            }
            catch (Exception ex) when (ex is IOException)
            {
                return null;
            }
        }

        private static string GetFilePath()
        {
            string root = AppDomain.CurrentDomain.BaseDirectory;
            var fullPath = Path.Combine(root, SourceContextFileName);
            return s_fileExistsFunc(fullPath) ? fullPath : null;
        }

        /// <summary>
        /// Intended to be used by unit test only.
        /// </summary>
        internal static void ResetAppSourceContext()
        {
            s_filePath = new Lazy<string>(GetFilePath);
            s_sourceContext = new Lazy<SourceContext>(OpenParseFile);
        }
    }
}
