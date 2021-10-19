// Copyright 2021 Google LLC
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

using gaxgrpc = Google.Api.Gax.Grpc;
using gagr = Google.Api.Gax.ResourceNames;
using lro = Google.LongRunning;
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.Domains.V1Beta1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedDomainsClientTest
    {
        [xunit::FactAttribute]
        public void SearchDomainsRequestObject()
        {
            moq::Mock<Domains.DomainsClient> mockGrpcClient = new moq::Mock<Domains.DomainsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            SearchDomainsRequest request = new SearchDomainsRequest
            {
                Query = "queryf0c71c1b",
                LocationAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            SearchDomainsResponse expectedResponse = new SearchDomainsResponse
            {
                RegisterParameters =
                {
                    new RegisterParameters(),
                },
            };
            mockGrpcClient.Setup(x => x.SearchDomains(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DomainsClient client = new DomainsClientImpl(mockGrpcClient.Object, null);
            SearchDomainsResponse response = client.SearchDomains(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SearchDomainsRequestObjectAsync()
        {
            moq::Mock<Domains.DomainsClient> mockGrpcClient = new moq::Mock<Domains.DomainsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            SearchDomainsRequest request = new SearchDomainsRequest
            {
                Query = "queryf0c71c1b",
                LocationAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            SearchDomainsResponse expectedResponse = new SearchDomainsResponse
            {
                RegisterParameters =
                {
                    new RegisterParameters(),
                },
            };
            mockGrpcClient.Setup(x => x.SearchDomainsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<SearchDomainsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DomainsClient client = new DomainsClientImpl(mockGrpcClient.Object, null);
            SearchDomainsResponse responseCallSettings = await client.SearchDomainsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            SearchDomainsResponse responseCancellationToken = await client.SearchDomainsAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SearchDomains()
        {
            moq::Mock<Domains.DomainsClient> mockGrpcClient = new moq::Mock<Domains.DomainsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            SearchDomainsRequest request = new SearchDomainsRequest
            {
                Query = "queryf0c71c1b",
                LocationAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            SearchDomainsResponse expectedResponse = new SearchDomainsResponse
            {
                RegisterParameters =
                {
                    new RegisterParameters(),
                },
            };
            mockGrpcClient.Setup(x => x.SearchDomains(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DomainsClient client = new DomainsClientImpl(mockGrpcClient.Object, null);
            SearchDomainsResponse response = client.SearchDomains(request.Location, request.Query);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SearchDomainsAsync()
        {
            moq::Mock<Domains.DomainsClient> mockGrpcClient = new moq::Mock<Domains.DomainsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            SearchDomainsRequest request = new SearchDomainsRequest
            {
                Query = "queryf0c71c1b",
                LocationAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            SearchDomainsResponse expectedResponse = new SearchDomainsResponse
            {
                RegisterParameters =
                {
                    new RegisterParameters(),
                },
            };
            mockGrpcClient.Setup(x => x.SearchDomainsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<SearchDomainsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DomainsClient client = new DomainsClientImpl(mockGrpcClient.Object, null);
            SearchDomainsResponse responseCallSettings = await client.SearchDomainsAsync(request.Location, request.Query, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            SearchDomainsResponse responseCancellationToken = await client.SearchDomainsAsync(request.Location, request.Query, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SearchDomainsResourceNames()
        {
            moq::Mock<Domains.DomainsClient> mockGrpcClient = new moq::Mock<Domains.DomainsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            SearchDomainsRequest request = new SearchDomainsRequest
            {
                Query = "queryf0c71c1b",
                LocationAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            SearchDomainsResponse expectedResponse = new SearchDomainsResponse
            {
                RegisterParameters =
                {
                    new RegisterParameters(),
                },
            };
            mockGrpcClient.Setup(x => x.SearchDomains(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DomainsClient client = new DomainsClientImpl(mockGrpcClient.Object, null);
            SearchDomainsResponse response = client.SearchDomains(request.LocationAsLocationName, request.Query);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SearchDomainsResourceNamesAsync()
        {
            moq::Mock<Domains.DomainsClient> mockGrpcClient = new moq::Mock<Domains.DomainsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            SearchDomainsRequest request = new SearchDomainsRequest
            {
                Query = "queryf0c71c1b",
                LocationAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            SearchDomainsResponse expectedResponse = new SearchDomainsResponse
            {
                RegisterParameters =
                {
                    new RegisterParameters(),
                },
            };
            mockGrpcClient.Setup(x => x.SearchDomainsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<SearchDomainsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DomainsClient client = new DomainsClientImpl(mockGrpcClient.Object, null);
            SearchDomainsResponse responseCallSettings = await client.SearchDomainsAsync(request.LocationAsLocationName, request.Query, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            SearchDomainsResponse responseCancellationToken = await client.SearchDomainsAsync(request.LocationAsLocationName, request.Query, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void RetrieveRegisterParametersRequestObject()
        {
            moq::Mock<Domains.DomainsClient> mockGrpcClient = new moq::Mock<Domains.DomainsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            RetrieveRegisterParametersRequest request = new RetrieveRegisterParametersRequest
            {
                DomainName = "domain_nameea17a44f",
                LocationAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            RetrieveRegisterParametersResponse expectedResponse = new RetrieveRegisterParametersResponse
            {
                RegisterParameters = new RegisterParameters(),
            };
            mockGrpcClient.Setup(x => x.RetrieveRegisterParameters(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DomainsClient client = new DomainsClientImpl(mockGrpcClient.Object, null);
            RetrieveRegisterParametersResponse response = client.RetrieveRegisterParameters(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task RetrieveRegisterParametersRequestObjectAsync()
        {
            moq::Mock<Domains.DomainsClient> mockGrpcClient = new moq::Mock<Domains.DomainsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            RetrieveRegisterParametersRequest request = new RetrieveRegisterParametersRequest
            {
                DomainName = "domain_nameea17a44f",
                LocationAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            RetrieveRegisterParametersResponse expectedResponse = new RetrieveRegisterParametersResponse
            {
                RegisterParameters = new RegisterParameters(),
            };
            mockGrpcClient.Setup(x => x.RetrieveRegisterParametersAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<RetrieveRegisterParametersResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DomainsClient client = new DomainsClientImpl(mockGrpcClient.Object, null);
            RetrieveRegisterParametersResponse responseCallSettings = await client.RetrieveRegisterParametersAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            RetrieveRegisterParametersResponse responseCancellationToken = await client.RetrieveRegisterParametersAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void RetrieveRegisterParameters()
        {
            moq::Mock<Domains.DomainsClient> mockGrpcClient = new moq::Mock<Domains.DomainsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            RetrieveRegisterParametersRequest request = new RetrieveRegisterParametersRequest
            {
                DomainName = "domain_nameea17a44f",
                LocationAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            RetrieveRegisterParametersResponse expectedResponse = new RetrieveRegisterParametersResponse
            {
                RegisterParameters = new RegisterParameters(),
            };
            mockGrpcClient.Setup(x => x.RetrieveRegisterParameters(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DomainsClient client = new DomainsClientImpl(mockGrpcClient.Object, null);
            RetrieveRegisterParametersResponse response = client.RetrieveRegisterParameters(request.Location, request.DomainName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task RetrieveRegisterParametersAsync()
        {
            moq::Mock<Domains.DomainsClient> mockGrpcClient = new moq::Mock<Domains.DomainsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            RetrieveRegisterParametersRequest request = new RetrieveRegisterParametersRequest
            {
                DomainName = "domain_nameea17a44f",
                LocationAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            RetrieveRegisterParametersResponse expectedResponse = new RetrieveRegisterParametersResponse
            {
                RegisterParameters = new RegisterParameters(),
            };
            mockGrpcClient.Setup(x => x.RetrieveRegisterParametersAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<RetrieveRegisterParametersResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DomainsClient client = new DomainsClientImpl(mockGrpcClient.Object, null);
            RetrieveRegisterParametersResponse responseCallSettings = await client.RetrieveRegisterParametersAsync(request.Location, request.DomainName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            RetrieveRegisterParametersResponse responseCancellationToken = await client.RetrieveRegisterParametersAsync(request.Location, request.DomainName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void RetrieveRegisterParametersResourceNames()
        {
            moq::Mock<Domains.DomainsClient> mockGrpcClient = new moq::Mock<Domains.DomainsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            RetrieveRegisterParametersRequest request = new RetrieveRegisterParametersRequest
            {
                DomainName = "domain_nameea17a44f",
                LocationAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            RetrieveRegisterParametersResponse expectedResponse = new RetrieveRegisterParametersResponse
            {
                RegisterParameters = new RegisterParameters(),
            };
            mockGrpcClient.Setup(x => x.RetrieveRegisterParameters(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DomainsClient client = new DomainsClientImpl(mockGrpcClient.Object, null);
            RetrieveRegisterParametersResponse response = client.RetrieveRegisterParameters(request.LocationAsLocationName, request.DomainName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task RetrieveRegisterParametersResourceNamesAsync()
        {
            moq::Mock<Domains.DomainsClient> mockGrpcClient = new moq::Mock<Domains.DomainsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            RetrieveRegisterParametersRequest request = new RetrieveRegisterParametersRequest
            {
                DomainName = "domain_nameea17a44f",
                LocationAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            RetrieveRegisterParametersResponse expectedResponse = new RetrieveRegisterParametersResponse
            {
                RegisterParameters = new RegisterParameters(),
            };
            mockGrpcClient.Setup(x => x.RetrieveRegisterParametersAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<RetrieveRegisterParametersResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DomainsClient client = new DomainsClientImpl(mockGrpcClient.Object, null);
            RetrieveRegisterParametersResponse responseCallSettings = await client.RetrieveRegisterParametersAsync(request.LocationAsLocationName, request.DomainName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            RetrieveRegisterParametersResponse responseCancellationToken = await client.RetrieveRegisterParametersAsync(request.LocationAsLocationName, request.DomainName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void RetrieveTransferParametersRequestObject()
        {
            moq::Mock<Domains.DomainsClient> mockGrpcClient = new moq::Mock<Domains.DomainsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            RetrieveTransferParametersRequest request = new RetrieveTransferParametersRequest
            {
                DomainName = "domain_nameea17a44f",
                LocationAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            RetrieveTransferParametersResponse expectedResponse = new RetrieveTransferParametersResponse
            {
                TransferParameters = new TransferParameters(),
            };
            mockGrpcClient.Setup(x => x.RetrieveTransferParameters(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DomainsClient client = new DomainsClientImpl(mockGrpcClient.Object, null);
            RetrieveTransferParametersResponse response = client.RetrieveTransferParameters(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task RetrieveTransferParametersRequestObjectAsync()
        {
            moq::Mock<Domains.DomainsClient> mockGrpcClient = new moq::Mock<Domains.DomainsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            RetrieveTransferParametersRequest request = new RetrieveTransferParametersRequest
            {
                DomainName = "domain_nameea17a44f",
                LocationAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            RetrieveTransferParametersResponse expectedResponse = new RetrieveTransferParametersResponse
            {
                TransferParameters = new TransferParameters(),
            };
            mockGrpcClient.Setup(x => x.RetrieveTransferParametersAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<RetrieveTransferParametersResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DomainsClient client = new DomainsClientImpl(mockGrpcClient.Object, null);
            RetrieveTransferParametersResponse responseCallSettings = await client.RetrieveTransferParametersAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            RetrieveTransferParametersResponse responseCancellationToken = await client.RetrieveTransferParametersAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void RetrieveTransferParameters()
        {
            moq::Mock<Domains.DomainsClient> mockGrpcClient = new moq::Mock<Domains.DomainsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            RetrieveTransferParametersRequest request = new RetrieveTransferParametersRequest
            {
                DomainName = "domain_nameea17a44f",
                LocationAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            RetrieveTransferParametersResponse expectedResponse = new RetrieveTransferParametersResponse
            {
                TransferParameters = new TransferParameters(),
            };
            mockGrpcClient.Setup(x => x.RetrieveTransferParameters(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DomainsClient client = new DomainsClientImpl(mockGrpcClient.Object, null);
            RetrieveTransferParametersResponse response = client.RetrieveTransferParameters(request.Location, request.DomainName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task RetrieveTransferParametersAsync()
        {
            moq::Mock<Domains.DomainsClient> mockGrpcClient = new moq::Mock<Domains.DomainsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            RetrieveTransferParametersRequest request = new RetrieveTransferParametersRequest
            {
                DomainName = "domain_nameea17a44f",
                LocationAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            RetrieveTransferParametersResponse expectedResponse = new RetrieveTransferParametersResponse
            {
                TransferParameters = new TransferParameters(),
            };
            mockGrpcClient.Setup(x => x.RetrieveTransferParametersAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<RetrieveTransferParametersResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DomainsClient client = new DomainsClientImpl(mockGrpcClient.Object, null);
            RetrieveTransferParametersResponse responseCallSettings = await client.RetrieveTransferParametersAsync(request.Location, request.DomainName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            RetrieveTransferParametersResponse responseCancellationToken = await client.RetrieveTransferParametersAsync(request.Location, request.DomainName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void RetrieveTransferParametersResourceNames()
        {
            moq::Mock<Domains.DomainsClient> mockGrpcClient = new moq::Mock<Domains.DomainsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            RetrieveTransferParametersRequest request = new RetrieveTransferParametersRequest
            {
                DomainName = "domain_nameea17a44f",
                LocationAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            RetrieveTransferParametersResponse expectedResponse = new RetrieveTransferParametersResponse
            {
                TransferParameters = new TransferParameters(),
            };
            mockGrpcClient.Setup(x => x.RetrieveTransferParameters(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DomainsClient client = new DomainsClientImpl(mockGrpcClient.Object, null);
            RetrieveTransferParametersResponse response = client.RetrieveTransferParameters(request.LocationAsLocationName, request.DomainName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task RetrieveTransferParametersResourceNamesAsync()
        {
            moq::Mock<Domains.DomainsClient> mockGrpcClient = new moq::Mock<Domains.DomainsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            RetrieveTransferParametersRequest request = new RetrieveTransferParametersRequest
            {
                DomainName = "domain_nameea17a44f",
                LocationAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            RetrieveTransferParametersResponse expectedResponse = new RetrieveTransferParametersResponse
            {
                TransferParameters = new TransferParameters(),
            };
            mockGrpcClient.Setup(x => x.RetrieveTransferParametersAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<RetrieveTransferParametersResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DomainsClient client = new DomainsClientImpl(mockGrpcClient.Object, null);
            RetrieveTransferParametersResponse responseCallSettings = await client.RetrieveTransferParametersAsync(request.LocationAsLocationName, request.DomainName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            RetrieveTransferParametersResponse responseCancellationToken = await client.RetrieveTransferParametersAsync(request.LocationAsLocationName, request.DomainName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetRegistrationRequestObject()
        {
            moq::Mock<Domains.DomainsClient> mockGrpcClient = new moq::Mock<Domains.DomainsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetRegistrationRequest request = new GetRegistrationRequest
            {
                RegistrationName = RegistrationName.FromProjectLocationRegistration("[PROJECT]", "[LOCATION]", "[REGISTRATION]"),
            };
            Registration expectedResponse = new Registration
            {
                RegistrationName = RegistrationName.FromProjectLocationRegistration("[PROJECT]", "[LOCATION]", "[REGISTRATION]"),
                DomainName = "domain_nameea17a44f",
                CreateTime = new wkt::Timestamp(),
                ExpireTime = new wkt::Timestamp(),
                State = Registration.Types.State.Suspended,
                Issues =
                {
                    Registration.Types.Issue.UnverifiedEmail,
                },
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                ManagementSettings = new ManagementSettings(),
                DnsSettings = new DnsSettings(),
                ContactSettings = new ContactSettings(),
                PendingContactSettings = new ContactSettings(),
                SupportedPrivacy =
                {
                    ContactPrivacy.PublicContactData,
                },
            };
            mockGrpcClient.Setup(x => x.GetRegistration(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DomainsClient client = new DomainsClientImpl(mockGrpcClient.Object, null);
            Registration response = client.GetRegistration(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetRegistrationRequestObjectAsync()
        {
            moq::Mock<Domains.DomainsClient> mockGrpcClient = new moq::Mock<Domains.DomainsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetRegistrationRequest request = new GetRegistrationRequest
            {
                RegistrationName = RegistrationName.FromProjectLocationRegistration("[PROJECT]", "[LOCATION]", "[REGISTRATION]"),
            };
            Registration expectedResponse = new Registration
            {
                RegistrationName = RegistrationName.FromProjectLocationRegistration("[PROJECT]", "[LOCATION]", "[REGISTRATION]"),
                DomainName = "domain_nameea17a44f",
                CreateTime = new wkt::Timestamp(),
                ExpireTime = new wkt::Timestamp(),
                State = Registration.Types.State.Suspended,
                Issues =
                {
                    Registration.Types.Issue.UnverifiedEmail,
                },
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                ManagementSettings = new ManagementSettings(),
                DnsSettings = new DnsSettings(),
                ContactSettings = new ContactSettings(),
                PendingContactSettings = new ContactSettings(),
                SupportedPrivacy =
                {
                    ContactPrivacy.PublicContactData,
                },
            };
            mockGrpcClient.Setup(x => x.GetRegistrationAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Registration>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DomainsClient client = new DomainsClientImpl(mockGrpcClient.Object, null);
            Registration responseCallSettings = await client.GetRegistrationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Registration responseCancellationToken = await client.GetRegistrationAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetRegistration()
        {
            moq::Mock<Domains.DomainsClient> mockGrpcClient = new moq::Mock<Domains.DomainsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetRegistrationRequest request = new GetRegistrationRequest
            {
                RegistrationName = RegistrationName.FromProjectLocationRegistration("[PROJECT]", "[LOCATION]", "[REGISTRATION]"),
            };
            Registration expectedResponse = new Registration
            {
                RegistrationName = RegistrationName.FromProjectLocationRegistration("[PROJECT]", "[LOCATION]", "[REGISTRATION]"),
                DomainName = "domain_nameea17a44f",
                CreateTime = new wkt::Timestamp(),
                ExpireTime = new wkt::Timestamp(),
                State = Registration.Types.State.Suspended,
                Issues =
                {
                    Registration.Types.Issue.UnverifiedEmail,
                },
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                ManagementSettings = new ManagementSettings(),
                DnsSettings = new DnsSettings(),
                ContactSettings = new ContactSettings(),
                PendingContactSettings = new ContactSettings(),
                SupportedPrivacy =
                {
                    ContactPrivacy.PublicContactData,
                },
            };
            mockGrpcClient.Setup(x => x.GetRegistration(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DomainsClient client = new DomainsClientImpl(mockGrpcClient.Object, null);
            Registration response = client.GetRegistration(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetRegistrationAsync()
        {
            moq::Mock<Domains.DomainsClient> mockGrpcClient = new moq::Mock<Domains.DomainsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetRegistrationRequest request = new GetRegistrationRequest
            {
                RegistrationName = RegistrationName.FromProjectLocationRegistration("[PROJECT]", "[LOCATION]", "[REGISTRATION]"),
            };
            Registration expectedResponse = new Registration
            {
                RegistrationName = RegistrationName.FromProjectLocationRegistration("[PROJECT]", "[LOCATION]", "[REGISTRATION]"),
                DomainName = "domain_nameea17a44f",
                CreateTime = new wkt::Timestamp(),
                ExpireTime = new wkt::Timestamp(),
                State = Registration.Types.State.Suspended,
                Issues =
                {
                    Registration.Types.Issue.UnverifiedEmail,
                },
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                ManagementSettings = new ManagementSettings(),
                DnsSettings = new DnsSettings(),
                ContactSettings = new ContactSettings(),
                PendingContactSettings = new ContactSettings(),
                SupportedPrivacy =
                {
                    ContactPrivacy.PublicContactData,
                },
            };
            mockGrpcClient.Setup(x => x.GetRegistrationAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Registration>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DomainsClient client = new DomainsClientImpl(mockGrpcClient.Object, null);
            Registration responseCallSettings = await client.GetRegistrationAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Registration responseCancellationToken = await client.GetRegistrationAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetRegistrationResourceNames()
        {
            moq::Mock<Domains.DomainsClient> mockGrpcClient = new moq::Mock<Domains.DomainsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetRegistrationRequest request = new GetRegistrationRequest
            {
                RegistrationName = RegistrationName.FromProjectLocationRegistration("[PROJECT]", "[LOCATION]", "[REGISTRATION]"),
            };
            Registration expectedResponse = new Registration
            {
                RegistrationName = RegistrationName.FromProjectLocationRegistration("[PROJECT]", "[LOCATION]", "[REGISTRATION]"),
                DomainName = "domain_nameea17a44f",
                CreateTime = new wkt::Timestamp(),
                ExpireTime = new wkt::Timestamp(),
                State = Registration.Types.State.Suspended,
                Issues =
                {
                    Registration.Types.Issue.UnverifiedEmail,
                },
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                ManagementSettings = new ManagementSettings(),
                DnsSettings = new DnsSettings(),
                ContactSettings = new ContactSettings(),
                PendingContactSettings = new ContactSettings(),
                SupportedPrivacy =
                {
                    ContactPrivacy.PublicContactData,
                },
            };
            mockGrpcClient.Setup(x => x.GetRegistration(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DomainsClient client = new DomainsClientImpl(mockGrpcClient.Object, null);
            Registration response = client.GetRegistration(request.RegistrationName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetRegistrationResourceNamesAsync()
        {
            moq::Mock<Domains.DomainsClient> mockGrpcClient = new moq::Mock<Domains.DomainsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetRegistrationRequest request = new GetRegistrationRequest
            {
                RegistrationName = RegistrationName.FromProjectLocationRegistration("[PROJECT]", "[LOCATION]", "[REGISTRATION]"),
            };
            Registration expectedResponse = new Registration
            {
                RegistrationName = RegistrationName.FromProjectLocationRegistration("[PROJECT]", "[LOCATION]", "[REGISTRATION]"),
                DomainName = "domain_nameea17a44f",
                CreateTime = new wkt::Timestamp(),
                ExpireTime = new wkt::Timestamp(),
                State = Registration.Types.State.Suspended,
                Issues =
                {
                    Registration.Types.Issue.UnverifiedEmail,
                },
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                ManagementSettings = new ManagementSettings(),
                DnsSettings = new DnsSettings(),
                ContactSettings = new ContactSettings(),
                PendingContactSettings = new ContactSettings(),
                SupportedPrivacy =
                {
                    ContactPrivacy.PublicContactData,
                },
            };
            mockGrpcClient.Setup(x => x.GetRegistrationAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Registration>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DomainsClient client = new DomainsClientImpl(mockGrpcClient.Object, null);
            Registration responseCallSettings = await client.GetRegistrationAsync(request.RegistrationName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Registration responseCancellationToken = await client.GetRegistrationAsync(request.RegistrationName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void RetrieveAuthorizationCodeRequestObject()
        {
            moq::Mock<Domains.DomainsClient> mockGrpcClient = new moq::Mock<Domains.DomainsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            RetrieveAuthorizationCodeRequest request = new RetrieveAuthorizationCodeRequest
            {
                RegistrationAsRegistrationName = RegistrationName.FromProjectLocationRegistration("[PROJECT]", "[LOCATION]", "[REGISTRATION]"),
            };
            AuthorizationCode expectedResponse = new AuthorizationCode
            {
                Code = "code946733c1",
            };
            mockGrpcClient.Setup(x => x.RetrieveAuthorizationCode(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DomainsClient client = new DomainsClientImpl(mockGrpcClient.Object, null);
            AuthorizationCode response = client.RetrieveAuthorizationCode(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task RetrieveAuthorizationCodeRequestObjectAsync()
        {
            moq::Mock<Domains.DomainsClient> mockGrpcClient = new moq::Mock<Domains.DomainsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            RetrieveAuthorizationCodeRequest request = new RetrieveAuthorizationCodeRequest
            {
                RegistrationAsRegistrationName = RegistrationName.FromProjectLocationRegistration("[PROJECT]", "[LOCATION]", "[REGISTRATION]"),
            };
            AuthorizationCode expectedResponse = new AuthorizationCode
            {
                Code = "code946733c1",
            };
            mockGrpcClient.Setup(x => x.RetrieveAuthorizationCodeAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AuthorizationCode>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DomainsClient client = new DomainsClientImpl(mockGrpcClient.Object, null);
            AuthorizationCode responseCallSettings = await client.RetrieveAuthorizationCodeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AuthorizationCode responseCancellationToken = await client.RetrieveAuthorizationCodeAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void RetrieveAuthorizationCode()
        {
            moq::Mock<Domains.DomainsClient> mockGrpcClient = new moq::Mock<Domains.DomainsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            RetrieveAuthorizationCodeRequest request = new RetrieveAuthorizationCodeRequest
            {
                RegistrationAsRegistrationName = RegistrationName.FromProjectLocationRegistration("[PROJECT]", "[LOCATION]", "[REGISTRATION]"),
            };
            AuthorizationCode expectedResponse = new AuthorizationCode
            {
                Code = "code946733c1",
            };
            mockGrpcClient.Setup(x => x.RetrieveAuthorizationCode(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DomainsClient client = new DomainsClientImpl(mockGrpcClient.Object, null);
            AuthorizationCode response = client.RetrieveAuthorizationCode(request.Registration);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task RetrieveAuthorizationCodeAsync()
        {
            moq::Mock<Domains.DomainsClient> mockGrpcClient = new moq::Mock<Domains.DomainsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            RetrieveAuthorizationCodeRequest request = new RetrieveAuthorizationCodeRequest
            {
                RegistrationAsRegistrationName = RegistrationName.FromProjectLocationRegistration("[PROJECT]", "[LOCATION]", "[REGISTRATION]"),
            };
            AuthorizationCode expectedResponse = new AuthorizationCode
            {
                Code = "code946733c1",
            };
            mockGrpcClient.Setup(x => x.RetrieveAuthorizationCodeAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AuthorizationCode>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DomainsClient client = new DomainsClientImpl(mockGrpcClient.Object, null);
            AuthorizationCode responseCallSettings = await client.RetrieveAuthorizationCodeAsync(request.Registration, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AuthorizationCode responseCancellationToken = await client.RetrieveAuthorizationCodeAsync(request.Registration, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void RetrieveAuthorizationCodeResourceNames()
        {
            moq::Mock<Domains.DomainsClient> mockGrpcClient = new moq::Mock<Domains.DomainsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            RetrieveAuthorizationCodeRequest request = new RetrieveAuthorizationCodeRequest
            {
                RegistrationAsRegistrationName = RegistrationName.FromProjectLocationRegistration("[PROJECT]", "[LOCATION]", "[REGISTRATION]"),
            };
            AuthorizationCode expectedResponse = new AuthorizationCode
            {
                Code = "code946733c1",
            };
            mockGrpcClient.Setup(x => x.RetrieveAuthorizationCode(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DomainsClient client = new DomainsClientImpl(mockGrpcClient.Object, null);
            AuthorizationCode response = client.RetrieveAuthorizationCode(request.RegistrationAsRegistrationName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task RetrieveAuthorizationCodeResourceNamesAsync()
        {
            moq::Mock<Domains.DomainsClient> mockGrpcClient = new moq::Mock<Domains.DomainsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            RetrieveAuthorizationCodeRequest request = new RetrieveAuthorizationCodeRequest
            {
                RegistrationAsRegistrationName = RegistrationName.FromProjectLocationRegistration("[PROJECT]", "[LOCATION]", "[REGISTRATION]"),
            };
            AuthorizationCode expectedResponse = new AuthorizationCode
            {
                Code = "code946733c1",
            };
            mockGrpcClient.Setup(x => x.RetrieveAuthorizationCodeAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AuthorizationCode>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DomainsClient client = new DomainsClientImpl(mockGrpcClient.Object, null);
            AuthorizationCode responseCallSettings = await client.RetrieveAuthorizationCodeAsync(request.RegistrationAsRegistrationName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AuthorizationCode responseCancellationToken = await client.RetrieveAuthorizationCodeAsync(request.RegistrationAsRegistrationName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ResetAuthorizationCodeRequestObject()
        {
            moq::Mock<Domains.DomainsClient> mockGrpcClient = new moq::Mock<Domains.DomainsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            ResetAuthorizationCodeRequest request = new ResetAuthorizationCodeRequest
            {
                RegistrationAsRegistrationName = RegistrationName.FromProjectLocationRegistration("[PROJECT]", "[LOCATION]", "[REGISTRATION]"),
            };
            AuthorizationCode expectedResponse = new AuthorizationCode
            {
                Code = "code946733c1",
            };
            mockGrpcClient.Setup(x => x.ResetAuthorizationCode(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DomainsClient client = new DomainsClientImpl(mockGrpcClient.Object, null);
            AuthorizationCode response = client.ResetAuthorizationCode(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ResetAuthorizationCodeRequestObjectAsync()
        {
            moq::Mock<Domains.DomainsClient> mockGrpcClient = new moq::Mock<Domains.DomainsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            ResetAuthorizationCodeRequest request = new ResetAuthorizationCodeRequest
            {
                RegistrationAsRegistrationName = RegistrationName.FromProjectLocationRegistration("[PROJECT]", "[LOCATION]", "[REGISTRATION]"),
            };
            AuthorizationCode expectedResponse = new AuthorizationCode
            {
                Code = "code946733c1",
            };
            mockGrpcClient.Setup(x => x.ResetAuthorizationCodeAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AuthorizationCode>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DomainsClient client = new DomainsClientImpl(mockGrpcClient.Object, null);
            AuthorizationCode responseCallSettings = await client.ResetAuthorizationCodeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AuthorizationCode responseCancellationToken = await client.ResetAuthorizationCodeAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ResetAuthorizationCode()
        {
            moq::Mock<Domains.DomainsClient> mockGrpcClient = new moq::Mock<Domains.DomainsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            ResetAuthorizationCodeRequest request = new ResetAuthorizationCodeRequest
            {
                RegistrationAsRegistrationName = RegistrationName.FromProjectLocationRegistration("[PROJECT]", "[LOCATION]", "[REGISTRATION]"),
            };
            AuthorizationCode expectedResponse = new AuthorizationCode
            {
                Code = "code946733c1",
            };
            mockGrpcClient.Setup(x => x.ResetAuthorizationCode(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DomainsClient client = new DomainsClientImpl(mockGrpcClient.Object, null);
            AuthorizationCode response = client.ResetAuthorizationCode(request.Registration);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ResetAuthorizationCodeAsync()
        {
            moq::Mock<Domains.DomainsClient> mockGrpcClient = new moq::Mock<Domains.DomainsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            ResetAuthorizationCodeRequest request = new ResetAuthorizationCodeRequest
            {
                RegistrationAsRegistrationName = RegistrationName.FromProjectLocationRegistration("[PROJECT]", "[LOCATION]", "[REGISTRATION]"),
            };
            AuthorizationCode expectedResponse = new AuthorizationCode
            {
                Code = "code946733c1",
            };
            mockGrpcClient.Setup(x => x.ResetAuthorizationCodeAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AuthorizationCode>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DomainsClient client = new DomainsClientImpl(mockGrpcClient.Object, null);
            AuthorizationCode responseCallSettings = await client.ResetAuthorizationCodeAsync(request.Registration, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AuthorizationCode responseCancellationToken = await client.ResetAuthorizationCodeAsync(request.Registration, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ResetAuthorizationCodeResourceNames()
        {
            moq::Mock<Domains.DomainsClient> mockGrpcClient = new moq::Mock<Domains.DomainsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            ResetAuthorizationCodeRequest request = new ResetAuthorizationCodeRequest
            {
                RegistrationAsRegistrationName = RegistrationName.FromProjectLocationRegistration("[PROJECT]", "[LOCATION]", "[REGISTRATION]"),
            };
            AuthorizationCode expectedResponse = new AuthorizationCode
            {
                Code = "code946733c1",
            };
            mockGrpcClient.Setup(x => x.ResetAuthorizationCode(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DomainsClient client = new DomainsClientImpl(mockGrpcClient.Object, null);
            AuthorizationCode response = client.ResetAuthorizationCode(request.RegistrationAsRegistrationName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ResetAuthorizationCodeResourceNamesAsync()
        {
            moq::Mock<Domains.DomainsClient> mockGrpcClient = new moq::Mock<Domains.DomainsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            ResetAuthorizationCodeRequest request = new ResetAuthorizationCodeRequest
            {
                RegistrationAsRegistrationName = RegistrationName.FromProjectLocationRegistration("[PROJECT]", "[LOCATION]", "[REGISTRATION]"),
            };
            AuthorizationCode expectedResponse = new AuthorizationCode
            {
                Code = "code946733c1",
            };
            mockGrpcClient.Setup(x => x.ResetAuthorizationCodeAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AuthorizationCode>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DomainsClient client = new DomainsClientImpl(mockGrpcClient.Object, null);
            AuthorizationCode responseCallSettings = await client.ResetAuthorizationCodeAsync(request.RegistrationAsRegistrationName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AuthorizationCode responseCancellationToken = await client.ResetAuthorizationCodeAsync(request.RegistrationAsRegistrationName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
