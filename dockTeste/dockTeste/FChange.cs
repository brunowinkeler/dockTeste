using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OxyPlot.WindowsForms;
using OxyPlot.Series;
using OxyPlot.Axes;
using OxyPlot;
using WeifenLuo.WinFormsUI.Docking;

namespace dockTeste
{
    public partial class FChange : DockContent
    {
        PlotModel myModel;
        FTreeview parent = null;
        public FChange(FTreeview p)
        {
            InitializeComponent();
            parent = p;

            
            //this.plotView1.Model = myModel;
        }
        public void changeBackColor (Color color1)
        {
            this.BackColor = color1;
        }

        public void graphOxy1 ()
        {
            myModel = new PlotModel { Title = "Example 1" };
            myModel.Background = OxyColor.FromRgb(255, 255, 255);
            myModel.TextColor = OxyColor.FromRgb(0, 0, 0);
            myModel.Series.Clear();
            myModel.Series.Add(new FunctionSeries(Math.Cos, 0, 10, 0.1, "cos(x)"));
            this.plotView1.Model = myModel;
        }
        public void graphOxy2()
        {
            myModel = new PlotModel { Title = "Example 1" };
            myModel.Background = OxyColor.FromRgb(255, 255, 255);
            myModel.TextColor = OxyColor.FromRgb(0, 0, 0);
            myModel.Series.Clear();
            myModel.Series.Add(new FunctionSeries(Math.Abs, -1, 1, 0.05, "exp(x)"));
            this.plotView1.Model = myModel;
            //this.plotView1.Refresh();
        }
        public void graphOxy3()
        {
            myModel = new PlotModel { Title = "Example 1" };
            myModel.Background = OxyColor.FromRgb(255, 255, 255);
            myModel.TextColor = OxyColor.FromRgb(0, 0, 0);
            myModel.Series.Clear();
            myModel.Series.Add(new FunctionSeries(Math.Sin, 0, 20, 0.1, "Sen(x)"));
            this.plotView1.Model = myModel;
            //this.plotView1.Refresh();
        }
    }
}
