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
    public partial class DesignationUI : Form
    {
        public DesignationUI()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Designation aDesignation=new Designation();
            DesignationManager aDesignationManager=new DesignationManager();
            aDesignation.Code = codeTextBox.Text;
            aDesignation.Title = titleTextBox.Text;
            MessageBox.Show(aDesignationManager.Save(aDesignation));
        }
    }
}
