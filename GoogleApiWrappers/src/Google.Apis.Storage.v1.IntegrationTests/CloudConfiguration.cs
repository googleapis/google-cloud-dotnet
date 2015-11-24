// Copyright 2015 Google Inc. All Rights Reserved.
// Licensed under the Apache License Version 2.0.
using Google.Apis.Storage.v1.ClientWrapper;
using System;
using System.Threading.Tasks;

namespace Google.Apis.Storage.v1.IntegrationTests
{
    /// <summary>
    /// Represents all the environmental information we need for integration tests,
    /// such as project name. We assume the user has already authenticated with gcloud auth.
    /// Currently a singleton, which is a bit of a smell... but we can refactor when we have better
    /// understanding of what we need.
    /// </summary>
    internal sealed class CloudConfiguration
    {
        private const string ProjectEnvironmentVariable = "TEST_PROJECT";

        internal static CloudConfiguration Instance { get; } = FromEnvironmentVariables();

        internal string Project { get; }
        internal string TempBucketPrefix { get; } = "integrationtests-";
        internal StorageClient Client { get; }

        private CloudConfiguration(string project)
        {
            Project = project;
            Client = Task.Run(async () => await StorageClient.FromApplicationCredentials("Test")).Result;
        }

        private static CloudConfiguration FromEnvironmentVariables()
        {
            var project = Environment.GetEnvironmentVariable(ProjectEnvironmentVariable);
            if (string.IsNullOrEmpty(project))
            {
                throw new InvalidOperationException($"Please set {ProjectEnvironmentVariable} before running tests");
            }
            return new CloudConfiguration(project);
        }
    }
}
