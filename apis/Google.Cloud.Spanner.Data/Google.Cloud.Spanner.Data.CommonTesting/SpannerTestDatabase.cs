// Copyright 2018 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Google.Api.Gax;
using Google.Cloud.ClientTesting;
using Google.Cloud.Spanner.V1.Internal.Logging;
using Google.Protobuf.Reflection;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using System;

namespace Google.Cloud.Spanner.Data.CommonTesting;

/// <summary>
/// A database created on-demand for testing. This is never dropped, partly as it's hard to know when to do so.
/// (This may be used by multiple fixtures, each created and then disposed, within the same test run.)
/// A tool is provided to clean up test databases.
/// </summary>
public sealed class SpannerTestDatabase : SpannerTestDatabaseBase
{
    private static readonly object s_lock = new object();

    private static SpannerTestDatabase s_instance = null;

    /// <summary>
    /// Fetches the database, creating it if necessary.
    /// </summary>
    /// <param name="projectId">The project ID to use, typically from a fixture.</param>
    public static SpannerTestDatabase Create(string projectId)
    {
        lock (s_lock)
        {
            if (s_instance == null)
            {
                s_instance = new SpannerTestDatabase(projectId);
            }
            else if (s_instance.ProjectId != projectId)
            {
                throw new ArgumentException($"A database for project ID {s_instance.ProjectId} has already been created; this test requested {projectId}");
            }
            return s_instance;
        }
    }

    private static readonly string s_generatedDatabaseName = IdGenerator.FromDateTime(prefix: "testdb_", pattern: "yyyyMMdd't'HHmmss");

    /// <inheritdoc/>
    public override string GeneratedDatabaseName => s_generatedDatabaseName;

    /// <inheritdoc/>
    public override string SpannerDatabaseEnvVariable => "TEST_SPANNER_DATABASE";

    /// <summary>
    /// Initializes a new instance of the <see cref="SpannerTestDatabase"/> class.
    /// </summary>
    /// <param name="projectId">The project ID to use for test database.</param>
    private SpannerTestDatabase(string projectId) : base(projectId, EmulatorDetection.EmulatorOrProduction)
    {
    }

    protected override bool TryCreateDatabase()
    {
        FileDescriptorSet fileDescriptorSet = new FileDescriptorSet
        {
            File =
            {
                Duration.Descriptor.File.ToProto(),
                Rectangle.Descriptor.File.ToProto(),
                ValueWrapper.Descriptor.File.ToProto(),
                Value.Descriptor.File.ToProto(),
                Person.Descriptor.File.ToProto()
            }
        };

        using var connection = new SpannerConnection(NoDbConnectionString);
        var createCmd = connection.CreateDdlCommand($"CREATE DATABASE {SpannerDatabase}",protobufDescriptors: fileDescriptorSet,
            $"CREATE PROTO BUNDLE (" +
            $"{Point.Descriptor.FullName}" +
            $", {Rectangle.Descriptor.FullName}" +
            $", {Duration.Descriptor.FullName}" +
            $", {Person.Descriptor.FullName}" +
            $", {ValueWrapper.Descriptor.FullName}" +
            $", {Value.Descriptor.FindFieldByNumber(Value.NullValueFieldNumber).EnumType.FullName}" +
            $", {ListValue.Descriptor.FullName}" +
            $", {Value.Descriptor.FullName}" +
            $")");
        try
        {
            createCmd.ExecuteNonQuery();
            Logger.DefaultLogger.Debug($"Created database {SpannerDatabase}.");
            return true;
        }
        catch (SpannerException e) when (e.RpcException?.StatusCode == StatusCode.AlreadyExists)
        {
            return false;
        }
    }
}
