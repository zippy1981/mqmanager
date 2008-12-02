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

namespace MQManager.GUI.Forms
{
	/// <summary>
	/// Description of QueueConnectionDialog.
	/// </summary>
	internal partial class QueueConnectDialog : ConnectMessageDialog
	{
		
		const string JOURNAL = "\\Journal$";
		const string DEADLETTER = "\\_deadletter";
		
		public QueueConnectDialog()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}

		private void journalCheckBox_CheckedChanged(object sender, EventArgs e)
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
		
		private void deadletterCheckBox_CheckedChanged(object sender, EventArgs e)
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

		private void connectionString_TextChanged(object sender, EventArgs e)
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
	}
}
