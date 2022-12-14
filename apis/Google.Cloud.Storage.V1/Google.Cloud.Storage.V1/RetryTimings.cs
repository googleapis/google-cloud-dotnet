// Copyright 2022 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License").
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at 
//
// https://www.apache.org/licenses/LICENSE-2.0 
//
// Unless required by applicable law or agreed to in writing, software 
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and 
// limitations under the License.

using System;
using System.Collections.Generic;
using System.Text;

namespace Google.Cloud.Storage.V1;


public sealed class RetryTimings
{
    public static RetryTimings Default { get; }

    public int MaxAttempts { get; private set; }
    public int InitialBackoff { get; private set; }
    public int MaxBackoff { get; private set; }
    public int BackoffMultiplier { get; private set; }

    public RetryTimings WithMaxAttempts(int maxAttempts);
    public RetryTimings WithInitialBackoff(int initialBackoff);
    public RetryTimings WithMaxBackoff(int maxBackoff);
    public RetryTimings WithBackoffMultiplier(int backoffMultiplier);
}
