// Copyright 2026 Google LLC
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

using Google.Apis.Bigquery.v2.Data;
using System;
using System.Collections.Generic;

namespace Google.Cloud.BigQuery.V2;

/// <summary>
/// Options for <c>ExecuteStatelessQuery</c> operations.
/// </summary>
internal sealed class StatelessQueryOptions
{
    /// <summary>
    /// Optional connection properties which can modify the query behavior.
    /// </summary>
    internal IList<ConnectionProperty> ConnectionProperties { get; set; }

    /// <summary>
    /// Specifies whether the query should be executed as a continuous query.
    /// If not set, this is effectively <c>false</c>.
    /// </summary>
    internal bool? Continuous { get; set; }

    /// <summary>
    /// If <c>true</c>, creates a new session using a randomly generated session ID.
    /// If <c>false</c>, runs the query in non-session mode unless a session ID is provided in <see cref="ConnectionProperties"/>.
    /// </summary>
    internal bool? CreateSession { get; set; }

    /// <summary>
    /// The default dataset to assume for any unqualified table names in the query.
    /// If this is not set, all table names must be fully qualified.
    /// </summary>
    internal DatasetReference DefaultDataset { get; set; }

    /// <summary>
    /// The encryption configuration to apply to the destination table, if any.
    /// </summary>
    internal EncryptionConfiguration DestinationEncryptionConfiguration { get; set; }

    /// <summary>
    /// If set to true, don't actually run this query. A valid query will return a mostly empty response
    /// with some processing statistics, while an invalid query will return the same error it would if it wasn't a dry run.
    /// This option can be used to determine the schema of the query without running it.
    /// </summary>
    internal bool? DryRun { get; set; }

    /// <summary>
    /// Optional output format adjustments.
    /// </summary>
    internal DataFormatOptions FormatOptions { get; set; }

    /// <summary>
    /// Specifies whether a job is required to be created.
    /// If not set, this is effectively <see cref="JobCreationMode.Required"/>.
    /// </summary>
    internal JobCreationMode? JobCreationMode { get; set; }

    /// <summary>
    /// The job timeout. If this limit is exceeded, BigQuery will attempt to stop the job,
    /// but cancellation is not guaranteed. This timeout applies even if a job does not need to be created.
    /// </summary>
    internal TimeSpan? JobTimeout { get; set; }

    /// <summary>
    /// The labels associated with this query. Labels can be used to organize and group query jobs.
    /// </summary>
    internal IDictionary<string, string> Labels { get; set; }

    /// <summary>
    /// The geographic location where the job should run.
    /// </summary>
    internal string Location { get; set; }

    /// <summary>
    /// The maximum number of rows of data to return per page of results.
    /// This does not affect the total number of results returned.
    /// </summary>
    internal long? MaxResults { get; set; }

    /// <summary>
    /// Limits the bytes billed for this query.
    /// If not set, this is effectively the project default.
    /// </summary>
    internal long? MaximumBytesBilled { get; set; }

    /// <summary>
    /// If set, determines whether parameters are named or positional. If not set,
    /// this will default to named parameters. When named parameters are used, all parameters
    /// must have a name. When positional parameters are used, parameters may still have names,
    /// but don't have to.
    /// </summary>
    internal BigQueryParameterMode? ParameterMode { get; set; }

    /// <summary>
    /// A unique user-provided identifier to ensure idempotent behavior for queries.
    /// This is case-sensitive and limited to 36 ASCII characters; a UUID is recommended.
    /// </summary>
    internal string RequestId { get; set; }

    /// <summary>
    /// The reservation that the query request should use, in the format
    /// <c>projects/{project}/locations/{location}/reservations/{reservation}</c>.
    /// </summary>
    internal string Reservation { get; set; }

    /// <summary>
    /// The maximum amount of time the client is willing to wait for the query to complete.
    /// If not set, this defaults to 10 seconds.
    /// </summary>
    internal TimeSpan? Timeout { get; set; }

    /// <summary>
    /// Set to true to use legacy SQL instead of standard SQL.
    /// </summary>
    internal bool? UseLegacySql { get; set; }

    /// <summary>
    /// Whether to look for the result in the query cache.
    /// If not set, this is effectively true.
    /// </summary>
    internal bool? UseQueryCache { get; set; }

    /// <summary>
    /// If set to <c>true</c>, the query is allowed to write results incrementally to the temporary result table.
    /// This is only supported for <c>SELECT</c> queries.
    /// </summary>
    internal bool? WriteIncrementalResults { get; set; }

    /// <summary>
    /// Optional action to perform after preparing the request. If this property is non-null,
    /// the <see cref="QueryRequest"/> used for a request will be passed to the delegate
    /// before the request is executed. This allows for fine-grained modifications which aren't
    /// otherwise directly supported by the properties in this options type.
    /// </summary>
    /// <remarks>
    /// Prefer the properties on this type over this modifier to prepare the request.
    /// Only use this modifier to configure aspects for which there are no properties available.
    /// This modifier is applied to the request after all properties on this type have been applied.
    /// The delegate is only called once per operation, even if the request is automatically retried.
    /// </remarks>
    internal Action<QueryRequest> RequestModifier { get; set; }

    internal void ModifyRequest(QueryRequest query)
    {
        if (ConnectionProperties != null)
        {
            query.ConnectionProperties = ConnectionProperties;
        }
        if (Continuous != null)
        {
            query.Continuous = Continuous;
        }
        if (CreateSession != null)
        {
            query.CreateSession = CreateSession;
        }
        if (DefaultDataset != null)
        {
            query.DefaultDataset = DefaultDataset;
        }
        if (DestinationEncryptionConfiguration != null)
        {
            query.DestinationEncryptionConfiguration = DestinationEncryptionConfiguration;
        }
        if (DryRun != null)
        {
            query.DryRun = DryRun;
        }
        if (FormatOptions != null)
        {
            query.FormatOptions = FormatOptions;
        }
        if (JobCreationMode != null)
        {
            query.JobCreationMode = EnumMap.ToApiValue(JobCreationMode.Value);
        }
        if (JobTimeout != null)
        {
            query.JobTimeoutMs = (long) JobTimeout.Value.TotalMilliseconds;
        }
        if (Labels != null && Labels.Count > 0)
        {
            query.Labels = Labels;
        }
        if (Location != null)
        {
            query.Location = Location;
        }
        if (MaxResults != null)
        {
            query.MaxResults = MaxResults;
        }
        if (MaximumBytesBilled != null)
        {
            query.MaximumBytesBilled = MaximumBytesBilled;
        }
        if (ParameterMode != null)
        {
            query.ParameterMode = ParameterMode.ToString().ToLowerInvariant();
        }
        if (RequestId != null)
        {
            query.RequestId = RequestId;
        }
        if (Reservation != null)
        {
            query.Reservation = Reservation;
        }
        if (Timeout != null)
        {
            query.TimeoutMs = (long) Timeout.Value.TotalMilliseconds;
        }
        if (UseLegacySql != null)
        {
            query.UseLegacySql = UseLegacySql;
        }
        if (UseQueryCache != null)
        {
            query.UseQueryCache = UseQueryCache;
        }
        if (WriteIncrementalResults != null)
        {
            query.WriteIncrementalResults = WriteIncrementalResults;
        }
        RequestModifier?.Invoke(query);
    }

    /// <summary>
    /// Attempts to create a <see cref="StatelessQueryOptions"/> from a <see cref="QueryOptions"/> and <see cref="GetQueryResultsOptions"/>.
    /// </summary>
    /// <param name="queryOptions">The query options to convert. May be null.</param>
    /// <param name="resultsOptions">The results options to convert. May be null.</param>
    /// <param name="statelessOptions">The created stateless options, or null if the input options are not supported by the stateless endpoint.</param>
    /// <returns>True if the options could be converted; otherwise, false.</returns>
    internal static bool TryCreateStatelessOptions(QueryOptions queryOptions, GetQueryResultsOptions resultsOptions, out StatelessQueryOptions statelessOptions)
    {
        statelessOptions = null;

        // Pagination via PageToken or StartIndex requires a pre-existing job resource to reference.
        // Since the jobs.query RPC initiates a new query execution, these options are not supported in the stateless path.
        if (resultsOptions != null && (resultsOptions.StartIndex != null || resultsOptions.PageToken != null))
        {
            return false;
        }

        // At this point we know that the resultsOptions is valid so if no queryOptions are provided we just apply the
        // result options.
        if (queryOptions == null)
        {
            statelessOptions = new StatelessQueryOptions();
            ApplyResultsOptions(statelessOptions, resultsOptions);
            return true;
        }

        // QueryOptions.ConfigurationModifier is an Action that operates on a JobConfiguration object.
        // To capture its effects, we must generate a JobConfiguration and apply the options here,
        // rather than checking QueryOptions properties directly.
        var queryConfig = new JobConfigurationQuery();
        queryOptions.ModifyRequest(queryConfig);
        var jobConfig = new JobConfiguration { Query = queryConfig };
        queryOptions.ModifyJobConfiguration(jobConfig);

        // These properties are not supported by the stateless jobs.query RPC; if any are set, the query must use the standard job-based path.
        if (queryConfig.DestinationTable != null
            || queryConfig.CreateDisposition != null
            || queryConfig.WriteDisposition != null
            || queryConfig.Priority != null
            || queryConfig.AllowLargeResults != null
            || queryConfig.FlattenResults != null
            || queryConfig.MaximumBillingTier != null
            || queryConfig.TimePartitioning != null
            || queryConfig.SchemaUpdateOptions != null
            || queryConfig.Clustering != null
            || queryConfig.RangePartitioning != null
            || queryConfig.ScriptOptions != null
            || queryConfig.TableDefinitions != null
            || queryConfig.UserDefinedFunctionResources != null
            || queryOptions.JobId != null
            || queryOptions.JobIdPrefix != null)
        {
            return false;
        }

        // All validation checks passed; the query and its options are compatible with the stateless path from here on.
        statelessOptions = new StatelessQueryOptions
        {
            ConnectionProperties = queryConfig.ConnectionProperties,
            Continuous = queryConfig.Continuous,
            CreateSession = queryConfig.CreateSession,
            DefaultDataset = queryConfig.DefaultDataset,
            DestinationEncryptionConfiguration = queryConfig.DestinationEncryptionConfiguration,
            DryRun = jobConfig.DryRun,
            Labels = jobConfig.Labels,
            Location = queryOptions.JobLocation,
            MaximumBytesBilled = queryConfig.MaximumBytesBilled,
            UseLegacySql = queryConfig.UseLegacySql,
            UseQueryCache = queryConfig.UseQueryCache,
            WriteIncrementalResults = queryConfig.WriteIncrementalResults,
            ParameterMode = queryOptions.ParameterMode,
            JobCreationMode = queryOptions.JobCreationMode,
        };

        ApplyResultsOptions(statelessOptions, resultsOptions);
        return true;

        static void ApplyResultsOptions(StatelessQueryOptions statelessOptions, GetQueryResultsOptions resultsOptions)
        {
            if (resultsOptions == null)
            {
                return;
            }
            if (resultsOptions.Timeout != null)
            {
                statelessOptions.Timeout = resultsOptions.Timeout;
            }
            if (resultsOptions.PageSize != null)
            {
                statelessOptions.MaxResults = resultsOptions.PageSize;
            }
            if (resultsOptions.UseInt64Timestamp != null)
            {
                statelessOptions.FormatOptions = new DataFormatOptions
                {
                    UseInt64Timestamp = resultsOptions.UseInt64Timestamp
                };
            }
        }
    }
}
