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

/// <summary>
/// 
/// </summary>
public sealed class RetryTimings
{
    /// <summary>
    /// 
    /// </summary>
    public static RetryTimings Default { get; }

    /// <summary>
    /// 
    /// </summary>
    public TimeSpan InitialBackoff { get; }

    /// <summary>
    /// 
    /// </summary>
    public TimeSpan MaxBackoff { get; }

    /// <summary>
    /// 
    /// </summary>
    public double BackoffMultiplier { get; }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="initialBackoff"></param>
    /// <returns></returns>
    public RetryTimings WithInitialBackoff(TimeSpan initialBackoff)
    {
        return null;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="maxBackoff"></param>
    /// <returns></returns>
    public RetryTimings WithMaxBackoff(TimeSpan maxBackoff)
    {
        return null;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="backoffMultiplier"></param>
    /// <returns></returns>
    public RetryTimings WithBackoffMultiplier(double backoffMultiplier)
    {
        return null;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="initialBackoff"></param>
    /// <param name="maxBackoff"></param>
    /// <param name="backoffMultiplier"></param>
    public RetryTimings(TimeSpan initialBackoff, TimeSpan maxBackoff, double backoffMultiplier)
    {

    }
}

