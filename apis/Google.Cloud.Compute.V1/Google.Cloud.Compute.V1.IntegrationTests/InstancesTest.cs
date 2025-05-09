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
        private const string DiskImage = "projects/debian-cloud/global/images/family/debian-12";

        private readonly ITestOutputHelper _output;
        private readonly ComputeFixture _fixture;

        public InstancesTest(ComputeFixture fixture, ITestOutputHelper output) =>
            (_fixture, _output) = (fixture, output);

        [Fact]
        public void CreateInstance()
        {
            string projectId = _fixture.ProjectId;
            string zone = _fixture.Zone;
            string machineType =
                $"https://www.googleapis.com/compute/v1/projects/{projectId}/zones/{zone}/machineTypes/n1-standard-1";
            InstancesClient instancesClient = InstancesClient.Create();
            var instanceName = _fixture.GenerateResourceId();

            CreateInstanceNonAsciiDescription();
            FetchInstance();
            PatchInstance();
            UpdateDescriptionEmptyString();
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
                            Type = ComputeEnumConstants.AttachedDisk.Type.Persistent,
                            InitializeParams = new AttachedDiskInitializeParams {SourceImage = DiskImage}
                        }
                    },
                    NetworkInterfaces = {new NetworkInterface {Name = "default"}}
                };
                var insertOp = instancesClient.Insert(projectId, zone, instanceResource);
                var completed = insertOp.PollUntilCompleted(metadataCallback: metadata => _output.WriteLine($"Called back; metadata name={metadata.Name}"));
                Assert.Null(completed.Exception);
                Assert.True(completed.IsCompleted);
                _output.WriteLine($"Polling completed with result {completed.RpcMessage}");
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

            /// <summary>
            /// We want to test here: 1)set body field to empty string
            ///                       2)optional body field not set
            /// </summary>
            void UpdateDescriptionEmptyString()
            {
                Instance instance = instancesClient.Get(projectId, zone, instanceName);
                Assert.Equal("тест", instance.Description);
                Assert.Equal(0, instance.Scheduling.MinNodeCpus);
                instance.Description = "";
                var updateOp = instancesClient.Update(projectId, zone, instanceName, instance);
                updateOp.PollUntilCompleted();
                var fetched = instancesClient.Get(projectId, zone, instanceName);
                Assert.Equal("", fetched.Description);
                Assert.Equal(0, instance.Scheduling.MinNodeCpus);
            }

            void DeleteInstance()
            {
                _output.WriteLine($"Deleting instance with the name: {instanceName}");
                var deleteOp = instancesClient.Delete(projectId, zone, instanceName);
                deleteOp = deleteOp.PollUntilCompleted();
                var result = deleteOp.Result;
                _output.WriteLine(
                    $"Operation to delete instance completed: status {result.Status}; start time {result.StartTime}; end time {result.EndTime}");
            }

            void PatchInstance()
            {
                ShieldedInstanceConfig shieldedInstanceConfigResource = new ShieldedInstanceConfig
                {
                    EnableSecureBoot = true
                };
                var stopOp = instancesClient.Stop(projectId, zone, instanceName);
                stopOp.PollUntilCompleted();
                var patchOp = instancesClient.UpdateShieldedInstanceConfig(
                    projectId,
                    zone,
                    instanceName,
                    shieldedInstanceConfigResource);
                patchOp.PollUntilCompleted();
                Instance instance = instancesClient.Get(projectId, zone, instanceName);
                Assert.Equal(true, instance.ShieldedInstanceConfig.EnableSecureBoot);
            }
        }

        /// <summary>
        /// We want to test here: 1)set body field to zero
        ///                       2)set query param to zero
        /// </summary>
        [Fact]
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
                        Type = ComputeEnumConstants.AttachedDisk.Type.Persistent,
                        InitializeParams = new AttachedDiskInitializeParams
                        {
                            SourceImage = DiskImage
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
                var insertTemplateOp = instanceTemplatesClient.Insert(projectId, instanceTemplate);
                var completed = insertTemplateOp.PollUntilCompleted(metadataCallback: metadata => _output.WriteLine($"Called back; metadata name={metadata.Name}"));
                _output.WriteLine($"Polling completed with result {completed.RpcMessage}");

                InstanceGroupManager instanceGroupManager = new InstanceGroupManager
                {
                    InstanceTemplate = completed.Result.TargetLink,
                    TargetSize = 0,
                    Name = instanceGroupManagerName,
                    BaseInstanceName = "dotnetgapic"
                };

                var insertIgmOp = instanceGroupManagersClient.Insert(projectId, zone, instanceGroupManager);
                insertIgmOp.PollUntilCompleted();
                var inserted = instanceGroupManagersClient.Get(projectId, zone, instanceGroupManagerName);
                Assert.Equal(0, inserted.TargetSize);

                var resizeOp = instanceGroupManagersClient.Resize(
                    projectId,
                    zone,
                    instanceGroupManagerName,
                    1
                );
                resizeOp.PollUntilCompleted();

                var resizedTo1 = instanceGroupManagersClient.Get(projectId, zone, instanceGroupManagerName);
                Assert.Equal(1, resizedTo1.TargetSize);

                var resizeToZeroOp = instanceGroupManagersClient.Resize(
                    projectId,
                    zone,
                    instanceGroupManagerName,
                    0
                );
                resizeToZeroOp.PollUntilCompleted();

                var fetched = instanceGroupManagersClient.Get(projectId, zone, instanceGroupManagerName);
                _output.WriteLine($"fetched target size is {fetched.TargetSize} ");
                Assert.Equal(0, fetched.TargetSize);
            }
            finally
            {
                var deleteOp = instanceGroupManagersClient.Delete(projectId, zone, instanceGroupManagerName);
                deleteOp.PollUntilCompleted();

                var deleteTemplateOp = instanceTemplatesClient.Delete(projectId, instanceTemplateName);
                deleteTemplateOp.PollUntilCompleted();
            }
        }
    }
}
