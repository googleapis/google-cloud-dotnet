// Copyright 2022 Google LLC
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

// Generated code. DO NOT EDIT!

using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using gagr = Google.Api.Gax.ResourceNames;
using lro = Google.LongRunning;
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.Logging.V2.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedConfigServiceV2ClientTest
    {
        [xunit::FactAttribute]
        public void GetBucketRequestObject()
        {
            moq::Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new moq::Mock<ConfigServiceV2.ConfigServiceV2Client>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetBucketRequest request = new GetBucketRequest
            {
                LogBucketName = LogBucketName.FromProjectLocationBucket("[PROJECT]", "[LOCATION]", "[BUCKET]"),
            };
            LogBucket expectedResponse = new LogBucket
            {
                LogBucketName = LogBucketName.FromProjectLocationBucket("[PROJECT]", "[LOCATION]", "[BUCKET]"),
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Locked = true,
                RetentionDays = -710726207,
                LifecycleState = LifecycleState.Unspecified,
                RestrictedFields =
                {
                    "restricted_fields6a1f6114",
                },
                CmekSettings = new CmekSettings(),
            };
            mockGrpcClient.Setup(x => x.GetBucket(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null, null);
            LogBucket response = client.GetBucket(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetBucketRequestObjectAsync()
        {
            moq::Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new moq::Mock<ConfigServiceV2.ConfigServiceV2Client>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetBucketRequest request = new GetBucketRequest
            {
                LogBucketName = LogBucketName.FromProjectLocationBucket("[PROJECT]", "[LOCATION]", "[BUCKET]"),
            };
            LogBucket expectedResponse = new LogBucket
            {
                LogBucketName = LogBucketName.FromProjectLocationBucket("[PROJECT]", "[LOCATION]", "[BUCKET]"),
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Locked = true,
                RetentionDays = -710726207,
                LifecycleState = LifecycleState.Unspecified,
                RestrictedFields =
                {
                    "restricted_fields6a1f6114",
                },
                CmekSettings = new CmekSettings(),
            };
            mockGrpcClient.Setup(x => x.GetBucketAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<LogBucket>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null, null);
            LogBucket responseCallSettings = await client.GetBucketAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            LogBucket responseCancellationToken = await client.GetBucketAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateBucketRequestObject()
        {
            moq::Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new moq::Mock<ConfigServiceV2.ConfigServiceV2Client>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateBucketRequest request = new CreateBucketRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                BucketId = "bucket_ida571c84e",
                Bucket = new LogBucket(),
            };
            LogBucket expectedResponse = new LogBucket
            {
                LogBucketName = LogBucketName.FromProjectLocationBucket("[PROJECT]", "[LOCATION]", "[BUCKET]"),
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Locked = true,
                RetentionDays = -710726207,
                LifecycleState = LifecycleState.Unspecified,
                RestrictedFields =
                {
                    "restricted_fields6a1f6114",
                },
                CmekSettings = new CmekSettings(),
            };
            mockGrpcClient.Setup(x => x.CreateBucket(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null, null);
            LogBucket response = client.CreateBucket(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateBucketRequestObjectAsync()
        {
            moq::Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new moq::Mock<ConfigServiceV2.ConfigServiceV2Client>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateBucketRequest request = new CreateBucketRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                BucketId = "bucket_ida571c84e",
                Bucket = new LogBucket(),
            };
            LogBucket expectedResponse = new LogBucket
            {
                LogBucketName = LogBucketName.FromProjectLocationBucket("[PROJECT]", "[LOCATION]", "[BUCKET]"),
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Locked = true,
                RetentionDays = -710726207,
                LifecycleState = LifecycleState.Unspecified,
                RestrictedFields =
                {
                    "restricted_fields6a1f6114",
                },
                CmekSettings = new CmekSettings(),
            };
            mockGrpcClient.Setup(x => x.CreateBucketAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<LogBucket>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null, null);
            LogBucket responseCallSettings = await client.CreateBucketAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            LogBucket responseCancellationToken = await client.CreateBucketAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateBucketRequestObject()
        {
            moq::Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new moq::Mock<ConfigServiceV2.ConfigServiceV2Client>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateBucketRequest request = new UpdateBucketRequest
            {
                LogBucketName = LogBucketName.FromProjectLocationBucket("[PROJECT]", "[LOCATION]", "[BUCKET]"),
                Bucket = new LogBucket(),
                UpdateMask = new wkt::FieldMask(),
            };
            LogBucket expectedResponse = new LogBucket
            {
                LogBucketName = LogBucketName.FromProjectLocationBucket("[PROJECT]", "[LOCATION]", "[BUCKET]"),
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Locked = true,
                RetentionDays = -710726207,
                LifecycleState = LifecycleState.Unspecified,
                RestrictedFields =
                {
                    "restricted_fields6a1f6114",
                },
                CmekSettings = new CmekSettings(),
            };
            mockGrpcClient.Setup(x => x.UpdateBucket(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null, null);
            LogBucket response = client.UpdateBucket(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateBucketRequestObjectAsync()
        {
            moq::Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new moq::Mock<ConfigServiceV2.ConfigServiceV2Client>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateBucketRequest request = new UpdateBucketRequest
            {
                LogBucketName = LogBucketName.FromProjectLocationBucket("[PROJECT]", "[LOCATION]", "[BUCKET]"),
                Bucket = new LogBucket(),
                UpdateMask = new wkt::FieldMask(),
            };
            LogBucket expectedResponse = new LogBucket
            {
                LogBucketName = LogBucketName.FromProjectLocationBucket("[PROJECT]", "[LOCATION]", "[BUCKET]"),
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Locked = true,
                RetentionDays = -710726207,
                LifecycleState = LifecycleState.Unspecified,
                RestrictedFields =
                {
                    "restricted_fields6a1f6114",
                },
                CmekSettings = new CmekSettings(),
            };
            mockGrpcClient.Setup(x => x.UpdateBucketAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<LogBucket>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null, null);
            LogBucket responseCallSettings = await client.UpdateBucketAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            LogBucket responseCancellationToken = await client.UpdateBucketAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteBucketRequestObject()
        {
            moq::Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new moq::Mock<ConfigServiceV2.ConfigServiceV2Client>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteBucketRequest request = new DeleteBucketRequest
            {
                LogBucketName = LogBucketName.FromProjectLocationBucket("[PROJECT]", "[LOCATION]", "[BUCKET]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteBucket(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteBucket(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteBucketRequestObjectAsync()
        {
            moq::Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new moq::Mock<ConfigServiceV2.ConfigServiceV2Client>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteBucketRequest request = new DeleteBucketRequest
            {
                LogBucketName = LogBucketName.FromProjectLocationBucket("[PROJECT]", "[LOCATION]", "[BUCKET]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteBucketAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteBucketAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteBucketAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UndeleteBucketRequestObject()
        {
            moq::Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new moq::Mock<ConfigServiceV2.ConfigServiceV2Client>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UndeleteBucketRequest request = new UndeleteBucketRequest
            {
                LogBucketName = LogBucketName.FromProjectLocationBucket("[PROJECT]", "[LOCATION]", "[BUCKET]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.UndeleteBucket(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null, null);
            client.UndeleteBucket(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UndeleteBucketRequestObjectAsync()
        {
            moq::Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new moq::Mock<ConfigServiceV2.ConfigServiceV2Client>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UndeleteBucketRequest request = new UndeleteBucketRequest
            {
                LogBucketName = LogBucketName.FromProjectLocationBucket("[PROJECT]", "[LOCATION]", "[BUCKET]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.UndeleteBucketAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null, null);
            await client.UndeleteBucketAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.UndeleteBucketAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetViewRequestObject()
        {
            moq::Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new moq::Mock<ConfigServiceV2.ConfigServiceV2Client>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetViewRequest request = new GetViewRequest
            {
                LogViewName = LogViewName.FromProjectLocationBucketView("[PROJECT]", "[LOCATION]", "[BUCKET]", "[VIEW]"),
            };
            LogView expectedResponse = new LogView
            {
                LogViewName = LogViewName.FromProjectLocationBucketView("[PROJECT]", "[LOCATION]", "[BUCKET]", "[VIEW]"),
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Filter = "filtere47ac9b2",
            };
            mockGrpcClient.Setup(x => x.GetView(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null, null);
            LogView response = client.GetView(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetViewRequestObjectAsync()
        {
            moq::Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new moq::Mock<ConfigServiceV2.ConfigServiceV2Client>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetViewRequest request = new GetViewRequest
            {
                LogViewName = LogViewName.FromProjectLocationBucketView("[PROJECT]", "[LOCATION]", "[BUCKET]", "[VIEW]"),
            };
            LogView expectedResponse = new LogView
            {
                LogViewName = LogViewName.FromProjectLocationBucketView("[PROJECT]", "[LOCATION]", "[BUCKET]", "[VIEW]"),
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Filter = "filtere47ac9b2",
            };
            mockGrpcClient.Setup(x => x.GetViewAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<LogView>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null, null);
            LogView responseCallSettings = await client.GetViewAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            LogView responseCancellationToken = await client.GetViewAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateViewRequestObject()
        {
            moq::Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new moq::Mock<ConfigServiceV2.ConfigServiceV2Client>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateViewRequest request = new CreateViewRequest
            {
                Parent = "parent7858e4d0",
                ViewId = "view_id98131a2e",
                View = new LogView(),
            };
            LogView expectedResponse = new LogView
            {
                LogViewName = LogViewName.FromProjectLocationBucketView("[PROJECT]", "[LOCATION]", "[BUCKET]", "[VIEW]"),
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Filter = "filtere47ac9b2",
            };
            mockGrpcClient.Setup(x => x.CreateView(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null, null);
            LogView response = client.CreateView(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateViewRequestObjectAsync()
        {
            moq::Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new moq::Mock<ConfigServiceV2.ConfigServiceV2Client>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateViewRequest request = new CreateViewRequest
            {
                Parent = "parent7858e4d0",
                ViewId = "view_id98131a2e",
                View = new LogView(),
            };
            LogView expectedResponse = new LogView
            {
                LogViewName = LogViewName.FromProjectLocationBucketView("[PROJECT]", "[LOCATION]", "[BUCKET]", "[VIEW]"),
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Filter = "filtere47ac9b2",
            };
            mockGrpcClient.Setup(x => x.CreateViewAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<LogView>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null, null);
            LogView responseCallSettings = await client.CreateViewAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            LogView responseCancellationToken = await client.CreateViewAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateViewRequestObject()
        {
            moq::Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new moq::Mock<ConfigServiceV2.ConfigServiceV2Client>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateViewRequest request = new UpdateViewRequest
            {
                Name = "name1c9368b0",
                View = new LogView(),
                UpdateMask = new wkt::FieldMask(),
            };
            LogView expectedResponse = new LogView
            {
                LogViewName = LogViewName.FromProjectLocationBucketView("[PROJECT]", "[LOCATION]", "[BUCKET]", "[VIEW]"),
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Filter = "filtere47ac9b2",
            };
            mockGrpcClient.Setup(x => x.UpdateView(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null, null);
            LogView response = client.UpdateView(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateViewRequestObjectAsync()
        {
            moq::Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new moq::Mock<ConfigServiceV2.ConfigServiceV2Client>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateViewRequest request = new UpdateViewRequest
            {
                Name = "name1c9368b0",
                View = new LogView(),
                UpdateMask = new wkt::FieldMask(),
            };
            LogView expectedResponse = new LogView
            {
                LogViewName = LogViewName.FromProjectLocationBucketView("[PROJECT]", "[LOCATION]", "[BUCKET]", "[VIEW]"),
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Filter = "filtere47ac9b2",
            };
            mockGrpcClient.Setup(x => x.UpdateViewAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<LogView>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null, null);
            LogView responseCallSettings = await client.UpdateViewAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            LogView responseCancellationToken = await client.UpdateViewAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteViewRequestObject()
        {
            moq::Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new moq::Mock<ConfigServiceV2.ConfigServiceV2Client>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteViewRequest request = new DeleteViewRequest
            {
                LogViewName = LogViewName.FromProjectLocationBucketView("[PROJECT]", "[LOCATION]", "[BUCKET]", "[VIEW]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteView(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteView(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteViewRequestObjectAsync()
        {
            moq::Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new moq::Mock<ConfigServiceV2.ConfigServiceV2Client>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteViewRequest request = new DeleteViewRequest
            {
                LogViewName = LogViewName.FromProjectLocationBucketView("[PROJECT]", "[LOCATION]", "[BUCKET]", "[VIEW]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteViewAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteViewAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteViewAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetSinkRequestObject()
        {
            moq::Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new moq::Mock<ConfigServiceV2.ConfigServiceV2Client>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetSinkRequest request = new GetSinkRequest
            {
                SinkNameAsLogSinkName = LogSinkName.FromProjectSink("[PROJECT]", "[SINK]"),
            };
            LogSink expectedResponse = new LogSink
            {
                LogSinkName = LogSinkName.FromProjectSink("[PROJECT]", "[SINK]"),
                DestinationAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Filter = "filtere47ac9b2",
#pragma warning disable CS0612
                OutputVersionFormat = LogSink.Types.VersionFormat.V2,
#pragma warning restore CS0612
                WriterIdentity = "writer_identityfa497f32",
                IncludeChildren = true,
                BigqueryOptions = new BigQueryOptions(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Exclusions = { new LogExclusion(), },
                Description = "description2cf9da67",
                Disabled = false,
            };
            mockGrpcClient.Setup(x => x.GetSink(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null, null);
            LogSink response = client.GetSink(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetSinkRequestObjectAsync()
        {
            moq::Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new moq::Mock<ConfigServiceV2.ConfigServiceV2Client>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetSinkRequest request = new GetSinkRequest
            {
                SinkNameAsLogSinkName = LogSinkName.FromProjectSink("[PROJECT]", "[SINK]"),
            };
            LogSink expectedResponse = new LogSink
            {
                LogSinkName = LogSinkName.FromProjectSink("[PROJECT]", "[SINK]"),
                DestinationAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Filter = "filtere47ac9b2",
#pragma warning disable CS0612
                OutputVersionFormat = LogSink.Types.VersionFormat.V2,
#pragma warning restore CS0612
                WriterIdentity = "writer_identityfa497f32",
                IncludeChildren = true,
                BigqueryOptions = new BigQueryOptions(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Exclusions = { new LogExclusion(), },
                Description = "description2cf9da67",
                Disabled = false,
            };
            mockGrpcClient.Setup(x => x.GetSinkAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<LogSink>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null, null);
            LogSink responseCallSettings = await client.GetSinkAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            LogSink responseCancellationToken = await client.GetSinkAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetSink()
        {
            moq::Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new moq::Mock<ConfigServiceV2.ConfigServiceV2Client>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetSinkRequest request = new GetSinkRequest
            {
                SinkNameAsLogSinkName = LogSinkName.FromProjectSink("[PROJECT]", "[SINK]"),
            };
            LogSink expectedResponse = new LogSink
            {
                LogSinkName = LogSinkName.FromProjectSink("[PROJECT]", "[SINK]"),
                DestinationAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Filter = "filtere47ac9b2",
#pragma warning disable CS0612
                OutputVersionFormat = LogSink.Types.VersionFormat.V2,
#pragma warning restore CS0612
                WriterIdentity = "writer_identityfa497f32",
                IncludeChildren = true,
                BigqueryOptions = new BigQueryOptions(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Exclusions = { new LogExclusion(), },
                Description = "description2cf9da67",
                Disabled = false,
            };
            mockGrpcClient.Setup(x => x.GetSink(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null, null);
            LogSink response = client.GetSink(request.SinkName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetSinkAsync()
        {
            moq::Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new moq::Mock<ConfigServiceV2.ConfigServiceV2Client>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetSinkRequest request = new GetSinkRequest
            {
                SinkNameAsLogSinkName = LogSinkName.FromProjectSink("[PROJECT]", "[SINK]"),
            };
            LogSink expectedResponse = new LogSink
            {
                LogSinkName = LogSinkName.FromProjectSink("[PROJECT]", "[SINK]"),
                DestinationAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Filter = "filtere47ac9b2",
#pragma warning disable CS0612
                OutputVersionFormat = LogSink.Types.VersionFormat.V2,
#pragma warning restore CS0612
                WriterIdentity = "writer_identityfa497f32",
                IncludeChildren = true,
                BigqueryOptions = new BigQueryOptions(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Exclusions = { new LogExclusion(), },
                Description = "description2cf9da67",
                Disabled = false,
            };
            mockGrpcClient.Setup(x => x.GetSinkAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<LogSink>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null, null);
            LogSink responseCallSettings = await client.GetSinkAsync(request.SinkName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            LogSink responseCancellationToken = await client.GetSinkAsync(request.SinkName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetSinkResourceNames()
        {
            moq::Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new moq::Mock<ConfigServiceV2.ConfigServiceV2Client>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetSinkRequest request = new GetSinkRequest
            {
                SinkNameAsLogSinkName = LogSinkName.FromProjectSink("[PROJECT]", "[SINK]"),
            };
            LogSink expectedResponse = new LogSink
            {
                LogSinkName = LogSinkName.FromProjectSink("[PROJECT]", "[SINK]"),
                DestinationAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Filter = "filtere47ac9b2",
#pragma warning disable CS0612
                OutputVersionFormat = LogSink.Types.VersionFormat.V2,
#pragma warning restore CS0612
                WriterIdentity = "writer_identityfa497f32",
                IncludeChildren = true,
                BigqueryOptions = new BigQueryOptions(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Exclusions = { new LogExclusion(), },
                Description = "description2cf9da67",
                Disabled = false,
            };
            mockGrpcClient.Setup(x => x.GetSink(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null, null);
            LogSink response = client.GetSink(request.SinkNameAsLogSinkName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetSinkResourceNamesAsync()
        {
            moq::Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new moq::Mock<ConfigServiceV2.ConfigServiceV2Client>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetSinkRequest request = new GetSinkRequest
            {
                SinkNameAsLogSinkName = LogSinkName.FromProjectSink("[PROJECT]", "[SINK]"),
            };
            LogSink expectedResponse = new LogSink
            {
                LogSinkName = LogSinkName.FromProjectSink("[PROJECT]", "[SINK]"),
                DestinationAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Filter = "filtere47ac9b2",
#pragma warning disable CS0612
                OutputVersionFormat = LogSink.Types.VersionFormat.V2,
#pragma warning restore CS0612
                WriterIdentity = "writer_identityfa497f32",
                IncludeChildren = true,
                BigqueryOptions = new BigQueryOptions(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Exclusions = { new LogExclusion(), },
                Description = "description2cf9da67",
                Disabled = false,
            };
            mockGrpcClient.Setup(x => x.GetSinkAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<LogSink>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null, null);
            LogSink responseCallSettings = await client.GetSinkAsync(request.SinkNameAsLogSinkName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            LogSink responseCancellationToken = await client.GetSinkAsync(request.SinkNameAsLogSinkName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateSinkRequestObject()
        {
            moq::Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new moq::Mock<ConfigServiceV2.ConfigServiceV2Client>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateSinkRequest request = new CreateSinkRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Sink = new LogSink(),
                UniqueWriterIdentity = false,
            };
            LogSink expectedResponse = new LogSink
            {
                LogSinkName = LogSinkName.FromProjectSink("[PROJECT]", "[SINK]"),
                DestinationAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Filter = "filtere47ac9b2",
#pragma warning disable CS0612
                OutputVersionFormat = LogSink.Types.VersionFormat.V2,
#pragma warning restore CS0612
                WriterIdentity = "writer_identityfa497f32",
                IncludeChildren = true,
                BigqueryOptions = new BigQueryOptions(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Exclusions = { new LogExclusion(), },
                Description = "description2cf9da67",
                Disabled = false,
            };
            mockGrpcClient.Setup(x => x.CreateSink(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null, null);
            LogSink response = client.CreateSink(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateSinkRequestObjectAsync()
        {
            moq::Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new moq::Mock<ConfigServiceV2.ConfigServiceV2Client>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateSinkRequest request = new CreateSinkRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Sink = new LogSink(),
                UniqueWriterIdentity = false,
            };
            LogSink expectedResponse = new LogSink
            {
                LogSinkName = LogSinkName.FromProjectSink("[PROJECT]", "[SINK]"),
                DestinationAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Filter = "filtere47ac9b2",
#pragma warning disable CS0612
                OutputVersionFormat = LogSink.Types.VersionFormat.V2,
#pragma warning restore CS0612
                WriterIdentity = "writer_identityfa497f32",
                IncludeChildren = true,
                BigqueryOptions = new BigQueryOptions(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Exclusions = { new LogExclusion(), },
                Description = "description2cf9da67",
                Disabled = false,
            };
            mockGrpcClient.Setup(x => x.CreateSinkAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<LogSink>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null, null);
            LogSink responseCallSettings = await client.CreateSinkAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            LogSink responseCancellationToken = await client.CreateSinkAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateSink()
        {
            moq::Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new moq::Mock<ConfigServiceV2.ConfigServiceV2Client>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateSinkRequest request = new CreateSinkRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Sink = new LogSink(),
            };
            LogSink expectedResponse = new LogSink
            {
                LogSinkName = LogSinkName.FromProjectSink("[PROJECT]", "[SINK]"),
                DestinationAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Filter = "filtere47ac9b2",
#pragma warning disable CS0612
                OutputVersionFormat = LogSink.Types.VersionFormat.V2,
#pragma warning restore CS0612
                WriterIdentity = "writer_identityfa497f32",
                IncludeChildren = true,
                BigqueryOptions = new BigQueryOptions(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Exclusions = { new LogExclusion(), },
                Description = "description2cf9da67",
                Disabled = false,
            };
            mockGrpcClient.Setup(x => x.CreateSink(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null, null);
            LogSink response = client.CreateSink(request.Parent, request.Sink);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateSinkAsync()
        {
            moq::Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new moq::Mock<ConfigServiceV2.ConfigServiceV2Client>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateSinkRequest request = new CreateSinkRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Sink = new LogSink(),
            };
            LogSink expectedResponse = new LogSink
            {
                LogSinkName = LogSinkName.FromProjectSink("[PROJECT]", "[SINK]"),
                DestinationAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Filter = "filtere47ac9b2",
#pragma warning disable CS0612
                OutputVersionFormat = LogSink.Types.VersionFormat.V2,
#pragma warning restore CS0612
                WriterIdentity = "writer_identityfa497f32",
                IncludeChildren = true,
                BigqueryOptions = new BigQueryOptions(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Exclusions = { new LogExclusion(), },
                Description = "description2cf9da67",
                Disabled = false,
            };
            mockGrpcClient.Setup(x => x.CreateSinkAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<LogSink>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null, null);
            LogSink responseCallSettings = await client.CreateSinkAsync(request.Parent, request.Sink, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            LogSink responseCancellationToken = await client.CreateSinkAsync(request.Parent, request.Sink, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateSinkResourceNames1()
        {
            moq::Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new moq::Mock<ConfigServiceV2.ConfigServiceV2Client>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateSinkRequest request = new CreateSinkRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Sink = new LogSink(),
            };
            LogSink expectedResponse = new LogSink
            {
                LogSinkName = LogSinkName.FromProjectSink("[PROJECT]", "[SINK]"),
                DestinationAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Filter = "filtere47ac9b2",
#pragma warning disable CS0612
                OutputVersionFormat = LogSink.Types.VersionFormat.V2,
#pragma warning restore CS0612
                WriterIdentity = "writer_identityfa497f32",
                IncludeChildren = true,
                BigqueryOptions = new BigQueryOptions(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Exclusions = { new LogExclusion(), },
                Description = "description2cf9da67",
                Disabled = false,
            };
            mockGrpcClient.Setup(x => x.CreateSink(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null, null);
            LogSink response = client.CreateSink(request.ParentAsProjectName, request.Sink);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateSinkResourceNames1Async()
        {
            moq::Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new moq::Mock<ConfigServiceV2.ConfigServiceV2Client>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateSinkRequest request = new CreateSinkRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Sink = new LogSink(),
            };
            LogSink expectedResponse = new LogSink
            {
                LogSinkName = LogSinkName.FromProjectSink("[PROJECT]", "[SINK]"),
                DestinationAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Filter = "filtere47ac9b2",
#pragma warning disable CS0612
                OutputVersionFormat = LogSink.Types.VersionFormat.V2,
#pragma warning restore CS0612
                WriterIdentity = "writer_identityfa497f32",
                IncludeChildren = true,
                BigqueryOptions = new BigQueryOptions(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Exclusions = { new LogExclusion(), },
                Description = "description2cf9da67",
                Disabled = false,
            };
            mockGrpcClient.Setup(x => x.CreateSinkAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<LogSink>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null, null);
            LogSink responseCallSettings = await client.CreateSinkAsync(request.ParentAsProjectName, request.Sink, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            LogSink responseCancellationToken = await client.CreateSinkAsync(request.ParentAsProjectName, request.Sink, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateSinkResourceNames2()
        {
            moq::Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new moq::Mock<ConfigServiceV2.ConfigServiceV2Client>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateSinkRequest request = new CreateSinkRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Sink = new LogSink(),
            };
            LogSink expectedResponse = new LogSink
            {
                LogSinkName = LogSinkName.FromProjectSink("[PROJECT]", "[SINK]"),
                DestinationAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Filter = "filtere47ac9b2",
#pragma warning disable CS0612
                OutputVersionFormat = LogSink.Types.VersionFormat.V2,
#pragma warning restore CS0612
                WriterIdentity = "writer_identityfa497f32",
                IncludeChildren = true,
                BigqueryOptions = new BigQueryOptions(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Exclusions = { new LogExclusion(), },
                Description = "description2cf9da67",
                Disabled = false,
            };
            mockGrpcClient.Setup(x => x.CreateSink(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null, null);
            LogSink response = client.CreateSink(request.ParentAsOrganizationName, request.Sink);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateSinkResourceNames2Async()
        {
            moq::Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new moq::Mock<ConfigServiceV2.ConfigServiceV2Client>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateSinkRequest request = new CreateSinkRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Sink = new LogSink(),
            };
            LogSink expectedResponse = new LogSink
            {
                LogSinkName = LogSinkName.FromProjectSink("[PROJECT]", "[SINK]"),
                DestinationAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Filter = "filtere47ac9b2",
#pragma warning disable CS0612
                OutputVersionFormat = LogSink.Types.VersionFormat.V2,
#pragma warning restore CS0612
                WriterIdentity = "writer_identityfa497f32",
                IncludeChildren = true,
                BigqueryOptions = new BigQueryOptions(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Exclusions = { new LogExclusion(), },
                Description = "description2cf9da67",
                Disabled = false,
            };
            mockGrpcClient.Setup(x => x.CreateSinkAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<LogSink>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null, null);
            LogSink responseCallSettings = await client.CreateSinkAsync(request.ParentAsOrganizationName, request.Sink, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            LogSink responseCancellationToken = await client.CreateSinkAsync(request.ParentAsOrganizationName, request.Sink, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateSinkResourceNames3()
        {
            moq::Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new moq::Mock<ConfigServiceV2.ConfigServiceV2Client>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateSinkRequest request = new CreateSinkRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Sink = new LogSink(),
            };
            LogSink expectedResponse = new LogSink
            {
                LogSinkName = LogSinkName.FromProjectSink("[PROJECT]", "[SINK]"),
                DestinationAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Filter = "filtere47ac9b2",
#pragma warning disable CS0612
                OutputVersionFormat = LogSink.Types.VersionFormat.V2,
#pragma warning restore CS0612
                WriterIdentity = "writer_identityfa497f32",
                IncludeChildren = true,
                BigqueryOptions = new BigQueryOptions(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Exclusions = { new LogExclusion(), },
                Description = "description2cf9da67",
                Disabled = false,
            };
            mockGrpcClient.Setup(x => x.CreateSink(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null, null);
            LogSink response = client.CreateSink(request.ParentAsFolderName, request.Sink);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateSinkResourceNames3Async()
        {
            moq::Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new moq::Mock<ConfigServiceV2.ConfigServiceV2Client>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateSinkRequest request = new CreateSinkRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Sink = new LogSink(),
            };
            LogSink expectedResponse = new LogSink
            {
                LogSinkName = LogSinkName.FromProjectSink("[PROJECT]", "[SINK]"),
                DestinationAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Filter = "filtere47ac9b2",
#pragma warning disable CS0612
                OutputVersionFormat = LogSink.Types.VersionFormat.V2,
#pragma warning restore CS0612
                WriterIdentity = "writer_identityfa497f32",
                IncludeChildren = true,
                BigqueryOptions = new BigQueryOptions(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Exclusions = { new LogExclusion(), },
                Description = "description2cf9da67",
                Disabled = false,
            };
            mockGrpcClient.Setup(x => x.CreateSinkAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<LogSink>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null, null);
            LogSink responseCallSettings = await client.CreateSinkAsync(request.ParentAsFolderName, request.Sink, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            LogSink responseCancellationToken = await client.CreateSinkAsync(request.ParentAsFolderName, request.Sink, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateSinkResourceNames4()
        {
            moq::Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new moq::Mock<ConfigServiceV2.ConfigServiceV2Client>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateSinkRequest request = new CreateSinkRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Sink = new LogSink(),
            };
            LogSink expectedResponse = new LogSink
            {
                LogSinkName = LogSinkName.FromProjectSink("[PROJECT]", "[SINK]"),
                DestinationAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Filter = "filtere47ac9b2",
#pragma warning disable CS0612
                OutputVersionFormat = LogSink.Types.VersionFormat.V2,
#pragma warning restore CS0612
                WriterIdentity = "writer_identityfa497f32",
                IncludeChildren = true,
                BigqueryOptions = new BigQueryOptions(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Exclusions = { new LogExclusion(), },
                Description = "description2cf9da67",
                Disabled = false,
            };
            mockGrpcClient.Setup(x => x.CreateSink(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null, null);
            LogSink response = client.CreateSink(request.ParentAsBillingAccountName, request.Sink);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateSinkResourceNames4Async()
        {
            moq::Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new moq::Mock<ConfigServiceV2.ConfigServiceV2Client>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateSinkRequest request = new CreateSinkRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Sink = new LogSink(),
            };
            LogSink expectedResponse = new LogSink
            {
                LogSinkName = LogSinkName.FromProjectSink("[PROJECT]", "[SINK]"),
                DestinationAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Filter = "filtere47ac9b2",
#pragma warning disable CS0612
                OutputVersionFormat = LogSink.Types.VersionFormat.V2,
#pragma warning restore CS0612
                WriterIdentity = "writer_identityfa497f32",
                IncludeChildren = true,
                BigqueryOptions = new BigQueryOptions(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Exclusions = { new LogExclusion(), },
                Description = "description2cf9da67",
                Disabled = false,
            };
            mockGrpcClient.Setup(x => x.CreateSinkAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<LogSink>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null, null);
            LogSink responseCallSettings = await client.CreateSinkAsync(request.ParentAsBillingAccountName, request.Sink, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            LogSink responseCancellationToken = await client.CreateSinkAsync(request.ParentAsBillingAccountName, request.Sink, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateSinkRequestObject()
        {
            moq::Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new moq::Mock<ConfigServiceV2.ConfigServiceV2Client>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateSinkRequest request = new UpdateSinkRequest
            {
                SinkNameAsLogSinkName = LogSinkName.FromProjectSink("[PROJECT]", "[SINK]"),
                Sink = new LogSink(),
                UniqueWriterIdentity = false,
                UpdateMask = new wkt::FieldMask(),
            };
            LogSink expectedResponse = new LogSink
            {
                LogSinkName = LogSinkName.FromProjectSink("[PROJECT]", "[SINK]"),
                DestinationAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Filter = "filtere47ac9b2",
#pragma warning disable CS0612
                OutputVersionFormat = LogSink.Types.VersionFormat.V2,
#pragma warning restore CS0612
                WriterIdentity = "writer_identityfa497f32",
                IncludeChildren = true,
                BigqueryOptions = new BigQueryOptions(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Exclusions = { new LogExclusion(), },
                Description = "description2cf9da67",
                Disabled = false,
            };
            mockGrpcClient.Setup(x => x.UpdateSink(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null, null);
            LogSink response = client.UpdateSink(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateSinkRequestObjectAsync()
        {
            moq::Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new moq::Mock<ConfigServiceV2.ConfigServiceV2Client>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateSinkRequest request = new UpdateSinkRequest
            {
                SinkNameAsLogSinkName = LogSinkName.FromProjectSink("[PROJECT]", "[SINK]"),
                Sink = new LogSink(),
                UniqueWriterIdentity = false,
                UpdateMask = new wkt::FieldMask(),
            };
            LogSink expectedResponse = new LogSink
            {
                LogSinkName = LogSinkName.FromProjectSink("[PROJECT]", "[SINK]"),
                DestinationAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Filter = "filtere47ac9b2",
#pragma warning disable CS0612
                OutputVersionFormat = LogSink.Types.VersionFormat.V2,
#pragma warning restore CS0612
                WriterIdentity = "writer_identityfa497f32",
                IncludeChildren = true,
                BigqueryOptions = new BigQueryOptions(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Exclusions = { new LogExclusion(), },
                Description = "description2cf9da67",
                Disabled = false,
            };
            mockGrpcClient.Setup(x => x.UpdateSinkAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<LogSink>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null, null);
            LogSink responseCallSettings = await client.UpdateSinkAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            LogSink responseCancellationToken = await client.UpdateSinkAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateSink1()
        {
            moq::Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new moq::Mock<ConfigServiceV2.ConfigServiceV2Client>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateSinkRequest request = new UpdateSinkRequest
            {
                SinkNameAsLogSinkName = LogSinkName.FromProjectSink("[PROJECT]", "[SINK]"),
                Sink = new LogSink(),
                UpdateMask = new wkt::FieldMask(),
            };
            LogSink expectedResponse = new LogSink
            {
                LogSinkName = LogSinkName.FromProjectSink("[PROJECT]", "[SINK]"),
                DestinationAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Filter = "filtere47ac9b2",
#pragma warning disable CS0612
                OutputVersionFormat = LogSink.Types.VersionFormat.V2,
#pragma warning restore CS0612
                WriterIdentity = "writer_identityfa497f32",
                IncludeChildren = true,
                BigqueryOptions = new BigQueryOptions(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Exclusions = { new LogExclusion(), },
                Description = "description2cf9da67",
                Disabled = false,
            };
            mockGrpcClient.Setup(x => x.UpdateSink(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null, null);
            LogSink response = client.UpdateSink(request.SinkName, request.Sink, request.UpdateMask);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateSink1Async()
        {
            moq::Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new moq::Mock<ConfigServiceV2.ConfigServiceV2Client>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateSinkRequest request = new UpdateSinkRequest
            {
                SinkNameAsLogSinkName = LogSinkName.FromProjectSink("[PROJECT]", "[SINK]"),
                Sink = new LogSink(),
                UpdateMask = new wkt::FieldMask(),
            };
            LogSink expectedResponse = new LogSink
            {
                LogSinkName = LogSinkName.FromProjectSink("[PROJECT]", "[SINK]"),
                DestinationAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Filter = "filtere47ac9b2",
#pragma warning disable CS0612
                OutputVersionFormat = LogSink.Types.VersionFormat.V2,
#pragma warning restore CS0612
                WriterIdentity = "writer_identityfa497f32",
                IncludeChildren = true,
                BigqueryOptions = new BigQueryOptions(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Exclusions = { new LogExclusion(), },
                Description = "description2cf9da67",
                Disabled = false,
            };
            mockGrpcClient.Setup(x => x.UpdateSinkAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<LogSink>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null, null);
            LogSink responseCallSettings = await client.UpdateSinkAsync(request.SinkName, request.Sink, request.UpdateMask, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            LogSink responseCancellationToken = await client.UpdateSinkAsync(request.SinkName, request.Sink, request.UpdateMask, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateSink1ResourceNames()
        {
            moq::Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new moq::Mock<ConfigServiceV2.ConfigServiceV2Client>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateSinkRequest request = new UpdateSinkRequest
            {
                SinkNameAsLogSinkName = LogSinkName.FromProjectSink("[PROJECT]", "[SINK]"),
                Sink = new LogSink(),
                UpdateMask = new wkt::FieldMask(),
            };
            LogSink expectedResponse = new LogSink
            {
                LogSinkName = LogSinkName.FromProjectSink("[PROJECT]", "[SINK]"),
                DestinationAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Filter = "filtere47ac9b2",
#pragma warning disable CS0612
                OutputVersionFormat = LogSink.Types.VersionFormat.V2,
#pragma warning restore CS0612
                WriterIdentity = "writer_identityfa497f32",
                IncludeChildren = true,
                BigqueryOptions = new BigQueryOptions(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Exclusions = { new LogExclusion(), },
                Description = "description2cf9da67",
                Disabled = false,
            };
            mockGrpcClient.Setup(x => x.UpdateSink(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null, null);
            LogSink response = client.UpdateSink(request.SinkNameAsLogSinkName, request.Sink, request.UpdateMask);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateSink1ResourceNamesAsync()
        {
            moq::Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new moq::Mock<ConfigServiceV2.ConfigServiceV2Client>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateSinkRequest request = new UpdateSinkRequest
            {
                SinkNameAsLogSinkName = LogSinkName.FromProjectSink("[PROJECT]", "[SINK]"),
                Sink = new LogSink(),
                UpdateMask = new wkt::FieldMask(),
            };
            LogSink expectedResponse = new LogSink
            {
                LogSinkName = LogSinkName.FromProjectSink("[PROJECT]", "[SINK]"),
                DestinationAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Filter = "filtere47ac9b2",
#pragma warning disable CS0612
                OutputVersionFormat = LogSink.Types.VersionFormat.V2,
#pragma warning restore CS0612
                WriterIdentity = "writer_identityfa497f32",
                IncludeChildren = true,
                BigqueryOptions = new BigQueryOptions(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Exclusions = { new LogExclusion(), },
                Description = "description2cf9da67",
                Disabled = false,
            };
            mockGrpcClient.Setup(x => x.UpdateSinkAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<LogSink>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null, null);
            LogSink responseCallSettings = await client.UpdateSinkAsync(request.SinkNameAsLogSinkName, request.Sink, request.UpdateMask, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            LogSink responseCancellationToken = await client.UpdateSinkAsync(request.SinkNameAsLogSinkName, request.Sink, request.UpdateMask, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateSink2()
        {
            moq::Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new moq::Mock<ConfigServiceV2.ConfigServiceV2Client>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateSinkRequest request = new UpdateSinkRequest
            {
                SinkNameAsLogSinkName = LogSinkName.FromProjectSink("[PROJECT]", "[SINK]"),
                Sink = new LogSink(),
            };
            LogSink expectedResponse = new LogSink
            {
                LogSinkName = LogSinkName.FromProjectSink("[PROJECT]", "[SINK]"),
                DestinationAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Filter = "filtere47ac9b2",
#pragma warning disable CS0612
                OutputVersionFormat = LogSink.Types.VersionFormat.V2,
#pragma warning restore CS0612
                WriterIdentity = "writer_identityfa497f32",
                IncludeChildren = true,
                BigqueryOptions = new BigQueryOptions(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Exclusions = { new LogExclusion(), },
                Description = "description2cf9da67",
                Disabled = false,
            };
            mockGrpcClient.Setup(x => x.UpdateSink(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null, null);
            LogSink response = client.UpdateSink(request.SinkName, request.Sink);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateSink2Async()
        {
            moq::Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new moq::Mock<ConfigServiceV2.ConfigServiceV2Client>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateSinkRequest request = new UpdateSinkRequest
            {
                SinkNameAsLogSinkName = LogSinkName.FromProjectSink("[PROJECT]", "[SINK]"),
                Sink = new LogSink(),
            };
            LogSink expectedResponse = new LogSink
            {
                LogSinkName = LogSinkName.FromProjectSink("[PROJECT]", "[SINK]"),
                DestinationAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Filter = "filtere47ac9b2",
#pragma warning disable CS0612
                OutputVersionFormat = LogSink.Types.VersionFormat.V2,
#pragma warning restore CS0612
                WriterIdentity = "writer_identityfa497f32",
                IncludeChildren = true,
                BigqueryOptions = new BigQueryOptions(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Exclusions = { new LogExclusion(), },
                Description = "description2cf9da67",
                Disabled = false,
            };
            mockGrpcClient.Setup(x => x.UpdateSinkAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<LogSink>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null, null);
            LogSink responseCallSettings = await client.UpdateSinkAsync(request.SinkName, request.Sink, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            LogSink responseCancellationToken = await client.UpdateSinkAsync(request.SinkName, request.Sink, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateSink2ResourceNames()
        {
            moq::Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new moq::Mock<ConfigServiceV2.ConfigServiceV2Client>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateSinkRequest request = new UpdateSinkRequest
            {
                SinkNameAsLogSinkName = LogSinkName.FromProjectSink("[PROJECT]", "[SINK]"),
                Sink = new LogSink(),
            };
            LogSink expectedResponse = new LogSink
            {
                LogSinkName = LogSinkName.FromProjectSink("[PROJECT]", "[SINK]"),
                DestinationAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Filter = "filtere47ac9b2",
#pragma warning disable CS0612
                OutputVersionFormat = LogSink.Types.VersionFormat.V2,
#pragma warning restore CS0612
                WriterIdentity = "writer_identityfa497f32",
                IncludeChildren = true,
                BigqueryOptions = new BigQueryOptions(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Exclusions = { new LogExclusion(), },
                Description = "description2cf9da67",
                Disabled = false,
            };
            mockGrpcClient.Setup(x => x.UpdateSink(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null, null);
            LogSink response = client.UpdateSink(request.SinkNameAsLogSinkName, request.Sink);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateSink2ResourceNamesAsync()
        {
            moq::Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new moq::Mock<ConfigServiceV2.ConfigServiceV2Client>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateSinkRequest request = new UpdateSinkRequest
            {
                SinkNameAsLogSinkName = LogSinkName.FromProjectSink("[PROJECT]", "[SINK]"),
                Sink = new LogSink(),
            };
            LogSink expectedResponse = new LogSink
            {
                LogSinkName = LogSinkName.FromProjectSink("[PROJECT]", "[SINK]"),
                DestinationAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Filter = "filtere47ac9b2",
#pragma warning disable CS0612
                OutputVersionFormat = LogSink.Types.VersionFormat.V2,
#pragma warning restore CS0612
                WriterIdentity = "writer_identityfa497f32",
                IncludeChildren = true,
                BigqueryOptions = new BigQueryOptions(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Exclusions = { new LogExclusion(), },
                Description = "description2cf9da67",
                Disabled = false,
            };
            mockGrpcClient.Setup(x => x.UpdateSinkAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<LogSink>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null, null);
            LogSink responseCallSettings = await client.UpdateSinkAsync(request.SinkNameAsLogSinkName, request.Sink, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            LogSink responseCancellationToken = await client.UpdateSinkAsync(request.SinkNameAsLogSinkName, request.Sink, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteSinkRequestObject()
        {
            moq::Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new moq::Mock<ConfigServiceV2.ConfigServiceV2Client>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteSinkRequest request = new DeleteSinkRequest
            {
                SinkNameAsLogSinkName = LogSinkName.FromProjectSink("[PROJECT]", "[SINK]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteSink(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteSink(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteSinkRequestObjectAsync()
        {
            moq::Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new moq::Mock<ConfigServiceV2.ConfigServiceV2Client>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteSinkRequest request = new DeleteSinkRequest
            {
                SinkNameAsLogSinkName = LogSinkName.FromProjectSink("[PROJECT]", "[SINK]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteSinkAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteSinkAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteSinkAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteSink()
        {
            moq::Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new moq::Mock<ConfigServiceV2.ConfigServiceV2Client>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteSinkRequest request = new DeleteSinkRequest
            {
                SinkNameAsLogSinkName = LogSinkName.FromProjectSink("[PROJECT]", "[SINK]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteSink(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteSink(request.SinkName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteSinkAsync()
        {
            moq::Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new moq::Mock<ConfigServiceV2.ConfigServiceV2Client>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteSinkRequest request = new DeleteSinkRequest
            {
                SinkNameAsLogSinkName = LogSinkName.FromProjectSink("[PROJECT]", "[SINK]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteSinkAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteSinkAsync(request.SinkName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteSinkAsync(request.SinkName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteSinkResourceNames()
        {
            moq::Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new moq::Mock<ConfigServiceV2.ConfigServiceV2Client>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteSinkRequest request = new DeleteSinkRequest
            {
                SinkNameAsLogSinkName = LogSinkName.FromProjectSink("[PROJECT]", "[SINK]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteSink(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteSink(request.SinkNameAsLogSinkName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteSinkResourceNamesAsync()
        {
            moq::Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new moq::Mock<ConfigServiceV2.ConfigServiceV2Client>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteSinkRequest request = new DeleteSinkRequest
            {
                SinkNameAsLogSinkName = LogSinkName.FromProjectSink("[PROJECT]", "[SINK]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteSinkAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteSinkAsync(request.SinkNameAsLogSinkName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteSinkAsync(request.SinkNameAsLogSinkName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetExclusionRequestObject()
        {
            moq::Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new moq::Mock<ConfigServiceV2.ConfigServiceV2Client>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetExclusionRequest request = new GetExclusionRequest
            {
                LogExclusionName = LogExclusionName.FromProjectExclusion("[PROJECT]", "[EXCLUSION]"),
            };
            LogExclusion expectedResponse = new LogExclusion
            {
                LogExclusionName = LogExclusionName.FromProjectExclusion("[PROJECT]", "[EXCLUSION]"),
                Description = "description2cf9da67",
                Filter = "filtere47ac9b2",
                Disabled = false,
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetExclusion(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null, null);
            LogExclusion response = client.GetExclusion(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetExclusionRequestObjectAsync()
        {
            moq::Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new moq::Mock<ConfigServiceV2.ConfigServiceV2Client>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetExclusionRequest request = new GetExclusionRequest
            {
                LogExclusionName = LogExclusionName.FromProjectExclusion("[PROJECT]", "[EXCLUSION]"),
            };
            LogExclusion expectedResponse = new LogExclusion
            {
                LogExclusionName = LogExclusionName.FromProjectExclusion("[PROJECT]", "[EXCLUSION]"),
                Description = "description2cf9da67",
                Filter = "filtere47ac9b2",
                Disabled = false,
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetExclusionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<LogExclusion>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null, null);
            LogExclusion responseCallSettings = await client.GetExclusionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            LogExclusion responseCancellationToken = await client.GetExclusionAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetExclusion()
        {
            moq::Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new moq::Mock<ConfigServiceV2.ConfigServiceV2Client>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetExclusionRequest request = new GetExclusionRequest
            {
                LogExclusionName = LogExclusionName.FromProjectExclusion("[PROJECT]", "[EXCLUSION]"),
            };
            LogExclusion expectedResponse = new LogExclusion
            {
                LogExclusionName = LogExclusionName.FromProjectExclusion("[PROJECT]", "[EXCLUSION]"),
                Description = "description2cf9da67",
                Filter = "filtere47ac9b2",
                Disabled = false,
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetExclusion(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null, null);
            LogExclusion response = client.GetExclusion(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetExclusionAsync()
        {
            moq::Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new moq::Mock<ConfigServiceV2.ConfigServiceV2Client>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetExclusionRequest request = new GetExclusionRequest
            {
                LogExclusionName = LogExclusionName.FromProjectExclusion("[PROJECT]", "[EXCLUSION]"),
            };
            LogExclusion expectedResponse = new LogExclusion
            {
                LogExclusionName = LogExclusionName.FromProjectExclusion("[PROJECT]", "[EXCLUSION]"),
                Description = "description2cf9da67",
                Filter = "filtere47ac9b2",
                Disabled = false,
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetExclusionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<LogExclusion>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null, null);
            LogExclusion responseCallSettings = await client.GetExclusionAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            LogExclusion responseCancellationToken = await client.GetExclusionAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetExclusionResourceNames()
        {
            moq::Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new moq::Mock<ConfigServiceV2.ConfigServiceV2Client>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetExclusionRequest request = new GetExclusionRequest
            {
                LogExclusionName = LogExclusionName.FromProjectExclusion("[PROJECT]", "[EXCLUSION]"),
            };
            LogExclusion expectedResponse = new LogExclusion
            {
                LogExclusionName = LogExclusionName.FromProjectExclusion("[PROJECT]", "[EXCLUSION]"),
                Description = "description2cf9da67",
                Filter = "filtere47ac9b2",
                Disabled = false,
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetExclusion(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null, null);
            LogExclusion response = client.GetExclusion(request.LogExclusionName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetExclusionResourceNamesAsync()
        {
            moq::Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new moq::Mock<ConfigServiceV2.ConfigServiceV2Client>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetExclusionRequest request = new GetExclusionRequest
            {
                LogExclusionName = LogExclusionName.FromProjectExclusion("[PROJECT]", "[EXCLUSION]"),
            };
            LogExclusion expectedResponse = new LogExclusion
            {
                LogExclusionName = LogExclusionName.FromProjectExclusion("[PROJECT]", "[EXCLUSION]"),
                Description = "description2cf9da67",
                Filter = "filtere47ac9b2",
                Disabled = false,
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetExclusionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<LogExclusion>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null, null);
            LogExclusion responseCallSettings = await client.GetExclusionAsync(request.LogExclusionName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            LogExclusion responseCancellationToken = await client.GetExclusionAsync(request.LogExclusionName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateExclusionRequestObject()
        {
            moq::Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new moq::Mock<ConfigServiceV2.ConfigServiceV2Client>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateExclusionRequest request = new CreateExclusionRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Exclusion = new LogExclusion(),
            };
            LogExclusion expectedResponse = new LogExclusion
            {
                LogExclusionName = LogExclusionName.FromProjectExclusion("[PROJECT]", "[EXCLUSION]"),
                Description = "description2cf9da67",
                Filter = "filtere47ac9b2",
                Disabled = false,
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.CreateExclusion(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null, null);
            LogExclusion response = client.CreateExclusion(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateExclusionRequestObjectAsync()
        {
            moq::Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new moq::Mock<ConfigServiceV2.ConfigServiceV2Client>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateExclusionRequest request = new CreateExclusionRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Exclusion = new LogExclusion(),
            };
            LogExclusion expectedResponse = new LogExclusion
            {
                LogExclusionName = LogExclusionName.FromProjectExclusion("[PROJECT]", "[EXCLUSION]"),
                Description = "description2cf9da67",
                Filter = "filtere47ac9b2",
                Disabled = false,
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.CreateExclusionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<LogExclusion>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null, null);
            LogExclusion responseCallSettings = await client.CreateExclusionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            LogExclusion responseCancellationToken = await client.CreateExclusionAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateExclusion()
        {
            moq::Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new moq::Mock<ConfigServiceV2.ConfigServiceV2Client>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateExclusionRequest request = new CreateExclusionRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Exclusion = new LogExclusion(),
            };
            LogExclusion expectedResponse = new LogExclusion
            {
                LogExclusionName = LogExclusionName.FromProjectExclusion("[PROJECT]", "[EXCLUSION]"),
                Description = "description2cf9da67",
                Filter = "filtere47ac9b2",
                Disabled = false,
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.CreateExclusion(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null, null);
            LogExclusion response = client.CreateExclusion(request.Parent, request.Exclusion);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateExclusionAsync()
        {
            moq::Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new moq::Mock<ConfigServiceV2.ConfigServiceV2Client>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateExclusionRequest request = new CreateExclusionRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Exclusion = new LogExclusion(),
            };
            LogExclusion expectedResponse = new LogExclusion
            {
                LogExclusionName = LogExclusionName.FromProjectExclusion("[PROJECT]", "[EXCLUSION]"),
                Description = "description2cf9da67",
                Filter = "filtere47ac9b2",
                Disabled = false,
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.CreateExclusionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<LogExclusion>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null, null);
            LogExclusion responseCallSettings = await client.CreateExclusionAsync(request.Parent, request.Exclusion, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            LogExclusion responseCancellationToken = await client.CreateExclusionAsync(request.Parent, request.Exclusion, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateExclusionResourceNames1()
        {
            moq::Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new moq::Mock<ConfigServiceV2.ConfigServiceV2Client>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateExclusionRequest request = new CreateExclusionRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Exclusion = new LogExclusion(),
            };
            LogExclusion expectedResponse = new LogExclusion
            {
                LogExclusionName = LogExclusionName.FromProjectExclusion("[PROJECT]", "[EXCLUSION]"),
                Description = "description2cf9da67",
                Filter = "filtere47ac9b2",
                Disabled = false,
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.CreateExclusion(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null, null);
            LogExclusion response = client.CreateExclusion(request.ParentAsProjectName, request.Exclusion);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateExclusionResourceNames1Async()
        {
            moq::Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new moq::Mock<ConfigServiceV2.ConfigServiceV2Client>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateExclusionRequest request = new CreateExclusionRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Exclusion = new LogExclusion(),
            };
            LogExclusion expectedResponse = new LogExclusion
            {
                LogExclusionName = LogExclusionName.FromProjectExclusion("[PROJECT]", "[EXCLUSION]"),
                Description = "description2cf9da67",
                Filter = "filtere47ac9b2",
                Disabled = false,
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.CreateExclusionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<LogExclusion>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null, null);
            LogExclusion responseCallSettings = await client.CreateExclusionAsync(request.ParentAsProjectName, request.Exclusion, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            LogExclusion responseCancellationToken = await client.CreateExclusionAsync(request.ParentAsProjectName, request.Exclusion, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateExclusionResourceNames2()
        {
            moq::Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new moq::Mock<ConfigServiceV2.ConfigServiceV2Client>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateExclusionRequest request = new CreateExclusionRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Exclusion = new LogExclusion(),
            };
            LogExclusion expectedResponse = new LogExclusion
            {
                LogExclusionName = LogExclusionName.FromProjectExclusion("[PROJECT]", "[EXCLUSION]"),
                Description = "description2cf9da67",
                Filter = "filtere47ac9b2",
                Disabled = false,
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.CreateExclusion(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null, null);
            LogExclusion response = client.CreateExclusion(request.ParentAsOrganizationName, request.Exclusion);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateExclusionResourceNames2Async()
        {
            moq::Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new moq::Mock<ConfigServiceV2.ConfigServiceV2Client>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateExclusionRequest request = new CreateExclusionRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Exclusion = new LogExclusion(),
            };
            LogExclusion expectedResponse = new LogExclusion
            {
                LogExclusionName = LogExclusionName.FromProjectExclusion("[PROJECT]", "[EXCLUSION]"),
                Description = "description2cf9da67",
                Filter = "filtere47ac9b2",
                Disabled = false,
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.CreateExclusionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<LogExclusion>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null, null);
            LogExclusion responseCallSettings = await client.CreateExclusionAsync(request.ParentAsOrganizationName, request.Exclusion, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            LogExclusion responseCancellationToken = await client.CreateExclusionAsync(request.ParentAsOrganizationName, request.Exclusion, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateExclusionResourceNames3()
        {
            moq::Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new moq::Mock<ConfigServiceV2.ConfigServiceV2Client>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateExclusionRequest request = new CreateExclusionRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Exclusion = new LogExclusion(),
            };
            LogExclusion expectedResponse = new LogExclusion
            {
                LogExclusionName = LogExclusionName.FromProjectExclusion("[PROJECT]", "[EXCLUSION]"),
                Description = "description2cf9da67",
                Filter = "filtere47ac9b2",
                Disabled = false,
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.CreateExclusion(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null, null);
            LogExclusion response = client.CreateExclusion(request.ParentAsFolderName, request.Exclusion);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateExclusionResourceNames3Async()
        {
            moq::Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new moq::Mock<ConfigServiceV2.ConfigServiceV2Client>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateExclusionRequest request = new CreateExclusionRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Exclusion = new LogExclusion(),
            };
            LogExclusion expectedResponse = new LogExclusion
            {
                LogExclusionName = LogExclusionName.FromProjectExclusion("[PROJECT]", "[EXCLUSION]"),
                Description = "description2cf9da67",
                Filter = "filtere47ac9b2",
                Disabled = false,
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.CreateExclusionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<LogExclusion>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null, null);
            LogExclusion responseCallSettings = await client.CreateExclusionAsync(request.ParentAsFolderName, request.Exclusion, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            LogExclusion responseCancellationToken = await client.CreateExclusionAsync(request.ParentAsFolderName, request.Exclusion, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateExclusionResourceNames4()
        {
            moq::Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new moq::Mock<ConfigServiceV2.ConfigServiceV2Client>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateExclusionRequest request = new CreateExclusionRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Exclusion = new LogExclusion(),
            };
            LogExclusion expectedResponse = new LogExclusion
            {
                LogExclusionName = LogExclusionName.FromProjectExclusion("[PROJECT]", "[EXCLUSION]"),
                Description = "description2cf9da67",
                Filter = "filtere47ac9b2",
                Disabled = false,
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.CreateExclusion(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null, null);
            LogExclusion response = client.CreateExclusion(request.ParentAsBillingAccountName, request.Exclusion);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateExclusionResourceNames4Async()
        {
            moq::Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new moq::Mock<ConfigServiceV2.ConfigServiceV2Client>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateExclusionRequest request = new CreateExclusionRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Exclusion = new LogExclusion(),
            };
            LogExclusion expectedResponse = new LogExclusion
            {
                LogExclusionName = LogExclusionName.FromProjectExclusion("[PROJECT]", "[EXCLUSION]"),
                Description = "description2cf9da67",
                Filter = "filtere47ac9b2",
                Disabled = false,
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.CreateExclusionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<LogExclusion>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null, null);
            LogExclusion responseCallSettings = await client.CreateExclusionAsync(request.ParentAsBillingAccountName, request.Exclusion, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            LogExclusion responseCancellationToken = await client.CreateExclusionAsync(request.ParentAsBillingAccountName, request.Exclusion, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateExclusionRequestObject()
        {
            moq::Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new moq::Mock<ConfigServiceV2.ConfigServiceV2Client>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateExclusionRequest request = new UpdateExclusionRequest
            {
                LogExclusionName = LogExclusionName.FromProjectExclusion("[PROJECT]", "[EXCLUSION]"),
                Exclusion = new LogExclusion(),
                UpdateMask = new wkt::FieldMask(),
            };
            LogExclusion expectedResponse = new LogExclusion
            {
                LogExclusionName = LogExclusionName.FromProjectExclusion("[PROJECT]", "[EXCLUSION]"),
                Description = "description2cf9da67",
                Filter = "filtere47ac9b2",
                Disabled = false,
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.UpdateExclusion(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null, null);
            LogExclusion response = client.UpdateExclusion(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateExclusionRequestObjectAsync()
        {
            moq::Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new moq::Mock<ConfigServiceV2.ConfigServiceV2Client>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateExclusionRequest request = new UpdateExclusionRequest
            {
                LogExclusionName = LogExclusionName.FromProjectExclusion("[PROJECT]", "[EXCLUSION]"),
                Exclusion = new LogExclusion(),
                UpdateMask = new wkt::FieldMask(),
            };
            LogExclusion expectedResponse = new LogExclusion
            {
                LogExclusionName = LogExclusionName.FromProjectExclusion("[PROJECT]", "[EXCLUSION]"),
                Description = "description2cf9da67",
                Filter = "filtere47ac9b2",
                Disabled = false,
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.UpdateExclusionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<LogExclusion>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null, null);
            LogExclusion responseCallSettings = await client.UpdateExclusionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            LogExclusion responseCancellationToken = await client.UpdateExclusionAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateExclusion()
        {
            moq::Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new moq::Mock<ConfigServiceV2.ConfigServiceV2Client>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateExclusionRequest request = new UpdateExclusionRequest
            {
                LogExclusionName = LogExclusionName.FromProjectExclusion("[PROJECT]", "[EXCLUSION]"),
                Exclusion = new LogExclusion(),
                UpdateMask = new wkt::FieldMask(),
            };
            LogExclusion expectedResponse = new LogExclusion
            {
                LogExclusionName = LogExclusionName.FromProjectExclusion("[PROJECT]", "[EXCLUSION]"),
                Description = "description2cf9da67",
                Filter = "filtere47ac9b2",
                Disabled = false,
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.UpdateExclusion(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null, null);
            LogExclusion response = client.UpdateExclusion(request.Name, request.Exclusion, request.UpdateMask);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateExclusionAsync()
        {
            moq::Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new moq::Mock<ConfigServiceV2.ConfigServiceV2Client>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateExclusionRequest request = new UpdateExclusionRequest
            {
                LogExclusionName = LogExclusionName.FromProjectExclusion("[PROJECT]", "[EXCLUSION]"),
                Exclusion = new LogExclusion(),
                UpdateMask = new wkt::FieldMask(),
            };
            LogExclusion expectedResponse = new LogExclusion
            {
                LogExclusionName = LogExclusionName.FromProjectExclusion("[PROJECT]", "[EXCLUSION]"),
                Description = "description2cf9da67",
                Filter = "filtere47ac9b2",
                Disabled = false,
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.UpdateExclusionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<LogExclusion>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null, null);
            LogExclusion responseCallSettings = await client.UpdateExclusionAsync(request.Name, request.Exclusion, request.UpdateMask, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            LogExclusion responseCancellationToken = await client.UpdateExclusionAsync(request.Name, request.Exclusion, request.UpdateMask, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateExclusionResourceNames()
        {
            moq::Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new moq::Mock<ConfigServiceV2.ConfigServiceV2Client>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateExclusionRequest request = new UpdateExclusionRequest
            {
                LogExclusionName = LogExclusionName.FromProjectExclusion("[PROJECT]", "[EXCLUSION]"),
                Exclusion = new LogExclusion(),
                UpdateMask = new wkt::FieldMask(),
            };
            LogExclusion expectedResponse = new LogExclusion
            {
                LogExclusionName = LogExclusionName.FromProjectExclusion("[PROJECT]", "[EXCLUSION]"),
                Description = "description2cf9da67",
                Filter = "filtere47ac9b2",
                Disabled = false,
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.UpdateExclusion(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null, null);
            LogExclusion response = client.UpdateExclusion(request.LogExclusionName, request.Exclusion, request.UpdateMask);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateExclusionResourceNamesAsync()
        {
            moq::Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new moq::Mock<ConfigServiceV2.ConfigServiceV2Client>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateExclusionRequest request = new UpdateExclusionRequest
            {
                LogExclusionName = LogExclusionName.FromProjectExclusion("[PROJECT]", "[EXCLUSION]"),
                Exclusion = new LogExclusion(),
                UpdateMask = new wkt::FieldMask(),
            };
            LogExclusion expectedResponse = new LogExclusion
            {
                LogExclusionName = LogExclusionName.FromProjectExclusion("[PROJECT]", "[EXCLUSION]"),
                Description = "description2cf9da67",
                Filter = "filtere47ac9b2",
                Disabled = false,
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.UpdateExclusionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<LogExclusion>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null, null);
            LogExclusion responseCallSettings = await client.UpdateExclusionAsync(request.LogExclusionName, request.Exclusion, request.UpdateMask, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            LogExclusion responseCancellationToken = await client.UpdateExclusionAsync(request.LogExclusionName, request.Exclusion, request.UpdateMask, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteExclusionRequestObject()
        {
            moq::Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new moq::Mock<ConfigServiceV2.ConfigServiceV2Client>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteExclusionRequest request = new DeleteExclusionRequest
            {
                LogExclusionName = LogExclusionName.FromProjectExclusion("[PROJECT]", "[EXCLUSION]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteExclusion(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteExclusion(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteExclusionRequestObjectAsync()
        {
            moq::Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new moq::Mock<ConfigServiceV2.ConfigServiceV2Client>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteExclusionRequest request = new DeleteExclusionRequest
            {
                LogExclusionName = LogExclusionName.FromProjectExclusion("[PROJECT]", "[EXCLUSION]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteExclusionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteExclusionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteExclusionAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteExclusion()
        {
            moq::Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new moq::Mock<ConfigServiceV2.ConfigServiceV2Client>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteExclusionRequest request = new DeleteExclusionRequest
            {
                LogExclusionName = LogExclusionName.FromProjectExclusion("[PROJECT]", "[EXCLUSION]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteExclusion(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteExclusion(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteExclusionAsync()
        {
            moq::Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new moq::Mock<ConfigServiceV2.ConfigServiceV2Client>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteExclusionRequest request = new DeleteExclusionRequest
            {
                LogExclusionName = LogExclusionName.FromProjectExclusion("[PROJECT]", "[EXCLUSION]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteExclusionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteExclusionAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteExclusionAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteExclusionResourceNames()
        {
            moq::Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new moq::Mock<ConfigServiceV2.ConfigServiceV2Client>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteExclusionRequest request = new DeleteExclusionRequest
            {
                LogExclusionName = LogExclusionName.FromProjectExclusion("[PROJECT]", "[EXCLUSION]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteExclusion(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteExclusion(request.LogExclusionName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteExclusionResourceNamesAsync()
        {
            moq::Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new moq::Mock<ConfigServiceV2.ConfigServiceV2Client>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteExclusionRequest request = new DeleteExclusionRequest
            {
                LogExclusionName = LogExclusionName.FromProjectExclusion("[PROJECT]", "[EXCLUSION]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteExclusionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteExclusionAsync(request.LogExclusionName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteExclusionAsync(request.LogExclusionName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetCmekSettingsRequestObject()
        {
            moq::Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new moq::Mock<ConfigServiceV2.ConfigServiceV2Client>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetCmekSettingsRequest request = new GetCmekSettingsRequest
            {
                CmekSettingsName = CmekSettingsName.FromProject("[PROJECT]"),
            };
            CmekSettings expectedResponse = new CmekSettings
            {
                CmekSettingsName = CmekSettingsName.FromProject("[PROJECT]"),
                KmsKeyName = "kms_key_name06bd122b",
                ServiceAccountId = "service_account_idc0b71d2a",
            };
            mockGrpcClient.Setup(x => x.GetCmekSettings(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null, null);
            CmekSettings response = client.GetCmekSettings(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetCmekSettingsRequestObjectAsync()
        {
            moq::Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new moq::Mock<ConfigServiceV2.ConfigServiceV2Client>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetCmekSettingsRequest request = new GetCmekSettingsRequest
            {
                CmekSettingsName = CmekSettingsName.FromProject("[PROJECT]"),
            };
            CmekSettings expectedResponse = new CmekSettings
            {
                CmekSettingsName = CmekSettingsName.FromProject("[PROJECT]"),
                KmsKeyName = "kms_key_name06bd122b",
                ServiceAccountId = "service_account_idc0b71d2a",
            };
            mockGrpcClient.Setup(x => x.GetCmekSettingsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CmekSettings>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null, null);
            CmekSettings responseCallSettings = await client.GetCmekSettingsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CmekSettings responseCancellationToken = await client.GetCmekSettingsAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateCmekSettingsRequestObject()
        {
            moq::Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new moq::Mock<ConfigServiceV2.ConfigServiceV2Client>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateCmekSettingsRequest request = new UpdateCmekSettingsRequest
            {
                Name = "name1c9368b0",
                CmekSettings = new CmekSettings(),
                UpdateMask = new wkt::FieldMask(),
            };
            CmekSettings expectedResponse = new CmekSettings
            {
                CmekSettingsName = CmekSettingsName.FromProject("[PROJECT]"),
                KmsKeyName = "kms_key_name06bd122b",
                ServiceAccountId = "service_account_idc0b71d2a",
            };
            mockGrpcClient.Setup(x => x.UpdateCmekSettings(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null, null);
            CmekSettings response = client.UpdateCmekSettings(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateCmekSettingsRequestObjectAsync()
        {
            moq::Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new moq::Mock<ConfigServiceV2.ConfigServiceV2Client>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateCmekSettingsRequest request = new UpdateCmekSettingsRequest
            {
                Name = "name1c9368b0",
                CmekSettings = new CmekSettings(),
                UpdateMask = new wkt::FieldMask(),
            };
            CmekSettings expectedResponse = new CmekSettings
            {
                CmekSettingsName = CmekSettingsName.FromProject("[PROJECT]"),
                KmsKeyName = "kms_key_name06bd122b",
                ServiceAccountId = "service_account_idc0b71d2a",
            };
            mockGrpcClient.Setup(x => x.UpdateCmekSettingsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CmekSettings>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null, null);
            CmekSettings responseCallSettings = await client.UpdateCmekSettingsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CmekSettings responseCancellationToken = await client.UpdateCmekSettingsAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetSettingsRequestObject()
        {
            moq::Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new moq::Mock<ConfigServiceV2.ConfigServiceV2Client>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetSettingsRequest request = new GetSettingsRequest
            {
                SettingsName = SettingsName.FromProject("[PROJECT]"),
            };
            Settings expectedResponse = new Settings
            {
                SettingsName = SettingsName.FromProject("[PROJECT]"),
                KmsKeyName = "kms_key_name06bd122b",
                KmsServiceAccountId = "kms_service_account_id158e99fb",
                StorageLocation = "storage_locationde7cb603",
                DisableDefaultSink = false,
            };
            mockGrpcClient.Setup(x => x.GetSettings(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null, null);
            Settings response = client.GetSettings(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetSettingsRequestObjectAsync()
        {
            moq::Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new moq::Mock<ConfigServiceV2.ConfigServiceV2Client>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetSettingsRequest request = new GetSettingsRequest
            {
                SettingsName = SettingsName.FromProject("[PROJECT]"),
            };
            Settings expectedResponse = new Settings
            {
                SettingsName = SettingsName.FromProject("[PROJECT]"),
                KmsKeyName = "kms_key_name06bd122b",
                KmsServiceAccountId = "kms_service_account_id158e99fb",
                StorageLocation = "storage_locationde7cb603",
                DisableDefaultSink = false,
            };
            mockGrpcClient.Setup(x => x.GetSettingsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Settings>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null, null);
            Settings responseCallSettings = await client.GetSettingsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Settings responseCancellationToken = await client.GetSettingsAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetSettings()
        {
            moq::Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new moq::Mock<ConfigServiceV2.ConfigServiceV2Client>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetSettingsRequest request = new GetSettingsRequest
            {
                SettingsName = SettingsName.FromProject("[PROJECT]"),
            };
            Settings expectedResponse = new Settings
            {
                SettingsName = SettingsName.FromProject("[PROJECT]"),
                KmsKeyName = "kms_key_name06bd122b",
                KmsServiceAccountId = "kms_service_account_id158e99fb",
                StorageLocation = "storage_locationde7cb603",
                DisableDefaultSink = false,
            };
            mockGrpcClient.Setup(x => x.GetSettings(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null, null);
            Settings response = client.GetSettings(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetSettingsAsync()
        {
            moq::Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new moq::Mock<ConfigServiceV2.ConfigServiceV2Client>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetSettingsRequest request = new GetSettingsRequest
            {
                SettingsName = SettingsName.FromProject("[PROJECT]"),
            };
            Settings expectedResponse = new Settings
            {
                SettingsName = SettingsName.FromProject("[PROJECT]"),
                KmsKeyName = "kms_key_name06bd122b",
                KmsServiceAccountId = "kms_service_account_id158e99fb",
                StorageLocation = "storage_locationde7cb603",
                DisableDefaultSink = false,
            };
            mockGrpcClient.Setup(x => x.GetSettingsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Settings>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null, null);
            Settings responseCallSettings = await client.GetSettingsAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Settings responseCancellationToken = await client.GetSettingsAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetSettingsResourceNames()
        {
            moq::Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new moq::Mock<ConfigServiceV2.ConfigServiceV2Client>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetSettingsRequest request = new GetSettingsRequest
            {
                SettingsName = SettingsName.FromProject("[PROJECT]"),
            };
            Settings expectedResponse = new Settings
            {
                SettingsName = SettingsName.FromProject("[PROJECT]"),
                KmsKeyName = "kms_key_name06bd122b",
                KmsServiceAccountId = "kms_service_account_id158e99fb",
                StorageLocation = "storage_locationde7cb603",
                DisableDefaultSink = false,
            };
            mockGrpcClient.Setup(x => x.GetSettings(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null, null);
            Settings response = client.GetSettings(request.SettingsName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetSettingsResourceNamesAsync()
        {
            moq::Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new moq::Mock<ConfigServiceV2.ConfigServiceV2Client>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetSettingsRequest request = new GetSettingsRequest
            {
                SettingsName = SettingsName.FromProject("[PROJECT]"),
            };
            Settings expectedResponse = new Settings
            {
                SettingsName = SettingsName.FromProject("[PROJECT]"),
                KmsKeyName = "kms_key_name06bd122b",
                KmsServiceAccountId = "kms_service_account_id158e99fb",
                StorageLocation = "storage_locationde7cb603",
                DisableDefaultSink = false,
            };
            mockGrpcClient.Setup(x => x.GetSettingsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Settings>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null, null);
            Settings responseCallSettings = await client.GetSettingsAsync(request.SettingsName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Settings responseCancellationToken = await client.GetSettingsAsync(request.SettingsName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateSettingsRequestObject()
        {
            moq::Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new moq::Mock<ConfigServiceV2.ConfigServiceV2Client>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateSettingsRequest request = new UpdateSettingsRequest
            {
                Name = "name1c9368b0",
                Settings = new Settings(),
                UpdateMask = new wkt::FieldMask(),
            };
            Settings expectedResponse = new Settings
            {
                SettingsName = SettingsName.FromProject("[PROJECT]"),
                KmsKeyName = "kms_key_name06bd122b",
                KmsServiceAccountId = "kms_service_account_id158e99fb",
                StorageLocation = "storage_locationde7cb603",
                DisableDefaultSink = false,
            };
            mockGrpcClient.Setup(x => x.UpdateSettings(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null, null);
            Settings response = client.UpdateSettings(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateSettingsRequestObjectAsync()
        {
            moq::Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new moq::Mock<ConfigServiceV2.ConfigServiceV2Client>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateSettingsRequest request = new UpdateSettingsRequest
            {
                Name = "name1c9368b0",
                Settings = new Settings(),
                UpdateMask = new wkt::FieldMask(),
            };
            Settings expectedResponse = new Settings
            {
                SettingsName = SettingsName.FromProject("[PROJECT]"),
                KmsKeyName = "kms_key_name06bd122b",
                KmsServiceAccountId = "kms_service_account_id158e99fb",
                StorageLocation = "storage_locationde7cb603",
                DisableDefaultSink = false,
            };
            mockGrpcClient.Setup(x => x.UpdateSettingsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Settings>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null, null);
            Settings responseCallSettings = await client.UpdateSettingsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Settings responseCancellationToken = await client.UpdateSettingsAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateSettings()
        {
            moq::Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new moq::Mock<ConfigServiceV2.ConfigServiceV2Client>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateSettingsRequest request = new UpdateSettingsRequest
            {
                Settings = new Settings(),
                UpdateMask = new wkt::FieldMask(),
            };
            Settings expectedResponse = new Settings
            {
                SettingsName = SettingsName.FromProject("[PROJECT]"),
                KmsKeyName = "kms_key_name06bd122b",
                KmsServiceAccountId = "kms_service_account_id158e99fb",
                StorageLocation = "storage_locationde7cb603",
                DisableDefaultSink = false,
            };
            mockGrpcClient.Setup(x => x.UpdateSettings(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null, null);
            Settings response = client.UpdateSettings(request.Settings, request.UpdateMask);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateSettingsAsync()
        {
            moq::Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new moq::Mock<ConfigServiceV2.ConfigServiceV2Client>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateSettingsRequest request = new UpdateSettingsRequest
            {
                Settings = new Settings(),
                UpdateMask = new wkt::FieldMask(),
            };
            Settings expectedResponse = new Settings
            {
                SettingsName = SettingsName.FromProject("[PROJECT]"),
                KmsKeyName = "kms_key_name06bd122b",
                KmsServiceAccountId = "kms_service_account_id158e99fb",
                StorageLocation = "storage_locationde7cb603",
                DisableDefaultSink = false,
            };
            mockGrpcClient.Setup(x => x.UpdateSettingsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Settings>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null, null);
            Settings responseCallSettings = await client.UpdateSettingsAsync(request.Settings, request.UpdateMask, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Settings responseCancellationToken = await client.UpdateSettingsAsync(request.Settings, request.UpdateMask, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
