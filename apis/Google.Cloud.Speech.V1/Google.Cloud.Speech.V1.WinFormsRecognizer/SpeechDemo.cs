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

using Grpc.Core;
using NAudio.Wave;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace Google.Cloud.Speech.V1.WinFormsRecognizer
{
    public partial class SpeechDemoForm : Form
    {
        private readonly ComboBox _microphoneChoice;
        private readonly Button _startStop;
        private readonly TextBox _finalizedText;
        private readonly TextBox _ongoingText;
        private readonly ToolStripStatusLabel _statusText;
        private readonly ToolStripStatusLabel _statisticsText;
        private readonly System.Windows.Forms.Timer _timer;
        private int _responsesReceived;
        private int _messagesSent;
        private int _messagesBuffered;
        private Stopwatch _listeningStopwatch;

        private SpeechRecognizer _currentRecognizer;

        public SpeechDemoForm()
        {
            // These have to be assigned in the constructor, but everything else can be done in a helper method.
            _microphoneChoice = new ComboBox();
            _startStop = new Button();
            _finalizedText = new TextBox();
            _ongoingText = new TextBox();
            _statusText = new ToolStripStatusLabel();
            _statisticsText = new ToolStripStatusLabel();
            _timer = new System.Windows.Forms.Timer();
            BuildUserInterface();
        }

        private void StartOrStop(object sender, EventArgs e)
        {
            if (_currentRecognizer == null)
            {
                _finalizedText.Clear();
                _ongoingText.Clear();
                _startStop.Text = "Stop";
                _statusText.Text = "Listening";
                _responsesReceived = 0;
                _messagesBuffered = 0;
                _messagesSent = 0;
                _listeningStopwatch = Stopwatch.StartNew();
                _currentRecognizer = new SpeechRecognizer(_microphoneChoice.SelectedIndex);
                _currentRecognizer.Faulted += HandleRecognitionFaulted;
                _currentRecognizer.ResponseReceived += HandleRecognitionResponse;
                _currentRecognizer.Stopped += HandleRecognitionStopped;
                _currentRecognizer.MessageBuffered += delegate { Interlocked.Increment(ref _messagesBuffered); };
                _currentRecognizer.MessageSent += delegate { Interlocked.Increment(ref _messagesSent); };
                _currentRecognizer.Start();
            }
            else
            {
                _statusText.Text = "Stopped";
                _currentRecognizer.Stop();
                _currentRecognizer = null;
                _startStop.Enabled = false;
                // We'll re-enable when the recognizer finishes
            }
        }

        private void HandleRecognitionStopped(object sender, EventArgs e)
        {
            if (InvokeRequired)
            {
                Invoke(HandleRecognitionStopped, sender, e);
                return;
            }
            _startStop.Text = "Start";
            _startStop.Enabled = true;
            _listeningStopwatch.Stop();
        }

        private void HandleRecognitionFaulted(object sender, Status status)
        {
            if (InvokeRequired)
            {
                Invoke(HandleRecognitionFaulted, sender, status);
                return;
            }
            _statusText.Text = $"Error: {status.Detail} ({status.StatusCode})";
            _currentRecognizer = null;
        }

        private void HandleRecognitionResponse(object sender, StreamingRecognizeResponse response)
        {
            if (InvokeRequired)
            {
                Invoke(HandleRecognitionResponse, sender, response);
                return;
            }
            Interlocked.Increment(ref _responsesReceived);
            _ongoingText.Clear();
            foreach (var result in response.Results)
            {
                if (result.IsFinal)
                {
                    foreach (var alternative in result.Alternatives.Where(a => a.Confidence >= 0.05))
                    {
                        _finalizedText.AppendText($"({((int) (alternative.Confidence * 100))}%) {alternative.Transcript}\r\n");
                    }
                }
                else
                {
                    _ongoingText.AppendText($"({((int) (result.Stability * 100))}%) ");
                    foreach (var alternative in result.Alternatives)
                    {
                        _ongoingText.AppendText($"{alternative.Transcript}\r\n");
                    }
                }
            }
        }

        private void UpdateStatistics(object sender, EventArgs e)
        {
            if (InvokeRequired)
            {
                Invoke(UpdateStatistics, sender, e);
                return;
            }
            var elapsedTime = _listeningStopwatch?.Elapsed ?? TimeSpan.Zero;
            _statisticsText.Text = $"Buffered: {_messagesBuffered} Sent: {_messagesSent} Responses: {_responsesReceived} Time: {elapsedTime:m':'ss}";
        }

        private void PopulateMicrophoneChoice(object sender, EventArgs e)
        {
            for (int i = 0; i < WaveIn.DeviceCount; i++)
            {
                _microphoneChoice.Items.Add(WaveIn.GetCapabilities(i).ProductName);
            }
            var width = _microphoneChoice.Items.Cast<string>().Max(item => TextRenderer.MeasureText(item, _microphoneChoice.Font).Width);
            _microphoneChoice.Width = width + 20; // Leave space for the dropdown button.
            _microphoneChoice.SelectedIndex = 0;
        }

        private void BuildUserInterface()
        {
            Name = "SpeechDemoForm";
            Text = "Google Cloud Speech Demo";
            Load += PopulateMicrophoneChoice;

            _microphoneChoice.Dock = DockStyle.Left;
            _microphoneChoice.FormattingEnabled = true;
            _microphoneChoice.Location = new Point(72, 3);
            _microphoneChoice.Size = new Size(121, 21);

            _ongoingText.Dock = DockStyle.Fill;
            _ongoingText.Margin = new Padding(3, 6, 3, 3);
            _ongoingText.Multiline = true;

            _finalizedText.Dock = DockStyle.Fill;
            _finalizedText.Margin = new Padding(3, 3, 3, 6);
            _finalizedText.Multiline = true;

            _startStop.Text = "Start";
            _startStop.Click += StartOrStop;

            _statusText.Text = "Ready";
            _statusText.Spring = true;
            _statusText.TextAlign = ContentAlignment.MiddleLeft;

            //_statisticsText.Spring = true;
            _statisticsText.TextAlign = ContentAlignment.MiddleLeft;

            var finalizedTextGroup = new GroupBox
            {
                Text = "Finalized text",
                Dock = DockStyle.Fill,
                Controls = { _finalizedText }
            };

            var ongoingTextGroup = new GroupBox
            {
                Text = "Ongoing text",
                Dock = DockStyle.Fill,
                Controls = { _ongoingText }
            };

            var mainContainer = new TableLayoutPanel
            {
                ColumnCount = 3,
                ColumnStyles =
                {
                    new ColumnStyle(),
                    new ColumnStyle(),
                    new ColumnStyle(SizeType.Percent, 100f)
                },
                Controls =
                {
                    {
                        new Label
                        {
                            Text = "Microphone",
                            Anchor = AnchorStyles.Bottom | AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right,
                            AutoSize = true,
                            TextAlign = ContentAlignment.MiddleCenter },
                        0, 0
                    },
                    { _microphoneChoice, 1, 0 },
                    { _startStop, 2, 0 },
                    { finalizedTextGroup, 0, 1 },
                    { ongoingTextGroup, 0, 2 }
                },
                Dock = DockStyle.Fill,
                RowCount = 2,
                RowStyles =
                {
                    new RowStyle(),
                    new RowStyle(SizeType.Percent, 50f),
                    new RowStyle(SizeType.Percent, 50f)
                }
            };

            mainContainer.SetColumnSpan(finalizedTextGroup, 3);
            mainContainer.SetColumnSpan(ongoingTextGroup, 3);
            var statusStrip = new StatusStrip
            {
                Dock = DockStyle.Bottom,
                Items = { _statusText, _statisticsText }
            };

            _timer.Interval = 200;
            _timer.Tick += UpdateStatistics;
            _timer.Start();

            Size = new Size(800, 600);
            Controls.Add(mainContainer);
            Controls.Add(statusStrip);
        }

        // Convenience method for cross-threading.
        private void Invoke<T>(Action<object, T> action, object sender, T args)
        {
            Invoke((Delegate) action, sender, args);
        }
    }
}
