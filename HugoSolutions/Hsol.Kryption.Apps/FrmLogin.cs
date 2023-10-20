using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hsol.Kryption.Apps
{
    public partial class FrmLogin : Form
    {
        private const int Login_max_count = 3;
        private Configuration _solutionConfig;
        private int _login_fault_count;
        public string plantCode, userId, userName = string.Empty;


        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {

        }
    }
}
