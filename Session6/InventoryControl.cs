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

            allocatedList.ColumnCount = 5;
            allocatedList.Columns[0].Name = "Name";
            allocatedList.Columns[1].Name = "Batch Number";
            allocatedList.Columns[2].Name = "Unit Price";
            allocatedList.Columns[3].Name = "Amount";
            allocatedList.Columns[4].Name = "ID";
            allocatedList.Columns[4].Visible = false;
            using (var context = new Session6Entities())
            {
                var amount = Decimal.Parse(amtBox.Text);
                var selectedPart = partBox.SelectedItem.ToString();
                if (aMethodBox.SelectedItem.ToString() == "LIFO")
                {
                    var getPart = (from x in context.OrderItems
                                   where x.Part.Name == selectedPart
                                   orderby x.Order.Date descending
                                   where x.Amount <= amount
                                   select new { Name = x.Part.Name, BatchNumber = x.BatchNumber, unitPrice = x.UnitPrice, Amount = x.Amount, ID = x.ID });

                    decimal amtToAdd = 0;
                    while (amtToAdd <= amount)
                    {
                        foreach (var item in getPart)
                        {
                            List<string> rows = new List<string>() 
                            { 
                                item.Name, item.BatchNumber, item.unitPrice.ToString(), item.Amount.ToString(), item.ID.ToString()
                            };

                            amtToAdd += item.Amount;
                            if (amtToAdd > amount) break;
                            allocatedList.Rows.Add(rows.ToArray());
                            
                        }
                    }

                }
                else if (aMethodBox.SelectedItem.ToString() == "FIFO")
                {
                    var getPart = (from x in context.OrderItems
                                   where x.Part.Name == selectedPart
                                   orderby x.Order.Date ascending
                                   where x.Amount <= amount
                                   select new { Name = x.Part.Name, BatchNumber = x.BatchNumber, unitPrice = x.UnitPrice, Amount = x.Amount, ID = x.ID });
                    decimal amtToAdd = 0;
                    while (amtToAdd <= amount)
                    {
                        foreach (var item in getPart)
                        {
                            List<string> rows = new List<string>()
                            {
                                item.Name, item.BatchNumber, item.unitPrice.ToString(), item.Amount.ToString(), item.ID.ToString()
                            };

                            amtToAdd += item.Amount;
                            if (amtToAdd > amount) break;
                            allocatedList.Rows.Add(rows.ToArray());

                        }
                    }
                }
                else
                {
                    var getPart = (from x in context.OrderItems
                                   where x.Part.Name == selectedPart
                                   orderby x.UnitPrice * x.Amount ascending
                                   where x.Amount <= amount
                                   select new { Name = x.Part.Name, BatchNumber = x.BatchNumber, unitPrice = x.UnitPrice, Amount = x.Amount, ID = x.ID });
                    decimal amtToAdd = 0;
                    while (amtToAdd <= amount)
                    {
                        foreach (var item in getPart)
                        {
                            List<string> rows = new List<string>()
                            {
                                item.Name, item.BatchNumber, item.unitPrice.ToString(), item.Amount.ToString(), item.ID.ToString()
                            };

                            amtToAdd += item.Amount;
                            if (amtToAdd > amount) break;
                            allocatedList.Rows.Add(rows.ToArray());

                        }
                    }
                }
            }

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

                List<string> vs = new List<string>()
                {
                    "LIFO", "FIFO", "Minimum Price"
                };

                aMethodBox.Items.AddRange(vs.ToArray());
                aMethodBox.SelectedItem = vs[2];

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
                                    where y.Amount != 0
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
