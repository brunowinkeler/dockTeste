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
    public partial class MainForm : Form
    {

        FTreeview ftree = null;

        public MainForm()
        {
            InitializeComponent();

            ftree = new FTreeview(this);
            ftree.Show(dockPanel, DockState.DockLeftAutoHide);
        }

        public DockPanel mainDock 
        {
            get { return this.dockPanel; }
        }
    }
}
