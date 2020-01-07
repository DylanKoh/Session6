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
                                join y in context.EmergencyMaintenances on x.ID equals y.AssetID
                                where y.EMStartDate != null && y.EMEndDate == null
                                select new { Asset = x.AssetName, EM = y.ID });
                List<string> assets = new List<string>();
                foreach (var item in getAsset)
                {
                    assets.Add(item.Asset + " (" + item.EM + ")");
                }

                assetBox.Items.AddRange(assets.ToArray());
                assetBox.SelectedItem = assets.First();

                var getWarehouse = (from x in context.Warehouses
                                    select x.Name).Distinct().ToList();

                warehouseBox.Items.AddRange(getWarehouse.ToArray());
                warehouseBox.SelectedItem = getWarehouse.First();

                

            }
        }

        private void partBox_SelectedIndexChanged(object sender, EventArgs e)
        {





        }

        private void partBox_Click(object sender, EventArgs e)
        {
            using (var context = new Session6Entities())
            {
                if (warehouseBox.SelectedItem != null)
                {
                    partBox.Items.Clear();
                    var warehouseName = warehouseBox.SelectedItem.ToString();

                    var getWarehouseID = (from x in context.Warehouses
                                          where x.Name.Equals(warehouseName)
                                          select x.ID).FirstOrDefault();

                    var getParts = (from x in context.Orders
                                    where x.SourceWarehouseID == getWarehouseID
                                    join y in context.OrderItems on x.ID equals y.OrderID
                                    select y.Part.Name).Distinct();
                    List<string> partList = new List<string>();
                    foreach (var parts in getParts)
                    {
                        partList.Add(parts);
                    }

                    partBox.Items.AddRange(partList.ToArray());
                }
            }
        }
    }
}
