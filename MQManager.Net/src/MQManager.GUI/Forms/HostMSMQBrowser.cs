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
using System.Text;
using System.Windows.Forms;
using Aga.Controls.Tree;
using MQManager.SPI;
using MQManager.SPI.MSMQ;

namespace MQManager.GUI.Forms
{
	/// <summary>
	/// Lists all the MSMQs on a single host
	/// </summary>
	public partial class HostMSMQBrowser : UserControl
	{
		private readonly IQueueHostInfo _hostQueues;
        private readonly TreeModel _hostTreeModel;
        private readonly Node _privateQueues;
        private readonly Node _publicQueues;

		
		private HostMSMQBrowser()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
        }
		

		/// <summary>
		/// creates a HostMQMQ browser for the given host.
		/// </summary>
		/// <param name="hostName"></param>
		public HostMSMQBrowser(string hostName) : this()
		{
			StringBuilder sb = new StringBuilder();
			_hostQueues = new MSMQHost(hostName);

            _hostTreeModel = new TreeModel();
            treeViewAdvHostQueues.Model = _hostTreeModel;

            _privateQueues = new Node("Private Queues");
            _publicQueues = new Node("Public Queues");

            treeViewAdvHostQueues.BeginUpdate();
            
            _hostTreeModel.Nodes.Add(_privateQueues);
            _hostTreeModel.Nodes.Add(_publicQueues);
            
            foreach (IMessagingProvider queueProvider in _hostQueues.PrivateQueues)
            {
                MessagingProviderNode node = new MessagingProviderNode(queueProvider);
                _privateQueues.Nodes.Add(node);
            }

            foreach (IMessagingProvider queueProvider in _hostQueues.PublicQueues)
            {
                MessagingProviderNode node = new MessagingProviderNode(queueProvider);
                _publicQueues.Nodes.Add(node);
            }

            treeViewAdvHostQueues.EndUpdate();
        }


        /// <summary>
        /// Fires when you double click on a message queue node.
        /// </summary>
        internal event EventHandler<TreeNodeAdvMouseEventArgs> MessagingProviderNodeDoubleClick;

        private void treeViewAdvHostQueues_NodeMouseDoubleClick(object sender, TreeNodeAdvMouseEventArgs e)
        {
            MessagingProviderNode node = e.Node.Tag as MessagingProviderNode;
            if (node == null) { return; }
            //TODO: change this delegate so I don't cast twice.

            MessagingProviderNodeDoubleClick(sender, e);
        }
	}
}
