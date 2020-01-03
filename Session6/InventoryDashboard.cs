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
            using (var context = new Session6Entities())
            {
                var getDepartment = (from x in context.Orders
                                     where x.EmergencyMaintenance.EMStartDate != null && x.EmergencyMaintenance.EMEndDate != null
                                     select x.EmergencyMaintenance.Asset.DepartmentLocation.Department.Name).ToList();


                var getDepartmentSpendingGrouping = (from x in context.Orders
                                                     where x.EmergencyMaintenance.EMEndDate != null
                                                     orderby x.Date descending
                                                     select new { intDate = x.Date }).ToList();

                var getDistinctDates = (from x in getDepartmentSpendingGrouping
                                        select new { date = x.intDate.ToString("yyyy-MM") }).ToList().Select(x => x.date).Distinct().Take(10);

                foreach (var date in getDistinctDates)
                {
                    spendList.Columns.Add(date, date);
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
                                                    select x).ToList();

                        var dID = (from x in context.Departments
                                   where x.Name.Equals(department)
                                   select x.ID).First();

                        var getDetailsOfSpending1 = (from x in getDetailsOfSpending
                                                     where x.Date.ToString("yyyy-MM") == date 
                                                     where x.EmergencyMaintenance.Asset.DepartmentLocation.DepartmentID == dID
                                                     select new { spending = x.OrderItems.Sum(p => p.Amount * p.UnitPrice)}).FirstOrDefault();
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

                /* foreach (var item1 in getDistinctDates.Select(x => x.date).Distinct().Take(10))
                 {
                     spendList.Columns.Add(item1, item1);

                     foreach (var departments in getDepartment.Select(x => x).Distinct())
                     {

                         var getDetailsOfSpending = (from x in context.Orders
                                                     select x).ToList();

                         var dID = (from x in context.Departments
                                    where x.Name.Equals(departments)
                                    select x.ID).First();

                         var getDetailsOfSpending1 = (from x in getDetailsOfSpending
                                                      where x.Date.ToString("yyyy-MM") == item1 && x.EmergencyMaintenance.EMStartDate != null && x.EmergencyMaintenance.EMEndDate != null
                                                      where x.EmergencyMaintenance.Asset.DepartmentLocation.DepartmentID == dID
                                                      select new { spending = x.OrderItems.Sum(p => p.Amount * p.UnitPrice), deptName = departments });


                         List<string> vs = new List<string>();

                         *//*foreach (var departmentCheck in getDetailsOfSpending1.Select(x => x.deptName).Distinct())
                         {
                             vs.Add(departmentCheck);

                             foreach (var item in getDetailsOfSpending1.Where(x => x.deptName == departmentCheck).Select(x => x.spending))
                             {
                                 vs.Add(item.ToString());
                                 spendList.Rows.Add(vs.ToArray());
                             }
                         }*//*



                     }*/
            }


        }
    }
}
