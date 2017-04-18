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

using System.Data.Common;
using System.Threading;
using System.Threading.Tasks;
using Google.Apis.Auth.OAuth2;
using Google.Cloud.Spanner.V1;

// ReSharper disable UnusedParameter.Local

namespace Google.Cloud.Spanner
{
    /// <summary>
    ///     A connection string builder for Spanner connection strings.
    /// </summary>
    public class SpannerConnectionStringBuilder : DbConnectionStringBuilder
    {
        /// <summary>
        /// </summary>
        /// <param name="connectionString"></param>
        /// <param name="credential"></param>
        public SpannerConnectionStringBuilder(string connectionString, ITokenAccess credential)
        {
            Credential = credential;
            ConnectionString = connectionString;
        }

        /// <summary>
        /// </summary>
        public SpannerConnectionStringBuilder()
        {
        }

        /// <summary>
        /// </summary>
        public string ClientId
        {
            get { return (string) this[nameof(ClientId)]; }
            private set { this[nameof(ClientId)] = value; }
        }

        /// <summary>
        /// </summary>
        public string ClientSecret
        {
            get { return (string) this[nameof(ClientSecret)]; }
            private set { this[nameof(ClientSecret)] = value; }
        }

        /// <summary>
        /// </summary>
        public ITokenAccess Credential { get; private set; }

        /// <summary>
        /// </summary>
        public string DataSource
        {
            get { return (string) this["Data Source"]; }
            private set { this["Data Source"] = value; }
        }

        /// <summary>
        /// </summary>
        public string Project => ParsedDataSourcePart(0);

        /// <summary>
        /// </summary>
        public string SpannerDatabase => ParsedDataSourcePart(2);

        /// <summary>
        /// </summary>
        public string SpannerInstance => ParsedDataSourcePart(1);

        /// <summary>
        /// </summary>
        public string UserName
        {
            get { return (string) this[nameof(UserName)]; }
            private set { this[nameof(UserName)] = value; }
        }

        /// <summary>
        /// </summary>
        /// <returns></returns>
        public async Task<UserCredential> QueryForCredentials()
        {
            if (Credential == null)
            {
                var clientId = ClientId;
                var clientSecret = ClientSecret;
                if (!string.IsNullOrEmpty(clientId)
                    && !string.IsNullOrEmpty(clientSecret))
                    return
                        await
                            GoogleWebAuthorizationBroker.AuthorizeAsync(
                                new ClientSecrets {
                                    ClientId = clientId,
                                    ClientSecret = clientSecret
                                },
                                SpannerClient.DefaultScopes,
                                "user",
                                CancellationToken.None);
            }
            return null;
        }

        internal SpannerConnectionStringBuilder CloneWithNewDataSource(string dataSource)
        {
            var newInstance = new SpannerConnectionStringBuilder();
            newInstance.Credential = Credential;
            newInstance.ClientId = ClientId;
            newInstance.ClientSecret = ClientSecret;
            newInstance.UserName = UserName;
            newInstance.DataSource = dataSource;
            return newInstance;
        }

        private string ParsedDataSourcePart(int index)
        {
            var dataSource = DataSource;
            if (string.IsNullOrEmpty(dataSource))
                return string.Empty;
            var parts = dataSource.Split('/');
            if (parts.Length != 3) return string.Empty;
            return parts[index];
        }
    }
}