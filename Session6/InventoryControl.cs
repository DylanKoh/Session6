using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session6
{
    public partial class InventoryControl : Form
    {
        // Check Commit
        public InventoryControl()
        {
            InitializeComponent();
        }

        private void allocateBtn_Click(object sender, EventArgs e)
        {

        }

        private void assignBtn_Click(object sender, EventArgs e)
        {

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void InventoryControl_Load(object sender, EventArgs e)
        {
            LoadFields();
        }

        private void LoadFields()
        {
            dateBox.Value = DateTime.Now;

            using (var context = new Session6Entities())
            {
                var getAsset = (from x in context.Assets
                                select new { Asset = x.AssetName + " (" + x.AssetSN + ")" }).Distinct();
                List<string> assets = new List<string>();
                foreach (var item in getAsset)
                {
                    assets.Add(item.Asset);
                }

                assetBox.Items.AddRange(assets.ToArray());
                assetBox.SelectedItem = assets.First();

                var getWarehouse = (from x in context.Warehouses
                                    select x.Name).Distinct().ToList();

                warehouseBox.Items.AddRange(getWarehouse.ToArray());
                warehouseBox.SelectedItem = getWarehouse.First();
            }
        }
    }
}
