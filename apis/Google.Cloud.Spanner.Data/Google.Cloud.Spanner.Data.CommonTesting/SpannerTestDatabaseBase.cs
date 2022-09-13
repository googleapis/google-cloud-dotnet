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
using Google.Cloud.Spanner.Admin.Database.V1;
using Google.Cloud.Spanner.Admin.Instance.V1;
using Google.Cloud.Spanner.Common.V1;
using Google.Cloud.Spanner.V1.Internal.Logging;
using Grpc.Core;
using System;

namespace Google.Cloud.Spanner.Data.CommonTesting;

public abstract class SpannerTestDatabaseBase
{
    protected static readonly object s_lock = new object();

    public virtual string SpannerHost { get; } = GetEnvironmentVariableOrDefault("TEST_SPANNER_HOST", null);
    public virtual string SpannerPort { get; } = GetEnvironmentVariableOrDefault("TEST_SPANNER_PORT", null);
    public virtual string SpannerInstance { get; } = GetEnvironmentVariableOrDefault("TEST_SPANNER_INSTANCE", "spannerintegration");
    public abstract string SpannerDatabase { get; }

    /// <summary>
    /// Returns true if the database was created just for this test, or false if the database was an existing one
    /// specified through an environment variable.
    /// </summary>
    public abstract bool Fresh { get; }

    // Connection string including database, generated from the above properties
    public string ConnectionString { get; }
    // Connection string without the database, generated from the above properties
    public string NoDbConnectionString { get; }
    public string ProjectId { get; }
    public DatabaseName DatabaseName { get; }
    internal SpannerClientCreationOptions SpannerClientCreationOptions { get; }

    protected SpannerTestDatabaseBase(string projectId, DatabaseDialect dialect)
    {
        TestLogger.Install();
        ProjectId = projectId;
        var builder = new SpannerConnectionStringBuilder
        {
            Host = SpannerHost,
            DataSource = $"projects/{ProjectId}/instances/{SpannerInstance}",
            EmulatorDetection = dialect == DatabaseDialect.Postgresql ? EmulatorDetection.None : EmulatorDetection.EmulatorOrProduction
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

        if (dialect != DatabaseDialect.Postgresql)
        {
            // We create instance only on emulator. In production, we expect the instance to exist.
            MaybeCreateInstanceOnEmulator(projectId);
        }

        if (Fresh)
        {
            CreateDatabase(dialect);
            Logger.DefaultLogger.Debug($"Created database {SpannerDatabase} with {dialect} dialect.");
        }
        else
        {
            Logger.DefaultLogger.Debug($"Using existing database {SpannerDatabase}");
        }
    }

    protected static string GetEnvironmentVariableOrDefault(string name, string defaultValue)
    {
        string value = Environment.GetEnvironmentVariable(name);
        return string.IsNullOrEmpty(value) ? defaultValue : value;
    }

    protected virtual void CreateDatabase(DatabaseDialect dialect)
    {
        // PostgreSQL database can only be created by Admin APIs, which is not supported by Emulator for GSQL database creation.
        if (dialect == DatabaseDialect.Postgresql)
        {
            DatabaseAdminClient databaseAdminClient = DatabaseAdminClient.Create();
            CreateDatabaseRequest createDatabaseRequest = new CreateDatabaseRequest
            {
                CreateStatement = $"CREATE DATABASE {SpannerDatabase}",
                DatabaseDialect = dialect,
                ParentAsInstanceName = InstanceName.FromProjectInstance(ProjectId, SpannerInstance)
            };

            try
            {
                var operation = databaseAdminClient.CreateDatabase(createDatabaseRequest);
                var completedResponse = operation.PollUntilCompleted();
                if (completedResponse.IsFaulted)
                {
                    Logger.DefaultLogger.Debug($"Error while creating database with dialect {dialect}: {completedResponse.Exception}");
                    throw completedResponse.Exception;
                }

                Logger.DefaultLogger.Debug($"The database {SpannerDatabase} with dialect {dialect} created successfully.");
            }
            catch (RpcException e) when (e.StatusCode == StatusCode.AlreadyExists)
            {
                // Ignore.
            }
        }
        else
        {
            using var connection = new SpannerConnection(NoDbConnectionString);
            var createCmd = connection.CreateDdlCommand($"CREATE DATABASE {SpannerDatabase}");
            createCmd.ExecuteNonQuery();
            Logger.DefaultLogger.Debug($"Created database {SpannerDatabase}");
        }
    }

    protected virtual void MaybeCreateInstanceOnEmulator(string projectId)
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

    public virtual SpannerConnection GetConnection() => new SpannerConnection(ConnectionString);

    // Creates a SpannerConnection with a specific logger.
    public virtual SpannerConnection GetConnection(Logger logger, bool logCommitStats = false) =>
        new SpannerConnection(new SpannerConnectionStringBuilder(ConnectionString)
        {
            SessionPoolManager = SessionPoolManager.Create(new V1.SessionPoolOptions(), logger),
            LogCommitStats = logCommitStats
        });
}
