using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Krypton.Toolkit;
using Krypton.Docking;
using Krypton.Navigator;
using Krypton.Workspace;

namespace Hsol.Kryption.Apps
{
    public partial class FrmMain : KryptonForm
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        #region `팔레트 영역`

        private void btn365Blue_Click(object sender, EventArgs e)
        {
            kryptonManager.GlobalPaletteMode = PaletteModeManager.Office365Blue;
            UpdatePaletteButtons();
        }

        private void btn365Silver_Click(object sender, EventArgs e)
        {
            kryptonManager.GlobalPaletteMode = PaletteModeManager.Office365Silver;
            UpdatePaletteButtons();
        }

        private void btn365DarkGray_Click(object sender, EventArgs e)
        {
            kryptonManager.GlobalPaletteMode = PaletteModeManager.Office365DarkGray;
            UpdatePaletteButtons();
        }

        private void btn2010Blue_Click(object sender, EventArgs e)
        {
            kryptonManager.GlobalPaletteMode = PaletteModeManager.Office2007Blue;
            UpdatePaletteButtons();
        }

        private void btn2010Silver_Click(object sender, EventArgs e)
        {
            kryptonManager.GlobalPaletteMode = PaletteModeManager.Office2010Silver;
            UpdatePaletteButtons();
        }

        private void btn2010Black_Click(object sender, EventArgs e)
        {
            kryptonManager.GlobalPaletteMode = PaletteModeManager.Office2010Black;
            UpdatePaletteButtons();
        }

        private void btn2007Blue_Click(object sender, EventArgs e)
        {
            kryptonManager.GlobalPaletteMode = PaletteModeManager.Office2007Blue;
            UpdatePaletteButtons();
        }

        private void btn2007Silver_Click(object sender, EventArgs e)
        {
            kryptonManager.GlobalPaletteMode = PaletteModeManager.Office2007Silver;
            UpdatePaletteButtons();
        }

        private void btn2007Black_Click(object sender, EventArgs e)
        {
            kryptonManager.GlobalPaletteMode = PaletteModeManager.Office2007Black;
            UpdatePaletteButtons();
        }

        private void UpdatePaletteButtons()
        {
            btn365Blue.Checked = (kryptonManager.GlobalPaletteMode == PaletteModeManager.Office365Blue);
            btn365Silver.Checked = (kryptonManager.GlobalPaletteMode == PaletteModeManager.Office365Silver);
            btn365DarkGray.Checked = (kryptonManager.GlobalPaletteMode == PaletteModeManager.Office365DarkGray);

            btn2010Blue.Checked = (kryptonManager.GlobalPaletteMode == PaletteModeManager.Office2010Blue);
            btn2010Silver.Checked = (kryptonManager.GlobalPaletteMode == PaletteModeManager.Office2010Silver);
            btn2010Black.Checked = (kryptonManager.GlobalPaletteMode == PaletteModeManager.Office2010Black);

            btn2007Blue.Checked = (kryptonManager.GlobalPaletteMode == PaletteModeManager.Office2007Blue);
            btn2007Silver.Checked = (kryptonManager.GlobalPaletteMode == PaletteModeManager.Office2007Silver);
            btn2007Black.Checked = (kryptonManager.GlobalPaletteMode == PaletteModeManager.Office2007Black);
        }

        #endregion `팔레트 영역`
    }
}
