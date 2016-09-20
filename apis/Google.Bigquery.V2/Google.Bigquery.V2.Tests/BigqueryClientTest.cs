// Copyright 2016 Google Inc. All Rights Reserved.
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

using Google.Cloud.ClientTesting;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Xunit;

namespace Google.Bigquery.V2.Tests
{
    public class BigqueryClientTest : AbstractClientTester<BigqueryClient, BigqueryClientTest.DerivedBigqueryClient>
    {
        // The Get*Reference methods are actually implemented...
        public static IEnumerable<object[]> NotImplementedMethods => AllInstanceMethods
            .Where(array =>
            {
                var method = (MethodInfo)array[0];
                return !(method.Name.StartsWith("Get") && method.Name.EndsWith("Reference"));
            });

        public class DerivedBigqueryClient : BigqueryClient
        {
            public override string ProjectId => "project";
        }

        [Theory]
        [MemberData(nameof(NotImplementedMethods))]
        public void NotImplementedMethodsThrow(MethodInfo method)
        {
            AssertNotImplemented(method);
        }

        protected override object GetArgument(ParameterInfo parameter)
        {
            if (parameter.ParameterType == typeof(InsertRow))
            {
                return new InsertRow();
            }
            return base.GetArgument(parameter);
        }

        [Fact]
        public void GetJobReference_ImplicitProject()
        {
            var reference = new DerivedBigqueryClient().GetJobReference("jobid");
            Assert.Equal("jobid", reference.JobId);
            Assert.Equal("project", reference.ProjectId);
        }

        [Fact]
        public void GetJobReference_ExplicitProject()
        {
            var reference = new DerivedBigqueryClient().GetJobReference("p", "jobid");
            Assert.Equal("jobid", reference.JobId);
            Assert.Equal("p", reference.ProjectId);
        }

        [Fact]
        public void GetTableReference_ImplicitProject()
        {
            var reference = new DerivedBigqueryClient().GetTableReference("datasetid", "tableid");
            Assert.Equal("datasetid", reference.DatasetId);
            Assert.Equal("tableid", reference.TableId);
            Assert.Equal("project", reference.ProjectId);
        }

        [Fact]
        public void GetTableReference_ExplicitProject()
        {
            var reference = new DerivedBigqueryClient().GetTableReference("p", "datasetid", "tableid");
            Assert.Equal("datasetid", reference.DatasetId);
            Assert.Equal("tableid", reference.TableId);
            Assert.Equal("p", reference.ProjectId);
        }

        [Fact]
        public void GetDatasetReference_ImplicitProject()
        {
            var reference = new DerivedBigqueryClient().GetDatasetReference("datasetid");
            Assert.Equal("datasetid", reference.DatasetId);
            Assert.Equal("project", reference.ProjectId);
        }

        [Fact]
        public void GetDatasetReference_ExplicitProject()
        {
            var reference = new DerivedBigqueryClient().GetDatasetReference("p", "datasetid");
            Assert.Equal("datasetid", reference.DatasetId);
            Assert.Equal("p", reference.ProjectId);
        }

        [Fact]
        public void GetProjectReference_ExplicitProject()
        {
            var reference = new DerivedBigqueryClient().GetProjectReference("p");
            Assert.Equal("p", reference.ProjectId);
        }
    }
}