/*
 * Created by SharpDevelop.
 * User: Owner
 * Date: 11/23/2008
 * Time: 4:37 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace MQManager.GUI.Forms
{
	partial class HostMSMQBrowser
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the control.
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
			this.txtQueueList = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// txtQueueList
			// 
			this.txtQueueList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.txtQueueList.Location = new System.Drawing.Point(217, 3);
			this.txtQueueList.Multiline = true;
			this.txtQueueList.Name = "txtQueueList";
			this.txtQueueList.Size = new System.Drawing.Size(300, 375);
			this.txtQueueList.TabIndex = 0;
			// 
			// HostMSMQBrowser
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.txtQueueList);
			this.Name = "HostMSMQBrowser";
			this.Size = new System.Drawing.Size(520, 381);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TextBox txtQueueList;
	}
}
