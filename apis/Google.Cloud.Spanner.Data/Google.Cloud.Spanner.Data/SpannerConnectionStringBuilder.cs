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

using Google.Api.Gax;
using Google.Apis.Auth.OAuth2;
using Google.Cloud.Spanner.Common.V1;
using Google.Cloud.Spanner.V1;
using Grpc.Core;
using System;
using System.Data.Common;
using System.Globalization;
using System.Threading.Tasks;

namespace Google.Cloud.Spanner.Data
{
    /// <summary>
    /// A connection string builder for Spanner connection strings.
    /// The connection string should be of the form:
    /// Data Source=projects/{project}/instances/{instance}/databases/{database};[Host={hostname};][Port={portnumber}]
    /// </summary>
    public sealed class SpannerConnectionStringBuilder : DbConnectionStringBuilder
    {
        /// <summary>
        /// The default value for <see cref="Timeout"/>.
        /// </summary>
        internal const int DefaultTimeout = 60;

        /// <summary>
        /// The default value for <see cref="MaximumGrpcChannels"/>.
        /// </summary>
        internal const int DefaultMaximumGrpcChannels = 4;

        /// <summary>
        /// The default value for <see cref="MaxConcurrentStreamsLowWatermark"/>.
        /// </summary>
        internal const int DefaultMaxConcurrentStreamsLowWatermark = 20;

        private const string CredentialFileKeyword = "CredentialFile";
        private const string DataSourceKeyword = "Data Source";
        private const string UseClrDefaultForNullKeyword = "UseClrDefaultForNull";
        private const string EnableGetSchemaTableKeyword = "EnableGetSchemaTable";
        private const string LogCommitStatsKeyword = "LogCommitStats";
        private const string EmulatorDetectionKeyword = "EmulatorDetection";
        private const string ClrToSpannerTypeDefaultMappingsKeyword = "ClrToSpannerTypeDefaultMappings";
        private const string SpannerToClrTypeDefaultMappingsKeyword = "SpannerToClrTypeDefaultMappings";
        private const string DatabaseRoleKeyword = "DatabaseRole";
        private const string EnableLeaderRoutingKeyword = "EnableLeaderRouting";

        private InstanceName _instanceName;
        private DatabaseName _databaseName;

        internal const string DefaultDomain = "googleapis.com";
        internal const string DefaultHost = $"spanner.{DefaultDomain}";
        internal const int DefaultPort = 443;

        /// <summary>
        /// The database role for the sessions created by this connection.
        /// </summary>
        public string DatabaseRole
        {
            get => GetValueOrDefault(DatabaseRoleKeyword);
            set => this[DatabaseRoleKeyword] = value;
        }

        /// <summary>
        /// Optional path to a JSON Credential file. If a Credential is not supplied, Cloud Spanner
        /// will use Default Application Credentials.
        /// </summary>
        public string CredentialFile
        {
            get => GetValueOrDefault(CredentialFileKeyword);
            set => this[CredentialFileKeyword] = value;
        }

        /// <summary>
        /// Option to change between the default handling of null database values (return <see cref="DBNull.Value">DBNull.Value</see>) or
        /// the non-standard handling (return the default value for whatever type is requested).
        /// </summary>
        /// <remarks>
        /// <para>
        /// If this is <c>false</c> (the default), requesting a value from a <see cref="SpannerDataReader"/> that is null
        /// in the database will return <see cref="DBNull.Value">DBNull.Value</see>, which may cause an <see cref="InvalidCastException"/> if
        /// the requested type is not compatible with that value. For arrays and structs, the behavior is slightly different.
        /// A null value is used for an array or struct value where the target type permits such a value. Attempting to convert
        /// an array value that contains a null element into a .NET array type with a non-nullable element type will
        /// cause an <see cref="InvalidCastException"/> to be thrown. To avoid this, where array elements may be null for value types,
        /// use an array with a nullable element type. This allows code to distinguish between a null element in the original
        /// data and a value of 0, false etc.
        /// </para>
        /// <para>
        /// If this is <c>true</c>, requesting a value from a <see cref="SpannerDataReader"/> that is null in the
        /// database will return the default value of the requested type (e.g. 0 or a null reference). That conversion is also used for
        /// array elements. For example, converting a Spanner array consisting of 1, null, and 2 into an <c>Int32</c> array will result in
        /// an array containing 1, 0 and 2. This is the behavior from release 1.0 of this package.
        /// </para>
        /// <para>
        /// This property corresponds with the value of the "UseClrDefaultForNull" part of the connection string.
        /// </para>
        /// </remarks>
        public bool UseClrDefaultForNull
        {
            get => GetValueOrDefault(UseClrDefaultForNullKeyword).Equals("True", StringComparison.OrdinalIgnoreCase);
            set
            {
                ConversionOptions = ConversionOptions.WithClrDefaultForNullSetting(value);
                this[UseClrDefaultForNullKeyword] = value.ToString(); // Always "True" or "False", regardless of culture.
            }
        }

        /// <summary>
        /// The universe domain to connect to, or null to use the default universe domain <see cref="DefaultDomain"/>.
        /// </summary>
        /// <remarks>
        /// <para>
        /// <see cref="UniverseDomain"/> is used to build the endpoint to connect to, unless <see cref="EndPoint"/>
        /// is set, in which case <see cref="EndPoint"/> will be used without further modification.
        /// </para>
        /// <para>
        /// If default credentials or one of <see cref="GoogleCredential"/> or <see cref="CredentialFile"/>
        /// is used, <see cref="GoogleCredential.GetUniverseDomain"/> should be:
        /// <list type="bullet">
        /// <item>The same as <see cref="UniverseDomain"/> if <see cref="UniverseDomain"/> has been set.</item>
        /// </list>
        /// </para>
        /// </remarks>
        public string UniverseDomain
        {
            get => GetValueOrDefault(nameof(UniverseDomain), DefaultDomain);
            set => this[nameof(UniverseDomain)] = value;
        }

        // Note: GetSchemaTable can't be a link as it wouldn't build on netstandard1.0.

        /// <summary>
        /// Option to allow <see cref="SpannerDataReader"/> to return a schema from <c>GetSchemaTable</c>, on supported platforms.
        /// Only partial information is available, and when this option is enabled, <c>DbDataAdapter</c> may be overly eager to
        /// use the information to create and manage datasets.
        /// </summary>
        public bool EnableGetSchemaTable
        {
            get => GetValueOrDefault(EnableGetSchemaTableKeyword).Equals("True", StringComparison.OrdinalIgnoreCase);
            set => this[EnableGetSchemaTableKeyword] = value.ToString(); // Always "True" or "False", regardless of culture.
        }

        /// <summary>
        /// DataSource of the Spanner database in the form of 'projects/{project}/instances/{instance}/databases/{database}'
        /// or 'projects/{project}/instances/{instance}'.
        /// </summary>
        public string DataSource
        {
            get => GetValueOrDefault(DataSourceKeyword);
            set => this[DataSourceKeyword] = ValidatedDataSource(value);
        }

        private bool ParseCurrentDataSource() => ParseDataSource(DataSource);

        // We parse both every time; only one will ever be non-null afterwards (if any).
        private bool ParseDataSource(string dataSource) =>
            DatabaseName.TryParse(dataSource, out _databaseName) |
            InstanceName.TryParse(dataSource, out _instanceName);

        private string ValidatedDataSource(string dataSource)
        {
            // It's okay to set the data source to an empty string or null to clear it.
            if (!string.IsNullOrEmpty(dataSource) && !ParseDataSource(dataSource))
            {
                throw new ArgumentException(
                    $"'{dataSource}' is not a valid value for ${nameof(DataSource)}. It should be of the form "
                    + "projects/<project>/instances/<instance>/databases/<database>.", nameof(DataSource));
            }

            return dataSource;
        }

        // TODO: Move the docs into the connection string docs (and link to them from here) for both the new properties.

        /// <summary>
        /// Option to configure the default CLR type to SpannerDbType mapping. This option comes into picture
        /// only if <see cref="SpannerDbType"/> and <see cref="System.Data.DbType"/> of the <see cref="SpannerParameter"/>
        /// are not explicitly provided. Currently only <see cref="decimal"/> and <see cref="DateTime"/> CLR types are supported.
        /// </summary>
        /// <remarks>
        /// The valid type mappings for decimal are:
        /// <para><c>DecimalToFloat64</c> - <see cref="decimal"/> CLR type will map to <see cref="SpannerDbType.Float64"/>,
        /// if <see cref="SpannerDbType"/> and <see cref="System.Data.DbType"/> is not explicitly provided for the <see cref="SpannerParameter"/>.
        /// </para>
        /// <para><c>DecimalToNumeric</c> - <see cref="decimal"/> CLR type will map to <see cref="SpannerDbType.Numeric"/>,
        /// if <see cref="SpannerDbType"/> and <see cref="System.Data.DbType"/> is not explicitly provided for the <see cref="SpannerParameter"/>.
        /// This should be used while working with Google Standard SQL dialect only.
        /// </para>
        /// <para><c>DecimalToPgNumeric</c> - <see cref="decimal"/> CLR type will map to <see cref="SpannerDbType.PgNumeric"/>,
        /// if <see cref="SpannerDbType"/> and <see cref="System.Data.DbType"/> is not explicitly provided for the <see cref="SpannerParameter"/>.
        /// This should be used while working with PostgreSQL dialect only.
        /// </para>
        /// The valid type mappings for DateTime are:
        /// <para><c>DateTimeToDate</c> - <see cref="DateTime"/> CLR type will map to <see cref="SpannerDbType.Date"/>,
        /// if <see cref="SpannerDbType"/> and <see cref="System.Data.DbType"/> is not explicitly provided for the <see cref="SpannerParameter"/>.
        /// </para>
        /// <para><c>DateTimeToTimestamp</c> - <see cref="DateTime"/> CLR type will map to <see cref="SpannerDbType.Timestamp"/>,
        /// if <see cref="SpannerDbType"/> and <see cref="System.Data.DbType"/> is not explicitly provided for the <see cref="SpannerParameter"/>.
        /// </para>
        /// The mapping can be provided as comma separated values. Only one mapping for a type must be provided.
        /// Providing mutiple mapping for a type, or providing invalid mapping or providing whitespaces will result in <see cref="ArgumentException"/>. Few examples of valid values are:
        /// <para>
        /// DecimalToFloat64,DateTimeToDate
        /// </para>
        /// <para>
        /// DecimalToNumeric,DateTimeToTimestamp
        /// </para>
        /// <para>
        /// This property corresponds with the value of the "ClrToSpannerTypeDefaultMappings" part of the connection string.
        /// </para>
        /// </remarks>
        public string ClrToSpannerTypeDefaultMappings
        {
            get => GetValueOrDefault(ClrToSpannerTypeDefaultMappingsKeyword);
            set
            {
                ConversionOptions = ConversionOptions.WithClrToSpannerMappings(value);
                this[ClrToSpannerTypeDefaultMappingsKeyword] = value;
            }
        }

        /// <summary>
        /// Option to configure the default SpannerDbType to CLR type mappings. This option comes into picture
        /// only if CLR type of the value being read is not explicitly provided while reading the data from the database.
        /// Currently only <see cref="SpannerDbType.Date"/> is supported.
        /// </summary>
        /// <remarks>
        /// The valid type mappings for Date are:
        /// <para>
        /// <c>DateToDateTime</c> - <see cref="SpannerDbType.Date"/> will map to <see cref="DateTime"/>,
        /// if CLR type of the value being read is not explicitly provided.
        /// </para>
        /// <para>
        /// <c>DateToSpannerDate</c> - <see cref="SpannerDbType.Date"/> will map to <see cref="SpannerDate"/>,
        /// if CLR type of the value being read is not explicitly provided.
        /// </para>
        /// The mapping can be provided as comma separated values. Only one mapping for a SpannerDbType must be provided.
        /// Providing mutiple mapping for a type, or providing invalid mapping or providing whitespaces will result in <see cref="ArgumentException"/>.
        /// Few examples of valid values are:
        /// <para>
        /// DateToDateTime
        /// </para>
        /// <para>
        /// DateToSpannerDate
        /// </para>
        /// <para>
        /// This property corresponds with the value of the "SpannerToClrTypeDefaultMappings" part of the connection string.
        /// </para>
        /// </remarks>
        public string SpannerToClrTypeDefaultMappings
        {
            get => GetValueOrDefault(SpannerToClrTypeDefaultMappingsKeyword);
            set
            {
                ConversionOptions = ConversionOptions.WithSpannerToClrMappings(value);
                this[SpannerToClrTypeDefaultMappingsKeyword] = value;
            }
        }

        // Note: EndPoint rather than Endpoint to avoid an unnecessary breaking change from V1.

        /// <summary>
        /// The endpoint to use to connect to Spanner. If not supplied in the
        /// connection string, the default endpoint will be used.
        /// </summary>
        public string EndPoint => $"{Host}:{Port}";

        /// <summary>
        /// The TCP Host name to connect to Spanner. If not supplied in the connection string, the default
        /// host will be used.
        /// </summary>
        public string Host
        {
            // TODO: Now that ServiceEndpoint has been removed, we don't have separate host/port for the default endpoint.
            // This is currently hardcoded for convenience; it's unlikely to ever change, but ideally we'd parse it from the
            // SpannerClient.DefaultEndpoint;
            get => GetValueOrDefault(nameof(Host), DefaultHost);
            set => this[nameof(Host)] = value;
        }

        /// <summary>
        /// The TCP port number to connect to Spanner. If not supplied in the connection string, the default
        /// port will be used.
        /// </summary>
        public int Port
        {
            // TODO: Now that ServiceEndpoint has been removed, we don't have separate host/port for the default endpoint.
            // This is currently hardcoded for convenience; it's unlikely to ever change, but ideally we'd parse it from the
            // SpannerClient.DefaultEndpoint;
            get => GetInt32OrDefault(nameof(Port), 1, 65535, DefaultPort);
            set => SetInt32WithValidation(nameof(Port), 1, 65535, value);
        }

        /// <summary>
        /// The fully-qualified database name parsed from <see cref="DataSource"/>.
        /// May be null, if the data source isn't set, or is invalid, or doesn't contain a database name.
        /// </summary>
        public DatabaseName DatabaseName
        {
            get
            {
                ParseCurrentDataSource();
                return _databaseName;
            }
            set
            {
                // .NET Core 1.0 behaves bizarrely around null values: setting a null value in the
                // indexer appears to be ignored. We can remove the value instead. Even though this is fixed
                // in .NET Core 2.0, we might as well be consistent.
                if (value == null)
                {
                    Remove(DataSourceKeyword);
                }
                else
                {
                    DataSource = value.ToString();
                }
            }
        }

        /// <summary>
        /// The Spanner Project name parsed from <see cref="DataSource"/>
        /// May be null, if the data source isn't set, or is invalid.
        /// </summary>
        public string Project
        {
            get
            {
                ParseCurrentDataSource();
                return _databaseName?.ProjectId ?? _instanceName?.ProjectId;
            }
        }

        /// <summary>
        /// The Spanner Database name parsed from <see cref="DataSource"/>.
        /// May be null, if the data source isn't set, or is invalid, or doesn't contain a database name.
        /// </summary>
        public string SpannerDatabase
        {
            get
            {
                ParseCurrentDataSource();
                return _databaseName?.DatabaseId;
            }
        }

        /// <summary>
        /// The Spanner Instance name parsed from <see cref="DataSource"/>
        /// May be null, if the data source isn't set, or is invalid.
        /// </summary>
        public string SpannerInstance
        {
            get
            {
                ParseCurrentDataSource();
                return _databaseName?.InstanceId ?? _instanceName?.InstanceId;
            }
        }

        /// <summary>
        /// Option to allow a timeout of 0 to mean "fail immediately" rather than "continue indefinitely".
        /// This is primarily used for testing.
        /// </summary>
        public bool AllowImmediateTimeouts
        {
            // Allow both a bool value and a text value of "true", case-insensitively.
            get => TryGetValue(nameof(AllowImmediateTimeouts), out var value) &&
                (value is true || (value is string textValue && textValue.Equals("true", StringComparison.OrdinalIgnoreCase)));
            set => this[nameof(AllowImmediateTimeouts)] = value;
        }

        /// <summary>
        /// The maximum number of gRPC channels used for connections with the same settings.
        /// Defaults to 4.
        /// </summary>
        public int MaximumGrpcChannels
        {
            get => GetInt32OrDefault(nameof(MaximumGrpcChannels), 1, int.MaxValue, DefaultMaximumGrpcChannels);
            set => SetInt32WithValidation(nameof(MaximumGrpcChannels), 1, int.MaxValue, value);
        }

        /// <summary>
        /// The low watermark of max number of concurrent streams in a channel.
        /// A new channel will be created once this is reached, until the maximum size
        /// of the channel pool is reached. This rarely needs to be modified.
        /// </summary>
        public int MaxConcurrentStreamsLowWatermark
        {
            get => GetInt32OrDefault(nameof(MaxConcurrentStreamsLowWatermark), 1, int.MaxValue, DefaultMaxConcurrentStreamsLowWatermark);
            set => SetInt32WithValidation(nameof(MaxConcurrentStreamsLowWatermark), 1, int.MaxValue, value);
        }

        /// <summary>
        /// Defines the default values for <see cref="SpannerCommand.CommandTimeout"/> and
        /// transaction commits along with all network operations to a Cloud Spanner database.
        /// Defaults to 60 seconds.
        /// </summary>
        /// <remarks>
        /// Operations sent to the server that take greater than this duration will fail
        /// with a <see cref="SpannerException"/> and error code <see cref="ErrorCode.DeadlineExceeded"/>.
        /// A value of '0' normally indicates that no timeout should be used (it waits an infinite amount of time).
        /// However, if you specify AllowImmediateTimeouts=true in the connection string, '0' will cause a timeout
        /// that expires immediately. This is normally used only for testing purposes.
        /// </remarks>
        public int Timeout
        {
            get => GetInt32OrDefault(nameof(Timeout), 0, int.MaxValue, DefaultTimeout);
            set => SetInt32WithValidation(nameof(Timeout), 0, int.MaxValue, value);
        }

        /// <summary>
        /// Request commit statistics for all read/write transactions throughout the
        /// lifetime of the connection and log these.
        /// </summary>
        /// <remarks>
        /// Commit statistics that are returned for a transaction are logged using the
        /// logger of the connection. Applications can set a custom logger on the
        /// connection to log the output to a different destination.
        /// <see cref="Google.Cloud.Spanner.V1.Internal.Logging.Logger.LogCommitStats(CommitRequest, CommitResponse)"/>
        /// </remarks>
        public bool LogCommitStats
        {
            get => GetValueOrDefault(LogCommitStatsKeyword).Equals("True", StringComparison.OrdinalIgnoreCase);
            set => this[LogCommitStatsKeyword] = value.ToString(); // Always "True" or "False", regardless of culture.
        }

        /// <summary>
        /// Specifies whether to allow the connection to check for the presence of the emulator
        /// environment variable.
        /// </summary>
        /// <remarks>
        /// This property defaults to <see cref="EmulatorDetection.None"/>, meaning that the
        /// environment variable is ignored.
        /// </remarks>
        public EmulatorDetection EmulatorDetection
        {
            get
            {
                if (TryGetValue(EmulatorDetectionKeyword, out object value) &&
                    (value is EmulatorDetection parsed || (value is string text && Enum.TryParse(text, out parsed))))
                {
                    return parsed >= EmulatorDetection.None && parsed <= EmulatorDetection.EmulatorOrProduction ? parsed : EmulatorDetection.None;
                }
                return EmulatorDetection.None;
            }
            set
            {
                GaxPreconditions.CheckEnumValue(value, nameof(value));
                this[EmulatorDetectionKeyword] = value.ToString();
            }
        }

        /// <summary>
        /// Options to control leader routing. This is true by default.
        /// </summary>
        /// <remarks>
        /// If this value is true some operations will always be explicitly routed to the leader,
        /// some operations will never be explicitly routed to the leader, and some operations will
        /// be routed to the leader depending on the transaction type they are using.
        /// </remarks>
        public bool EnableLeaderRouting
        {
            get => GetValueOrDefault(EnableLeaderRoutingKeyword, "True").Equals("True", StringComparison.OrdinalIgnoreCase);
            set => this[EnableLeaderRoutingKeyword] = value.ToString(); // Always "True" or "False", regardless of culture.
        }

        /// <summary>
        /// Specifies which replicas or regions should be used for non-transactional reads or queries. May be null.
        /// When set, all queries and reads executed on this connection within a read-only or single-use transaction
        /// will include these options. If a query or read command specifies directed read options itself
        /// then those have precedence over these.
        /// For other operations or for non read-only or single-use transactions, these options are ignored.
        /// </summary>
        /// <remarks>
        /// These options are not settable through the connection string actual string value.
        /// Instead they are only settable via code on <see cref="SpannerConnectionStringBuilder"/> instances.
        /// This may change in the future and directed read options may be made available through the actual string
        /// value of the connection string.
        /// </remarks>
        public DirectedReadOptions DirectedReadOptions { get; set; }

        // Credential overrides: at most one will be non-null.
        internal ChannelCredentials CredentialOverride { get; }
        internal GoogleCredential GoogleCredential { get; }

        private SessionPoolManager _sessionPoolManager = SessionPoolManager.Default;

        /// <summary>
        /// The <see cref="SessionPoolManager"/> to use for server interactions.
        /// </summary>
        /// <remarks>
        /// This property defaults to <see cref="SessionPoolManager.Default"/>, and
        /// most code will not need to change this. It can be convenient for isolation purposes,
        /// particularly in testing.
        /// </remarks>
        public SessionPoolManager SessionPoolManager
        {
            get => _sessionPoolManager;
            set => _sessionPoolManager = GaxPreconditions.CheckNotNull(value, nameof(value));
        }

        internal Task<SessionPool> AcquireSessionPoolAsync() =>
            SessionPoolManager.AcquireSessionPoolAsync(new SpannerClientCreationOptions(this));

        /// <summary>
        /// Copy constructor, used for cloning. (This allows for the use of object initializers, unlike
        /// the <see cref="Clone"/> method.)
        /// </summary>
        private SpannerConnectionStringBuilder(SpannerConnectionStringBuilder other) : this()
        {
            ConnectionString = other.ConnectionString;
            CredentialOverride = other.CredentialOverride;
            GoogleCredential = other.GoogleCredential;
            SessionPoolManager = other.SessionPoolManager;
            EnvironmentVariableProvider = other.EnvironmentVariableProvider;
            DirectedReadOptions = other.DirectedReadOptions?.Clone();
            // Note: ConversionOptions is populated by the connection string.
        }

        /// <summary>
        /// Creates a new <see cref="SpannerConnectionStringBuilder"/> with the given
        /// connection string and optional credential.
        /// </summary>
        /// <param name="connectionString">A connection string of the form
        /// Data Source=projects/{project}/instances/{instance}/databases/{database};[Host={hostname};][Port={portnumber}].
        /// Must not be null.
        /// </param>
        /// <param name="credentials">Optionally supplied credential to use for the connection.
        /// If this is null (the default parameter value), then default application credentials will be used.
        /// Credentials can be retrieved from a file or obtained interactively.
        /// See Google Cloud documentation for more information.
        /// </param>
        public SpannerConnectionStringBuilder(string connectionString, ChannelCredentials credentials = null) : this()
        {
            ConnectionString = GaxPreconditions.CheckNotNull(connectionString, nameof(connectionString));
            CredentialOverride = credentials;
        }

        /// <summary>
        /// Creates a new <see cref="SpannerConnectionStringBuilder"/> with the given
        /// connection string and optional credential.
        /// </summary>
        /// <param name="connectionString">A connection string of the form
        /// Data Source=projects/{project}/instances/{instance}/databases/{database};[Host={hostname};][Port={portnumber}].
        /// </param>
        /// <param name="googleCredential">The credential to use for the connection.
        /// If this is null, then default application credentials will be used.
        /// Credentials can be retrieved from a file or obtained interactively.
        /// See Google Cloud documentation for more information. May be null.
        /// </param>
        public SpannerConnectionStringBuilder(string connectionString, GoogleCredential googleCredential) : this()
        {
            ConnectionString = GaxPreconditions.CheckNotNull(connectionString, nameof(connectionString));
            GoogleCredential = googleCredential;
        }

        /// <summary>
        /// Creates a new <see cref="SpannerConnectionStringBuilder"/>.
        /// </summary>
        public SpannerConnectionStringBuilder() => ConversionOptions = SpannerConversionOptions.Default;

        /// <inheritdoc />
        public override void Clear()
        {
            base.Clear();
            ConversionOptions = SpannerConversionOptions.Default;
        }

        internal SpannerConnectionStringBuilder Clone() => new SpannerConnectionStringBuilder(this);

        internal SpannerConnectionStringBuilder CloneWithNewDataSource(string dataSource) =>
            new SpannerConnectionStringBuilder(this) { DataSource = dataSource };

        /// <summary>
        /// Returns a new instance of a <see cref="SpannerConnectionStringBuilder"/> with the database
        /// portion of the DataSource replaced with a new value.
        /// </summary>
        /// <param name="database">The new database name. Can be null to open a connection for Ddl commands.</param>
        /// <returns>A new instance of <see cref="SpannerConnectionStringBuilder"/></returns>
        public SpannerConnectionStringBuilder WithDatabase(string database) =>
            CloneWithNewDataSource(string.IsNullOrEmpty(database)
                ? $"projects/{Project}/instances/{SpannerInstance}"
                : $"projects/{Project}/instances/{SpannerInstance}/databases/{database}");

        private int GetInt32OrDefault(string key, int minValue, int maxValue, int defaultValue)
        {
            if (TryGetValue(key, out object value) &&
                (value is int parsed || (value is string text && int.TryParse(text, NumberStyles.None, CultureInfo.InvariantCulture, out parsed))))
            {
                return parsed >= minValue && parsed <= maxValue ? parsed : defaultValue;
            }
            return defaultValue;
        }

        private void SetInt32WithValidation(string key, int minValue, int maxValue, int value)
        {
            GaxPreconditions.CheckArgumentRange(value, "value", minValue, maxValue);
            this[key] = value.ToString(CultureInfo.InvariantCulture);
        }

        private string GetValueOrDefault(string key, string defaultValue = "")
        {
            key = key.ToLowerInvariant();
            if (ContainsKey(key))
            {
                return (string) this[key];
            }

            return defaultValue;
        }

        /// <inheritdoc />
        public override object this[string keyword]
        {
            get => base[keyword];
            set
            {
                // TODO: Other validation? (For integer values etc?)
                if (string.Equals(keyword, DataSourceKeyword, StringComparison.OrdinalIgnoreCase))
                {
                    value = ValidatedDataSource((string)value);
                }
                else if (string.Equals(keyword, ClrToSpannerTypeDefaultMappingsKeyword, StringComparison.OrdinalIgnoreCase))
                {
                    ConversionOptions = ConversionOptions.WithClrToSpannerMappings((string)value);
                }
                else if (string.Equals(keyword, SpannerToClrTypeDefaultMappingsKeyword, StringComparison.OrdinalIgnoreCase))
                {
                    ConversionOptions = ConversionOptions.WithSpannerToClrMappings((string)value);
                }
                else if (string.Equals(keyword, UseClrDefaultForNullKeyword, StringComparison.OrdinalIgnoreCase))
                {
                    ConversionOptions = ConversionOptions.WithClrDefaultForNullSetting(bool.Parse((string)value));
                }
                base[keyword] = value;
            }
        }

        /// <summary>
        /// An environment variable provider function (variable -> value) that is used during
        /// emulator environment detection. This is provided for testability, so that clients are able to test
        /// how they would connect based on emulator environment variables. This is not expected to be used in
        /// production code. (Indeed, this property is currently internal, although the equivalent in SpannerClientBuilder
        /// is necessarily public.)
        /// </summary>
        internal Func<string, string> EnvironmentVariableProvider { get; set; }

        /// <summary>
        /// Gets the conversion options associated with this instance of the builder.
        /// </summary>
        internal SpannerConversionOptions ConversionOptions { get; private set; }
    }
}
