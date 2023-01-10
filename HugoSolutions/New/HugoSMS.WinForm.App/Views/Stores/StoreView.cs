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

namespace HugoSMS.WinForm.App.Views.Stores
{
    public partial class StoreView : UserControl
    {
        List<Store> stores = new List<Store>();
        List<Stock> stocks = new List<Stock>();

        public StoreView()
        {
            InitializeComponent();
        }

        private void BtnExportPdf_Click(object sender, EventArgs e)
        {

        }

        private void BtnAddStore_Click(object sender, EventArgs e)
        {
            ((MainView)this.Parent.Parent).ChangeView<AddStoreView>();
        }

        private void BtnUpdateStore_Click(object sender, EventArgs e)
        {

        }

        private void StoreView_Load(object sender, EventArgs e)
        {
            try
            {
                stores = Business.DataAccess.GetStores();
                stocks = Business.DataAccess.GetStocks();

                for (int i = 0; i < stores.Count; i++)
                {
                    int total = stocks.Where(t => t.StoreID == stores[i].StoreID).ToList().Count;
                    DgvData.Rows.Add(stores[i].StoreID, stores[i].StoreName, stores[i].StoreLocation, total);
                }

                DgvData.ClearSelection();
            }
            catch (Exception ex)
            {
                COMMONS.LOGGER.Error($"예외발생 : {ex.Message}");
            }
        }
    }
}
