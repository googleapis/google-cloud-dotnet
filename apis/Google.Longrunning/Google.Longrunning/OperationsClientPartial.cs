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

using Google.Api.Gax;
using System;

namespace Google.Longrunning
{
    public partial class OperationsClient
    {
        /// <summary>
        /// The clock used for timeouts, retries and polling.
        /// </summary>
        public virtual IClock Clock
        {
            get { throw new NotImplementedException(); }
        }

        /// <summary>
        /// The scheduler used for timeouts, retries and polling.
        /// </summary>
        public virtual IScheduler Scheduler
        {
            get { throw new NotImplementedException(); }
        }
    }

    public partial class OperationsClientImpl
    {
        /// <inheritdoc />
        public override IClock Clock => _clientHelper.Clock;

        /// <inheritdoc />
        public override IScheduler Scheduler => _clientHelper.Scheduler;
    }
}
