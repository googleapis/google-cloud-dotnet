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

namespace Google.Cloud.Spanner.V1
{
    /// <summary>
    /// Holds a key that we use to look up cached sessions.
    /// </summary>
    internal struct SessionPoolKey : IEquatable<SessionPoolKey>
    {
        public SessionPoolKey(SpannerClient client, string project, string instance, string database)
        {
            Client = client;
            Project = project;
            Instance = instance;
            Database = database;
        }

        public SpannerClient Client { get; }
        public string Project { get; }
        public string Instance { get; }
        public string Database { get; }
        public bool Equals(SessionPoolKey other)
        {
            return (other.Client == Client && other.Project == Project && other.Instance == Instance
                    && other.Database == Database);
        }

        /// <inheritdoc />
        public override string ToString()
        {
            return $"ID:{Project}.{Instance}.{Database}";
        }
    }
}