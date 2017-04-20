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
using System.Collections.Generic;
using System.Collections;

namespace Google.Pubsub.V1
{
    public partial class PublisherClient
    {
        // Note: I haven't looked at the async options yet.
        public virtual IPagedEnumerable<ListTopicsResponse, Topic> ListTopicsStreamed(string project, string pageToken = "", CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }
    }

    public partial class PublisherClientImpl
    {
        public override IPagedEnumerable<ListTopicsResponse, Topic> ListTopicsStreamed(string project, string pageToken = "", CallSettings callSettings = null)
            => new PagedEnumerable<Topic, ListTopicsRequest, ListTopicsResponse>(
                callSettings,
                new ListTopicsRequest
                {
                    Project = project,
                    PageToken = pageToken
                },
                _callListTopics);
    }

    public partial class ListTopicsResponse : IPageResponse<Topic>
    {
        string IPageResponse<Topic>.NextPageToken => NextPageToken;
        IEnumerator IEnumerable.GetEnumerator() => ((IEnumerable<Topic>)this).GetEnumerator();
        IEnumerator<Topic> IEnumerable<Topic>.GetEnumerator() => Topics.GetEnumerator();
    }

    public partial class ListTopicsRequest : IPageRequest
    {
        string IPageRequest.PageToken { set { PageToken = value; } }
        int IPageRequest.PageSize { set { PageSize = value; } }
    }
}
