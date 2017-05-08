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

using Google.Cloud.Logging.V2;
using Google.Protobuf.WellKnownTypes;
using System;

namespace Google.Cloud.Logging.Log4Net
{
    internal static class Extensions
    {
        public static Timestamp ToTimestamp(this DateTime dt)
        {
            switch (dt.Kind)
            {
                case DateTimeKind.Local:
                    dt = dt.ToUniversalTime();
                    break;
                case DateTimeKind.Unspecified:
                    dt = DateTime.SpecifyKind(dt, DateTimeKind.Utc);
                    break;
            }
            return Timestamp.FromDateTime(dt);
        }
    }
}
