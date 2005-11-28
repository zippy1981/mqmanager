/*
 * Copyright 2005 David H. DeWolf
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

namespace MQManager.GUI
{
	namespace Panels
	{
		/// <summary>
		/// Summary description for ForwardMessageDialog.
		/// </summary>
		public class ConnectDialog : System.Windows.Forms.Form
		{
		
			const string JOURNAL = "\\Journal$";
			const string DEADLETTER = "\\_deadletter";

			private System.Windows.Forms.Label label1;
			private System.Windows.Forms.TextBox connectionString;
			private System.Windows.Forms.Button forwardButton;
			private System.Windows.Forms.Button cancelButton;
			private System.Windows.Forms.CheckBox journalCheckBox;
			private System.Windows.Forms.CheckBox deadletterCheckBox;
			/// <summary>
			/// Required designer variable.
			/// </summary>
			private System.ComponentModel.Container components = null;

			public ConnectDialog()
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
				this.connectionString = new System.Windows.Forms.TextBox();
				this.forwardButton = new System.Windows.Forms.Button();
				this.cancelButton = new System.Windows.Forms.Button();
				this.label1 = new System.Windows.Forms.Label();
				this.journalCheckBox = new System.Windows.Forms.CheckBox();
				this.deadletterCheckBox = new System.Windows.Forms.CheckBox();
				this.SuspendLayout();
				// 
				// connectionString
				// 
				this.connectionString.Location = new System.Drawing.Point(8, 32);
				this.connectionString.Name = "connectionString";
				this.connectionString.Size = new System.Drawing.Size(360, 20);
				this.connectionString.TabIndex = 0;
				this.connectionString.Text = "";
				this.connectionString.TextChanged += new System.EventHandler(this.connectionString_TextChanged);
				// 
				// forwardButton
				// 
				this.forwardButton.Location = new System.Drawing.Point(8, 104);
				this.forwardButton.Name = "forwardButton";
				this.forwardButton.TabIndex = 1;
				this.forwardButton.Text = "Connect";
				this.forwardButton.Click += new System.EventHandler(this.connect_Click);
				// 
				// cancelButton
				// 
				this.cancelButton.Location = new System.Drawing.Point(96, 104);
				this.cancelButton.Name = "cancelButton";
				this.cancelButton.TabIndex = 2;
				this.cancelButton.Text = "Cancel";
				this.cancelButton.Click += new System.EventHandler(this.cancel_Click);
				// 
				// label1
				// 
				this.label1.Location = new System.Drawing.Point(8, 8);
				this.label1.Name = "label1";
				this.label1.TabIndex = 3;
				this.label1.Text = "Queue Path";
				// 
				// journalCheckBox
				// 
				this.journalCheckBox.Location = new System.Drawing.Point(8, 64);
				this.journalCheckBox.Name = "journalCheckBox";
				this.journalCheckBox.TabIndex = 4;
				this.journalCheckBox.Text = "View Journal";
				this.journalCheckBox.CheckedChanged += new System.EventHandler(this.journalCheckBox_CheckedChanged);
				// 
				// deadletterCheckBox
				// 
				this.deadletterCheckBox.Location = new System.Drawing.Point(120, 64);
				this.deadletterCheckBox.Name = "deadletterCheckBox";
				this.deadletterCheckBox.TabIndex = 5;
				this.deadletterCheckBox.Text = "Deadletter";
				this.deadletterCheckBox.CheckedChanged += new System.EventHandler(deadletterCheckBox_CheckedChanged);
				// 
				// ConnectMessageDialog
				// 
				this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
				this.ClientSize = new System.Drawing.Size(384, 149);
				this.Controls.Add(this.deadletterCheckBox);
				this.Controls.Add(this.journalCheckBox);
				this.Controls.Add(this.connectionString);
				this.Controls.Add(this.label1);
				this.Controls.Add(this.cancelButton);
				this.Controls.Add(this.forwardButton);
				this.Name = "ConnectMessageDialog";
				this.Text = "Connect to Queue";
				this.ResumeLayout(false);

			}
			#endregion

			private void connect_Click(object sender, System.EventArgs e)
			{
				if(OnConnect != null) 
					OnConnect(connectionString.Text);
				this.Close();
			}

			private void cancel_Click(object sender, System.EventArgs e)
			{
				if(OnCancel != null)
					OnCancel(sender, e);
				this.Close();
			}

			private void journalCheckBox_CheckedChanged(object sender, System.EventArgs e)
			{
				if(journalCheckBox.Checked)
				{
					connectionString.Text += JOURNAL;
				}
				else
				{
					if(connectionString.Text.EndsWith(JOURNAL))
					{
						connectionString.Text = connectionString.Text.Substring(0, connectionString.Text.IndexOf(JOURNAL));
					}
				}
			}
		
			private void deadletterCheckBox_CheckedChanged(object sender, System.EventArgs e)
			{
				if(deadletterCheckBox.Checked)
				{
					connectionString.Text += DEADLETTER;
				}
				else
				{
					if(connectionString.Text.EndsWith(DEADLETTER))
					{
						connectionString.Text = connectionString.Text.Substring(0, connectionString.Text.IndexOf(DEADLETTER));
					}
				}
			
			}

			private void connectionString_TextChanged(object sender, System.EventArgs e)
			{
				if(journalCheckBox.Checked)
				{
					if(!connectionString.Text.EndsWith(JOURNAL))
					{
						journalCheckBox.Checked = false;
					}
				}
				else if (connectionString.Text.EndsWith(JOURNAL))
				{
					journalCheckBox.Checked = true;
				}
			}

			public event ConnectEventHandler OnConnect;
			public event EventHandler OnCancel;


		}
	}

	public delegate void ConnectEventHandler(string connectionString);
}