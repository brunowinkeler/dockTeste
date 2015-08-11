using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace dockTeste
{
    public partial class FTreeview : DockContent
    {
        FChange fc1 = null;
        MainForm parent = null;
        public FTreeview(MainForm p)
        {
            InitializeComponent();

            parent = p;
            fc1 = new FChange(this);
            fc1.Show(parent.mainDock, DockState.Document);
            
        }
        public DockPanel mainDock
        {
            get { return parent.mainDock;}
        }

        private void treeViewCores_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            TreeNode escolha = e.Node;
            if (escolha.Text != string.Empty)
            {
                if (escolha.Text == "Azul")
                {
                    fc1.graphOxy1();
                }
                else if (escolha.Text == "Vermelho")
                {
                    fc1.graphOxy2();
                }
                else if (escolha.Text == "Amarelo")
                {
                    fc1.graphOxy3();
                }
            }
        }

        private void FTreeview_MouseLeave(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }
    }
}
