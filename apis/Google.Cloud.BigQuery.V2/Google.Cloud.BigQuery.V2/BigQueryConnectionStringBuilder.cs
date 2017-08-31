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
using Google.Api.Gax;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Util;

namespace Google.Cloud.BigQuery.V2
{
    /// <summary>
    /// </summary>
    public sealed class BigQueryConnectionStringBuilder : DbConnectionStringBuilder
    {
        private const string DataSourceKeyword = "Data Source";
        private static readonly PathTemplate s_template = new PathTemplate("projects/{project}/datasets/{dataset}");
        private TemplatedResourceName _resourceName;

        /// <summary>
        /// </summary>
        public BigQueryConnectionStringBuilder(string connectionString, GoogleCredential credential = null)
        {
            connectionString.ThrowIfNullOrEmpty(nameof(connectionString));
            Credential = credential;
            ConnectionString = connectionString;
        }

        /// <summary>
        /// </summary>
        public BigQueryConnectionStringBuilder()
        {
        }

        /// <summary>
        /// </summary>
        public string DataSource
        {
            get => GetValueOrDefault(DataSourceKeyword);
            set => this[DataSourceKeyword] = ValidatedDataSource(value);
        }

        /// <summary>
        /// </summary>
        public string Project
        {
            get
            {
                ParseCurrentDataSource();
                return _resourceName?[0];
            }
        }

        /// <summary>
        /// </summary>
        public string BigQueryDataset
        {
            get
            {
                ParseCurrentDataSource();
                return _resourceName?[1];
            }
        }

        /// <summary>
        /// </summary>
        public GoogleCredential Credential { get; }

        /// <inheritdoc />
        public override object this[string keyword]
        {
            get => base[keyword];
            set
            {
                if (string.Equals(keyword, DataSourceKeyword, StringComparison.OrdinalIgnoreCase))
                    value = ValidatedDataSource((string) value);
                base[keyword] = value;
            }
        }

        private bool ParseCurrentDataSource() => ParseDataSource(DataSource);

        private bool ParseDataSource(string dataSource) => s_template.TryParseName(dataSource, out _resourceName);

        private string ValidatedDataSource(string dataSource)
        {
            if (!ParseDataSource(dataSource))
                throw new ArgumentException(
                    $"'{dataSource}' is not a valid value for ${nameof(DataSource)}. It should be of the form "
                    + "projects/<project>/datasets/<datasetid>.", nameof(DataSource));

            return dataSource;
        }

        internal BigQueryConnectionStringBuilder Clone() => new BigQueryConnectionStringBuilder(ConnectionString,
            Credential);

        internal BigQueryConnectionStringBuilder CloneWithNewDataSource(string dataSource)
            => new BigQueryConnectionStringBuilder(ConnectionString, Credential)
            {
                DataSource = dataSource
            };

        private string GetValueOrDefault(string key, string defaultValue = "")
        {
            key = key.ToLower();
            if (ContainsKey(key))
                return (string) this[key];

            return defaultValue;
        }
    }
}