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
    /// <summary>
    /// Partial class to SourceContext proto.
    /// The class here reads source-context.json file from app root.
    /// </summary>
    public sealed partial class SourceContext
    {
        private const string SourceContextFileName = "source-context.json";
        private static Lazy<string> s_filePath = new Lazy<string>(GetFilePath);
        private static Lazy<SourceContext> s_sourceContext = new Lazy<SourceContext>(OpenParseFile);

        /// <summary>
        /// Gets the custom log label of Stackdriver Logging entry to set Git revision id.
        /// When writing Stackdriver Logging entry, 
        /// user should add this custom label, set the value to the git revision id.
        /// This enables Google Cloud Tools for Visual Studio to locate source file revision
        /// of the log entry. 
        /// The design is still evolving, the usage of the label is subject to change.
        /// </summary>
        public const string GitRevisionIdLogLabel = "git_revision_id";

        /// <summary>
        /// Gets the <seealso cref="SourceContext"/> for the application.
        /// </summary>
        /// <exception cref="InvalidProtocolBufferException">
        /// Thrown when the source context file is invalid in some way, 
        /// e.g. it contains a malformed varint or a negative byte length.
        /// </exception>
        /// <exception cref="InvalidJsonException">
        /// Thrown when the source context file is not in valid json format.
        /// </exception>
        /// <exception cref="SecurityException">
        /// Thrown when the application does not have permission to read the file.
        /// </exception>
        /// <exception cref="UnauthorizedAccessException">
        /// Theown when the application is not authorized to access the file.
        /// </exception>
        public static SourceContext AppSourceContext => s_sourceContext.Value;

        /// <summary>
        /// Open the source context file and parse it with <seealso cref="SourceContext"/> proto.
        /// </summary>
        /// <returns>
        /// A <seealso cref="SourceContext"/> object if the file is read and parsed successfully.
        /// null is returned if there is error reading/parsing the file or the source context file is not found.
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
        /// Find source context file and open the content.
        /// </summary>
        private static string Read()
        {
            if (s_filePath.Value == null)
            {
                return null;
            }
            try
            {
                return File.ReadAllText(s_filePath.Value);
            }
            catch (Exception ex) when (ex is IOException)
            {
                return null;
            }
        }

        private static string GetFilePath()
        {
#if NETSTANDARD1_3
            string root = AppContext.BaseDirectory;
#else
            string root = AppDomain.CurrentDomain.BaseDirectory;
#endif
            var fullPath = Path.Combine(root, SourceContextFileName);
            return File.Exists(fullPath) ? fullPath : null;
        }
    }
}
