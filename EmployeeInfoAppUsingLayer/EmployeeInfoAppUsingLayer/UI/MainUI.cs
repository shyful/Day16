using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmployeeInfoAppUsingLayer.DAL.DAO;
using EmployeeInfoAppUsingLayer.UI;

namespace EmployeeInfoAppUsingLayer
{
    public partial class MainUI : Form
    {
        private List<Designation> designationlList;
        public MainUI()
        {
            InitializeComponent();
        }

        private void addEmployeeButton_Click(object sender, EventArgs e)
        {
            EmployeeInfoUI anEmployeeInfoUi = new EmployeeInfoUI(designationlList);
            anEmployeeInfoUi.Show();
        }

        private void designationButton_Click(object sender, EventArgs e)
        {
            DesignationUI aDesignationUi=new DesignationUI();
            aDesignationUi.Show();
        }

        private void editAndFindbutton_Click(object sender, EventArgs e)
        {
            SearchEmployeeUI aSearchEmployeeUi=new SearchEmployeeUI();
            aSearchEmployeeUi.Show();
        }
    }
}
