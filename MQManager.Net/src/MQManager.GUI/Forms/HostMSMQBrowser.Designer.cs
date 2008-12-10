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
            this.treeViewAdvHostQueues = new Aga.Controls.Tree.TreeViewAdv();
            this._treeColumnName = new Aga.Controls.Tree.TreeColumn();
            this._treeColumnMessageCount = new Aga.Controls.Tree.TreeColumn();
            this._nodeTextBox = new Aga.Controls.Tree.NodeControls.NodeTextBox();
            this._nodeMessageCount = new Aga.Controls.Tree.NodeControls.NodeIntegerTextBox();
            this.SuspendLayout();
            // 
            // treeViewAdvHostQueues
            // 
            this.treeViewAdvHostQueues.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.treeViewAdvHostQueues.BackColor = System.Drawing.SystemColors.Window;
            this.treeViewAdvHostQueues.Columns.Add(this._treeColumnName);
            this.treeViewAdvHostQueues.Columns.Add(this._treeColumnMessageCount);
            this.treeViewAdvHostQueues.DefaultToolTipProvider = null;
            this.treeViewAdvHostQueues.DragDropMarkColor = System.Drawing.Color.Black;
            this.treeViewAdvHostQueues.LineColor = System.Drawing.SystemColors.ControlDark;
            this.treeViewAdvHostQueues.Location = new System.Drawing.Point(2, 3);
            this.treeViewAdvHostQueues.Margin = new System.Windows.Forms.Padding(2);
            this.treeViewAdvHostQueues.Model = null;
            this.treeViewAdvHostQueues.Name = "treeViewAdvHostQueues";
            this.treeViewAdvHostQueues.NodeControls.Add(this._nodeTextBox);
            this.treeViewAdvHostQueues.NodeControls.Add(this._nodeMessageCount);
            this.treeViewAdvHostQueues.SelectedNode = null;
            this.treeViewAdvHostQueues.Size = new System.Drawing.Size(516, 375);
            this.treeViewAdvHostQueues.TabIndex = 1;
            this.treeViewAdvHostQueues.Text = "treeViewAdvHostQueues";
            this.treeViewAdvHostQueues.UseColumns = true;
            this.treeViewAdvHostQueues.NodeMouseDoubleClick += new System.EventHandler<Aga.Controls.Tree.TreeNodeAdvMouseEventArgs>(this.treeViewAdvHostQueues_NodeMouseDoubleClick);
            // 
            // _treeColumnName
            // 
            this._treeColumnName.Header = "Node";
            this._treeColumnName.SortOrder = System.Windows.Forms.SortOrder.None;
            this._treeColumnName.TooltipText = null;
            this._treeColumnName.Width = 350;
            // 
            // _treeColumnMessageCount
            // 
            this._treeColumnMessageCount.Header = "Message Count";
            this._treeColumnMessageCount.SortOrder = System.Windows.Forms.SortOrder.None;
            this._treeColumnMessageCount.TooltipText = null;
            this._treeColumnMessageCount.Width = 100;
            // 
            // _nodeTextBox
            // 
            this._nodeTextBox.DataPropertyName = "Text";
            this._nodeTextBox.IncrementalSearchEnabled = true;
            this._nodeTextBox.LeftMargin = 3;
            this._nodeTextBox.ParentColumn = this._treeColumnName;
            // 
            // _nodeMessageCount
            // 
            this._nodeMessageCount.DataPropertyName = "MessageCount";
            this._nodeMessageCount.IncrementalSearchEnabled = true;
            this._nodeMessageCount.LeftMargin = 3;
            this._nodeMessageCount.ParentColumn = this._treeColumnMessageCount;
            // 
            // HostMSMQBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.treeViewAdvHostQueues);
            this.Name = "HostMSMQBrowser";
            this.Size = new System.Drawing.Size(520, 381);
            this.ResumeLayout(false);

        }
        private Aga.Controls.Tree.TreeViewAdv treeViewAdvHostQueues;
        private Aga.Controls.Tree.NodeControls.NodeTextBox _nodeTextBox;
        private Aga.Controls.Tree.TreeColumn _treeColumnName;
        private Aga.Controls.Tree.TreeColumn _treeColumnMessageCount;
        private Aga.Controls.Tree.NodeControls.NodeIntegerTextBox _nodeMessageCount;
	}
}
