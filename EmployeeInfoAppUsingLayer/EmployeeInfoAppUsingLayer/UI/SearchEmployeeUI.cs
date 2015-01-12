using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmployeeInfoAppUsingLayer.BLL;
using EmployeeInfoAppUsingLayer.DAL.DAO;

namespace EmployeeInfoAppUsingLayer.UI
{
    public partial class SearchEmployeeUI : Form
    {
        public SearchEmployeeUI()
        {
            InitializeComponent();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            showListView.Items.Clear();
            string name = searchNameTextBox.Text;
            EmployeeManager anManager=new EmployeeManager();
            List<Employee> employeeList =anManager.ShowEmployeelist(name);
            foreach (Employee employees in employeeList)
            {
                ListViewItem aListViewItem=new ListViewItem();
                aListViewItem.Text = employees.Id.ToString();
                aListViewItem.SubItems.Add(employees.Name);
                aListViewItem.SubItems.Add(employees.Email);
                aListViewItem.SubItems.Add(employees.Address);
                showListView.Items.Add(aListViewItem);
            }
        }
    }
}
