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
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using MQManager.SPI;
using MQManager.SPI.MSMQ;

namespace MQManager.GUI.Forms
{
	/// <summary>
	/// Lists all the MSMQs on a single host
	/// </summary>
	public partial class HostMSMQBrowser : UserControl
	{
		private IHostQueueInfo hostQueues;
		
		private HostMSMQBrowser()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		
		public HostMSMQBrowser(string hostName) : this()
		{
			StringBuilder sb = new StringBuilder();
			hostQueues = new HostMSMQs(hostName);
			
			sb.AppendLine("Private Queues:");
			foreach (IMessagingProvider queueProvider in  hostQueues.PrivateQueues)
			{
				sb.AppendFormat("\t{0}", queueProvider.Name);
				sb.AppendLine();
			}
			sb.AppendLine("Public Queues:");
			foreach (IMessagingProvider queueProvider in  hostQueues.PublicQueues)
			{
				sb.AppendFormat("\t{0}", queueProvider.Name);
				sb.AppendLine();
			}
			txtQueueList.Text = sb.ToString();
		}
	}
}