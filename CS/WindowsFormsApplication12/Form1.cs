using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;

namespace WindowsFormsApplication12 {
    public partial class Form1 : XtraForm {
        public Form1() {
            InitializeComponent();
            //Parent BackstageView controls' tab appearances
            backstageViewControl1.Appearance.BackColor = Color.Black;
            backstageViewControl1.Appearance.ForeColor = Color.White;
            foreach (BackstageViewTabItem tab in backstageViewControl1.Items.OfType<BackstageViewTabItem>()) {
                tab.AppearanceSelected.BackColor = Color.DarkOrange;
                tab.AppearanceSelected.ForeColor = Color.Black;
                tab.AppearanceHover.BackColor = Color.DimGray;
            }
            //Child BackstageView controls' tab appearances
            IEnumerable<BackstageViewTabItem> tabs2 = backstageViewControl2.Items.OfType<BackstageViewTabItem>();
            IEnumerable<BackstageViewTabItem> tabs3 = backstageViewControl3.Items.OfType<BackstageViewTabItem>();
            IEnumerable<BackstageViewTabItem> tabs4 = backstageViewControl4.Items.OfType<BackstageViewTabItem>();
            foreach (BackstageViewTabItem tab in tabs2.Concat(tabs3.Concat(tabs4))) {
                tab.AppearanceSelected.BackColor = Color.White;
                tab.AppearanceSelected.ForeColor = Color.Black;
                tab.AppearanceHover.BackColor = Color.SandyBrown;
            }
        }

        private void backstageViewButtonItem1_ItemClick(object sender, DevExpress.XtraBars.Ribbon.BackstageViewItemEventArgs e) {
            this.Close();
        }
    }
}
