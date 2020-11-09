// Copyright 2020, Google LLC
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

using Google.Protobuf.Reflection;
using System.Linq;
using static Google.Cloud.Tools.ApiIndex.V1.Method.Types;

namespace Google.Cloud.Tools.ApiIndex
{
    /// <summary>
    /// Internal representation of a service, without reference to any specific schema version.
    /// </summary>
    public class ServiceModel
    {
        private ServiceDescriptor service;

        public ServiceModel(ServiceDescriptor service)
        {
            this.service = service;
        }

        public V1.Service ToV1Service() => new V1.Service
        {
            FullName = service.FullName,
            ShortName = service.Name,
            Methods = { service.Methods.OrderBy(method => method.Name).Select(ConvertMethod) }
        };

        private static V1.Method ConvertMethod(MethodDescriptor method) => new V1.Method
        {
            FullName = method.FullName,
            ShortName = method.Name,
            Mode = method.IsClientStreaming && method.IsServerStreaming ? Mode.BidirectionalStreaming
               : method.IsClientStreaming ? Mode.ClientStreaming
               : method.IsServerStreaming ? Mode.ServerStreaming
               : Mode.Unary            
        };
        
    }
}
