// Copyright 2024 Google LLC
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

namespace Google.Cloud.Language.V1;

// Support for API keys

public partial class LanguageServiceClientBuilder
{
    /// <summary>
    /// An API key to use instead of an authenticated credential.
    /// When this is set, no other credential-related properties should be set.
    /// </summary>
    public new string ApiKey
    {
        get => base.ApiKey;
        set => base.ApiKey = value;
    }
}
