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
using System.IO;

namespace Google.Cloud.Storage.V1.ThroughputTool
{
    /// <summary>
    /// Configuration for the test.
    /// </summary>
    internal sealed class Configuration
    {
        public string Bucket { get; }
        public string ObjectName { get; }
        public long SizeBytes { get; }
        public string LocalFile { get; }

        private Configuration(string bucket, string objectName, long sizeBytes)
        {
            Bucket = bucket;
            ObjectName = objectName;
            SizeBytes = sizeBytes;
            LocalFile = Path.GetTempFileName();
        }

        public static Configuration FromCommandLineArguments(string[] args)
        {
            if (args.Length != 3)
            {
                throw new Exception("Error: 3 arguments required: <bucket> <name> <size in MB>");
            }
            return new Configuration(args[0], args[1], long.Parse(args[2]) * 1024L * 1024L);
        }
    }
}
