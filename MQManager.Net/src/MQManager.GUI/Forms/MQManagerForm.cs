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
using Aga.Controls.Tree;

namespace MQManager.GUI.Forms
{
	/// <summary>
	/// Main program form.
	/// </summary>
	public class MQManagerForm : Form
	{
		private MenuItem menuItemNew;
		private MenuItem menuItemNewConnection;
		private MenuItem menuItemBrowseHost;
		private MenuItem menuItemClose;
		private MenuItem menuItemExit;
		private MainMenu mainMenu;
		private TabControl mainTabs;
		private MenuItem menuItemEdit;
        private MenuItem menuItem3;
        private IContainer components;
        private ContextMenuStrip contextMenuTab;
        private MenuItem menuItemHelp;
        private MenuItem menuItem1;
        private ToolStripMenuItem closeTabToolStripMenuItem;

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
            this.menuItemHelp = new System.Windows.Forms.MenuItem();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
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
            this.menuItemEdit,
            this.menuItemHelp});
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
            this.menuItemNewConnection.Click += new System.EventHandler(this.menuItemNewConnection_Click);
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
            // menuItemHelp
            // 
            this.menuItemHelp.Index = 2;
            this.menuItemHelp.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1});
            this.menuItemHelp.Text = "&Help";
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 0;
            this.menuItem1.Text = "&About";
            this.menuItem1.Click += new System.EventHandler(this.menuItem1_Click);
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
            this.mainTabs.Size = new System.Drawing.Size(860, 611);
            this.mainTabs.TabIndex = 0;
            // 
            // contextMenuTab
            // 
            this.contextMenuTab.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeTabToolStripMenuItem});
            this.contextMenuTab.Name = "contextMenuTab";
            this.contextMenuTab.Size = new System.Drawing.Size(133, 26);
            // 
            // closeTabToolStripMenuItem
            // 
            this.closeTabToolStripMenuItem.Name = "closeTabToolStripMenuItem";
            this.closeTabToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.closeTabToolStripMenuItem.Text = "&Close Tab";
            this.closeTabToolStripMenuItem.Click += new System.EventHandler(this.closeTabToolStripMenuItem_Click);
            // 
            // MQManagerForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
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

		private void menuItemNewConnection_Click(object sender, EventArgs e)
		{
			QueueConnectDialog connect = new QueueConnectDialog();
			connect.Show();
			connect.OnConnect += ConnectToQueue;
		}


        private void closeTabToolStripMenuItem_Click(object sender, EventArgs e)
	    {
        	// go through all tab pages
            for (int i = 0; i < mainTabs.TabPages.Count; i++)
            {
                if (mainTabs.GetTabRect(i).Contains(mainTabs.PointToClient(Cursor.Position)))
                {
                    // we found the tabpage we want to remove
                    string key = mainTabs.TabPages[i].Name;
                    mainTabs.TabPages.RemoveAt(i);
                    break;
                }
            }

	        if (mainTabs.TabCount == 0) { menuItemClose.Enabled = false; }
	    }
        
        /// <summary>
        /// Conects to a queue.
        /// </summary>
        /// <param name="connectionString">The queue connection string.</param>
        private void ConnectToQueue(string connectionString)
		{
	    	
	        if (mainTabs.TabPages.ContainsKey(connectionString))
	        {
	            mainTabs.SelectTab(connectionString);
	        }
            else
	        {
            	TabPage tabPage = new TabPage();
            	tabPage.AutoScroll = true;
            	tabPage.Visible = true;
            	
            	MSMQBrowserControl queueBrowser = MSMQBrowserControl.Create(connectionString);
            	
            	// Fix the connection string
            	connectionString = queueBrowser.QueueName;
            	tabPage.Name = connectionString;
            	tabPage.Text = connectionString;
            	tabPage.Controls.Add(queueBrowser);
            	tabPage.ToolTipText = string.Format("Connection to: {0}", connectionString);
            	
            	//TODO: Add a right click menu item to close the control. Ensure that it will disable the "File | Close" menu item.
            	queueBrowser.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            	mainTabs.Controls.Add(tabPage);
            	mainTabs.SelectTab(tabPage);
            	menuItemClose.Enabled = true;
		    }
		}
		
        /// <summary>
        /// Connects to a host to get a list of queues.
        /// </summary>
        /// <param name="hostName">The host to connect to.</param>
        private void ListHostQueues (string hostName)
		{
			menuItemClose.Enabled = true;
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
	       	    
	        ConnectToQueue(host);
	    }


	    private void MenuItemExit_Click(object sender, EventArgs e)
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
			ConnectMessageDialog connect = new ConnectMessageDialog("Connect to host.");
			connect.OnConnect += ListHostQueues;
			connect.Show();
		}
        
		void MenuItemNewQueueClick(object sender, EventArgs e)
		{
			// TODO: Implement dialog to create a new message queue.
			MessageBox.Show("Feature not implemented.", "Not Implemented");
		}

        private void menuItem1_Click(object sender, EventArgs e)
        {
            Form frm = new AboutBox();
            frm.ShowDialog();
        }
	}
}
