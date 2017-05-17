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

using System;
using Google.Protobuf.WellKnownTypes;

// ReSharper disable UnusedParameter.Local

namespace Google.Cloud.Spanner
{
    internal static class ValueHelper
    {
        public static object CoerceTo(object value, System.Type targetType)
        {
            throw new NotImplementedException();
        }

        public static object GetUnderlyingObject(this Value value, System.Type getFieldType)
        {
            throw new NotImplementedException();
        }
    }
}