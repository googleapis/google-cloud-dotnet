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
                _fixture.PollUntilCompleted(insertOp, "create", _output);
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
                deleteOp = _fixture.PollUntilCompleted(deleteOp, "delete", _output);
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
                _fixture.PollUntilCompleted(stopOp, "stop", _output);
                Operation patchOp = instancesClient.UpdateShieldedInstanceConfig(
                    projectId,
                    zone,
                    instanceName,
                    shieldedInstanceConfigResource);
                _fixture.PollUntilCompleted(patchOp, "patch", _output);
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
                _fixture.PollUntilCompleted(insertTemplateOp, "insert template", _output);

                InstanceGroupManager instanceGroupManager = new InstanceGroupManager
                {
                    InstanceTemplate = insertTemplateOp.TargetLink,
                    TargetSize = 1,
                    Name = instanceGroupManagerName,
                    BaseInstanceName = "dotnetgapic"
                };

                Operation insertIgmOp = instanceGroupManagersClient.Insert(projectId, zone, instanceGroupManager);
                _fixture.PollUntilCompleted(insertIgmOp, "insert group manager", _output);

                Operation resizeOp = instanceGroupManagersClient.Resize(
                    projectId,
                    zone,
                    instanceGroupManagerName,
                    0
                );

                _fixture.PollUntilCompleted(resizeOp, "resize", _output);

                var fetched = instanceGroupManagersClient.Get(projectId, zone, instanceGroupManagerName);

                Assert.Equal(0, fetched.TargetSize);
            }
            finally
            {
                Operation deleteOp = instanceGroupManagersClient.Delete(projectId, zone, instanceGroupManagerName);

                _fixture.PollUntilCompleted(deleteOp, "delete igm", _output);

                Operation deleteTemplateOp = instanceTemplatesClient.Delete(projectId, instanceTemplateName);

                _fixture.PollUntilCompleted(deleteTemplateOp, "delete template", _output);
            }
        }
    }
}