// Copyright 2019, Google Inc. All rights reserved.
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
using Xunit;

namespace Google.Cloud.Firestore.V1.Tests
{
    public class FirestoreClientImplTest
    {
        [Theory]
        [InlineData("projects/proj/databases/database", "projects/proj/databases/database")]
        [InlineData("projects/proj/databases/database/", "projects/proj/databases/database")]
        [InlineData("projects/proj/databases/database/documents", "projects/proj/databases/database")]
        [InlineData("projects/proj/databases/database/documents/col1/doc", "projects/proj/databases/database")]
        [InlineData("projects/proj_id/databases/(default)/foo", "projects/proj_id/databases/(default)")]
        public void GetDatabaseResourceName_Valid(string resourceName, string expectedDatabaseName)
        {
            Assert.Equal(expectedDatabaseName, FirestoreClientImpl.GetDatabaseResourceName(resourceName));
        }

        [Theory]
        [InlineData("")]
        [InlineData("projects//databases/(default)/foo")]
        [InlineData("not_projects/project/databases/(default)/foo")]
        [InlineData("projects/proj/not_databases/database")]
        [InlineData("projects/")]
        [InlineData("projects/proj/")]
        [InlineData("projects/proj/databases")]
        [InlineData("projects/proj/databases/")]
        [InlineData("projects/proj/databases//other")]
        public void GetDatabaseResourceName_Invalid(string resourceName)
        {
            Assert.Throws<ArgumentException>(() => FirestoreClientImpl.GetDatabaseResourceName(resourceName));
        }
    }
}
