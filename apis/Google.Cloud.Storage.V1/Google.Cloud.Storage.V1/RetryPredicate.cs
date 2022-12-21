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
public sealed class RetryPredicate
{
    /// <summary>
    /// 
    /// </summary>
    public static RetryPredicate DefaultErrorCodes { get; } = RetryPredicate.FromErrorCodes(408, 429, 500, 502, 503, 504);

    private Func<int, bool> Predicate { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="errorCodes"></param>
    /// <returns></returns>
    public static RetryPredicate FromErrorCodes(params int[] errorCodes)
    {
        return null;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="predicate"></param>
    /// <returns></returns>
    public static RetryPredicate FromErrorCodePredicate(Func<int, bool> predicate)
    {
        return null;
    }

    internal bool ShouldRetry(int statusCode)
    {
        return false;
    }
}


