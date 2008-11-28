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
using System.Collections.Generic;
using System.Windows.Forms;
using Aga.Controls.Tree;

namespace MQManager.GUI.Forms
{
	/// <summary>
	/// Main program form.
	/// </summary>
	public class MQManagerForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.MenuItem menuItemNew;
		private System.Windows.Forms.MenuItem menuItemNewConnection;
		private System.Windows.Forms.MenuItem menuItemBrowseHost;
		private System.Windows.Forms.MenuItem menuItemClose;
		private System.Windows.Forms.MenuItem menuItemExit;
		private System.Windows.Forms.MainMenu mainMenu;
		private System.Windows.Forms.TabControl mainTabs;
		private System.Windows.Forms.MenuItem menuItemEdit;
        private System.Windows.Forms.MenuItem menuItem3;
        private System.ComponentModel.IContainer components;
        private ContextMenuStrip contextMenuTab;
        private ToolStripMenuItem closeTabToolStripMenuItem;

        private Dictionary<string, TabPage> queueBrowsers = new Dictionary<string, TabPage>();

		public MQManagerForm()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
            // TODO: Redo the main menu as a menustrip.
		    Menu = mainMenu;
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
            this.mainMenu = new System.Windows.Forms.MainMenu(this.components);
            this.menuItemFile = new System.Windows.Forms.MenuItem();
            this.menuItemBrowseHost = new System.Windows.Forms.MenuItem();
            this.menuItemNew = new System.Windows.Forms.MenuItem();
            this.menuItemNewConnection = new System.Windows.Forms.MenuItem();
            this.menuItemNewQueue = new System.Windows.Forms.MenuItem();
            this.menuItemClose = new System.Windows.Forms.MenuItem();
            this.menuItemExit = new System.Windows.Forms.MenuItem();
            this.menuItemEdit = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.mainTabs = new System.Windows.Forms.TabControl();
            this.contextMenuTab = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.closeTabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItemFile,
            this.menuItemEdit});
            // 
            // menuItemFile
            // 
            this.menuItemFile.Index = 0;
            this.menuItemFile.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItemBrowseHost,
            this.menuItemNew,
            this.menuItemClose,
            this.menuItemExit});
            this.menuItemFile.Text = "&File";
            // 
            // menuItemBrowseHost
            // 
            this.menuItemBrowseHost.Index = 0;
            this.menuItemBrowseHost.Text = "List &Host Queues";
            this.menuItemBrowseHost.Click += new System.EventHandler(this.MenuItemBrowseHostClick);
            // 
            // menuItemNew
            // 
            this.menuItemNew.Index = 1;
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
            this.menuItemClose.Index = 2;
            this.menuItemClose.Text = "&Close Tab";
            this.menuItemClose.Click += new System.EventHandler(this.menuItemClose_Click);
            // 
            // menuItemExit
            // 
            this.menuItemExit.Index = 3;
            this.menuItemExit.Text = "E&xit";
            this.menuItemExit.Click += new System.EventHandler(this.MenuItemExit_Click);
            // 
            // menuItemEdit
            // 
            this.menuItemEdit.Index = 1;
            this.menuItemEdit.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem3});
            this.menuItemEdit.Text = "&Edit";
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 0;
            this.menuItem3.Text = "Properties";
            // 
            // mainTabs
            // 
            this.mainTabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.mainTabs.ContextMenuStrip = this.contextMenuTab;
            this.mainTabs.Location = new System.Drawing.Point(0, 0);
            this.mainTabs.Name = "mainTabs";
            this.mainTabs.SelectedIndex = 0;
            this.mainTabs.Size = new System.Drawing.Size(861, 610);
            this.mainTabs.TabIndex = 0;
            // 
            // contextMenuTab
            // 
            this.contextMenuTab.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeTabToolStripMenuItem});
            this.contextMenuTab.Name = "contextMenuTab";
            this.contextMenuTab.Size = new System.Drawing.Size(157, 26);
            // 
            // closeTabToolStripMenuItem
            // 
            this.closeTabToolStripMenuItem.Name = "closeTabToolStripMenuItem";
            this.closeTabToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.closeTabToolStripMenuItem.Text = "&Close Tab";
            this.closeTabToolStripMenuItem.Click += new System.EventHandler(this.closeTabToolStripMenuItem_Click);
            // 
            // MQManagerForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 15);
            this.ClientSize = new System.Drawing.Size(857, 606);
            this.Controls.Add(this.mainTabs);
            this.Name = "MQManagerForm";
            this.Text = "MQManagerForm";
            this.contextMenuTab.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		private System.Windows.Forms.MenuItem menuItemFile;
		private System.Windows.Forms.MenuItem menuItemNewQueue;
		#endregion

		private void OpenTab(object sender, System.EventArgs e)
		{
			ConnectMessageDialog connect = new ConnectMessageDialog();
			connect.Visible = true;
			connect.OnConnect += ConnectToQueue;
		}


        private void closeTabToolStripMenuItem_Click(object sender, EventArgs e)
	    {
            // index to remove
            int toRemove = -1;
            // go through all tab pages
            for (int i = 0; i < mainTabs.TabPages.Count; i++)
            {
                if (mainTabs.GetTabRect(i).Contains(mainTabs.PointToClient(Cursor.Position)))
                {
                    // we found the tabpage we want to remove
                    toRemove = i;
                    break;
                }
            }

            // is there anything to remove?
            if (toRemove != -1)
                mainTabs.TabPages.RemoveAt(toRemove);

	        if (mainTabs.TabCount == 0) { menuItemClose.Enabled = false; }
	    }

	    private void ConnectToQueue(string connectionString)
		{
            menuItemClose.Enabled = true;
	        TabPage tabPage = new TabPage();
			tabPage.AutoScroll = true;
			tabPage.Visible = true;
			MSMQBrowserControl queueBrowser = new MSMQBrowserControl(connectionString);
		    
            // Fix the connection string
            connectionString = queueBrowser.QueueName;
            tabPage.Name = connectionString;
            tabPage.Text = connectionString;
			tabPage.Controls.Add(queueBrowser);
            tabPage.ToolTipText = string.Format("Connection to: {0}", connectionString);
            queueBrowsers.Add(connectionString, tabPage);
			
			//TODO: Add a right click menu item to close the control. Ensure that it will disable the "File | Close" menu item.
			queueBrowser.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            mainTabs.Controls.Add(tabPage);
		    mainTabs.SelectTab(tabPage);
		}
		
		public void ListHostQueues (string hostName)
		{
			this.menuItemClose.Enabled = true;
			TabPage tabPage = new TabPage();
			tabPage.Text = string.Format("[{0}]", hostName);
			tabPage.ToolTipText = string.Format("Queues for: {0}", hostName);
			tabPage.AutoScroll = true;
			tabPage.Visible = true;
			HostMSMQBrowser hostBrowser = new HostMSMQBrowser(hostName);			
			tabPage.Controls.Add(hostBrowser);

            hostBrowser.MessagingProviderNodeDoubleClick +=hostBrowser_MessagingProviderNodeDoubleClick;
			
			//TODO: Add a right click menu item to close the control. Ensure that it will disable the "File | Close" menu item.
			hostBrowser.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            mainTabs.Controls.Add(tabPage);
            mainTabs.SelectTab(tabPage);
		}

	    private void hostBrowser_MessagingProviderNodeDoubleClick(object sender, TreeNodeAdvMouseEventArgs e)
	    {
            MessagingProviderNode node = e.Node.Tag as MessagingProviderNode;
            if (node == null) { return; }
	        string host = node.Text;
	        if (queueBrowsers.ContainsKey(host))
	        {
	            mainTabs.SelectTab(host);
	        }
            else
	        {
                //TODO: Store the ImessageProvider in the MessagingProviderNode and load the queue that way.
	            ConnectToQueue(host);
	        }
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
		
		void MenuItemBrowseHostClick(object sender, EventArgs e)
		{
			// TODO: Add dialog to allow you to select the host name.
			MessageBox.Show("For now you can only connect to localhost.");
			ListHostQueues(".");
		}
        
		void MenuItemNewQueueClick(object sender, EventArgs e)
		{
			// TODO: Implement dialog to create a new message queue.
			MessageBox.Show("Feature not implemented.", "Not Implemented");
		}        
	}
}
