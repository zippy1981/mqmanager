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

using Microsoft.Win32;
using System;
using System.Collections;
using System.IO;
using System.Windows.Forms;

using MQManager.GUI.Forms;
using MQManager.SPI;
using MQManager.SPI.MSMQ;

namespace MQManager.GUI.Forms
{
	/// <summary>
	/// This control displays the messages in a single message queue.
	/// </summary>
	public class MSMQManagerForm : System.Windows.Forms.UserControl
	{
		private System.Windows.Forms.Label queuePathLabel;
		private System.Windows.Forms.TextBox queuePath;

		private System.Windows.Forms.ComboBox messageHeaders;
		private System.Windows.Forms.RichTextBox peekedMessage;


		private System.Windows.Forms.Label messageLabel;

		private System.Windows.Forms.Label statusMessageLabel;

		private System.Windows.Forms.Button listMessagesButton;
		private System.Windows.Forms.Button clearButton;
		private System.Windows.Forms.Button saveButton;
		private System.Windows.Forms.Button forwardButton;
		private System.Windows.Forms.Button deleteButton;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public MSMQManagerForm()
		{
			InitializeComponent();
		}

		public MSMQManagerForm(string connectionString) : this()
		{
            queuePath.Text = connectionString;
			Submit_Click(null, null);
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
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
			this.queuePath = new System.Windows.Forms.TextBox();
			this.listMessagesButton = new System.Windows.Forms.Button();
			this.queuePathLabel = new System.Windows.Forms.Label();
			this.messageLabel = new System.Windows.Forms.Label();
			this.peekedMessage = new System.Windows.Forms.RichTextBox();
			this.clearButton = new System.Windows.Forms.Button();
			this.forwardButton = new System.Windows.Forms.Button();
			this.statusMessageLabel = new System.Windows.Forms.Label();
			this.messageHeaders = new System.Windows.Forms.ComboBox();
			this.saveButton = new System.Windows.Forms.Button();
			this.deleteButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// queuePath
			// 
			this.queuePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.queuePath.Location = new System.Drawing.Point(16, 32);
			this.queuePath.Name = "queuePath";
			this.queuePath.Size = new System.Drawing.Size(376, 20);
			this.queuePath.TabIndex = 0;
			// 
			// listMessagesButton
			// 
			this.listMessagesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.listMessagesButton.Location = new System.Drawing.Point(408, 32);
			this.listMessagesButton.Name = "listMessagesButton";
			this.listMessagesButton.Size = new System.Drawing.Size(96, 23);
			this.listMessagesButton.TabIndex = 0;
			this.listMessagesButton.Text = "List Messages";
			this.listMessagesButton.Click += new System.EventHandler(this.Submit_Click);
			// 
			// queuePathLabel
			// 
			this.queuePathLabel.Location = new System.Drawing.Point(16, 8);
			this.queuePathLabel.Name = "queuePathLabel";
			this.queuePathLabel.Size = new System.Drawing.Size(100, 23);
			this.queuePathLabel.TabIndex = 2;
			this.queuePathLabel.Text = "Queue Path";
			// 
			// messageLabel
			// 
			this.messageLabel.Location = new System.Drawing.Point(16, 104);
			this.messageLabel.Name = "messageLabel";
			this.messageLabel.Size = new System.Drawing.Size(100, 23);
			this.messageLabel.TabIndex = 3;
			this.messageLabel.Text = "Message Contents";
			// 
			// peekedMessage
			// 
			this.peekedMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.peekedMessage.Location = new System.Drawing.Point(16, 128);
			this.peekedMessage.Name = "peekedMessage";
			this.peekedMessage.Size = new System.Drawing.Size(376, 217);
			this.peekedMessage.TabIndex = 4;
			this.peekedMessage.Text = "";
			// 
			// clearButton
			// 
			this.clearButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.clearButton.Location = new System.Drawing.Point(408, 64);
			this.clearButton.Name = "clearButton";
			this.clearButton.Size = new System.Drawing.Size(96, 23);
			this.clearButton.TabIndex = 5;
			this.clearButton.Text = "Clear Messages";
			this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
			// 
			// forwardButton
			// 
			this.forwardButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.forwardButton.Location = new System.Drawing.Point(408, 160);
			this.forwardButton.Name = "forwardButton";
			this.forwardButton.Size = new System.Drawing.Size(96, 23);
			this.forwardButton.TabIndex = 8;
			this.forwardButton.Text = "Forward";
			this.forwardButton.Click += new System.EventHandler(this.showForwardButton_Click);
			// 
			// statusMessageLabel
			// 
			this.statusMessageLabel.AutoSize = true;
			this.statusMessageLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.statusMessageLabel.Location = new System.Drawing.Point(0, 368);
			this.statusMessageLabel.Name = "statusMessageLabel";
			this.statusMessageLabel.Size = new System.Drawing.Size(0, 13);
			this.statusMessageLabel.TabIndex = 9;
			// 
			// messageHeaders
			// 
			this.messageHeaders.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.messageHeaders.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.messageHeaders.Location = new System.Drawing.Point(16, 64);
			this.messageHeaders.Name = "messageHeaders";
			this.messageHeaders.Size = new System.Drawing.Size(376, 21);
			this.messageHeaders.TabIndex = 10;
			this.messageHeaders.SelectedIndexChanged += new System.EventHandler(this.messageHeadersComboBox_SelectedIndexChanged);
			// 
			// saveButton
			// 
			this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.saveButton.Location = new System.Drawing.Point(408, 128);
			this.saveButton.Name = "saveButton";
			this.saveButton.Size = new System.Drawing.Size(96, 23);
			this.saveButton.TabIndex = 11;
			this.saveButton.Text = "Save";
			this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
			// 
			// deleteButton
			// 
			this.deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.deleteButton.Location = new System.Drawing.Point(408, 192);
			this.deleteButton.Name = "deleteButton";
			this.deleteButton.Size = new System.Drawing.Size(96, 23);
			this.deleteButton.TabIndex = 12;
			this.deleteButton.Text = "Delete";
			this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
			// 
			// MSMQManagerForm
			// 
			this.Controls.Add(this.deleteButton);
			this.Controls.Add(this.saveButton);
			this.Controls.Add(this.messageHeaders);
			this.Controls.Add(this.statusMessageLabel);
			this.Controls.Add(this.forwardButton);
			this.Controls.Add(this.clearButton);
			this.Controls.Add(this.peekedMessage);
			this.Controls.Add(this.messageLabel);
			this.Controls.Add(this.queuePathLabel);
			this.Controls.Add(this.listMessagesButton);
			this.Controls.Add(this.queuePath);
			this.Name = "MSMQManagerForm";
			this.Size = new System.Drawing.Size(520, 381);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		#endregion

		private IMessagingProvider messagingProvider;

		private void Submit_Click(object sender, System.EventArgs e)
		{
		    string conUrl = this.queuePath.Text;

			string results = null;
			try
			{
				clearButton_Click(sender, e);
				messagingProvider = new MSMQProvider(conUrl);
				IList messages = messagingProvider.GetMessageHeaders();
				foreach(IMessageHeader header in messages)
				{
					this.messageHeaders.DisplayMember = "MessageLabel";
					this.messageHeaders.Items.Add(header);
				}

			}
			catch(Exception ex)
			{
				results = ex.Message;
			}

			this.peekedMessage.Text = results;
		}

		private void clearButton_Click(object sender, System.EventArgs e)
		{
			messageHeaders.Items.Clear();
			messageHeaders.Items.Add("Please Choose a Message. . .");
			messageHeaders.SelectedIndex = 0;
		    peekedMessage.Text = "";
			statusMessageLabel.Text = "All Messages cleared.";
		}

		private void showForwardButton_Click(object sender, System.EventArgs e)
		{
			ForwardMessageDialog dialog = new ForwardMessageDialog();
			dialog.OriginalMessageHeader(CurrentMessageHeader());
			dialog.OnForward += new ForwardEventHandler(forwardCurrentMessage);
			dialog.OnCancel += new EventHandler(cancelButton_Click);
			dialog.ShowDialog(this);
		}

		private void forwardCurrentMessage(IMessagingProvider forwardProvider, string label, bool copy)
		{
			try 
			{
                IMessagingTransaction transaction = messagingProvider.BeginTransaction();
				IMessageContents msg = null;

				if(copy)
					msg = messagingProvider.PreviewMessage(CurrentMessageHeader());
				else
					msg = messagingProvider.GetMessage(CurrentMessageHeader());

				DefaultMessageContents contents = new DefaultMessageContents(msg);
				contents.MessageLabel = label == null ? "[FWD] " + msg.MessageLabel : label;
				contents.MessageBody = peekedMessage.Text;
				contents.TimeStamp = DateTime.Now;

				forwardProvider.ShareTransaction(transaction);

				forwardProvider.Send(contents);
				messagingProvider.CommitTransaction();
				clearButton_Click(null, null);
			}
			catch(Exception ex)
			{
				this.statusMessageLabel.Text = ex.Message;
			}
			finally
			{
				this.Submit_Click(null, null);
			}
		}

		private void cancelButton_Click(object sender, System.EventArgs e)
		{
			this.statusMessageLabel.Text = "Action Canceled";
		}

		private void messageHeadersComboBox_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			IMessageHeader header = CurrentMessageHeader();

			if(header == null) 
			{
				this.statusMessageLabel.Text = "Please select a message.";
			}
			else
			{
				IMessageContents content = messagingProvider.PreviewMessage(header);
				peekedMessage.Text = content.MessageBody;
				this.statusMessageLabel.Text = "Loaded Message: " + content.MessageLabel;
			}

		}

		private IMessageHeader CurrentMessageHeader()
		{
			if(messageHeaders.SelectedIndex == 0)
			{
				return null;
			}

			IMessageHeader header = (IMessageHeader)messageHeaders.SelectedItem;
			return header;
		}

		private void saveButton_Click(object sender, System.EventArgs e)
		{
            SaveFileDialog dialog = new SaveFileDialog();
			dialog.Filter = "xml files (*.xml)|*.xml|message Files (*.msg)|*.msg";
			dialog.FilterIndex = 1;
			dialog.RestoreDirectory = true;

			Stream output = null;
			if(dialog.ShowDialog(this) == DialogResult.OK)
			{
				if((output = dialog.OpenFile()) != null)
				{
				    StreamWriter put = new StreamWriter(output);
					put.Write(this.peekedMessage.Text);
					put.Flush();
					put.Close();
        			statusMessageLabel.Text = "Contents Saved to: "+dialog.FileName;
				}
				else
				{
					this.statusMessageLabel.Text = "Unable to locate file path";
				}
			}
			else
			{
				statusMessageLabel.Text = "Save canceled.";
			}
		}

		private void deleteButton_Click(object sender, System.EventArgs e)
		{
			string confirm = @"Are you sure that you want to remove this message from the queue? Once completed, this operation can not be undone.";

			DialogResult results = MessageBox.Show(
				confirm, "Delete Message?",  MessageBoxButtons.YesNo,
				MessageBoxIcon.Question,  MessageBoxDefaultButton.Button2
			);

			if(results == DialogResult.Yes)
			{
				IMessageHeader header = CurrentMessageHeader();
				try
				{
					messagingProvider.BeginTransaction();
				    messagingProvider.GetMessage(header);
					messagingProvider.CommitTransaction();
         			this.Submit_Click(null, null);
					statusMessageLabel.Text = "'"+header.MessageLabel+"'" + " deleted.";
				}
				catch(MessagingException ex)
				{
					statusMessageLabel.Text = "Error deleting message '"+header.MessageLabel+ "': "+ex.Message;
				}
			}
			else
			{
				statusMessageLabel.Text = "Delete Canceled.";
			}
		
		}
	}


}
