// Copyright 2020 Google LLC
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

using Google.Apis.Bigquery.v2.Data;
using System;
using Xunit;

namespace Google.Cloud.BigQuery.V2.Tests
{
    public class RoutineExtensionsTest
    {
        [Theory]
        [InlineData(null, null)]
        [InlineData(RoutineType.ScalarFunction, "SCALAR_FUNCTION")]
        [InlineData(RoutineType.StoredProcedure, "PROCEDURE")]
        public void SetRoutineType(RoutineType? routineType, string expectedType)
        {
            var routine = new Routine();
            routine.SetRoutineType(routineType);
            Assert.Equal(expectedType, routine.RoutineType);
        }

        [Fact]
        public void SetRoutineType_Invalid()
        {
            var routine = new Routine();
            Assert.Throws<ArgumentException>(() => routine.SetRoutineType((RoutineType)200));
        }

        [Theory]
        [InlineData(null, null)]
        [InlineData("ROUTINE_TYPE_UNSPECIFIED", null)]
        [InlineData("SCALAR_FUNCTION", RoutineType.ScalarFunction)]
        [InlineData("PROCEDURE", RoutineType.StoredProcedure)]
        public void GetRoutineType(string routineType, RoutineType? expectedType)
        {
            var routine = new Routine { RoutineType = routineType };
            Assert.Equal(expectedType, routine.GetRoutineType());
        }

        [Fact]
        public void GetRoutineType_Invalid()
        {
            var routine = new Routine { RoutineType = "invalid" };
            Assert.Throws<ArgumentException>(() => routine.GetRoutineType());
        }

        [Theory]
        [InlineData(null, null)]
        [InlineData(RoutineLanguage.JavaScript, "JAVASCRIPT")]
        [InlineData(RoutineLanguage.Sql, "SQL")]
        public void SetLanguage(RoutineLanguage? routineLanguage, string expectedLanguage)
        {
            var routine = new Routine();
            routine.SetRoutineLanguage(routineLanguage);
            Assert.Equal(expectedLanguage, routine.Language);
        }

        [Fact]
        public void SetLanguage_Invalid()
        {
            var routine = new Routine();
            Assert.Throws<ArgumentException>(() => routine.SetRoutineLanguage((RoutineLanguage)200));
        }

        [Theory]
        [InlineData(null, null)]
        [InlineData("LANGUAGE_UNSPECIFIED", null)]
        [InlineData("JAVASCRIPT", RoutineLanguage.JavaScript)]
        [InlineData("SQL", RoutineLanguage.Sql)]
        public void GetLanguage(string routineLanguage, RoutineLanguage? expectedLanguage)
        {
            var routine = new Routine { Language = routineLanguage };
            Assert.Equal(expectedLanguage, routine.GetRoutineLanguage());
        }

        [Fact]
        public void GetLanguage_Invalid()
        {
            var routine = new Routine { Language = "invalid" };
            Assert.Throws<ArgumentException>(() => routine.GetRoutineLanguage());
        }

        [Fact]
        public void ReferenceSameAs_FirstNull()
        {
            RoutineReference first = null;
            RoutineReference second = new RoutineReference();

            Assert.Throws<ArgumentNullException>(() => first.ReferencesSameAs(second));
        }

        [Fact]
        public void ReferenceSameAs_SecondNull()
        {
            RoutineReference first = new RoutineReference();
            RoutineReference second = null;

            Assert.Throws<ArgumentNullException>(() => first.ReferencesSameAs(second));
        }

        [Fact]
        public void ReferenceSameAs_True()
        {
            RoutineReference first = new RoutineReference { ProjectId = "project", DatasetId = "dataset", RoutineId = "routine"};
            RoutineReference second = new RoutineReference { ProjectId = "project", DatasetId = "dataset", RoutineId = "routine" };

            Assert.True(first.ReferencesSameAs(second));
        }

        [Theory]
        [InlineData("project1", "dataset", "routine")]
        [InlineData("project", "dataset1", "routine")]
        [InlineData("project", "dataset", "routine1")]
        public void ReferenceSameAs_False(string projectId, string datasetId, string routineId)
        {
            RoutineReference first = new RoutineReference { ProjectId = "project", DatasetId = "dataset", RoutineId = "routine" };
            RoutineReference second = new RoutineReference { ProjectId = projectId, DatasetId = datasetId, RoutineId = routineId };

            Assert.False(first.ReferencesSameAs(second));
        }
    }
}
