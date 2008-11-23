/*
 * Copyright 2005-2008 David H. DeWolf and Justin Dearing
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using MQManager.SPI;
using MQManager.SPI.MSMQ;

namespace MQManager.GUI.Forms
{
	/// <summary>
	/// Summary description for ForwardMessageDialog.
	/// </summary>
	public class ForwardMessageDialog : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox forwardQueueUri;
		private System.Windows.Forms.Button forwardButton;
		private System.Windows.Forms.Button cancelButton;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.CheckBox copyCheckBox;
		private System.Windows.Forms.TextBox messageLabel;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public ForwardMessageDialog()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.forwardQueueUri = new System.Windows.Forms.TextBox();
			this.forwardButton = new System.Windows.Forms.Button();
			this.cancelButton = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.copyCheckBox = new System.Windows.Forms.CheckBox();
			this.messageLabel = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// forwardQueueUri
			// 
			this.forwardQueueUri.Location = new System.Drawing.Point(8, 32);
			this.forwardQueueUri.Name = "forwardQueueUri";
			this.forwardQueueUri.Size = new System.Drawing.Size(360, 20);
			this.forwardQueueUri.TabIndex = 0;
			this.forwardQueueUri.Text = "";
			// 
			// forwardButton
			// 
			this.forwardButton.Location = new System.Drawing.Point(8, 160);
			this.forwardButton.Name = "forwardButton";
			this.forwardButton.TabIndex = 1;
			this.forwardButton.Text = "Forward";
			this.forwardButton.Click += new System.EventHandler(this.button1_Click);
			// 
			// cancelButton
			// 
			this.cancelButton.Location = new System.Drawing.Point(96, 160);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.TabIndex = 2;
			this.cancelButton.Text = "Cancel";
			this.cancelButton.Click += new System.EventHandler(this.button2_Click);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 8);
			this.label1.Name = "label1";
			this.label1.TabIndex = 3;
			this.label1.Text = "Queue Path";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(8, 64);
			this.label2.Name = "label2";
			this.label2.TabIndex = 5;
			this.label2.Text = "Message Label";
			// 
			// copyCheckBox
			// 
			this.copyCheckBox.Location = new System.Drawing.Point(8, 120);
			this.copyCheckBox.Name = "copyCheckBox";
			this.copyCheckBox.Size = new System.Drawing.Size(256, 24);
			this.copyCheckBox.TabIndex = 6;
			this.copyCheckBox.Text = "Leave a Copy in the Originating Queue";
			// 
			// messageLabel
			// 
			this.messageLabel.Location = new System.Drawing.Point(8, 88);
			this.messageLabel.Name = "messageLabel";
			this.messageLabel.Size = new System.Drawing.Size(360, 20);
			this.messageLabel.TabIndex = 4;
			this.messageLabel.Text = "";
			// 
			// ForwardMessageDialog
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(384, 197);
			this.Controls.Add(this.copyCheckBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.messageLabel);
			this.Controls.Add(this.forwardQueueUri);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cancelButton);
			this.Controls.Add(this.forwardButton);
			this.Name = "ForwardMessageDialog";
			this.Text = "Forward Message";
			this.ResumeLayout(false);

		}
		#endregion

		private void button1_Click(object sender, System.EventArgs e)
		{
			if(OnForward != null)
				OnForward(new MSMQProvider(forwardQueueUri.Text), messageLabel.Text, copyCheckBox.Checked);
			this.Close();
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			if(OnCancel != null)
				OnCancel(sender, e);
			this.Close();
			
		}

		public event ForwardEventHandler OnForward;
		public event EventHandler OnCancel;

		public void OriginalMessageHeader(IMessageHeader header)
		{
			messageLabel.Text = "[FWD] "+header.MessageLabel;
		}
	}


	public delegate void ForwardEventHandler(IMessagingProvider forwardingProvider, string label, bool copy);
}
