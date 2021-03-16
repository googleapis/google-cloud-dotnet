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
using gt = Google.Type;
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
                    new RegisterParameters
                    {
                        DomainName = "domain_nameea17a44f",
                        Availability = RegisterParameters.Types.Availability.Available,
                        SupportedPrivacy =
                        {
                            ContactPrivacy.PublicContactData,
                        },
                        DomainNotices =
                        {
                            DomainNotice.HstsPreloaded,
                        },
                        YearlyPrice = new gt::Money
                        {
                            CurrencyCode = "currency_code7f81e352",
                            Units = 1040752433522641849L,
                            Nanos = 985689544,
                        },
                    },
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
                    new RegisterParameters
                    {
                        DomainName = "domain_nameea17a44f",
                        Availability = RegisterParameters.Types.Availability.Available,
                        SupportedPrivacy =
                        {
                            ContactPrivacy.PublicContactData,
                        },
                        DomainNotices =
                        {
                            DomainNotice.HstsPreloaded,
                        },
                        YearlyPrice = new gt::Money
                        {
                            CurrencyCode = "currency_code7f81e352",
                            Units = 1040752433522641849L,
                            Nanos = 985689544,
                        },
                    },
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
                    new RegisterParameters
                    {
                        DomainName = "domain_nameea17a44f",
                        Availability = RegisterParameters.Types.Availability.Available,
                        SupportedPrivacy =
                        {
                            ContactPrivacy.PublicContactData,
                        },
                        DomainNotices =
                        {
                            DomainNotice.HstsPreloaded,
                        },
                        YearlyPrice = new gt::Money
                        {
                            CurrencyCode = "currency_code7f81e352",
                            Units = 1040752433522641849L,
                            Nanos = 985689544,
                        },
                    },
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
                    new RegisterParameters
                    {
                        DomainName = "domain_nameea17a44f",
                        Availability = RegisterParameters.Types.Availability.Available,
                        SupportedPrivacy =
                        {
                            ContactPrivacy.PublicContactData,
                        },
                        DomainNotices =
                        {
                            DomainNotice.HstsPreloaded,
                        },
                        YearlyPrice = new gt::Money
                        {
                            CurrencyCode = "currency_code7f81e352",
                            Units = 1040752433522641849L,
                            Nanos = 985689544,
                        },
                    },
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
                    new RegisterParameters
                    {
                        DomainName = "domain_nameea17a44f",
                        Availability = RegisterParameters.Types.Availability.Available,
                        SupportedPrivacy =
                        {
                            ContactPrivacy.PublicContactData,
                        },
                        DomainNotices =
                        {
                            DomainNotice.HstsPreloaded,
                        },
                        YearlyPrice = new gt::Money
                        {
                            CurrencyCode = "currency_code7f81e352",
                            Units = 1040752433522641849L,
                            Nanos = 985689544,
                        },
                    },
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
                    new RegisterParameters
                    {
                        DomainName = "domain_nameea17a44f",
                        Availability = RegisterParameters.Types.Availability.Available,
                        SupportedPrivacy =
                        {
                            ContactPrivacy.PublicContactData,
                        },
                        DomainNotices =
                        {
                            DomainNotice.HstsPreloaded,
                        },
                        YearlyPrice = new gt::Money
                        {
                            CurrencyCode = "currency_code7f81e352",
                            Units = 1040752433522641849L,
                            Nanos = 985689544,
                        },
                    },
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
                RegisterParameters = new RegisterParameters
                {
                    DomainName = "domain_nameea17a44f",
                    Availability = RegisterParameters.Types.Availability.Available,
                    SupportedPrivacy =
                    {
                        ContactPrivacy.PublicContactData,
                    },
                    DomainNotices =
                    {
                        DomainNotice.HstsPreloaded,
                    },
                    YearlyPrice = new gt::Money
                    {
                        CurrencyCode = "currency_code7f81e352",
                        Units = 1040752433522641849L,
                        Nanos = 985689544,
                    },
                },
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
                RegisterParameters = new RegisterParameters
                {
                    DomainName = "domain_nameea17a44f",
                    Availability = RegisterParameters.Types.Availability.Available,
                    SupportedPrivacy =
                    {
                        ContactPrivacy.PublicContactData,
                    },
                    DomainNotices =
                    {
                        DomainNotice.HstsPreloaded,
                    },
                    YearlyPrice = new gt::Money
                    {
                        CurrencyCode = "currency_code7f81e352",
                        Units = 1040752433522641849L,
                        Nanos = 985689544,
                    },
                },
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
                RegisterParameters = new RegisterParameters
                {
                    DomainName = "domain_nameea17a44f",
                    Availability = RegisterParameters.Types.Availability.Available,
                    SupportedPrivacy =
                    {
                        ContactPrivacy.PublicContactData,
                    },
                    DomainNotices =
                    {
                        DomainNotice.HstsPreloaded,
                    },
                    YearlyPrice = new gt::Money
                    {
                        CurrencyCode = "currency_code7f81e352",
                        Units = 1040752433522641849L,
                        Nanos = 985689544,
                    },
                },
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
                RegisterParameters = new RegisterParameters
                {
                    DomainName = "domain_nameea17a44f",
                    Availability = RegisterParameters.Types.Availability.Available,
                    SupportedPrivacy =
                    {
                        ContactPrivacy.PublicContactData,
                    },
                    DomainNotices =
                    {
                        DomainNotice.HstsPreloaded,
                    },
                    YearlyPrice = new gt::Money
                    {
                        CurrencyCode = "currency_code7f81e352",
                        Units = 1040752433522641849L,
                        Nanos = 985689544,
                    },
                },
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
                RegisterParameters = new RegisterParameters
                {
                    DomainName = "domain_nameea17a44f",
                    Availability = RegisterParameters.Types.Availability.Available,
                    SupportedPrivacy =
                    {
                        ContactPrivacy.PublicContactData,
                    },
                    DomainNotices =
                    {
                        DomainNotice.HstsPreloaded,
                    },
                    YearlyPrice = new gt::Money
                    {
                        CurrencyCode = "currency_code7f81e352",
                        Units = 1040752433522641849L,
                        Nanos = 985689544,
                    },
                },
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
                RegisterParameters = new RegisterParameters
                {
                    DomainName = "domain_nameea17a44f",
                    Availability = RegisterParameters.Types.Availability.Available,
                    SupportedPrivacy =
                    {
                        ContactPrivacy.PublicContactData,
                    },
                    DomainNotices =
                    {
                        DomainNotice.HstsPreloaded,
                    },
                    YearlyPrice = new gt::Money
                    {
                        CurrencyCode = "currency_code7f81e352",
                        Units = 1040752433522641849L,
                        Nanos = 985689544,
                    },
                },
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
                CreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                ExpireTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                State = Registration.Types.State.Unspecified,
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
                ManagementSettings = new ManagementSettings
                {
                    RenewalMethod = ManagementSettings.Types.RenewalMethod.ManualRenewal,
                    TransferLockState = TransferLockState.Locked,
                },
                DnsSettings = new DnsSettings
                {
                    CustomDns = new DnsSettings.Types.CustomDns
                    {
                        NameServers =
                        {
                            "name_servers0cf60382",
                        },
                        DsRecords =
                        {
                            new DnsSettings.Types.DsRecord
                            {
                                KeyTag = 95837116,
                                Algorithm = DnsSettings.Types.DsRecord.Types.Algorithm.Ecc,
                                DigestType = DnsSettings.Types.DsRecord.Types.DigestType.Sha256,
                                Digest = "digest96770fc1",
                            },
                        },
                    },
                    GoogleDomainsDns = new DnsSettings.Types.GoogleDomainsDns
                    {
                        NameServers =
                        {
                            "name_servers0cf60382",
                        },
                        DsState = DnsSettings.Types.DsState.DsRecordsPublished,
                        DsRecords =
                        {
                            new DnsSettings.Types.DsRecord
                            {
                                KeyTag = 95837116,
                                Algorithm = DnsSettings.Types.DsRecord.Types.Algorithm.Ecc,
                                DigestType = DnsSettings.Types.DsRecord.Types.DigestType.Sha256,
                                Digest = "digest96770fc1",
                            },
                        },
                    },
                    GlueRecords =
                    {
                        new DnsSettings.Types.GlueRecord
                        {
                            HostName = "host_name01d12cde",
                            Ipv4Addresses =
                            {
                                "ipv4_addresses46965872",
                            },
                            Ipv6Addresses =
                            {
                                "ipv6_addresses6e6e5fd1",
                            },
                        },
                    },
                },
                ContactSettings = new ContactSettings
                {
                    Privacy = ContactPrivacy.PublicContactData,
                    RegistrantContact = new ContactSettings.Types.Contact
                    {
                        PostalAddress = new gt::PostalAddress
                        {
                            Revision = -1171785291,
                            RegionCode = "region_code72561d46",
                            LanguageCode = "language_code2f6c7160",
                            PostalCode = "postal_code51d301e6",
                            SortingCode = "sorting_codeab47cbcd",
                            AdministrativeArea = "administrative_area5d9f9eab",
                            Locality = "locality2082e309",
                            Sublocality = "sublocality1a785e24",
                            AddressLines =
                            {
                                "address_lines4ab5c702",
                            },
                            Recipients =
                            {
                                "recipients9bf62a97",
                            },
                            Organization = "organization8c94c1b4",
                        },
                        Email = "email7cf5830c",
                        PhoneNumber = "phone_number9ebac341",
                        FaxNumber = "fax_number37e1f392",
                    },
                    AdminContact = new ContactSettings.Types.Contact
                    {
                        PostalAddress = new gt::PostalAddress
                        {
                            Revision = -1171785291,
                            RegionCode = "region_code72561d46",
                            LanguageCode = "language_code2f6c7160",
                            PostalCode = "postal_code51d301e6",
                            SortingCode = "sorting_codeab47cbcd",
                            AdministrativeArea = "administrative_area5d9f9eab",
                            Locality = "locality2082e309",
                            Sublocality = "sublocality1a785e24",
                            AddressLines =
                            {
                                "address_lines4ab5c702",
                            },
                            Recipients =
                            {
                                "recipients9bf62a97",
                            },
                            Organization = "organization8c94c1b4",
                        },
                        Email = "email7cf5830c",
                        PhoneNumber = "phone_number9ebac341",
                        FaxNumber = "fax_number37e1f392",
                    },
                    TechnicalContact = new ContactSettings.Types.Contact
                    {
                        PostalAddress = new gt::PostalAddress
                        {
                            Revision = -1171785291,
                            RegionCode = "region_code72561d46",
                            LanguageCode = "language_code2f6c7160",
                            PostalCode = "postal_code51d301e6",
                            SortingCode = "sorting_codeab47cbcd",
                            AdministrativeArea = "administrative_area5d9f9eab",
                            Locality = "locality2082e309",
                            Sublocality = "sublocality1a785e24",
                            AddressLines =
                            {
                                "address_lines4ab5c702",
                            },
                            Recipients =
                            {
                                "recipients9bf62a97",
                            },
                            Organization = "organization8c94c1b4",
                        },
                        Email = "email7cf5830c",
                        PhoneNumber = "phone_number9ebac341",
                        FaxNumber = "fax_number37e1f392",
                    },
                },
                PendingContactSettings = new ContactSettings
                {
                    Privacy = ContactPrivacy.PublicContactData,
                    RegistrantContact = new ContactSettings.Types.Contact
                    {
                        PostalAddress = new gt::PostalAddress
                        {
                            Revision = -1171785291,
                            RegionCode = "region_code72561d46",
                            LanguageCode = "language_code2f6c7160",
                            PostalCode = "postal_code51d301e6",
                            SortingCode = "sorting_codeab47cbcd",
                            AdministrativeArea = "administrative_area5d9f9eab",
                            Locality = "locality2082e309",
                            Sublocality = "sublocality1a785e24",
                            AddressLines =
                            {
                                "address_lines4ab5c702",
                            },
                            Recipients =
                            {
                                "recipients9bf62a97",
                            },
                            Organization = "organization8c94c1b4",
                        },
                        Email = "email7cf5830c",
                        PhoneNumber = "phone_number9ebac341",
                        FaxNumber = "fax_number37e1f392",
                    },
                    AdminContact = new ContactSettings.Types.Contact
                    {
                        PostalAddress = new gt::PostalAddress
                        {
                            Revision = -1171785291,
                            RegionCode = "region_code72561d46",
                            LanguageCode = "language_code2f6c7160",
                            PostalCode = "postal_code51d301e6",
                            SortingCode = "sorting_codeab47cbcd",
                            AdministrativeArea = "administrative_area5d9f9eab",
                            Locality = "locality2082e309",
                            Sublocality = "sublocality1a785e24",
                            AddressLines =
                            {
                                "address_lines4ab5c702",
                            },
                            Recipients =
                            {
                                "recipients9bf62a97",
                            },
                            Organization = "organization8c94c1b4",
                        },
                        Email = "email7cf5830c",
                        PhoneNumber = "phone_number9ebac341",
                        FaxNumber = "fax_number37e1f392",
                    },
                    TechnicalContact = new ContactSettings.Types.Contact
                    {
                        PostalAddress = new gt::PostalAddress
                        {
                            Revision = -1171785291,
                            RegionCode = "region_code72561d46",
                            LanguageCode = "language_code2f6c7160",
                            PostalCode = "postal_code51d301e6",
                            SortingCode = "sorting_codeab47cbcd",
                            AdministrativeArea = "administrative_area5d9f9eab",
                            Locality = "locality2082e309",
                            Sublocality = "sublocality1a785e24",
                            AddressLines =
                            {
                                "address_lines4ab5c702",
                            },
                            Recipients =
                            {
                                "recipients9bf62a97",
                            },
                            Organization = "organization8c94c1b4",
                        },
                        Email = "email7cf5830c",
                        PhoneNumber = "phone_number9ebac341",
                        FaxNumber = "fax_number37e1f392",
                    },
                },
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
                CreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                ExpireTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                State = Registration.Types.State.Unspecified,
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
                ManagementSettings = new ManagementSettings
                {
                    RenewalMethod = ManagementSettings.Types.RenewalMethod.ManualRenewal,
                    TransferLockState = TransferLockState.Locked,
                },
                DnsSettings = new DnsSettings
                {
                    CustomDns = new DnsSettings.Types.CustomDns
                    {
                        NameServers =
                        {
                            "name_servers0cf60382",
                        },
                        DsRecords =
                        {
                            new DnsSettings.Types.DsRecord
                            {
                                KeyTag = 95837116,
                                Algorithm = DnsSettings.Types.DsRecord.Types.Algorithm.Ecc,
                                DigestType = DnsSettings.Types.DsRecord.Types.DigestType.Sha256,
                                Digest = "digest96770fc1",
                            },
                        },
                    },
                    GoogleDomainsDns = new DnsSettings.Types.GoogleDomainsDns
                    {
                        NameServers =
                        {
                            "name_servers0cf60382",
                        },
                        DsState = DnsSettings.Types.DsState.DsRecordsPublished,
                        DsRecords =
                        {
                            new DnsSettings.Types.DsRecord
                            {
                                KeyTag = 95837116,
                                Algorithm = DnsSettings.Types.DsRecord.Types.Algorithm.Ecc,
                                DigestType = DnsSettings.Types.DsRecord.Types.DigestType.Sha256,
                                Digest = "digest96770fc1",
                            },
                        },
                    },
                    GlueRecords =
                    {
                        new DnsSettings.Types.GlueRecord
                        {
                            HostName = "host_name01d12cde",
                            Ipv4Addresses =
                            {
                                "ipv4_addresses46965872",
                            },
                            Ipv6Addresses =
                            {
                                "ipv6_addresses6e6e5fd1",
                            },
                        },
                    },
                },
                ContactSettings = new ContactSettings
                {
                    Privacy = ContactPrivacy.PublicContactData,
                    RegistrantContact = new ContactSettings.Types.Contact
                    {
                        PostalAddress = new gt::PostalAddress
                        {
                            Revision = -1171785291,
                            RegionCode = "region_code72561d46",
                            LanguageCode = "language_code2f6c7160",
                            PostalCode = "postal_code51d301e6",
                            SortingCode = "sorting_codeab47cbcd",
                            AdministrativeArea = "administrative_area5d9f9eab",
                            Locality = "locality2082e309",
                            Sublocality = "sublocality1a785e24",
                            AddressLines =
                            {
                                "address_lines4ab5c702",
                            },
                            Recipients =
                            {
                                "recipients9bf62a97",
                            },
                            Organization = "organization8c94c1b4",
                        },
                        Email = "email7cf5830c",
                        PhoneNumber = "phone_number9ebac341",
                        FaxNumber = "fax_number37e1f392",
                    },
                    AdminContact = new ContactSettings.Types.Contact
                    {
                        PostalAddress = new gt::PostalAddress
                        {
                            Revision = -1171785291,
                            RegionCode = "region_code72561d46",
                            LanguageCode = "language_code2f6c7160",
                            PostalCode = "postal_code51d301e6",
                            SortingCode = "sorting_codeab47cbcd",
                            AdministrativeArea = "administrative_area5d9f9eab",
                            Locality = "locality2082e309",
                            Sublocality = "sublocality1a785e24",
                            AddressLines =
                            {
                                "address_lines4ab5c702",
                            },
                            Recipients =
                            {
                                "recipients9bf62a97",
                            },
                            Organization = "organization8c94c1b4",
                        },
                        Email = "email7cf5830c",
                        PhoneNumber = "phone_number9ebac341",
                        FaxNumber = "fax_number37e1f392",
                    },
                    TechnicalContact = new ContactSettings.Types.Contact
                    {
                        PostalAddress = new gt::PostalAddress
                        {
                            Revision = -1171785291,
                            RegionCode = "region_code72561d46",
                            LanguageCode = "language_code2f6c7160",
                            PostalCode = "postal_code51d301e6",
                            SortingCode = "sorting_codeab47cbcd",
                            AdministrativeArea = "administrative_area5d9f9eab",
                            Locality = "locality2082e309",
                            Sublocality = "sublocality1a785e24",
                            AddressLines =
                            {
                                "address_lines4ab5c702",
                            },
                            Recipients =
                            {
                                "recipients9bf62a97",
                            },
                            Organization = "organization8c94c1b4",
                        },
                        Email = "email7cf5830c",
                        PhoneNumber = "phone_number9ebac341",
                        FaxNumber = "fax_number37e1f392",
                    },
                },
                PendingContactSettings = new ContactSettings
                {
                    Privacy = ContactPrivacy.PublicContactData,
                    RegistrantContact = new ContactSettings.Types.Contact
                    {
                        PostalAddress = new gt::PostalAddress
                        {
                            Revision = -1171785291,
                            RegionCode = "region_code72561d46",
                            LanguageCode = "language_code2f6c7160",
                            PostalCode = "postal_code51d301e6",
                            SortingCode = "sorting_codeab47cbcd",
                            AdministrativeArea = "administrative_area5d9f9eab",
                            Locality = "locality2082e309",
                            Sublocality = "sublocality1a785e24",
                            AddressLines =
                            {
                                "address_lines4ab5c702",
                            },
                            Recipients =
                            {
                                "recipients9bf62a97",
                            },
                            Organization = "organization8c94c1b4",
                        },
                        Email = "email7cf5830c",
                        PhoneNumber = "phone_number9ebac341",
                        FaxNumber = "fax_number37e1f392",
                    },
                    AdminContact = new ContactSettings.Types.Contact
                    {
                        PostalAddress = new gt::PostalAddress
                        {
                            Revision = -1171785291,
                            RegionCode = "region_code72561d46",
                            LanguageCode = "language_code2f6c7160",
                            PostalCode = "postal_code51d301e6",
                            SortingCode = "sorting_codeab47cbcd",
                            AdministrativeArea = "administrative_area5d9f9eab",
                            Locality = "locality2082e309",
                            Sublocality = "sublocality1a785e24",
                            AddressLines =
                            {
                                "address_lines4ab5c702",
                            },
                            Recipients =
                            {
                                "recipients9bf62a97",
                            },
                            Organization = "organization8c94c1b4",
                        },
                        Email = "email7cf5830c",
                        PhoneNumber = "phone_number9ebac341",
                        FaxNumber = "fax_number37e1f392",
                    },
                    TechnicalContact = new ContactSettings.Types.Contact
                    {
                        PostalAddress = new gt::PostalAddress
                        {
                            Revision = -1171785291,
                            RegionCode = "region_code72561d46",
                            LanguageCode = "language_code2f6c7160",
                            PostalCode = "postal_code51d301e6",
                            SortingCode = "sorting_codeab47cbcd",
                            AdministrativeArea = "administrative_area5d9f9eab",
                            Locality = "locality2082e309",
                            Sublocality = "sublocality1a785e24",
                            AddressLines =
                            {
                                "address_lines4ab5c702",
                            },
                            Recipients =
                            {
                                "recipients9bf62a97",
                            },
                            Organization = "organization8c94c1b4",
                        },
                        Email = "email7cf5830c",
                        PhoneNumber = "phone_number9ebac341",
                        FaxNumber = "fax_number37e1f392",
                    },
                },
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
                CreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                ExpireTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                State = Registration.Types.State.Unspecified,
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
                ManagementSettings = new ManagementSettings
                {
                    RenewalMethod = ManagementSettings.Types.RenewalMethod.ManualRenewal,
                    TransferLockState = TransferLockState.Locked,
                },
                DnsSettings = new DnsSettings
                {
                    CustomDns = new DnsSettings.Types.CustomDns
                    {
                        NameServers =
                        {
                            "name_servers0cf60382",
                        },
                        DsRecords =
                        {
                            new DnsSettings.Types.DsRecord
                            {
                                KeyTag = 95837116,
                                Algorithm = DnsSettings.Types.DsRecord.Types.Algorithm.Ecc,
                                DigestType = DnsSettings.Types.DsRecord.Types.DigestType.Sha256,
                                Digest = "digest96770fc1",
                            },
                        },
                    },
                    GoogleDomainsDns = new DnsSettings.Types.GoogleDomainsDns
                    {
                        NameServers =
                        {
                            "name_servers0cf60382",
                        },
                        DsState = DnsSettings.Types.DsState.DsRecordsPublished,
                        DsRecords =
                        {
                            new DnsSettings.Types.DsRecord
                            {
                                KeyTag = 95837116,
                                Algorithm = DnsSettings.Types.DsRecord.Types.Algorithm.Ecc,
                                DigestType = DnsSettings.Types.DsRecord.Types.DigestType.Sha256,
                                Digest = "digest96770fc1",
                            },
                        },
                    },
                    GlueRecords =
                    {
                        new DnsSettings.Types.GlueRecord
                        {
                            HostName = "host_name01d12cde",
                            Ipv4Addresses =
                            {
                                "ipv4_addresses46965872",
                            },
                            Ipv6Addresses =
                            {
                                "ipv6_addresses6e6e5fd1",
                            },
                        },
                    },
                },
                ContactSettings = new ContactSettings
                {
                    Privacy = ContactPrivacy.PublicContactData,
                    RegistrantContact = new ContactSettings.Types.Contact
                    {
                        PostalAddress = new gt::PostalAddress
                        {
                            Revision = -1171785291,
                            RegionCode = "region_code72561d46",
                            LanguageCode = "language_code2f6c7160",
                            PostalCode = "postal_code51d301e6",
                            SortingCode = "sorting_codeab47cbcd",
                            AdministrativeArea = "administrative_area5d9f9eab",
                            Locality = "locality2082e309",
                            Sublocality = "sublocality1a785e24",
                            AddressLines =
                            {
                                "address_lines4ab5c702",
                            },
                            Recipients =
                            {
                                "recipients9bf62a97",
                            },
                            Organization = "organization8c94c1b4",
                        },
                        Email = "email7cf5830c",
                        PhoneNumber = "phone_number9ebac341",
                        FaxNumber = "fax_number37e1f392",
                    },
                    AdminContact = new ContactSettings.Types.Contact
                    {
                        PostalAddress = new gt::PostalAddress
                        {
                            Revision = -1171785291,
                            RegionCode = "region_code72561d46",
                            LanguageCode = "language_code2f6c7160",
                            PostalCode = "postal_code51d301e6",
                            SortingCode = "sorting_codeab47cbcd",
                            AdministrativeArea = "administrative_area5d9f9eab",
                            Locality = "locality2082e309",
                            Sublocality = "sublocality1a785e24",
                            AddressLines =
                            {
                                "address_lines4ab5c702",
                            },
                            Recipients =
                            {
                                "recipients9bf62a97",
                            },
                            Organization = "organization8c94c1b4",
                        },
                        Email = "email7cf5830c",
                        PhoneNumber = "phone_number9ebac341",
                        FaxNumber = "fax_number37e1f392",
                    },
                    TechnicalContact = new ContactSettings.Types.Contact
                    {
                        PostalAddress = new gt::PostalAddress
                        {
                            Revision = -1171785291,
                            RegionCode = "region_code72561d46",
                            LanguageCode = "language_code2f6c7160",
                            PostalCode = "postal_code51d301e6",
                            SortingCode = "sorting_codeab47cbcd",
                            AdministrativeArea = "administrative_area5d9f9eab",
                            Locality = "locality2082e309",
                            Sublocality = "sublocality1a785e24",
                            AddressLines =
                            {
                                "address_lines4ab5c702",
                            },
                            Recipients =
                            {
                                "recipients9bf62a97",
                            },
                            Organization = "organization8c94c1b4",
                        },
                        Email = "email7cf5830c",
                        PhoneNumber = "phone_number9ebac341",
                        FaxNumber = "fax_number37e1f392",
                    },
                },
                PendingContactSettings = new ContactSettings
                {
                    Privacy = ContactPrivacy.PublicContactData,
                    RegistrantContact = new ContactSettings.Types.Contact
                    {
                        PostalAddress = new gt::PostalAddress
                        {
                            Revision = -1171785291,
                            RegionCode = "region_code72561d46",
                            LanguageCode = "language_code2f6c7160",
                            PostalCode = "postal_code51d301e6",
                            SortingCode = "sorting_codeab47cbcd",
                            AdministrativeArea = "administrative_area5d9f9eab",
                            Locality = "locality2082e309",
                            Sublocality = "sublocality1a785e24",
                            AddressLines =
                            {
                                "address_lines4ab5c702",
                            },
                            Recipients =
                            {
                                "recipients9bf62a97",
                            },
                            Organization = "organization8c94c1b4",
                        },
                        Email = "email7cf5830c",
                        PhoneNumber = "phone_number9ebac341",
                        FaxNumber = "fax_number37e1f392",
                    },
                    AdminContact = new ContactSettings.Types.Contact
                    {
                        PostalAddress = new gt::PostalAddress
                        {
                            Revision = -1171785291,
                            RegionCode = "region_code72561d46",
                            LanguageCode = "language_code2f6c7160",
                            PostalCode = "postal_code51d301e6",
                            SortingCode = "sorting_codeab47cbcd",
                            AdministrativeArea = "administrative_area5d9f9eab",
                            Locality = "locality2082e309",
                            Sublocality = "sublocality1a785e24",
                            AddressLines =
                            {
                                "address_lines4ab5c702",
                            },
                            Recipients =
                            {
                                "recipients9bf62a97",
                            },
                            Organization = "organization8c94c1b4",
                        },
                        Email = "email7cf5830c",
                        PhoneNumber = "phone_number9ebac341",
                        FaxNumber = "fax_number37e1f392",
                    },
                    TechnicalContact = new ContactSettings.Types.Contact
                    {
                        PostalAddress = new gt::PostalAddress
                        {
                            Revision = -1171785291,
                            RegionCode = "region_code72561d46",
                            LanguageCode = "language_code2f6c7160",
                            PostalCode = "postal_code51d301e6",
                            SortingCode = "sorting_codeab47cbcd",
                            AdministrativeArea = "administrative_area5d9f9eab",
                            Locality = "locality2082e309",
                            Sublocality = "sublocality1a785e24",
                            AddressLines =
                            {
                                "address_lines4ab5c702",
                            },
                            Recipients =
                            {
                                "recipients9bf62a97",
                            },
                            Organization = "organization8c94c1b4",
                        },
                        Email = "email7cf5830c",
                        PhoneNumber = "phone_number9ebac341",
                        FaxNumber = "fax_number37e1f392",
                    },
                },
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
                CreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                ExpireTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                State = Registration.Types.State.Unspecified,
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
                ManagementSettings = new ManagementSettings
                {
                    RenewalMethod = ManagementSettings.Types.RenewalMethod.ManualRenewal,
                    TransferLockState = TransferLockState.Locked,
                },
                DnsSettings = new DnsSettings
                {
                    CustomDns = new DnsSettings.Types.CustomDns
                    {
                        NameServers =
                        {
                            "name_servers0cf60382",
                        },
                        DsRecords =
                        {
                            new DnsSettings.Types.DsRecord
                            {
                                KeyTag = 95837116,
                                Algorithm = DnsSettings.Types.DsRecord.Types.Algorithm.Ecc,
                                DigestType = DnsSettings.Types.DsRecord.Types.DigestType.Sha256,
                                Digest = "digest96770fc1",
                            },
                        },
                    },
                    GoogleDomainsDns = new DnsSettings.Types.GoogleDomainsDns
                    {
                        NameServers =
                        {
                            "name_servers0cf60382",
                        },
                        DsState = DnsSettings.Types.DsState.DsRecordsPublished,
                        DsRecords =
                        {
                            new DnsSettings.Types.DsRecord
                            {
                                KeyTag = 95837116,
                                Algorithm = DnsSettings.Types.DsRecord.Types.Algorithm.Ecc,
                                DigestType = DnsSettings.Types.DsRecord.Types.DigestType.Sha256,
                                Digest = "digest96770fc1",
                            },
                        },
                    },
                    GlueRecords =
                    {
                        new DnsSettings.Types.GlueRecord
                        {
                            HostName = "host_name01d12cde",
                            Ipv4Addresses =
                            {
                                "ipv4_addresses46965872",
                            },
                            Ipv6Addresses =
                            {
                                "ipv6_addresses6e6e5fd1",
                            },
                        },
                    },
                },
                ContactSettings = new ContactSettings
                {
                    Privacy = ContactPrivacy.PublicContactData,
                    RegistrantContact = new ContactSettings.Types.Contact
                    {
                        PostalAddress = new gt::PostalAddress
                        {
                            Revision = -1171785291,
                            RegionCode = "region_code72561d46",
                            LanguageCode = "language_code2f6c7160",
                            PostalCode = "postal_code51d301e6",
                            SortingCode = "sorting_codeab47cbcd",
                            AdministrativeArea = "administrative_area5d9f9eab",
                            Locality = "locality2082e309",
                            Sublocality = "sublocality1a785e24",
                            AddressLines =
                            {
                                "address_lines4ab5c702",
                            },
                            Recipients =
                            {
                                "recipients9bf62a97",
                            },
                            Organization = "organization8c94c1b4",
                        },
                        Email = "email7cf5830c",
                        PhoneNumber = "phone_number9ebac341",
                        FaxNumber = "fax_number37e1f392",
                    },
                    AdminContact = new ContactSettings.Types.Contact
                    {
                        PostalAddress = new gt::PostalAddress
                        {
                            Revision = -1171785291,
                            RegionCode = "region_code72561d46",
                            LanguageCode = "language_code2f6c7160",
                            PostalCode = "postal_code51d301e6",
                            SortingCode = "sorting_codeab47cbcd",
                            AdministrativeArea = "administrative_area5d9f9eab",
                            Locality = "locality2082e309",
                            Sublocality = "sublocality1a785e24",
                            AddressLines =
                            {
                                "address_lines4ab5c702",
                            },
                            Recipients =
                            {
                                "recipients9bf62a97",
                            },
                            Organization = "organization8c94c1b4",
                        },
                        Email = "email7cf5830c",
                        PhoneNumber = "phone_number9ebac341",
                        FaxNumber = "fax_number37e1f392",
                    },
                    TechnicalContact = new ContactSettings.Types.Contact
                    {
                        PostalAddress = new gt::PostalAddress
                        {
                            Revision = -1171785291,
                            RegionCode = "region_code72561d46",
                            LanguageCode = "language_code2f6c7160",
                            PostalCode = "postal_code51d301e6",
                            SortingCode = "sorting_codeab47cbcd",
                            AdministrativeArea = "administrative_area5d9f9eab",
                            Locality = "locality2082e309",
                            Sublocality = "sublocality1a785e24",
                            AddressLines =
                            {
                                "address_lines4ab5c702",
                            },
                            Recipients =
                            {
                                "recipients9bf62a97",
                            },
                            Organization = "organization8c94c1b4",
                        },
                        Email = "email7cf5830c",
                        PhoneNumber = "phone_number9ebac341",
                        FaxNumber = "fax_number37e1f392",
                    },
                },
                PendingContactSettings = new ContactSettings
                {
                    Privacy = ContactPrivacy.PublicContactData,
                    RegistrantContact = new ContactSettings.Types.Contact
                    {
                        PostalAddress = new gt::PostalAddress
                        {
                            Revision = -1171785291,
                            RegionCode = "region_code72561d46",
                            LanguageCode = "language_code2f6c7160",
                            PostalCode = "postal_code51d301e6",
                            SortingCode = "sorting_codeab47cbcd",
                            AdministrativeArea = "administrative_area5d9f9eab",
                            Locality = "locality2082e309",
                            Sublocality = "sublocality1a785e24",
                            AddressLines =
                            {
                                "address_lines4ab5c702",
                            },
                            Recipients =
                            {
                                "recipients9bf62a97",
                            },
                            Organization = "organization8c94c1b4",
                        },
                        Email = "email7cf5830c",
                        PhoneNumber = "phone_number9ebac341",
                        FaxNumber = "fax_number37e1f392",
                    },
                    AdminContact = new ContactSettings.Types.Contact
                    {
                        PostalAddress = new gt::PostalAddress
                        {
                            Revision = -1171785291,
                            RegionCode = "region_code72561d46",
                            LanguageCode = "language_code2f6c7160",
                            PostalCode = "postal_code51d301e6",
                            SortingCode = "sorting_codeab47cbcd",
                            AdministrativeArea = "administrative_area5d9f9eab",
                            Locality = "locality2082e309",
                            Sublocality = "sublocality1a785e24",
                            AddressLines =
                            {
                                "address_lines4ab5c702",
                            },
                            Recipients =
                            {
                                "recipients9bf62a97",
                            },
                            Organization = "organization8c94c1b4",
                        },
                        Email = "email7cf5830c",
                        PhoneNumber = "phone_number9ebac341",
                        FaxNumber = "fax_number37e1f392",
                    },
                    TechnicalContact = new ContactSettings.Types.Contact
                    {
                        PostalAddress = new gt::PostalAddress
                        {
                            Revision = -1171785291,
                            RegionCode = "region_code72561d46",
                            LanguageCode = "language_code2f6c7160",
                            PostalCode = "postal_code51d301e6",
                            SortingCode = "sorting_codeab47cbcd",
                            AdministrativeArea = "administrative_area5d9f9eab",
                            Locality = "locality2082e309",
                            Sublocality = "sublocality1a785e24",
                            AddressLines =
                            {
                                "address_lines4ab5c702",
                            },
                            Recipients =
                            {
                                "recipients9bf62a97",
                            },
                            Organization = "organization8c94c1b4",
                        },
                        Email = "email7cf5830c",
                        PhoneNumber = "phone_number9ebac341",
                        FaxNumber = "fax_number37e1f392",
                    },
                },
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
                CreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                ExpireTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                State = Registration.Types.State.Unspecified,
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
                ManagementSettings = new ManagementSettings
                {
                    RenewalMethod = ManagementSettings.Types.RenewalMethod.ManualRenewal,
                    TransferLockState = TransferLockState.Locked,
                },
                DnsSettings = new DnsSettings
                {
                    CustomDns = new DnsSettings.Types.CustomDns
                    {
                        NameServers =
                        {
                            "name_servers0cf60382",
                        },
                        DsRecords =
                        {
                            new DnsSettings.Types.DsRecord
                            {
                                KeyTag = 95837116,
                                Algorithm = DnsSettings.Types.DsRecord.Types.Algorithm.Ecc,
                                DigestType = DnsSettings.Types.DsRecord.Types.DigestType.Sha256,
                                Digest = "digest96770fc1",
                            },
                        },
                    },
                    GoogleDomainsDns = new DnsSettings.Types.GoogleDomainsDns
                    {
                        NameServers =
                        {
                            "name_servers0cf60382",
                        },
                        DsState = DnsSettings.Types.DsState.DsRecordsPublished,
                        DsRecords =
                        {
                            new DnsSettings.Types.DsRecord
                            {
                                KeyTag = 95837116,
                                Algorithm = DnsSettings.Types.DsRecord.Types.Algorithm.Ecc,
                                DigestType = DnsSettings.Types.DsRecord.Types.DigestType.Sha256,
                                Digest = "digest96770fc1",
                            },
                        },
                    },
                    GlueRecords =
                    {
                        new DnsSettings.Types.GlueRecord
                        {
                            HostName = "host_name01d12cde",
                            Ipv4Addresses =
                            {
                                "ipv4_addresses46965872",
                            },
                            Ipv6Addresses =
                            {
                                "ipv6_addresses6e6e5fd1",
                            },
                        },
                    },
                },
                ContactSettings = new ContactSettings
                {
                    Privacy = ContactPrivacy.PublicContactData,
                    RegistrantContact = new ContactSettings.Types.Contact
                    {
                        PostalAddress = new gt::PostalAddress
                        {
                            Revision = -1171785291,
                            RegionCode = "region_code72561d46",
                            LanguageCode = "language_code2f6c7160",
                            PostalCode = "postal_code51d301e6",
                            SortingCode = "sorting_codeab47cbcd",
                            AdministrativeArea = "administrative_area5d9f9eab",
                            Locality = "locality2082e309",
                            Sublocality = "sublocality1a785e24",
                            AddressLines =
                            {
                                "address_lines4ab5c702",
                            },
                            Recipients =
                            {
                                "recipients9bf62a97",
                            },
                            Organization = "organization8c94c1b4",
                        },
                        Email = "email7cf5830c",
                        PhoneNumber = "phone_number9ebac341",
                        FaxNumber = "fax_number37e1f392",
                    },
                    AdminContact = new ContactSettings.Types.Contact
                    {
                        PostalAddress = new gt::PostalAddress
                        {
                            Revision = -1171785291,
                            RegionCode = "region_code72561d46",
                            LanguageCode = "language_code2f6c7160",
                            PostalCode = "postal_code51d301e6",
                            SortingCode = "sorting_codeab47cbcd",
                            AdministrativeArea = "administrative_area5d9f9eab",
                            Locality = "locality2082e309",
                            Sublocality = "sublocality1a785e24",
                            AddressLines =
                            {
                                "address_lines4ab5c702",
                            },
                            Recipients =
                            {
                                "recipients9bf62a97",
                            },
                            Organization = "organization8c94c1b4",
                        },
                        Email = "email7cf5830c",
                        PhoneNumber = "phone_number9ebac341",
                        FaxNumber = "fax_number37e1f392",
                    },
                    TechnicalContact = new ContactSettings.Types.Contact
                    {
                        PostalAddress = new gt::PostalAddress
                        {
                            Revision = -1171785291,
                            RegionCode = "region_code72561d46",
                            LanguageCode = "language_code2f6c7160",
                            PostalCode = "postal_code51d301e6",
                            SortingCode = "sorting_codeab47cbcd",
                            AdministrativeArea = "administrative_area5d9f9eab",
                            Locality = "locality2082e309",
                            Sublocality = "sublocality1a785e24",
                            AddressLines =
                            {
                                "address_lines4ab5c702",
                            },
                            Recipients =
                            {
                                "recipients9bf62a97",
                            },
                            Organization = "organization8c94c1b4",
                        },
                        Email = "email7cf5830c",
                        PhoneNumber = "phone_number9ebac341",
                        FaxNumber = "fax_number37e1f392",
                    },
                },
                PendingContactSettings = new ContactSettings
                {
                    Privacy = ContactPrivacy.PublicContactData,
                    RegistrantContact = new ContactSettings.Types.Contact
                    {
                        PostalAddress = new gt::PostalAddress
                        {
                            Revision = -1171785291,
                            RegionCode = "region_code72561d46",
                            LanguageCode = "language_code2f6c7160",
                            PostalCode = "postal_code51d301e6",
                            SortingCode = "sorting_codeab47cbcd",
                            AdministrativeArea = "administrative_area5d9f9eab",
                            Locality = "locality2082e309",
                            Sublocality = "sublocality1a785e24",
                            AddressLines =
                            {
                                "address_lines4ab5c702",
                            },
                            Recipients =
                            {
                                "recipients9bf62a97",
                            },
                            Organization = "organization8c94c1b4",
                        },
                        Email = "email7cf5830c",
                        PhoneNumber = "phone_number9ebac341",
                        FaxNumber = "fax_number37e1f392",
                    },
                    AdminContact = new ContactSettings.Types.Contact
                    {
                        PostalAddress = new gt::PostalAddress
                        {
                            Revision = -1171785291,
                            RegionCode = "region_code72561d46",
                            LanguageCode = "language_code2f6c7160",
                            PostalCode = "postal_code51d301e6",
                            SortingCode = "sorting_codeab47cbcd",
                            AdministrativeArea = "administrative_area5d9f9eab",
                            Locality = "locality2082e309",
                            Sublocality = "sublocality1a785e24",
                            AddressLines =
                            {
                                "address_lines4ab5c702",
                            },
                            Recipients =
                            {
                                "recipients9bf62a97",
                            },
                            Organization = "organization8c94c1b4",
                        },
                        Email = "email7cf5830c",
                        PhoneNumber = "phone_number9ebac341",
                        FaxNumber = "fax_number37e1f392",
                    },
                    TechnicalContact = new ContactSettings.Types.Contact
                    {
                        PostalAddress = new gt::PostalAddress
                        {
                            Revision = -1171785291,
                            RegionCode = "region_code72561d46",
                            LanguageCode = "language_code2f6c7160",
                            PostalCode = "postal_code51d301e6",
                            SortingCode = "sorting_codeab47cbcd",
                            AdministrativeArea = "administrative_area5d9f9eab",
                            Locality = "locality2082e309",
                            Sublocality = "sublocality1a785e24",
                            AddressLines =
                            {
                                "address_lines4ab5c702",
                            },
                            Recipients =
                            {
                                "recipients9bf62a97",
                            },
                            Organization = "organization8c94c1b4",
                        },
                        Email = "email7cf5830c",
                        PhoneNumber = "phone_number9ebac341",
                        FaxNumber = "fax_number37e1f392",
                    },
                },
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
                CreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                ExpireTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                State = Registration.Types.State.Unspecified,
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
                ManagementSettings = new ManagementSettings
                {
                    RenewalMethod = ManagementSettings.Types.RenewalMethod.ManualRenewal,
                    TransferLockState = TransferLockState.Locked,
                },
                DnsSettings = new DnsSettings
                {
                    CustomDns = new DnsSettings.Types.CustomDns
                    {
                        NameServers =
                        {
                            "name_servers0cf60382",
                        },
                        DsRecords =
                        {
                            new DnsSettings.Types.DsRecord
                            {
                                KeyTag = 95837116,
                                Algorithm = DnsSettings.Types.DsRecord.Types.Algorithm.Ecc,
                                DigestType = DnsSettings.Types.DsRecord.Types.DigestType.Sha256,
                                Digest = "digest96770fc1",
                            },
                        },
                    },
                    GoogleDomainsDns = new DnsSettings.Types.GoogleDomainsDns
                    {
                        NameServers =
                        {
                            "name_servers0cf60382",
                        },
                        DsState = DnsSettings.Types.DsState.DsRecordsPublished,
                        DsRecords =
                        {
                            new DnsSettings.Types.DsRecord
                            {
                                KeyTag = 95837116,
                                Algorithm = DnsSettings.Types.DsRecord.Types.Algorithm.Ecc,
                                DigestType = DnsSettings.Types.DsRecord.Types.DigestType.Sha256,
                                Digest = "digest96770fc1",
                            },
                        },
                    },
                    GlueRecords =
                    {
                        new DnsSettings.Types.GlueRecord
                        {
                            HostName = "host_name01d12cde",
                            Ipv4Addresses =
                            {
                                "ipv4_addresses46965872",
                            },
                            Ipv6Addresses =
                            {
                                "ipv6_addresses6e6e5fd1",
                            },
                        },
                    },
                },
                ContactSettings = new ContactSettings
                {
                    Privacy = ContactPrivacy.PublicContactData,
                    RegistrantContact = new ContactSettings.Types.Contact
                    {
                        PostalAddress = new gt::PostalAddress
                        {
                            Revision = -1171785291,
                            RegionCode = "region_code72561d46",
                            LanguageCode = "language_code2f6c7160",
                            PostalCode = "postal_code51d301e6",
                            SortingCode = "sorting_codeab47cbcd",
                            AdministrativeArea = "administrative_area5d9f9eab",
                            Locality = "locality2082e309",
                            Sublocality = "sublocality1a785e24",
                            AddressLines =
                            {
                                "address_lines4ab5c702",
                            },
                            Recipients =
                            {
                                "recipients9bf62a97",
                            },
                            Organization = "organization8c94c1b4",
                        },
                        Email = "email7cf5830c",
                        PhoneNumber = "phone_number9ebac341",
                        FaxNumber = "fax_number37e1f392",
                    },
                    AdminContact = new ContactSettings.Types.Contact
                    {
                        PostalAddress = new gt::PostalAddress
                        {
                            Revision = -1171785291,
                            RegionCode = "region_code72561d46",
                            LanguageCode = "language_code2f6c7160",
                            PostalCode = "postal_code51d301e6",
                            SortingCode = "sorting_codeab47cbcd",
                            AdministrativeArea = "administrative_area5d9f9eab",
                            Locality = "locality2082e309",
                            Sublocality = "sublocality1a785e24",
                            AddressLines =
                            {
                                "address_lines4ab5c702",
                            },
                            Recipients =
                            {
                                "recipients9bf62a97",
                            },
                            Organization = "organization8c94c1b4",
                        },
                        Email = "email7cf5830c",
                        PhoneNumber = "phone_number9ebac341",
                        FaxNumber = "fax_number37e1f392",
                    },
                    TechnicalContact = new ContactSettings.Types.Contact
                    {
                        PostalAddress = new gt::PostalAddress
                        {
                            Revision = -1171785291,
                            RegionCode = "region_code72561d46",
                            LanguageCode = "language_code2f6c7160",
                            PostalCode = "postal_code51d301e6",
                            SortingCode = "sorting_codeab47cbcd",
                            AdministrativeArea = "administrative_area5d9f9eab",
                            Locality = "locality2082e309",
                            Sublocality = "sublocality1a785e24",
                            AddressLines =
                            {
                                "address_lines4ab5c702",
                            },
                            Recipients =
                            {
                                "recipients9bf62a97",
                            },
                            Organization = "organization8c94c1b4",
                        },
                        Email = "email7cf5830c",
                        PhoneNumber = "phone_number9ebac341",
                        FaxNumber = "fax_number37e1f392",
                    },
                },
                PendingContactSettings = new ContactSettings
                {
                    Privacy = ContactPrivacy.PublicContactData,
                    RegistrantContact = new ContactSettings.Types.Contact
                    {
                        PostalAddress = new gt::PostalAddress
                        {
                            Revision = -1171785291,
                            RegionCode = "region_code72561d46",
                            LanguageCode = "language_code2f6c7160",
                            PostalCode = "postal_code51d301e6",
                            SortingCode = "sorting_codeab47cbcd",
                            AdministrativeArea = "administrative_area5d9f9eab",
                            Locality = "locality2082e309",
                            Sublocality = "sublocality1a785e24",
                            AddressLines =
                            {
                                "address_lines4ab5c702",
                            },
                            Recipients =
                            {
                                "recipients9bf62a97",
                            },
                            Organization = "organization8c94c1b4",
                        },
                        Email = "email7cf5830c",
                        PhoneNumber = "phone_number9ebac341",
                        FaxNumber = "fax_number37e1f392",
                    },
                    AdminContact = new ContactSettings.Types.Contact
                    {
                        PostalAddress = new gt::PostalAddress
                        {
                            Revision = -1171785291,
                            RegionCode = "region_code72561d46",
                            LanguageCode = "language_code2f6c7160",
                            PostalCode = "postal_code51d301e6",
                            SortingCode = "sorting_codeab47cbcd",
                            AdministrativeArea = "administrative_area5d9f9eab",
                            Locality = "locality2082e309",
                            Sublocality = "sublocality1a785e24",
                            AddressLines =
                            {
                                "address_lines4ab5c702",
                            },
                            Recipients =
                            {
                                "recipients9bf62a97",
                            },
                            Organization = "organization8c94c1b4",
                        },
                        Email = "email7cf5830c",
                        PhoneNumber = "phone_number9ebac341",
                        FaxNumber = "fax_number37e1f392",
                    },
                    TechnicalContact = new ContactSettings.Types.Contact
                    {
                        PostalAddress = new gt::PostalAddress
                        {
                            Revision = -1171785291,
                            RegionCode = "region_code72561d46",
                            LanguageCode = "language_code2f6c7160",
                            PostalCode = "postal_code51d301e6",
                            SortingCode = "sorting_codeab47cbcd",
                            AdministrativeArea = "administrative_area5d9f9eab",
                            Locality = "locality2082e309",
                            Sublocality = "sublocality1a785e24",
                            AddressLines =
                            {
                                "address_lines4ab5c702",
                            },
                            Recipients =
                            {
                                "recipients9bf62a97",
                            },
                            Organization = "organization8c94c1b4",
                        },
                        Email = "email7cf5830c",
                        PhoneNumber = "phone_number9ebac341",
                        FaxNumber = "fax_number37e1f392",
                    },
                },
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
