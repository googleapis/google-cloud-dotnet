// Copyright 2017, Google Inc. All rights reserved.
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

// Generated code. DO NOT EDIT!

using Google.Api.Gax;
using Google.Api.Gax.Grpc;
using Google.Cloud.ErrorReporting.V1Beta1;
using Google.Protobuf;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.ErrorReporting.V1Beta1.Snippets
{
    public class GeneratedErrorGroupServiceClientSnippets
    {
        public async Task GetGroupAsync()
        {
            // Snippet: GetGroupAsync(GroupName,CallSettings)
            // Additional: GetGroupAsync(GroupName,CancellationToken)
            // Create client
            ErrorGroupServiceClient errorGroupServiceClient = await ErrorGroupServiceClient.CreateAsync();
            // Initialize request argument(s)
            GroupName groupName = new GroupName("[PROJECT]", "[GROUP]");
            // Make the request
            ErrorGroup response = await errorGroupServiceClient.GetGroupAsync(groupName);
            // End snippet
        }

        public void GetGroup()
        {
            // Snippet: GetGroup(GroupName,CallSettings)
            // Create client
            ErrorGroupServiceClient errorGroupServiceClient = ErrorGroupServiceClient.Create();
            // Initialize request argument(s)
            GroupName groupName = new GroupName("[PROJECT]", "[GROUP]");
            // Make the request
            ErrorGroup response = errorGroupServiceClient.GetGroup(groupName);
            // End snippet
        }

        public async Task GetGroupAsync_RequestObject()
        {
            // Snippet: GetGroupAsync(GetGroupRequest,CallSettings)
            // Create client
            ErrorGroupServiceClient errorGroupServiceClient = await ErrorGroupServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetGroupRequest request = new GetGroupRequest
            {
                GroupNameAsGroupName = new GroupName("[PROJECT]", "[GROUP]"),
            };
            // Make the request
            ErrorGroup response = await errorGroupServiceClient.GetGroupAsync(request);
            // End snippet
        }

        public void GetGroup_RequestObject()
        {
            // Snippet: GetGroup(GetGroupRequest,CallSettings)
            // Create client
            ErrorGroupServiceClient errorGroupServiceClient = ErrorGroupServiceClient.Create();
            // Initialize request argument(s)
            GetGroupRequest request = new GetGroupRequest
            {
                GroupNameAsGroupName = new GroupName("[PROJECT]", "[GROUP]"),
            };
            // Make the request
            ErrorGroup response = errorGroupServiceClient.GetGroup(request);
            // End snippet
        }

        public async Task UpdateGroupAsync()
        {
            // Snippet: UpdateGroupAsync(ErrorGroup,CallSettings)
            // Additional: UpdateGroupAsync(ErrorGroup,CancellationToken)
            // Create client
            ErrorGroupServiceClient errorGroupServiceClient = await ErrorGroupServiceClient.CreateAsync();
            // Initialize request argument(s)
            ErrorGroup group = new ErrorGroup();
            // Make the request
            ErrorGroup response = await errorGroupServiceClient.UpdateGroupAsync(group);
            // End snippet
        }

        public void UpdateGroup()
        {
            // Snippet: UpdateGroup(ErrorGroup,CallSettings)
            // Create client
            ErrorGroupServiceClient errorGroupServiceClient = ErrorGroupServiceClient.Create();
            // Initialize request argument(s)
            ErrorGroup group = new ErrorGroup();
            // Make the request
            ErrorGroup response = errorGroupServiceClient.UpdateGroup(group);
            // End snippet
        }

        public async Task UpdateGroupAsync_RequestObject()
        {
            // Snippet: UpdateGroupAsync(UpdateGroupRequest,CallSettings)
            // Create client
            ErrorGroupServiceClient errorGroupServiceClient = await ErrorGroupServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateGroupRequest request = new UpdateGroupRequest
            {
                Group = new ErrorGroup(),
            };
            // Make the request
            ErrorGroup response = await errorGroupServiceClient.UpdateGroupAsync(request);
            // End snippet
        }

        public void UpdateGroup_RequestObject()
        {
            // Snippet: UpdateGroup(UpdateGroupRequest,CallSettings)
            // Create client
            ErrorGroupServiceClient errorGroupServiceClient = ErrorGroupServiceClient.Create();
            // Initialize request argument(s)
            UpdateGroupRequest request = new UpdateGroupRequest
            {
                Group = new ErrorGroup(),
            };
            // Make the request
            ErrorGroup response = errorGroupServiceClient.UpdateGroup(request);
            // End snippet
        }

    }
}
