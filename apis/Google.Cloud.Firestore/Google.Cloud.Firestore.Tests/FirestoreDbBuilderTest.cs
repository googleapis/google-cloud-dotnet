// Copyright 2019, Google LLC
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

using Google.Api.Gax.Testing;
using Google.Cloud.Firestore.Converters;
using Google.Cloud.Firestore.V1;
using Grpc.Core;
using System;
using Xunit;

namespace Google.Cloud.Firestore.Tests;

public class FirestoreDbBuilderTest
{
    [Fact]
    public void MaximalConfiguration()
    {
        string warning = null;
        var builder = new FirestoreDbBuilder
        {
            ProjectId = "proj",
            DatabaseId = "db",
            CallInvoker = new FakeCallInvoker(),
            WarningLogger = text => warning = text,
            Settings = new FirestoreSettings { Clock = new FakeClock() },
            ConverterRegistry = new ConverterRegistry { new SerializationTestData.GuidConverter() }
        };
        var db = builder.Build();
        Assert.Equal("proj", db.ProjectId);
        Assert.Equal("db", db.DatabaseId);
        db.LogWarning("Test warning");
        Assert.Equal("Test warning", warning);
        Assert.IsType<FakeClock>(db.Client.Settings.Clock);
        Assert.IsType<CustomConverter<Guid>>(db.SerializationContext.GetConverter(typeof(Guid)));
    }

    [Fact]
    public void DefaultDatabase()
    {
        string projectId = "testProjectId";
        FirestoreDb defaultDb = new FirestoreDbBuilder
        {
            ProjectId = projectId,
            CallInvoker = new FakeCallInvoker()
        }.Build();
        Assert.Equal("(default)", defaultDb.DatabaseId);
    }

    [Fact]
    public void NonDefaultDatabase()
    {
        string databaseId = "testDatabase";
        string projectId = "testProjectId";
        FirestoreDb nonDefaultDb = new FirestoreDbBuilder
        {
            ProjectId = projectId,
            DatabaseId = databaseId,
            CallInvoker = new FakeCallInvoker()
        }.Build();
        Assert.Equal(databaseId, nonDefaultDb.DatabaseId);
    }

    private class FakeCallInvoker : CallInvoker
    {
        public override AsyncClientStreamingCall<TRequest, TResponse> AsyncClientStreamingCall<TRequest, TResponse>(Method<TRequest, TResponse> method, string host, CallOptions options) =>
            throw new NotImplementedException();

        public override AsyncDuplexStreamingCall<TRequest, TResponse> AsyncDuplexStreamingCall<TRequest, TResponse>(Method<TRequest, TResponse> method, string host, CallOptions options) =>
            throw new NotImplementedException();

        public override AsyncServerStreamingCall<TResponse> AsyncServerStreamingCall<TRequest, TResponse>(Method<TRequest, TResponse> method, string host, CallOptions options, TRequest request) =>
            throw new NotImplementedException();

        public override AsyncUnaryCall<TResponse> AsyncUnaryCall<TRequest, TResponse>(Method<TRequest, TResponse> method, string host, CallOptions options, TRequest request) =>
            throw new NotImplementedException();

        public override TResponse BlockingUnaryCall<TRequest, TResponse>(Method<TRequest, TResponse> method, string host, CallOptions options, TRequest request) =>
            throw new NotImplementedException();
    }
}
