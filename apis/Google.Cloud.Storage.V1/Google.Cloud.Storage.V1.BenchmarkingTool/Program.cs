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

using Google.Apis.Download;
using Google.Apis.Storage.v1.Data;
using Google.Apis.Upload;
using Google.Cloud.ClientTesting;
using System;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Threading;

namespace Google.Cloud.Storage.V1.BenchmarkingTool;

public static class Program
{
    private static readonly string s_projectId = TestEnvironment.GetTestProjectId(TestEnvironment.TestProjectEnvironmentVariable);
    private static readonly string[] s_logHeaders = { "Op", "ObjectSize", "AppBufferSize", "LibBufferSize", "Crc32cEnabled", "MD5Enabled", "ApiName", "CpuTimeUs", "ElapsedTimeUs", "Status" };
    // These are TimeSpan/DateTime ticks, not Stopwatch ticks. 1 TimeSpan/DateTime tick = 100 nanoseconds.
    private const long TimeSpanTicksPerMicrosecond = 10;

    private static void Main(string[] args)
    {
        Configuration configuration = null;
        try
        {
            configuration = Configuration.FromCommandLineArguments(args);
            CreateRandomFile(configuration); // Local file is created before the start of all W1R3 benchmark runs.
            var logger = new PerformanceLogger(configuration.OutputFolder);
            logger.Log(s_logHeaders);

            var client = StorageClient.Create();
            for (int i = 1; i <= configuration.NumOfSamples; i++)
            {
                Console.WriteLine($"Running W1R3 iteration number {i}..");
                RunW1R3Benchmark(configuration, client, logger);
            }
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

    private static void RunW1R3Benchmark(Configuration configuration, StorageClient client, PerformanceLogger logger)
    {
        try
        {
            CreateBucket(configuration, client);

            RunWriteTest(configuration, client, logger, "Write");
            RunReadTest(configuration, client, logger, "Read[1]");
            RunReadTest(configuration, client, logger, "Read[2]");
            RunReadTest(configuration, client, logger, "Read[3]");
        }
        finally
        {
            DeleteBucket(client, configuration.BucketName);
        }
    }

    private static Bucket CreateBucket(Configuration config, StorageClient client)
    {
        Bucket bucket = new Bucket
        {
            Location = config.BucketLocation,
            Name = config.BucketName,
            StorageClass = config.BucketStorageClass,
            Versioning = new Bucket.VersioningData { Enabled = config.ObjectVersioningEnabled },
        };

        var newlyCreatedBucket = client.CreateBucket(s_projectId, bucket);
        SleepAfterBucketCreateDelete();
        return newlyCreatedBucket;
    }

    private static void DeleteBucket(StorageClient client, string bucketName)
    {
        try
        {
            client.DeleteBucket(bucketName, new DeleteBucketOptions { UserProject = null, DeleteObjects = true });
        }
        catch (GoogleApiException)
        {
            // Some tests fail to delete buckets due to object retention locks etc.
            // They can be cleaned up later.
        }
        SleepAfterBucketCreateDelete();
    }

    /// <summary>
    /// Creates a local file containing random data.
    /// </summary>
    /// <param name="configuration"> An instance of <see cref="Configuration"/> containing new file's path and size.</param>
    private static void CreateRandomFile(Configuration configuration)
    {
        var random = new Random();
        long bytesLeft = configuration.DataSizeInBytes;
        byte[] buffer = new byte[1024 * 1024];
        using var output = File.Create(configuration.LocalFile);
        while (bytesLeft > 0)
        {
            random.NextBytes(buffer);
            int count = (int) Math.Min(bytesLeft, buffer.Length);
            output.Write(buffer, 0, count);
            bytesLeft -= count;
        }
    }

    private static void RunWriteTest(Configuration configuration, StorageClient client, PerformanceLogger logger, string opName)
    {
        string elapsedTimeUs = "-1";
        bool success = false;
        UploadObjectOptions options = null;
        if (configuration.UploadChunkSizeInBytes != 0)
        {
            options = new UploadObjectOptions { ChunkSize = configuration.UploadChunkSizeInBytes };
        }

        // Values in the same order as s_logHeaders
        string[] rowValues =
        {
            opName,
            configuration.DataSizeInBytes.ToString(),
            "NA", // AppBufferSize,
            (options?.ChunkSize ?? ResumableUpload.DefaultChunkSize).ToString(), // LibBufferSize
            "TRUE", // Crc32cEnabled
            "NA", // MD5Enabled
            "JSON", // ApiName
            "-1", // CpuTimeUs,
            null, // ElapsedTimeUs (populated later)
            null // Status (populated later)
        };

        try
        {
            Console.WriteLine("Uploading..");
            using var input = File.OpenRead(configuration.LocalFile);
            var stopwatch = Stopwatch.StartNew();
            client.UploadObject(configuration.BucketName, configuration.ObjectName, "application/binary", input, options);
            elapsedTimeUs = (stopwatch.Elapsed.Ticks / TimeSpanTicksPerMicrosecond).ToString(CultureInfo.InvariantCulture);
            success = true;
        }
        catch (Exception e)
        {
            Console.WriteLine($"Error while uploading : {e.Message}");
        }
        finally
        {
            rowValues[8] = elapsedTimeUs;
            rowValues[9] = success ? "OK" : "FAIL";
            logger.Log(rowValues);
        }
    }

    private static void RunReadTest(Configuration configuration, StorageClient client, PerformanceLogger logger, string opName)
    {
        var downloadFileName = $"{configuration.LocalFile}_downloaded";
        string elapsedTimeUs = "-1";
        bool success = false;
        DownloadObjectOptions options = null;
        if (configuration.DownloadChunkSizeInBytes != 0)
        {
            options = new DownloadObjectOptions { ChunkSize = configuration.DownloadChunkSizeInBytes };
        }

        // Values in the same order as s_logHeaders
        string[] rowValues =
        {
            opName,
            configuration.DataSizeInBytes.ToString(),
            "NA", // AppBufferSize,
            (options?.ChunkSize ?? MediaDownloader.MaximumChunkSize).ToString(), // LibBufferSize
            "TRUE", // Crc32cEnabled
            "NA", // MD5Enabled
            "JSON", // ApiName
            "-1", // CpuTimeUs,
            null, // ElapsedTimeUs (populated later)
            null // Status (populated later)
        };

        try
        {
            Console.WriteLine("Downloading..");
            using var output = new FileStream(downloadFileName, FileMode.CreateNew);
            var stopwatch = Stopwatch.StartNew();
            client.DownloadObject(configuration.BucketName, configuration.ObjectName, output, options);
            elapsedTimeUs = (stopwatch.Elapsed.Ticks / TimeSpanTicksPerMicrosecond).ToString(CultureInfo.InvariantCulture);
            success = true;
        }
        catch (Exception e)
        {
            Console.WriteLine($"Error while downloading : {e.Message}");
        }
        finally
        {
            rowValues[8] = elapsedTimeUs;
            rowValues[9] = success ? "OK" : "FAIL";
            logger.Log(rowValues);
            File.Delete(downloadFileName);
        }
    }

    private static void SleepAfterBucketCreateDelete() => Thread.Sleep(2000);
}
