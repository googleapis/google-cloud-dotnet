// Copyright 2015 Google Inc. All Rights Reserved.
// Licensed under the Apache License Version 2.0.
using Google.Apis.Download;
using Google.Apis.Storage.v1.ClientWrapper;
using Microsoft.Framework.Runtime.Common.CommandLine;
using System;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Apis.Storage.v1.Demo
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
                var project = config.Argument("project", "Google Cloud Project to list buckets from");
                ConfigureForExecution(config, client => ListBuckets(client, project.Value));
            });
            app.Command("list-objects", config => {
                config.Description = "List objects in a bucket";
                config.HelpOption("-?|-h|--help");
                var bucket = config.Argument("bucket", "Bucket to list objects from");
                ConfigureForExecution(config, client => ListObjects(client, bucket.Value));
            });
            app.Command("download-object", config => {
                config.HelpOption("-?|-h|--help");
                config.Description = "Downloads an object, saving it to the local disk";
                var bucket = config.Argument("bucket", "Bucket to list objects from");
                var source = config.Argument("source", "Name of object to download");
                var destination = config.Argument("destination", "Destination filename");
                ConfigureForExecution(config, client => DownloadObject(client, bucket.Value, source.Value, destination.Value));
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

        private static Task ListBuckets(StorageClient client, string project)
        {
            var results = client.ListBucketsAsync(project, new ListBucketsOptions { PageSize = 3 });
            Console.WriteLine($"Buckets in {project} (3 at a time):");
            return results.ForEachAsync(bucket => Console.WriteLine($"  {bucket.Name}"));
        }

        private static Task ListObjects(StorageClient client, string bucket)
        {
            var results = client.ListObjectsAsync(bucket, new ListObjectsOptions { PageSize = 3 });
            Console.WriteLine($"Objects in {bucket} (3 at a time):");
            return results.ForEachAsync(obj => Console.WriteLine($"  {obj.Name}"));
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
    }
}
