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
using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Google.Cloud.Speech.V1Beta1.WinFormsRecognizer
{
    internal sealed class Recognizer
    {
        private readonly TextBox _finalizedTextOutput;
        private readonly TextBox _ongoingTextOutput;
        private readonly IWaveIn _waveIn;
        private RecognizerStream _recognizerStream;
        private Task _doneTask;

        internal Recognizer(TextBox finalizedTextOutput, TextBox ongoingTextOutput, IWaveIn waveIn)
        {
            _finalizedTextOutput = finalizedTextOutput;
            _ongoingTextOutput = ongoingTextOutput;
            _waveIn = waveIn;
            _waveIn.DataAvailable += ConsumeMicrophoneData;
            _waveIn.RecordingStopped += RecordingStopped;
        }

        private async void RecordingStopped(object sender, StoppedEventArgs e)
        {
            await _recognizerStream.RequestStream.CompleteAsync();
        }

        private async void ConsumeMicrophoneData(object sender, WaveInEventArgs e)
        {
            ByteString data = ByteString.CopyFrom(e.Buffer, 0, e.BytesRecorded);
            // This await isn't actually useful, because nothing's waiting for this async
            // method to finish. Really, we want a BufferBlock or similar so we can just
            // shovel data into a queue. gRPC will fail if there's more than one pending request,
            // but I haven't actually seen it fail with this sample code yet, presumably because my
            // network connection is fast.
            await _recognizerStream.RequestStream.WriteAsync(data);
        }

        internal async Task Start()
        {
            var recognizer = SpeechRecognizer.Create();
            var config = new StreamingRecognitionConfig
            {
                Config = new RecognitionConfig
                {
                    Encoding = RecognitionConfig.Types.AudioEncoding.Linear16,
                    SampleRate = 16000,
                    MaxAlternatives = 5
                },
                InterimResults = true
            };
            _recognizerStream = await recognizer.BeginStreamingRecognizeAsync(config);
            _waveIn.StartRecording();
            _doneTask = ConsumeResultsAsync();
        }

        private async Task ConsumeResultsAsync()
        {
            // This runs in the UI thread, looping, but will only actually trigger when there's data.
            var responses = _recognizerStream.ResponseStream;
            while (await responses.MoveNext())
            {
                var response = responses.Current;
                if (response.Results.Any())
                {
                    _ongoingTextOutput.Clear(); // Is this appropriate?
                    foreach (var result in response.Results)
                    {
                        if (result.IsFinal)
                        {
                            foreach (var alternative in result.Alternatives.Where(a => a.Confidence >= 0.05))
                            {
                                _finalizedTextOutput.AppendText($"({((int)(alternative.Confidence * 100))}%) {alternative.Transcript}\r\n");
                            }
                            _finalizedTextOutput.AppendText("\r\n");
                        }
                        else
                        {
                            _ongoingTextOutput.AppendText($"({((int)(result.Stability * 100))}%) ");
                            foreach (var alternative in result.Alternatives)
                            {
                                _ongoingTextOutput.AppendText($"{alternative.Transcript}\r\n");
                            }
                            _ongoingTextOutput.AppendText("\r\n");
                        }
                    }
                }
            }
        }

        internal Task Stop()
        {
            _waveIn.StopRecording();
            // This will complete when the gRPC stream has completed.
            return _doneTask;
        }
    }
}
