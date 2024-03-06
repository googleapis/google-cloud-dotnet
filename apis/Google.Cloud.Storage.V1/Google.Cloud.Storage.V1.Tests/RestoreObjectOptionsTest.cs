// Copyright 2024 Google Inc. All Rights Reserved.
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
using static Google.Apis.Storage.v1.ObjectsResource.RestoreRequest;
using Object = Google.Apis.Storage.v1.Data.Object;

namespace Google.Cloud.Storage.V1.Tests;

public class RestoreObjectOptionsTest
{
    [Fact]
    public void ModifyRequest_DefaultOptions()
    {
        var request = new RestoreRequest(null, "bucket", "object", 2L);
        var options = new RestoreObjectOptions();
        options.ModifyRequest(request);
        Assert.Null(request.IfGenerationMatch);
        Assert.Null(request.IfGenerationNotMatch);
        Assert.Null(request.IfMetagenerationMatch);
        Assert.Null(request.IfMetagenerationNotMatch);
        Assert.Null(request.CopySourceAcl);
        Assert.Null(request.Projection);
        Assert.Null(request.UserProject);
    }

    [Fact]
    public void ModifyRequest_PositiveMatchOptions()
    {
        var request = new RestoreRequest(null, "bucket", "object", 2L);
        var options = new RestoreObjectOptions
        {
            IfGenerationMatch = 1L,
            IfMetagenerationMatch = 2L,
            CopySourceAcl = true,
            Projection = Projection.Full,
            UserProject = "proj"
        };
        options.ModifyRequest(request);
        Assert.Equal(1L, request.IfGenerationMatch);
        Assert.Null(request.IfGenerationNotMatch);
        Assert.Equal(2L, request.IfMetagenerationMatch);
        Assert.Null(request.IfMetagenerationNotMatch);
        Assert.True(request.CopySourceAcl);
        Assert.Equal(ProjectionEnum.Full, request.Projection);
        Assert.Equal("proj", request.UserProject);
    }

    [Fact]
    public void ModifyRequest_NegativeMatchOptions()
    {
        var request = new RestoreRequest(null, "bucket", "object", 2L);
        var options = new RestoreObjectOptions
        {
            IfGenerationNotMatch = 1L,
            IfMetagenerationNotMatch = 2L,
            Projection = Projection.Full
        };
        options.ModifyRequest(request);
        Assert.Null(request.IfGenerationMatch);
        Assert.Equal(1L, request.IfGenerationNotMatch);
        Assert.Null(request.IfMetagenerationMatch);
        Assert.Equal(2L, request.IfMetagenerationNotMatch);
        Assert.Equal(ProjectionEnum.Full, request.Projection);
    }

    [Fact]
    public void ModifyRequest_MatchNotMatchConflicts()
    {
        var request = new RestoreRequest(null, "bucket", "object", 2L);
        Assert.Throws<ArgumentException>(() =>
        {
            var options = new RestoreObjectOptions { IfGenerationMatch = 1L, IfGenerationNotMatch = 2L };
            options.ModifyRequest(request);
        });
        Assert.Throws<ArgumentException>(() =>
        {
            var options = new RestoreObjectOptions { IfMetagenerationMatch = 1L, IfMetagenerationNotMatch = 2L };
            options.ModifyRequest(request);
        });
    }

}
