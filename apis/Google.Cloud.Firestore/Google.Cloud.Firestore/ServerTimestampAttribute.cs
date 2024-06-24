// Copyright 2018, Google LLC
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

using System;

namespace Google.Cloud.Firestore
{
    /// <summary>
    /// Attribute indicating that the value of the property within the .NET object should be ignored
    /// when creating or modifying a document. Instead, the server time of the commit that creates
    /// or modifies the document is automatically used to populate the value in the Firestore document.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public sealed class ServerTimestampAttribute  : Attribute
    {
    }
}
