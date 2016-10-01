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

using NAudio.Wave;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Google.Cloud.Speech.V1Beta1.WinFormsRecognizer
{
    public partial class SpeechDemoForm : Form
    {
        private Recognizer _currentRecognizer;

        public SpeechDemoForm()
        {
            InitializeComponent();
        }

        private async void StartOrStop(object sender, EventArgs e)
        {
            startStop.Enabled = false;
            if (_currentRecognizer == null)
            {
                finalizedText.Clear();
                ongoingText.Clear();
                var device = new WaveIn
                {
                    DeviceNumber = microphoneChoice.SelectedIndex,
                    WaveFormat = new WaveFormat(16000, 1), // 16KHz, mono, 16 bit.
                    BufferMilliseconds = 500,
                    NumberOfBuffers = 3
                };
                _currentRecognizer = new Recognizer(finalizedText, ongoingText, device);
                await _currentRecognizer.Start();
                startStop.Text = "Stop";
            }
            else
            {
                await _currentRecognizer.Stop();
                _currentRecognizer = null;
                startStop.Text = "Start";
            }
            startStop.Enabled = true;
        }

        private void PopulateMicrophoneChoice(object sender, EventArgs e)
        {
            for (int i = 0; i < WaveIn.DeviceCount; i++)
            {
                microphoneChoice.Items.Add(WaveIn.GetCapabilities(i).ProductName);
            }
            var width = microphoneChoice.Items.Cast<string>().Max(item => TextRenderer.MeasureText(item, microphoneChoice.Font).Width);
            microphoneChoice.Width = width + 20; // Leave space for the dropdown button.
            microphoneChoice.SelectedIndex = 0;
        }
    }
}
