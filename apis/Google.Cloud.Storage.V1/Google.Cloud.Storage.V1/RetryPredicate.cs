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
using System.Linq;

namespace Google.Cloud.Storage.V1;

/// <summary>
/// 
/// </summary>
public sealed class RetryPredicate
{
    /// <summary>
    /// 
    /// </summary>
    public static RetryPredicate DefaultErrorCodes { get; } = RetryPredicate.FromErrorCodes(
                408, // Request timeout
                429, // Too many requests
                500, // Internal server error
                502, // Bad gateway
                503, // Service unavailable
                504 // Gateway timeout
        );

    private Func<int, bool> Predicate { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="errorCodes"></param>
    /// <returns></returns>
    public static RetryPredicate FromErrorCodes(params int[] errorCodes)
    {
        Func<int, bool> func = x => errorCodes.Contains(x);
        return new RetryPredicate() { Predicate = func };
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="predicate"></param>
    /// <returns></returns>
    public static RetryPredicate FromErrorCodePredicate(Func<int, bool> predicate)
    {
        return new RetryPredicate() { Predicate = predicate };
    }

    internal bool ShouldRetry(int statusCode)
    {
        return Predicate.Invoke(statusCode);
    }
}


