using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HugoSMS.WinForm.App.Helpers;
using HugoSMS.WinForm.App.Models;
using MetroFramework;

namespace HugoSMS.WinForm.App.Views.Stores
{
    public partial class AddStoreView : UserControl
    {
        List<Store> stores = new List<Store>();

        public AddStoreView()
        {
            InitializeComponent();
        }

        private void AddStoreView_Load(object sender, EventArgs e)
        {
            try
            {
                stores = Business.DataAccess.GetStores();
            }
            catch (Exception ex)
            {
                COMMONS.LOGGER.Error($"예외발생 : {ex.Message}");
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            LblStoreName.Visible = LblLocation.Visible = LblDuplicate.Visible = false;
            bool isCheck = true;
            int result = 0;

            if (string.IsNullOrEmpty(TxtStoreName.Text))
            {
                LblStoreName.Visible = true;
                LblStoreName.Text = @"창고명을 입력하세요.";
                isCheck = false;
            }

            if (string.IsNullOrEmpty(TxtStoreLocation.Text))
            {
                LblLocation.Visible = true;
                LblLocation.Text = @"창고위치를 입력하세요.";
                isCheck = false;
            }

            try
            {
                if (stores?.Where(s => s.StoreName.Equals(TxtStoreName.Text)).FirstOrDefault() != null)
                {
                    LblDuplicate.Visible = true;
                    LblDuplicate.Text = @"창고가 이미 존재합니다.";
                    isCheck = false;
                }

                if (isCheck)
                {
                    Store store = new Store() {StoreName = TxtStoreName.Text, StoreLocation = TxtStoreLocation.Text};

                    result = Business.DataAccess.SetStore(store);

                    if (result == -1)
                    {
                        MetroMessageBox.Show(this, "Sorry something went wrong, the store was not added");
                        ((MainView)this.Parent.Parent).ChangeView<StoreView>();
                    }
                    else
                    {
                        MetroMessageBox.Show(this, "The store was added successfully");
                        ((MainView)this.Parent.Parent).ChangeView<StoreView>();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }

            
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {

        }
    }
}
