// Copyright 2018 Google Inc. All Rights Reserved.
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

using System.Collections.Generic;
using System.Security.Claims;
using System.Security.Principal;
using Google.Cloud.Diagnostics.Common;
using Microsoft.AspNetCore.Http;

namespace Google.Cloud.Diagnostics.AspNetCore3
{
    /// <summary>
    /// A <see cref="ILogEntryLabelProvider"/> which adds the information of the authenticated user to the log entry labels.
    /// </summary>
    public class UserLogEntryLabelProvider : HttpLogEntryLabelProvider
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserLogEntryLabelProvider"/> class.
        /// </summary>
        /// <param name="httpContextAccessor">The <see cref="IHttpContextAccessor"/> instance with the <see cref="HttpContext"/>.</param>
        public UserLogEntryLabelProvider(IHttpContextAccessor httpContextAccessor) : base(httpContextAccessor)
        {
        }

        /// <inheritdoc/>
        protected override void InvokeCore(Dictionary<string, string> labels, HttpContext httpContext)
        {
            if (httpContext.User?.Identity != null)
            {
                labels["user_authenticated"] = httpContext.User.Identity.IsAuthenticated.ToString();
                var userName = GetUserName(httpContext.User.Identity);
                if (httpContext.User.Identity.IsAuthenticated && !string.IsNullOrEmpty(userName))
                {
                    labels["user_name"] = userName;
                }
            }
        }

        private string GetUserName(IIdentity identity)
        {
            var name = identity.Name;
            if (name != null)
            {
                return name;
            }

            if (identity is ClaimsIdentity claimsIdentity)
            {
                return GetClaimValue(claimsIdentity, "sub")
                    ?? GetClaimValue(claimsIdentity, ClaimTypes.Name)
                    ?? GetClaimValue(claimsIdentity, ClaimTypes.NameIdentifier);
            }

            return null;
        }

        private string GetClaimValue(ClaimsIdentity identity, string claimsType) => identity.FindFirst(claimsType)?.Value;
    }
}
