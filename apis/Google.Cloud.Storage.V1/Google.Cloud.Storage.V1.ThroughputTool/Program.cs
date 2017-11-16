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
    public static class Program
    {
        private static void Main(string[] args)
        {
            Configuration configuration = null;
            try
            {
                configuration = Configuration.FromCommandLineArguments(args);
                CreateFile(configuration);
                RunUpload(configuration);
                RunDownload(configuration);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                if (configuration != null)
                {
                    File.Delete(configuration.LocalFile);
                }
            }
        }

        private static void CreateFile(Configuration configuration)
        {
            var random = new Random();
            long bytesLeft = configuration.SizeBytes;
            byte[] buffer = new byte[1024 * 1024];
            using (var output = File.Create(configuration.LocalFile))
            {
                while (bytesLeft > 0)
                {
                    random.NextBytes(buffer);
                    int count = (int) Math.Min(bytesLeft, buffer.Length);
                    output.Write(buffer, 0, count);
                    bytesLeft -= count;
                }
            }
        }

        private static void RunUpload(Configuration configuration)
        {
            var client = StorageClient.Create();
            Console.WriteLine("Uploading");
            using (var input = File.OpenRead(configuration.LocalFile))
            {
                using (var reporter = new ProgressReporter())
                {
                    client.UploadObject(configuration.Bucket, configuration.ObjectName, "application/binary", input, progress: reporter);
                }
            }
            Console.WriteLine();
        }

        private static void RunDownload(Configuration configuration)
        {
            var client = StorageClient.Create();
            Console.WriteLine("Downloading");
            using (var output = new NullStream())
            {
                using (var reporter = new ProgressReporter())
                {
                    client.DownloadObject(configuration.Bucket, configuration.ObjectName, output, progress: reporter);
                }
            }
            Console.WriteLine();
        }
    }
}
