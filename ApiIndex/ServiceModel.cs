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
using System.Collections.Generic;
using System.Linq;

namespace Google.Cloud.Tools.ApiIndex
{
    /// <summary>
    /// Internal representation of a service, without reference to any specific schema version.
    /// </summary>
    public class ServiceModel
    {
        private ServiceDescriptor _service;

        public IReadOnlyList<MethodModel> Methods { get; }

        public ServiceModel(ServiceDescriptor service)
        {
            this._service = service;
            Methods = service.Methods
                .OrderBy(method => method.Name)
                .Select(method => new MethodModel(method))
                .ToList()
                .AsReadOnly();
        }

        public V1.Service ToV1Service() => new V1.Service
        {
            FullName = _service.FullName,
            ShortName = _service.Name,
            Methods = { Methods.Select(m => m.ToV1Method()) }
        };        
    }
}
