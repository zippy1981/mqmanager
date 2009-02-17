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
		private MenuItem _menuItemNew;
		private MenuItem _menuItemNewConnection;
		private MenuItem _menuItemBrowseHost;
		private MenuItem _menuItemClose;
		private MenuItem _menuItemExit;
		private MainMenu _mainMenu;
		private TabControl _mainTabs;
		private MenuItem _menuItemEdit;
        private MenuItem _menuItem3;
        private ContextMenuStrip _contextMenuTab;
        private MenuItem _menuItemHelp;
        private MenuItem _menuItem1;
        private ToolStripMenuItem _closeTabToolStripMenuItem;
        private IContainer components;

		/// <summary>
		/// Default constructor.
		/// </summary>
        public MQManagerForm()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
            // TODO: Redo the main menu as a menustrip.
		    Menu = _mainMenu;
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
            this._mainMenu = new System.Windows.Forms.MainMenu(this.components);
            this.menuItemFile = new System.Windows.Forms.MenuItem();
            this._menuItemBrowseHost = new System.Windows.Forms.MenuItem();
            this._menuItemNew = new System.Windows.Forms.MenuItem();
            this._menuItemNewConnection = new System.Windows.Forms.MenuItem();
            this.menuItemNewQueue = new System.Windows.Forms.MenuItem();
            this._menuItemClose = new System.Windows.Forms.MenuItem();
            this._menuItemExit = new System.Windows.Forms.MenuItem();
            this._menuItemEdit = new System.Windows.Forms.MenuItem();
            this._menuItem3 = new System.Windows.Forms.MenuItem();
            this._menuItemHelp = new System.Windows.Forms.MenuItem();
            this._menuItem1 = new System.Windows.Forms.MenuItem();
            this._mainTabs = new System.Windows.Forms.TabControl();
            this._contextMenuTab = new System.Windows.Forms.ContextMenuStrip(this.components);
            this._closeTabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._contextMenuTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // _mainMenu
            // 
            this._mainMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItemFile,
            this._menuItemEdit,
            this._menuItemHelp});
            // 
            // menuItemFile
            // 
            this.menuItemFile.Index = 0;
            this.menuItemFile.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this._menuItemBrowseHost,
            this._menuItemNew,
            this._menuItemClose,
            this._menuItemExit});
            this.menuItemFile.Text = "&File";
            // 
            // _menuItemBrowseHost
            // 
            this._menuItemBrowseHost.Index = 0;
            this._menuItemBrowseHost.Text = "List &Host Queues";
            this._menuItemBrowseHost.Click += new System.EventHandler(this.MenuItemBrowseHostClick);
            // 
            // _menuItemNew
            // 
            this._menuItemNew.Index = 1;
            this._menuItemNew.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this._menuItemNewConnection,
            this.menuItemNewQueue});
            this._menuItemNew.Text = "&New";
            // 
            // _menuItemNewConnection
            // 
            this._menuItemNewConnection.Index = 0;
            this._menuItemNewConnection.Text = "C&onnection";
            this._menuItemNewConnection.Click += new System.EventHandler(this.menuItemNewConnection_Click);
            // 
            // menuItemNewQueue
            // 
            this.menuItemNewQueue.Index = 1;
            this.menuItemNewQueue.Text = "&Queue";
            this.menuItemNewQueue.Click += new System.EventHandler(this.MenuItemNewQueueClick);
            // 
            // _menuItemClose
            // 
            this._menuItemClose.Enabled = false;
            this._menuItemClose.Index = 2;
            this._menuItemClose.Text = "&Close Tab";
            this._menuItemClose.Click += new System.EventHandler(this.menuItemClose_Click);
            // 
            // _menuItemExit
            // 
            this._menuItemExit.Index = 3;
            this._menuItemExit.Text = "E&xit";
            this._menuItemExit.Click += new System.EventHandler(this.MenuItemExit_Click);
            // 
            // _menuItemEdit
            // 
            this._menuItemEdit.Index = 1;
            this._menuItemEdit.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this._menuItem3});
            this._menuItemEdit.Text = "&Edit";
            // 
            // _menuItem3
            // 
            this._menuItem3.Index = 0;
            this._menuItem3.Text = "Properties";
            // 
            // _menuItemHelp
            // 
            this._menuItemHelp.Index = 2;
            this._menuItemHelp.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this._menuItem1});
            this._menuItemHelp.Text = "&Help";
            // 
            // _menuItem1
            // 
            this._menuItem1.Index = 0;
            this._menuItem1.Text = "&About";
            this._menuItem1.Click += new System.EventHandler(this.menuItem1_Click);
            // 
            // _mainTabs
            // 
            this._mainTabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this._mainTabs.ContextMenuStrip = this._contextMenuTab;
            this._mainTabs.Location = new System.Drawing.Point(0, 0);
            this._mainTabs.Name = "_mainTabs";
            this._mainTabs.SelectedIndex = 0;
            this._mainTabs.Size = new System.Drawing.Size(860, 611);
            this._mainTabs.TabIndex = 0;
            this._mainTabs.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainTabs_MouseDown);
            // 
            // _contextMenuTab
            // 
            this._contextMenuTab.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._closeTabToolStripMenuItem});
            this._contextMenuTab.Name = "_contextMenuTab";
            this._contextMenuTab.Size = new System.Drawing.Size(133, 26);
            // 
            // _closeTabToolStripMenuItem
            // 
            this._closeTabToolStripMenuItem.Name = "_closeTabToolStripMenuItem";
            this._closeTabToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this._closeTabToolStripMenuItem.Text = "&Close Tab";
            this._closeTabToolStripMenuItem.Click += new System.EventHandler(this.closeTabToolStripMenuItem_Click);
            // 
            // MQManagerForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(857, 606);
            this.Controls.Add(this._mainTabs);
            this.Name = "MQManagerForm";
            this.Text = "MQManagerForm";
            this._contextMenuTab.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		private System.Windows.Forms.MenuItem menuItemFile;
		private System.Windows.Forms.MenuItem menuItemNewQueue;
		#endregion

		private void menuItemNewConnection_Click(object sender, EventArgs e)
		{
			QueueConnectDialog connect = new QueueConnectDialog();
			connect.Show();
			connect.OnConnect += connectToQueue;
		}


        private void closeTabToolStripMenuItem_Click(object sender, EventArgs e)
	    {
        	// go through all tab pages
            for (int i = 0; i < _mainTabs.TabPages.Count; i++)
            {
                if (_mainTabs.GetTabRect(i).Contains(_mainTabs.PointToClient(Cursor.Position)))
                {
                    // we found the tabpage we want to remove
                    _mainTabs.TabPages.Remove(_mainTabs.SelectedTab);
                    break;
                }
            }

	        if (_mainTabs.TabCount == 0) { _menuItemClose.Enabled = false; }
	    }
        
        /// <summary>
        /// Connects to a queue.
        /// </summary>
        /// <param name="connectionString">The queue connection string.</param>
        private void connectToQueue(string connectionString)
		{
	    	
	        if (_mainTabs.TabPages.ContainsKey(connectionString))
	        {
	            _mainTabs.SelectTab(connectionString);
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
            	_mainTabs.Controls.Add(tabPage);
            	_mainTabs.SelectTab(tabPage);
            	_menuItemClose.Enabled = true;
		    }
		}
		
        /// <summary>
        /// Connects to a host to get a list of queues.
        /// </summary>
        /// <param name="hostName">The host to connect to.</param>
        private void listHostQueues (string hostName)
		{
			_menuItemClose.Enabled = true;
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
            _mainTabs.Controls.Add(tabPage);
            _mainTabs.SelectTab(tabPage);
		}

	    private void hostBrowser_MessagingProviderNodeDoubleClick(object sender, TreeNodeAdvMouseEventArgs e)
	    {
            MessagingProviderNode node = e.Node.Tag as MessagingProviderNode;
            if (node == null) { return; }
	        string host = node.Text;
	       	    
	        connectToQueue(host);
	    }


	    private void MenuItemExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

        private void menuItemClose_Click(object sender, EventArgs e)
        {
            _mainTabs.Controls.Remove(_mainTabs.SelectedTab);
            if (_mainTabs.Controls.Count == 0)
            {
                _menuItemClose.Enabled = false;
            }
        }
		
		void MenuItemBrowseHostClick(object sender, EventArgs e)
		{
			ConnectMessageDialog connect = new ConnectMessageDialog("Connect to host.");
			connect.OnConnect += listHostQueues;
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

        private void mainTabs_MouseDown(object sender, MouseEventArgs e)
        {
            if((e.Button | MouseButtons.Right) != MouseButtons.Right)
            {
                return;
            }
            // go through all tab pages
            for (int i = 0; i < _mainTabs.TabPages.Count; i++)
            {
                if (_mainTabs.GetTabRect(i).Contains(_mainTabs.PointToClient(Cursor.Position)))
                {
                    // we found the tabpage we want to act upon
                    _mainTabs.SelectTab(i);
                    break;
                }
            }
        }
	}
}
