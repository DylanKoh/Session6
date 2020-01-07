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

            allocatedList.Rows.Clear();
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
                                   select new { Name = x.Part.Name, BatchNumber = x.BatchNumber, unitPrice = x.UnitPrice, Amount = x.Amount, ID = x.OrderID });

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
                                   select new { Name = x.Part.Name, BatchNumber = x.BatchNumber, unitPrice = x.UnitPrice, Amount = x.Amount, ID = x.OrderID });
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
                                   select new { Name = x.Part.Name, BatchNumber = x.BatchNumber, unitPrice = x.UnitPrice, Amount = x.Amount, ID = x.OrderID });
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
            assignedList.ColumnCount = 5;
            assignedList.Columns[0].Name = "Name";
            assignedList.Columns[1].Name = "Batch Number";
            assignedList.Columns[2].Name = "Unit Price";
            assignedList.Columns[3].Name = "Amount";
            assignedList.Columns[4].Name = "ID";
            assignedList.Columns[4].Visible = false;

            DataGridViewLinkColumn dgvLC = new DataGridViewLinkColumn()
            {
                UseColumnTextForLinkValue = true,
                HeaderText = "Action",
                Name = "Action",
                Text = "Remove"
            };

            assignedList.Columns.Add(dgvLC);
            foreach (DataGridViewRow rows in allocatedList.Rows)
            {
                List<string> rowList = new List<string>()
                {
                    rows.Cells[0].Value.ToString(), rows.Cells[1].Value.ToString(), rows.Cells[2].Value.ToString(),
                    rows.Cells[3].Value.ToString(), rows.Cells[4].Value.ToString()
                };

                assignedList.Rows.Add(rowList.ToArray());
            }
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

        private void assignedList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                var getRowIndex = e.RowIndex;
                assignedList.Rows.RemoveAt(getRowIndex);
            }
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in assignedList.Rows)
            {
                if (item == null)
                {
                    MessageBox.Show("A part needs to be allocated to submit changes to Database!",
                        "No changes made!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    using (var context = new Session6Entities())
                    {
                        var part = item.Cells[0].Value.ToString();
                        var getPartID = (from x in context.Parts
                                         where x.Name == part
                                         select x.ID).FirstOrDefault();


                        if (item.Cells[1].Value.ToString() != "")
                        {
                            context.OrderItems.Add(new OrderItem()
                            {
                                PartID = getPartID,
                                BatchNumber = item.Cells[1].Value.ToString(),
                                UnitPrice = Convert.ToDecimal(item.Cells[2].Value),
                                Amount = Convert.ToDecimal(item.Cells[3].Value),
                                OrderID = Convert.ToInt64(item.Cells[4].Value)
                            });
                        }

                        else
                        {
                            context.OrderItems.Add(new OrderItem()
                            {
                                PartID = getPartID,
                                UnitPrice = Convert.ToDecimal(item.Cells[2].Value),
                                Amount = Convert.ToDecimal(item.Cells[3].Value),
                                OrderID = Convert.ToInt64(item.Cells[4].Value)
                            });
                        }
                        

                        var orderID = Convert.ToInt64(item.Cells[4].Value);

                        var updateOrders = (from x in context.Orders
                                            where x.ID == orderID
                                            select new { x }).First();

                        updateOrders.x.Date = dateBox.Value;
                        context.SaveChanges();
                        this.Close();
                    }
                }
            }
        }
    }
}
