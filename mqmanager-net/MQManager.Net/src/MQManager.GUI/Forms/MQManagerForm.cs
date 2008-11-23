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
using System.Windows.Forms;
using MQManager.GUI.Forms;

namespace MQManager.GUI.Forms
{
	/// <summary>
	/// Summary description for MQManagerForm.
	/// </summary>
	public class MQManagerForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem menuItemNew;
		private System.Windows.Forms.MenuItem menuItemNewConnection;
		private System.Windows.Forms.MenuItem menuItemClose;
		private System.Windows.Forms.MenuItem MenuItemExit;
		private System.Windows.Forms.MenuItem menuItem6;
		private System.Windows.Forms.MenuItem mainMenu;
		private System.Windows.Forms.TabControl mainTabs;
		private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.MenuItem menuItem3;
        private System.ComponentModel.IContainer components;

		public MQManagerForm()
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
			this.components = new System.ComponentModel.Container();
			this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
			this.mainMenu = new System.Windows.Forms.MenuItem();
			this.menuItemNew = new System.Windows.Forms.MenuItem();
			this.menuItemNewConnection = new System.Windows.Forms.MenuItem();
			this.menuItemNewQueue = new System.Windows.Forms.MenuItem();
			this.menuItemClose = new System.Windows.Forms.MenuItem();
			this.MenuItemExit = new System.Windows.Forms.MenuItem();
			this.menuItem2 = new System.Windows.Forms.MenuItem();
			this.menuItem3 = new System.Windows.Forms.MenuItem();
			this.menuItem6 = new System.Windows.Forms.MenuItem();
			this.mainTabs = new System.Windows.Forms.TabControl();
			this.SuspendLayout();
			// 
			// mainMenu1
			// 
			this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
									this.mainMenu,
									this.menuItem2,
									this.menuItem6});
			// 
			// mainMenu
			// 
			this.mainMenu.Index = 0;
			this.mainMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
									this.menuItemNew,
									this.menuItemClose,
									this.MenuItemExit});
			this.mainMenu.Text = "&File";
			// 
			// menuItemNew
			// 
			this.menuItemNew.Index = 0;
			this.menuItemNew.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
									this.menuItemNewConnection,
									this.menuItemNewQueue});
			this.menuItemNew.Text = "&New";
			// 
			// menuItemNewConnection
			// 
			this.menuItemNewConnection.Index = 0;
			this.menuItemNewConnection.Text = "C&onnection";
			this.menuItemNewConnection.Click += new System.EventHandler(this.OpenTab);
			// 
			// menuItemNewQueue
			// 
			this.menuItemNewQueue.Index = 1;
			this.menuItemNewQueue.Text = "&Queue";
			this.menuItemNewQueue.Click += new System.EventHandler(this.MenuItemNewQueueClick);
			// 
			// menuItemClose
			// 
			this.menuItemClose.Enabled = false;
			this.menuItemClose.Index = 1;
			this.menuItemClose.Text = "&Close";
			this.menuItemClose.Click += new System.EventHandler(this.menuItemClose_Click);
			// 
			// MenuItemExit
			// 
			this.MenuItemExit.Index = 2;
			this.MenuItemExit.Text = "E&xit";
			this.MenuItemExit.Click += new System.EventHandler(this.MenuItemExit_Click);
			// 
			// menuItem2
			// 
			this.menuItem2.Index = 1;
			this.menuItem2.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
									this.menuItem3});
			this.menuItem2.Text = "Edit";
			// 
			// menuItem3
			// 
			this.menuItem3.Index = 0;
			this.menuItem3.Text = "Properties";
			// 
			// menuItem6
			// 
			this.menuItem6.Index = 2;
			this.menuItem6.Text = "";
			// 
			// mainTabs
			// 
			this.mainTabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.mainTabs.Location = new System.Drawing.Point(0, 0);
			this.mainTabs.Name = "mainTabs";
			this.mainTabs.SelectedIndex = 0;
			this.mainTabs.Size = new System.Drawing.Size(860, 552);
			this.mainTabs.TabIndex = 0;
			// 
			// MQManagerForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(857, 549);
			this.Controls.Add(this.mainTabs);
			this.Menu = this.mainMenu1;
			this.Name = "MQManagerForm";
			this.Text = "MQManagerForm";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.MenuItem menuItemNewQueue;
		#endregion

		private void OpenTab(object sender, System.EventArgs e)
		{
			ConnectMessageDialog connect = new ConnectMessageDialog();
			connect.Visible = true;
			connect.OnConnect += new ConnectEventHandler(OnConnect);

		}

		public void OnConnect(string connectionString)
		{
            this.menuItemClose.Enabled = true;
	        TabPage control = new TabPage();
			control.Text = connectionString;
			control.ToolTipText = string.Format("Connection to: {0}", connectionString);
			control.AutoScroll = true;
			control.Visible = true;
			MSMQManagerForm queueBrowser = new MSMQManagerForm(connectionString); 
			control.Controls.Add(queueBrowser);
			
			//TODO: Add a right click menu item to close the control. Ensure that it will disable the "File | Close" menu item.
			queueBrowser.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            mainTabs.Controls.Add(control);		
		}

		
		private void MenuItemExit_Click(object sender, System.EventArgs e)
		{
			Application.Exit();
		}

        private void menuItemClose_Click(object sender, EventArgs e)
        {
            mainTabs.Controls.Remove(mainTabs.SelectedTab);
            if (mainTabs.Controls.Count == 0)
            {
                menuItemClose.Enabled = false;
            }
        }
        
		void MenuItemNewQueueClick(object sender, EventArgs e)
		{
			// TODO: Implement dialog to create a new message queue.
			MessageBox.Show("Feature not implemented.", "Not Implemented");
		}
	}
}
