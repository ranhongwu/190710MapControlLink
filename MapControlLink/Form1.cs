using ESRI.ArcGIS.Controls;
using ESRI.ArcGIS.SystemUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MapControlLink
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string mapName = "";

        private void leftMapControl_OnViewRefreshed(object sender, IMapControlEvents2_OnViewRefreshedEvent e)
        {
            if (mapName == "leftMapControl")
            {
                rightMapControl.Extent = leftMapControl.Extent;
                rightMapControl.Refresh();
            }
        }
        
        private void rightMapControl_OnViewRefreshed(object sender, IMapControlEvents2_OnViewRefreshedEvent e)
        {
            if (mapName == "rightMapControl")
            {
                leftMapControl.Extent = rightMapControl.Extent;
                leftMapControl.Refresh();
            }
        }

        private void leftMapControl_OnMouseMove(object sender, IMapControlEvents2_OnMouseMoveEvent e)
        {
            mapName = (sender as AxMapControl).Name;
        }

        private void rightMapControl_OnMouseMove(object sender, IMapControlEvents2_OnMouseMoveEvent e)
        {
            mapName = (sender as AxMapControl).Name;
        }
    }
}
