using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POS.UI.MasterSetup;
using POS.BusinessLogic;

namespace POS.UI.MainUI
{
    public partial class POSMainUI : Form
    {
        SettingController settingcontroller = new SettingController();
        public POSMainUI()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UM um = new UM();
            um.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AppSetting s = new AppSetting();
            s.Show();
        }

        private void POSMainUI_Load(object sender, EventArgs e)
        {
            lblCompanyInfo.Text = settingcontroller.getCompany();
            lblMsg.Text = settingcontroller.getMessage();

        }
    }
}
