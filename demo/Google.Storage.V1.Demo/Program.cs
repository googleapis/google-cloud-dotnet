// Copyright 2015 Google Inc. All Rights Reserved.
// Licensed under the Apache License Version 2.0.
using Google.Apis.Download;
using Google.Storage.V1;
using Google.Apis.Upload;
using Microsoft.Framework.Runtime.Common.CommandLine;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Storage.V1.Demo
{
    /// <summary>
    /// Command line application to demonstrate features of the Google Cloud Storage client wrapper library.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Entry point for the application.
        /// </summary>
        public int Main(string[] args)
        {
            var app = new CommandLineApplication
            {
                Name = "storage-demo",
                Description = "Demonstrates the Google Cloud Storage client wrapper library",
                FullName = "storage-demo - simple demonstration application for the Google Cloud Storage wrapper",                
            };

            app.OnExecute(() =>
            {
                app.ShowHelp();
                return 2;
            });

            app.Command("list-buckets", config => {
                config.HelpOption("-?|-h|--help");
                config.Description = "List buckets in a Google Cloud Project";
                var project = config.Argument("project", "Google Cloud Project ID to list buckets from");
                ConfigureForExecution(config, client => ListBuckets(client, project.Value));
            });
            app.Command("list-objects", config => {
                config.Description = "List objects in a bucket";
                config.HelpOption("-?|-h|--help");
                var bucket = config.Argument("bucket", "Bucket to list objects from");
                var prefix = config.Option("--prefix", "Prefix to match", CommandOptionType.SingleValue);
                ConfigureForExecution(config, client => ListObjects(client, bucket.Value, prefix.Value()));
            });
            app.Command("download-object", config => {
                config.HelpOption("-?|-h|--help");
                config.Description = "Downloads an object, saving it to the local disk";
                var bucket = config.Argument("bucket", "Bucket containing the object");
                var source = config.Argument("source", "Name of object to download");
                var destination = config.Argument("destination", "Destination filename");
                ConfigureForExecution(config, client => DownloadObject(client, bucket.Value, source.Value, destination.Value));
            });
            app.Command("upload-object", config => {
                config.HelpOption("-?|-h|--help");
                config.Description = "Uploads an object from the local disk";
                var source = config.Argument("source", "Name of file to upload");
                var bucket = config.Argument("bucket", "Bucket to upload the object to");
                var destination = config.Argument("destination", "Name of object to create/update in the bucket");
                var contentType = config.Option("--contentType", "Content type", CommandOptionType.SingleValue);
                ConfigureForExecution(config, client => UploadObject(client, source.Value, bucket.Value, destination.Value, contentType.Value()));
            });
            app.Command("get-object", config => {
                config.HelpOption("-?|-h|--help");
                config.Description = "Gets information about an object, displaying it as JSON";
                var bucket = config.Argument("bucket", "Bucket containing the object");
                var name = config.Argument("name", "Name of object to fetch information about");
                ConfigureForExecution(config, client => GetObject(client, bucket.Value, name.Value));
            });
            app.Command("delete-object", config => {
                config.HelpOption("-?|-h|--help");
                config.Description = "Deletes the latest generation of an object from storage";
                var bucket = config.Argument("bucket", "Bucket containing the object");
                var name = config.Argument("name", "Name of object to delete");
                var generation = config.Option("--generation", "Generation", CommandOptionType.SingleValue);
                ConfigureForExecution(config, client => DeleteObject(client, bucket.Value, name.Value, generation.Value()));
            });

            return app.Execute(args);
        }

        /// <summary>
        /// Helper method to validate that all arguments have been provided, obtain a StorageClient,
        /// and then call the given command. We might want to make this an extension method at some point.
        /// </summary>
        private static void ConfigureForExecution(CommandLineApplication config, Func<StorageClient, Task> command)
        {
            config.OnExecute(async () =>
            {
                foreach (var argument in config.Arguments)
                {
                    if (argument.Values.Count == 0)
                    {
                        Console.WriteLine($"Argument '{argument.Name}' not specified");
                        return 1;
                    }
                }
                try
                {
                    var client = await StorageClient.FromApplicationCredentials("Demo");
                    await command(client);
                    return 0;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    return 1;
                }
            });
        }

        private static async Task ListBuckets(StorageClient client, string projectId)
        {
            Console.WriteLine($"Buckets in {projectId}:");
            var results = await client.ListAllBucketsAsync(projectId, new ListBucketsOptions { PageSize = 3 });
            foreach (var bucket in results)
            {
                Console.WriteLine($"  {bucket.Name}");
            }
        }

        private static async Task ListObjects(StorageClient client, string bucket, string prefix)
        {
            Console.WriteLine($"Objects in {bucket}:");
            var results = await client.ListAllObjectsAsync(bucket, prefix, new ListObjectsOptions { PageSize = 3 });
            foreach (var obj in results)
            {
                Console.WriteLine($"  {obj.Name}");
            }
        }

        private static async Task DownloadObject(StorageClient client, string bucket, string source, string destination)
        {
            using (var output = File.Create(destination))
            {
                var progress = new Progress<IDownloadProgress>(
                    p => Console.WriteLine($"Downloaded {p.BytesDownloaded} bytes; status: {p.Status}"));

                await client.DownloadObjectAsync(bucket, source, output,
                    new DownloadObjectOptions { ChunkSize = 256 * 1024 },
                    CancellationToken.None, progress);
            }
        }

        private static async Task UploadObject(StorageClient client, string source, string bucket, string destination, string contentType)
        {
            using (var input = File.OpenRead(source))
            {
                var progress = new Progress<IUploadProgress>(
                    p => Console.WriteLine($"Uploaded {p.BytesSent} bytes; status: {p.Status}"));

                await client.UploadObjectAsync(bucket, destination, contentType ?? "", input,
                    new UploadObjectOptions { ChunkSize = 256 * 1024 },
                    CancellationToken.None, progress);
            }
        }

        private static async Task GetObject(StorageClient client, string bucket, string name)
        {
            var obj = await client.GetObjectAsync(bucket, name);
            Console.WriteLine(JsonConvert.SerializeObject(obj, Formatting.Indented));
        }

        private static async Task DeleteObject(StorageClient client, string bucket, string name, string generation)
        {
            long? generationOption = generation == null ? default(long?) : long.Parse(generation);
            await client.DeleteObjectAsync(bucket, name, new DeleteObjectOptions { Generation = generationOption }, CancellationToken.None);
            Console.WriteLine($"Deleted object {bucket}/{name}");
        }
    }
}
