// Copyright 2025 Google LLC
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
using Google.Cloud.Spanner.Common.V1;
using Google.Cloud.Spanner.V1;
using System;
using System.Collections.Concurrent;
using System.Threading.Tasks;

namespace Google.Cloud.Spanner.Data;

/// <summary>
/// Manages ManagedSessions used by SpannerConnection.
/// </summary>
public sealed class SessionManager
{
    /// <summary>
    /// The default session manager, used by <see cref="SpannerConnection"/> unless a different manager
    /// is specified on construction.
    /// </summary>
    public static SessionManager Default { get; } = new SessionManager(new SpannerSettings(), null);

    internal SpannerSettings SpannerSettings => _spannerSettings;

    private readonly SpannerSettings _spannerSettings;
    private readonly Func<SpannerClientCreationOptions, SpannerSettings, Task<SpannerClient>> _clientFactory;
    private readonly ConcurrentDictionary<SpannerClientCreationOptions, Task<SpannerClient>> _clients = new ConcurrentDictionary<SpannerClientCreationOptions, Task<SpannerClient>>();
    private readonly ConcurrentDictionary<SessionAcquisitionOptions, Task<ManagedSession>> _sessions = new ConcurrentDictionary<SessionAcquisitionOptions, Task<ManagedSession>>();

    internal SessionManager(SpannerSettings spannerSettings, Func<SpannerClientCreationOptions, SpannerSettings, Task<SpannerClient>> clientFactory)
    {
        _spannerSettings = GaxPreconditions.CheckNotNull(spannerSettings, nameof(spannerSettings));
        _spannerSettings.VersionHeaderBuilder.AppendAssemblyVersion("gccl", typeof(SessionManager));

        _clientFactory = clientFactory ?? ((options, settings) => options.CreateSpannerClientAsync(settings));
    }

    /// <summary>
    /// Creates a new <see cref="SessionManager"/> identical to this one but with the given
    /// <see cref="SpannerSettings"/>.
    /// </summary>
    /// <param name="spannerSettings">
    /// Spanner settings to apply to the new session manager.
    /// May be null, in which case, defaults will be used.
    /// </param>
    public SessionManager WithSpannerSettings(SpannerSettings spannerSettings) =>
        new SessionManager(spannerSettings?.Clone() ?? new SpannerSettings(), _clientFactory);

    internal Task<ManagedSession> AcquireSessionAsync(SessionAcquisitionOptions sessionOptions) =>
        _sessions.GetOrAdd(sessionOptions, CreateSessionAsync);

    internal Task<SpannerClient> AcquireClientAsync(SpannerClientCreationOptions clientOptions) =>
        _clients.GetOrAdd(clientOptions, options => _clientFactory(options, _spannerSettings));

    private async Task<ManagedSession> CreateSessionAsync(SessionAcquisitionOptions sessionOptions)
    {
        var client = await AcquireClientAsync(sessionOptions.ClientOptions).ConfigureAwait(false);
        var options = ManagedSessionOptions.Create(sessionOptions.DatabaseName, client)
            .WithDatabaseRole(sessionOptions.DatabaseRole)
            .WithTimeout(sessionOptions.Timeout);
        return new ManagedSession(options);
    }
}

internal readonly struct SessionAcquisitionOptions : IEquatable<SessionAcquisitionOptions>
{
    public SpannerClientCreationOptions ClientOptions { get; }
    public DatabaseName DatabaseName { get; }
    public string DatabaseRole { get; }
    public TimeSpan? Timeout { get; }

    public SessionAcquisitionOptions(SpannerClientCreationOptions clientOptions, DatabaseName databaseName, string databaseRole, TimeSpan? timeout)
    {
        ClientOptions = GaxPreconditions.CheckNotNull(clientOptions, nameof(clientOptions));
        DatabaseName = GaxPreconditions.CheckNotNull(databaseName, nameof(databaseName));
        DatabaseRole = databaseRole;
        Timeout = timeout;
    }

    public bool Equals(SessionAcquisitionOptions other) =>
        ClientOptions.Equals(other.ClientOptions) &&
        DatabaseName.Equals(other.DatabaseName) &&
        string.Equals(DatabaseRole, other.DatabaseRole, StringComparison.Ordinal) &&
        Equals(Timeout, other.Timeout);

    public override bool Equals(object obj) => obj is SessionAcquisitionOptions other && Equals(other);

    public override int GetHashCode() => GaxEqualityHelpers.CombineHashCodes(
        ClientOptions.GetHashCode(),
        DatabaseName.GetHashCode(),
        DatabaseRole?.GetHashCode() ?? 0,
        Timeout?.GetHashCode() ?? 0);
}
