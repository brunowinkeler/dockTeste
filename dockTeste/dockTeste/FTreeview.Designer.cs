﻿namespace dockTeste
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Azul");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Vermelho");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Amarelo");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Cores", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            treeNode1.BackColor = System.Drawing.Color.Blue;
            treeNode1.Name = "Azul";
            treeNode1.Text = "Azul";
            treeNode2.BackColor = System.Drawing.Color.Red;
            treeNode2.Name = "Vermelho";
            treeNode2.Text = "Vermelho";
            treeNode3.BackColor = System.Drawing.Color.Yellow;
            treeNode3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            treeNode3.Name = "Amarelo";
            treeNode3.Text = "Amarelo";
            treeNode4.Name = "Cores";
            treeNode4.Text = "Cores";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4});
            this.treeView1.Size = new System.Drawing.Size(295, 280);
            this.treeView1.TabIndex = 0;
            // 
            // FTreeview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 280);
            this.Controls.Add(this.treeView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FTreeview";
            this.Text = "FTreeview";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
    }
}