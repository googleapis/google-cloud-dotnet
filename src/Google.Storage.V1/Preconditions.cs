// Copyright 2015 Google Inc. All Rights Reserved.
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

using Google.Api.Gax.Rest;
using System;

// Note: we'd really like to have a Google.Common package, but at the moment
// it would only contain Preconditions, which seems a small benefit for the cost
// of a dependency (and repo). Until then, this class will be copied and pasted in various
// places. Where it needs to be public, it should be given a project-specific name; where it
// can be entirely internal, we can leave it as "Preconditions".

namespace Google.Storage.V1
{
    /// <summary>
    /// Additional preconditions currently not supported by GaxRestPreconditions.
    /// </summary>
    internal static class Preconditions
    {
        internal static T CheckEnumValue<T>(T value, string paramName) where T : struct
        {
            GaxRestPreconditions.CheckArgument(Enum.IsDefined(typeof(T), value), paramName,
                "Value {0} not defined in enum {1}", value, typeof(T).Name);
            return value;
        }
    }
}