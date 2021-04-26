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

using System;
using System.Threading;
using Xunit;
using Xunit.Abstractions;

namespace Google.Cloud.Compute.V1.IntegrationTests
{
    [Collection(nameof(ComputeFixture))]
    public sealed class InstancesTest
    {
        private readonly ITestOutputHelper _output;
        private readonly ComputeFixture _fixture;

        public InstancesTest(ComputeFixture fixture, ITestOutputHelper output) =>
            (_fixture, _output) = (fixture, output);

        [Fact]
        public void CreateInstance()
        {
            string projectId = _fixture.ProjectId;
            string zone = _fixture.Zone;
            string diskImage = "projects/debian-cloud/global/images/family/debian-10";
            string machineType =
                $"https://www.googleapis.com/compute/v1/projects/{projectId}/zones/{zone}/machineTypes/n1-standard-1";
            InstancesClient instancesClient = InstancesClient.Create();
            var instanceName = _fixture.GenerateResourceId();

            CreateInstanceNonAsciiDescription();
            FetchInstance();
            PatchInstance();
            DeleteInstance();

            void CreateInstanceNonAsciiDescription()
            {
                var instanceResource = new Instance
                {
                    Name = instanceName,
                    Zone = zone,
                    Description = "тест",
                    MachineType = machineType,
                    Disks =
                    {
                        new AttachedDisk
                        {
                            AutoDelete = true,
                            Boot = true,
                            Type = AttachedDisk.Types.Type.Persistent,
                            InitializeParams = new AttachedDiskInitializeParams {SourceImage = diskImage}
                        }
                    },
                    NetworkInterfaces = {new NetworkInterface {Name = "default"}}
                };
                Operation insertOp = instancesClient.Insert(projectId, zone, instanceResource);
                PollForCompletion(insertOp, "create");
            }

            void FetchInstance()
            {
                _output.WriteLine($"Retrieving instance with the name: {instanceName}");
                Instance instance = instancesClient.Get(projectId, zone, instanceName);
                Assert.NotNull(instance);
                Assert.Equal(instanceName, instance.Name);
                Assert.Equal(machineType, instance.MachineType);
                Assert.Equal(false, instance.ShieldedInstanceConfig.EnableSecureBoot);
                Assert.Equal("тест", instance.Description);
            }

            void DeleteInstance()
            {
                _output.WriteLine($"Deleting instance with the name: {instanceName}");
                Operation deleteOp = instancesClient.Delete(projectId, zone, instanceName);
                deleteOp = PollForCompletion(deleteOp, "delete");
                _output.WriteLine(
                    $"Operation to delete instance completed: status {deleteOp.Status}; start time {deleteOp.StartTime}; end time {deleteOp.EndTime}");
            }

            void PatchInstance()
            {
                ShieldedInstanceConfig shieldedInstanceConfigResource = new ShieldedInstanceConfig
                {
                    EnableSecureBoot = true
                };
                Operation stopOp = instancesClient.Stop(projectId, zone, instanceName);
                PollForCompletion(stopOp, "stop");
                Operation patchOp = instancesClient.UpdateShieldedInstanceConfig(
                    projectId,
                    zone,
                    instanceName,
                    shieldedInstanceConfigResource);
                PollForCompletion(patchOp, "patch");
                Instance instance = instancesClient.Get(projectId, zone, instanceName);
                Assert.Equal(true, instance.ShieldedInstanceConfig.EnableSecureBoot);
            }
        }

        [Fact(Skip = "resize fails")]
        public void TestQueryParams()
        {
            string projectId = _fixture.ProjectId;
            string zone = _fixture.Zone;
            InstanceGroupManagersClient instanceGroupManagersClient = InstanceGroupManagersClient.Create();
            InstanceTemplatesClient instanceTemplatesClient = InstanceTemplatesClient.Create();
            var instanceGroupManagerName = _fixture.GenerateResourceId();
            var instanceTemplateName = _fixture.GenerateResourceId();
            InstanceProperties props = new InstanceProperties
            {
                Disks =
                {
                    new AttachedDisk
                    {
                        AutoDelete = true,
                        Boot = true,
                        Type = AttachedDisk.Types.Type.Persistent,
                        InitializeParams = new AttachedDiskInitializeParams
                        {
                            SourceImage = "projects/debian-cloud/global/images/family/debian-10"
                        }
                    }
                },
                NetworkInterfaces = {new NetworkInterface {Name = "default"}},
                MachineType = "n1-standard-1"
            };
            InstanceTemplate instanceTemplate = new InstanceTemplate
            {
                Name = instanceTemplateName,
                Properties = props
            };
            try
            {
                Operation insertTemplateOp = instanceTemplatesClient.Insert(projectId, instanceTemplate);
                PollForCompletionGlobalOp(insertTemplateOp, "insert template");

                InstanceGroupManager instanceGroupManager = new InstanceGroupManager
                {
                    InstanceTemplate = insertTemplateOp.TargetLink,
                    TargetSize = 1,
                    Name = instanceGroupManagerName,
                    BaseInstanceName = "dotnetgapic"
                };

                Operation insertIgmOp = instanceGroupManagersClient.Insert(projectId, zone, instanceGroupManager);
                PollForCompletion(insertIgmOp, "insert group manager");

                Operation resizeOp = instanceGroupManagersClient.Resize(
                    projectId,
                    zone,
                    instanceGroupManagerName,
                    0
                );

                PollForCompletion(resizeOp, "resize");

                var fetched = instanceGroupManagersClient.Get(projectId, zone, instanceGroupManagerName);

                Assert.Equal(0, fetched.TargetSize);
            }
            finally
            {
                Operation deleteOp = instanceGroupManagersClient.Delete(projectId, zone, instanceGroupManagerName);

                PollForCompletion(deleteOp, "delete igm");

                Operation deleteTemplateOp = instanceTemplatesClient.Delete(projectId, instanceTemplateName);

                PollForCompletionGlobalOp(deleteTemplateOp, "delete template");
            }
        }

        private Operation PollForCompletion(Operation operation, string alias)
        {
            ZoneOperationsClient zoneOperationsClient = ZoneOperationsClient.Create();

            TimeSpan timeOut = TimeSpan.FromMinutes(3);
            TimeSpan pollInterval = TimeSpan.FromSeconds(15);

            DateTime deadline = DateTime.UtcNow + timeOut;
            while (operation.Status != Operation.Types.Status.Done)
            {
                GetZoneOperationRequest request = new GetZoneOperationRequest
                {
                    Operation = operation.Name,
                    Zone = _fixture.Zone,
                    Project = _fixture.ProjectId,
                };
                _output.WriteLine($"Checking for {alias} operation status ...");
                operation = zoneOperationsClient.Get(request);

                if (operation.Status == Operation.Types.Status.Done)
                {
                    break;
                }

                if (DateTime.UtcNow > deadline)
                {
                    throw new InvalidOperationException(
                        $"Timeout hit while polling for the status of the {alias} operation\n{operation}");
                }

                _output.WriteLine($"Status: {operation.Status}. Sleeping for the {pollInterval.TotalSeconds}s");
                Thread.Sleep(pollInterval);
            }

            return operation;
        }

        private Operation PollForCompletionGlobalOp(Operation operation, string alias)
        {
            GlobalOperationsClient globalOperationClient = GlobalOperationsClient.Create();

            TimeSpan timeOut = TimeSpan.FromMinutes(3);
            TimeSpan pollInterval = TimeSpan.FromSeconds(15);

            DateTime deadline = DateTime.UtcNow + timeOut;
            while (operation.Status != Operation.Types.Status.Done)
            {
                GetGlobalOperationRequest request = new GetGlobalOperationRequest
                {
                    Operation = operation.Name,
                    Project = _fixture.ProjectId,
                };
                _output.WriteLine($"Checking for {alias} operation status ...");
                operation = globalOperationClient.Get(request);

                if (operation.Status == Operation.Types.Status.Done)
                {
                    break;
                }

                if (DateTime.UtcNow > deadline)
                {
                    throw new InvalidOperationException(
                        $"Timeout hit while polling for the status of the {alias} operation\n{operation}");
                }

                _output.WriteLine($"Status: {operation.Status}. Sleeping for the {pollInterval.TotalSeconds}s");
                Thread.Sleep(pollInterval);
            }

            return operation;
        }
    }
}