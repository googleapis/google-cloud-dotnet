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

namespace Google.Cloud.Debugger.V2.Snippets
{
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedController2ClientSnippets
    {
        /// <summary>Snippet for RegisterDebuggee</summary>
        public void RegisterDebuggeeRequestObject()
        {
            // Snippet: RegisterDebuggee(RegisterDebuggeeRequest, CallSettings)
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

        /// <summary>Snippet for RegisterDebuggeeAsync</summary>
        public async Task RegisterDebuggeeRequestObjectAsync()
        {
            // Snippet: RegisterDebuggeeAsync(RegisterDebuggeeRequest, CallSettings)
            // Additional: RegisterDebuggeeAsync(RegisterDebuggeeRequest, CancellationToken)
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

        /// <summary>Snippet for RegisterDebuggee</summary>
        public void RegisterDebuggee()
        {
            // Snippet: RegisterDebuggee(Debuggee, CallSettings)
            // Create client
            Controller2Client controller2Client = Controller2Client.Create();
            // Initialize request argument(s)
            Debuggee debuggee = new Debuggee();
            // Make the request
            RegisterDebuggeeResponse response = controller2Client.RegisterDebuggee(debuggee);
            // End snippet
        }

        /// <summary>Snippet for RegisterDebuggeeAsync</summary>
        public async Task RegisterDebuggeeAsync()
        {
            // Snippet: RegisterDebuggeeAsync(Debuggee, CallSettings)
            // Additional: RegisterDebuggeeAsync(Debuggee, CancellationToken)
            // Create client
            Controller2Client controller2Client = await Controller2Client.CreateAsync();
            // Initialize request argument(s)
            Debuggee debuggee = new Debuggee();
            // Make the request
            RegisterDebuggeeResponse response = await controller2Client.RegisterDebuggeeAsync(debuggee);
            // End snippet
        }

        /// <summary>Snippet for ListActiveBreakpoints</summary>
        public void ListActiveBreakpointsRequestObject()
        {
            // Snippet: ListActiveBreakpoints(ListActiveBreakpointsRequest, CallSettings)
            // Create client
            Controller2Client controller2Client = Controller2Client.Create();
            // Initialize request argument(s)
            ListActiveBreakpointsRequest request = new ListActiveBreakpointsRequest
            {
                DebuggeeId = "",
                WaitToken = "",
                SuccessOnTimeout = false,
            };
            // Make the request
            ListActiveBreakpointsResponse response = controller2Client.ListActiveBreakpoints(request);
            // End snippet
        }

        /// <summary>Snippet for ListActiveBreakpointsAsync</summary>
        public async Task ListActiveBreakpointsRequestObjectAsync()
        {
            // Snippet: ListActiveBreakpointsAsync(ListActiveBreakpointsRequest, CallSettings)
            // Additional: ListActiveBreakpointsAsync(ListActiveBreakpointsRequest, CancellationToken)
            // Create client
            Controller2Client controller2Client = await Controller2Client.CreateAsync();
            // Initialize request argument(s)
            ListActiveBreakpointsRequest request = new ListActiveBreakpointsRequest
            {
                DebuggeeId = "",
                WaitToken = "",
                SuccessOnTimeout = false,
            };
            // Make the request
            ListActiveBreakpointsResponse response = await controller2Client.ListActiveBreakpointsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ListActiveBreakpoints</summary>
        public void ListActiveBreakpoints()
        {
            // Snippet: ListActiveBreakpoints(string, CallSettings)
            // Create client
            Controller2Client controller2Client = Controller2Client.Create();
            // Initialize request argument(s)
            string debuggeeId = "";
            // Make the request
            ListActiveBreakpointsResponse response = controller2Client.ListActiveBreakpoints(debuggeeId);
            // End snippet
        }

        /// <summary>Snippet for ListActiveBreakpointsAsync</summary>
        public async Task ListActiveBreakpointsAsync()
        {
            // Snippet: ListActiveBreakpointsAsync(string, CallSettings)
            // Additional: ListActiveBreakpointsAsync(string, CancellationToken)
            // Create client
            Controller2Client controller2Client = await Controller2Client.CreateAsync();
            // Initialize request argument(s)
            string debuggeeId = "";
            // Make the request
            ListActiveBreakpointsResponse response = await controller2Client.ListActiveBreakpointsAsync(debuggeeId);
            // End snippet
        }

        /// <summary>Snippet for UpdateActiveBreakpoint</summary>
        public void UpdateActiveBreakpointRequestObject()
        {
            // Snippet: UpdateActiveBreakpoint(UpdateActiveBreakpointRequest, CallSettings)
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

        /// <summary>Snippet for UpdateActiveBreakpointAsync</summary>
        public async Task UpdateActiveBreakpointRequestObjectAsync()
        {
            // Snippet: UpdateActiveBreakpointAsync(UpdateActiveBreakpointRequest, CallSettings)
            // Additional: UpdateActiveBreakpointAsync(UpdateActiveBreakpointRequest, CancellationToken)
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

        /// <summary>Snippet for UpdateActiveBreakpoint</summary>
        public void UpdateActiveBreakpoint()
        {
            // Snippet: UpdateActiveBreakpoint(string, Breakpoint, CallSettings)
            // Create client
            Controller2Client controller2Client = Controller2Client.Create();
            // Initialize request argument(s)
            string debuggeeId = "";
            Breakpoint breakpoint = new Breakpoint();
            // Make the request
            UpdateActiveBreakpointResponse response = controller2Client.UpdateActiveBreakpoint(debuggeeId, breakpoint);
            // End snippet
        }

        /// <summary>Snippet for UpdateActiveBreakpointAsync</summary>
        public async Task UpdateActiveBreakpointAsync()
        {
            // Snippet: UpdateActiveBreakpointAsync(string, Breakpoint, CallSettings)
            // Additional: UpdateActiveBreakpointAsync(string, Breakpoint, CancellationToken)
            // Create client
            Controller2Client controller2Client = await Controller2Client.CreateAsync();
            // Initialize request argument(s)
            string debuggeeId = "";
            Breakpoint breakpoint = new Breakpoint();
            // Make the request
            UpdateActiveBreakpointResponse response = await controller2Client.UpdateActiveBreakpointAsync(debuggeeId, breakpoint);
            // End snippet
        }
    }
}
