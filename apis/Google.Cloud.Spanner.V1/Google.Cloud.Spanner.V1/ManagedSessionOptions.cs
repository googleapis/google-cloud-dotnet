// Copyright 2025 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License"):
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
using Google.Cloud.Spanner.Common.V1;
using System;

namespace Google.Cloud.Spanner.V1;

/// <summary>
/// Options to used when creating a managed session.
/// </summary>
public sealed class ManagedSessionOptions
{
    private static readonly TimeSpan s_defaultTimeout = TimeSpan.FromMinutes(1);

    /// <summary>
    /// The database for which the session will be created. Won't be null.
    /// </summary>
    public DatabaseName DatabaseName { get; }

    /// <summary>
    /// The database role with which the session will be created. May be null,
    /// in which case the default (public) database role is used if fine grained access control
    /// is enabled; otherwise the database role is ignored.
    /// </summary>
    public string DatabaseRole { get; }

    /// <summary>
    /// The Spanner client to use for all operations associated to the session,
    /// including session creation. Won't be null.
    /// </summary>
    public SpannerClient Client { get; }

    /// <summary>
    /// The total time allowed for a network call to the Cloud Spanner server, including retries. This setting
    /// is applied to calls to create sessions, as well as explicitly beginning transactions. May be null,
    /// in which case 1 minute will be used. Otherwise, the value will be positive.
    /// </summary>
    public TimeSpan? Timeout {  get; }

    internal TimeSpan EffectiveTimeout => Timeout ?? s_defaultTimeout;

    private ManagedSessionOptions(
        DatabaseName databaseName, string databaseRole, SpannerClient client, TimeSpan? timeout)
    {
        DatabaseName = GaxPreconditions.CheckNotNull(databaseName, nameof(databaseName));
        Client = GaxPreconditions.CheckNotNull(client, nameof(client));
        Timeout = CheckNullOrPositiveTimeSpan(timeout);
        DatabaseRole = databaseRole;
        
    }

    /// <summary>
    /// Creates a <see cref="ManagedSessionOptions"/> with the given database name.
    /// </summary>
    /// <param name="databaseName">
    /// The database name for the associated session. Must not be null.
    /// </param>
    /// <param name="client">
    /// The Spanner client that the sessions will use for all command execution,
    /// including those executed by associated <see cref="ManagedTransaction"/>.
    /// </param>
    public static ManagedSessionOptions Create(DatabaseName databaseName, SpannerClient client) =>
        new ManagedSessionOptions(databaseName, null, client, null);

    /// <summary>
    /// Creates a <see cref="ManagedSessionOptions"/> based on this one but with the given database role.
    /// </summary>
    /// <param name="databaseRole">
    /// The database role for the associated session. May be null
    /// in which case the default (public) database role is used if fine grained access control
    /// is enabled; otherwise the database role is ignored.
    /// </param>
    public ManagedSessionOptions WithDatabaseRole(string databaseRole) =>
        new ManagedSessionOptions(DatabaseName, databaseRole, Client, Timeout);

    /// <summary>
    /// Creates a <see cref="ManagedSessionOptions"/> based on this one but with the given timeout.
    /// </summary>
    /// <param name="timeout">
    /// The total time allowed for a network call to the Cloud Spanner server, including retries. This setting
    /// is applied to calls to create sessions, as well as explicitly beginning transactions. May be null,
    /// in which case 1 minute will be used. Otherwise, the value must be positive.
    /// </param>
    public ManagedSessionOptions WithTimeout(TimeSpan? timeout) =>
        new ManagedSessionOptions(DatabaseName, DatabaseRole, Client, timeout);

    internal static TimeSpan? CheckNullOrPositiveTimeSpan(TimeSpan? value)
    {
        if (value.HasValue && value.Value.Ticks <= 0)
        {
            throw new ArgumentOutOfRangeException("value", "Value must be null or a positive TimeSpan");
        }
        return value;
    }
}
