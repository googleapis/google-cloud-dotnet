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
using System.Data.Common;
using Google.Api.Gax.Grpc;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Util;
using Google.Cloud.Spanner.Admin.Database.V1;
using Google.Cloud.Spanner.V1;
using DatabaseName = Google.Cloud.Spanner.V1.DatabaseName;

// ReSharper disable UnusedParameter.Local
namespace Google.Cloud.Spanner.Data
{
    /// <summary>
    /// A connection string builder for Spanner connection strings.
    /// The connection string should be of the form:
    /// Data Source=projects/{project}/instances/{instance}/databases/{database};[Host={hostname};][Port={portnumber}]
    /// </summary>
    public sealed class SpannerConnectionStringBuilder : DbConnectionStringBuilder
    {
        private const string DataSourceKeyword = "Data Source";
        private InstanceName _instanceName;
        private DatabaseName _databaseName;

        /// <summary>
        /// The <see cref="ITokenAccess"/> credential used to communicate with Spanner.
        /// If not set, then default application credentials will be used.
        /// Credentials can be retrieved from a file or obtained interactively.
        /// See Google Cloud documentation for more information.
        /// </summary>
        public ITokenAccess Credential { get; private set; }

        /// <summary>
        /// DataSource of the Spanner database in the form of 'projects/{project}/instances/{instance}/databases/{database}'
        /// </summary>
        public string DataSource
        {
            get => GetValueOrDefault(DataSourceKeyword);
            set => this[DataSourceKeyword] = ValidatedDataSource(value);
        }

        private bool ParseCurrentDataSource()
        {
            return ParseDataSource(DataSource);
        }

        private bool ParseDataSource(string dataSource)
        {
            return DatabaseName.TryParse(dataSource, out _databaseName)
                || InstanceName.TryParse(dataSource, out _instanceName);
        }

        private string ValidatedDataSource(string dataSource)
        {
            if (!ParseDataSource(dataSource))
            {
                throw new ArgumentException(
                    $"'{dataSource}' is not a valid value for ${nameof(DataSource)}. It should be of the form "
                    + "projects/<project>/instances/<instance>/databases/<database>.", nameof(DataSource));
            }

            return dataSource;
        }

        /// <summary>
        /// The <see cref="ServiceEndpoint"/> to use to connect to Spanner. If not supplied in the
        /// connection string, the default endpoint will be used.
        /// </summary>
        public ServiceEndpoint EndPoint => new ServiceEndpoint(Host, Port);

        /// <summary>
        /// The TCP Host name to connect to Spanner. If not supplied in the connection string, the default
        /// host will be used.
        /// </summary>
        // ReSharper disable once MemberCanBePrivate.Global
        public string Host
        {
            get => GetValueOrDefault(nameof(Host), SpannerClient.DefaultEndpoint.Host);
            set => this[nameof(Host)] = value;
        }

        /// <summary>
        /// The TCP port number to connect to Spanner. If not supplied in the connection string, the default
        /// port will be used.
        /// </summary>
        // ReSharper disable once MemberCanBePrivate.Global
        public int Port
        {
            get
            {
                int result = SpannerClient.DefaultEndpoint.Port;
                string value = GetValueOrDefault(nameof(Port));
                if (!string.IsNullOrEmpty(value))
                {
                    if (!int.TryParse(value, out result))
                    {
                        result = SpannerClient.DefaultEndpoint.Port;
                    }
                }

                return result;
            }
            set => this[nameof(Port)] = value.ToString();
        }

        /// <summary>
        /// The Spanner Project name parsed from <see cref="DataSource"/>
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
        /// The Spanner Database name parsed from <see cref="DataSource"/>
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
        /// Creates a new <see cref="SpannerConnectionStringBuilder"/> with the given
        /// connection string and optional credential
        /// </summary>
        /// <param name="connectionString">A connection string of the form
        /// Data Source=projects/{project}/instances/{instance}/databases/{database};[Host={hostname};][Port={portnumber}].
        /// Must not be null.
        /// </param>
        /// <param name="credential">Optionally supplied credential to use for the connection.
        /// If not set, then default application credentials will be used.
        /// Credentials can be retrieved from a file or obtained interactively.
        /// See Google Cloud documentation for more information. May be null.
        /// </param>
        public SpannerConnectionStringBuilder(string connectionString, ITokenAccess credential = null)
        {
            connectionString.ThrowIfNullOrEmpty(nameof(connectionString));
            Credential = credential;
            ConnectionString = connectionString;
        }

        /// <summary>
        /// Creates a new <see cref="SpannerConnectionStringBuilder"/>.
        /// </summary>
        public SpannerConnectionStringBuilder() { }

        internal SpannerConnectionStringBuilder CloneWithNewDataSource(string dataSource) => new
            SpannerConnectionStringBuilder
            {
                Credential = Credential,
                Host = Host,
                Port = Port,
                DataSource = dataSource
            };

        private string GetValueOrDefault(string key, string defaultValue = "")
        {
            key = key.ToLower();
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
                if (string.Equals(keyword, DataSourceKeyword, StringComparison.OrdinalIgnoreCase))
                {
                    value = ValidatedDataSource((string)value);
                }
                base[keyword] = value;
            }
        }
    }
}
