// Copyright 2017 Google Inc. All Rights Reserved.
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

using Google.Cloud.Diagnostics.Common;
using System.Web;

namespace Google.Cloud.Diagnostics.AspNet
{
    /// <summary>
    /// Manages storage of instances of types for the current <see cref="HttpContext"/>.
    /// </summary>
    internal static class ContextInstanceManager
    {
        /// <summary>
        /// Sets the current value for a type.
        /// </summary>
        public static void Set<T>(T obj) => 
            HttpContext.Current.Items[typeof(T)] = obj;

        /// <summary>
        /// Gets the current value for a type.
        /// </summary>
        public static T Get<T>() => (T)HttpContext.Current.Items[typeof(T)];
    }
}