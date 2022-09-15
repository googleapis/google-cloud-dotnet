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

#pragma warning disable CS8981
using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using gagr = Google.Api.Gax.ResourceNames;
using gciv = Google.Cloud.Iam.V1;
using proto = Google.Protobuf;
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.BigQuery.DataPolicies.V1Beta1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedDataPolicyServiceClientTest
    {
        [xunit::FactAttribute]
        public void CreateDataPolicyRequestObject()
        {
            moq::Mock<DataPolicyService.DataPolicyServiceClient> mockGrpcClient = new moq::Mock<DataPolicyService.DataPolicyServiceClient>(moq::MockBehavior.Strict);
            CreateDataPolicyRequest request = new CreateDataPolicyRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                DataPolicy = new DataPolicy(),
            };
            DataPolicy expectedResponse = new DataPolicy
            {
                DataPolicyName = DataPolicyName.FromProjectLocationDataPolicy("[PROJECT]", "[LOCATION]", "[DATA_POLICY]"),
                DataPolicyType = DataPolicy.Types.DataPolicyType.Unspecified,
                DataPolicyId = "data_policy_id8b1a53bd",
                PolicyTag = "policy_tag2a38282c",
                DataMaskingPolicy = new DataMaskingPolicy(),
            };
            mockGrpcClient.Setup(x => x.CreateDataPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataPolicyServiceClient client = new DataPolicyServiceClientImpl(mockGrpcClient.Object, null, null);
            DataPolicy response = client.CreateDataPolicy(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateDataPolicyRequestObjectAsync()
        {
            moq::Mock<DataPolicyService.DataPolicyServiceClient> mockGrpcClient = new moq::Mock<DataPolicyService.DataPolicyServiceClient>(moq::MockBehavior.Strict);
            CreateDataPolicyRequest request = new CreateDataPolicyRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                DataPolicy = new DataPolicy(),
            };
            DataPolicy expectedResponse = new DataPolicy
            {
                DataPolicyName = DataPolicyName.FromProjectLocationDataPolicy("[PROJECT]", "[LOCATION]", "[DATA_POLICY]"),
                DataPolicyType = DataPolicy.Types.DataPolicyType.Unspecified,
                DataPolicyId = "data_policy_id8b1a53bd",
                PolicyTag = "policy_tag2a38282c",
                DataMaskingPolicy = new DataMaskingPolicy(),
            };
            mockGrpcClient.Setup(x => x.CreateDataPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<DataPolicy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataPolicyServiceClient client = new DataPolicyServiceClientImpl(mockGrpcClient.Object, null, null);
            DataPolicy responseCallSettings = await client.CreateDataPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            DataPolicy responseCancellationToken = await client.CreateDataPolicyAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateDataPolicy()
        {
            moq::Mock<DataPolicyService.DataPolicyServiceClient> mockGrpcClient = new moq::Mock<DataPolicyService.DataPolicyServiceClient>(moq::MockBehavior.Strict);
            CreateDataPolicyRequest request = new CreateDataPolicyRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                DataPolicy = new DataPolicy(),
            };
            DataPolicy expectedResponse = new DataPolicy
            {
                DataPolicyName = DataPolicyName.FromProjectLocationDataPolicy("[PROJECT]", "[LOCATION]", "[DATA_POLICY]"),
                DataPolicyType = DataPolicy.Types.DataPolicyType.Unspecified,
                DataPolicyId = "data_policy_id8b1a53bd",
                PolicyTag = "policy_tag2a38282c",
                DataMaskingPolicy = new DataMaskingPolicy(),
            };
            mockGrpcClient.Setup(x => x.CreateDataPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataPolicyServiceClient client = new DataPolicyServiceClientImpl(mockGrpcClient.Object, null, null);
            DataPolicy response = client.CreateDataPolicy(request.Parent, request.DataPolicy);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateDataPolicyAsync()
        {
            moq::Mock<DataPolicyService.DataPolicyServiceClient> mockGrpcClient = new moq::Mock<DataPolicyService.DataPolicyServiceClient>(moq::MockBehavior.Strict);
            CreateDataPolicyRequest request = new CreateDataPolicyRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                DataPolicy = new DataPolicy(),
            };
            DataPolicy expectedResponse = new DataPolicy
            {
                DataPolicyName = DataPolicyName.FromProjectLocationDataPolicy("[PROJECT]", "[LOCATION]", "[DATA_POLICY]"),
                DataPolicyType = DataPolicy.Types.DataPolicyType.Unspecified,
                DataPolicyId = "data_policy_id8b1a53bd",
                PolicyTag = "policy_tag2a38282c",
                DataMaskingPolicy = new DataMaskingPolicy(),
            };
            mockGrpcClient.Setup(x => x.CreateDataPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<DataPolicy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataPolicyServiceClient client = new DataPolicyServiceClientImpl(mockGrpcClient.Object, null, null);
            DataPolicy responseCallSettings = await client.CreateDataPolicyAsync(request.Parent, request.DataPolicy, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            DataPolicy responseCancellationToken = await client.CreateDataPolicyAsync(request.Parent, request.DataPolicy, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateDataPolicyResourceNames()
        {
            moq::Mock<DataPolicyService.DataPolicyServiceClient> mockGrpcClient = new moq::Mock<DataPolicyService.DataPolicyServiceClient>(moq::MockBehavior.Strict);
            CreateDataPolicyRequest request = new CreateDataPolicyRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                DataPolicy = new DataPolicy(),
            };
            DataPolicy expectedResponse = new DataPolicy
            {
                DataPolicyName = DataPolicyName.FromProjectLocationDataPolicy("[PROJECT]", "[LOCATION]", "[DATA_POLICY]"),
                DataPolicyType = DataPolicy.Types.DataPolicyType.Unspecified,
                DataPolicyId = "data_policy_id8b1a53bd",
                PolicyTag = "policy_tag2a38282c",
                DataMaskingPolicy = new DataMaskingPolicy(),
            };
            mockGrpcClient.Setup(x => x.CreateDataPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataPolicyServiceClient client = new DataPolicyServiceClientImpl(mockGrpcClient.Object, null, null);
            DataPolicy response = client.CreateDataPolicy(request.ParentAsLocationName, request.DataPolicy);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateDataPolicyResourceNamesAsync()
        {
            moq::Mock<DataPolicyService.DataPolicyServiceClient> mockGrpcClient = new moq::Mock<DataPolicyService.DataPolicyServiceClient>(moq::MockBehavior.Strict);
            CreateDataPolicyRequest request = new CreateDataPolicyRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                DataPolicy = new DataPolicy(),
            };
            DataPolicy expectedResponse = new DataPolicy
            {
                DataPolicyName = DataPolicyName.FromProjectLocationDataPolicy("[PROJECT]", "[LOCATION]", "[DATA_POLICY]"),
                DataPolicyType = DataPolicy.Types.DataPolicyType.Unspecified,
                DataPolicyId = "data_policy_id8b1a53bd",
                PolicyTag = "policy_tag2a38282c",
                DataMaskingPolicy = new DataMaskingPolicy(),
            };
            mockGrpcClient.Setup(x => x.CreateDataPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<DataPolicy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataPolicyServiceClient client = new DataPolicyServiceClientImpl(mockGrpcClient.Object, null, null);
            DataPolicy responseCallSettings = await client.CreateDataPolicyAsync(request.ParentAsLocationName, request.DataPolicy, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            DataPolicy responseCancellationToken = await client.CreateDataPolicyAsync(request.ParentAsLocationName, request.DataPolicy, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateDataPolicyRequestObject()
        {
            moq::Mock<DataPolicyService.DataPolicyServiceClient> mockGrpcClient = new moq::Mock<DataPolicyService.DataPolicyServiceClient>(moq::MockBehavior.Strict);
            UpdateDataPolicyRequest request = new UpdateDataPolicyRequest
            {
                DataPolicy = new DataPolicy(),
                UpdateMask = new wkt::FieldMask(),
            };
            DataPolicy expectedResponse = new DataPolicy
            {
                DataPolicyName = DataPolicyName.FromProjectLocationDataPolicy("[PROJECT]", "[LOCATION]", "[DATA_POLICY]"),
                DataPolicyType = DataPolicy.Types.DataPolicyType.Unspecified,
                DataPolicyId = "data_policy_id8b1a53bd",
                PolicyTag = "policy_tag2a38282c",
                DataMaskingPolicy = new DataMaskingPolicy(),
            };
            mockGrpcClient.Setup(x => x.UpdateDataPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataPolicyServiceClient client = new DataPolicyServiceClientImpl(mockGrpcClient.Object, null, null);
            DataPolicy response = client.UpdateDataPolicy(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateDataPolicyRequestObjectAsync()
        {
            moq::Mock<DataPolicyService.DataPolicyServiceClient> mockGrpcClient = new moq::Mock<DataPolicyService.DataPolicyServiceClient>(moq::MockBehavior.Strict);
            UpdateDataPolicyRequest request = new UpdateDataPolicyRequest
            {
                DataPolicy = new DataPolicy(),
                UpdateMask = new wkt::FieldMask(),
            };
            DataPolicy expectedResponse = new DataPolicy
            {
                DataPolicyName = DataPolicyName.FromProjectLocationDataPolicy("[PROJECT]", "[LOCATION]", "[DATA_POLICY]"),
                DataPolicyType = DataPolicy.Types.DataPolicyType.Unspecified,
                DataPolicyId = "data_policy_id8b1a53bd",
                PolicyTag = "policy_tag2a38282c",
                DataMaskingPolicy = new DataMaskingPolicy(),
            };
            mockGrpcClient.Setup(x => x.UpdateDataPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<DataPolicy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataPolicyServiceClient client = new DataPolicyServiceClientImpl(mockGrpcClient.Object, null, null);
            DataPolicy responseCallSettings = await client.UpdateDataPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            DataPolicy responseCancellationToken = await client.UpdateDataPolicyAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateDataPolicy()
        {
            moq::Mock<DataPolicyService.DataPolicyServiceClient> mockGrpcClient = new moq::Mock<DataPolicyService.DataPolicyServiceClient>(moq::MockBehavior.Strict);
            UpdateDataPolicyRequest request = new UpdateDataPolicyRequest
            {
                DataPolicy = new DataPolicy(),
                UpdateMask = new wkt::FieldMask(),
            };
            DataPolicy expectedResponse = new DataPolicy
            {
                DataPolicyName = DataPolicyName.FromProjectLocationDataPolicy("[PROJECT]", "[LOCATION]", "[DATA_POLICY]"),
                DataPolicyType = DataPolicy.Types.DataPolicyType.Unspecified,
                DataPolicyId = "data_policy_id8b1a53bd",
                PolicyTag = "policy_tag2a38282c",
                DataMaskingPolicy = new DataMaskingPolicy(),
            };
            mockGrpcClient.Setup(x => x.UpdateDataPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataPolicyServiceClient client = new DataPolicyServiceClientImpl(mockGrpcClient.Object, null, null);
            DataPolicy response = client.UpdateDataPolicy(request.DataPolicy, request.UpdateMask);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateDataPolicyAsync()
        {
            moq::Mock<DataPolicyService.DataPolicyServiceClient> mockGrpcClient = new moq::Mock<DataPolicyService.DataPolicyServiceClient>(moq::MockBehavior.Strict);
            UpdateDataPolicyRequest request = new UpdateDataPolicyRequest
            {
                DataPolicy = new DataPolicy(),
                UpdateMask = new wkt::FieldMask(),
            };
            DataPolicy expectedResponse = new DataPolicy
            {
                DataPolicyName = DataPolicyName.FromProjectLocationDataPolicy("[PROJECT]", "[LOCATION]", "[DATA_POLICY]"),
                DataPolicyType = DataPolicy.Types.DataPolicyType.Unspecified,
                DataPolicyId = "data_policy_id8b1a53bd",
                PolicyTag = "policy_tag2a38282c",
                DataMaskingPolicy = new DataMaskingPolicy(),
            };
            mockGrpcClient.Setup(x => x.UpdateDataPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<DataPolicy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataPolicyServiceClient client = new DataPolicyServiceClientImpl(mockGrpcClient.Object, null, null);
            DataPolicy responseCallSettings = await client.UpdateDataPolicyAsync(request.DataPolicy, request.UpdateMask, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            DataPolicy responseCancellationToken = await client.UpdateDataPolicyAsync(request.DataPolicy, request.UpdateMask, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteDataPolicyRequestObject()
        {
            moq::Mock<DataPolicyService.DataPolicyServiceClient> mockGrpcClient = new moq::Mock<DataPolicyService.DataPolicyServiceClient>(moq::MockBehavior.Strict);
            DeleteDataPolicyRequest request = new DeleteDataPolicyRequest
            {
                DataPolicyName = DataPolicyName.FromProjectLocationDataPolicy("[PROJECT]", "[LOCATION]", "[DATA_POLICY]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteDataPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataPolicyServiceClient client = new DataPolicyServiceClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteDataPolicy(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteDataPolicyRequestObjectAsync()
        {
            moq::Mock<DataPolicyService.DataPolicyServiceClient> mockGrpcClient = new moq::Mock<DataPolicyService.DataPolicyServiceClient>(moq::MockBehavior.Strict);
            DeleteDataPolicyRequest request = new DeleteDataPolicyRequest
            {
                DataPolicyName = DataPolicyName.FromProjectLocationDataPolicy("[PROJECT]", "[LOCATION]", "[DATA_POLICY]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteDataPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataPolicyServiceClient client = new DataPolicyServiceClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteDataPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteDataPolicyAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteDataPolicy()
        {
            moq::Mock<DataPolicyService.DataPolicyServiceClient> mockGrpcClient = new moq::Mock<DataPolicyService.DataPolicyServiceClient>(moq::MockBehavior.Strict);
            DeleteDataPolicyRequest request = new DeleteDataPolicyRequest
            {
                DataPolicyName = DataPolicyName.FromProjectLocationDataPolicy("[PROJECT]", "[LOCATION]", "[DATA_POLICY]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteDataPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataPolicyServiceClient client = new DataPolicyServiceClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteDataPolicy(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteDataPolicyAsync()
        {
            moq::Mock<DataPolicyService.DataPolicyServiceClient> mockGrpcClient = new moq::Mock<DataPolicyService.DataPolicyServiceClient>(moq::MockBehavior.Strict);
            DeleteDataPolicyRequest request = new DeleteDataPolicyRequest
            {
                DataPolicyName = DataPolicyName.FromProjectLocationDataPolicy("[PROJECT]", "[LOCATION]", "[DATA_POLICY]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteDataPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataPolicyServiceClient client = new DataPolicyServiceClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteDataPolicyAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteDataPolicyAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteDataPolicyResourceNames()
        {
            moq::Mock<DataPolicyService.DataPolicyServiceClient> mockGrpcClient = new moq::Mock<DataPolicyService.DataPolicyServiceClient>(moq::MockBehavior.Strict);
            DeleteDataPolicyRequest request = new DeleteDataPolicyRequest
            {
                DataPolicyName = DataPolicyName.FromProjectLocationDataPolicy("[PROJECT]", "[LOCATION]", "[DATA_POLICY]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteDataPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataPolicyServiceClient client = new DataPolicyServiceClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteDataPolicy(request.DataPolicyName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteDataPolicyResourceNamesAsync()
        {
            moq::Mock<DataPolicyService.DataPolicyServiceClient> mockGrpcClient = new moq::Mock<DataPolicyService.DataPolicyServiceClient>(moq::MockBehavior.Strict);
            DeleteDataPolicyRequest request = new DeleteDataPolicyRequest
            {
                DataPolicyName = DataPolicyName.FromProjectLocationDataPolicy("[PROJECT]", "[LOCATION]", "[DATA_POLICY]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteDataPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataPolicyServiceClient client = new DataPolicyServiceClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteDataPolicyAsync(request.DataPolicyName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteDataPolicyAsync(request.DataPolicyName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetDataPolicyRequestObject()
        {
            moq::Mock<DataPolicyService.DataPolicyServiceClient> mockGrpcClient = new moq::Mock<DataPolicyService.DataPolicyServiceClient>(moq::MockBehavior.Strict);
            GetDataPolicyRequest request = new GetDataPolicyRequest
            {
                DataPolicyName = DataPolicyName.FromProjectLocationDataPolicy("[PROJECT]", "[LOCATION]", "[DATA_POLICY]"),
            };
            DataPolicy expectedResponse = new DataPolicy
            {
                DataPolicyName = DataPolicyName.FromProjectLocationDataPolicy("[PROJECT]", "[LOCATION]", "[DATA_POLICY]"),
                DataPolicyType = DataPolicy.Types.DataPolicyType.Unspecified,
                DataPolicyId = "data_policy_id8b1a53bd",
                PolicyTag = "policy_tag2a38282c",
                DataMaskingPolicy = new DataMaskingPolicy(),
            };
            mockGrpcClient.Setup(x => x.GetDataPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataPolicyServiceClient client = new DataPolicyServiceClientImpl(mockGrpcClient.Object, null, null);
            DataPolicy response = client.GetDataPolicy(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetDataPolicyRequestObjectAsync()
        {
            moq::Mock<DataPolicyService.DataPolicyServiceClient> mockGrpcClient = new moq::Mock<DataPolicyService.DataPolicyServiceClient>(moq::MockBehavior.Strict);
            GetDataPolicyRequest request = new GetDataPolicyRequest
            {
                DataPolicyName = DataPolicyName.FromProjectLocationDataPolicy("[PROJECT]", "[LOCATION]", "[DATA_POLICY]"),
            };
            DataPolicy expectedResponse = new DataPolicy
            {
                DataPolicyName = DataPolicyName.FromProjectLocationDataPolicy("[PROJECT]", "[LOCATION]", "[DATA_POLICY]"),
                DataPolicyType = DataPolicy.Types.DataPolicyType.Unspecified,
                DataPolicyId = "data_policy_id8b1a53bd",
                PolicyTag = "policy_tag2a38282c",
                DataMaskingPolicy = new DataMaskingPolicy(),
            };
            mockGrpcClient.Setup(x => x.GetDataPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<DataPolicy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataPolicyServiceClient client = new DataPolicyServiceClientImpl(mockGrpcClient.Object, null, null);
            DataPolicy responseCallSettings = await client.GetDataPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            DataPolicy responseCancellationToken = await client.GetDataPolicyAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetDataPolicy()
        {
            moq::Mock<DataPolicyService.DataPolicyServiceClient> mockGrpcClient = new moq::Mock<DataPolicyService.DataPolicyServiceClient>(moq::MockBehavior.Strict);
            GetDataPolicyRequest request = new GetDataPolicyRequest
            {
                DataPolicyName = DataPolicyName.FromProjectLocationDataPolicy("[PROJECT]", "[LOCATION]", "[DATA_POLICY]"),
            };
            DataPolicy expectedResponse = new DataPolicy
            {
                DataPolicyName = DataPolicyName.FromProjectLocationDataPolicy("[PROJECT]", "[LOCATION]", "[DATA_POLICY]"),
                DataPolicyType = DataPolicy.Types.DataPolicyType.Unspecified,
                DataPolicyId = "data_policy_id8b1a53bd",
                PolicyTag = "policy_tag2a38282c",
                DataMaskingPolicy = new DataMaskingPolicy(),
            };
            mockGrpcClient.Setup(x => x.GetDataPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataPolicyServiceClient client = new DataPolicyServiceClientImpl(mockGrpcClient.Object, null, null);
            DataPolicy response = client.GetDataPolicy(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetDataPolicyAsync()
        {
            moq::Mock<DataPolicyService.DataPolicyServiceClient> mockGrpcClient = new moq::Mock<DataPolicyService.DataPolicyServiceClient>(moq::MockBehavior.Strict);
            GetDataPolicyRequest request = new GetDataPolicyRequest
            {
                DataPolicyName = DataPolicyName.FromProjectLocationDataPolicy("[PROJECT]", "[LOCATION]", "[DATA_POLICY]"),
            };
            DataPolicy expectedResponse = new DataPolicy
            {
                DataPolicyName = DataPolicyName.FromProjectLocationDataPolicy("[PROJECT]", "[LOCATION]", "[DATA_POLICY]"),
                DataPolicyType = DataPolicy.Types.DataPolicyType.Unspecified,
                DataPolicyId = "data_policy_id8b1a53bd",
                PolicyTag = "policy_tag2a38282c",
                DataMaskingPolicy = new DataMaskingPolicy(),
            };
            mockGrpcClient.Setup(x => x.GetDataPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<DataPolicy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataPolicyServiceClient client = new DataPolicyServiceClientImpl(mockGrpcClient.Object, null, null);
            DataPolicy responseCallSettings = await client.GetDataPolicyAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            DataPolicy responseCancellationToken = await client.GetDataPolicyAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetDataPolicyResourceNames()
        {
            moq::Mock<DataPolicyService.DataPolicyServiceClient> mockGrpcClient = new moq::Mock<DataPolicyService.DataPolicyServiceClient>(moq::MockBehavior.Strict);
            GetDataPolicyRequest request = new GetDataPolicyRequest
            {
                DataPolicyName = DataPolicyName.FromProjectLocationDataPolicy("[PROJECT]", "[LOCATION]", "[DATA_POLICY]"),
            };
            DataPolicy expectedResponse = new DataPolicy
            {
                DataPolicyName = DataPolicyName.FromProjectLocationDataPolicy("[PROJECT]", "[LOCATION]", "[DATA_POLICY]"),
                DataPolicyType = DataPolicy.Types.DataPolicyType.Unspecified,
                DataPolicyId = "data_policy_id8b1a53bd",
                PolicyTag = "policy_tag2a38282c",
                DataMaskingPolicy = new DataMaskingPolicy(),
            };
            mockGrpcClient.Setup(x => x.GetDataPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataPolicyServiceClient client = new DataPolicyServiceClientImpl(mockGrpcClient.Object, null, null);
            DataPolicy response = client.GetDataPolicy(request.DataPolicyName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetDataPolicyResourceNamesAsync()
        {
            moq::Mock<DataPolicyService.DataPolicyServiceClient> mockGrpcClient = new moq::Mock<DataPolicyService.DataPolicyServiceClient>(moq::MockBehavior.Strict);
            GetDataPolicyRequest request = new GetDataPolicyRequest
            {
                DataPolicyName = DataPolicyName.FromProjectLocationDataPolicy("[PROJECT]", "[LOCATION]", "[DATA_POLICY]"),
            };
            DataPolicy expectedResponse = new DataPolicy
            {
                DataPolicyName = DataPolicyName.FromProjectLocationDataPolicy("[PROJECT]", "[LOCATION]", "[DATA_POLICY]"),
                DataPolicyType = DataPolicy.Types.DataPolicyType.Unspecified,
                DataPolicyId = "data_policy_id8b1a53bd",
                PolicyTag = "policy_tag2a38282c",
                DataMaskingPolicy = new DataMaskingPolicy(),
            };
            mockGrpcClient.Setup(x => x.GetDataPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<DataPolicy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataPolicyServiceClient client = new DataPolicyServiceClientImpl(mockGrpcClient.Object, null, null);
            DataPolicy responseCallSettings = await client.GetDataPolicyAsync(request.DataPolicyName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            DataPolicy responseCancellationToken = await client.GetDataPolicyAsync(request.DataPolicyName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetIamPolicyRequestObject()
        {
            moq::Mock<DataPolicyService.DataPolicyServiceClient> mockGrpcClient = new moq::Mock<DataPolicyService.DataPolicyServiceClient>(moq::MockBehavior.Strict);
            gciv::GetIamPolicyRequest request = new gciv::GetIamPolicyRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Options = new gciv::GetPolicyOptions(),
            };
            gciv::Policy expectedResponse = new gciv::Policy
            {
                Version = 271578922,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Bindings =
                {
                    new gciv::Binding(),
                },
                AuditConfigs =
                {
                    new gciv::AuditConfig(),
                },
            };
            mockGrpcClient.Setup(x => x.GetIamPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataPolicyServiceClient client = new DataPolicyServiceClientImpl(mockGrpcClient.Object, null, null);
            gciv::Policy response = client.GetIamPolicy(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetIamPolicyRequestObjectAsync()
        {
            moq::Mock<DataPolicyService.DataPolicyServiceClient> mockGrpcClient = new moq::Mock<DataPolicyService.DataPolicyServiceClient>(moq::MockBehavior.Strict);
            gciv::GetIamPolicyRequest request = new gciv::GetIamPolicyRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Options = new gciv::GetPolicyOptions(),
            };
            gciv::Policy expectedResponse = new gciv::Policy
            {
                Version = 271578922,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Bindings =
                {
                    new gciv::Binding(),
                },
                AuditConfigs =
                {
                    new gciv::AuditConfig(),
                },
            };
            mockGrpcClient.Setup(x => x.GetIamPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gciv::Policy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataPolicyServiceClient client = new DataPolicyServiceClientImpl(mockGrpcClient.Object, null, null);
            gciv::Policy responseCallSettings = await client.GetIamPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gciv::Policy responseCancellationToken = await client.GetIamPolicyAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SetIamPolicyRequestObject()
        {
            moq::Mock<DataPolicyService.DataPolicyServiceClient> mockGrpcClient = new moq::Mock<DataPolicyService.DataPolicyServiceClient>(moq::MockBehavior.Strict);
            gciv::SetIamPolicyRequest request = new gciv::SetIamPolicyRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Policy = new gciv::Policy(),
                UpdateMask = new wkt::FieldMask(),
            };
            gciv::Policy expectedResponse = new gciv::Policy
            {
                Version = 271578922,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Bindings =
                {
                    new gciv::Binding(),
                },
                AuditConfigs =
                {
                    new gciv::AuditConfig(),
                },
            };
            mockGrpcClient.Setup(x => x.SetIamPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataPolicyServiceClient client = new DataPolicyServiceClientImpl(mockGrpcClient.Object, null, null);
            gciv::Policy response = client.SetIamPolicy(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SetIamPolicyRequestObjectAsync()
        {
            moq::Mock<DataPolicyService.DataPolicyServiceClient> mockGrpcClient = new moq::Mock<DataPolicyService.DataPolicyServiceClient>(moq::MockBehavior.Strict);
            gciv::SetIamPolicyRequest request = new gciv::SetIamPolicyRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Policy = new gciv::Policy(),
                UpdateMask = new wkt::FieldMask(),
            };
            gciv::Policy expectedResponse = new gciv::Policy
            {
                Version = 271578922,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Bindings =
                {
                    new gciv::Binding(),
                },
                AuditConfigs =
                {
                    new gciv::AuditConfig(),
                },
            };
            mockGrpcClient.Setup(x => x.SetIamPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gciv::Policy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataPolicyServiceClient client = new DataPolicyServiceClientImpl(mockGrpcClient.Object, null, null);
            gciv::Policy responseCallSettings = await client.SetIamPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gciv::Policy responseCancellationToken = await client.SetIamPolicyAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void TestIamPermissionsRequestObject()
        {
            moq::Mock<DataPolicyService.DataPolicyServiceClient> mockGrpcClient = new moq::Mock<DataPolicyService.DataPolicyServiceClient>(moq::MockBehavior.Strict);
            gciv::TestIamPermissionsRequest request = new gciv::TestIamPermissionsRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Permissions =
                {
                    "permissions535a2741",
                },
            };
            gciv::TestIamPermissionsResponse expectedResponse = new gciv::TestIamPermissionsResponse
            {
                Permissions =
                {
                    "permissions535a2741",
                },
            };
            mockGrpcClient.Setup(x => x.TestIamPermissions(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DataPolicyServiceClient client = new DataPolicyServiceClientImpl(mockGrpcClient.Object, null, null);
            gciv::TestIamPermissionsResponse response = client.TestIamPermissions(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task TestIamPermissionsRequestObjectAsync()
        {
            moq::Mock<DataPolicyService.DataPolicyServiceClient> mockGrpcClient = new moq::Mock<DataPolicyService.DataPolicyServiceClient>(moq::MockBehavior.Strict);
            gciv::TestIamPermissionsRequest request = new gciv::TestIamPermissionsRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Permissions =
                {
                    "permissions535a2741",
                },
            };
            gciv::TestIamPermissionsResponse expectedResponse = new gciv::TestIamPermissionsResponse
            {
                Permissions =
                {
                    "permissions535a2741",
                },
            };
            mockGrpcClient.Setup(x => x.TestIamPermissionsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gciv::TestIamPermissionsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DataPolicyServiceClient client = new DataPolicyServiceClientImpl(mockGrpcClient.Object, null, null);
            gciv::TestIamPermissionsResponse responseCallSettings = await client.TestIamPermissionsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gciv::TestIamPermissionsResponse responseCancellationToken = await client.TestIamPermissionsAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
