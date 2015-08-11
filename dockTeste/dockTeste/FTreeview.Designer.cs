namespace dockTeste
{
    partial class FTreeview
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Azul");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Vermelho");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Amarelo");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Cores", new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6,
            treeNode7});
            this.treeViewCores = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // treeViewCores
            // 
            this.treeViewCores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewCores.Location = new System.Drawing.Point(0, 0);
            this.treeViewCores.Name = "treeViewCores";
            treeNode5.BackColor = System.Drawing.Color.Blue;
            treeNode5.Name = "Azul";
            treeNode5.Text = "Azul";
            treeNode6.BackColor = System.Drawing.Color.Red;
            treeNode6.Name = "Vermelho";
            treeNode6.Text = "Vermelho";
            treeNode7.BackColor = System.Drawing.Color.Yellow;
            treeNode7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            treeNode7.Name = "Amarelo";
            treeNode7.Text = "Amarelo";
            treeNode8.Name = "Cores";
            treeNode8.Text = "Cores";
            this.treeViewCores.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode8});
            this.treeViewCores.Size = new System.Drawing.Size(295, 280);
            this.treeViewCores.TabIndex = 0;
            this.treeViewCores.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeViewCores_NodeMouseClick);
            // 
            // FTreeview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 280);
            this.Controls.Add(this.treeViewCores);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FTreeview";
            this.Text = "FTreeview";
            this.MouseLeave += new System.EventHandler(this.FTreeview_MouseLeave);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeViewCores;
    }
}