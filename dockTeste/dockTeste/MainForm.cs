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
        FChange fc1 = new FChange();
        FTreeview ftree = new FTreeview();

        public MainForm()
        {
            InitializeComponent();
            fc1.Show(dockPanel, DockState.Document);
            ftree.Show(dockPanel, DockState.DockLeftAutoHide);
        }
    }
}
