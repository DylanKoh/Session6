using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
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

            mostUsedList.ColumnCount = 1;
            mostUsedList.Columns[0].Name = "Notes / Month";

            costlyAssetList.ColumnCount = 1;
            costlyAssetList.Columns[0].Name = "Asset Name / Month";
            using (var context = new Session6Entities())
            {
                var getDepartment = (from x in context.Orders
                                     where x.EmergencyMaintenance.EMStartDate != null && x.EmergencyMaintenance.EMEndDate != null
                                     select x.EmergencyMaintenance.Asset.DepartmentLocation.Department.Name).ToList();


                var getDepartmentSpendingGrouping = (from x in context.Orders
                                                     where x.EmergencyMaintenance.EMEndDate != null && x.EmergencyMaintenance.EMStartDate != null
                                                     orderby x.Date descending
                                                     select new { intDate = x.Date }).ToList();

                var getDistinctDates = (from x in getDepartmentSpendingGrouping
                                        select new { date = x.intDate.ToString("yyyy-MM") }).ToList().Select(x => x.date).Distinct().Take(10);

                foreach (var date in getDistinctDates)
                {
                    spendList.Columns.Add(date, date);
                    mostUsedList.Columns.Add(date, date);
                    costlyAssetList.Columns.Add(date, date);
                }

                foreach (var department in getDepartment.Select(x => x).Distinct())
                {
                    List<string> row = new List<string>();
                    row.Add(department);
                    Console.WriteLine(department);

                    foreach (var date in getDistinctDates)
                    {
                        var getDetailsOfSpending = (from x in context.Orders
                                                    where x.EmergencyMaintenance.EMStartDate != null && x.EmergencyMaintenance.EMEndDate != null
                                                    where x.EmergencyMaintenance.Asset.DepartmentLocation.Department.Name == department
                                                    select x).ToList();



                        var getDetailsOfSpending1 = (from x in getDetailsOfSpending
                                                     where x.Date.ToString("yyyy-MM") == date                                                     
                                                     select new { spending = x.OrderItems.Sum(p => p.Amount * p.UnitPrice) }).FirstOrDefault();
                        if (getDetailsOfSpending1 == null)
                        {
                            row.Add("0");
                        }
                        else
                        {
                            row.Add(getDetailsOfSpending1.spending.ToString());
                        }



                    }

                    spendList.Rows.Add(row.ToArray());
                }

                List<string> noteList = new List<string>()
                {
                    "Highest Cost", "Most Number"
                };
                foreach (var notes in noteList)
                {
                    List<string> rows = new List<string>();
                    rows.Add(notes);

                    foreach (var dates in getDistinctDates)
                    {
                        if (notes == "Highest Cost")
                        {

                            var getParts = (from x in context.Parts
                                            select x.Name).ToList();
                            List<decimal> comparison = new List<decimal>();
                            List<string> comparisonName = new List<string>();
                            foreach (var parts in getParts)
                            {
                                var initialQuery = (from x in context.Orders
                                                    where x.EmergencyMaintenance.EMStartDate != null && x.EmergencyMaintenance.EMEndDate != null
                                                    select x).ToList();

                                var getCost = (from x in initialQuery
                                               where x.Date.ToString("yyyy-MM") == dates
                                               select new
                                               {
                                                   cost = x.OrderItems.Where(y => y.Part.Name == parts).Sum(p => p.Amount * p.UnitPrice),
                                                   part = parts
                                               }).FirstOrDefault();

                                comparison.Add(Convert.ToDecimal(getCost.cost));
                                comparisonName.Add(getCost.part);
                            }

                            var getHighest = comparison.Max();

                            int index = comparison.FindIndex(x => x == getHighest);

                            var getPartName = comparisonName[index];

                            rows.Add(getPartName);



                        }

                    }
                    mostUsedList.Rows.Add(rows.ToArray());
                }


            }


        }
    }
}
