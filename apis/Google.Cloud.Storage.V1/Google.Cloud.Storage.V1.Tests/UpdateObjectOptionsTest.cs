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

using System;
using Xunit;
using static Google.Apis.Storage.v1.ObjectsResource;
using static Google.Apis.Storage.v1.ObjectsResource.UpdateRequest;
using Object = Google.Apis.Storage.v1.Data.Object;

namespace Google.Cloud.Storage.V1.Tests
{
    public class UpdateObjectOptionsTest
    {
        [Fact]
        public void ModifyRequest_DefaultOptions()
        {
            var obj = new Object { Generation = 10L, Metageneration = 20L };
            var request = new UpdateRequest(null, obj, "bucket", "object");
            var options = new UpdateObjectOptions();
            options.ModifyRequest(request, obj);
            Assert.Null(request.Generation);
            Assert.Equal(10L, request.IfGenerationMatch);
            Assert.Null(request.IfGenerationNotMatch);
            Assert.Equal(20L, request.IfMetagenerationMatch);
            Assert.Null(request.IfMetagenerationNotMatch);
            Assert.Null(request.PredefinedAcl);
            Assert.Null(request.Projection);
            Assert.Null(request.UserProject);
        }

        [Fact]
        public void ModifyRequest_ForceNoPreconditions()
        {
            var obj = new Object { Generation = 10L, Metageneration = 20L };
            var request = new UpdateRequest(null, obj, "bucket", "object");
            var options = new UpdateObjectOptions { ForceNoPreconditions = true };
            options.ModifyRequest(request, obj);
            Assert.Null(request.Generation);
            Assert.Null(request.IfGenerationMatch);
            Assert.Null(request.IfGenerationNotMatch);
            Assert.Null(request.IfMetagenerationMatch);
            Assert.Null(request.IfMetagenerationNotMatch);
            Assert.Null(request.PredefinedAcl);
            Assert.Null(request.Projection);
        }

        [Fact]
        public void ModifyRequest_PositiveMatchOptions()
        {
            var obj = new Object { Generation = 10L, Metageneration = 20L };
            var request = new UpdateRequest(null, obj, "bucket", "object");
            var options = new UpdateObjectOptions
            {
                Generation = 1L,
                IfGenerationMatch = 2L,
                IfMetagenerationMatch = 3L,
                PredefinedAcl = PredefinedObjectAcl.AuthenticatedRead,
                Projection = Projection.Full,
                UserProject = "proj"
            };
            options.ModifyRequest(request, obj);
            Assert.Equal(1L, request.Generation);
            Assert.Equal(2L, request.IfGenerationMatch);
            Assert.Null(request.IfGenerationNotMatch);
            Assert.Equal(3L, request.IfMetagenerationMatch);
            Assert.Null(request.IfMetagenerationNotMatch);
            Assert.Equal(PredefinedAclEnum.AuthenticatedRead, request.PredefinedAcl);
            Assert.Equal(ProjectionEnum.Full, request.Projection);
            Assert.Equal("proj", request.UserProject);
        }

        [Fact]
        public void ModifyRequest_NegativeMatchOptions()
        {
            var obj = new Object { Generation = 10L, Metageneration = 20L };
            var request = new UpdateRequest(null, obj, "bucket", "object");
            var options = new UpdateObjectOptions
            {
                Generation = 1L,
                IfGenerationNotMatch = 2L,
                IfMetagenerationNotMatch = 3L,
                PredefinedAcl = PredefinedObjectAcl.AuthenticatedRead,
                Projection = Projection.Full
            };
            options.ModifyRequest(request, obj);
            Assert.Equal(1L, request.Generation);
            Assert.Null(request.IfGenerationMatch);
            Assert.Equal(2L, request.IfGenerationNotMatch);
            Assert.Null(request.IfMetagenerationMatch);
            Assert.Equal(3L, request.IfMetagenerationNotMatch);
            Assert.Equal(PredefinedAclEnum.AuthenticatedRead, request.PredefinedAcl);
            Assert.Equal(ProjectionEnum.Full, request.Projection);
        }

        [Fact]
        public void ModifyRequest_MatchNotMatchConflicts()
        {
            var obj = new Object { Generation = 10L, Metageneration = 20L };
            var request = new UpdateRequest(null, obj, "bucket", "object");
            Assert.Throws<ArgumentException>(() =>
            {
                var options = new UpdateObjectOptions { IfGenerationMatch = 1L, IfGenerationNotMatch = 2L };
                options.ModifyRequest(request, obj);
            });
            Assert.Throws<ArgumentException>(() =>
            {
                var options = new UpdateObjectOptions { IfMetagenerationMatch = 1L, IfMetagenerationNotMatch = 2L };
                options.ModifyRequest(request, obj);
            });
        }

        [Fact]
        public void ModifyRequest_ForceNoPreconditions_ButPreconditionsSet()
        {
            var obj = new Object { Generation = 10L, Metageneration = 20L };
            var request = new UpdateRequest(null, obj, "bucket", "object");
            var options = new UpdateObjectOptions { ForceNoPreconditions = true, IfGenerationMatch = 2L };
            Assert.Throws<ArgumentException>(() => options.ModifyRequest(request, obj));
        }
    }
}
