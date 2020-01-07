using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

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

            List<string> languages = new List<string>()
            {
                "English", "Chinese", "Malay"
            };

            languageBoc.Items.AddRange(languages.ToArray());

            languageBoc.SelectedItem = "English";
        }

        private void GridRefresh()
        {
            spendList.ColumnCount = 1;
            spendList.Columns[0].Name = "Department / Month";

            mostUsedList.ColumnCount = 1;
            mostUsedList.Columns[0].Name = "Notes / Month";

            costlyAssetList.ColumnCount = 1;
            costlyAssetList.Columns[0].Name = "Asset Name / Month";

            spendList.Rows.Clear();
            mostUsedList.Rows.Clear();
            costlyAssetList.Rows.Clear();

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

                #region 1st DGV Loading
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
                                                     select x.OrderItems.Sum(p => p.Amount * p.UnitPrice)).Sum().Value.ToString("0");

                        row.Add(getDetailsOfSpending1);




                    }

                    spendList.Rows.Add(row.ToArray());
                }
                #endregion

                #region PieChart Load
                pieChart.Series["s1"].Points.Clear();


                var getSpendingsOfDepartment = (from x in context.Orders
                                                where x.EmergencyMaintenance.EMStartDate != null && x.EmergencyMaintenance.EMEndDate != null
                                                group x by x.EmergencyMaintenance.Asset.DepartmentLocation.Department.Name into q
                                                select new { spendings = q.Sum(y => y.OrderItems.Sum(z => z.UnitPrice * z.Amount)), DeptName = q.Key });
                foreach (var r in getSpendingsOfDepartment)
                {
                    var index = pieChart.Series["s1"].Points.AddY(r.spendings);
                    pieChart.Series["s1"].Points[index].Label = r.DeptName;
                }
                #endregion

                #region Bar graph load

                barChart.Series.Clear();

                var initialQuery1 = (from x in context.Orders
                                     where x.EmergencyMaintenance.EMStartDate != null && x.EmergencyMaintenance.EMEndDate != null
                                     select x).ToList();
                foreach (var departments in getDepartment.Select(x => x).Distinct())
                {
                    barChart.Series.Add(new Series(departments));
                    barChart.ChartAreas["ChartArea1"].AxisX.LabelStyle.Interval = 1;
                    foreach (var dates in getDistinctDates)
                    {
                        var getPoints = (from x in initialQuery1
                                         where x.Date.ToString("yyyy-MM") == dates && x.EmergencyMaintenance.Asset.DepartmentLocation.Department.Name == departments
                                         select x.OrderItems.Sum(z => z.UnitPrice * z.Amount).Value).Sum();


                        if (getPoints == 0)
                        {
                            barChart.Series[departments].Points.AddXY(dates, 0);

                        }
                        else
                        {
                            barChart.Series[departments].Points.AddXY(dates, getPoints);
                        }



                    }
                }


                #endregion


                #region 2nd DGV Loading
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
                        var getParts = (from x in context.Parts
                                        select x.Name).ToList();

                        if (notes == "Highest Cost")
                        {


                            List<decimal> comparison = new List<decimal>();
                            List<string> comparisonName = new List<string>();
                            foreach (var parts in getParts)
                            {
                                var initialQuery = (from x in context.Orders
                                                    where x.EmergencyMaintenance.EMStartDate != null && x.EmergencyMaintenance.EMEndDate != null
                                                    select x).ToList();

                                var getCost = (from x in initialQuery
                                               where x.Date.ToString("yyyy-MM") == dates
                                               select x.OrderItems.Where(y => y.Part.Name == parts).Sum(p => p.Amount * p.UnitPrice)).Sum();

                                comparison.Add(Convert.ToDecimal(getCost));
                                comparisonName.Add(parts);
                            }

                            var getHighest = comparison.Max();

                            int index = comparison.FindIndex(x => x == getHighest);

                            var getPartName = comparisonName[index];

                            rows.Add(getPartName);



                        }

                        else
                        {
                            List<decimal> NumberOfTransaction = new List<decimal>();
                            List<string> comparisonName = new List<string>();
                            foreach (var parts in getParts)
                            {
                                var initialQuery = (from x in context.Orders
                                                    where x.EmergencyMaintenance.EMStartDate != null && x.EmergencyMaintenance.EMEndDate != null
                                                    select x).ToList();

                                var getCount = (from x in initialQuery
                                                where x.Date.ToString("yyyy-MM") == dates
                                                where x.TransactionTypeID == 3
                                                select x.OrderItems.Where(y => y.Part.Name == parts).Sum(y => y.Amount)).Sum();

                                NumberOfTransaction.Add(getCount);
                                comparisonName.Add(parts);

                            }

                            var getHighest = NumberOfTransaction.Max();

                            int index = NumberOfTransaction.FindIndex(x => x == getHighest);

                            var getPartName = comparisonName[index];

                            rows.Add(getPartName);
                        }

                    }
                    mostUsedList.Rows.Add(rows.ToArray());
                }

                #endregion

                #region 3rd DGV Loading

                List<string> main = new List<string>()
                {
                    "Asset", "Department"
                };

                foreach (var label in main)
                {
                    List<string> row = new List<string>();
                    row.Add(label);

                    foreach (var dates in getDistinctDates)
                    {
                        if (label == "Asset")
                        {
                            List<string> Assets = new List<string>();
                            List<decimal> CostTotal = new List<decimal>();

                            var getAsset = (from x in context.Assets
                                            select x.AssetName);

                            foreach (var Asset in getAsset)
                            {
                                var initialQuery = (from x in context.Orders
                                                    where x.EmergencyMaintenance.EMStartDate != null && x.EmergencyMaintenance.EMEndDate != null
                                                    select x).ToList();

                                var getCostly = (from x in initialQuery
                                                 where x.Date.ToString("yyyy-MM") == dates && x.EmergencyMaintenance.Asset.AssetName == Asset
                                                 select x.OrderItems.Sum(y => y.Amount * y.UnitPrice)).Sum().Value;

                                Assets.Add(Asset);
                                CostTotal.Add(getCostly);

                            }

                            var getHighest = CostTotal.Max();
                            int index = CostTotal.FindIndex(x => x == getHighest);
                            var getAssetName = Assets[index];
                            row.Add(getAssetName);



                        }

                        else
                        {
                            List<string> Department = new List<string>();

                            List<decimal> CostTotal = new List<decimal>();

                            var getAsset = (from x in context.Assets
                                            select x.AssetName);

                            foreach (var Asset in getAsset)
                            {
                                var initialQuery = (from x in context.Orders
                                                    where x.EmergencyMaintenance.EMStartDate != null && x.EmergencyMaintenance.EMEndDate != null
                                                    select x).ToList();

                                var getCostly = (from x in initialQuery
                                                 where x.Date.ToString("yyyy-MM") == dates && x.EmergencyMaintenance.Asset.AssetName == Asset
                                                 select x.OrderItems.Sum(y => y.Amount * y.UnitPrice)).Sum().Value;

                                var getDepartmentOfAsset = (from x in initialQuery
                                                            where x.Date.ToString("yyyy-MM") == dates && x.EmergencyMaintenance.Asset.AssetName == Asset
                                                            select x.EmergencyMaintenance.Asset.DepartmentLocation.Department.Name).FirstOrDefault();

                                Department.Add(getDepartmentOfAsset);

                                CostTotal.Add(getCostly);

                            }

                            var getHighest = CostTotal.Max();
                            int index = CostTotal.FindIndex(x => x == getHighest);
                            var getDepartmentName = Department[index];
                            row.Add(getDepartmentName);
                        }

                    }
                    costlyAssetList.Rows.Add(row.ToArray());

                }

                #endregion

                #region Color DGV 1

                foreach (var item in spendList.Columns)
                {

                }

                #endregion
            }




        }

        private void inventCBtn_Click(object sender, EventArgs e)
        {
            (new InventoryControl()).ShowDialog();
            GridRefresh();
        }

        private void languageBoc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
