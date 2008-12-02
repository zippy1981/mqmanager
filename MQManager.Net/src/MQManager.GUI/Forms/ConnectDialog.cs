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
using System.ComponentModel;
using System.Windows.Forms;

namespace MQManager.GUI.Forms
{
	/// <summary>
	/// Dialog for connecting to a queue or host.
	/// </summary>
	internal class ConnectMessageDialog : Form
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private Container components = null;

		protected ConnectMessageDialog()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		internal ConnectMessageDialog(string title) : this()
		{
			this.Text = title;
			label.Text = title;
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
			this.cmdForward = new System.Windows.Forms.Button();
			this.cmdCancel = new System.Windows.Forms.Button();
			this.label = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// connectionString
			// 
			this.connectionString.Location = new System.Drawing.Point(8, 32);
			this.connectionString.Name = "connectionString";
			this.connectionString.Size = new System.Drawing.Size(360, 20);
			this.connectionString.TabIndex = 0;
			// 
			// cmdForward
			// 
			this.cmdForward.Location = new System.Drawing.Point(8, 104);
			this.cmdForward.Name = "cmdForward";
			this.cmdForward.Size = new System.Drawing.Size(75, 23);
			this.cmdForward.TabIndex = 1;
			this.cmdForward.Text = "C&onnect";
			this.cmdForward.Click += new System.EventHandler(this.connect_Click);
			// 
			// cmdCancel
			// 
			this.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.cmdCancel.Location = new System.Drawing.Point(96, 104);
			this.cmdCancel.Name = "cmdCancel";
			this.cmdCancel.Size = new System.Drawing.Size(75, 23);
			this.cmdCancel.TabIndex = 2;
			this.cmdCancel.Text = "&Cancel";
			this.cmdCancel.Click += new System.EventHandler(this.cancel_Click);
			// 
			// label
			// 
			this.label.Location = new System.Drawing.Point(8, 8);
			this.label.Name = "label";
			this.label.Size = new System.Drawing.Size(100, 23);
			this.label.TabIndex = 3;
			this.label.Text = "hostname";
			// 
			// ConnectMessageDialog
			// 
			this.AcceptButton = this.cmdForward;
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.CancelButton = this.cmdCancel;
			this.ClientSize = new System.Drawing.Size(460, 171);
			this.Controls.Add(this.connectionString);
			this.Controls.Add(this.label);
			this.Controls.Add(this.cmdCancel);
			this.Controls.Add(this.cmdForward);
			this.Name = "ConnectMessageDialog";
			this.Text = "Connect to Host";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		protected System.Windows.Forms.Label label;
		protected System.Windows.Forms.TextBox connectionString;
		private System.Windows.Forms.Button cmdForward;
		private System.Windows.Forms.Button cmdCancel;
		#endregion

		private void connect_Click(object sender, EventArgs e)
		{
			if(OnConnect != null)
			{
				OnConnect(connectionString.Text);
			}
			this.Close();
		}

		private void cancel_Click(object sender, EventArgs e)
		{
			if(OnCancel != null)
				OnCancel(sender, e);
			this.Close();
		}

		public event ConnectEventHandler OnConnect;
		public event EventHandler OnCancel;
	}
	
	/// <summary>
	/// Delegate for connection event.
	/// </summary>
	public delegate void ConnectEventHandler(string connectionString);
}