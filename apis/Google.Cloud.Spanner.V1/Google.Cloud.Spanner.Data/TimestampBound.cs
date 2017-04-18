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

namespace Google.Cloud.Spanner
{
    /// <summary>
    /// </summary>
    public class TimestampBound
    {
        /// <summary>
        /// </summary>
        public TimestampBoundMode Mode
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        /// <summary>
        /// </summary>
        public TimeSpan Staleness
        {
            get { throw new NotImplementedException(); }
        }

        /// <summary>
        /// </summary>
        public static TimestampBound Strong
        {
            get { throw new NotImplementedException(); }
        }

        /// <summary>
        /// </summary>
        public DateTime TimeStamp
        {
            get { throw new NotImplementedException(); }
        }

        /// <summary>
        /// </summary>
        /// <param name="duration"></param>
        /// <returns></returns>
        public static TimestampBound OfExactStaleness(TimeSpan duration)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// </summary>
        /// <param name="duration"></param>
        /// <returns></returns>
        public static TimestampBound OfMaxStaleness(TimeSpan duration)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// </summary>
        /// <param name="timestamp"></param>
        /// <returns></returns>
        public static TimestampBound OfMinReadTimestamp(DateTime timestamp)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// </summary>
        /// <param name="timestamp"></param>
        /// <returns></returns>
        public static TimestampBound OfReadTimestamp(DateTime timestamp)
        {
            throw new NotImplementedException();
        }
    }
}