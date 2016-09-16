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

using Google.Protobuf;
using Grpc.Core;
using System;
using System.Threading.Tasks;

namespace Google.Cloud.Speech.V1Beta1
{
    // TODO: It would be nice not to have to do this, but we can't create an AsyncDuplexStreamingCall outselves.
    // This will be a problem if there are utilities over AsyncDuplexStreamingCall that folks want to use...

    /// <summary>
    /// A recognizer stream, already configured.
    /// </summary>
    public sealed class RecognizerStream : IDisposable
    {
        /// <summary>
        /// The configuration used to initialize this stream.
        /// </summary>
        public StreamingRecognitionConfig Configuration { get; }
        public IClientStreamWriter<ByteString> RequestStream { get; }

        private AsyncDuplexStreamingCall<StreamingRecognizeRequest, StreamingRecognizeResponse> _stream;

        public RecognizerStream(StreamingRecognitionConfig config, AsyncDuplexStreamingCall<StreamingRecognizeRequest, StreamingRecognizeResponse> stream)
        {
            Configuration = config;
            _stream = stream;
            RequestStream = new ClientStreamWriterAdapter<StreamingRecognizeRequest, ByteString>(
                _stream.RequestStream, data => new StreamingRecognizeRequest { AudioContent = data });
        }

        // Simple pass through methods and properties.
        public IAsyncStreamReader<StreamingRecognizeResponse> ResponseStream => _stream.ResponseStream;
        public Task<Metadata> ResponseHeadersAsync => _stream.ResponseHeadersAsync;
        public Status GetStatus() => _stream.GetStatus();
        public Metadata GetTrailers() => _stream.GetTrailers();
        public void Dispose() => _stream.Dispose();

        // TODO: Make this more widely available (GAX? Grpc.Core?)
        private class ClientStreamWriterAdapter<TOriginal, TEffective> : IClientStreamWriter<TEffective>
        {
            private readonly IClientStreamWriter<TOriginal> _underlyingStream;
            private readonly Func<TEffective, TOriginal> _selector;

            public ClientStreamWriterAdapter(
                IClientStreamWriter<TOriginal> underlyingStream,
                Func<TEffective, TOriginal> selector)
            {
                _underlyingStream = underlyingStream;
                _selector = selector;
            }

            public WriteOptions WriteOptions
            {
                get { return _underlyingStream.WriteOptions; }
                set { _underlyingStream.WriteOptions = value; }
            }

            public Task CompleteAsync() => _underlyingStream.CompleteAsync();

            public Task WriteAsync(TEffective message) => _underlyingStream.WriteAsync(_selector(message));
        }
    }
}
