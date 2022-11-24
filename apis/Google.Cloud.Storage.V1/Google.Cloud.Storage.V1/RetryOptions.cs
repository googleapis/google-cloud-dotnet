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

/// <summary>
/// 
/// </summary>
public sealed class RetryOptions
{
    /// <summary>
    /// 
    /// </summary>
    public int MaxAttempts { get;  }

    /// <summary>
    /// 
    /// </summary>
    public int InitialBackoff { get; }

    /// <summary>
    /// 
    /// </summary>
    public int MaxBackoff { get; }

    /// <summary>
    /// 
    /// </summary>
    public int BackoffMultiplier { get; }

    /// <summary>
    /// 
    /// </summary>
    public Func<int, bool> RetryPredicate { get; }

    /// <summary>
    /// 
    /// </summary>
    public RetryOptions(int maxAttempts = 0, int initialBackoff = 0, int maxBackoff = 0, int backoffMultiplier = 0, Func<int, bool> retryPredicate = null)
    {
        MaxAttempts = maxAttempts;
        InitialBackoff = initialBackoff;
        MaxBackoff = maxBackoff;
        BackoffMultiplier = backoffMultiplier;
        RetryPredicate = retryPredicate;
    }
}
