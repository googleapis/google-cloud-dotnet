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

using Google.Apis.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using static Google.Apis.Storage.v1.ObjectsResource;
using Object = Google.Apis.Storage.v1.Data.Object;
using System.Net.Http;

namespace Google.Cloud.Storage.V1
{
    internal class TmpInsertMediaUpload : Google.Apis.Upload.TmpResumableUpload<Google.Apis.Storage.v1.Data.Object, Google.Apis.Storage.v1.Data.Object>
    {

        /// <summary>Data format for the response.</summary>
        /// [default: json]
        [Google.Apis.Util.RequestParameterAttribute("alt", Google.Apis.Util.RequestParameterType.Query)]
        public virtual System.Nullable<InsertMediaUpload.AltEnum> Alt { get; set; }

        /// <summary>Selector specifying which fields to include in a partial response.</summary>
        [Google.Apis.Util.RequestParameterAttribute("fields", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string Fields { get; set; }

        /// <summary>API key. Your API key identifies your project and provides you with API access, quota, and
        /// reports. Required unless you provide an OAuth 2.0 token.</summary>
        [Google.Apis.Util.RequestParameterAttribute("key", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string Key { get; set; }

        /// <summary>OAuth 2.0 token for the current user.</summary>
        [Google.Apis.Util.RequestParameterAttribute("oauth_token", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string OauthToken { get; set; }

        /// <summary>Returns response with indentations and line breaks.</summary>
        /// [default: true]
        [Google.Apis.Util.RequestParameterAttribute("prettyPrint", Google.Apis.Util.RequestParameterType.Query)]
        public virtual System.Nullable<bool> PrettyPrint { get; set; }

        /// <summary>Available to use for quota purposes for server-side applications. Can be any arbitrary string
        /// assigned to a user, but should not exceed 40 characters. Overrides userIp if both are
        /// provided.</summary>
        [Google.Apis.Util.RequestParameterAttribute("quotaUser", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string QuotaUser { get; set; }

        /// <summary>IP address of the site where the request originates. Use this if you want to enforce per-user
        /// limits.</summary>
        [Google.Apis.Util.RequestParameterAttribute("userIp", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string UserIp { get; set; }


        /// <summary>Name of the bucket in which to store the new object. Overrides the provided object metadata's
        /// bucket value, if any.</summary>
        [Google.Apis.Util.RequestParameterAttribute("bucket", Google.Apis.Util.RequestParameterType.Path)]
        public virtual string Bucket { get; private set; }

        /// <summary>If set, sets the contentEncoding property of the final object to this value. Setting this
        /// parameter is equivalent to setting the contentEncoding metadata property. This can be useful when
        /// uploading an object with uploadType=media to indicate the encoding of the content being
        /// uploaded.</summary>
        [Google.Apis.Util.RequestParameterAttribute("contentEncoding", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string ContentEncoding { get; set; }

        /// <summary>Makes the operation conditional on whether the object's current generation matches the given
        /// value.</summary>
        [Google.Apis.Util.RequestParameterAttribute("ifGenerationMatch", Google.Apis.Util.RequestParameterType.Query)]
        public virtual System.Nullable<long> IfGenerationMatch { get; set; }

        /// <summary>Makes the operation conditional on whether the object's current generation does not match the
        /// given value.</summary>
        [Google.Apis.Util.RequestParameterAttribute("ifGenerationNotMatch", Google.Apis.Util.RequestParameterType.Query)]
        public virtual System.Nullable<long> IfGenerationNotMatch { get; set; }

        /// <summary>Makes the operation conditional on whether the object's current metageneration matches the
        /// given value.</summary>
        [Google.Apis.Util.RequestParameterAttribute("ifMetagenerationMatch", Google.Apis.Util.RequestParameterType.Query)]
        public virtual System.Nullable<long> IfMetagenerationMatch { get; set; }

        /// <summary>Makes the operation conditional on whether the object's current metageneration does not match
        /// the given value.</summary>
        [Google.Apis.Util.RequestParameterAttribute("ifMetagenerationNotMatch", Google.Apis.Util.RequestParameterType.Query)]
        public virtual System.Nullable<long> IfMetagenerationNotMatch { get; set; }

        /// <summary>Name of the object. Required when the object metadata is not otherwise provided. Overrides the
        /// object metadata's name value, if any. For information about how to URL encode object names to be path
        /// safe, see Encoding URI Path Parts.</summary>
        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string Name { get; set; }

        /// <summary>Apply a predefined set of access controls to this object.</summary>
        [Google.Apis.Util.RequestParameterAttribute("predefinedAcl", Google.Apis.Util.RequestParameterType.Query)]
        public virtual System.Nullable<InsertMediaUpload.PredefinedAclEnum> PredefinedAcl { get; set; }        

        /// <summary>Set of properties to return. Defaults to noAcl, unless the object resource specifies the acl
        /// property, when it defaults to full.</summary>
        [Google.Apis.Util.RequestParameterAttribute("projection", Google.Apis.Util.RequestParameterType.Query)]
        public virtual System.Nullable<InsertMediaUpload.ProjectionEnum> Projection { get; set; }

        /// <summary>Constructs a new Insert media upload instance.</summary>
        public TmpInsertMediaUpload(Google.Apis.Services.IClientService service, Google.Apis.Storage.v1.Data.Object body, string
         bucket, System.IO.Stream stream, string contentType)
            : base(service, string.Format("/{0}/{1}{2}", "upload", service.BasePath, "b/{bucket}/o"), "POST", stream, contentType)
        {
            Bucket = bucket;
            Body = body;
        }
    }

    /// <summary>
    /// Subclass of <see cref="InsertMediaUpload"/> which provides the expected crc32c hash
    /// of the chunk in a header for each request.
    /// </summary>
    internal sealed class HashProvidingUpload : TmpInsertMediaUpload
    {
        internal HashProvidingUpload(IClientService service, Object body, string bucket, Stream stream, string contentType)
            : base(service, body, bucket, stream, contentType)
        {
        }

        protected override void ModifyRequest(HttpRequestMessage httpRequest)
        {
            base.ModifyRequest(httpRequest);

            var hash = new Crc32c();
            // We know the request contains data in memory, either as a ByteArrayContent or a StreamContent
            // wrapping a MemoryStream.
            var stream = httpRequest.Content.ReadAsStreamAsync().Result;
            // Nice and small...
            byte[] hashBuffer = new byte[1024];
            int bytesRead;
            while ((bytesRead = stream.Read(hashBuffer, 0, hashBuffer.Length)) > 0)
            {
                hash.UpdateHash(hashBuffer, 0, bytesRead);
            }
            stream.Position = 0;
            httpRequest.Headers.Add(Crc32c.HashHeaderName, $"{Crc32c.HashName}={Convert.ToBase64String(hash.GetHash())}");
        }
    }
}
