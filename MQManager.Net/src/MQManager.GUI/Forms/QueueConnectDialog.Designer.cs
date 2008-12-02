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
 
namespace MQManager.GUI.Forms
{
	partial class QueueConnectDialog
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.journalCheckBox = new System.Windows.Forms.CheckBox();
			this.deadletterCheckBox = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// label
			// 
			this.label.Text = "Queue:";
			// 
			// journalCheckBox
			// 
			this.journalCheckBox.Location = new System.Drawing.Point(10, 74);
			this.journalCheckBox.Name = "journalCheckBox";
			this.journalCheckBox.Size = new System.Drawing.Size(124, 28);
			this.journalCheckBox.TabIndex = 4;
			this.journalCheckBox.Text = "View Journal";
			this.journalCheckBox.CheckedChanged += new System.EventHandler(this.journalCheckBox_CheckedChanged);
			// 
			// deadletterCheckBox
			// 
			this.deadletterCheckBox.Location = new System.Drawing.Point(144, 74);
			this.deadletterCheckBox.Name = "deadletterCheckBox";
			this.deadletterCheckBox.Size = new System.Drawing.Size(125, 28);
			this.deadletterCheckBox.TabIndex = 5;
			this.deadletterCheckBox.Text = "Deadletter";
			this.deadletterCheckBox.CheckedChanged += new System.EventHandler(this.deadletterCheckBox_CheckedChanged);
			// 
			// QueueConnectDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(460, 171);
			this.Controls.Add(this.deadletterCheckBox);
			this.Controls.Add(this.journalCheckBox);
			this.Name = "QueueConnectDialog";
			this.Text = "QueueConnectionDialog";
			this.Controls.SetChildIndex(this.journalCheckBox, 0);
			this.Controls.SetChildIndex(this.deadletterCheckBox, 0);
			this.Controls.SetChildIndex(this.label, 0);
			this.Controls.SetChildIndex(this.connectionString, 0);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		
		private System.Windows.Forms.CheckBox journalCheckBox;
		private System.Windows.Forms.CheckBox deadletterCheckBox;
	}
}
