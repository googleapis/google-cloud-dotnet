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

namespace Google.Cloud.DevTools.Source.V1
{
    /// <summary>
    /// Utilities that reads source-context.json file from app root.
    /// </summary>
    public static class SourceContextFile
    {
        private const string SourceContextFileName = "source-context.json";
        private static Lazy<string> s_filePath = new Lazy<string>(GetFilePath);
        private static Lazy<SourceContext> s_sourceContext = new Lazy<SourceContext>(OpenParseFile);
        private static Lazy<string> s_gitRevisionId => new Lazy<string>(() => s_sourceContext.Value?.Git.RevisionId);

        /// <summary>
        /// Gets the custom log label of Stackdriver Logging entry for Git commit id.
        /// </summary>
        public const string GitRevisionIdLogLabel = "git_revision_id";

        /// <summary>
        /// Gets the Git revision id if it is present. 
        /// Returns null if there is no Git Repo source context found.
        /// </summary>
        public static string GitRevisionId => s_gitRevisionId.Value;

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

            try
            {
                return JsonParser.Default.Parse<SourceContext>(sourceContext);
            }
            catch (Exception ex) when (IsProtobufParserException(ex))
            {
                return null;
            }
        }

        /// <summary>
        /// Find source context file and open the content.
        /// </summary>
        private static string Read()
        {
            try
            {
                using (StreamReader sr = File.OpenText(s_filePath.Value))
                {
                    return sr.ReadToEnd();
                }
            }
            catch (Exception ex) when (IsIOException(ex))
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

        private static bool IsIOException(Exception ex)
        {
            return ex is FileNotFoundException
                || ex is DirectoryNotFoundException
                || ex is IOException
                || ex is UnauthorizedAccessException
                || ex is PathTooLongException;
        }

        private static bool IsProtobufParserException(Exception ex)
        {
            return ex is InvalidProtocolBufferException
                || ex is InvalidJsonException;
        }
    }
}