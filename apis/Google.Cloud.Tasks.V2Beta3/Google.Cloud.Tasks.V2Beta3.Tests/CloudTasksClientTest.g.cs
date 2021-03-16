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

using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using gagr = Google.Api.Gax.ResourceNames;
using gciv = Google.Cloud.Iam.V1;
using proto = Google.Protobuf;
using wkt = Google.Protobuf.WellKnownTypes;
using gr = Google.Rpc;
using gt = Google.Type;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.Tasks.V2Beta3.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedCloudTasksClientTest
    {
        [xunit::FactAttribute]
        public void GetQueueRequestObject()
        {
            moq::Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new moq::Mock<CloudTasks.CloudTasksClient>(moq::MockBehavior.Strict);
            GetQueueRequest request = new GetQueueRequest
            {
                QueueName = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
                ReadMask = new wkt::FieldMask
                {
                    Paths = { "paths012c8713", },
                },
            };
            Queue expectedResponse = new Queue
            {
                QueueName = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
                AppEngineHttpQueue = new AppEngineHttpQueue
                {
                    AppEngineRoutingOverride = new AppEngineRouting
                    {
                        Service = "serviced3f0abaa",
                        Version = "version102ff72a",
                        Instance = "instance99a62371",
                        Host = "hosta8dbb367",
                    },
                },
                RateLimits = new RateLimits
                {
                    MaxDispatchesPerSecond = -1.3413182376911498E+17,
                    MaxBurstSize = -392517653,
                    MaxConcurrentDispatches = 1055474748,
                },
                RetryConfig = new RetryConfig
                {
                    MaxAttempts = 773154519,
                    MaxRetryDuration = new wkt::Duration
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    MinBackoff = new wkt::Duration
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    MaxBackoff = new wkt::Duration
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    MaxDoublings = 118749490,
                },
                State = Queue.Types.State.Paused,
                PurgeTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                TaskTtl = new wkt::Duration
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                TombstoneTtl = new wkt::Duration
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                StackdriverLoggingConfig = new StackdriverLoggingConfig
                {
                    SamplingRatio = -4.970885912593337E+17,
                },
                Type = Queue.Types.Type.Unspecified,
                Stats = new QueueStats
                {
                    TasksCount = -599872995928871713L,
                    OldestEstimatedArrivalTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    ExecutedLastMinuteCount = -6134631481989949557L,
                    ConcurrentDispatchesCount = -2842648588445718402L,
                    EffectiveExecutionRate = -8.535060261327416E+17,
                },
            };
            mockGrpcClient.Setup(x => x.GetQueue(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null);
            Queue response = client.GetQueue(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetQueueRequestObjectAsync()
        {
            moq::Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new moq::Mock<CloudTasks.CloudTasksClient>(moq::MockBehavior.Strict);
            GetQueueRequest request = new GetQueueRequest
            {
                QueueName = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
                ReadMask = new wkt::FieldMask
                {
                    Paths = { "paths012c8713", },
                },
            };
            Queue expectedResponse = new Queue
            {
                QueueName = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
                AppEngineHttpQueue = new AppEngineHttpQueue
                {
                    AppEngineRoutingOverride = new AppEngineRouting
                    {
                        Service = "serviced3f0abaa",
                        Version = "version102ff72a",
                        Instance = "instance99a62371",
                        Host = "hosta8dbb367",
                    },
                },
                RateLimits = new RateLimits
                {
                    MaxDispatchesPerSecond = -1.3413182376911498E+17,
                    MaxBurstSize = -392517653,
                    MaxConcurrentDispatches = 1055474748,
                },
                RetryConfig = new RetryConfig
                {
                    MaxAttempts = 773154519,
                    MaxRetryDuration = new wkt::Duration
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    MinBackoff = new wkt::Duration
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    MaxBackoff = new wkt::Duration
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    MaxDoublings = 118749490,
                },
                State = Queue.Types.State.Paused,
                PurgeTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                TaskTtl = new wkt::Duration
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                TombstoneTtl = new wkt::Duration
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                StackdriverLoggingConfig = new StackdriverLoggingConfig
                {
                    SamplingRatio = -4.970885912593337E+17,
                },
                Type = Queue.Types.Type.Unspecified,
                Stats = new QueueStats
                {
                    TasksCount = -599872995928871713L,
                    OldestEstimatedArrivalTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    ExecutedLastMinuteCount = -6134631481989949557L,
                    ConcurrentDispatchesCount = -2842648588445718402L,
                    EffectiveExecutionRate = -8.535060261327416E+17,
                },
            };
            mockGrpcClient.Setup(x => x.GetQueueAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Queue>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null);
            Queue responseCallSettings = await client.GetQueueAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Queue responseCancellationToken = await client.GetQueueAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetQueue()
        {
            moq::Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new moq::Mock<CloudTasks.CloudTasksClient>(moq::MockBehavior.Strict);
            GetQueueRequest request = new GetQueueRequest
            {
                QueueName = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
            };
            Queue expectedResponse = new Queue
            {
                QueueName = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
                AppEngineHttpQueue = new AppEngineHttpQueue
                {
                    AppEngineRoutingOverride = new AppEngineRouting
                    {
                        Service = "serviced3f0abaa",
                        Version = "version102ff72a",
                        Instance = "instance99a62371",
                        Host = "hosta8dbb367",
                    },
                },
                RateLimits = new RateLimits
                {
                    MaxDispatchesPerSecond = -1.3413182376911498E+17,
                    MaxBurstSize = -392517653,
                    MaxConcurrentDispatches = 1055474748,
                },
                RetryConfig = new RetryConfig
                {
                    MaxAttempts = 773154519,
                    MaxRetryDuration = new wkt::Duration
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    MinBackoff = new wkt::Duration
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    MaxBackoff = new wkt::Duration
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    MaxDoublings = 118749490,
                },
                State = Queue.Types.State.Paused,
                PurgeTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                TaskTtl = new wkt::Duration
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                TombstoneTtl = new wkt::Duration
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                StackdriverLoggingConfig = new StackdriverLoggingConfig
                {
                    SamplingRatio = -4.970885912593337E+17,
                },
                Type = Queue.Types.Type.Unspecified,
                Stats = new QueueStats
                {
                    TasksCount = -599872995928871713L,
                    OldestEstimatedArrivalTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    ExecutedLastMinuteCount = -6134631481989949557L,
                    ConcurrentDispatchesCount = -2842648588445718402L,
                    EffectiveExecutionRate = -8.535060261327416E+17,
                },
            };
            mockGrpcClient.Setup(x => x.GetQueue(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null);
            Queue response = client.GetQueue(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetQueueAsync()
        {
            moq::Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new moq::Mock<CloudTasks.CloudTasksClient>(moq::MockBehavior.Strict);
            GetQueueRequest request = new GetQueueRequest
            {
                QueueName = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
            };
            Queue expectedResponse = new Queue
            {
                QueueName = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
                AppEngineHttpQueue = new AppEngineHttpQueue
                {
                    AppEngineRoutingOverride = new AppEngineRouting
                    {
                        Service = "serviced3f0abaa",
                        Version = "version102ff72a",
                        Instance = "instance99a62371",
                        Host = "hosta8dbb367",
                    },
                },
                RateLimits = new RateLimits
                {
                    MaxDispatchesPerSecond = -1.3413182376911498E+17,
                    MaxBurstSize = -392517653,
                    MaxConcurrentDispatches = 1055474748,
                },
                RetryConfig = new RetryConfig
                {
                    MaxAttempts = 773154519,
                    MaxRetryDuration = new wkt::Duration
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    MinBackoff = new wkt::Duration
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    MaxBackoff = new wkt::Duration
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    MaxDoublings = 118749490,
                },
                State = Queue.Types.State.Paused,
                PurgeTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                TaskTtl = new wkt::Duration
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                TombstoneTtl = new wkt::Duration
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                StackdriverLoggingConfig = new StackdriverLoggingConfig
                {
                    SamplingRatio = -4.970885912593337E+17,
                },
                Type = Queue.Types.Type.Unspecified,
                Stats = new QueueStats
                {
                    TasksCount = -599872995928871713L,
                    OldestEstimatedArrivalTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    ExecutedLastMinuteCount = -6134631481989949557L,
                    ConcurrentDispatchesCount = -2842648588445718402L,
                    EffectiveExecutionRate = -8.535060261327416E+17,
                },
            };
            mockGrpcClient.Setup(x => x.GetQueueAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Queue>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null);
            Queue responseCallSettings = await client.GetQueueAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Queue responseCancellationToken = await client.GetQueueAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetQueueResourceNames()
        {
            moq::Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new moq::Mock<CloudTasks.CloudTasksClient>(moq::MockBehavior.Strict);
            GetQueueRequest request = new GetQueueRequest
            {
                QueueName = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
            };
            Queue expectedResponse = new Queue
            {
                QueueName = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
                AppEngineHttpQueue = new AppEngineHttpQueue
                {
                    AppEngineRoutingOverride = new AppEngineRouting
                    {
                        Service = "serviced3f0abaa",
                        Version = "version102ff72a",
                        Instance = "instance99a62371",
                        Host = "hosta8dbb367",
                    },
                },
                RateLimits = new RateLimits
                {
                    MaxDispatchesPerSecond = -1.3413182376911498E+17,
                    MaxBurstSize = -392517653,
                    MaxConcurrentDispatches = 1055474748,
                },
                RetryConfig = new RetryConfig
                {
                    MaxAttempts = 773154519,
                    MaxRetryDuration = new wkt::Duration
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    MinBackoff = new wkt::Duration
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    MaxBackoff = new wkt::Duration
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    MaxDoublings = 118749490,
                },
                State = Queue.Types.State.Paused,
                PurgeTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                TaskTtl = new wkt::Duration
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                TombstoneTtl = new wkt::Duration
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                StackdriverLoggingConfig = new StackdriverLoggingConfig
                {
                    SamplingRatio = -4.970885912593337E+17,
                },
                Type = Queue.Types.Type.Unspecified,
                Stats = new QueueStats
                {
                    TasksCount = -599872995928871713L,
                    OldestEstimatedArrivalTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    ExecutedLastMinuteCount = -6134631481989949557L,
                    ConcurrentDispatchesCount = -2842648588445718402L,
                    EffectiveExecutionRate = -8.535060261327416E+17,
                },
            };
            mockGrpcClient.Setup(x => x.GetQueue(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null);
            Queue response = client.GetQueue(request.QueueName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetQueueResourceNamesAsync()
        {
            moq::Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new moq::Mock<CloudTasks.CloudTasksClient>(moq::MockBehavior.Strict);
            GetQueueRequest request = new GetQueueRequest
            {
                QueueName = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
            };
            Queue expectedResponse = new Queue
            {
                QueueName = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
                AppEngineHttpQueue = new AppEngineHttpQueue
                {
                    AppEngineRoutingOverride = new AppEngineRouting
                    {
                        Service = "serviced3f0abaa",
                        Version = "version102ff72a",
                        Instance = "instance99a62371",
                        Host = "hosta8dbb367",
                    },
                },
                RateLimits = new RateLimits
                {
                    MaxDispatchesPerSecond = -1.3413182376911498E+17,
                    MaxBurstSize = -392517653,
                    MaxConcurrentDispatches = 1055474748,
                },
                RetryConfig = new RetryConfig
                {
                    MaxAttempts = 773154519,
                    MaxRetryDuration = new wkt::Duration
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    MinBackoff = new wkt::Duration
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    MaxBackoff = new wkt::Duration
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    MaxDoublings = 118749490,
                },
                State = Queue.Types.State.Paused,
                PurgeTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                TaskTtl = new wkt::Duration
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                TombstoneTtl = new wkt::Duration
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                StackdriverLoggingConfig = new StackdriverLoggingConfig
                {
                    SamplingRatio = -4.970885912593337E+17,
                },
                Type = Queue.Types.Type.Unspecified,
                Stats = new QueueStats
                {
                    TasksCount = -599872995928871713L,
                    OldestEstimatedArrivalTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    ExecutedLastMinuteCount = -6134631481989949557L,
                    ConcurrentDispatchesCount = -2842648588445718402L,
                    EffectiveExecutionRate = -8.535060261327416E+17,
                },
            };
            mockGrpcClient.Setup(x => x.GetQueueAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Queue>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null);
            Queue responseCallSettings = await client.GetQueueAsync(request.QueueName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Queue responseCancellationToken = await client.GetQueueAsync(request.QueueName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateQueueRequestObject()
        {
            moq::Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new moq::Mock<CloudTasks.CloudTasksClient>(moq::MockBehavior.Strict);
            CreateQueueRequest request = new CreateQueueRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Queue = new Queue
                {
                    QueueName = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
                    AppEngineHttpQueue = new AppEngineHttpQueue
                    {
                        AppEngineRoutingOverride = new AppEngineRouting
                        {
                            Service = "serviced3f0abaa",
                            Version = "version102ff72a",
                            Instance = "instance99a62371",
                            Host = "hosta8dbb367",
                        },
                    },
                    RateLimits = new RateLimits
                    {
                        MaxDispatchesPerSecond = -1.3413182376911498E+17,
                        MaxBurstSize = -392517653,
                        MaxConcurrentDispatches = 1055474748,
                    },
                    RetryConfig = new RetryConfig
                    {
                        MaxAttempts = 773154519,
                        MaxRetryDuration = new wkt::Duration
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        MinBackoff = new wkt::Duration
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        MaxBackoff = new wkt::Duration
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        MaxDoublings = 118749490,
                    },
                    State = Queue.Types.State.Paused,
                    PurgeTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    TaskTtl = new wkt::Duration
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    TombstoneTtl = new wkt::Duration
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    StackdriverLoggingConfig = new StackdriverLoggingConfig
                    {
                        SamplingRatio = -4.970885912593337E+17,
                    },
                    Type = Queue.Types.Type.Unspecified,
                    Stats = new QueueStats
                    {
                        TasksCount = -599872995928871713L,
                        OldestEstimatedArrivalTime = new wkt::Timestamp
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        ExecutedLastMinuteCount = -6134631481989949557L,
                        ConcurrentDispatchesCount = -2842648588445718402L,
                        EffectiveExecutionRate = -8.535060261327416E+17,
                    },
                },
            };
            Queue expectedResponse = new Queue
            {
                QueueName = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
                AppEngineHttpQueue = new AppEngineHttpQueue
                {
                    AppEngineRoutingOverride = new AppEngineRouting
                    {
                        Service = "serviced3f0abaa",
                        Version = "version102ff72a",
                        Instance = "instance99a62371",
                        Host = "hosta8dbb367",
                    },
                },
                RateLimits = new RateLimits
                {
                    MaxDispatchesPerSecond = -1.3413182376911498E+17,
                    MaxBurstSize = -392517653,
                    MaxConcurrentDispatches = 1055474748,
                },
                RetryConfig = new RetryConfig
                {
                    MaxAttempts = 773154519,
                    MaxRetryDuration = new wkt::Duration
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    MinBackoff = new wkt::Duration
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    MaxBackoff = new wkt::Duration
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    MaxDoublings = 118749490,
                },
                State = Queue.Types.State.Paused,
                PurgeTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                TaskTtl = new wkt::Duration
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                TombstoneTtl = new wkt::Duration
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                StackdriverLoggingConfig = new StackdriverLoggingConfig
                {
                    SamplingRatio = -4.970885912593337E+17,
                },
                Type = Queue.Types.Type.Unspecified,
                Stats = new QueueStats
                {
                    TasksCount = -599872995928871713L,
                    OldestEstimatedArrivalTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    ExecutedLastMinuteCount = -6134631481989949557L,
                    ConcurrentDispatchesCount = -2842648588445718402L,
                    EffectiveExecutionRate = -8.535060261327416E+17,
                },
            };
            mockGrpcClient.Setup(x => x.CreateQueue(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null);
            Queue response = client.CreateQueue(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateQueueRequestObjectAsync()
        {
            moq::Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new moq::Mock<CloudTasks.CloudTasksClient>(moq::MockBehavior.Strict);
            CreateQueueRequest request = new CreateQueueRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Queue = new Queue
                {
                    QueueName = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
                    AppEngineHttpQueue = new AppEngineHttpQueue
                    {
                        AppEngineRoutingOverride = new AppEngineRouting
                        {
                            Service = "serviced3f0abaa",
                            Version = "version102ff72a",
                            Instance = "instance99a62371",
                            Host = "hosta8dbb367",
                        },
                    },
                    RateLimits = new RateLimits
                    {
                        MaxDispatchesPerSecond = -1.3413182376911498E+17,
                        MaxBurstSize = -392517653,
                        MaxConcurrentDispatches = 1055474748,
                    },
                    RetryConfig = new RetryConfig
                    {
                        MaxAttempts = 773154519,
                        MaxRetryDuration = new wkt::Duration
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        MinBackoff = new wkt::Duration
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        MaxBackoff = new wkt::Duration
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        MaxDoublings = 118749490,
                    },
                    State = Queue.Types.State.Paused,
                    PurgeTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    TaskTtl = new wkt::Duration
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    TombstoneTtl = new wkt::Duration
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    StackdriverLoggingConfig = new StackdriverLoggingConfig
                    {
                        SamplingRatio = -4.970885912593337E+17,
                    },
                    Type = Queue.Types.Type.Unspecified,
                    Stats = new QueueStats
                    {
                        TasksCount = -599872995928871713L,
                        OldestEstimatedArrivalTime = new wkt::Timestamp
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        ExecutedLastMinuteCount = -6134631481989949557L,
                        ConcurrentDispatchesCount = -2842648588445718402L,
                        EffectiveExecutionRate = -8.535060261327416E+17,
                    },
                },
            };
            Queue expectedResponse = new Queue
            {
                QueueName = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
                AppEngineHttpQueue = new AppEngineHttpQueue
                {
                    AppEngineRoutingOverride = new AppEngineRouting
                    {
                        Service = "serviced3f0abaa",
                        Version = "version102ff72a",
                        Instance = "instance99a62371",
                        Host = "hosta8dbb367",
                    },
                },
                RateLimits = new RateLimits
                {
                    MaxDispatchesPerSecond = -1.3413182376911498E+17,
                    MaxBurstSize = -392517653,
                    MaxConcurrentDispatches = 1055474748,
                },
                RetryConfig = new RetryConfig
                {
                    MaxAttempts = 773154519,
                    MaxRetryDuration = new wkt::Duration
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    MinBackoff = new wkt::Duration
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    MaxBackoff = new wkt::Duration
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    MaxDoublings = 118749490,
                },
                State = Queue.Types.State.Paused,
                PurgeTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                TaskTtl = new wkt::Duration
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                TombstoneTtl = new wkt::Duration
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                StackdriverLoggingConfig = new StackdriverLoggingConfig
                {
                    SamplingRatio = -4.970885912593337E+17,
                },
                Type = Queue.Types.Type.Unspecified,
                Stats = new QueueStats
                {
                    TasksCount = -599872995928871713L,
                    OldestEstimatedArrivalTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    ExecutedLastMinuteCount = -6134631481989949557L,
                    ConcurrentDispatchesCount = -2842648588445718402L,
                    EffectiveExecutionRate = -8.535060261327416E+17,
                },
            };
            mockGrpcClient.Setup(x => x.CreateQueueAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Queue>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null);
            Queue responseCallSettings = await client.CreateQueueAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Queue responseCancellationToken = await client.CreateQueueAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateQueue()
        {
            moq::Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new moq::Mock<CloudTasks.CloudTasksClient>(moq::MockBehavior.Strict);
            CreateQueueRequest request = new CreateQueueRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Queue = new Queue
                {
                    QueueName = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
                    AppEngineHttpQueue = new AppEngineHttpQueue
                    {
                        AppEngineRoutingOverride = new AppEngineRouting
                        {
                            Service = "serviced3f0abaa",
                            Version = "version102ff72a",
                            Instance = "instance99a62371",
                            Host = "hosta8dbb367",
                        },
                    },
                    RateLimits = new RateLimits
                    {
                        MaxDispatchesPerSecond = -1.3413182376911498E+17,
                        MaxBurstSize = -392517653,
                        MaxConcurrentDispatches = 1055474748,
                    },
                    RetryConfig = new RetryConfig
                    {
                        MaxAttempts = 773154519,
                        MaxRetryDuration = new wkt::Duration
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        MinBackoff = new wkt::Duration
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        MaxBackoff = new wkt::Duration
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        MaxDoublings = 118749490,
                    },
                    State = Queue.Types.State.Paused,
                    PurgeTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    TaskTtl = new wkt::Duration
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    TombstoneTtl = new wkt::Duration
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    StackdriverLoggingConfig = new StackdriverLoggingConfig
                    {
                        SamplingRatio = -4.970885912593337E+17,
                    },
                    Type = Queue.Types.Type.Unspecified,
                    Stats = new QueueStats
                    {
                        TasksCount = -599872995928871713L,
                        OldestEstimatedArrivalTime = new wkt::Timestamp
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        ExecutedLastMinuteCount = -6134631481989949557L,
                        ConcurrentDispatchesCount = -2842648588445718402L,
                        EffectiveExecutionRate = -8.535060261327416E+17,
                    },
                },
            };
            Queue expectedResponse = new Queue
            {
                QueueName = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
                AppEngineHttpQueue = new AppEngineHttpQueue
                {
                    AppEngineRoutingOverride = new AppEngineRouting
                    {
                        Service = "serviced3f0abaa",
                        Version = "version102ff72a",
                        Instance = "instance99a62371",
                        Host = "hosta8dbb367",
                    },
                },
                RateLimits = new RateLimits
                {
                    MaxDispatchesPerSecond = -1.3413182376911498E+17,
                    MaxBurstSize = -392517653,
                    MaxConcurrentDispatches = 1055474748,
                },
                RetryConfig = new RetryConfig
                {
                    MaxAttempts = 773154519,
                    MaxRetryDuration = new wkt::Duration
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    MinBackoff = new wkt::Duration
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    MaxBackoff = new wkt::Duration
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    MaxDoublings = 118749490,
                },
                State = Queue.Types.State.Paused,
                PurgeTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                TaskTtl = new wkt::Duration
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                TombstoneTtl = new wkt::Duration
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                StackdriverLoggingConfig = new StackdriverLoggingConfig
                {
                    SamplingRatio = -4.970885912593337E+17,
                },
                Type = Queue.Types.Type.Unspecified,
                Stats = new QueueStats
                {
                    TasksCount = -599872995928871713L,
                    OldestEstimatedArrivalTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    ExecutedLastMinuteCount = -6134631481989949557L,
                    ConcurrentDispatchesCount = -2842648588445718402L,
                    EffectiveExecutionRate = -8.535060261327416E+17,
                },
            };
            mockGrpcClient.Setup(x => x.CreateQueue(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null);
            Queue response = client.CreateQueue(request.Parent, request.Queue);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateQueueAsync()
        {
            moq::Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new moq::Mock<CloudTasks.CloudTasksClient>(moq::MockBehavior.Strict);
            CreateQueueRequest request = new CreateQueueRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Queue = new Queue
                {
                    QueueName = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
                    AppEngineHttpQueue = new AppEngineHttpQueue
                    {
                        AppEngineRoutingOverride = new AppEngineRouting
                        {
                            Service = "serviced3f0abaa",
                            Version = "version102ff72a",
                            Instance = "instance99a62371",
                            Host = "hosta8dbb367",
                        },
                    },
                    RateLimits = new RateLimits
                    {
                        MaxDispatchesPerSecond = -1.3413182376911498E+17,
                        MaxBurstSize = -392517653,
                        MaxConcurrentDispatches = 1055474748,
                    },
                    RetryConfig = new RetryConfig
                    {
                        MaxAttempts = 773154519,
                        MaxRetryDuration = new wkt::Duration
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        MinBackoff = new wkt::Duration
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        MaxBackoff = new wkt::Duration
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        MaxDoublings = 118749490,
                    },
                    State = Queue.Types.State.Paused,
                    PurgeTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    TaskTtl = new wkt::Duration
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    TombstoneTtl = new wkt::Duration
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    StackdriverLoggingConfig = new StackdriverLoggingConfig
                    {
                        SamplingRatio = -4.970885912593337E+17,
                    },
                    Type = Queue.Types.Type.Unspecified,
                    Stats = new QueueStats
                    {
                        TasksCount = -599872995928871713L,
                        OldestEstimatedArrivalTime = new wkt::Timestamp
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        ExecutedLastMinuteCount = -6134631481989949557L,
                        ConcurrentDispatchesCount = -2842648588445718402L,
                        EffectiveExecutionRate = -8.535060261327416E+17,
                    },
                },
            };
            Queue expectedResponse = new Queue
            {
                QueueName = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
                AppEngineHttpQueue = new AppEngineHttpQueue
                {
                    AppEngineRoutingOverride = new AppEngineRouting
                    {
                        Service = "serviced3f0abaa",
                        Version = "version102ff72a",
                        Instance = "instance99a62371",
                        Host = "hosta8dbb367",
                    },
                },
                RateLimits = new RateLimits
                {
                    MaxDispatchesPerSecond = -1.3413182376911498E+17,
                    MaxBurstSize = -392517653,
                    MaxConcurrentDispatches = 1055474748,
                },
                RetryConfig = new RetryConfig
                {
                    MaxAttempts = 773154519,
                    MaxRetryDuration = new wkt::Duration
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    MinBackoff = new wkt::Duration
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    MaxBackoff = new wkt::Duration
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    MaxDoublings = 118749490,
                },
                State = Queue.Types.State.Paused,
                PurgeTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                TaskTtl = new wkt::Duration
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                TombstoneTtl = new wkt::Duration
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                StackdriverLoggingConfig = new StackdriverLoggingConfig
                {
                    SamplingRatio = -4.970885912593337E+17,
                },
                Type = Queue.Types.Type.Unspecified,
                Stats = new QueueStats
                {
                    TasksCount = -599872995928871713L,
                    OldestEstimatedArrivalTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    ExecutedLastMinuteCount = -6134631481989949557L,
                    ConcurrentDispatchesCount = -2842648588445718402L,
                    EffectiveExecutionRate = -8.535060261327416E+17,
                },
            };
            mockGrpcClient.Setup(x => x.CreateQueueAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Queue>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null);
            Queue responseCallSettings = await client.CreateQueueAsync(request.Parent, request.Queue, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Queue responseCancellationToken = await client.CreateQueueAsync(request.Parent, request.Queue, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateQueueResourceNames()
        {
            moq::Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new moq::Mock<CloudTasks.CloudTasksClient>(moq::MockBehavior.Strict);
            CreateQueueRequest request = new CreateQueueRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Queue = new Queue
                {
                    QueueName = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
                    AppEngineHttpQueue = new AppEngineHttpQueue
                    {
                        AppEngineRoutingOverride = new AppEngineRouting
                        {
                            Service = "serviced3f0abaa",
                            Version = "version102ff72a",
                            Instance = "instance99a62371",
                            Host = "hosta8dbb367",
                        },
                    },
                    RateLimits = new RateLimits
                    {
                        MaxDispatchesPerSecond = -1.3413182376911498E+17,
                        MaxBurstSize = -392517653,
                        MaxConcurrentDispatches = 1055474748,
                    },
                    RetryConfig = new RetryConfig
                    {
                        MaxAttempts = 773154519,
                        MaxRetryDuration = new wkt::Duration
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        MinBackoff = new wkt::Duration
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        MaxBackoff = new wkt::Duration
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        MaxDoublings = 118749490,
                    },
                    State = Queue.Types.State.Paused,
                    PurgeTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    TaskTtl = new wkt::Duration
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    TombstoneTtl = new wkt::Duration
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    StackdriverLoggingConfig = new StackdriverLoggingConfig
                    {
                        SamplingRatio = -4.970885912593337E+17,
                    },
                    Type = Queue.Types.Type.Unspecified,
                    Stats = new QueueStats
                    {
                        TasksCount = -599872995928871713L,
                        OldestEstimatedArrivalTime = new wkt::Timestamp
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        ExecutedLastMinuteCount = -6134631481989949557L,
                        ConcurrentDispatchesCount = -2842648588445718402L,
                        EffectiveExecutionRate = -8.535060261327416E+17,
                    },
                },
            };
            Queue expectedResponse = new Queue
            {
                QueueName = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
                AppEngineHttpQueue = new AppEngineHttpQueue
                {
                    AppEngineRoutingOverride = new AppEngineRouting
                    {
                        Service = "serviced3f0abaa",
                        Version = "version102ff72a",
                        Instance = "instance99a62371",
                        Host = "hosta8dbb367",
                    },
                },
                RateLimits = new RateLimits
                {
                    MaxDispatchesPerSecond = -1.3413182376911498E+17,
                    MaxBurstSize = -392517653,
                    MaxConcurrentDispatches = 1055474748,
                },
                RetryConfig = new RetryConfig
                {
                    MaxAttempts = 773154519,
                    MaxRetryDuration = new wkt::Duration
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    MinBackoff = new wkt::Duration
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    MaxBackoff = new wkt::Duration
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    MaxDoublings = 118749490,
                },
                State = Queue.Types.State.Paused,
                PurgeTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                TaskTtl = new wkt::Duration
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                TombstoneTtl = new wkt::Duration
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                StackdriverLoggingConfig = new StackdriverLoggingConfig
                {
                    SamplingRatio = -4.970885912593337E+17,
                },
                Type = Queue.Types.Type.Unspecified,
                Stats = new QueueStats
                {
                    TasksCount = -599872995928871713L,
                    OldestEstimatedArrivalTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    ExecutedLastMinuteCount = -6134631481989949557L,
                    ConcurrentDispatchesCount = -2842648588445718402L,
                    EffectiveExecutionRate = -8.535060261327416E+17,
                },
            };
            mockGrpcClient.Setup(x => x.CreateQueue(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null);
            Queue response = client.CreateQueue(request.ParentAsLocationName, request.Queue);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateQueueResourceNamesAsync()
        {
            moq::Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new moq::Mock<CloudTasks.CloudTasksClient>(moq::MockBehavior.Strict);
            CreateQueueRequest request = new CreateQueueRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Queue = new Queue
                {
                    QueueName = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
                    AppEngineHttpQueue = new AppEngineHttpQueue
                    {
                        AppEngineRoutingOverride = new AppEngineRouting
                        {
                            Service = "serviced3f0abaa",
                            Version = "version102ff72a",
                            Instance = "instance99a62371",
                            Host = "hosta8dbb367",
                        },
                    },
                    RateLimits = new RateLimits
                    {
                        MaxDispatchesPerSecond = -1.3413182376911498E+17,
                        MaxBurstSize = -392517653,
                        MaxConcurrentDispatches = 1055474748,
                    },
                    RetryConfig = new RetryConfig
                    {
                        MaxAttempts = 773154519,
                        MaxRetryDuration = new wkt::Duration
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        MinBackoff = new wkt::Duration
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        MaxBackoff = new wkt::Duration
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        MaxDoublings = 118749490,
                    },
                    State = Queue.Types.State.Paused,
                    PurgeTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    TaskTtl = new wkt::Duration
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    TombstoneTtl = new wkt::Duration
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    StackdriverLoggingConfig = new StackdriverLoggingConfig
                    {
                        SamplingRatio = -4.970885912593337E+17,
                    },
                    Type = Queue.Types.Type.Unspecified,
                    Stats = new QueueStats
                    {
                        TasksCount = -599872995928871713L,
                        OldestEstimatedArrivalTime = new wkt::Timestamp
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        ExecutedLastMinuteCount = -6134631481989949557L,
                        ConcurrentDispatchesCount = -2842648588445718402L,
                        EffectiveExecutionRate = -8.535060261327416E+17,
                    },
                },
            };
            Queue expectedResponse = new Queue
            {
                QueueName = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
                AppEngineHttpQueue = new AppEngineHttpQueue
                {
                    AppEngineRoutingOverride = new AppEngineRouting
                    {
                        Service = "serviced3f0abaa",
                        Version = "version102ff72a",
                        Instance = "instance99a62371",
                        Host = "hosta8dbb367",
                    },
                },
                RateLimits = new RateLimits
                {
                    MaxDispatchesPerSecond = -1.3413182376911498E+17,
                    MaxBurstSize = -392517653,
                    MaxConcurrentDispatches = 1055474748,
                },
                RetryConfig = new RetryConfig
                {
                    MaxAttempts = 773154519,
                    MaxRetryDuration = new wkt::Duration
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    MinBackoff = new wkt::Duration
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    MaxBackoff = new wkt::Duration
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    MaxDoublings = 118749490,
                },
                State = Queue.Types.State.Paused,
                PurgeTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                TaskTtl = new wkt::Duration
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                TombstoneTtl = new wkt::Duration
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                StackdriverLoggingConfig = new StackdriverLoggingConfig
                {
                    SamplingRatio = -4.970885912593337E+17,
                },
                Type = Queue.Types.Type.Unspecified,
                Stats = new QueueStats
                {
                    TasksCount = -599872995928871713L,
                    OldestEstimatedArrivalTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    ExecutedLastMinuteCount = -6134631481989949557L,
                    ConcurrentDispatchesCount = -2842648588445718402L,
                    EffectiveExecutionRate = -8.535060261327416E+17,
                },
            };
            mockGrpcClient.Setup(x => x.CreateQueueAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Queue>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null);
            Queue responseCallSettings = await client.CreateQueueAsync(request.ParentAsLocationName, request.Queue, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Queue responseCancellationToken = await client.CreateQueueAsync(request.ParentAsLocationName, request.Queue, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateQueueRequestObject()
        {
            moq::Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new moq::Mock<CloudTasks.CloudTasksClient>(moq::MockBehavior.Strict);
            UpdateQueueRequest request = new UpdateQueueRequest
            {
                Queue = new Queue
                {
                    QueueName = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
                    AppEngineHttpQueue = new AppEngineHttpQueue
                    {
                        AppEngineRoutingOverride = new AppEngineRouting
                        {
                            Service = "serviced3f0abaa",
                            Version = "version102ff72a",
                            Instance = "instance99a62371",
                            Host = "hosta8dbb367",
                        },
                    },
                    RateLimits = new RateLimits
                    {
                        MaxDispatchesPerSecond = -1.3413182376911498E+17,
                        MaxBurstSize = -392517653,
                        MaxConcurrentDispatches = 1055474748,
                    },
                    RetryConfig = new RetryConfig
                    {
                        MaxAttempts = 773154519,
                        MaxRetryDuration = new wkt::Duration
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        MinBackoff = new wkt::Duration
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        MaxBackoff = new wkt::Duration
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        MaxDoublings = 118749490,
                    },
                    State = Queue.Types.State.Paused,
                    PurgeTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    TaskTtl = new wkt::Duration
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    TombstoneTtl = new wkt::Duration
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    StackdriverLoggingConfig = new StackdriverLoggingConfig
                    {
                        SamplingRatio = -4.970885912593337E+17,
                    },
                    Type = Queue.Types.Type.Unspecified,
                    Stats = new QueueStats
                    {
                        TasksCount = -599872995928871713L,
                        OldestEstimatedArrivalTime = new wkt::Timestamp
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        ExecutedLastMinuteCount = -6134631481989949557L,
                        ConcurrentDispatchesCount = -2842648588445718402L,
                        EffectiveExecutionRate = -8.535060261327416E+17,
                    },
                },
                UpdateMask = new wkt::FieldMask
                {
                    Paths = { "paths012c8713", },
                },
            };
            Queue expectedResponse = new Queue
            {
                QueueName = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
                AppEngineHttpQueue = new AppEngineHttpQueue
                {
                    AppEngineRoutingOverride = new AppEngineRouting
                    {
                        Service = "serviced3f0abaa",
                        Version = "version102ff72a",
                        Instance = "instance99a62371",
                        Host = "hosta8dbb367",
                    },
                },
                RateLimits = new RateLimits
                {
                    MaxDispatchesPerSecond = -1.3413182376911498E+17,
                    MaxBurstSize = -392517653,
                    MaxConcurrentDispatches = 1055474748,
                },
                RetryConfig = new RetryConfig
                {
                    MaxAttempts = 773154519,
                    MaxRetryDuration = new wkt::Duration
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    MinBackoff = new wkt::Duration
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    MaxBackoff = new wkt::Duration
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    MaxDoublings = 118749490,
                },
                State = Queue.Types.State.Paused,
                PurgeTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                TaskTtl = new wkt::Duration
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                TombstoneTtl = new wkt::Duration
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                StackdriverLoggingConfig = new StackdriverLoggingConfig
                {
                    SamplingRatio = -4.970885912593337E+17,
                },
                Type = Queue.Types.Type.Unspecified,
                Stats = new QueueStats
                {
                    TasksCount = -599872995928871713L,
                    OldestEstimatedArrivalTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    ExecutedLastMinuteCount = -6134631481989949557L,
                    ConcurrentDispatchesCount = -2842648588445718402L,
                    EffectiveExecutionRate = -8.535060261327416E+17,
                },
            };
            mockGrpcClient.Setup(x => x.UpdateQueue(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null);
            Queue response = client.UpdateQueue(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateQueueRequestObjectAsync()
        {
            moq::Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new moq::Mock<CloudTasks.CloudTasksClient>(moq::MockBehavior.Strict);
            UpdateQueueRequest request = new UpdateQueueRequest
            {
                Queue = new Queue
                {
                    QueueName = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
                    AppEngineHttpQueue = new AppEngineHttpQueue
                    {
                        AppEngineRoutingOverride = new AppEngineRouting
                        {
                            Service = "serviced3f0abaa",
                            Version = "version102ff72a",
                            Instance = "instance99a62371",
                            Host = "hosta8dbb367",
                        },
                    },
                    RateLimits = new RateLimits
                    {
                        MaxDispatchesPerSecond = -1.3413182376911498E+17,
                        MaxBurstSize = -392517653,
                        MaxConcurrentDispatches = 1055474748,
                    },
                    RetryConfig = new RetryConfig
                    {
                        MaxAttempts = 773154519,
                        MaxRetryDuration = new wkt::Duration
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        MinBackoff = new wkt::Duration
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        MaxBackoff = new wkt::Duration
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        MaxDoublings = 118749490,
                    },
                    State = Queue.Types.State.Paused,
                    PurgeTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    TaskTtl = new wkt::Duration
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    TombstoneTtl = new wkt::Duration
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    StackdriverLoggingConfig = new StackdriverLoggingConfig
                    {
                        SamplingRatio = -4.970885912593337E+17,
                    },
                    Type = Queue.Types.Type.Unspecified,
                    Stats = new QueueStats
                    {
                        TasksCount = -599872995928871713L,
                        OldestEstimatedArrivalTime = new wkt::Timestamp
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        ExecutedLastMinuteCount = -6134631481989949557L,
                        ConcurrentDispatchesCount = -2842648588445718402L,
                        EffectiveExecutionRate = -8.535060261327416E+17,
                    },
                },
                UpdateMask = new wkt::FieldMask
                {
                    Paths = { "paths012c8713", },
                },
            };
            Queue expectedResponse = new Queue
            {
                QueueName = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
                AppEngineHttpQueue = new AppEngineHttpQueue
                {
                    AppEngineRoutingOverride = new AppEngineRouting
                    {
                        Service = "serviced3f0abaa",
                        Version = "version102ff72a",
                        Instance = "instance99a62371",
                        Host = "hosta8dbb367",
                    },
                },
                RateLimits = new RateLimits
                {
                    MaxDispatchesPerSecond = -1.3413182376911498E+17,
                    MaxBurstSize = -392517653,
                    MaxConcurrentDispatches = 1055474748,
                },
                RetryConfig = new RetryConfig
                {
                    MaxAttempts = 773154519,
                    MaxRetryDuration = new wkt::Duration
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    MinBackoff = new wkt::Duration
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    MaxBackoff = new wkt::Duration
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    MaxDoublings = 118749490,
                },
                State = Queue.Types.State.Paused,
                PurgeTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                TaskTtl = new wkt::Duration
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                TombstoneTtl = new wkt::Duration
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                StackdriverLoggingConfig = new StackdriverLoggingConfig
                {
                    SamplingRatio = -4.970885912593337E+17,
                },
                Type = Queue.Types.Type.Unspecified,
                Stats = new QueueStats
                {
                    TasksCount = -599872995928871713L,
                    OldestEstimatedArrivalTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    ExecutedLastMinuteCount = -6134631481989949557L,
                    ConcurrentDispatchesCount = -2842648588445718402L,
                    EffectiveExecutionRate = -8.535060261327416E+17,
                },
            };
            mockGrpcClient.Setup(x => x.UpdateQueueAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Queue>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null);
            Queue responseCallSettings = await client.UpdateQueueAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Queue responseCancellationToken = await client.UpdateQueueAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateQueue()
        {
            moq::Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new moq::Mock<CloudTasks.CloudTasksClient>(moq::MockBehavior.Strict);
            UpdateQueueRequest request = new UpdateQueueRequest
            {
                Queue = new Queue
                {
                    QueueName = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
                    AppEngineHttpQueue = new AppEngineHttpQueue
                    {
                        AppEngineRoutingOverride = new AppEngineRouting
                        {
                            Service = "serviced3f0abaa",
                            Version = "version102ff72a",
                            Instance = "instance99a62371",
                            Host = "hosta8dbb367",
                        },
                    },
                    RateLimits = new RateLimits
                    {
                        MaxDispatchesPerSecond = -1.3413182376911498E+17,
                        MaxBurstSize = -392517653,
                        MaxConcurrentDispatches = 1055474748,
                    },
                    RetryConfig = new RetryConfig
                    {
                        MaxAttempts = 773154519,
                        MaxRetryDuration = new wkt::Duration
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        MinBackoff = new wkt::Duration
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        MaxBackoff = new wkt::Duration
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        MaxDoublings = 118749490,
                    },
                    State = Queue.Types.State.Paused,
                    PurgeTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    TaskTtl = new wkt::Duration
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    TombstoneTtl = new wkt::Duration
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    StackdriverLoggingConfig = new StackdriverLoggingConfig
                    {
                        SamplingRatio = -4.970885912593337E+17,
                    },
                    Type = Queue.Types.Type.Unspecified,
                    Stats = new QueueStats
                    {
                        TasksCount = -599872995928871713L,
                        OldestEstimatedArrivalTime = new wkt::Timestamp
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        ExecutedLastMinuteCount = -6134631481989949557L,
                        ConcurrentDispatchesCount = -2842648588445718402L,
                        EffectiveExecutionRate = -8.535060261327416E+17,
                    },
                },
                UpdateMask = new wkt::FieldMask
                {
                    Paths = { "paths012c8713", },
                },
            };
            Queue expectedResponse = new Queue
            {
                QueueName = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
                AppEngineHttpQueue = new AppEngineHttpQueue
                {
                    AppEngineRoutingOverride = new AppEngineRouting
                    {
                        Service = "serviced3f0abaa",
                        Version = "version102ff72a",
                        Instance = "instance99a62371",
                        Host = "hosta8dbb367",
                    },
                },
                RateLimits = new RateLimits
                {
                    MaxDispatchesPerSecond = -1.3413182376911498E+17,
                    MaxBurstSize = -392517653,
                    MaxConcurrentDispatches = 1055474748,
                },
                RetryConfig = new RetryConfig
                {
                    MaxAttempts = 773154519,
                    MaxRetryDuration = new wkt::Duration
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    MinBackoff = new wkt::Duration
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    MaxBackoff = new wkt::Duration
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    MaxDoublings = 118749490,
                },
                State = Queue.Types.State.Paused,
                PurgeTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                TaskTtl = new wkt::Duration
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                TombstoneTtl = new wkt::Duration
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                StackdriverLoggingConfig = new StackdriverLoggingConfig
                {
                    SamplingRatio = -4.970885912593337E+17,
                },
                Type = Queue.Types.Type.Unspecified,
                Stats = new QueueStats
                {
                    TasksCount = -599872995928871713L,
                    OldestEstimatedArrivalTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    ExecutedLastMinuteCount = -6134631481989949557L,
                    ConcurrentDispatchesCount = -2842648588445718402L,
                    EffectiveExecutionRate = -8.535060261327416E+17,
                },
            };
            mockGrpcClient.Setup(x => x.UpdateQueue(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null);
            Queue response = client.UpdateQueue(request.Queue, request.UpdateMask);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateQueueAsync()
        {
            moq::Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new moq::Mock<CloudTasks.CloudTasksClient>(moq::MockBehavior.Strict);
            UpdateQueueRequest request = new UpdateQueueRequest
            {
                Queue = new Queue
                {
                    QueueName = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
                    AppEngineHttpQueue = new AppEngineHttpQueue
                    {
                        AppEngineRoutingOverride = new AppEngineRouting
                        {
                            Service = "serviced3f0abaa",
                            Version = "version102ff72a",
                            Instance = "instance99a62371",
                            Host = "hosta8dbb367",
                        },
                    },
                    RateLimits = new RateLimits
                    {
                        MaxDispatchesPerSecond = -1.3413182376911498E+17,
                        MaxBurstSize = -392517653,
                        MaxConcurrentDispatches = 1055474748,
                    },
                    RetryConfig = new RetryConfig
                    {
                        MaxAttempts = 773154519,
                        MaxRetryDuration = new wkt::Duration
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        MinBackoff = new wkt::Duration
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        MaxBackoff = new wkt::Duration
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        MaxDoublings = 118749490,
                    },
                    State = Queue.Types.State.Paused,
                    PurgeTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    TaskTtl = new wkt::Duration
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    TombstoneTtl = new wkt::Duration
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    StackdriverLoggingConfig = new StackdriverLoggingConfig
                    {
                        SamplingRatio = -4.970885912593337E+17,
                    },
                    Type = Queue.Types.Type.Unspecified,
                    Stats = new QueueStats
                    {
                        TasksCount = -599872995928871713L,
                        OldestEstimatedArrivalTime = new wkt::Timestamp
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        ExecutedLastMinuteCount = -6134631481989949557L,
                        ConcurrentDispatchesCount = -2842648588445718402L,
                        EffectiveExecutionRate = -8.535060261327416E+17,
                    },
                },
                UpdateMask = new wkt::FieldMask
                {
                    Paths = { "paths012c8713", },
                },
            };
            Queue expectedResponse = new Queue
            {
                QueueName = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
                AppEngineHttpQueue = new AppEngineHttpQueue
                {
                    AppEngineRoutingOverride = new AppEngineRouting
                    {
                        Service = "serviced3f0abaa",
                        Version = "version102ff72a",
                        Instance = "instance99a62371",
                        Host = "hosta8dbb367",
                    },
                },
                RateLimits = new RateLimits
                {
                    MaxDispatchesPerSecond = -1.3413182376911498E+17,
                    MaxBurstSize = -392517653,
                    MaxConcurrentDispatches = 1055474748,
                },
                RetryConfig = new RetryConfig
                {
                    MaxAttempts = 773154519,
                    MaxRetryDuration = new wkt::Duration
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    MinBackoff = new wkt::Duration
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    MaxBackoff = new wkt::Duration
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    MaxDoublings = 118749490,
                },
                State = Queue.Types.State.Paused,
                PurgeTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                TaskTtl = new wkt::Duration
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                TombstoneTtl = new wkt::Duration
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                StackdriverLoggingConfig = new StackdriverLoggingConfig
                {
                    SamplingRatio = -4.970885912593337E+17,
                },
                Type = Queue.Types.Type.Unspecified,
                Stats = new QueueStats
                {
                    TasksCount = -599872995928871713L,
                    OldestEstimatedArrivalTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    ExecutedLastMinuteCount = -6134631481989949557L,
                    ConcurrentDispatchesCount = -2842648588445718402L,
                    EffectiveExecutionRate = -8.535060261327416E+17,
                },
            };
            mockGrpcClient.Setup(x => x.UpdateQueueAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Queue>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null);
            Queue responseCallSettings = await client.UpdateQueueAsync(request.Queue, request.UpdateMask, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Queue responseCancellationToken = await client.UpdateQueueAsync(request.Queue, request.UpdateMask, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteQueueRequestObject()
        {
            moq::Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new moq::Mock<CloudTasks.CloudTasksClient>(moq::MockBehavior.Strict);
            DeleteQueueRequest request = new DeleteQueueRequest
            {
                QueueName = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteQueue(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null);
            client.DeleteQueue(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteQueueRequestObjectAsync()
        {
            moq::Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new moq::Mock<CloudTasks.CloudTasksClient>(moq::MockBehavior.Strict);
            DeleteQueueRequest request = new DeleteQueueRequest
            {
                QueueName = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteQueueAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null);
            await client.DeleteQueueAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteQueueAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteQueue()
        {
            moq::Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new moq::Mock<CloudTasks.CloudTasksClient>(moq::MockBehavior.Strict);
            DeleteQueueRequest request = new DeleteQueueRequest
            {
                QueueName = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteQueue(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null);
            client.DeleteQueue(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteQueueAsync()
        {
            moq::Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new moq::Mock<CloudTasks.CloudTasksClient>(moq::MockBehavior.Strict);
            DeleteQueueRequest request = new DeleteQueueRequest
            {
                QueueName = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteQueueAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null);
            await client.DeleteQueueAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteQueueAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteQueueResourceNames()
        {
            moq::Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new moq::Mock<CloudTasks.CloudTasksClient>(moq::MockBehavior.Strict);
            DeleteQueueRequest request = new DeleteQueueRequest
            {
                QueueName = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteQueue(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null);
            client.DeleteQueue(request.QueueName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteQueueResourceNamesAsync()
        {
            moq::Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new moq::Mock<CloudTasks.CloudTasksClient>(moq::MockBehavior.Strict);
            DeleteQueueRequest request = new DeleteQueueRequest
            {
                QueueName = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteQueueAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null);
            await client.DeleteQueueAsync(request.QueueName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteQueueAsync(request.QueueName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void PurgeQueueRequestObject()
        {
            moq::Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new moq::Mock<CloudTasks.CloudTasksClient>(moq::MockBehavior.Strict);
            PurgeQueueRequest request = new PurgeQueueRequest
            {
                QueueName = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
            };
            Queue expectedResponse = new Queue
            {
                QueueName = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
                AppEngineHttpQueue = new AppEngineHttpQueue
                {
                    AppEngineRoutingOverride = new AppEngineRouting
                    {
                        Service = "serviced3f0abaa",
                        Version = "version102ff72a",
                        Instance = "instance99a62371",
                        Host = "hosta8dbb367",
                    },
                },
                RateLimits = new RateLimits
                {
                    MaxDispatchesPerSecond = -1.3413182376911498E+17,
                    MaxBurstSize = -392517653,
                    MaxConcurrentDispatches = 1055474748,
                },
                RetryConfig = new RetryConfig
                {
                    MaxAttempts = 773154519,
                    MaxRetryDuration = new wkt::Duration
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    MinBackoff = new wkt::Duration
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    MaxBackoff = new wkt::Duration
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    MaxDoublings = 118749490,
                },
                State = Queue.Types.State.Paused,
                PurgeTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                TaskTtl = new wkt::Duration
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                TombstoneTtl = new wkt::Duration
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                StackdriverLoggingConfig = new StackdriverLoggingConfig
                {
                    SamplingRatio = -4.970885912593337E+17,
                },
                Type = Queue.Types.Type.Unspecified,
                Stats = new QueueStats
                {
                    TasksCount = -599872995928871713L,
                    OldestEstimatedArrivalTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    ExecutedLastMinuteCount = -6134631481989949557L,
                    ConcurrentDispatchesCount = -2842648588445718402L,
                    EffectiveExecutionRate = -8.535060261327416E+17,
                },
            };
            mockGrpcClient.Setup(x => x.PurgeQueue(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null);
            Queue response = client.PurgeQueue(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task PurgeQueueRequestObjectAsync()
        {
            moq::Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new moq::Mock<CloudTasks.CloudTasksClient>(moq::MockBehavior.Strict);
            PurgeQueueRequest request = new PurgeQueueRequest
            {
                QueueName = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
            };
            Queue expectedResponse = new Queue
            {
                QueueName = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
                AppEngineHttpQueue = new AppEngineHttpQueue
                {
                    AppEngineRoutingOverride = new AppEngineRouting
                    {
                        Service = "serviced3f0abaa",
                        Version = "version102ff72a",
                        Instance = "instance99a62371",
                        Host = "hosta8dbb367",
                    },
                },
                RateLimits = new RateLimits
                {
                    MaxDispatchesPerSecond = -1.3413182376911498E+17,
                    MaxBurstSize = -392517653,
                    MaxConcurrentDispatches = 1055474748,
                },
                RetryConfig = new RetryConfig
                {
                    MaxAttempts = 773154519,
                    MaxRetryDuration = new wkt::Duration
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    MinBackoff = new wkt::Duration
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    MaxBackoff = new wkt::Duration
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    MaxDoublings = 118749490,
                },
                State = Queue.Types.State.Paused,
                PurgeTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                TaskTtl = new wkt::Duration
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                TombstoneTtl = new wkt::Duration
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                StackdriverLoggingConfig = new StackdriverLoggingConfig
                {
                    SamplingRatio = -4.970885912593337E+17,
                },
                Type = Queue.Types.Type.Unspecified,
                Stats = new QueueStats
                {
                    TasksCount = -599872995928871713L,
                    OldestEstimatedArrivalTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    ExecutedLastMinuteCount = -6134631481989949557L,
                    ConcurrentDispatchesCount = -2842648588445718402L,
                    EffectiveExecutionRate = -8.535060261327416E+17,
                },
            };
            mockGrpcClient.Setup(x => x.PurgeQueueAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Queue>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null);
            Queue responseCallSettings = await client.PurgeQueueAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Queue responseCancellationToken = await client.PurgeQueueAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void PurgeQueue()
        {
            moq::Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new moq::Mock<CloudTasks.CloudTasksClient>(moq::MockBehavior.Strict);
            PurgeQueueRequest request = new PurgeQueueRequest
            {
                QueueName = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
            };
            Queue expectedResponse = new Queue
            {
                QueueName = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
                AppEngineHttpQueue = new AppEngineHttpQueue
                {
                    AppEngineRoutingOverride = new AppEngineRouting
                    {
                        Service = "serviced3f0abaa",
                        Version = "version102ff72a",
                        Instance = "instance99a62371",
                        Host = "hosta8dbb367",
                    },
                },
                RateLimits = new RateLimits
                {
                    MaxDispatchesPerSecond = -1.3413182376911498E+17,
                    MaxBurstSize = -392517653,
                    MaxConcurrentDispatches = 1055474748,
                },
                RetryConfig = new RetryConfig
                {
                    MaxAttempts = 773154519,
                    MaxRetryDuration = new wkt::Duration
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    MinBackoff = new wkt::Duration
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    MaxBackoff = new wkt::Duration
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    MaxDoublings = 118749490,
                },
                State = Queue.Types.State.Paused,
                PurgeTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                TaskTtl = new wkt::Duration
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                TombstoneTtl = new wkt::Duration
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                StackdriverLoggingConfig = new StackdriverLoggingConfig
                {
                    SamplingRatio = -4.970885912593337E+17,
                },
                Type = Queue.Types.Type.Unspecified,
                Stats = new QueueStats
                {
                    TasksCount = -599872995928871713L,
                    OldestEstimatedArrivalTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    ExecutedLastMinuteCount = -6134631481989949557L,
                    ConcurrentDispatchesCount = -2842648588445718402L,
                    EffectiveExecutionRate = -8.535060261327416E+17,
                },
            };
            mockGrpcClient.Setup(x => x.PurgeQueue(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null);
            Queue response = client.PurgeQueue(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task PurgeQueueAsync()
        {
            moq::Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new moq::Mock<CloudTasks.CloudTasksClient>(moq::MockBehavior.Strict);
            PurgeQueueRequest request = new PurgeQueueRequest
            {
                QueueName = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
            };
            Queue expectedResponse = new Queue
            {
                QueueName = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
                AppEngineHttpQueue = new AppEngineHttpQueue
                {
                    AppEngineRoutingOverride = new AppEngineRouting
                    {
                        Service = "serviced3f0abaa",
                        Version = "version102ff72a",
                        Instance = "instance99a62371",
                        Host = "hosta8dbb367",
                    },
                },
                RateLimits = new RateLimits
                {
                    MaxDispatchesPerSecond = -1.3413182376911498E+17,
                    MaxBurstSize = -392517653,
                    MaxConcurrentDispatches = 1055474748,
                },
                RetryConfig = new RetryConfig
                {
                    MaxAttempts = 773154519,
                    MaxRetryDuration = new wkt::Duration
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    MinBackoff = new wkt::Duration
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    MaxBackoff = new wkt::Duration
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    MaxDoublings = 118749490,
                },
                State = Queue.Types.State.Paused,
                PurgeTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                TaskTtl = new wkt::Duration
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                TombstoneTtl = new wkt::Duration
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                StackdriverLoggingConfig = new StackdriverLoggingConfig
                {
                    SamplingRatio = -4.970885912593337E+17,
                },
                Type = Queue.Types.Type.Unspecified,
                Stats = new QueueStats
                {
                    TasksCount = -599872995928871713L,
                    OldestEstimatedArrivalTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    ExecutedLastMinuteCount = -6134631481989949557L,
                    ConcurrentDispatchesCount = -2842648588445718402L,
                    EffectiveExecutionRate = -8.535060261327416E+17,
                },
            };
            mockGrpcClient.Setup(x => x.PurgeQueueAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Queue>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null);
            Queue responseCallSettings = await client.PurgeQueueAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Queue responseCancellationToken = await client.PurgeQueueAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void PurgeQueueResourceNames()
        {
            moq::Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new moq::Mock<CloudTasks.CloudTasksClient>(moq::MockBehavior.Strict);
            PurgeQueueRequest request = new PurgeQueueRequest
            {
                QueueName = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
            };
            Queue expectedResponse = new Queue
            {
                QueueName = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
                AppEngineHttpQueue = new AppEngineHttpQueue
                {
                    AppEngineRoutingOverride = new AppEngineRouting
                    {
                        Service = "serviced3f0abaa",
                        Version = "version102ff72a",
                        Instance = "instance99a62371",
                        Host = "hosta8dbb367",
                    },
                },
                RateLimits = new RateLimits
                {
                    MaxDispatchesPerSecond = -1.3413182376911498E+17,
                    MaxBurstSize = -392517653,
                    MaxConcurrentDispatches = 1055474748,
                },
                RetryConfig = new RetryConfig
                {
                    MaxAttempts = 773154519,
                    MaxRetryDuration = new wkt::Duration
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    MinBackoff = new wkt::Duration
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    MaxBackoff = new wkt::Duration
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    MaxDoublings = 118749490,
                },
                State = Queue.Types.State.Paused,
                PurgeTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                TaskTtl = new wkt::Duration
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                TombstoneTtl = new wkt::Duration
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                StackdriverLoggingConfig = new StackdriverLoggingConfig
                {
                    SamplingRatio = -4.970885912593337E+17,
                },
                Type = Queue.Types.Type.Unspecified,
                Stats = new QueueStats
                {
                    TasksCount = -599872995928871713L,
                    OldestEstimatedArrivalTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    ExecutedLastMinuteCount = -6134631481989949557L,
                    ConcurrentDispatchesCount = -2842648588445718402L,
                    EffectiveExecutionRate = -8.535060261327416E+17,
                },
            };
            mockGrpcClient.Setup(x => x.PurgeQueue(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null);
            Queue response = client.PurgeQueue(request.QueueName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task PurgeQueueResourceNamesAsync()
        {
            moq::Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new moq::Mock<CloudTasks.CloudTasksClient>(moq::MockBehavior.Strict);
            PurgeQueueRequest request = new PurgeQueueRequest
            {
                QueueName = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
            };
            Queue expectedResponse = new Queue
            {
                QueueName = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
                AppEngineHttpQueue = new AppEngineHttpQueue
                {
                    AppEngineRoutingOverride = new AppEngineRouting
                    {
                        Service = "serviced3f0abaa",
                        Version = "version102ff72a",
                        Instance = "instance99a62371",
                        Host = "hosta8dbb367",
                    },
                },
                RateLimits = new RateLimits
                {
                    MaxDispatchesPerSecond = -1.3413182376911498E+17,
                    MaxBurstSize = -392517653,
                    MaxConcurrentDispatches = 1055474748,
                },
                RetryConfig = new RetryConfig
                {
                    MaxAttempts = 773154519,
                    MaxRetryDuration = new wkt::Duration
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    MinBackoff = new wkt::Duration
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    MaxBackoff = new wkt::Duration
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    MaxDoublings = 118749490,
                },
                State = Queue.Types.State.Paused,
                PurgeTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                TaskTtl = new wkt::Duration
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                TombstoneTtl = new wkt::Duration
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                StackdriverLoggingConfig = new StackdriverLoggingConfig
                {
                    SamplingRatio = -4.970885912593337E+17,
                },
                Type = Queue.Types.Type.Unspecified,
                Stats = new QueueStats
                {
                    TasksCount = -599872995928871713L,
                    OldestEstimatedArrivalTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    ExecutedLastMinuteCount = -6134631481989949557L,
                    ConcurrentDispatchesCount = -2842648588445718402L,
                    EffectiveExecutionRate = -8.535060261327416E+17,
                },
            };
            mockGrpcClient.Setup(x => x.PurgeQueueAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Queue>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null);
            Queue responseCallSettings = await client.PurgeQueueAsync(request.QueueName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Queue responseCancellationToken = await client.PurgeQueueAsync(request.QueueName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void PauseQueueRequestObject()
        {
            moq::Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new moq::Mock<CloudTasks.CloudTasksClient>(moq::MockBehavior.Strict);
            PauseQueueRequest request = new PauseQueueRequest
            {
                QueueName = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
            };
            Queue expectedResponse = new Queue
            {
                QueueName = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
                AppEngineHttpQueue = new AppEngineHttpQueue
                {
                    AppEngineRoutingOverride = new AppEngineRouting
                    {
                        Service = "serviced3f0abaa",
                        Version = "version102ff72a",
                        Instance = "instance99a62371",
                        Host = "hosta8dbb367",
                    },
                },
                RateLimits = new RateLimits
                {
                    MaxDispatchesPerSecond = -1.3413182376911498E+17,
                    MaxBurstSize = -392517653,
                    MaxConcurrentDispatches = 1055474748,
                },
                RetryConfig = new RetryConfig
                {
                    MaxAttempts = 773154519,
                    MaxRetryDuration = new wkt::Duration
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    MinBackoff = new wkt::Duration
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    MaxBackoff = new wkt::Duration
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    MaxDoublings = 118749490,
                },
                State = Queue.Types.State.Paused,
                PurgeTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                TaskTtl = new wkt::Duration
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                TombstoneTtl = new wkt::Duration
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                StackdriverLoggingConfig = new StackdriverLoggingConfig
                {
                    SamplingRatio = -4.970885912593337E+17,
                },
                Type = Queue.Types.Type.Unspecified,
                Stats = new QueueStats
                {
                    TasksCount = -599872995928871713L,
                    OldestEstimatedArrivalTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    ExecutedLastMinuteCount = -6134631481989949557L,
                    ConcurrentDispatchesCount = -2842648588445718402L,
                    EffectiveExecutionRate = -8.535060261327416E+17,
                },
            };
            mockGrpcClient.Setup(x => x.PauseQueue(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null);
            Queue response = client.PauseQueue(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task PauseQueueRequestObjectAsync()
        {
            moq::Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new moq::Mock<CloudTasks.CloudTasksClient>(moq::MockBehavior.Strict);
            PauseQueueRequest request = new PauseQueueRequest
            {
                QueueName = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
            };
            Queue expectedResponse = new Queue
            {
                QueueName = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
                AppEngineHttpQueue = new AppEngineHttpQueue
                {
                    AppEngineRoutingOverride = new AppEngineRouting
                    {
                        Service = "serviced3f0abaa",
                        Version = "version102ff72a",
                        Instance = "instance99a62371",
                        Host = "hosta8dbb367",
                    },
                },
                RateLimits = new RateLimits
                {
                    MaxDispatchesPerSecond = -1.3413182376911498E+17,
                    MaxBurstSize = -392517653,
                    MaxConcurrentDispatches = 1055474748,
                },
                RetryConfig = new RetryConfig
                {
                    MaxAttempts = 773154519,
                    MaxRetryDuration = new wkt::Duration
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    MinBackoff = new wkt::Duration
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    MaxBackoff = new wkt::Duration
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    MaxDoublings = 118749490,
                },
                State = Queue.Types.State.Paused,
                PurgeTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                TaskTtl = new wkt::Duration
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                TombstoneTtl = new wkt::Duration
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                StackdriverLoggingConfig = new StackdriverLoggingConfig
                {
                    SamplingRatio = -4.970885912593337E+17,
                },
                Type = Queue.Types.Type.Unspecified,
                Stats = new QueueStats
                {
                    TasksCount = -599872995928871713L,
                    OldestEstimatedArrivalTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    ExecutedLastMinuteCount = -6134631481989949557L,
                    ConcurrentDispatchesCount = -2842648588445718402L,
                    EffectiveExecutionRate = -8.535060261327416E+17,
                },
            };
            mockGrpcClient.Setup(x => x.PauseQueueAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Queue>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null);
            Queue responseCallSettings = await client.PauseQueueAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Queue responseCancellationToken = await client.PauseQueueAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void PauseQueue()
        {
            moq::Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new moq::Mock<CloudTasks.CloudTasksClient>(moq::MockBehavior.Strict);
            PauseQueueRequest request = new PauseQueueRequest
            {
                QueueName = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
            };
            Queue expectedResponse = new Queue
            {
                QueueName = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
                AppEngineHttpQueue = new AppEngineHttpQueue
                {
                    AppEngineRoutingOverride = new AppEngineRouting
                    {
                        Service = "serviced3f0abaa",
                        Version = "version102ff72a",
                        Instance = "instance99a62371",
                        Host = "hosta8dbb367",
                    },
                },
                RateLimits = new RateLimits
                {
                    MaxDispatchesPerSecond = -1.3413182376911498E+17,
                    MaxBurstSize = -392517653,
                    MaxConcurrentDispatches = 1055474748,
                },
                RetryConfig = new RetryConfig
                {
                    MaxAttempts = 773154519,
                    MaxRetryDuration = new wkt::Duration
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    MinBackoff = new wkt::Duration
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    MaxBackoff = new wkt::Duration
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    MaxDoublings = 118749490,
                },
                State = Queue.Types.State.Paused,
                PurgeTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                TaskTtl = new wkt::Duration
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                TombstoneTtl = new wkt::Duration
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                StackdriverLoggingConfig = new StackdriverLoggingConfig
                {
                    SamplingRatio = -4.970885912593337E+17,
                },
                Type = Queue.Types.Type.Unspecified,
                Stats = new QueueStats
                {
                    TasksCount = -599872995928871713L,
                    OldestEstimatedArrivalTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    ExecutedLastMinuteCount = -6134631481989949557L,
                    ConcurrentDispatchesCount = -2842648588445718402L,
                    EffectiveExecutionRate = -8.535060261327416E+17,
                },
            };
            mockGrpcClient.Setup(x => x.PauseQueue(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null);
            Queue response = client.PauseQueue(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task PauseQueueAsync()
        {
            moq::Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new moq::Mock<CloudTasks.CloudTasksClient>(moq::MockBehavior.Strict);
            PauseQueueRequest request = new PauseQueueRequest
            {
                QueueName = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
            };
            Queue expectedResponse = new Queue
            {
                QueueName = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
                AppEngineHttpQueue = new AppEngineHttpQueue
                {
                    AppEngineRoutingOverride = new AppEngineRouting
                    {
                        Service = "serviced3f0abaa",
                        Version = "version102ff72a",
                        Instance = "instance99a62371",
                        Host = "hosta8dbb367",
                    },
                },
                RateLimits = new RateLimits
                {
                    MaxDispatchesPerSecond = -1.3413182376911498E+17,
                    MaxBurstSize = -392517653,
                    MaxConcurrentDispatches = 1055474748,
                },
                RetryConfig = new RetryConfig
                {
                    MaxAttempts = 773154519,
                    MaxRetryDuration = new wkt::Duration
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    MinBackoff = new wkt::Duration
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    MaxBackoff = new wkt::Duration
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    MaxDoublings = 118749490,
                },
                State = Queue.Types.State.Paused,
                PurgeTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                TaskTtl = new wkt::Duration
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                TombstoneTtl = new wkt::Duration
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                StackdriverLoggingConfig = new StackdriverLoggingConfig
                {
                    SamplingRatio = -4.970885912593337E+17,
                },
                Type = Queue.Types.Type.Unspecified,
                Stats = new QueueStats
                {
                    TasksCount = -599872995928871713L,
                    OldestEstimatedArrivalTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    ExecutedLastMinuteCount = -6134631481989949557L,
                    ConcurrentDispatchesCount = -2842648588445718402L,
                    EffectiveExecutionRate = -8.535060261327416E+17,
                },
            };
            mockGrpcClient.Setup(x => x.PauseQueueAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Queue>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null);
            Queue responseCallSettings = await client.PauseQueueAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Queue responseCancellationToken = await client.PauseQueueAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void PauseQueueResourceNames()
        {
            moq::Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new moq::Mock<CloudTasks.CloudTasksClient>(moq::MockBehavior.Strict);
            PauseQueueRequest request = new PauseQueueRequest
            {
                QueueName = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
            };
            Queue expectedResponse = new Queue
            {
                QueueName = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
                AppEngineHttpQueue = new AppEngineHttpQueue
                {
                    AppEngineRoutingOverride = new AppEngineRouting
                    {
                        Service = "serviced3f0abaa",
                        Version = "version102ff72a",
                        Instance = "instance99a62371",
                        Host = "hosta8dbb367",
                    },
                },
                RateLimits = new RateLimits
                {
                    MaxDispatchesPerSecond = -1.3413182376911498E+17,
                    MaxBurstSize = -392517653,
                    MaxConcurrentDispatches = 1055474748,
                },
                RetryConfig = new RetryConfig
                {
                    MaxAttempts = 773154519,
                    MaxRetryDuration = new wkt::Duration
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    MinBackoff = new wkt::Duration
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    MaxBackoff = new wkt::Duration
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    MaxDoublings = 118749490,
                },
                State = Queue.Types.State.Paused,
                PurgeTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                TaskTtl = new wkt::Duration
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                TombstoneTtl = new wkt::Duration
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                StackdriverLoggingConfig = new StackdriverLoggingConfig
                {
                    SamplingRatio = -4.970885912593337E+17,
                },
                Type = Queue.Types.Type.Unspecified,
                Stats = new QueueStats
                {
                    TasksCount = -599872995928871713L,
                    OldestEstimatedArrivalTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    ExecutedLastMinuteCount = -6134631481989949557L,
                    ConcurrentDispatchesCount = -2842648588445718402L,
                    EffectiveExecutionRate = -8.535060261327416E+17,
                },
            };
            mockGrpcClient.Setup(x => x.PauseQueue(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null);
            Queue response = client.PauseQueue(request.QueueName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task PauseQueueResourceNamesAsync()
        {
            moq::Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new moq::Mock<CloudTasks.CloudTasksClient>(moq::MockBehavior.Strict);
            PauseQueueRequest request = new PauseQueueRequest
            {
                QueueName = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
            };
            Queue expectedResponse = new Queue
            {
                QueueName = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
                AppEngineHttpQueue = new AppEngineHttpQueue
                {
                    AppEngineRoutingOverride = new AppEngineRouting
                    {
                        Service = "serviced3f0abaa",
                        Version = "version102ff72a",
                        Instance = "instance99a62371",
                        Host = "hosta8dbb367",
                    },
                },
                RateLimits = new RateLimits
                {
                    MaxDispatchesPerSecond = -1.3413182376911498E+17,
                    MaxBurstSize = -392517653,
                    MaxConcurrentDispatches = 1055474748,
                },
                RetryConfig = new RetryConfig
                {
                    MaxAttempts = 773154519,
                    MaxRetryDuration = new wkt::Duration
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    MinBackoff = new wkt::Duration
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    MaxBackoff = new wkt::Duration
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    MaxDoublings = 118749490,
                },
                State = Queue.Types.State.Paused,
                PurgeTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                TaskTtl = new wkt::Duration
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                TombstoneTtl = new wkt::Duration
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                StackdriverLoggingConfig = new StackdriverLoggingConfig
                {
                    SamplingRatio = -4.970885912593337E+17,
                },
                Type = Queue.Types.Type.Unspecified,
                Stats = new QueueStats
                {
                    TasksCount = -599872995928871713L,
                    OldestEstimatedArrivalTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    ExecutedLastMinuteCount = -6134631481989949557L,
                    ConcurrentDispatchesCount = -2842648588445718402L,
                    EffectiveExecutionRate = -8.535060261327416E+17,
                },
            };
            mockGrpcClient.Setup(x => x.PauseQueueAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Queue>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null);
            Queue responseCallSettings = await client.PauseQueueAsync(request.QueueName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Queue responseCancellationToken = await client.PauseQueueAsync(request.QueueName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ResumeQueueRequestObject()
        {
            moq::Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new moq::Mock<CloudTasks.CloudTasksClient>(moq::MockBehavior.Strict);
            ResumeQueueRequest request = new ResumeQueueRequest
            {
                QueueName = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
            };
            Queue expectedResponse = new Queue
            {
                QueueName = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
                AppEngineHttpQueue = new AppEngineHttpQueue
                {
                    AppEngineRoutingOverride = new AppEngineRouting
                    {
                        Service = "serviced3f0abaa",
                        Version = "version102ff72a",
                        Instance = "instance99a62371",
                        Host = "hosta8dbb367",
                    },
                },
                RateLimits = new RateLimits
                {
                    MaxDispatchesPerSecond = -1.3413182376911498E+17,
                    MaxBurstSize = -392517653,
                    MaxConcurrentDispatches = 1055474748,
                },
                RetryConfig = new RetryConfig
                {
                    MaxAttempts = 773154519,
                    MaxRetryDuration = new wkt::Duration
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    MinBackoff = new wkt::Duration
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    MaxBackoff = new wkt::Duration
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    MaxDoublings = 118749490,
                },
                State = Queue.Types.State.Paused,
                PurgeTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                TaskTtl = new wkt::Duration
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                TombstoneTtl = new wkt::Duration
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                StackdriverLoggingConfig = new StackdriverLoggingConfig
                {
                    SamplingRatio = -4.970885912593337E+17,
                },
                Type = Queue.Types.Type.Unspecified,
                Stats = new QueueStats
                {
                    TasksCount = -599872995928871713L,
                    OldestEstimatedArrivalTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    ExecutedLastMinuteCount = -6134631481989949557L,
                    ConcurrentDispatchesCount = -2842648588445718402L,
                    EffectiveExecutionRate = -8.535060261327416E+17,
                },
            };
            mockGrpcClient.Setup(x => x.ResumeQueue(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null);
            Queue response = client.ResumeQueue(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ResumeQueueRequestObjectAsync()
        {
            moq::Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new moq::Mock<CloudTasks.CloudTasksClient>(moq::MockBehavior.Strict);
            ResumeQueueRequest request = new ResumeQueueRequest
            {
                QueueName = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
            };
            Queue expectedResponse = new Queue
            {
                QueueName = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
                AppEngineHttpQueue = new AppEngineHttpQueue
                {
                    AppEngineRoutingOverride = new AppEngineRouting
                    {
                        Service = "serviced3f0abaa",
                        Version = "version102ff72a",
                        Instance = "instance99a62371",
                        Host = "hosta8dbb367",
                    },
                },
                RateLimits = new RateLimits
                {
                    MaxDispatchesPerSecond = -1.3413182376911498E+17,
                    MaxBurstSize = -392517653,
                    MaxConcurrentDispatches = 1055474748,
                },
                RetryConfig = new RetryConfig
                {
                    MaxAttempts = 773154519,
                    MaxRetryDuration = new wkt::Duration
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    MinBackoff = new wkt::Duration
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    MaxBackoff = new wkt::Duration
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    MaxDoublings = 118749490,
                },
                State = Queue.Types.State.Paused,
                PurgeTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                TaskTtl = new wkt::Duration
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                TombstoneTtl = new wkt::Duration
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                StackdriverLoggingConfig = new StackdriverLoggingConfig
                {
                    SamplingRatio = -4.970885912593337E+17,
                },
                Type = Queue.Types.Type.Unspecified,
                Stats = new QueueStats
                {
                    TasksCount = -599872995928871713L,
                    OldestEstimatedArrivalTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    ExecutedLastMinuteCount = -6134631481989949557L,
                    ConcurrentDispatchesCount = -2842648588445718402L,
                    EffectiveExecutionRate = -8.535060261327416E+17,
                },
            };
            mockGrpcClient.Setup(x => x.ResumeQueueAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Queue>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null);
            Queue responseCallSettings = await client.ResumeQueueAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Queue responseCancellationToken = await client.ResumeQueueAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ResumeQueue()
        {
            moq::Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new moq::Mock<CloudTasks.CloudTasksClient>(moq::MockBehavior.Strict);
            ResumeQueueRequest request = new ResumeQueueRequest
            {
                QueueName = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
            };
            Queue expectedResponse = new Queue
            {
                QueueName = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
                AppEngineHttpQueue = new AppEngineHttpQueue
                {
                    AppEngineRoutingOverride = new AppEngineRouting
                    {
                        Service = "serviced3f0abaa",
                        Version = "version102ff72a",
                        Instance = "instance99a62371",
                        Host = "hosta8dbb367",
                    },
                },
                RateLimits = new RateLimits
                {
                    MaxDispatchesPerSecond = -1.3413182376911498E+17,
                    MaxBurstSize = -392517653,
                    MaxConcurrentDispatches = 1055474748,
                },
                RetryConfig = new RetryConfig
                {
                    MaxAttempts = 773154519,
                    MaxRetryDuration = new wkt::Duration
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    MinBackoff = new wkt::Duration
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    MaxBackoff = new wkt::Duration
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    MaxDoublings = 118749490,
                },
                State = Queue.Types.State.Paused,
                PurgeTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                TaskTtl = new wkt::Duration
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                TombstoneTtl = new wkt::Duration
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                StackdriverLoggingConfig = new StackdriverLoggingConfig
                {
                    SamplingRatio = -4.970885912593337E+17,
                },
                Type = Queue.Types.Type.Unspecified,
                Stats = new QueueStats
                {
                    TasksCount = -599872995928871713L,
                    OldestEstimatedArrivalTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    ExecutedLastMinuteCount = -6134631481989949557L,
                    ConcurrentDispatchesCount = -2842648588445718402L,
                    EffectiveExecutionRate = -8.535060261327416E+17,
                },
            };
            mockGrpcClient.Setup(x => x.ResumeQueue(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null);
            Queue response = client.ResumeQueue(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ResumeQueueAsync()
        {
            moq::Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new moq::Mock<CloudTasks.CloudTasksClient>(moq::MockBehavior.Strict);
            ResumeQueueRequest request = new ResumeQueueRequest
            {
                QueueName = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
            };
            Queue expectedResponse = new Queue
            {
                QueueName = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
                AppEngineHttpQueue = new AppEngineHttpQueue
                {
                    AppEngineRoutingOverride = new AppEngineRouting
                    {
                        Service = "serviced3f0abaa",
                        Version = "version102ff72a",
                        Instance = "instance99a62371",
                        Host = "hosta8dbb367",
                    },
                },
                RateLimits = new RateLimits
                {
                    MaxDispatchesPerSecond = -1.3413182376911498E+17,
                    MaxBurstSize = -392517653,
                    MaxConcurrentDispatches = 1055474748,
                },
                RetryConfig = new RetryConfig
                {
                    MaxAttempts = 773154519,
                    MaxRetryDuration = new wkt::Duration
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    MinBackoff = new wkt::Duration
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    MaxBackoff = new wkt::Duration
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    MaxDoublings = 118749490,
                },
                State = Queue.Types.State.Paused,
                PurgeTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                TaskTtl = new wkt::Duration
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                TombstoneTtl = new wkt::Duration
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                StackdriverLoggingConfig = new StackdriverLoggingConfig
                {
                    SamplingRatio = -4.970885912593337E+17,
                },
                Type = Queue.Types.Type.Unspecified,
                Stats = new QueueStats
                {
                    TasksCount = -599872995928871713L,
                    OldestEstimatedArrivalTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    ExecutedLastMinuteCount = -6134631481989949557L,
                    ConcurrentDispatchesCount = -2842648588445718402L,
                    EffectiveExecutionRate = -8.535060261327416E+17,
                },
            };
            mockGrpcClient.Setup(x => x.ResumeQueueAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Queue>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null);
            Queue responseCallSettings = await client.ResumeQueueAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Queue responseCancellationToken = await client.ResumeQueueAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ResumeQueueResourceNames()
        {
            moq::Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new moq::Mock<CloudTasks.CloudTasksClient>(moq::MockBehavior.Strict);
            ResumeQueueRequest request = new ResumeQueueRequest
            {
                QueueName = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
            };
            Queue expectedResponse = new Queue
            {
                QueueName = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
                AppEngineHttpQueue = new AppEngineHttpQueue
                {
                    AppEngineRoutingOverride = new AppEngineRouting
                    {
                        Service = "serviced3f0abaa",
                        Version = "version102ff72a",
                        Instance = "instance99a62371",
                        Host = "hosta8dbb367",
                    },
                },
                RateLimits = new RateLimits
                {
                    MaxDispatchesPerSecond = -1.3413182376911498E+17,
                    MaxBurstSize = -392517653,
                    MaxConcurrentDispatches = 1055474748,
                },
                RetryConfig = new RetryConfig
                {
                    MaxAttempts = 773154519,
                    MaxRetryDuration = new wkt::Duration
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    MinBackoff = new wkt::Duration
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    MaxBackoff = new wkt::Duration
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    MaxDoublings = 118749490,
                },
                State = Queue.Types.State.Paused,
                PurgeTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                TaskTtl = new wkt::Duration
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                TombstoneTtl = new wkt::Duration
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                StackdriverLoggingConfig = new StackdriverLoggingConfig
                {
                    SamplingRatio = -4.970885912593337E+17,
                },
                Type = Queue.Types.Type.Unspecified,
                Stats = new QueueStats
                {
                    TasksCount = -599872995928871713L,
                    OldestEstimatedArrivalTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    ExecutedLastMinuteCount = -6134631481989949557L,
                    ConcurrentDispatchesCount = -2842648588445718402L,
                    EffectiveExecutionRate = -8.535060261327416E+17,
                },
            };
            mockGrpcClient.Setup(x => x.ResumeQueue(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null);
            Queue response = client.ResumeQueue(request.QueueName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ResumeQueueResourceNamesAsync()
        {
            moq::Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new moq::Mock<CloudTasks.CloudTasksClient>(moq::MockBehavior.Strict);
            ResumeQueueRequest request = new ResumeQueueRequest
            {
                QueueName = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
            };
            Queue expectedResponse = new Queue
            {
                QueueName = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
                AppEngineHttpQueue = new AppEngineHttpQueue
                {
                    AppEngineRoutingOverride = new AppEngineRouting
                    {
                        Service = "serviced3f0abaa",
                        Version = "version102ff72a",
                        Instance = "instance99a62371",
                        Host = "hosta8dbb367",
                    },
                },
                RateLimits = new RateLimits
                {
                    MaxDispatchesPerSecond = -1.3413182376911498E+17,
                    MaxBurstSize = -392517653,
                    MaxConcurrentDispatches = 1055474748,
                },
                RetryConfig = new RetryConfig
                {
                    MaxAttempts = 773154519,
                    MaxRetryDuration = new wkt::Duration
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    MinBackoff = new wkt::Duration
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    MaxBackoff = new wkt::Duration
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    MaxDoublings = 118749490,
                },
                State = Queue.Types.State.Paused,
                PurgeTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                TaskTtl = new wkt::Duration
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                TombstoneTtl = new wkt::Duration
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                StackdriverLoggingConfig = new StackdriverLoggingConfig
                {
                    SamplingRatio = -4.970885912593337E+17,
                },
                Type = Queue.Types.Type.Unspecified,
                Stats = new QueueStats
                {
                    TasksCount = -599872995928871713L,
                    OldestEstimatedArrivalTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    ExecutedLastMinuteCount = -6134631481989949557L,
                    ConcurrentDispatchesCount = -2842648588445718402L,
                    EffectiveExecutionRate = -8.535060261327416E+17,
                },
            };
            mockGrpcClient.Setup(x => x.ResumeQueueAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Queue>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null);
            Queue responseCallSettings = await client.ResumeQueueAsync(request.QueueName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Queue responseCancellationToken = await client.ResumeQueueAsync(request.QueueName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetIamPolicyRequestObject()
        {
            moq::Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new moq::Mock<CloudTasks.CloudTasksClient>(moq::MockBehavior.Strict);
            gciv::GetIamPolicyRequest request = new gciv::GetIamPolicyRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Options = new gciv::GetPolicyOptions
                {
                    RequestedPolicyVersion = -1009868260,
                },
            };
            gciv::Policy expectedResponse = new gciv::Policy
            {
                Version = 271578922,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Bindings =
                {
                    new gciv::Binding
                    {
                        Role = "role64e9a729",
                        Members = { "members3408e3d2", },
                        Condition = new gt::Expr
                        {
                            Expression = "expressiond33c9763",
                            Title = "title17dbd3d5",
                            Description = "description2cf9da67",
                            Location = "locatione09d18d5",
                        },
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetIamPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null);
            gciv::Policy response = client.GetIamPolicy(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetIamPolicyRequestObjectAsync()
        {
            moq::Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new moq::Mock<CloudTasks.CloudTasksClient>(moq::MockBehavior.Strict);
            gciv::GetIamPolicyRequest request = new gciv::GetIamPolicyRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Options = new gciv::GetPolicyOptions
                {
                    RequestedPolicyVersion = -1009868260,
                },
            };
            gciv::Policy expectedResponse = new gciv::Policy
            {
                Version = 271578922,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Bindings =
                {
                    new gciv::Binding
                    {
                        Role = "role64e9a729",
                        Members = { "members3408e3d2", },
                        Condition = new gt::Expr
                        {
                            Expression = "expressiond33c9763",
                            Title = "title17dbd3d5",
                            Description = "description2cf9da67",
                            Location = "locatione09d18d5",
                        },
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetIamPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gciv::Policy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null);
            gciv::Policy responseCallSettings = await client.GetIamPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gciv::Policy responseCancellationToken = await client.GetIamPolicyAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetIamPolicy()
        {
            moq::Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new moq::Mock<CloudTasks.CloudTasksClient>(moq::MockBehavior.Strict);
            gciv::GetIamPolicyRequest request = new gciv::GetIamPolicyRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
            };
            gciv::Policy expectedResponse = new gciv::Policy
            {
                Version = 271578922,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Bindings =
                {
                    new gciv::Binding
                    {
                        Role = "role64e9a729",
                        Members = { "members3408e3d2", },
                        Condition = new gt::Expr
                        {
                            Expression = "expressiond33c9763",
                            Title = "title17dbd3d5",
                            Description = "description2cf9da67",
                            Location = "locatione09d18d5",
                        },
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetIamPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null);
            gciv::Policy response = client.GetIamPolicy(request.Resource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetIamPolicyAsync()
        {
            moq::Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new moq::Mock<CloudTasks.CloudTasksClient>(moq::MockBehavior.Strict);
            gciv::GetIamPolicyRequest request = new gciv::GetIamPolicyRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
            };
            gciv::Policy expectedResponse = new gciv::Policy
            {
                Version = 271578922,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Bindings =
                {
                    new gciv::Binding
                    {
                        Role = "role64e9a729",
                        Members = { "members3408e3d2", },
                        Condition = new gt::Expr
                        {
                            Expression = "expressiond33c9763",
                            Title = "title17dbd3d5",
                            Description = "description2cf9da67",
                            Location = "locatione09d18d5",
                        },
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetIamPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gciv::Policy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null);
            gciv::Policy responseCallSettings = await client.GetIamPolicyAsync(request.Resource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gciv::Policy responseCancellationToken = await client.GetIamPolicyAsync(request.Resource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetIamPolicyResourceNames()
        {
            moq::Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new moq::Mock<CloudTasks.CloudTasksClient>(moq::MockBehavior.Strict);
            gciv::GetIamPolicyRequest request = new gciv::GetIamPolicyRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
            };
            gciv::Policy expectedResponse = new gciv::Policy
            {
                Version = 271578922,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Bindings =
                {
                    new gciv::Binding
                    {
                        Role = "role64e9a729",
                        Members = { "members3408e3d2", },
                        Condition = new gt::Expr
                        {
                            Expression = "expressiond33c9763",
                            Title = "title17dbd3d5",
                            Description = "description2cf9da67",
                            Location = "locatione09d18d5",
                        },
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetIamPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null);
            gciv::Policy response = client.GetIamPolicy(request.ResourceAsResourceName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetIamPolicyResourceNamesAsync()
        {
            moq::Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new moq::Mock<CloudTasks.CloudTasksClient>(moq::MockBehavior.Strict);
            gciv::GetIamPolicyRequest request = new gciv::GetIamPolicyRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
            };
            gciv::Policy expectedResponse = new gciv::Policy
            {
                Version = 271578922,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Bindings =
                {
                    new gciv::Binding
                    {
                        Role = "role64e9a729",
                        Members = { "members3408e3d2", },
                        Condition = new gt::Expr
                        {
                            Expression = "expressiond33c9763",
                            Title = "title17dbd3d5",
                            Description = "description2cf9da67",
                            Location = "locatione09d18d5",
                        },
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetIamPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gciv::Policy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null);
            gciv::Policy responseCallSettings = await client.GetIamPolicyAsync(request.ResourceAsResourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gciv::Policy responseCancellationToken = await client.GetIamPolicyAsync(request.ResourceAsResourceName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SetIamPolicyRequestObject()
        {
            moq::Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new moq::Mock<CloudTasks.CloudTasksClient>(moq::MockBehavior.Strict);
            gciv::SetIamPolicyRequest request = new gciv::SetIamPolicyRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Policy = new gciv::Policy
                {
                    Version = 271578922,
                    Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                    Bindings =
                    {
                        new gciv::Binding
                        {
                            Role = "role64e9a729",
                            Members = { "members3408e3d2", },
                            Condition = new gt::Expr
                            {
                                Expression = "expressiond33c9763",
                                Title = "title17dbd3d5",
                                Description = "description2cf9da67",
                                Location = "locatione09d18d5",
                            },
                        },
                    },
                },
            };
            gciv::Policy expectedResponse = new gciv::Policy
            {
                Version = 271578922,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Bindings =
                {
                    new gciv::Binding
                    {
                        Role = "role64e9a729",
                        Members = { "members3408e3d2", },
                        Condition = new gt::Expr
                        {
                            Expression = "expressiond33c9763",
                            Title = "title17dbd3d5",
                            Description = "description2cf9da67",
                            Location = "locatione09d18d5",
                        },
                    },
                },
            };
            mockGrpcClient.Setup(x => x.SetIamPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null);
            gciv::Policy response = client.SetIamPolicy(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SetIamPolicyRequestObjectAsync()
        {
            moq::Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new moq::Mock<CloudTasks.CloudTasksClient>(moq::MockBehavior.Strict);
            gciv::SetIamPolicyRequest request = new gciv::SetIamPolicyRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Policy = new gciv::Policy
                {
                    Version = 271578922,
                    Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                    Bindings =
                    {
                        new gciv::Binding
                        {
                            Role = "role64e9a729",
                            Members = { "members3408e3d2", },
                            Condition = new gt::Expr
                            {
                                Expression = "expressiond33c9763",
                                Title = "title17dbd3d5",
                                Description = "description2cf9da67",
                                Location = "locatione09d18d5",
                            },
                        },
                    },
                },
            };
            gciv::Policy expectedResponse = new gciv::Policy
            {
                Version = 271578922,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Bindings =
                {
                    new gciv::Binding
                    {
                        Role = "role64e9a729",
                        Members = { "members3408e3d2", },
                        Condition = new gt::Expr
                        {
                            Expression = "expressiond33c9763",
                            Title = "title17dbd3d5",
                            Description = "description2cf9da67",
                            Location = "locatione09d18d5",
                        },
                    },
                },
            };
            mockGrpcClient.Setup(x => x.SetIamPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gciv::Policy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null);
            gciv::Policy responseCallSettings = await client.SetIamPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gciv::Policy responseCancellationToken = await client.SetIamPolicyAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SetIamPolicy()
        {
            moq::Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new moq::Mock<CloudTasks.CloudTasksClient>(moq::MockBehavior.Strict);
            gciv::SetIamPolicyRequest request = new gciv::SetIamPolicyRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Policy = new gciv::Policy
                {
                    Version = 271578922,
                    Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                    Bindings =
                    {
                        new gciv::Binding
                        {
                            Role = "role64e9a729",
                            Members = { "members3408e3d2", },
                            Condition = new gt::Expr
                            {
                                Expression = "expressiond33c9763",
                                Title = "title17dbd3d5",
                                Description = "description2cf9da67",
                                Location = "locatione09d18d5",
                            },
                        },
                    },
                },
            };
            gciv::Policy expectedResponse = new gciv::Policy
            {
                Version = 271578922,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Bindings =
                {
                    new gciv::Binding
                    {
                        Role = "role64e9a729",
                        Members = { "members3408e3d2", },
                        Condition = new gt::Expr
                        {
                            Expression = "expressiond33c9763",
                            Title = "title17dbd3d5",
                            Description = "description2cf9da67",
                            Location = "locatione09d18d5",
                        },
                    },
                },
            };
            mockGrpcClient.Setup(x => x.SetIamPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null);
            gciv::Policy response = client.SetIamPolicy(request.Resource, request.Policy);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SetIamPolicyAsync()
        {
            moq::Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new moq::Mock<CloudTasks.CloudTasksClient>(moq::MockBehavior.Strict);
            gciv::SetIamPolicyRequest request = new gciv::SetIamPolicyRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Policy = new gciv::Policy
                {
                    Version = 271578922,
                    Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                    Bindings =
                    {
                        new gciv::Binding
                        {
                            Role = "role64e9a729",
                            Members = { "members3408e3d2", },
                            Condition = new gt::Expr
                            {
                                Expression = "expressiond33c9763",
                                Title = "title17dbd3d5",
                                Description = "description2cf9da67",
                                Location = "locatione09d18d5",
                            },
                        },
                    },
                },
            };
            gciv::Policy expectedResponse = new gciv::Policy
            {
                Version = 271578922,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Bindings =
                {
                    new gciv::Binding
                    {
                        Role = "role64e9a729",
                        Members = { "members3408e3d2", },
                        Condition = new gt::Expr
                        {
                            Expression = "expressiond33c9763",
                            Title = "title17dbd3d5",
                            Description = "description2cf9da67",
                            Location = "locatione09d18d5",
                        },
                    },
                },
            };
            mockGrpcClient.Setup(x => x.SetIamPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gciv::Policy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null);
            gciv::Policy responseCallSettings = await client.SetIamPolicyAsync(request.Resource, request.Policy, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gciv::Policy responseCancellationToken = await client.SetIamPolicyAsync(request.Resource, request.Policy, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SetIamPolicyResourceNames()
        {
            moq::Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new moq::Mock<CloudTasks.CloudTasksClient>(moq::MockBehavior.Strict);
            gciv::SetIamPolicyRequest request = new gciv::SetIamPolicyRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Policy = new gciv::Policy
                {
                    Version = 271578922,
                    Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                    Bindings =
                    {
                        new gciv::Binding
                        {
                            Role = "role64e9a729",
                            Members = { "members3408e3d2", },
                            Condition = new gt::Expr
                            {
                                Expression = "expressiond33c9763",
                                Title = "title17dbd3d5",
                                Description = "description2cf9da67",
                                Location = "locatione09d18d5",
                            },
                        },
                    },
                },
            };
            gciv::Policy expectedResponse = new gciv::Policy
            {
                Version = 271578922,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Bindings =
                {
                    new gciv::Binding
                    {
                        Role = "role64e9a729",
                        Members = { "members3408e3d2", },
                        Condition = new gt::Expr
                        {
                            Expression = "expressiond33c9763",
                            Title = "title17dbd3d5",
                            Description = "description2cf9da67",
                            Location = "locatione09d18d5",
                        },
                    },
                },
            };
            mockGrpcClient.Setup(x => x.SetIamPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null);
            gciv::Policy response = client.SetIamPolicy(request.ResourceAsResourceName, request.Policy);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SetIamPolicyResourceNamesAsync()
        {
            moq::Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new moq::Mock<CloudTasks.CloudTasksClient>(moq::MockBehavior.Strict);
            gciv::SetIamPolicyRequest request = new gciv::SetIamPolicyRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Policy = new gciv::Policy
                {
                    Version = 271578922,
                    Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                    Bindings =
                    {
                        new gciv::Binding
                        {
                            Role = "role64e9a729",
                            Members = { "members3408e3d2", },
                            Condition = new gt::Expr
                            {
                                Expression = "expressiond33c9763",
                                Title = "title17dbd3d5",
                                Description = "description2cf9da67",
                                Location = "locatione09d18d5",
                            },
                        },
                    },
                },
            };
            gciv::Policy expectedResponse = new gciv::Policy
            {
                Version = 271578922,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Bindings =
                {
                    new gciv::Binding
                    {
                        Role = "role64e9a729",
                        Members = { "members3408e3d2", },
                        Condition = new gt::Expr
                        {
                            Expression = "expressiond33c9763",
                            Title = "title17dbd3d5",
                            Description = "description2cf9da67",
                            Location = "locatione09d18d5",
                        },
                    },
                },
            };
            mockGrpcClient.Setup(x => x.SetIamPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gciv::Policy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null);
            gciv::Policy responseCallSettings = await client.SetIamPolicyAsync(request.ResourceAsResourceName, request.Policy, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gciv::Policy responseCancellationToken = await client.SetIamPolicyAsync(request.ResourceAsResourceName, request.Policy, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void TestIamPermissionsRequestObject()
        {
            moq::Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new moq::Mock<CloudTasks.CloudTasksClient>(moq::MockBehavior.Strict);
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
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null);
            gciv::TestIamPermissionsResponse response = client.TestIamPermissions(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task TestIamPermissionsRequestObjectAsync()
        {
            moq::Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new moq::Mock<CloudTasks.CloudTasksClient>(moq::MockBehavior.Strict);
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
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null);
            gciv::TestIamPermissionsResponse responseCallSettings = await client.TestIamPermissionsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gciv::TestIamPermissionsResponse responseCancellationToken = await client.TestIamPermissionsAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void TestIamPermissions()
        {
            moq::Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new moq::Mock<CloudTasks.CloudTasksClient>(moq::MockBehavior.Strict);
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
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null);
            gciv::TestIamPermissionsResponse response = client.TestIamPermissions(request.Resource, request.Permissions);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task TestIamPermissionsAsync()
        {
            moq::Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new moq::Mock<CloudTasks.CloudTasksClient>(moq::MockBehavior.Strict);
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
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null);
            gciv::TestIamPermissionsResponse responseCallSettings = await client.TestIamPermissionsAsync(request.Resource, request.Permissions, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gciv::TestIamPermissionsResponse responseCancellationToken = await client.TestIamPermissionsAsync(request.Resource, request.Permissions, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void TestIamPermissionsResourceNames()
        {
            moq::Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new moq::Mock<CloudTasks.CloudTasksClient>(moq::MockBehavior.Strict);
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
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null);
            gciv::TestIamPermissionsResponse response = client.TestIamPermissions(request.ResourceAsResourceName, request.Permissions);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task TestIamPermissionsResourceNamesAsync()
        {
            moq::Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new moq::Mock<CloudTasks.CloudTasksClient>(moq::MockBehavior.Strict);
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
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null);
            gciv::TestIamPermissionsResponse responseCallSettings = await client.TestIamPermissionsAsync(request.ResourceAsResourceName, request.Permissions, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gciv::TestIamPermissionsResponse responseCancellationToken = await client.TestIamPermissionsAsync(request.ResourceAsResourceName, request.Permissions, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetTaskRequestObject()
        {
            moq::Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new moq::Mock<CloudTasks.CloudTasksClient>(moq::MockBehavior.Strict);
            GetTaskRequest request = new GetTaskRequest
            {
                TaskName = TaskName.FromProjectLocationQueueTask("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]"),
                ResponseView = Task.Types.View.Basic,
            };
            Task expectedResponse = new Task
            {
                TaskName = TaskName.FromProjectLocationQueueTask("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]"),
                AppEngineHttpRequest = new AppEngineHttpRequest
                {
                    HttpMethod = HttpMethod.Put,
                    AppEngineRouting = new AppEngineRouting
                    {
                        Service = "serviced3f0abaa",
                        Version = "version102ff72a",
                        Instance = "instance99a62371",
                        Host = "hosta8dbb367",
                    },
                    RelativeUri = "relative_uri4e468832",
                    Headers =
                    {
                        {
                            "key8a0b6e3c",
                            "value60c16320"
                        },
                    },
                    Body = proto::ByteString.CopyFromUtf8("body682d1a84"),
                },
                ScheduleTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                CreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                DispatchCount = 341017545,
                ResponseCount = -1236920575,
                FirstAttempt = new Attempt
                {
                    ScheduleTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    DispatchTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    ResponseTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    ResponseStatus = new gr::Status
                    {
                        Code = -1805175871,
                        Message = "message0231e778",
                        Details =
                        {
                            new wkt::Any
                            {
                                TypeUrl = "type_urlfde5623b",
                                Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                            },
                        },
                    },
                },
                LastAttempt = new Attempt
                {
                    ScheduleTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    DispatchTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    ResponseTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    ResponseStatus = new gr::Status
                    {
                        Code = -1805175871,
                        Message = "message0231e778",
                        Details =
                        {
                            new wkt::Any
                            {
                                TypeUrl = "type_urlfde5623b",
                                Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                            },
                        },
                    },
                },
                View = Task.Types.View.Basic,
                HttpRequest = new HttpRequest
                {
                    Url = "url424e2d57",
                    HttpMethod = HttpMethod.Put,
                    Headers =
                    {
                        {
                            "key8a0b6e3c",
                            "value60c16320"
                        },
                    },
                    Body = proto::ByteString.CopyFromUtf8("body682d1a84"),
                    OauthToken = new OAuthToken
                    {
                        ServiceAccountEmail = "service_account_emailb0c3703d",
                        Scope = "scope14fda131",
                    },
                    OidcToken = new OidcToken
                    {
                        ServiceAccountEmail = "service_account_emailb0c3703d",
                        Audience = "audience986f1fe3",
                    },
                },
                DispatchDeadline = new wkt::Duration
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                PullMessage = new PullMessage
                {
                    Payload = proto::ByteString.CopyFromUtf8("payloadf43c1c32"),
                    Tag = "tag843ed2e4",
                },
            };
            mockGrpcClient.Setup(x => x.GetTask(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null);
            Task response = client.GetTask(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetTaskRequestObjectAsync()
        {
            moq::Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new moq::Mock<CloudTasks.CloudTasksClient>(moq::MockBehavior.Strict);
            GetTaskRequest request = new GetTaskRequest
            {
                TaskName = TaskName.FromProjectLocationQueueTask("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]"),
                ResponseView = Task.Types.View.Basic,
            };
            Task expectedResponse = new Task
            {
                TaskName = TaskName.FromProjectLocationQueueTask("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]"),
                AppEngineHttpRequest = new AppEngineHttpRequest
                {
                    HttpMethod = HttpMethod.Put,
                    AppEngineRouting = new AppEngineRouting
                    {
                        Service = "serviced3f0abaa",
                        Version = "version102ff72a",
                        Instance = "instance99a62371",
                        Host = "hosta8dbb367",
                    },
                    RelativeUri = "relative_uri4e468832",
                    Headers =
                    {
                        {
                            "key8a0b6e3c",
                            "value60c16320"
                        },
                    },
                    Body = proto::ByteString.CopyFromUtf8("body682d1a84"),
                },
                ScheduleTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                CreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                DispatchCount = 341017545,
                ResponseCount = -1236920575,
                FirstAttempt = new Attempt
                {
                    ScheduleTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    DispatchTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    ResponseTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    ResponseStatus = new gr::Status
                    {
                        Code = -1805175871,
                        Message = "message0231e778",
                        Details =
                        {
                            new wkt::Any
                            {
                                TypeUrl = "type_urlfde5623b",
                                Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                            },
                        },
                    },
                },
                LastAttempt = new Attempt
                {
                    ScheduleTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    DispatchTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    ResponseTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    ResponseStatus = new gr::Status
                    {
                        Code = -1805175871,
                        Message = "message0231e778",
                        Details =
                        {
                            new wkt::Any
                            {
                                TypeUrl = "type_urlfde5623b",
                                Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                            },
                        },
                    },
                },
                View = Task.Types.View.Basic,
                HttpRequest = new HttpRequest
                {
                    Url = "url424e2d57",
                    HttpMethod = HttpMethod.Put,
                    Headers =
                    {
                        {
                            "key8a0b6e3c",
                            "value60c16320"
                        },
                    },
                    Body = proto::ByteString.CopyFromUtf8("body682d1a84"),
                    OauthToken = new OAuthToken
                    {
                        ServiceAccountEmail = "service_account_emailb0c3703d",
                        Scope = "scope14fda131",
                    },
                    OidcToken = new OidcToken
                    {
                        ServiceAccountEmail = "service_account_emailb0c3703d",
                        Audience = "audience986f1fe3",
                    },
                },
                DispatchDeadline = new wkt::Duration
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                PullMessage = new PullMessage
                {
                    Payload = proto::ByteString.CopyFromUtf8("payloadf43c1c32"),
                    Tag = "tag843ed2e4",
                },
            };
            mockGrpcClient.Setup(x => x.GetTaskAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Task>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null);
            Task responseCallSettings = await client.GetTaskAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Task responseCancellationToken = await client.GetTaskAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetTask()
        {
            moq::Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new moq::Mock<CloudTasks.CloudTasksClient>(moq::MockBehavior.Strict);
            GetTaskRequest request = new GetTaskRequest
            {
                TaskName = TaskName.FromProjectLocationQueueTask("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]"),
            };
            Task expectedResponse = new Task
            {
                TaskName = TaskName.FromProjectLocationQueueTask("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]"),
                AppEngineHttpRequest = new AppEngineHttpRequest
                {
                    HttpMethod = HttpMethod.Put,
                    AppEngineRouting = new AppEngineRouting
                    {
                        Service = "serviced3f0abaa",
                        Version = "version102ff72a",
                        Instance = "instance99a62371",
                        Host = "hosta8dbb367",
                    },
                    RelativeUri = "relative_uri4e468832",
                    Headers =
                    {
                        {
                            "key8a0b6e3c",
                            "value60c16320"
                        },
                    },
                    Body = proto::ByteString.CopyFromUtf8("body682d1a84"),
                },
                ScheduleTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                CreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                DispatchCount = 341017545,
                ResponseCount = -1236920575,
                FirstAttempt = new Attempt
                {
                    ScheduleTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    DispatchTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    ResponseTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    ResponseStatus = new gr::Status
                    {
                        Code = -1805175871,
                        Message = "message0231e778",
                        Details =
                        {
                            new wkt::Any
                            {
                                TypeUrl = "type_urlfde5623b",
                                Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                            },
                        },
                    },
                },
                LastAttempt = new Attempt
                {
                    ScheduleTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    DispatchTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    ResponseTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    ResponseStatus = new gr::Status
                    {
                        Code = -1805175871,
                        Message = "message0231e778",
                        Details =
                        {
                            new wkt::Any
                            {
                                TypeUrl = "type_urlfde5623b",
                                Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                            },
                        },
                    },
                },
                View = Task.Types.View.Basic,
                HttpRequest = new HttpRequest
                {
                    Url = "url424e2d57",
                    HttpMethod = HttpMethod.Put,
                    Headers =
                    {
                        {
                            "key8a0b6e3c",
                            "value60c16320"
                        },
                    },
                    Body = proto::ByteString.CopyFromUtf8("body682d1a84"),
                    OauthToken = new OAuthToken
                    {
                        ServiceAccountEmail = "service_account_emailb0c3703d",
                        Scope = "scope14fda131",
                    },
                    OidcToken = new OidcToken
                    {
                        ServiceAccountEmail = "service_account_emailb0c3703d",
                        Audience = "audience986f1fe3",
                    },
                },
                DispatchDeadline = new wkt::Duration
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                PullMessage = new PullMessage
                {
                    Payload = proto::ByteString.CopyFromUtf8("payloadf43c1c32"),
                    Tag = "tag843ed2e4",
                },
            };
            mockGrpcClient.Setup(x => x.GetTask(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null);
            Task response = client.GetTask(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetTaskAsync()
        {
            moq::Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new moq::Mock<CloudTasks.CloudTasksClient>(moq::MockBehavior.Strict);
            GetTaskRequest request = new GetTaskRequest
            {
                TaskName = TaskName.FromProjectLocationQueueTask("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]"),
            };
            Task expectedResponse = new Task
            {
                TaskName = TaskName.FromProjectLocationQueueTask("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]"),
                AppEngineHttpRequest = new AppEngineHttpRequest
                {
                    HttpMethod = HttpMethod.Put,
                    AppEngineRouting = new AppEngineRouting
                    {
                        Service = "serviced3f0abaa",
                        Version = "version102ff72a",
                        Instance = "instance99a62371",
                        Host = "hosta8dbb367",
                    },
                    RelativeUri = "relative_uri4e468832",
                    Headers =
                    {
                        {
                            "key8a0b6e3c",
                            "value60c16320"
                        },
                    },
                    Body = proto::ByteString.CopyFromUtf8("body682d1a84"),
                },
                ScheduleTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                CreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                DispatchCount = 341017545,
                ResponseCount = -1236920575,
                FirstAttempt = new Attempt
                {
                    ScheduleTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    DispatchTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    ResponseTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    ResponseStatus = new gr::Status
                    {
                        Code = -1805175871,
                        Message = "message0231e778",
                        Details =
                        {
                            new wkt::Any
                            {
                                TypeUrl = "type_urlfde5623b",
                                Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                            },
                        },
                    },
                },
                LastAttempt = new Attempt
                {
                    ScheduleTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    DispatchTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    ResponseTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    ResponseStatus = new gr::Status
                    {
                        Code = -1805175871,
                        Message = "message0231e778",
                        Details =
                        {
                            new wkt::Any
                            {
                                TypeUrl = "type_urlfde5623b",
                                Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                            },
                        },
                    },
                },
                View = Task.Types.View.Basic,
                HttpRequest = new HttpRequest
                {
                    Url = "url424e2d57",
                    HttpMethod = HttpMethod.Put,
                    Headers =
                    {
                        {
                            "key8a0b6e3c",
                            "value60c16320"
                        },
                    },
                    Body = proto::ByteString.CopyFromUtf8("body682d1a84"),
                    OauthToken = new OAuthToken
                    {
                        ServiceAccountEmail = "service_account_emailb0c3703d",
                        Scope = "scope14fda131",
                    },
                    OidcToken = new OidcToken
                    {
                        ServiceAccountEmail = "service_account_emailb0c3703d",
                        Audience = "audience986f1fe3",
                    },
                },
                DispatchDeadline = new wkt::Duration
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                PullMessage = new PullMessage
                {
                    Payload = proto::ByteString.CopyFromUtf8("payloadf43c1c32"),
                    Tag = "tag843ed2e4",
                },
            };
            mockGrpcClient.Setup(x => x.GetTaskAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Task>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null);
            Task responseCallSettings = await client.GetTaskAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Task responseCancellationToken = await client.GetTaskAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetTaskResourceNames()
        {
            moq::Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new moq::Mock<CloudTasks.CloudTasksClient>(moq::MockBehavior.Strict);
            GetTaskRequest request = new GetTaskRequest
            {
                TaskName = TaskName.FromProjectLocationQueueTask("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]"),
            };
            Task expectedResponse = new Task
            {
                TaskName = TaskName.FromProjectLocationQueueTask("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]"),
                AppEngineHttpRequest = new AppEngineHttpRequest
                {
                    HttpMethod = HttpMethod.Put,
                    AppEngineRouting = new AppEngineRouting
                    {
                        Service = "serviced3f0abaa",
                        Version = "version102ff72a",
                        Instance = "instance99a62371",
                        Host = "hosta8dbb367",
                    },
                    RelativeUri = "relative_uri4e468832",
                    Headers =
                    {
                        {
                            "key8a0b6e3c",
                            "value60c16320"
                        },
                    },
                    Body = proto::ByteString.CopyFromUtf8("body682d1a84"),
                },
                ScheduleTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                CreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                DispatchCount = 341017545,
                ResponseCount = -1236920575,
                FirstAttempt = new Attempt
                {
                    ScheduleTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    DispatchTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    ResponseTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    ResponseStatus = new gr::Status
                    {
                        Code = -1805175871,
                        Message = "message0231e778",
                        Details =
                        {
                            new wkt::Any
                            {
                                TypeUrl = "type_urlfde5623b",
                                Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                            },
                        },
                    },
                },
                LastAttempt = new Attempt
                {
                    ScheduleTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    DispatchTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    ResponseTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    ResponseStatus = new gr::Status
                    {
                        Code = -1805175871,
                        Message = "message0231e778",
                        Details =
                        {
                            new wkt::Any
                            {
                                TypeUrl = "type_urlfde5623b",
                                Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                            },
                        },
                    },
                },
                View = Task.Types.View.Basic,
                HttpRequest = new HttpRequest
                {
                    Url = "url424e2d57",
                    HttpMethod = HttpMethod.Put,
                    Headers =
                    {
                        {
                            "key8a0b6e3c",
                            "value60c16320"
                        },
                    },
                    Body = proto::ByteString.CopyFromUtf8("body682d1a84"),
                    OauthToken = new OAuthToken
                    {
                        ServiceAccountEmail = "service_account_emailb0c3703d",
                        Scope = "scope14fda131",
                    },
                    OidcToken = new OidcToken
                    {
                        ServiceAccountEmail = "service_account_emailb0c3703d",
                        Audience = "audience986f1fe3",
                    },
                },
                DispatchDeadline = new wkt::Duration
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                PullMessage = new PullMessage
                {
                    Payload = proto::ByteString.CopyFromUtf8("payloadf43c1c32"),
                    Tag = "tag843ed2e4",
                },
            };
            mockGrpcClient.Setup(x => x.GetTask(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null);
            Task response = client.GetTask(request.TaskName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetTaskResourceNamesAsync()
        {
            moq::Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new moq::Mock<CloudTasks.CloudTasksClient>(moq::MockBehavior.Strict);
            GetTaskRequest request = new GetTaskRequest
            {
                TaskName = TaskName.FromProjectLocationQueueTask("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]"),
            };
            Task expectedResponse = new Task
            {
                TaskName = TaskName.FromProjectLocationQueueTask("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]"),
                AppEngineHttpRequest = new AppEngineHttpRequest
                {
                    HttpMethod = HttpMethod.Put,
                    AppEngineRouting = new AppEngineRouting
                    {
                        Service = "serviced3f0abaa",
                        Version = "version102ff72a",
                        Instance = "instance99a62371",
                        Host = "hosta8dbb367",
                    },
                    RelativeUri = "relative_uri4e468832",
                    Headers =
                    {
                        {
                            "key8a0b6e3c",
                            "value60c16320"
                        },
                    },
                    Body = proto::ByteString.CopyFromUtf8("body682d1a84"),
                },
                ScheduleTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                CreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                DispatchCount = 341017545,
                ResponseCount = -1236920575,
                FirstAttempt = new Attempt
                {
                    ScheduleTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    DispatchTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    ResponseTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    ResponseStatus = new gr::Status
                    {
                        Code = -1805175871,
                        Message = "message0231e778",
                        Details =
                        {
                            new wkt::Any
                            {
                                TypeUrl = "type_urlfde5623b",
                                Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                            },
                        },
                    },
                },
                LastAttempt = new Attempt
                {
                    ScheduleTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    DispatchTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    ResponseTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    ResponseStatus = new gr::Status
                    {
                        Code = -1805175871,
                        Message = "message0231e778",
                        Details =
                        {
                            new wkt::Any
                            {
                                TypeUrl = "type_urlfde5623b",
                                Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                            },
                        },
                    },
                },
                View = Task.Types.View.Basic,
                HttpRequest = new HttpRequest
                {
                    Url = "url424e2d57",
                    HttpMethod = HttpMethod.Put,
                    Headers =
                    {
                        {
                            "key8a0b6e3c",
                            "value60c16320"
                        },
                    },
                    Body = proto::ByteString.CopyFromUtf8("body682d1a84"),
                    OauthToken = new OAuthToken
                    {
                        ServiceAccountEmail = "service_account_emailb0c3703d",
                        Scope = "scope14fda131",
                    },
                    OidcToken = new OidcToken
                    {
                        ServiceAccountEmail = "service_account_emailb0c3703d",
                        Audience = "audience986f1fe3",
                    },
                },
                DispatchDeadline = new wkt::Duration
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                PullMessage = new PullMessage
                {
                    Payload = proto::ByteString.CopyFromUtf8("payloadf43c1c32"),
                    Tag = "tag843ed2e4",
                },
            };
            mockGrpcClient.Setup(x => x.GetTaskAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Task>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null);
            Task responseCallSettings = await client.GetTaskAsync(request.TaskName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Task responseCancellationToken = await client.GetTaskAsync(request.TaskName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateTaskRequestObject()
        {
            moq::Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new moq::Mock<CloudTasks.CloudTasksClient>(moq::MockBehavior.Strict);
            CreateTaskRequest request = new CreateTaskRequest
            {
                ParentAsQueueName = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
                Task = new Task
                {
                    TaskName = TaskName.FromProjectLocationQueueTask("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]"),
                    AppEngineHttpRequest = new AppEngineHttpRequest
                    {
                        HttpMethod = HttpMethod.Put,
                        AppEngineRouting = new AppEngineRouting
                        {
                            Service = "serviced3f0abaa",
                            Version = "version102ff72a",
                            Instance = "instance99a62371",
                            Host = "hosta8dbb367",
                        },
                        RelativeUri = "relative_uri4e468832",
                        Headers =
                        {
                            {
                                "key8a0b6e3c",
                                "value60c16320"
                            },
                        },
                        Body = proto::ByteString.CopyFromUtf8("body682d1a84"),
                    },
                    ScheduleTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    CreateTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    DispatchCount = 341017545,
                    ResponseCount = -1236920575,
                    FirstAttempt = new Attempt
                    {
                        ScheduleTime = new wkt::Timestamp
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        DispatchTime = new wkt::Timestamp
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        ResponseTime = new wkt::Timestamp
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        ResponseStatus = new gr::Status
                        {
                            Code = -1805175871,
                            Message = "message0231e778",
                            Details =
                            {
                                new wkt::Any
                                {
                                    TypeUrl = "type_urlfde5623b",
                                    Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                },
                            },
                        },
                    },
                    LastAttempt = new Attempt
                    {
                        ScheduleTime = new wkt::Timestamp
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        DispatchTime = new wkt::Timestamp
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        ResponseTime = new wkt::Timestamp
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        ResponseStatus = new gr::Status
                        {
                            Code = -1805175871,
                            Message = "message0231e778",
                            Details =
                            {
                                new wkt::Any
                                {
                                    TypeUrl = "type_urlfde5623b",
                                    Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                },
                            },
                        },
                    },
                    View = Task.Types.View.Basic,
                    HttpRequest = new HttpRequest
                    {
                        Url = "url424e2d57",
                        HttpMethod = HttpMethod.Put,
                        Headers =
                        {
                            {
                                "key8a0b6e3c",
                                "value60c16320"
                            },
                        },
                        Body = proto::ByteString.CopyFromUtf8("body682d1a84"),
                        OauthToken = new OAuthToken
                        {
                            ServiceAccountEmail = "service_account_emailb0c3703d",
                            Scope = "scope14fda131",
                        },
                        OidcToken = new OidcToken
                        {
                            ServiceAccountEmail = "service_account_emailb0c3703d",
                            Audience = "audience986f1fe3",
                        },
                    },
                    DispatchDeadline = new wkt::Duration
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    PullMessage = new PullMessage
                    {
                        Payload = proto::ByteString.CopyFromUtf8("payloadf43c1c32"),
                        Tag = "tag843ed2e4",
                    },
                },
                ResponseView = Task.Types.View.Basic,
            };
            Task expectedResponse = new Task
            {
                TaskName = TaskName.FromProjectLocationQueueTask("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]"),
                AppEngineHttpRequest = new AppEngineHttpRequest
                {
                    HttpMethod = HttpMethod.Put,
                    AppEngineRouting = new AppEngineRouting
                    {
                        Service = "serviced3f0abaa",
                        Version = "version102ff72a",
                        Instance = "instance99a62371",
                        Host = "hosta8dbb367",
                    },
                    RelativeUri = "relative_uri4e468832",
                    Headers =
                    {
                        {
                            "key8a0b6e3c",
                            "value60c16320"
                        },
                    },
                    Body = proto::ByteString.CopyFromUtf8("body682d1a84"),
                },
                ScheduleTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                CreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                DispatchCount = 341017545,
                ResponseCount = -1236920575,
                FirstAttempt = new Attempt
                {
                    ScheduleTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    DispatchTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    ResponseTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    ResponseStatus = new gr::Status
                    {
                        Code = -1805175871,
                        Message = "message0231e778",
                        Details =
                        {
                            new wkt::Any
                            {
                                TypeUrl = "type_urlfde5623b",
                                Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                            },
                        },
                    },
                },
                LastAttempt = new Attempt
                {
                    ScheduleTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    DispatchTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    ResponseTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    ResponseStatus = new gr::Status
                    {
                        Code = -1805175871,
                        Message = "message0231e778",
                        Details =
                        {
                            new wkt::Any
                            {
                                TypeUrl = "type_urlfde5623b",
                                Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                            },
                        },
                    },
                },
                View = Task.Types.View.Basic,
                HttpRequest = new HttpRequest
                {
                    Url = "url424e2d57",
                    HttpMethod = HttpMethod.Put,
                    Headers =
                    {
                        {
                            "key8a0b6e3c",
                            "value60c16320"
                        },
                    },
                    Body = proto::ByteString.CopyFromUtf8("body682d1a84"),
                    OauthToken = new OAuthToken
                    {
                        ServiceAccountEmail = "service_account_emailb0c3703d",
                        Scope = "scope14fda131",
                    },
                    OidcToken = new OidcToken
                    {
                        ServiceAccountEmail = "service_account_emailb0c3703d",
                        Audience = "audience986f1fe3",
                    },
                },
                DispatchDeadline = new wkt::Duration
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                PullMessage = new PullMessage
                {
                    Payload = proto::ByteString.CopyFromUtf8("payloadf43c1c32"),
                    Tag = "tag843ed2e4",
                },
            };
            mockGrpcClient.Setup(x => x.CreateTask(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null);
            Task response = client.CreateTask(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateTaskRequestObjectAsync()
        {
            moq::Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new moq::Mock<CloudTasks.CloudTasksClient>(moq::MockBehavior.Strict);
            CreateTaskRequest request = new CreateTaskRequest
            {
                ParentAsQueueName = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
                Task = new Task
                {
                    TaskName = TaskName.FromProjectLocationQueueTask("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]"),
                    AppEngineHttpRequest = new AppEngineHttpRequest
                    {
                        HttpMethod = HttpMethod.Put,
                        AppEngineRouting = new AppEngineRouting
                        {
                            Service = "serviced3f0abaa",
                            Version = "version102ff72a",
                            Instance = "instance99a62371",
                            Host = "hosta8dbb367",
                        },
                        RelativeUri = "relative_uri4e468832",
                        Headers =
                        {
                            {
                                "key8a0b6e3c",
                                "value60c16320"
                            },
                        },
                        Body = proto::ByteString.CopyFromUtf8("body682d1a84"),
                    },
                    ScheduleTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    CreateTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    DispatchCount = 341017545,
                    ResponseCount = -1236920575,
                    FirstAttempt = new Attempt
                    {
                        ScheduleTime = new wkt::Timestamp
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        DispatchTime = new wkt::Timestamp
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        ResponseTime = new wkt::Timestamp
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        ResponseStatus = new gr::Status
                        {
                            Code = -1805175871,
                            Message = "message0231e778",
                            Details =
                            {
                                new wkt::Any
                                {
                                    TypeUrl = "type_urlfde5623b",
                                    Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                },
                            },
                        },
                    },
                    LastAttempt = new Attempt
                    {
                        ScheduleTime = new wkt::Timestamp
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        DispatchTime = new wkt::Timestamp
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        ResponseTime = new wkt::Timestamp
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        ResponseStatus = new gr::Status
                        {
                            Code = -1805175871,
                            Message = "message0231e778",
                            Details =
                            {
                                new wkt::Any
                                {
                                    TypeUrl = "type_urlfde5623b",
                                    Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                },
                            },
                        },
                    },
                    View = Task.Types.View.Basic,
                    HttpRequest = new HttpRequest
                    {
                        Url = "url424e2d57",
                        HttpMethod = HttpMethod.Put,
                        Headers =
                        {
                            {
                                "key8a0b6e3c",
                                "value60c16320"
                            },
                        },
                        Body = proto::ByteString.CopyFromUtf8("body682d1a84"),
                        OauthToken = new OAuthToken
                        {
                            ServiceAccountEmail = "service_account_emailb0c3703d",
                            Scope = "scope14fda131",
                        },
                        OidcToken = new OidcToken
                        {
                            ServiceAccountEmail = "service_account_emailb0c3703d",
                            Audience = "audience986f1fe3",
                        },
                    },
                    DispatchDeadline = new wkt::Duration
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    PullMessage = new PullMessage
                    {
                        Payload = proto::ByteString.CopyFromUtf8("payloadf43c1c32"),
                        Tag = "tag843ed2e4",
                    },
                },
                ResponseView = Task.Types.View.Basic,
            };
            Task expectedResponse = new Task
            {
                TaskName = TaskName.FromProjectLocationQueueTask("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]"),
                AppEngineHttpRequest = new AppEngineHttpRequest
                {
                    HttpMethod = HttpMethod.Put,
                    AppEngineRouting = new AppEngineRouting
                    {
                        Service = "serviced3f0abaa",
                        Version = "version102ff72a",
                        Instance = "instance99a62371",
                        Host = "hosta8dbb367",
                    },
                    RelativeUri = "relative_uri4e468832",
                    Headers =
                    {
                        {
                            "key8a0b6e3c",
                            "value60c16320"
                        },
                    },
                    Body = proto::ByteString.CopyFromUtf8("body682d1a84"),
                },
                ScheduleTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                CreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                DispatchCount = 341017545,
                ResponseCount = -1236920575,
                FirstAttempt = new Attempt
                {
                    ScheduleTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    DispatchTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    ResponseTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    ResponseStatus = new gr::Status
                    {
                        Code = -1805175871,
                        Message = "message0231e778",
                        Details =
                        {
                            new wkt::Any
                            {
                                TypeUrl = "type_urlfde5623b",
                                Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                            },
                        },
                    },
                },
                LastAttempt = new Attempt
                {
                    ScheduleTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    DispatchTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    ResponseTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    ResponseStatus = new gr::Status
                    {
                        Code = -1805175871,
                        Message = "message0231e778",
                        Details =
                        {
                            new wkt::Any
                            {
                                TypeUrl = "type_urlfde5623b",
                                Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                            },
                        },
                    },
                },
                View = Task.Types.View.Basic,
                HttpRequest = new HttpRequest
                {
                    Url = "url424e2d57",
                    HttpMethod = HttpMethod.Put,
                    Headers =
                    {
                        {
                            "key8a0b6e3c",
                            "value60c16320"
                        },
                    },
                    Body = proto::ByteString.CopyFromUtf8("body682d1a84"),
                    OauthToken = new OAuthToken
                    {
                        ServiceAccountEmail = "service_account_emailb0c3703d",
                        Scope = "scope14fda131",
                    },
                    OidcToken = new OidcToken
                    {
                        ServiceAccountEmail = "service_account_emailb0c3703d",
                        Audience = "audience986f1fe3",
                    },
                },
                DispatchDeadline = new wkt::Duration
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                PullMessage = new PullMessage
                {
                    Payload = proto::ByteString.CopyFromUtf8("payloadf43c1c32"),
                    Tag = "tag843ed2e4",
                },
            };
            mockGrpcClient.Setup(x => x.CreateTaskAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Task>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null);
            Task responseCallSettings = await client.CreateTaskAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Task responseCancellationToken = await client.CreateTaskAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateTask()
        {
            moq::Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new moq::Mock<CloudTasks.CloudTasksClient>(moq::MockBehavior.Strict);
            CreateTaskRequest request = new CreateTaskRequest
            {
                ParentAsQueueName = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
                Task = new Task
                {
                    TaskName = TaskName.FromProjectLocationQueueTask("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]"),
                    AppEngineHttpRequest = new AppEngineHttpRequest
                    {
                        HttpMethod = HttpMethod.Put,
                        AppEngineRouting = new AppEngineRouting
                        {
                            Service = "serviced3f0abaa",
                            Version = "version102ff72a",
                            Instance = "instance99a62371",
                            Host = "hosta8dbb367",
                        },
                        RelativeUri = "relative_uri4e468832",
                        Headers =
                        {
                            {
                                "key8a0b6e3c",
                                "value60c16320"
                            },
                        },
                        Body = proto::ByteString.CopyFromUtf8("body682d1a84"),
                    },
                    ScheduleTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    CreateTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    DispatchCount = 341017545,
                    ResponseCount = -1236920575,
                    FirstAttempt = new Attempt
                    {
                        ScheduleTime = new wkt::Timestamp
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        DispatchTime = new wkt::Timestamp
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        ResponseTime = new wkt::Timestamp
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        ResponseStatus = new gr::Status
                        {
                            Code = -1805175871,
                            Message = "message0231e778",
                            Details =
                            {
                                new wkt::Any
                                {
                                    TypeUrl = "type_urlfde5623b",
                                    Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                },
                            },
                        },
                    },
                    LastAttempt = new Attempt
                    {
                        ScheduleTime = new wkt::Timestamp
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        DispatchTime = new wkt::Timestamp
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        ResponseTime = new wkt::Timestamp
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        ResponseStatus = new gr::Status
                        {
                            Code = -1805175871,
                            Message = "message0231e778",
                            Details =
                            {
                                new wkt::Any
                                {
                                    TypeUrl = "type_urlfde5623b",
                                    Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                },
                            },
                        },
                    },
                    View = Task.Types.View.Basic,
                    HttpRequest = new HttpRequest
                    {
                        Url = "url424e2d57",
                        HttpMethod = HttpMethod.Put,
                        Headers =
                        {
                            {
                                "key8a0b6e3c",
                                "value60c16320"
                            },
                        },
                        Body = proto::ByteString.CopyFromUtf8("body682d1a84"),
                        OauthToken = new OAuthToken
                        {
                            ServiceAccountEmail = "service_account_emailb0c3703d",
                            Scope = "scope14fda131",
                        },
                        OidcToken = new OidcToken
                        {
                            ServiceAccountEmail = "service_account_emailb0c3703d",
                            Audience = "audience986f1fe3",
                        },
                    },
                    DispatchDeadline = new wkt::Duration
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    PullMessage = new PullMessage
                    {
                        Payload = proto::ByteString.CopyFromUtf8("payloadf43c1c32"),
                        Tag = "tag843ed2e4",
                    },
                },
            };
            Task expectedResponse = new Task
            {
                TaskName = TaskName.FromProjectLocationQueueTask("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]"),
                AppEngineHttpRequest = new AppEngineHttpRequest
                {
                    HttpMethod = HttpMethod.Put,
                    AppEngineRouting = new AppEngineRouting
                    {
                        Service = "serviced3f0abaa",
                        Version = "version102ff72a",
                        Instance = "instance99a62371",
                        Host = "hosta8dbb367",
                    },
                    RelativeUri = "relative_uri4e468832",
                    Headers =
                    {
                        {
                            "key8a0b6e3c",
                            "value60c16320"
                        },
                    },
                    Body = proto::ByteString.CopyFromUtf8("body682d1a84"),
                },
                ScheduleTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                CreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                DispatchCount = 341017545,
                ResponseCount = -1236920575,
                FirstAttempt = new Attempt
                {
                    ScheduleTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    DispatchTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    ResponseTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    ResponseStatus = new gr::Status
                    {
                        Code = -1805175871,
                        Message = "message0231e778",
                        Details =
                        {
                            new wkt::Any
                            {
                                TypeUrl = "type_urlfde5623b",
                                Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                            },
                        },
                    },
                },
                LastAttempt = new Attempt
                {
                    ScheduleTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    DispatchTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    ResponseTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    ResponseStatus = new gr::Status
                    {
                        Code = -1805175871,
                        Message = "message0231e778",
                        Details =
                        {
                            new wkt::Any
                            {
                                TypeUrl = "type_urlfde5623b",
                                Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                            },
                        },
                    },
                },
                View = Task.Types.View.Basic,
                HttpRequest = new HttpRequest
                {
                    Url = "url424e2d57",
                    HttpMethod = HttpMethod.Put,
                    Headers =
                    {
                        {
                            "key8a0b6e3c",
                            "value60c16320"
                        },
                    },
                    Body = proto::ByteString.CopyFromUtf8("body682d1a84"),
                    OauthToken = new OAuthToken
                    {
                        ServiceAccountEmail = "service_account_emailb0c3703d",
                        Scope = "scope14fda131",
                    },
                    OidcToken = new OidcToken
                    {
                        ServiceAccountEmail = "service_account_emailb0c3703d",
                        Audience = "audience986f1fe3",
                    },
                },
                DispatchDeadline = new wkt::Duration
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                PullMessage = new PullMessage
                {
                    Payload = proto::ByteString.CopyFromUtf8("payloadf43c1c32"),
                    Tag = "tag843ed2e4",
                },
            };
            mockGrpcClient.Setup(x => x.CreateTask(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null);
            Task response = client.CreateTask(request.Parent, request.Task);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateTaskAsync()
        {
            moq::Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new moq::Mock<CloudTasks.CloudTasksClient>(moq::MockBehavior.Strict);
            CreateTaskRequest request = new CreateTaskRequest
            {
                ParentAsQueueName = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
                Task = new Task
                {
                    TaskName = TaskName.FromProjectLocationQueueTask("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]"),
                    AppEngineHttpRequest = new AppEngineHttpRequest
                    {
                        HttpMethod = HttpMethod.Put,
                        AppEngineRouting = new AppEngineRouting
                        {
                            Service = "serviced3f0abaa",
                            Version = "version102ff72a",
                            Instance = "instance99a62371",
                            Host = "hosta8dbb367",
                        },
                        RelativeUri = "relative_uri4e468832",
                        Headers =
                        {
                            {
                                "key8a0b6e3c",
                                "value60c16320"
                            },
                        },
                        Body = proto::ByteString.CopyFromUtf8("body682d1a84"),
                    },
                    ScheduleTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    CreateTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    DispatchCount = 341017545,
                    ResponseCount = -1236920575,
                    FirstAttempt = new Attempt
                    {
                        ScheduleTime = new wkt::Timestamp
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        DispatchTime = new wkt::Timestamp
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        ResponseTime = new wkt::Timestamp
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        ResponseStatus = new gr::Status
                        {
                            Code = -1805175871,
                            Message = "message0231e778",
                            Details =
                            {
                                new wkt::Any
                                {
                                    TypeUrl = "type_urlfde5623b",
                                    Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                },
                            },
                        },
                    },
                    LastAttempt = new Attempt
                    {
                        ScheduleTime = new wkt::Timestamp
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        DispatchTime = new wkt::Timestamp
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        ResponseTime = new wkt::Timestamp
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        ResponseStatus = new gr::Status
                        {
                            Code = -1805175871,
                            Message = "message0231e778",
                            Details =
                            {
                                new wkt::Any
                                {
                                    TypeUrl = "type_urlfde5623b",
                                    Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                },
                            },
                        },
                    },
                    View = Task.Types.View.Basic,
                    HttpRequest = new HttpRequest
                    {
                        Url = "url424e2d57",
                        HttpMethod = HttpMethod.Put,
                        Headers =
                        {
                            {
                                "key8a0b6e3c",
                                "value60c16320"
                            },
                        },
                        Body = proto::ByteString.CopyFromUtf8("body682d1a84"),
                        OauthToken = new OAuthToken
                        {
                            ServiceAccountEmail = "service_account_emailb0c3703d",
                            Scope = "scope14fda131",
                        },
                        OidcToken = new OidcToken
                        {
                            ServiceAccountEmail = "service_account_emailb0c3703d",
                            Audience = "audience986f1fe3",
                        },
                    },
                    DispatchDeadline = new wkt::Duration
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    PullMessage = new PullMessage
                    {
                        Payload = proto::ByteString.CopyFromUtf8("payloadf43c1c32"),
                        Tag = "tag843ed2e4",
                    },
                },
            };
            Task expectedResponse = new Task
            {
                TaskName = TaskName.FromProjectLocationQueueTask("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]"),
                AppEngineHttpRequest = new AppEngineHttpRequest
                {
                    HttpMethod = HttpMethod.Put,
                    AppEngineRouting = new AppEngineRouting
                    {
                        Service = "serviced3f0abaa",
                        Version = "version102ff72a",
                        Instance = "instance99a62371",
                        Host = "hosta8dbb367",
                    },
                    RelativeUri = "relative_uri4e468832",
                    Headers =
                    {
                        {
                            "key8a0b6e3c",
                            "value60c16320"
                        },
                    },
                    Body = proto::ByteString.CopyFromUtf8("body682d1a84"),
                },
                ScheduleTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                CreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                DispatchCount = 341017545,
                ResponseCount = -1236920575,
                FirstAttempt = new Attempt
                {
                    ScheduleTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    DispatchTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    ResponseTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    ResponseStatus = new gr::Status
                    {
                        Code = -1805175871,
                        Message = "message0231e778",
                        Details =
                        {
                            new wkt::Any
                            {
                                TypeUrl = "type_urlfde5623b",
                                Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                            },
                        },
                    },
                },
                LastAttempt = new Attempt
                {
                    ScheduleTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    DispatchTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    ResponseTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    ResponseStatus = new gr::Status
                    {
                        Code = -1805175871,
                        Message = "message0231e778",
                        Details =
                        {
                            new wkt::Any
                            {
                                TypeUrl = "type_urlfde5623b",
                                Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                            },
                        },
                    },
                },
                View = Task.Types.View.Basic,
                HttpRequest = new HttpRequest
                {
                    Url = "url424e2d57",
                    HttpMethod = HttpMethod.Put,
                    Headers =
                    {
                        {
                            "key8a0b6e3c",
                            "value60c16320"
                        },
                    },
                    Body = proto::ByteString.CopyFromUtf8("body682d1a84"),
                    OauthToken = new OAuthToken
                    {
                        ServiceAccountEmail = "service_account_emailb0c3703d",
                        Scope = "scope14fda131",
                    },
                    OidcToken = new OidcToken
                    {
                        ServiceAccountEmail = "service_account_emailb0c3703d",
                        Audience = "audience986f1fe3",
                    },
                },
                DispatchDeadline = new wkt::Duration
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                PullMessage = new PullMessage
                {
                    Payload = proto::ByteString.CopyFromUtf8("payloadf43c1c32"),
                    Tag = "tag843ed2e4",
                },
            };
            mockGrpcClient.Setup(x => x.CreateTaskAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Task>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null);
            Task responseCallSettings = await client.CreateTaskAsync(request.Parent, request.Task, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Task responseCancellationToken = await client.CreateTaskAsync(request.Parent, request.Task, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateTaskResourceNames()
        {
            moq::Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new moq::Mock<CloudTasks.CloudTasksClient>(moq::MockBehavior.Strict);
            CreateTaskRequest request = new CreateTaskRequest
            {
                ParentAsQueueName = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
                Task = new Task
                {
                    TaskName = TaskName.FromProjectLocationQueueTask("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]"),
                    AppEngineHttpRequest = new AppEngineHttpRequest
                    {
                        HttpMethod = HttpMethod.Put,
                        AppEngineRouting = new AppEngineRouting
                        {
                            Service = "serviced3f0abaa",
                            Version = "version102ff72a",
                            Instance = "instance99a62371",
                            Host = "hosta8dbb367",
                        },
                        RelativeUri = "relative_uri4e468832",
                        Headers =
                        {
                            {
                                "key8a0b6e3c",
                                "value60c16320"
                            },
                        },
                        Body = proto::ByteString.CopyFromUtf8("body682d1a84"),
                    },
                    ScheduleTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    CreateTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    DispatchCount = 341017545,
                    ResponseCount = -1236920575,
                    FirstAttempt = new Attempt
                    {
                        ScheduleTime = new wkt::Timestamp
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        DispatchTime = new wkt::Timestamp
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        ResponseTime = new wkt::Timestamp
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        ResponseStatus = new gr::Status
                        {
                            Code = -1805175871,
                            Message = "message0231e778",
                            Details =
                            {
                                new wkt::Any
                                {
                                    TypeUrl = "type_urlfde5623b",
                                    Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                },
                            },
                        },
                    },
                    LastAttempt = new Attempt
                    {
                        ScheduleTime = new wkt::Timestamp
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        DispatchTime = new wkt::Timestamp
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        ResponseTime = new wkt::Timestamp
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        ResponseStatus = new gr::Status
                        {
                            Code = -1805175871,
                            Message = "message0231e778",
                            Details =
                            {
                                new wkt::Any
                                {
                                    TypeUrl = "type_urlfde5623b",
                                    Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                },
                            },
                        },
                    },
                    View = Task.Types.View.Basic,
                    HttpRequest = new HttpRequest
                    {
                        Url = "url424e2d57",
                        HttpMethod = HttpMethod.Put,
                        Headers =
                        {
                            {
                                "key8a0b6e3c",
                                "value60c16320"
                            },
                        },
                        Body = proto::ByteString.CopyFromUtf8("body682d1a84"),
                        OauthToken = new OAuthToken
                        {
                            ServiceAccountEmail = "service_account_emailb0c3703d",
                            Scope = "scope14fda131",
                        },
                        OidcToken = new OidcToken
                        {
                            ServiceAccountEmail = "service_account_emailb0c3703d",
                            Audience = "audience986f1fe3",
                        },
                    },
                    DispatchDeadline = new wkt::Duration
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    PullMessage = new PullMessage
                    {
                        Payload = proto::ByteString.CopyFromUtf8("payloadf43c1c32"),
                        Tag = "tag843ed2e4",
                    },
                },
            };
            Task expectedResponse = new Task
            {
                TaskName = TaskName.FromProjectLocationQueueTask("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]"),
                AppEngineHttpRequest = new AppEngineHttpRequest
                {
                    HttpMethod = HttpMethod.Put,
                    AppEngineRouting = new AppEngineRouting
                    {
                        Service = "serviced3f0abaa",
                        Version = "version102ff72a",
                        Instance = "instance99a62371",
                        Host = "hosta8dbb367",
                    },
                    RelativeUri = "relative_uri4e468832",
                    Headers =
                    {
                        {
                            "key8a0b6e3c",
                            "value60c16320"
                        },
                    },
                    Body = proto::ByteString.CopyFromUtf8("body682d1a84"),
                },
                ScheduleTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                CreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                DispatchCount = 341017545,
                ResponseCount = -1236920575,
                FirstAttempt = new Attempt
                {
                    ScheduleTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    DispatchTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    ResponseTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    ResponseStatus = new gr::Status
                    {
                        Code = -1805175871,
                        Message = "message0231e778",
                        Details =
                        {
                            new wkt::Any
                            {
                                TypeUrl = "type_urlfde5623b",
                                Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                            },
                        },
                    },
                },
                LastAttempt = new Attempt
                {
                    ScheduleTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    DispatchTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    ResponseTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    ResponseStatus = new gr::Status
                    {
                        Code = -1805175871,
                        Message = "message0231e778",
                        Details =
                        {
                            new wkt::Any
                            {
                                TypeUrl = "type_urlfde5623b",
                                Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                            },
                        },
                    },
                },
                View = Task.Types.View.Basic,
                HttpRequest = new HttpRequest
                {
                    Url = "url424e2d57",
                    HttpMethod = HttpMethod.Put,
                    Headers =
                    {
                        {
                            "key8a0b6e3c",
                            "value60c16320"
                        },
                    },
                    Body = proto::ByteString.CopyFromUtf8("body682d1a84"),
                    OauthToken = new OAuthToken
                    {
                        ServiceAccountEmail = "service_account_emailb0c3703d",
                        Scope = "scope14fda131",
                    },
                    OidcToken = new OidcToken
                    {
                        ServiceAccountEmail = "service_account_emailb0c3703d",
                        Audience = "audience986f1fe3",
                    },
                },
                DispatchDeadline = new wkt::Duration
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                PullMessage = new PullMessage
                {
                    Payload = proto::ByteString.CopyFromUtf8("payloadf43c1c32"),
                    Tag = "tag843ed2e4",
                },
            };
            mockGrpcClient.Setup(x => x.CreateTask(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null);
            Task response = client.CreateTask(request.ParentAsQueueName, request.Task);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateTaskResourceNamesAsync()
        {
            moq::Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new moq::Mock<CloudTasks.CloudTasksClient>(moq::MockBehavior.Strict);
            CreateTaskRequest request = new CreateTaskRequest
            {
                ParentAsQueueName = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
                Task = new Task
                {
                    TaskName = TaskName.FromProjectLocationQueueTask("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]"),
                    AppEngineHttpRequest = new AppEngineHttpRequest
                    {
                        HttpMethod = HttpMethod.Put,
                        AppEngineRouting = new AppEngineRouting
                        {
                            Service = "serviced3f0abaa",
                            Version = "version102ff72a",
                            Instance = "instance99a62371",
                            Host = "hosta8dbb367",
                        },
                        RelativeUri = "relative_uri4e468832",
                        Headers =
                        {
                            {
                                "key8a0b6e3c",
                                "value60c16320"
                            },
                        },
                        Body = proto::ByteString.CopyFromUtf8("body682d1a84"),
                    },
                    ScheduleTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    CreateTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    DispatchCount = 341017545,
                    ResponseCount = -1236920575,
                    FirstAttempt = new Attempt
                    {
                        ScheduleTime = new wkt::Timestamp
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        DispatchTime = new wkt::Timestamp
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        ResponseTime = new wkt::Timestamp
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        ResponseStatus = new gr::Status
                        {
                            Code = -1805175871,
                            Message = "message0231e778",
                            Details =
                            {
                                new wkt::Any
                                {
                                    TypeUrl = "type_urlfde5623b",
                                    Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                },
                            },
                        },
                    },
                    LastAttempt = new Attempt
                    {
                        ScheduleTime = new wkt::Timestamp
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        DispatchTime = new wkt::Timestamp
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        ResponseTime = new wkt::Timestamp
                        {
                            Seconds = -2106654494186127752L,
                            Nanos = 985689544,
                        },
                        ResponseStatus = new gr::Status
                        {
                            Code = -1805175871,
                            Message = "message0231e778",
                            Details =
                            {
                                new wkt::Any
                                {
                                    TypeUrl = "type_urlfde5623b",
                                    Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                                },
                            },
                        },
                    },
                    View = Task.Types.View.Basic,
                    HttpRequest = new HttpRequest
                    {
                        Url = "url424e2d57",
                        HttpMethod = HttpMethod.Put,
                        Headers =
                        {
                            {
                                "key8a0b6e3c",
                                "value60c16320"
                            },
                        },
                        Body = proto::ByteString.CopyFromUtf8("body682d1a84"),
                        OauthToken = new OAuthToken
                        {
                            ServiceAccountEmail = "service_account_emailb0c3703d",
                            Scope = "scope14fda131",
                        },
                        OidcToken = new OidcToken
                        {
                            ServiceAccountEmail = "service_account_emailb0c3703d",
                            Audience = "audience986f1fe3",
                        },
                    },
                    DispatchDeadline = new wkt::Duration
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    PullMessage = new PullMessage
                    {
                        Payload = proto::ByteString.CopyFromUtf8("payloadf43c1c32"),
                        Tag = "tag843ed2e4",
                    },
                },
            };
            Task expectedResponse = new Task
            {
                TaskName = TaskName.FromProjectLocationQueueTask("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]"),
                AppEngineHttpRequest = new AppEngineHttpRequest
                {
                    HttpMethod = HttpMethod.Put,
                    AppEngineRouting = new AppEngineRouting
                    {
                        Service = "serviced3f0abaa",
                        Version = "version102ff72a",
                        Instance = "instance99a62371",
                        Host = "hosta8dbb367",
                    },
                    RelativeUri = "relative_uri4e468832",
                    Headers =
                    {
                        {
                            "key8a0b6e3c",
                            "value60c16320"
                        },
                    },
                    Body = proto::ByteString.CopyFromUtf8("body682d1a84"),
                },
                ScheduleTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                CreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                DispatchCount = 341017545,
                ResponseCount = -1236920575,
                FirstAttempt = new Attempt
                {
                    ScheduleTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    DispatchTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    ResponseTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    ResponseStatus = new gr::Status
                    {
                        Code = -1805175871,
                        Message = "message0231e778",
                        Details =
                        {
                            new wkt::Any
                            {
                                TypeUrl = "type_urlfde5623b",
                                Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                            },
                        },
                    },
                },
                LastAttempt = new Attempt
                {
                    ScheduleTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    DispatchTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    ResponseTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    ResponseStatus = new gr::Status
                    {
                        Code = -1805175871,
                        Message = "message0231e778",
                        Details =
                        {
                            new wkt::Any
                            {
                                TypeUrl = "type_urlfde5623b",
                                Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                            },
                        },
                    },
                },
                View = Task.Types.View.Basic,
                HttpRequest = new HttpRequest
                {
                    Url = "url424e2d57",
                    HttpMethod = HttpMethod.Put,
                    Headers =
                    {
                        {
                            "key8a0b6e3c",
                            "value60c16320"
                        },
                    },
                    Body = proto::ByteString.CopyFromUtf8("body682d1a84"),
                    OauthToken = new OAuthToken
                    {
                        ServiceAccountEmail = "service_account_emailb0c3703d",
                        Scope = "scope14fda131",
                    },
                    OidcToken = new OidcToken
                    {
                        ServiceAccountEmail = "service_account_emailb0c3703d",
                        Audience = "audience986f1fe3",
                    },
                },
                DispatchDeadline = new wkt::Duration
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                PullMessage = new PullMessage
                {
                    Payload = proto::ByteString.CopyFromUtf8("payloadf43c1c32"),
                    Tag = "tag843ed2e4",
                },
            };
            mockGrpcClient.Setup(x => x.CreateTaskAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Task>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null);
            Task responseCallSettings = await client.CreateTaskAsync(request.ParentAsQueueName, request.Task, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Task responseCancellationToken = await client.CreateTaskAsync(request.ParentAsQueueName, request.Task, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteTaskRequestObject()
        {
            moq::Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new moq::Mock<CloudTasks.CloudTasksClient>(moq::MockBehavior.Strict);
            DeleteTaskRequest request = new DeleteTaskRequest
            {
                TaskName = TaskName.FromProjectLocationQueueTask("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteTask(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null);
            client.DeleteTask(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteTaskRequestObjectAsync()
        {
            moq::Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new moq::Mock<CloudTasks.CloudTasksClient>(moq::MockBehavior.Strict);
            DeleteTaskRequest request = new DeleteTaskRequest
            {
                TaskName = TaskName.FromProjectLocationQueueTask("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteTaskAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null);
            await client.DeleteTaskAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteTaskAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteTask()
        {
            moq::Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new moq::Mock<CloudTasks.CloudTasksClient>(moq::MockBehavior.Strict);
            DeleteTaskRequest request = new DeleteTaskRequest
            {
                TaskName = TaskName.FromProjectLocationQueueTask("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteTask(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null);
            client.DeleteTask(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteTaskAsync()
        {
            moq::Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new moq::Mock<CloudTasks.CloudTasksClient>(moq::MockBehavior.Strict);
            DeleteTaskRequest request = new DeleteTaskRequest
            {
                TaskName = TaskName.FromProjectLocationQueueTask("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteTaskAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null);
            await client.DeleteTaskAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteTaskAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteTaskResourceNames()
        {
            moq::Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new moq::Mock<CloudTasks.CloudTasksClient>(moq::MockBehavior.Strict);
            DeleteTaskRequest request = new DeleteTaskRequest
            {
                TaskName = TaskName.FromProjectLocationQueueTask("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteTask(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null);
            client.DeleteTask(request.TaskName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteTaskResourceNamesAsync()
        {
            moq::Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new moq::Mock<CloudTasks.CloudTasksClient>(moq::MockBehavior.Strict);
            DeleteTaskRequest request = new DeleteTaskRequest
            {
                TaskName = TaskName.FromProjectLocationQueueTask("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteTaskAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null);
            await client.DeleteTaskAsync(request.TaskName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteTaskAsync(request.TaskName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void RunTaskRequestObject()
        {
            moq::Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new moq::Mock<CloudTasks.CloudTasksClient>(moq::MockBehavior.Strict);
            RunTaskRequest request = new RunTaskRequest
            {
                TaskName = TaskName.FromProjectLocationQueueTask("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]"),
                ResponseView = Task.Types.View.Basic,
            };
            Task expectedResponse = new Task
            {
                TaskName = TaskName.FromProjectLocationQueueTask("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]"),
                AppEngineHttpRequest = new AppEngineHttpRequest
                {
                    HttpMethod = HttpMethod.Put,
                    AppEngineRouting = new AppEngineRouting
                    {
                        Service = "serviced3f0abaa",
                        Version = "version102ff72a",
                        Instance = "instance99a62371",
                        Host = "hosta8dbb367",
                    },
                    RelativeUri = "relative_uri4e468832",
                    Headers =
                    {
                        {
                            "key8a0b6e3c",
                            "value60c16320"
                        },
                    },
                    Body = proto::ByteString.CopyFromUtf8("body682d1a84"),
                },
                ScheduleTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                CreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                DispatchCount = 341017545,
                ResponseCount = -1236920575,
                FirstAttempt = new Attempt
                {
                    ScheduleTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    DispatchTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    ResponseTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    ResponseStatus = new gr::Status
                    {
                        Code = -1805175871,
                        Message = "message0231e778",
                        Details =
                        {
                            new wkt::Any
                            {
                                TypeUrl = "type_urlfde5623b",
                                Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                            },
                        },
                    },
                },
                LastAttempt = new Attempt
                {
                    ScheduleTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    DispatchTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    ResponseTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    ResponseStatus = new gr::Status
                    {
                        Code = -1805175871,
                        Message = "message0231e778",
                        Details =
                        {
                            new wkt::Any
                            {
                                TypeUrl = "type_urlfde5623b",
                                Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                            },
                        },
                    },
                },
                View = Task.Types.View.Basic,
                HttpRequest = new HttpRequest
                {
                    Url = "url424e2d57",
                    HttpMethod = HttpMethod.Put,
                    Headers =
                    {
                        {
                            "key8a0b6e3c",
                            "value60c16320"
                        },
                    },
                    Body = proto::ByteString.CopyFromUtf8("body682d1a84"),
                    OauthToken = new OAuthToken
                    {
                        ServiceAccountEmail = "service_account_emailb0c3703d",
                        Scope = "scope14fda131",
                    },
                    OidcToken = new OidcToken
                    {
                        ServiceAccountEmail = "service_account_emailb0c3703d",
                        Audience = "audience986f1fe3",
                    },
                },
                DispatchDeadline = new wkt::Duration
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                PullMessage = new PullMessage
                {
                    Payload = proto::ByteString.CopyFromUtf8("payloadf43c1c32"),
                    Tag = "tag843ed2e4",
                },
            };
            mockGrpcClient.Setup(x => x.RunTask(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null);
            Task response = client.RunTask(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task RunTaskRequestObjectAsync()
        {
            moq::Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new moq::Mock<CloudTasks.CloudTasksClient>(moq::MockBehavior.Strict);
            RunTaskRequest request = new RunTaskRequest
            {
                TaskName = TaskName.FromProjectLocationQueueTask("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]"),
                ResponseView = Task.Types.View.Basic,
            };
            Task expectedResponse = new Task
            {
                TaskName = TaskName.FromProjectLocationQueueTask("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]"),
                AppEngineHttpRequest = new AppEngineHttpRequest
                {
                    HttpMethod = HttpMethod.Put,
                    AppEngineRouting = new AppEngineRouting
                    {
                        Service = "serviced3f0abaa",
                        Version = "version102ff72a",
                        Instance = "instance99a62371",
                        Host = "hosta8dbb367",
                    },
                    RelativeUri = "relative_uri4e468832",
                    Headers =
                    {
                        {
                            "key8a0b6e3c",
                            "value60c16320"
                        },
                    },
                    Body = proto::ByteString.CopyFromUtf8("body682d1a84"),
                },
                ScheduleTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                CreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                DispatchCount = 341017545,
                ResponseCount = -1236920575,
                FirstAttempt = new Attempt
                {
                    ScheduleTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    DispatchTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    ResponseTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    ResponseStatus = new gr::Status
                    {
                        Code = -1805175871,
                        Message = "message0231e778",
                        Details =
                        {
                            new wkt::Any
                            {
                                TypeUrl = "type_urlfde5623b",
                                Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                            },
                        },
                    },
                },
                LastAttempt = new Attempt
                {
                    ScheduleTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    DispatchTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    ResponseTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    ResponseStatus = new gr::Status
                    {
                        Code = -1805175871,
                        Message = "message0231e778",
                        Details =
                        {
                            new wkt::Any
                            {
                                TypeUrl = "type_urlfde5623b",
                                Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                            },
                        },
                    },
                },
                View = Task.Types.View.Basic,
                HttpRequest = new HttpRequest
                {
                    Url = "url424e2d57",
                    HttpMethod = HttpMethod.Put,
                    Headers =
                    {
                        {
                            "key8a0b6e3c",
                            "value60c16320"
                        },
                    },
                    Body = proto::ByteString.CopyFromUtf8("body682d1a84"),
                    OauthToken = new OAuthToken
                    {
                        ServiceAccountEmail = "service_account_emailb0c3703d",
                        Scope = "scope14fda131",
                    },
                    OidcToken = new OidcToken
                    {
                        ServiceAccountEmail = "service_account_emailb0c3703d",
                        Audience = "audience986f1fe3",
                    },
                },
                DispatchDeadline = new wkt::Duration
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                PullMessage = new PullMessage
                {
                    Payload = proto::ByteString.CopyFromUtf8("payloadf43c1c32"),
                    Tag = "tag843ed2e4",
                },
            };
            mockGrpcClient.Setup(x => x.RunTaskAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Task>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null);
            Task responseCallSettings = await client.RunTaskAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Task responseCancellationToken = await client.RunTaskAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void RunTask()
        {
            moq::Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new moq::Mock<CloudTasks.CloudTasksClient>(moq::MockBehavior.Strict);
            RunTaskRequest request = new RunTaskRequest
            {
                TaskName = TaskName.FromProjectLocationQueueTask("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]"),
            };
            Task expectedResponse = new Task
            {
                TaskName = TaskName.FromProjectLocationQueueTask("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]"),
                AppEngineHttpRequest = new AppEngineHttpRequest
                {
                    HttpMethod = HttpMethod.Put,
                    AppEngineRouting = new AppEngineRouting
                    {
                        Service = "serviced3f0abaa",
                        Version = "version102ff72a",
                        Instance = "instance99a62371",
                        Host = "hosta8dbb367",
                    },
                    RelativeUri = "relative_uri4e468832",
                    Headers =
                    {
                        {
                            "key8a0b6e3c",
                            "value60c16320"
                        },
                    },
                    Body = proto::ByteString.CopyFromUtf8("body682d1a84"),
                },
                ScheduleTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                CreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                DispatchCount = 341017545,
                ResponseCount = -1236920575,
                FirstAttempt = new Attempt
                {
                    ScheduleTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    DispatchTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    ResponseTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    ResponseStatus = new gr::Status
                    {
                        Code = -1805175871,
                        Message = "message0231e778",
                        Details =
                        {
                            new wkt::Any
                            {
                                TypeUrl = "type_urlfde5623b",
                                Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                            },
                        },
                    },
                },
                LastAttempt = new Attempt
                {
                    ScheduleTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    DispatchTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    ResponseTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    ResponseStatus = new gr::Status
                    {
                        Code = -1805175871,
                        Message = "message0231e778",
                        Details =
                        {
                            new wkt::Any
                            {
                                TypeUrl = "type_urlfde5623b",
                                Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                            },
                        },
                    },
                },
                View = Task.Types.View.Basic,
                HttpRequest = new HttpRequest
                {
                    Url = "url424e2d57",
                    HttpMethod = HttpMethod.Put,
                    Headers =
                    {
                        {
                            "key8a0b6e3c",
                            "value60c16320"
                        },
                    },
                    Body = proto::ByteString.CopyFromUtf8("body682d1a84"),
                    OauthToken = new OAuthToken
                    {
                        ServiceAccountEmail = "service_account_emailb0c3703d",
                        Scope = "scope14fda131",
                    },
                    OidcToken = new OidcToken
                    {
                        ServiceAccountEmail = "service_account_emailb0c3703d",
                        Audience = "audience986f1fe3",
                    },
                },
                DispatchDeadline = new wkt::Duration
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                PullMessage = new PullMessage
                {
                    Payload = proto::ByteString.CopyFromUtf8("payloadf43c1c32"),
                    Tag = "tag843ed2e4",
                },
            };
            mockGrpcClient.Setup(x => x.RunTask(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null);
            Task response = client.RunTask(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task RunTaskAsync()
        {
            moq::Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new moq::Mock<CloudTasks.CloudTasksClient>(moq::MockBehavior.Strict);
            RunTaskRequest request = new RunTaskRequest
            {
                TaskName = TaskName.FromProjectLocationQueueTask("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]"),
            };
            Task expectedResponse = new Task
            {
                TaskName = TaskName.FromProjectLocationQueueTask("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]"),
                AppEngineHttpRequest = new AppEngineHttpRequest
                {
                    HttpMethod = HttpMethod.Put,
                    AppEngineRouting = new AppEngineRouting
                    {
                        Service = "serviced3f0abaa",
                        Version = "version102ff72a",
                        Instance = "instance99a62371",
                        Host = "hosta8dbb367",
                    },
                    RelativeUri = "relative_uri4e468832",
                    Headers =
                    {
                        {
                            "key8a0b6e3c",
                            "value60c16320"
                        },
                    },
                    Body = proto::ByteString.CopyFromUtf8("body682d1a84"),
                },
                ScheduleTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                CreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                DispatchCount = 341017545,
                ResponseCount = -1236920575,
                FirstAttempt = new Attempt
                {
                    ScheduleTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    DispatchTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    ResponseTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    ResponseStatus = new gr::Status
                    {
                        Code = -1805175871,
                        Message = "message0231e778",
                        Details =
                        {
                            new wkt::Any
                            {
                                TypeUrl = "type_urlfde5623b",
                                Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                            },
                        },
                    },
                },
                LastAttempt = new Attempt
                {
                    ScheduleTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    DispatchTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    ResponseTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    ResponseStatus = new gr::Status
                    {
                        Code = -1805175871,
                        Message = "message0231e778",
                        Details =
                        {
                            new wkt::Any
                            {
                                TypeUrl = "type_urlfde5623b",
                                Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                            },
                        },
                    },
                },
                View = Task.Types.View.Basic,
                HttpRequest = new HttpRequest
                {
                    Url = "url424e2d57",
                    HttpMethod = HttpMethod.Put,
                    Headers =
                    {
                        {
                            "key8a0b6e3c",
                            "value60c16320"
                        },
                    },
                    Body = proto::ByteString.CopyFromUtf8("body682d1a84"),
                    OauthToken = new OAuthToken
                    {
                        ServiceAccountEmail = "service_account_emailb0c3703d",
                        Scope = "scope14fda131",
                    },
                    OidcToken = new OidcToken
                    {
                        ServiceAccountEmail = "service_account_emailb0c3703d",
                        Audience = "audience986f1fe3",
                    },
                },
                DispatchDeadline = new wkt::Duration
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                PullMessage = new PullMessage
                {
                    Payload = proto::ByteString.CopyFromUtf8("payloadf43c1c32"),
                    Tag = "tag843ed2e4",
                },
            };
            mockGrpcClient.Setup(x => x.RunTaskAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Task>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null);
            Task responseCallSettings = await client.RunTaskAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Task responseCancellationToken = await client.RunTaskAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void RunTaskResourceNames()
        {
            moq::Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new moq::Mock<CloudTasks.CloudTasksClient>(moq::MockBehavior.Strict);
            RunTaskRequest request = new RunTaskRequest
            {
                TaskName = TaskName.FromProjectLocationQueueTask("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]"),
            };
            Task expectedResponse = new Task
            {
                TaskName = TaskName.FromProjectLocationQueueTask("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]"),
                AppEngineHttpRequest = new AppEngineHttpRequest
                {
                    HttpMethod = HttpMethod.Put,
                    AppEngineRouting = new AppEngineRouting
                    {
                        Service = "serviced3f0abaa",
                        Version = "version102ff72a",
                        Instance = "instance99a62371",
                        Host = "hosta8dbb367",
                    },
                    RelativeUri = "relative_uri4e468832",
                    Headers =
                    {
                        {
                            "key8a0b6e3c",
                            "value60c16320"
                        },
                    },
                    Body = proto::ByteString.CopyFromUtf8("body682d1a84"),
                },
                ScheduleTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                CreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                DispatchCount = 341017545,
                ResponseCount = -1236920575,
                FirstAttempt = new Attempt
                {
                    ScheduleTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    DispatchTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    ResponseTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    ResponseStatus = new gr::Status
                    {
                        Code = -1805175871,
                        Message = "message0231e778",
                        Details =
                        {
                            new wkt::Any
                            {
                                TypeUrl = "type_urlfde5623b",
                                Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                            },
                        },
                    },
                },
                LastAttempt = new Attempt
                {
                    ScheduleTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    DispatchTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    ResponseTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    ResponseStatus = new gr::Status
                    {
                        Code = -1805175871,
                        Message = "message0231e778",
                        Details =
                        {
                            new wkt::Any
                            {
                                TypeUrl = "type_urlfde5623b",
                                Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                            },
                        },
                    },
                },
                View = Task.Types.View.Basic,
                HttpRequest = new HttpRequest
                {
                    Url = "url424e2d57",
                    HttpMethod = HttpMethod.Put,
                    Headers =
                    {
                        {
                            "key8a0b6e3c",
                            "value60c16320"
                        },
                    },
                    Body = proto::ByteString.CopyFromUtf8("body682d1a84"),
                    OauthToken = new OAuthToken
                    {
                        ServiceAccountEmail = "service_account_emailb0c3703d",
                        Scope = "scope14fda131",
                    },
                    OidcToken = new OidcToken
                    {
                        ServiceAccountEmail = "service_account_emailb0c3703d",
                        Audience = "audience986f1fe3",
                    },
                },
                DispatchDeadline = new wkt::Duration
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                PullMessage = new PullMessage
                {
                    Payload = proto::ByteString.CopyFromUtf8("payloadf43c1c32"),
                    Tag = "tag843ed2e4",
                },
            };
            mockGrpcClient.Setup(x => x.RunTask(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null);
            Task response = client.RunTask(request.TaskName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task RunTaskResourceNamesAsync()
        {
            moq::Mock<CloudTasks.CloudTasksClient> mockGrpcClient = new moq::Mock<CloudTasks.CloudTasksClient>(moq::MockBehavior.Strict);
            RunTaskRequest request = new RunTaskRequest
            {
                TaskName = TaskName.FromProjectLocationQueueTask("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]"),
            };
            Task expectedResponse = new Task
            {
                TaskName = TaskName.FromProjectLocationQueueTask("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]"),
                AppEngineHttpRequest = new AppEngineHttpRequest
                {
                    HttpMethod = HttpMethod.Put,
                    AppEngineRouting = new AppEngineRouting
                    {
                        Service = "serviced3f0abaa",
                        Version = "version102ff72a",
                        Instance = "instance99a62371",
                        Host = "hosta8dbb367",
                    },
                    RelativeUri = "relative_uri4e468832",
                    Headers =
                    {
                        {
                            "key8a0b6e3c",
                            "value60c16320"
                        },
                    },
                    Body = proto::ByteString.CopyFromUtf8("body682d1a84"),
                },
                ScheduleTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                CreateTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                DispatchCount = 341017545,
                ResponseCount = -1236920575,
                FirstAttempt = new Attempt
                {
                    ScheduleTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    DispatchTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    ResponseTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    ResponseStatus = new gr::Status
                    {
                        Code = -1805175871,
                        Message = "message0231e778",
                        Details =
                        {
                            new wkt::Any
                            {
                                TypeUrl = "type_urlfde5623b",
                                Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                            },
                        },
                    },
                },
                LastAttempt = new Attempt
                {
                    ScheduleTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    DispatchTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    ResponseTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    ResponseStatus = new gr::Status
                    {
                        Code = -1805175871,
                        Message = "message0231e778",
                        Details =
                        {
                            new wkt::Any
                            {
                                TypeUrl = "type_urlfde5623b",
                                Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                            },
                        },
                    },
                },
                View = Task.Types.View.Basic,
                HttpRequest = new HttpRequest
                {
                    Url = "url424e2d57",
                    HttpMethod = HttpMethod.Put,
                    Headers =
                    {
                        {
                            "key8a0b6e3c",
                            "value60c16320"
                        },
                    },
                    Body = proto::ByteString.CopyFromUtf8("body682d1a84"),
                    OauthToken = new OAuthToken
                    {
                        ServiceAccountEmail = "service_account_emailb0c3703d",
                        Scope = "scope14fda131",
                    },
                    OidcToken = new OidcToken
                    {
                        ServiceAccountEmail = "service_account_emailb0c3703d",
                        Audience = "audience986f1fe3",
                    },
                },
                DispatchDeadline = new wkt::Duration
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                PullMessage = new PullMessage
                {
                    Payload = proto::ByteString.CopyFromUtf8("payloadf43c1c32"),
                    Tag = "tag843ed2e4",
                },
            };
            mockGrpcClient.Setup(x => x.RunTaskAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Task>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudTasksClient client = new CloudTasksClientImpl(mockGrpcClient.Object, null);
            Task responseCallSettings = await client.RunTaskAsync(request.TaskName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Task responseCancellationToken = await client.RunTaskAsync(request.TaskName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
