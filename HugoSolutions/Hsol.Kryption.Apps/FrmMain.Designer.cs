namespace Hsol.Kryption.Apps
{
    partial class FrmMain
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.imgListSmall = new System.Windows.Forms.ImageList(this.components);
            this.kryptonManager = new Krypton.Toolkit.KryptonManager(this.components);
            this.kryptonDockingManager = new Krypton.Docking.KryptonDockingManager();
            this.kryptonRibbon = new Krypton.Ribbon.KryptonRibbon();
            this.kryptonRibbonTab1 = new Krypton.Ribbon.KryptonRibbonTab();
            this.kryptonRibbonGroup2 = new Krypton.Ribbon.KryptonRibbonGroup();
            this.kryptonRibbonGroupTriple6 = new Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.kryptonRibbonGroupButton1 = new Krypton.Ribbon.KryptonRibbonGroupButton();
            this.kryptonRibbonGroupButton2 = new Krypton.Ribbon.KryptonRibbonGroupButton();
            this.kryptonRibbonGroupButton3 = new Krypton.Ribbon.KryptonRibbonGroupButton();
            this.kryptonRibbonTab2 = new Krypton.Ribbon.KryptonRibbonTab();
            this.kryptonRibbonGroup1 = new Krypton.Ribbon.KryptonRibbonGroup();
            this.kryptonRibbonGroupTriple5 = new Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.btn365Blue = new Krypton.Ribbon.KryptonRibbonGroupButton();
            this.btn365Silver = new Krypton.Ribbon.KryptonRibbonGroupButton();
            this.btn365DarkGray = new Krypton.Ribbon.KryptonRibbonGroupButton();
            this.kryptonRibbonGroupSeparator4 = new Krypton.Ribbon.KryptonRibbonGroupSeparator();
            this.kryptonRibbonGroupTriple1 = new Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.btn2010Blue = new Krypton.Ribbon.KryptonRibbonGroupButton();
            this.btn2010Silver = new Krypton.Ribbon.KryptonRibbonGroupButton();
            this.btn2010Black = new Krypton.Ribbon.KryptonRibbonGroupButton();
            this.kryptonRibbonGroupSeparator1 = new Krypton.Ribbon.KryptonRibbonGroupSeparator();
            this.kryptonRibbonGroupTriple2 = new Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.btn2007Blue = new Krypton.Ribbon.KryptonRibbonGroupButton();
            this.btn2007Silver = new Krypton.Ribbon.KryptonRibbonGroupButton();
            this.btn2007Black = new Krypton.Ribbon.KryptonRibbonGroupButton();
            this.kryptonRibbonGroupSeparator2 = new Krypton.Ribbon.KryptonRibbonGroupSeparator();
            this.kryptonRibbonGroupTriple3 = new Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.btnSparkleBlue = new Krypton.Ribbon.KryptonRibbonGroupButton();
            this.btnSparkleOrange = new Krypton.Ribbon.KryptonRibbonGroupButton();
            this.btnSparklePurple = new Krypton.Ribbon.KryptonRibbonGroupButton();
            this.kryptonRibbonGroupSeparator3 = new Krypton.Ribbon.KryptonRibbonGroupSeparator();
            this.kryptonRibbonGroupTriple4 = new Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.btnSystem = new Krypton.Ribbon.KryptonRibbonGroupButton();
            this.kryptonDockableWorkspace = new Krypton.Docking.KryptonDockableWorkspace();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonRibbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDockableWorkspace)).BeginInit();
            this.SuspendLayout();
            // 
            // imgListSmall
            // 
            this.imgListSmall.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgListSmall.ImageStream")));
            this.imgListSmall.TransparentColor = System.Drawing.Color.Transparent;
            this.imgListSmall.Images.SetKeyName(0, "docs.png");
            this.imgListSmall.Images.SetKeyName(1, "preference.png");
            this.imgListSmall.Images.SetKeyName(2, "information.png");
            this.imgListSmall.Images.SetKeyName(3, "cloud-computing.png");
            this.imgListSmall.Images.SetKeyName(4, "neural.png");
            this.imgListSmall.Images.SetKeyName(5, "notification.png");
            this.imgListSmall.Images.SetKeyName(6, "phone-call.png");
            this.imgListSmall.Images.SetKeyName(7, "test.png");
            // 
            // kryptonRibbon
            // 
            this.kryptonRibbon.InDesignHelperMode = true;
            this.kryptonRibbon.Name = "kryptonRibbon";
            this.kryptonRibbon.RibbonTabs.AddRange(new Krypton.Ribbon.KryptonRibbonTab[] {
            this.kryptonRibbonTab1,
            this.kryptonRibbonTab2});
            this.kryptonRibbon.SelectedTab = this.kryptonRibbonTab1;
            this.kryptonRibbon.Size = new System.Drawing.Size(1148, 136);
            this.kryptonRibbon.TabIndex = 0;
            // 
            // kryptonRibbonTab1
            // 
            this.kryptonRibbonTab1.Groups.AddRange(new Krypton.Ribbon.KryptonRibbonGroup[] {
            this.kryptonRibbonGroup2});
            this.kryptonRibbonTab1.Text = "메뉴";
            // 
            // kryptonRibbonGroup2
            // 
            this.kryptonRibbonGroup2.Items.AddRange(new Krypton.Ribbon.KryptonRibbonGroupContainer[] {
            this.kryptonRibbonGroupTriple6});
            this.kryptonRibbonGroup2.TextLine1 = "시스템";
            // 
            // kryptonRibbonGroupTriple6
            // 
            this.kryptonRibbonGroupTriple6.Items.AddRange(new Krypton.Ribbon.KryptonRibbonGroupItem[] {
            this.kryptonRibbonGroupButton1,
            this.kryptonRibbonGroupButton2,
            this.kryptonRibbonGroupButton3});
            // 
            // kryptonRibbonTab2
            // 
            this.kryptonRibbonTab2.Groups.AddRange(new Krypton.Ribbon.KryptonRibbonGroup[] {
            this.kryptonRibbonGroup1});
            this.kryptonRibbonTab2.Text = "팔레트";
            // 
            // kryptonRibbonGroup1
            // 
            this.kryptonRibbonGroup1.Items.AddRange(new Krypton.Ribbon.KryptonRibbonGroupContainer[] {
            this.kryptonRibbonGroupTriple5,
            this.kryptonRibbonGroupSeparator4,
            this.kryptonRibbonGroupTriple1,
            this.kryptonRibbonGroupSeparator1,
            this.kryptonRibbonGroupTriple2,
            this.kryptonRibbonGroupSeparator2,
            this.kryptonRibbonGroupTriple3,
            this.kryptonRibbonGroupSeparator3,
            this.kryptonRibbonGroupTriple4});
            this.kryptonRibbonGroup1.TextLine1 = "팔레트 셋팅";
            // 
            // kryptonRibbonGroupTriple5
            // 
            this.kryptonRibbonGroupTriple5.Items.AddRange(new Krypton.Ribbon.KryptonRibbonGroupItem[] {
            this.btn365Blue,
            this.btn365Silver,
            this.btn365DarkGray});
            // 
            // btn365Blue
            // 
            this.btn365Blue.ButtonType = Krypton.Ribbon.GroupButtonType.Check;
            this.btn365Blue.Checked = true;
            this.btn365Blue.ImageLarge = global::Hsol.Kryption.Apps.Properties.Resources.color_circle32;
            this.btn365Blue.ImageSmall = global::Hsol.Kryption.Apps.Properties.Resources.color_circle16;
            this.btn365Blue.TextLine1 = "365";
            this.btn365Blue.TextLine2 = "Blue";
            this.btn365Blue.Click += new System.EventHandler(this.btn365Blue_Click);
            // 
            // btn365Silver
            // 
            this.btn365Silver.ButtonType = Krypton.Ribbon.GroupButtonType.Check;
            this.btn365Silver.ImageLarge = global::Hsol.Kryption.Apps.Properties.Resources.color_circle32;
            this.btn365Silver.ImageSmall = global::Hsol.Kryption.Apps.Properties.Resources.color_circle16;
            this.btn365Silver.TextLine1 = "365";
            this.btn365Silver.TextLine2 = "Silver";
            this.btn365Silver.Click += new System.EventHandler(this.btn365Silver_Click);
            // 
            // btn365DarkGray
            // 
            this.btn365DarkGray.ButtonType = Krypton.Ribbon.GroupButtonType.Check;
            this.btn365DarkGray.ImageLarge = global::Hsol.Kryption.Apps.Properties.Resources.color_circle32;
            this.btn365DarkGray.ImageSmall = global::Hsol.Kryption.Apps.Properties.Resources.color_circle16;
            this.btn365DarkGray.TextLine1 = "365";
            this.btn365DarkGray.TextLine2 = "Dark";
            this.btn365DarkGray.Click += new System.EventHandler(this.btn365DarkGray_Click);
            // 
            // kryptonRibbonGroupTriple1
            // 
            this.kryptonRibbonGroupTriple1.Items.AddRange(new Krypton.Ribbon.KryptonRibbonGroupItem[] {
            this.btn2010Blue,
            this.btn2010Silver,
            this.btn2010Black});
            // 
            // btn2010Blue
            // 
            this.btn2010Blue.ButtonType = Krypton.Ribbon.GroupButtonType.Check;
            this.btn2010Blue.ImageLarge = global::Hsol.Kryption.Apps.Properties.Resources.palette32;
            this.btn2010Blue.ImageSmall = global::Hsol.Kryption.Apps.Properties.Resources.palette16;
            this.btn2010Blue.TextLine1 = "2010";
            this.btn2010Blue.TextLine2 = "Blue";
            this.btn2010Blue.Click += new System.EventHandler(this.btn2010Blue_Click);
            // 
            // btn2010Silver
            // 
            this.btn2010Silver.ButtonType = Krypton.Ribbon.GroupButtonType.Check;
            this.btn2010Silver.ImageLarge = global::Hsol.Kryption.Apps.Properties.Resources.palette32;
            this.btn2010Silver.ImageSmall = global::Hsol.Kryption.Apps.Properties.Resources.palette16;
            this.btn2010Silver.TextLine1 = "2010";
            this.btn2010Silver.TextLine2 = "Silver";
            this.btn2010Silver.Click += new System.EventHandler(this.btn2010Silver_Click);
            // 
            // btn2010Black
            // 
            this.btn2010Black.ButtonType = Krypton.Ribbon.GroupButtonType.Check;
            this.btn2010Black.ImageLarge = global::Hsol.Kryption.Apps.Properties.Resources.palette32;
            this.btn2010Black.ImageSmall = global::Hsol.Kryption.Apps.Properties.Resources.palette16;
            this.btn2010Black.TextLine1 = "2010";
            this.btn2010Black.TextLine2 = "Black";
            this.btn2010Black.Click += new System.EventHandler(this.btn2010Black_Click);
            // 
            // kryptonRibbonGroupTriple2
            // 
            this.kryptonRibbonGroupTriple2.Items.AddRange(new Krypton.Ribbon.KryptonRibbonGroupItem[] {
            this.btn2007Blue,
            this.btn2007Silver,
            this.btn2007Black});
            // 
            // btn2007Blue
            // 
            this.btn2007Blue.ButtonType = Krypton.Ribbon.GroupButtonType.Check;
            this.btn2007Blue.ImageLarge = global::Hsol.Kryption.Apps.Properties.Resources.color_palette32;
            this.btn2007Blue.ImageSmall = global::Hsol.Kryption.Apps.Properties.Resources.color_palette16;
            this.btn2007Blue.TextLine1 = "2007";
            this.btn2007Blue.TextLine2 = "Blue";
            this.btn2007Blue.Click += new System.EventHandler(this.btn2007Blue_Click);
            // 
            // btn2007Silver
            // 
            this.btn2007Silver.ButtonType = Krypton.Ribbon.GroupButtonType.Check;
            this.btn2007Silver.ImageLarge = global::Hsol.Kryption.Apps.Properties.Resources.color_palette32;
            this.btn2007Silver.ImageSmall = global::Hsol.Kryption.Apps.Properties.Resources.color_palette16;
            this.btn2007Silver.TextLine1 = "2007";
            this.btn2007Silver.TextLine2 = "Silver";
            this.btn2007Silver.Click += new System.EventHandler(this.btn2007Silver_Click);
            // 
            // btn2007Black
            // 
            this.btn2007Black.ButtonType = Krypton.Ribbon.GroupButtonType.Check;
            this.btn2007Black.ImageLarge = global::Hsol.Kryption.Apps.Properties.Resources.color_palette32;
            this.btn2007Black.ImageSmall = global::Hsol.Kryption.Apps.Properties.Resources.color_palette16;
            this.btn2007Black.TextLine1 = "2007";
            this.btn2007Black.TextLine2 = "Black";
            this.btn2007Black.Click += new System.EventHandler(this.btn2007Black_Click);
            // 
            // kryptonRibbonGroupTriple3
            // 
            this.kryptonRibbonGroupTriple3.Items.AddRange(new Krypton.Ribbon.KryptonRibbonGroupItem[] {
            this.btnSparkleBlue,
            this.btnSparkleOrange,
            this.btnSparklePurple});
            // 
            // btnSparkleBlue
            // 
            this.btnSparkleBlue.ButtonType = Krypton.Ribbon.GroupButtonType.Check;
            this.btnSparkleBlue.ImageLarge = global::Hsol.Kryption.Apps.Properties.Resources.sparkle32;
            this.btnSparkleBlue.ImageSmall = global::Hsol.Kryption.Apps.Properties.Resources.sparkle16;
            this.btnSparkleBlue.TextLine1 = "Sparkle";
            this.btnSparkleBlue.TextLine2 = "Blue";
            this.btnSparkleBlue.Click += new System.EventHandler(this.btnSparkleBlue_Click);
            // 
            // btnSparkleOrange
            // 
            this.btnSparkleOrange.ButtonType = Krypton.Ribbon.GroupButtonType.Check;
            this.btnSparkleOrange.ImageLarge = global::Hsol.Kryption.Apps.Properties.Resources.sparkle32;
            this.btnSparkleOrange.ImageSmall = global::Hsol.Kryption.Apps.Properties.Resources.sparkle16;
            this.btnSparkleOrange.TextLine1 = "Sparkle";
            this.btnSparkleOrange.TextLine2 = "Orange";
            this.btnSparkleOrange.Click += new System.EventHandler(this.btnSparkleOrange_Click);
            // 
            // btnSparklePurple
            // 
            this.btnSparklePurple.ImageLarge = global::Hsol.Kryption.Apps.Properties.Resources.sparkle32;
            this.btnSparklePurple.ImageSmall = global::Hsol.Kryption.Apps.Properties.Resources.sparkle16;
            this.btnSparklePurple.TextLine1 = "Sparkle";
            this.btnSparklePurple.TextLine2 = "Purple";
            this.btnSparklePurple.Click += new System.EventHandler(this.btnSparklePurple_Click);
            // 
            // kryptonRibbonGroupTriple4
            // 
            this.kryptonRibbonGroupTriple4.Items.AddRange(new Krypton.Ribbon.KryptonRibbonGroupItem[] {
            this.btnSystem});
            // 
            // btnSystem
            // 
            this.btnSystem.ButtonType = Krypton.Ribbon.GroupButtonType.Check;
            this.btnSystem.ImageLarge = global::Hsol.Kryption.Apps.Properties.Resources.icons8_system_32;
            this.btnSystem.ImageSmall = global::Hsol.Kryption.Apps.Properties.Resources.icons8_system_16;
            this.btnSystem.TextLine1 = "System";
            this.btnSystem.Click += new System.EventHandler(this.btnSystem_Click);
            // 
            // kryptonDockableWorkspace
            // 
            this.kryptonDockableWorkspace.ActivePage = null;
            this.kryptonDockableWorkspace.AutoHiddenHost = false;
            this.kryptonDockableWorkspace.CompactFlags = ((Krypton.Workspace.CompactFlags)(((Krypton.Workspace.CompactFlags.RemoveEmptyCells | Krypton.Workspace.CompactFlags.RemoveEmptySequences) 
            | Krypton.Workspace.CompactFlags.PromoteLeafs)));
            this.kryptonDockableWorkspace.ContainerBackStyle = Krypton.Toolkit.PaletteBackStyle.PanelClient;
            this.kryptonDockableWorkspace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonDockableWorkspace.Location = new System.Drawing.Point(0, 136);
            this.kryptonDockableWorkspace.Name = "kryptonDockableWorkspace";
            // 
            // 
            // 
            this.kryptonDockableWorkspace.Root.UniqueName = "bcc820e479f145d2be8f401aaa719111";
            this.kryptonDockableWorkspace.Root.WorkspaceControl = this.kryptonDockableWorkspace;
            this.kryptonDockableWorkspace.SeparatorStyle = Krypton.Toolkit.SeparatorStyle.LowProfile;
            this.kryptonDockableWorkspace.ShowMaximizeButton = false;
            this.kryptonDockableWorkspace.Size = new System.Drawing.Size(1148, 448);
            this.kryptonDockableWorkspace.SplitterWidth = 5;
            this.kryptonDockableWorkspace.TabIndex = 1;
            this.kryptonDockableWorkspace.TabStop = true;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 584);
            this.Controls.Add(this.kryptonDockableWorkspace);
            this.Controls.Add(this.kryptonRibbon);
            this.Font = new System.Drawing.Font("나눔고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HSOL.KRYPTON.APP v1.0";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonRibbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDockableWorkspace)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imgListSmall;
        private Krypton.Toolkit.KryptonManager kryptonManager;
        private Krypton.Docking.KryptonDockingManager kryptonDockingManager;
        private Krypton.Ribbon.KryptonRibbon kryptonRibbon;
        private Krypton.Docking.KryptonDockableWorkspace kryptonDockableWorkspace;
        private Krypton.Ribbon.KryptonRibbonTab kryptonRibbonTab1;
        private Krypton.Ribbon.KryptonRibbonTab kryptonRibbonTab2;
        private Krypton.Ribbon.KryptonRibbonGroup kryptonRibbonGroup1;
        private Krypton.Ribbon.KryptonRibbonGroupTriple kryptonRibbonGroupTriple1;
        private Krypton.Ribbon.KryptonRibbonGroupButton btn2010Blue;
        private Krypton.Ribbon.KryptonRibbonGroupButton btn2010Silver;
        private Krypton.Ribbon.KryptonRibbonGroupButton btn2010Black;
        private Krypton.Ribbon.KryptonRibbonGroupSeparator kryptonRibbonGroupSeparator1;
        private Krypton.Ribbon.KryptonRibbonGroupTriple kryptonRibbonGroupTriple2;
        private Krypton.Ribbon.KryptonRibbonGroupButton btn2007Blue;
        private Krypton.Ribbon.KryptonRibbonGroupButton btn2007Silver;
        private Krypton.Ribbon.KryptonRibbonGroupButton btn2007Black;
        private Krypton.Ribbon.KryptonRibbonGroupSeparator kryptonRibbonGroupSeparator2;
        private Krypton.Ribbon.KryptonRibbonGroupTriple kryptonRibbonGroupTriple3;
        private Krypton.Ribbon.KryptonRibbonGroupButton btnSparkleBlue;
        private Krypton.Ribbon.KryptonRibbonGroupButton btnSparkleOrange;
        private Krypton.Ribbon.KryptonRibbonGroupButton btnSparklePurple;
        private Krypton.Ribbon.KryptonRibbonGroupSeparator kryptonRibbonGroupSeparator3;
        private Krypton.Ribbon.KryptonRibbonGroupTriple kryptonRibbonGroupTriple4;
        private Krypton.Ribbon.KryptonRibbonGroupButton btnSystem;
        private Krypton.Ribbon.KryptonRibbonGroupTriple kryptonRibbonGroupTriple5;
        private Krypton.Ribbon.KryptonRibbonGroupButton btn365Blue;
        private Krypton.Ribbon.KryptonRibbonGroupButton btn365Silver;
        private Krypton.Ribbon.KryptonRibbonGroupButton btn365DarkGray;
        private Krypton.Ribbon.KryptonRibbonGroupSeparator kryptonRibbonGroupSeparator4;
        private Krypton.Ribbon.KryptonRibbonGroup kryptonRibbonGroup2;
        private Krypton.Ribbon.KryptonRibbonGroupTriple kryptonRibbonGroupTriple6;
        private Krypton.Ribbon.KryptonRibbonGroupButton kryptonRibbonGroupButton1;
        private Krypton.Ribbon.KryptonRibbonGroupButton kryptonRibbonGroupButton2;
        private Krypton.Ribbon.KryptonRibbonGroupButton kryptonRibbonGroupButton3;
    }
}

