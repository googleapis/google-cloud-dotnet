// Copyright 2021 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Google.Protobuf;
using Google.Protobuf.WellKnownTypes;
using Google.Rpc;
using Grpc.Core;
using System.Linq;

using Status = Google.Rpc.Status;

namespace Google.Api.Gax.Grpc
{
    /// <summary>
    /// Utility extension methods to make it easier to retrieve extended error information from an <see cref="RpcException"/>.
    /// </summary>
    public static class RpcExceptionExtensions
    {
        public static Status GetRpcStatus(this RpcException ex) =>
            DecodeTrailer(GetTrailer(ex, "grpc-status-details-bin"), Status.Parser);

        // TODO: This attempts to find the BadRequest in two different trailers. Is
        // that appropriate?
        public static BadRequest GetBadRequest(this RpcException ex) =>
            DecodeTrailer(GetTrailer(ex, "google.rpc.badrequest-bin"), BadRequest.Parser)
            ?? GetStatusDetail<BadRequest>(ex);

        public static ErrorInfo GetErrorInfo(this RpcException ex) =>
            GetStatusDetail<ErrorInfo>(ex);

        public static T GetStatusDetail<T>(this RpcException ex) where T : class, IMessage<T>, new()
        {
            var status = GetRpcStatus(ex);
            if (status is null)
            {
                return null;
            }
            var expectedName = new T().Descriptor.FullName;
            var any = status.Details.FirstOrDefault(a => Any.GetTypeName(a.TypeUrl) == expectedName);
            if (any is null)
            {
                return null;
            }
            return any.Unpack<T>();
        }

        private static Metadata.Entry GetTrailer(RpcException ex, string key)
        {
            GaxPreconditions.CheckNotNull(ex, nameof(ex));
            return ex.Trailers.FirstOrDefault(t => t.Key == key);
        }

        private static T DecodeTrailer<T>(Metadata.Entry entry, MessageParser<T> parser) where T : class, IMessage<T>
        {
            if (entry is null)
            {
                return null;
            }
            try
            {
                return parser.ParseFrom(entry.ValueBytes);
            }
            catch
            {
                // TODO: Is this appropriate?
                return null;
            }
        }
    }
}
