// Copyright 2016 Google Inc. All Rights Reserved.
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

// SAMPLE CODE ONLY: THIS IS FOR DISCUSSION, NOT RELEASE!

using Google.Longrunning;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Threading.Tasks;

// This is an example of the generated client code for a "Deep Thought" API
// that uses long-running operations. It doesn't have the normal base/subclass split,
// just for simplicity - we're concentrating on what the customer code will look like.
namespace Google.DeepThought.V1
{
    public class DeepThoughtClient
    {
        // This wouldn't really be dynamic, of course. It's just to hide the details.
        private dynamic grpcClient;

        // An OperationsClient sharing the gRPC channel with this one.
        private OperationsClient operationsClient;

        public static DeepThoughtClient Create() => new DeepThoughtClient();

        public static Task<DeepThoughtClient> CreateAsync() => Task.FromResult(Create());

        public Operation<ContemplateLifeResponse> ContemplateLife(string question)
        {
            Operation response = grpcClient.ContemplateLife(new ContemplateLifeRequest { Question = question });
            return new Operation<ContemplateLifeResponse>(response, operationsClient);
        }

        public async Task<Operation<ContemplateLifeResponse>> ContemplateLifeAsync(string question)
        {
            Operation response = await grpcClient.ContemplateLifeAsync(new ContemplateLifeRequest { Question = question });
            return new Operation<ContemplateLifeResponse>(response, operationsClient);
        }

        // TODO: Rethink the "resume" name here. It's not like we've paused the operation; we're just catching up with
        // what's been going on...
        public Operation<ContemplateLifeResponse> ResumeContemplateLife(string name)
        {
            Operation response = operationsClient.GetOperation(name);
            return new Operation<ContemplateLifeResponse>(response, operationsClient);
        }

        public async Task<Operation<ContemplateLifeResponse>> ResumeContemplateLifeAsync(string name)
        {
            Operation response = await operationsClient.GetOperationAsync(name);
            return new Operation<ContemplateLifeResponse>(response, operationsClient);
        }
    }

    public class ContemplateLifeRequest
    {
        public string Question { get; set; }
    }

    public class ContemplateLifeResponse : IMessage<ContemplateLifeResponse>
    {
        public int Answer { get; set; }

        // Code provided by protobuf.
        MessageDescriptor IMessage.Descriptor => null;
        int IMessage.CalculateSize() => 0;
        ContemplateLifeResponse IDeepCloneable<ContemplateLifeResponse>.Clone() => null;
        bool IEquatable<ContemplateLifeResponse>.Equals(ContemplateLifeResponse other) => true;
        void IMessage.MergeFrom(CodedInputStream input) => { }
        void IMessage<ContemplateLifeResponse>.MergeFrom(ContemplateLifeResponse message) { }
        void IMessage.WriteTo(CodedOutputStream output) { }
    }
}
