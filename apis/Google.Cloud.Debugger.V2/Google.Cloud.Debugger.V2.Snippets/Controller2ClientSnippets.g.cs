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
using Google.Cloud.Debugger.V2;
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

namespace Google.Cloud.Debugger.V2.Snippets
{
    public class GeneratedController2ClientSnippets
    {
        public async Task RegisterDebuggeeAsync()
        {
            // Snippet: RegisterDebuggeeAsync(Debuggee,CallSettings)
            // Additional: RegisterDebuggeeAsync(Debuggee,CancellationToken)
            // Create client
            Controller2Client controller2Client = await Controller2Client.CreateAsync();
            // Initialize request argument(s)
            Debuggee debuggee = new Debuggee();
            // Make the request
            RegisterDebuggeeResponse response = await controller2Client.RegisterDebuggeeAsync(debuggee);
            // End snippet
        }

        public void RegisterDebuggee()
        {
            // Snippet: RegisterDebuggee(Debuggee,CallSettings)
            // Create client
            Controller2Client controller2Client = Controller2Client.Create();
            // Initialize request argument(s)
            Debuggee debuggee = new Debuggee();
            // Make the request
            RegisterDebuggeeResponse response = controller2Client.RegisterDebuggee(debuggee);
            // End snippet
        }

        public async Task RegisterDebuggeeAsync_RequestObject()
        {
            // Snippet: RegisterDebuggeeAsync(RegisterDebuggeeRequest,CallSettings)
            // Create client
            Controller2Client controller2Client = await Controller2Client.CreateAsync();
            // Initialize request argument(s)
            RegisterDebuggeeRequest request = new RegisterDebuggeeRequest
            {
                Debuggee = new Debuggee(),
            };
            // Make the request
            RegisterDebuggeeResponse response = await controller2Client.RegisterDebuggeeAsync(request);
            // End snippet
        }

        public void RegisterDebuggee_RequestObject()
        {
            // Snippet: RegisterDebuggee(RegisterDebuggeeRequest,CallSettings)
            // Create client
            Controller2Client controller2Client = Controller2Client.Create();
            // Initialize request argument(s)
            RegisterDebuggeeRequest request = new RegisterDebuggeeRequest
            {
                Debuggee = new Debuggee(),
            };
            // Make the request
            RegisterDebuggeeResponse response = controller2Client.RegisterDebuggee(request);
            // End snippet
        }

        public async Task ListActiveBreakpointsAsync()
        {
            // Snippet: ListActiveBreakpointsAsync(string,CallSettings)
            // Additional: ListActiveBreakpointsAsync(string,CancellationToken)
            // Create client
            Controller2Client controller2Client = await Controller2Client.CreateAsync();
            // Initialize request argument(s)
            string debuggeeId = "";
            // Make the request
            ListActiveBreakpointsResponse response = await controller2Client.ListActiveBreakpointsAsync(debuggeeId);
            // End snippet
        }

        public void ListActiveBreakpoints()
        {
            // Snippet: ListActiveBreakpoints(string,CallSettings)
            // Create client
            Controller2Client controller2Client = Controller2Client.Create();
            // Initialize request argument(s)
            string debuggeeId = "";
            // Make the request
            ListActiveBreakpointsResponse response = controller2Client.ListActiveBreakpoints(debuggeeId);
            // End snippet
        }

        public async Task ListActiveBreakpointsAsync_RequestObject()
        {
            // Snippet: ListActiveBreakpointsAsync(ListActiveBreakpointsRequest,CallSettings)
            // Create client
            Controller2Client controller2Client = await Controller2Client.CreateAsync();
            // Initialize request argument(s)
            ListActiveBreakpointsRequest request = new ListActiveBreakpointsRequest
            {
                DebuggeeId = "",
            };
            // Make the request
            ListActiveBreakpointsResponse response = await controller2Client.ListActiveBreakpointsAsync(request);
            // End snippet
        }

        public void ListActiveBreakpoints_RequestObject()
        {
            // Snippet: ListActiveBreakpoints(ListActiveBreakpointsRequest,CallSettings)
            // Create client
            Controller2Client controller2Client = Controller2Client.Create();
            // Initialize request argument(s)
            ListActiveBreakpointsRequest request = new ListActiveBreakpointsRequest
            {
                DebuggeeId = "",
            };
            // Make the request
            ListActiveBreakpointsResponse response = controller2Client.ListActiveBreakpoints(request);
            // End snippet
        }

        public async Task UpdateActiveBreakpointAsync()
        {
            // Snippet: UpdateActiveBreakpointAsync(string,Breakpoint,CallSettings)
            // Additional: UpdateActiveBreakpointAsync(string,Breakpoint,CancellationToken)
            // Create client
            Controller2Client controller2Client = await Controller2Client.CreateAsync();
            // Initialize request argument(s)
            string debuggeeId = "";
            Breakpoint breakpoint = new Breakpoint();
            // Make the request
            UpdateActiveBreakpointResponse response = await controller2Client.UpdateActiveBreakpointAsync(debuggeeId, breakpoint);
            // End snippet
        }

        public void UpdateActiveBreakpoint()
        {
            // Snippet: UpdateActiveBreakpoint(string,Breakpoint,CallSettings)
            // Create client
            Controller2Client controller2Client = Controller2Client.Create();
            // Initialize request argument(s)
            string debuggeeId = "";
            Breakpoint breakpoint = new Breakpoint();
            // Make the request
            UpdateActiveBreakpointResponse response = controller2Client.UpdateActiveBreakpoint(debuggeeId, breakpoint);
            // End snippet
        }

        public async Task UpdateActiveBreakpointAsync_RequestObject()
        {
            // Snippet: UpdateActiveBreakpointAsync(UpdateActiveBreakpointRequest,CallSettings)
            // Create client
            Controller2Client controller2Client = await Controller2Client.CreateAsync();
            // Initialize request argument(s)
            UpdateActiveBreakpointRequest request = new UpdateActiveBreakpointRequest
            {
                DebuggeeId = "",
                Breakpoint = new Breakpoint(),
            };
            // Make the request
            UpdateActiveBreakpointResponse response = await controller2Client.UpdateActiveBreakpointAsync(request);
            // End snippet
        }

        public void UpdateActiveBreakpoint_RequestObject()
        {
            // Snippet: UpdateActiveBreakpoint(UpdateActiveBreakpointRequest,CallSettings)
            // Create client
            Controller2Client controller2Client = Controller2Client.Create();
            // Initialize request argument(s)
            UpdateActiveBreakpointRequest request = new UpdateActiveBreakpointRequest
            {
                DebuggeeId = "",
                Breakpoint = new Breakpoint(),
            };
            // Make the request
            UpdateActiveBreakpointResponse response = controller2Client.UpdateActiveBreakpoint(request);
            // End snippet
        }

    }
}
