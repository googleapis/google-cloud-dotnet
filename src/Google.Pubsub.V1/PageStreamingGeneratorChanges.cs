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

namespace Google.Pubsub.V1
{
    public partial class PublisherClient
    {
        // Note: I haven't looked at the async options yet.
        public virtual IPagedEnumerable<ListTopicsResponse, Topic, string> ListTopicsStreamed(string project, string pageToken = "", CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }
    }

    public partial class PublisherClientImpl
    {
        private static readonly PageStreamer2<Topic, ListTopicsRequest, ListTopicsResponse, string> s_listTopicsPageStreamer2 =
            new PageStreamer2<Topic, ListTopicsRequest, ListTopicsResponse, string>("");

        public override IPagedEnumerable<ListTopicsResponse, Topic, string> ListTopicsStreamed(string project, string pageToken = "", CallSettings callSettings = null)
            => s_listTopicsPageStreamer2.Fetch(
                callSettings,
                new ListTopicsRequest
                {
                    Project = project,
                    PageToken = pageToken
                },
                _callListTopics);
    }   

    public partial class ListTopicsResponse : IPageResponse<Topic, string>
    {
        IEnumerable<Topic> IPageResponse<Topic>.Items => Topics;
        string IPageResponse<Topic, string>.NextPageToken => NextPageToken;
    }

    public partial class ListTopicsRequest : IPageRequest<string>
    {
        string IPageRequest<string>.PageToken { set { PageToken = value; } }
        int IPageRequest<string>.PageSize { set { PageSize = value; } }
    }
}
