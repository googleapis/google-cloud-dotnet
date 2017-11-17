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
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Google.Apis.Auth.OAuth2;
using Google.Cloud.Spanner.V1;
using Google.Cloud.Spanner.V1.Internal.Logging;
using Google.Protobuf.WellKnownTypes;
using Grpc.Auth;
using Grpc.Core;
using TypeCode = Google.Cloud.Spanner.V1.TypeCode;

namespace Google.Cloud.Spanner.Data.Ycsb
{
    internal class Program : YcsbRunner
    {
        private static readonly string s_tableName = "table";
        private static readonly string s_cloudspanner_instanceName = "cloudspanner.instance";
        private static readonly string s_cloudspanner_databaseName = "cloudspanner.database";
        private static readonly string s_cloudspanner_projectName = "cloudspanner.project";
        private static readonly string s_boundedStaleness = "cloudspanner.boundedstaleness";
        private static readonly string s_numchannels = "cloudspanner.numchannels";
        private static readonly string s_raw = "cloudspanner.raw"; //execute directly bypassing veneer and gapic
        private static readonly string s_empty = "cloudspanner.empty"; //do nothing -- just pretend to run.

        private static long s_boundedStalenessSeconds;
        private static readonly List<string> s_keys = new List<string>();

        private static string s_table;
        private static string s_instance;
        private static string s_database;
        private static string s_project;
        private static string s_connectionString;
        private static string s_selectQuery;

        private static readonly string[] s_fieldNames =
        {
            "field0",
            "field1",
            "field2",
            "field3",
            "field4",
            "field5",
            "field6",
            "field7",
            "field8",
            "field9"
        };

        private static SpannerConnection s_connection;
        private static TimestampBound s_timestampbound;
        private static SpannerClient s_rawclient;
        private static ConcurrentQueue<Session> s_rawsessions = new ConcurrentQueue<Session>();
        private static Program DefaultInstance { get; } = new Program();

        protected override List<Operation> Operations { get; } = new List<Operation>
        {
            new Operation(
                "readproportion", async latencies =>
                {
                    await Task.Yield();
                    var sw = Stopwatch.StartNew();
                    if (!IsEmpty)
                    {
                        if (IsRaw)
                        {
                            await RawStreamingReadOperationAsync();
                        }
                        else
                        {
                            await StreamingReadOperationAsync();
                        }
                    }
                    latencies.Add(sw.ElapsedMilliseconds);
                }),
            new Operation(
                "updateproportion", async latencies =>
                {
                    await Task.Yield();
                    var sw = Stopwatch.StartNew();
                    if (!IsEmpty)
                    {
                        if (IsRaw)
                        {
                            await RawUpdateOperationAsync().ConfigureAwait(false);
                        }
                        else
                        {
                            await UpdateOperationAsync().ConfigureAwait(false);
                        }
                    }
                    latencies.Add(sw.ElapsedMilliseconds);
                }),
            new Operation("scanproportion", x => throw new NotImplementedException("scan is not yet implemented")),
            new Operation("insertproportion", x => throw new NotImplementedException("scan is not yet implemented"))
        };

        private static Task UpdateOperationAsync()
        {
            var cmd = s_connection.CreateUpdateCommand(
                s_table,
                new SpannerParameterCollection
                {
                    {"id", SpannerDbType.String, s_keys[Rand.Value.Next(s_keys.Count)]},
                    {s_fieldNames[Rand.Value.Next(10)], SpannerDbType.String, GenerateRandomString()}
                });
            return cmd.ExecuteNonQueryAsync();
        }

        private static Task RawUpdateOperationAsync() => RawStreamingReadOperationAsync();

        private static async Task StreamingReadOperationAsync()
        {
            var cmd = s_connection.CreateSelectCommand(
                s_selectQuery, new SpannerParameterCollection
                {
                    {"p", SpannerDbType.String, s_keys[Rand.Value.Next(s_keys.Count)]}
                });
            using (var reader = await cmd.ExecuteReaderAsync(s_timestampbound).ConfigureAwait(false))
            {
                while (await reader.ReadAsync().ConfigureAwait(false)) { }
            }
        }

        private static V1.Type s_stringType = new V1.Type { Code = TypeCode.String};

        private static async Task RawStreamingReadOperationAsync()
        {
            Session session;
            s_rawsessions.TryDequeue(out session);
            var stream = s_rawclient.ExecuteStreamingSql(
                new ExecuteSqlRequest
                {
                    SessionAsSessionName = session.SessionName,
                    Sql = s_selectQuery,
                    Params = new Struct { Fields = { {"p", new Value { StringValue = s_keys[Rand.Value.Next(s_keys.Count)] }}}},
                    ParamTypes = { {"p", s_stringType } },
                    Transaction = new TransactionSelector
                    {
                        SingleUse = new TransactionOptions
                        {
                            ReadOnly = new TransactionOptions.Types.ReadOnly
                            {
                                Strong = true
                            }
                        }
                    }
                });
            while (await stream.ResponseStream.MoveNext().ConfigureAwait(false))
            {
            }
            stream.ResponseStream.Dispose();
            s_rawsessions.Enqueue(session);
        }

        public static int Main(string[] args) => DefaultInstance.Run(args);

        /// <summary>
        /// Runs a single worker task
        /// </summary>
        protected override async Task PreWarmOneInstance()
        {
            if (!IsRaw && !IsEmpty)
            {
                using (var spannerConnection = new SpannerConnection(
                    $"Data Source=projects/{s_project}/instances/{s_instance}/databases/{s_database}"))
                {
                    await spannerConnection.OpenAsync();
                }
            }
        }

        protected override void InitializeSettings()
        {
            base.InitializeSettings();
            if (!IsEmpty)
            {
                s_table = GetOption<string>(s_tableName);
                s_instance = GetOption<string>(s_cloudspanner_instanceName);
                s_database = GetOption<string>(s_cloudspanner_databaseName);
                s_project = GetOption<string>(s_cloudspanner_projectName);
                s_boundedStalenessSeconds = GetOptionWithDefault(s_boundedStaleness, 0);
            }
            if (IsDebugMode)
            {
                Logger.DefaultLogger.LogPerformanceTraces = true;
                if (GetOption<int>("debugmode") == 2)
                {
                    Logger.DefaultLogger.LogLevel = V1.Internal.Logging.LogLevel.Debug;
                }
            }

            int targetQps = GetOptionWithDefault(TargetQps, 0);
            if (targetQps > 0)
            {
                int countToPreWarm = Math.Min(targetQps / 4, 800);
                Options[Prewarm] = countToPreWarm;
                SpannerOptions.Instance.MaximumActiveSessions = Math.Max(countToPreWarm + 50, 400);
                SpannerOptions.Instance.MaximumPooledSessions = Math.Max(countToPreWarm + 50, 400);
                SpannerOptions.Instance.MaximumGrpcChannels = Math.Max(4, 8 * targetQps / 2000);
            }
            else
            {
                SpannerConnection.SpannerOptions.MaximumGrpcChannels = GetOptionWithDefault(s_numchannels, 1);
                SpannerConnection.SpannerOptions.MaximumPooledSessions = Math.Max(
                    GetOption<int>(NumWorker) + 1,
                    GetOptionWithDefault(Prewarm, 0));
            }
            LoadKeys();
            s_timestampbound = s_boundedStalenessSeconds > 0
                ? TimestampBound.OfMaxStaleness(TimeSpan.FromSeconds(s_boundedStalenessSeconds))
                : TimestampBound.Strong;
            if (IsRaw)
            {
                s_rawclient = SpannerClient.Create();
                for (int i = 0; i < GetOption<int>(NumWorker); i++)
                {
                    s_rawsessions.Enqueue(
                        s_rawclient.CreateSession(new DatabaseName(s_project, s_instance, s_database)));
                }
            }
        }

        private void LoadKeys()
        {
            if (!IsEmpty)
            {
                s_connectionString = $"Data Source=projects/{s_project}/instances/{s_instance}/databases/{s_database}";
                s_selectQuery = $"SELECT u.* FROM {s_table} u WHERE u.id=@p";
                s_connection = new SpannerConnection(s_connectionString);
                s_connection.Open();

                DebugMessage("Loading keys...");
                var cmd = s_connection.CreateSelectCommand($"SELECT u.id FROM {s_table} u");
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    s_keys.Add(reader.GetString(0));
                }
            }
        }

        private static bool IsRaw => GetOptionWithDefault(s_raw, false);

        private static bool IsEmpty => GetOptionWithDefault(s_empty, false);

    }
}
