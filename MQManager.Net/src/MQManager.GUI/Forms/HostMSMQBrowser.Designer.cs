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
            this._nodeTextBox = new Aga.Controls.Tree.NodeControls.NodeTextBox();
            this.SuspendLayout();
            // 
            // treeViewAdvHostQueues
            // 
            this.treeViewAdvHostQueues.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.treeViewAdvHostQueues.BackColor = System.Drawing.SystemColors.Window;
            this.treeViewAdvHostQueues.DefaultToolTipProvider = null;
            this.treeViewAdvHostQueues.DragDropMarkColor = System.Drawing.Color.Black;
            this.treeViewAdvHostQueues.LineColor = System.Drawing.SystemColors.ControlDark;
            this.treeViewAdvHostQueues.Location = new System.Drawing.Point(3, 4);
            this.treeViewAdvHostQueues.Model = null;
            this.treeViewAdvHostQueues.Name = "treeViewAdvHostQueues";
            this.treeViewAdvHostQueues.NodeControls.Add(this._nodeTextBox);
            this.treeViewAdvHostQueues.SelectedNode = null;
            this.treeViewAdvHostQueues.Size = new System.Drawing.Size(687, 461);
            this.treeViewAdvHostQueues.TabIndex = 1;
            this.treeViewAdvHostQueues.Text = "treeViewAdvHostQueues";
            this.treeViewAdvHostQueues.NodeMouseDoubleClick += new System.EventHandler<Aga.Controls.Tree.TreeNodeAdvMouseEventArgs>(this.treeViewAdvHostQueues_NodeMouseDoubleClick);
            // 
            // _nodeTextBox
            // 
            this._nodeTextBox.DataPropertyName = "Text";
            this._nodeTextBox.IncrementalSearchEnabled = true;
            this._nodeTextBox.LeftMargin = 3;
            this._nodeTextBox.ParentColumn = null;
            // 
            // HostMSMQBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.treeViewAdvHostQueues);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HostMSMQBrowser";
            this.Size = new System.Drawing.Size(693, 469);
            this.ResumeLayout(false);

        }
        private Aga.Controls.Tree.TreeViewAdv treeViewAdvHostQueues;
        private Aga.Controls.Tree.NodeControls.NodeTextBox _nodeTextBox;
	}
}
