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
    /// </summary>
    public sealed class SpannerConnectionStringBuilder : DbConnectionStringBuilder
    {
        private InstanceName _instanceName;
        private DatabaseName _databaseName;

        /// <summary>
        /// </summary>
        public ITokenAccess Credential { get; private set; }

        /// <summary>
        /// </summary>
        public string DataSource
        {
            get => GetValueOrDefault("Data Source");
            private set => this["Data Source"] = ValidatedDataSource(value);
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
                throw new ArgumentException($"'{dataSource}' is not a valid value for ${nameof(DataSource)}.  It should be of the form "
                    + "projects/<project>/instances/<instance>/databases/<database>.", nameof(DataSource));
            }

            return dataSource;
        }

        /// <summary>
        /// </summary>
        public ServiceEndpoint EndPoint => new ServiceEndpoint(Host, Port);

        /// <summary>
        /// </summary>
        // ReSharper disable once MemberCanBePrivate.Global
        public string Host
        {
            get => GetValueOrDefault(nameof(Host), SpannerClient.DefaultEndpoint.Host);
            private set => this[nameof(Host)] = value;
        }

        /// <summary>
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
            private set => this[nameof(Port)] = value.ToString();
        }

        /// <summary>
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
        /// </summary>
        /// <param name="connectionString"></param>
        /// <param name="credential"></param>
        public SpannerConnectionStringBuilder(string connectionString, ITokenAccess credential)
        {
            connectionString.ThrowIfNullOrEmpty(nameof(connectionString));
            Credential = credential;
            ConnectionString = connectionString;
        }

        /// <summary>
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
    }
}
