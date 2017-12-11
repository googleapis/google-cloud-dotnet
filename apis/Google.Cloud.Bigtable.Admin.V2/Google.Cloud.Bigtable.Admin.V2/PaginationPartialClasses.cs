// Copyright 2017, Google LLC All rights reserved.
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
using Google.Api.Gax.Grpc;
using System;

namespace Google.Cloud.Bigtable.Admin.V2
{
    // Workarounds for API calls that have page_token / next_page_token but no page size.
    // We can't support the full pagination pattern - any attempt to set the page size to a non-zero value will fail -
    // but we can implement the interface for now.
    // Tracking this in https://github.com/GoogleCloudPlatform/google-cloud-dotnet/issues/1776

    public partial class ListAppProfilesRequest
    {
        int IPageRequest.PageSize { set => PageSize = value; }

        internal int PageSize
        {
            set
            {
                if (value != 0)
                {
                    throw new NotSupportedException("Setting a page size is not supported by this API call");
                }
            }
        }
    }

    public partial class ListTablesRequest
    {
        int IPageRequest.PageSize { set => PageSize = value; }

        internal int PageSize
        {
            set
            {
                if (value != 0)
                {
                    throw new NotSupportedException("Setting a page size is not supported by this API call");
                }
            }
        }
    }
}
