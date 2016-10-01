namespace Google.Cloud.Speech.V1Beta1.WinFormsRecognizer
{
    partial class SpeechDemoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.SplitContainer topSplit;
            System.Windows.Forms.TableLayoutPanel topLayout;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.TableLayoutPanel bottomLayout;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label2;
            this.microphoneChoice = new System.Windows.Forms.ComboBox();
            this.startStop = new System.Windows.Forms.Button();
            this.finalizedText = new System.Windows.Forms.TextBox();
            this.ongoingText = new System.Windows.Forms.TextBox();
            topSplit = new System.Windows.Forms.SplitContainer();
            topLayout = new System.Windows.Forms.TableLayoutPanel();
            label1 = new System.Windows.Forms.Label();
            bottomLayout = new System.Windows.Forms.TableLayoutPanel();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(topSplit)).BeginInit();
            topSplit.Panel1.SuspendLayout();
            topSplit.Panel2.SuspendLayout();
            topSplit.SuspendLayout();
            topLayout.SuspendLayout();
            bottomLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // topSplit
            // 
            topSplit.Dock = System.Windows.Forms.DockStyle.Fill;
            topSplit.Location = new System.Drawing.Point(0, 0);
            topSplit.Name = "topSplit";
            topSplit.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // topSplit.Panel1
            // 
            topSplit.Panel1.Controls.Add(topLayout);
            // 
            // topSplit.Panel2
            // 
            topSplit.Panel2.Controls.Add(bottomLayout);
            topSplit.Size = new System.Drawing.Size(768, 448);
            topSplit.SplitterDistance = 121;
            topSplit.TabIndex = 0;
            // 
            // topLayout
            // 
            topLayout.ColumnCount = 2;
            topLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            topLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            topLayout.Controls.Add(label1, 0, 0);
            topLayout.Controls.Add(this.microphoneChoice, 1, 0);
            topLayout.Controls.Add(this.startStop, 1, 1);
            topLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            topLayout.Location = new System.Drawing.Point(0, 0);
            topLayout.Name = "topLayout";
            topLayout.RowCount = 2;
            topLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            topLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            topLayout.Size = new System.Drawing.Size(768, 121);
            topLayout.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(3, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(63, 27);
            label1.TabIndex = 0;
            label1.Text = "Microphone";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // microphoneChoice
            // 
            this.microphoneChoice.Dock = System.Windows.Forms.DockStyle.Left;
            this.microphoneChoice.FormattingEnabled = true;
            this.microphoneChoice.Location = new System.Drawing.Point(72, 3);
            this.microphoneChoice.Name = "microphoneChoice";
            this.microphoneChoice.Size = new System.Drawing.Size(121, 21);
            this.microphoneChoice.TabIndex = 1;
            // 
            // startStop
            // 
            this.startStop.Location = new System.Drawing.Point(72, 30);
            this.startStop.Name = "startStop";
            this.startStop.Size = new System.Drawing.Size(75, 23);
            this.startStop.TabIndex = 2;
            this.startStop.Text = "Start";
            this.startStop.UseVisualStyleBackColor = true;
            this.startStop.Click += new System.EventHandler(this.StartOrStop);
            // 
            // bottomLayout
            // 
            bottomLayout.ColumnCount = 2;
            bottomLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            bottomLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            bottomLayout.Controls.Add(this.finalizedText, 1, 0);
            bottomLayout.Controls.Add(label3, 0, 1);
            bottomLayout.Controls.Add(label2, 0, 0);
            bottomLayout.Controls.Add(this.ongoingText, 1, 1);
            bottomLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            bottomLayout.Location = new System.Drawing.Point(0, 0);
            bottomLayout.Name = "bottomLayout";
            bottomLayout.RowCount = 2;
            bottomLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            bottomLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            bottomLayout.Size = new System.Drawing.Size(768, 323);
            bottomLayout.TabIndex = 0;
            // 
            // finalizedText
            // 
            this.finalizedText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.finalizedText.Location = new System.Drawing.Point(77, 3);
            this.finalizedText.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.finalizedText.Multiline = true;
            this.finalizedText.Name = "finalizedText";
            this.finalizedText.Size = new System.Drawing.Size(688, 152);
            this.finalizedText.TabIndex = 0;
            // 
            // label3
            // 
            label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(3, 161);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(68, 162);
            label3.TabIndex = 2;
            label3.Text = "Ongoing text";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(3, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(68, 161);
            label2.TabIndex = 1;
            label2.Text = "Finalized text";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ongoingText
            // 
            this.ongoingText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ongoingText.Location = new System.Drawing.Point(77, 167);
            this.ongoingText.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.ongoingText.Multiline = true;
            this.ongoingText.Name = "ongoingText";
            this.ongoingText.Size = new System.Drawing.Size(688, 153);
            this.ongoingText.TabIndex = 3;
            // 
            // SpeechDemoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 448);
            this.Controls.Add(topSplit);
            this.Name = "SpeechDemoForm";
            this.Text = "Google Cloud Speech Demo";
            this.Load += new System.EventHandler(this.PopulateMicrophoneChoice);
            topSplit.Panel1.ResumeLayout(false);
            topSplit.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(topSplit)).EndInit();
            topSplit.ResumeLayout(false);
            topLayout.ResumeLayout(false);
            topLayout.PerformLayout();
            bottomLayout.ResumeLayout(false);
            bottomLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox microphoneChoice;
        private System.Windows.Forms.Button startStop;
        private System.Windows.Forms.TextBox finalizedText;
        private System.Windows.Forms.TextBox ongoingText;
    }
}

