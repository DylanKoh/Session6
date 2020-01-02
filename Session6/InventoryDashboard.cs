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
    public partial class InventoryDashboard : Form
    {
        public InventoryDashboard()
        {
            InitializeComponent();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void InventoryDashboard_Load(object sender, EventArgs e)
        {
            GridRefresh();
        }

        private void GridRefresh()
        {
            spendList.ColumnCount = 1;
            spendList.Columns[0].Name = "Department / Month";
            using (var context = new Session6Entities())
            {
                var getDepartment = (from x in context.Departments
                                     select x.Name).ToList().Distinct();


                var getDepartmentSpendingGrouping = (from x in context.Orders
                                                     where x.EmergencyMaintenance.EMEndDate != null
                                                     orderby x.Date descending
                                                     select new { intDate = x.Date }).ToList();

                var getDistinctDates = (from x in getDepartmentSpendingGrouping
                                        select new { date = x.intDate.ToString("yyyy-MM") }).ToList();
                List<string> department = new List<string>();


                foreach (var item1 in getDistinctDates.Select(x => x.date).Distinct().Take(10))
                {
                    spendList.Columns.Add(item1, item1);

                    foreach (var departments in getDepartment)
                    {

                        var getDetailsOfSpending = (from x in context.Orders
                                                    select x).ToList();

                        var dID = (from x in context.Departments
                                   where x.Name.Equals(departments)
                                   select x.ID).First();

                        var getDetailsOfSpending1 = (from x in getDetailsOfSpending
                                                     where x.Date.ToString("yyyy-MM") == item1
                                                     join y in context.EmergencyMaintenances on x.EmergencyMaintenancesID equals y.ID
                                                     where y.Asset.DepartmentLocation.DepartmentID.Equals(dID)
                                                     select new { spending = x.OrderItems.Sum(p => p.Amount * p.UnitPrice) });

                        var getDetailsOfSpending2 = (from x in getDetailsOfSpending1
                                                     select x.spending);
                        // TO CHANGE, F'ed up the DGV
                        foreach (var spendings in getDetailsOfSpending)
                        {
                            List<string> vs = new List<string>()
                                {
                                    departments, spendings.ToString(), 
                                };
                            spendList.Rows.Add(vs.ToArray());
                        }


                    }
                }


            }
        }
    }
}
