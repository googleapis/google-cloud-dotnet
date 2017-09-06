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
    /// A connection string builder for BigQuery connection strings.
    /// The connection string should be of the form:
    /// Data Source=projects/{project}/datasets/{datasetid}
    /// </summary>
    public sealed class BigQueryConnectionStringBuilder : DbConnectionStringBuilder
    {
        private const string DataSourceKeyword = "Data Source";

        private static readonly PathTemplate s_datasetTemplate =
            new PathTemplate("projects/{project}/datasets/{dataset}");

        private static readonly PathTemplate s_projectTemplate = new PathTemplate("projects/{project}");
        private bool _hasDataset;
        private TemplatedResourceName _resourceName;

        /// <summary>
        /// Creates an instance of a <see cref="BigQueryConnectionStringBuilder"/>
        /// </summary>
        /// <param name="connectionString">The connection string to use.</param>
        /// <param name="credential">The credentials to use for making API calls. Typically you would use
        /// default application credentials, but you may specify a <see cref="GoogleCredential"/></param>
        public BigQueryConnectionStringBuilder(string connectionString, GoogleCredential credential = null)
        {
            connectionString.ThrowIfNullOrEmpty(nameof(connectionString));
            Credential = credential;
            ConnectionString = connectionString;
        }

        /// <summary>
        /// Creates an instance of a <see cref="BigQueryConnectionStringBuilder"/>
        /// </summary>
        public BigQueryConnectionStringBuilder()
        {
        }

        /// <summary>
        /// The data source to use of the form projects/{project}/datasets/{datasetid}
        /// </summary>
        public string DataSource
        {
            get => GetValueOrDefault(DataSourceKeyword);
            set => this[DataSourceKeyword] = ValidatedDataSource(value);
        }

        /// <summary>
        /// The project id as parsed from the Data Source attribute of the connection string.
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
        /// The dataset id as parsed from the Data Source attribute of the connection string.
        /// </summary>
        public string BigQueryDataset
        {
            get
            {
                ParseCurrentDataSource();
                return _hasDataset ? _resourceName?[1] : null;
            }
        }

        /// <summary>
        /// The <see cref="GoogleCredential"/> used if overridden.
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

        private void ParseCurrentDataSource()
        {
            _hasDataset = s_datasetTemplate.TryParseName(DataSource, out _resourceName);
            if (!_hasDataset)
                s_projectTemplate.TryParseName(DataSource, out _resourceName);
        }

        private string ValidatedDataSource(string dataSource)
        {
            if (!s_datasetTemplate.TryParseName(dataSource, out _)
                && !s_projectTemplate.TryParseName(dataSource, out _))
                throw new ArgumentException(
                    $"'{dataSource}' is not a valid value for ${nameof(DataSource)}. It should be of the form "
                    + "projects/<project>/datasets/<datasetid>.", nameof(DataSource));

            return dataSource;
        }

        internal BigQueryConnectionStringBuilder Clone() 
            => new BigQueryConnectionStringBuilder(ConnectionString, Credential);

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