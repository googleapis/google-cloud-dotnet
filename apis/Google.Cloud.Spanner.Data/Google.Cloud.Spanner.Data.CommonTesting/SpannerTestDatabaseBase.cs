// Copyright 2022 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License").
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Google.Api.Gax;
using Google.Api.Gax.ResourceNames;
using Google.Cloud.Spanner.Admin.Instance.V1;
using Google.Cloud.Spanner.Common.V1;
using Google.Cloud.Spanner.V1;
using Google.Cloud.Spanner.V1.Internal.Logging;
using Grpc.Core;
using System;
using System.Threading.Tasks;

namespace Google.Cloud.Spanner.Data.CommonTesting;

/// <summary>
/// Base class for Spanner Test database.
/// </summary>
public abstract class SpannerTestDatabaseBase
{
    private ManagedSession _multiplexSession;

    /// <summary>
    /// The Spanner Host name to connect to. It is read from the environment variable "TEST_SPANNER_HOST".
    /// </summary>
    public string SpannerHost { get; } = GetEnvironmentVariableOrDefault("TEST_SPANNER_HOST", null);

    /// <summary>
    /// The Spanner port number to connect to. It is read from the environment variable "TEST_SPANNER_PORT".
    /// </summary>
    public string SpannerPort { get; } = GetEnvironmentVariableOrDefault("TEST_SPANNER_PORT", null);

    /// <summary>
    /// The Spanner Instance name to connect to. It is read from the environment variable "TEST_SPANNER_INSTANCE".
    /// </summary>
    public string SpannerInstance { get; } = GetEnvironmentVariableOrDefault("TEST_SPANNER_INSTANCE", "spannerintegration");

    /// <summary>
    /// The generated name for the database.
    /// The derived class must provide its implementation to return the database name.
    /// </summary>
    public abstract string GeneratedDatabaseName { get; }

    /// <summary>
    /// The environment variable from which the Spanner database name is read.
    /// </summary>
    public abstract string SpannerDatabaseEnvVariable { get; }

    /// <summary>
    /// The Spanner Database name to connect to.
    /// </summary>
    public string SpannerDatabase { get; }

    /// <summary>
    /// Returns true if a new database was created just for this test, false otherwise.
    /// </summary>
    public bool Fresh { get; }

    /// <summary>
    /// Connection string including database.
    /// </summary>
    public string ConnectionString { get; }

    /// <summary>
    /// Connection string without the database.
    /// </summary>
    public string NoDbConnectionString { get; }

    /// <summary>
    /// The GCP Project ID to be used for the test database.
    /// </summary>
    public string ProjectId { get; }

    /// <summary>
    /// The fully-qualified database name.
    /// </summary>
    public DatabaseName DatabaseName { get; }

    internal SpannerClientCreationOptions SpannerClientCreationOptions { get; }

    protected SpannerTestDatabaseBase(string projectId, EmulatorDetection emulatorDetection)
    {
        TestLogger.Install();
        SpannerDatabase = GetEnvironmentVariableOrDefault(SpannerDatabaseEnvVariable, GeneratedDatabaseName);
        ProjectId = projectId;
        var builder = new SpannerConnectionStringBuilder
        {
            Host = SpannerHost,
            DataSource = $"projects/{ProjectId}/instances/{SpannerInstance}",
            EmulatorDetection = emulatorDetection
        };
        if (SpannerPort != null)
        {
            builder.Port = int.Parse(SpannerPort);
        }
        NoDbConnectionString = builder.ConnectionString;
        SpannerClientCreationOptions = new SpannerClientCreationOptions(builder);
        var databaseBuilder = builder.WithDatabase(SpannerDatabase);
        ConnectionString = databaseBuilder.ConnectionString;
        DatabaseName = databaseBuilder.DatabaseName;

        // We create database instance only on the emulator.
        // In production, we expect the instance to already exist.
        MaybeCreateInstanceOnEmulator(projectId);

        Fresh = TryCreateDatabase();
        if (!Fresh)
        {
            Logger.DefaultLogger.Debug($"Using existing database {SpannerDatabase}.");
        }
    }

    protected static string GetEnvironmentVariableOrDefault(string name, string defaultValue)
    {
        string value = Environment.GetEnvironmentVariable(name);
        return string.IsNullOrEmpty(value) ? defaultValue : value;
    }

    /// <summary>
    /// Creates a new database with name <cref name="SpannerDatabase /> if it doesn't exist already.
    /// </summary>
    /// <returns>true if the database creation was successful; false otherwise.</returns>
    protected abstract bool TryCreateDatabase();

    protected void MaybeCreateInstanceOnEmulator(string projectId)
    {
        if (SpannerClientCreationOptions.UsesEmulator)
        {
#if NETSTANDARD2_1
            // On .NET Core 3.1 (but not .NET 6) Grpc.Net.Client needs an additional switch
            // to allow an insecure channel in HTTP/2.
            AppContext.SetSwitch("System.Net.Http.SocketsHttpHandler.Http2UnencryptedSupport", true);
#endif
            // Try to create an instance on the emulator and ignore any AlreadyExists error.
            var adminClientBuilder = new InstanceAdminClientBuilder
            {
                EmulatorDetection = EmulatorDetection.EmulatorOnly
            };
            var instanceAdminClient = adminClientBuilder.Build();

            var instanceName = InstanceName.FromProjectInstance(projectId, SpannerInstance);
            try
            {
                instanceAdminClient.CreateInstance(new CreateInstanceRequest
                {
                    InstanceId = instanceName.InstanceId,
                    ParentAsProjectName = ProjectName.FromProject(projectId),
                    Instance = new Instance
                    {
                        InstanceName = instanceName,
                        ConfigAsInstanceConfigName = new InstanceConfigName(projectId, "emulator-config"),
                        DisplayName = "Test Instance",
                        NodeCount = 1,
                    },
                }).PollUntilCompleted();
            }
            catch (RpcException e) when (e.StatusCode == StatusCode.AlreadyExists)
            {
                // Ignore
            }
        }
    }

    /// <summary>
    /// Creates a <see cref="SpannerConnection"/> with a specific logger.
    /// </summary>
    /// <returns>The SpannerConnection.</returns>
    public SpannerConnection GetConnection(Logger logger, bool logCommitStats = false) =>
        new SpannerConnection(new SpannerConnectionStringBuilder(ConnectionString)
        {
            SessionPoolManager = SessionPoolManager.Create(new ManagedSessionOptions(), logger),
            LogCommitStats = logCommitStats
        });

    public async Task<ManagedSession> GetManagedSession()
    {
        if (_multiplexSession != null && GetEnvironmentVariableOrDefault("SPANNER_EMULATOR_HOST", null) == null)
        {
            // Only return the same multiplex session if we are NOT testing on the emulator
            // The emulator does not handle concurrent transactions on a single multiplex session well
            return _multiplexSession;
        }

        var options = new ManagedSessionOptions();

        _multiplexSession = await CreateMultiplexSession(options).ConfigureAwait(false);

        return _multiplexSession;
    }

    private async Task<ManagedSession> CreateMultiplexSession(ManagedSessionOptions options)
    {
        var poolManager = SessionPoolManager.Create(options);
        var muxSession = await poolManager.AcquireManagedSessionAsync(SpannerClientCreationOptions, DatabaseName, null);

        return muxSession;
    }
}
