
namespace HugoSMS.WinForm.App.Views.Stores
{
    partial class AddStoreView
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

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.LblDuplicate = new System.Windows.Forms.Label();
            this.LblLocation = new System.Windows.Forms.Label();
            this.LblStoreName = new System.Windows.Forms.Label();
            this.BtnBack = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.TxtStoreLocation = new System.Windows.Forms.TextBox();
            this.TxtStoreName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔고딕", 21.75F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(4, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 34);
            this.label1.TabIndex = 100;
            this.label1.Text = "창고 추가";
            // 
            // LblDuplicate
            // 
            this.LblDuplicate.AutoSize = true;
            this.LblDuplicate.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDuplicate.ForeColor = System.Drawing.Color.Red;
            this.LblDuplicate.Location = new System.Drawing.Point(526, 130);
            this.LblDuplicate.Name = "LblDuplicate";
            this.LblDuplicate.Size = new System.Drawing.Size(130, 15);
            this.LblDuplicate.TabIndex = 331;
            this.LblDuplicate.Text = "Store already exists!";
            this.LblDuplicate.Visible = false;
            // 
            // LblLocation
            // 
            this.LblLocation.AutoSize = true;
            this.LblLocation.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLocation.ForeColor = System.Drawing.Color.Red;
            this.LblLocation.Location = new System.Drawing.Point(526, 101);
            this.LblLocation.Name = "LblLocation";
            this.LblLocation.Size = new System.Drawing.Size(174, 15);
            this.LblLocation.TabIndex = 330;
            this.LblLocation.Text = "Please enter store location!";
            this.LblLocation.Visible = false;
            // 
            // LblStoreName
            // 
            this.LblStoreName.AutoSize = true;
            this.LblStoreName.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblStoreName.ForeColor = System.Drawing.Color.Red;
            this.LblStoreName.Location = new System.Drawing.Point(526, 69);
            this.LblStoreName.Name = "LblStoreName";
            this.LblStoreName.Size = new System.Drawing.Size(160, 15);
            this.LblStoreName.TabIndex = 329;
            this.LblStoreName.Text = "Please enter store name!";
            this.LblStoreName.Visible = false;
            // 
            // BtnBack
            // 
            this.BtnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnBack.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBack.Font = new System.Drawing.Font("나눔고딕", 14.25F);
            this.BtnBack.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnBack.Location = new System.Drawing.Point(1101, 365);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(71, 104);
            this.BtnBack.TabIndex = 328;
            this.BtnBack.Text = "Back";
            this.BtnBack.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("나눔고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(441, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 24);
            this.label5.TabIndex = 327;
            this.label5.Text = "Add";
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnAdd.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdd.Location = new System.Drawing.Point(426, 130);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(93, 56);
            this.BtnAdd.TabIndex = 326;
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // TxtStoreLocation
            // 
            this.TxtStoreLocation.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtStoreLocation.Location = new System.Drawing.Point(233, 101);
            this.TxtStoreLocation.Name = "TxtStoreLocation";
            this.TxtStoreLocation.Size = new System.Drawing.Size(285, 26);
            this.TxtStoreLocation.TabIndex = 325;
            // 
            // TxtStoreName
            // 
            this.TxtStoreName.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtStoreName.Location = new System.Drawing.Point(233, 69);
            this.TxtStoreName.Name = "TxtStoreName";
            this.TxtStoreName.Size = new System.Drawing.Size(285, 26);
            this.TxtStoreName.TabIndex = 324;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(22, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 19);
            this.label7.TabIndex = 323;
            this.label7.Text = "Store Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(22, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 19);
            this.label6.TabIndex = 322;
            this.label6.Text = "Store Location:";
            // 
            // AddStoreView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.LblDuplicate);
            this.Controls.Add(this.LblLocation);
            this.Controls.Add(this.LblStoreName);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.TxtStoreLocation);
            this.Controls.Add(this.TxtStoreName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Name = "AddStoreView";
            this.Size = new System.Drawing.Size(1203, 491);
            this.Load += new System.EventHandler(this.AddStoreView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblDuplicate;
        private System.Windows.Forms.Label LblLocation;
        private System.Windows.Forms.Label LblStoreName;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.TextBox TxtStoreLocation;
        private System.Windows.Forms.TextBox TxtStoreName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}
