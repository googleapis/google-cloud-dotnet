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
    public class GeneratedDebugger2ClientSnippets
    {
        public async Task SetBreakpointAsync()
        {
            // Snippet: SetBreakpointAsync(string,Breakpoint,string,CallSettings)
            // Additional: SetBreakpointAsync(string,Breakpoint,string,CancellationToken)
            // Create client
            Debugger2Client debugger2Client = await Debugger2Client.CreateAsync();
            // Initialize request argument(s)
            string debuggeeId = "";
            Breakpoint breakpoint = new Breakpoint();
            string clientVersion = "";
            // Make the request
            SetBreakpointResponse response = await debugger2Client.SetBreakpointAsync(debuggeeId, breakpoint, clientVersion);
            // End snippet
        }

        public void SetBreakpoint()
        {
            // Snippet: SetBreakpoint(string,Breakpoint,string,CallSettings)
            // Create client
            Debugger2Client debugger2Client = Debugger2Client.Create();
            // Initialize request argument(s)
            string debuggeeId = "";
            Breakpoint breakpoint = new Breakpoint();
            string clientVersion = "";
            // Make the request
            SetBreakpointResponse response = debugger2Client.SetBreakpoint(debuggeeId, breakpoint, clientVersion);
            // End snippet
        }

        public async Task SetBreakpointAsync_RequestObject()
        {
            // Snippet: SetBreakpointAsync(SetBreakpointRequest,CallSettings)
            // Create client
            Debugger2Client debugger2Client = await Debugger2Client.CreateAsync();
            // Initialize request argument(s)
            SetBreakpointRequest request = new SetBreakpointRequest
            {
                DebuggeeId = "",
                Breakpoint = new Breakpoint(),
                ClientVersion = "",
            };
            // Make the request
            SetBreakpointResponse response = await debugger2Client.SetBreakpointAsync(request);
            // End snippet
        }

        public void SetBreakpoint_RequestObject()
        {
            // Snippet: SetBreakpoint(SetBreakpointRequest,CallSettings)
            // Create client
            Debugger2Client debugger2Client = Debugger2Client.Create();
            // Initialize request argument(s)
            SetBreakpointRequest request = new SetBreakpointRequest
            {
                DebuggeeId = "",
                Breakpoint = new Breakpoint(),
                ClientVersion = "",
            };
            // Make the request
            SetBreakpointResponse response = debugger2Client.SetBreakpoint(request);
            // End snippet
        }

        public async Task GetBreakpointAsync()
        {
            // Snippet: GetBreakpointAsync(string,string,string,CallSettings)
            // Additional: GetBreakpointAsync(string,string,string,CancellationToken)
            // Create client
            Debugger2Client debugger2Client = await Debugger2Client.CreateAsync();
            // Initialize request argument(s)
            string debuggeeId = "";
            string breakpointId = "";
            string clientVersion = "";
            // Make the request
            GetBreakpointResponse response = await debugger2Client.GetBreakpointAsync(debuggeeId, breakpointId, clientVersion);
            // End snippet
        }

        public void GetBreakpoint()
        {
            // Snippet: GetBreakpoint(string,string,string,CallSettings)
            // Create client
            Debugger2Client debugger2Client = Debugger2Client.Create();
            // Initialize request argument(s)
            string debuggeeId = "";
            string breakpointId = "";
            string clientVersion = "";
            // Make the request
            GetBreakpointResponse response = debugger2Client.GetBreakpoint(debuggeeId, breakpointId, clientVersion);
            // End snippet
        }

        public async Task GetBreakpointAsync_RequestObject()
        {
            // Snippet: GetBreakpointAsync(GetBreakpointRequest,CallSettings)
            // Create client
            Debugger2Client debugger2Client = await Debugger2Client.CreateAsync();
            // Initialize request argument(s)
            GetBreakpointRequest request = new GetBreakpointRequest
            {
                DebuggeeId = "",
                BreakpointId = "",
                ClientVersion = "",
            };
            // Make the request
            GetBreakpointResponse response = await debugger2Client.GetBreakpointAsync(request);
            // End snippet
        }

        public void GetBreakpoint_RequestObject()
        {
            // Snippet: GetBreakpoint(GetBreakpointRequest,CallSettings)
            // Create client
            Debugger2Client debugger2Client = Debugger2Client.Create();
            // Initialize request argument(s)
            GetBreakpointRequest request = new GetBreakpointRequest
            {
                DebuggeeId = "",
                BreakpointId = "",
                ClientVersion = "",
            };
            // Make the request
            GetBreakpointResponse response = debugger2Client.GetBreakpoint(request);
            // End snippet
        }

        public async Task DeleteBreakpointAsync()
        {
            // Snippet: DeleteBreakpointAsync(string,string,string,CallSettings)
            // Additional: DeleteBreakpointAsync(string,string,string,CancellationToken)
            // Create client
            Debugger2Client debugger2Client = await Debugger2Client.CreateAsync();
            // Initialize request argument(s)
            string debuggeeId = "";
            string breakpointId = "";
            string clientVersion = "";
            // Make the request
            await debugger2Client.DeleteBreakpointAsync(debuggeeId, breakpointId, clientVersion);
            // End snippet
        }

        public void DeleteBreakpoint()
        {
            // Snippet: DeleteBreakpoint(string,string,string,CallSettings)
            // Create client
            Debugger2Client debugger2Client = Debugger2Client.Create();
            // Initialize request argument(s)
            string debuggeeId = "";
            string breakpointId = "";
            string clientVersion = "";
            // Make the request
            debugger2Client.DeleteBreakpoint(debuggeeId, breakpointId, clientVersion);
            // End snippet
        }

        public async Task DeleteBreakpointAsync_RequestObject()
        {
            // Snippet: DeleteBreakpointAsync(DeleteBreakpointRequest,CallSettings)
            // Create client
            Debugger2Client debugger2Client = await Debugger2Client.CreateAsync();
            // Initialize request argument(s)
            DeleteBreakpointRequest request = new DeleteBreakpointRequest
            {
                DebuggeeId = "",
                BreakpointId = "",
                ClientVersion = "",
            };
            // Make the request
            await debugger2Client.DeleteBreakpointAsync(request);
            // End snippet
        }

        public void DeleteBreakpoint_RequestObject()
        {
            // Snippet: DeleteBreakpoint(DeleteBreakpointRequest,CallSettings)
            // Create client
            Debugger2Client debugger2Client = Debugger2Client.Create();
            // Initialize request argument(s)
            DeleteBreakpointRequest request = new DeleteBreakpointRequest
            {
                DebuggeeId = "",
                BreakpointId = "",
                ClientVersion = "",
            };
            // Make the request
            debugger2Client.DeleteBreakpoint(request);
            // End snippet
        }

        public async Task ListBreakpointsAsync()
        {
            // Snippet: ListBreakpointsAsync(string,string,CallSettings)
            // Additional: ListBreakpointsAsync(string,string,CancellationToken)
            // Create client
            Debugger2Client debugger2Client = await Debugger2Client.CreateAsync();
            // Initialize request argument(s)
            string debuggeeId = "";
            string clientVersion = "";
            // Make the request
            ListBreakpointsResponse response = await debugger2Client.ListBreakpointsAsync(debuggeeId, clientVersion);
            // End snippet
        }

        public void ListBreakpoints()
        {
            // Snippet: ListBreakpoints(string,string,CallSettings)
            // Create client
            Debugger2Client debugger2Client = Debugger2Client.Create();
            // Initialize request argument(s)
            string debuggeeId = "";
            string clientVersion = "";
            // Make the request
            ListBreakpointsResponse response = debugger2Client.ListBreakpoints(debuggeeId, clientVersion);
            // End snippet
        }

        public async Task ListBreakpointsAsync_RequestObject()
        {
            // Snippet: ListBreakpointsAsync(ListBreakpointsRequest,CallSettings)
            // Create client
            Debugger2Client debugger2Client = await Debugger2Client.CreateAsync();
            // Initialize request argument(s)
            ListBreakpointsRequest request = new ListBreakpointsRequest
            {
                DebuggeeId = "",
                ClientVersion = "",
            };
            // Make the request
            ListBreakpointsResponse response = await debugger2Client.ListBreakpointsAsync(request);
            // End snippet
        }

        public void ListBreakpoints_RequestObject()
        {
            // Snippet: ListBreakpoints(ListBreakpointsRequest,CallSettings)
            // Create client
            Debugger2Client debugger2Client = Debugger2Client.Create();
            // Initialize request argument(s)
            ListBreakpointsRequest request = new ListBreakpointsRequest
            {
                DebuggeeId = "",
                ClientVersion = "",
            };
            // Make the request
            ListBreakpointsResponse response = debugger2Client.ListBreakpoints(request);
            // End snippet
        }

        public async Task ListDebuggeesAsync()
        {
            // Snippet: ListDebuggeesAsync(string,string,CallSettings)
            // Additional: ListDebuggeesAsync(string,string,CancellationToken)
            // Create client
            Debugger2Client debugger2Client = await Debugger2Client.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string clientVersion = "";
            // Make the request
            ListDebuggeesResponse response = await debugger2Client.ListDebuggeesAsync(project, clientVersion);
            // End snippet
        }

        public void ListDebuggees()
        {
            // Snippet: ListDebuggees(string,string,CallSettings)
            // Create client
            Debugger2Client debugger2Client = Debugger2Client.Create();
            // Initialize request argument(s)
            string project = "";
            string clientVersion = "";
            // Make the request
            ListDebuggeesResponse response = debugger2Client.ListDebuggees(project, clientVersion);
            // End snippet
        }

        public async Task ListDebuggeesAsync_RequestObject()
        {
            // Snippet: ListDebuggeesAsync(ListDebuggeesRequest,CallSettings)
            // Create client
            Debugger2Client debugger2Client = await Debugger2Client.CreateAsync();
            // Initialize request argument(s)
            ListDebuggeesRequest request = new ListDebuggeesRequest
            {
                Project = "",
                ClientVersion = "",
            };
            // Make the request
            ListDebuggeesResponse response = await debugger2Client.ListDebuggeesAsync(request);
            // End snippet
        }

        public void ListDebuggees_RequestObject()
        {
            // Snippet: ListDebuggees(ListDebuggeesRequest,CallSettings)
            // Create client
            Debugger2Client debugger2Client = Debugger2Client.Create();
            // Initialize request argument(s)
            ListDebuggeesRequest request = new ListDebuggeesRequest
            {
                Project = "",
                ClientVersion = "",
            };
            // Make the request
            ListDebuggeesResponse response = debugger2Client.ListDebuggees(request);
            // End snippet
        }

    }
}
