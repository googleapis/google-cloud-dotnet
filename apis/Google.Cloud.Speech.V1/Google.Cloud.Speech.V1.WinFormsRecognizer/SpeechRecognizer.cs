// Copyright 2017 Google Inc. All Rights Reserved.
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
using Google.Protobuf;
using Grpc.Core;
using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Google.Cloud.Speech.V1.WinFormsRecognizer
{
    /// <summary>
    /// A speech recognizer dealing with the Google Speech API internals and exposing events to
    /// communicate with user interfaces. Events are not synchronized: they may be raised from any thread.
    /// </summary>
    public class SpeechRecognizer
    {
        /// <summary>
        /// Event raised when the recognizer stops, whether due to error or after <see cref="Stop"/> is called.
        /// </summary>
        public event EventHandler Stopped;

        /// <summary>
        /// Event raised when the recognizer encounters an error, however that occurs.
        /// </summary>
        public event EventHandler<Status> Faulted;

        /// <summary>
        /// Event raised when the recognizer starts sending a message to the API service.
        /// </summary>
        public event EventHandler MessageBuffered;

        /// <summary>
        /// Event raised when the recognizer successfully completes sending a message to the API service.
        /// </summary>
        public event EventHandler MessageSent;

        /// <summary>
        /// Event raised when the recognizer receives a successful response.
        /// </summary>
        public event EventHandler<StreamingRecognizeResponse> ResponseReceived;

        private readonly int _deviceNumber;
        private readonly SpeechClient _client;

        private IWaveIn _input;
        private SpeechClient.StreamingRecognizeStream _stream;

        /// <summary>
        /// Creates a new instance for the specified device.
        /// </summary>
        /// <param name="deviceNumber">The NAudio device number to receive audio input from.</param>
        /// <param name="client">The Google Cloud Speech client to use, or <c>null</c> to create one with
        /// default settings.</param>
        public SpeechRecognizer(int deviceNumber, SpeechClient client = null)
        {
            _deviceNumber = deviceNumber;
            _client = client ?? SpeechClient.Create();
        }

        /// <summary>
        /// Start recognizing speech.
        /// </summary>
        public void Start()
        {
            _stream = _client.StreamingRecognize(streamingSettings: new BidirectionalStreamingSettings(32));

            _input = new WaveIn
            {
                DeviceNumber = _deviceNumber,
                WaveFormat = new WaveFormat(16000, 1), // 16KHz, mono, 16 bit.
                BufferMilliseconds = 500,
                NumberOfBuffers = 3
            };

            var config = new StreamingRecognitionConfig
            {
                Config = new RecognitionConfig
                {
                    Encoding = RecognitionConfig.Types.AudioEncoding.Linear16,
                    SampleRateHertz = 16000,
                    MaxAlternatives = 5,
                    LanguageCode = LanguageCodes.English.UnitedStates
                },
                InterimResults = true
            };
            var initialRequest = new StreamingRecognizeRequest { StreamingConfig = config };
            Task.Run(ReadResponses);
            _stream.WriteAsync(initialRequest).ContinueWith(HandleWriteResult);
            MessageBuffered?.Invoke(this, EventArgs.Empty);
            _input.DataAvailable += ConsumeMicrophoneData;
            _input.RecordingStopped += HandleRecordingStopped;
            _input.StartRecording();
        }

        /// <summary>
        /// Stop recognizing. The <see cref="Stopped"/> event will be raised in response to this method.
        /// </summary>
        public void Stop() => _input.StopRecording();

        private async Task ReadResponses()
        {
            var responses = _stream.ResponseStream;
            try
            {
                while (await responses.MoveNext())
                {
                    var response = responses.Current;
                    // Once we've received an error, assume we're done.
                    if (response.Error != null)
                    {
                        var protoStatus = response.Error;
                        // TODO: Clean this up. It's a pity there are different Status types...
                        Faulted?.Invoke(this, new Status((StatusCode) protoStatus.Code, protoStatus.Message));
                        Stop();
                        break;
                    }

                    if (response.Results.Any())
                    {
                        ResponseReceived?.Invoke(this, response);
                    }
                }
            }
            catch (RpcException e)
            {
                Faulted?.Invoke(this, e.Status);
            }
        }

        private void HandleWriteResult(Task task)
        {
            if (task.IsFaulted)
            {
                var exception = task.Exception.InnerExceptions[0];
                var rpcException = task.Exception.InnerExceptions[0] as RpcException;
                Faulted?.Invoke(this, rpcException?.Status ?? new Status(StatusCode.Unknown, $"Non-RPC exception: {exception.GetType()} - {exception.Message}"));
                Stop();
            }
            else
            {
                MessageSent?.Invoke(this, EventArgs.Empty);
            }
        }

        private void ConsumeMicrophoneData(object sender, WaveInEventArgs e)
        {
            ByteString data = ByteString.CopyFrom(e.Buffer, 0, e.BytesRecorded);
            var task = _stream.TryWriteAsync(new StreamingRecognizeRequest { AudioContent = data });
            if (task != null)
            {
                MessageBuffered?.Invoke(this, EventArgs.Empty);
            }
            task?.ContinueWith(HandleWriteResult);
        }

        private void HandleRecordingStopped(object sender, StoppedEventArgs e)
        {
            // Try to tell the server we're done. It doesn't matter if this fails, e.g. because it's
            // already broken.
            _stream.TryWriteCompleteAsync();
            Stopped?.Invoke(this, EventArgs.Empty);
        }
    }
}
