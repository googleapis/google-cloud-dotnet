// Copyright 2015 Google Inc. All Rights Reserved.
// Licensed under the Apache License Version 2.0.
using Google.Apis.Storage.v1.ClientWrapper;
using Microsoft.Framework.Runtime.Common.CommandLine;
using System;
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
                var project = config.Argument("project", "Google Cloud Project to list buckets from");
                ConfigureForExecution(config, client => ListBuckets(client, project.Value));
            }).Description = "List buckets in a Google Cloud Project";
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

        private static async Task ListBuckets(StorageClient client, string project)
        {
            var results = await client.ListAllBucketsAsync(project);
            Console.WriteLine($"Buckets in {project}:");
            foreach (var bucket in results)
            {
                Console.WriteLine($"  {bucket.Name}");
            }
        }
    }
}
