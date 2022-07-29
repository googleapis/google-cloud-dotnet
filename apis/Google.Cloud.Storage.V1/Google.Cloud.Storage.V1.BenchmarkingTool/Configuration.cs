// Copyright 2022 Google Inc. All Rights Reserved.
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

using Google.Cloud.ClientTesting;
using System;
using System.IO;

namespace Google.Cloud.Storage.V1.BenchmarkingTool;

/// <summary>
/// Configuration for the benchmarking tool.
/// </summary>
internal sealed class Configuration
{
    internal int NumOfSamples { get; }
    internal int DataSizeInBytes { get; }
    internal string LocalFile { get; }
    internal string OutputFolder { get; }
    internal int UploadChunkSizeInBytes { get; }
    internal int DownloadChunkSizeInBytes { get; }
    internal string BucketStorageClass { get; }
    internal string BucketLocation { get; }
    internal bool ObjectVersioningEnabled { get; }
    internal string BucketName { get; } = IdGenerator.FromDateTime(prefix: "benchmark-");
    internal string ObjectName => "obj_random_data";

    private Configuration(
        int numOfSamples,
        int dataSizeInBytes,
        string outputFolder,
        int uploadChunkSizeInBytes,
        int downloadChunkSizeInBytes,
        string bucketLocation,
        string bucketStorageClass,
        bool objectVersioningEnabled)
    {
        DataSizeInBytes = dataSizeInBytes;
        LocalFile = Path.GetTempFileName();
        OutputFolder = outputFolder;
        UploadChunkSizeInBytes = uploadChunkSizeInBytes;
        DownloadChunkSizeInBytes = downloadChunkSizeInBytes;
        NumOfSamples = numOfSamples;
        BucketLocation = bucketLocation;
        BucketStorageClass = bucketStorageClass;
        ObjectVersioningEnabled = objectVersioningEnabled;
    }

    internal static Configuration FromCommandLineArguments(string[] args)
    {
        if (args.Length != 8)
        {
            throw new ArgumentException("Error: 8 arguments required: \n" +

                "<Number of samples> \n" +
                "<File size in MiB> \n" +
                "<Output folder path> \n" +
                "<Upload Buffer Size in MiB: Pass '0' for DefaultBufferSize> \n" +
                "<Download Buffer Size in MiB: Pass '0' for DefaultBufferSize> \n" +
                "<Bucket storage class: Values can be REGIONAL, MULTI_REGIONAL, STANDARD, NEARLINE, COLDLINE, ARCHIVE, DURABLE_REDUCED_AVAILABILITY> \n" +
                "<Bucket location> \n" +
                "<Object versioning enabled: Pass True Or False> \n");
        }

        if (!int.TryParse(args[0], out int numOfSamples) || numOfSamples < 1) // ars[0] is the total number of times W1R3 needs to be run.
        {
            throw new ArgumentException("Error: Number of samples should be positive number.");
        }

        if (!int.TryParse(args[1], out int fileSize) || fileSize < 1) // args[1] is the file size in MiB that should be generated and uploaded.
        {
            throw new ArgumentException("Error: File size should be positive number.");
        }

        if (!Directory.Exists(args[2])) // args[2] is the folder path where log will be generated.
        {
            throw new ArgumentException("Error: Please provide a valid output folder path.");
        }

        // args[3] and args[4] are the chunk sizes in which data can be uploaded or downloaded respectively.
        if (!int.TryParse(args[3], out int uploadChunkSize) || uploadChunkSize < 0
         || !int.TryParse(args[4], out int downloadChunkSize) || downloadChunkSize < 0)
        {
            throw new ArgumentException("Error: Please provide buffer size either '0' or a positive number.");
        }

        if (!bool.TryParse(args[7], out bool objVersionedEnabled))
        {
            throw new ArgumentException("Error: Please provide object versioning enabled either True or False");
        }

        return new Configuration(
            numOfSamples,
            ConvertMiBToBytes(fileSize),
            args[2],
            ConvertMiBToBytes(uploadChunkSize),
            ConvertMiBToBytes(downloadChunkSize),
            args[5], // args[5] is the bucket's location.
            args[6], // args[6] is the bucket's storage class.
            objVersionedEnabled);
    }

    private static int ConvertMiBToBytes(int dataInMiB) => dataInMiB * 1024 * 1024;
}
