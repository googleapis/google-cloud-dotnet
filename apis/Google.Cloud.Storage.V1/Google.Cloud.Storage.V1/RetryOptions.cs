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

namespace Google.Cloud.Storage.V1;

public sealed class RetryOptions
{
    private readonly RetryPredicate _retryPredicate;
    private readonly RetryTimings _retryTimings;
    internal RetryPredicate RetryPredicate => _retryPredicate;
    internal RetryTimings RetryTimings => _retryTimings;

    public RetryOptions(RetryTimings retryTimings, RetryPredicate retryPredicate)
    {
        _retryTimings = retryTimings;
        _retryPredicate = retryPredicate;
    }
}

