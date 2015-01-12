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
using EmployeeInfoAppUsingLayer.DAL.DBGateway;

namespace EmployeeInfoAppUsingLayer.UI
{
    public partial class EmployeeInfoUI : Form
    {
        //private List<Designation> designationlList;
        //private EmployeeManager anEmployeeManager;
        //private Designation aDesignation;
        public EmployeeInfoUI(List<Designation> designations)
        {
            InitializeComponent();
            //designationComboBox.DisplayMember = "Code";
            //designationComboBox.ValueMember = "Id";
            //designationlList = designations;
        }

        private void employeeInfoSaveButton_Click(object sender, EventArgs e)
        {
            Employee anEmployee = new Employee();
            anEmployee.Name = nameTextBox.Text;
            anEmployee.Email = emailTextBox.Text;
            anEmployee.Address = addressTextBox.Text;
            //aDesignation = new Designation();
            //anEmployee.DesignationId = aDesignation.Id;
            //Designation anDesignationComboBox = (Designation)designationComboBox.SelectedItem;
            anEmployee.DesignationId = (int)designationComboBox.SelectedValue;
            EmployeeManager anEmployeeManager=new EmployeeManager();
            anEmployeeManager = new EmployeeManager();
            MessageBox.Show(anEmployeeManager.Save(anEmployee));
        }

        private void EmployeeInfoUI_Load(object sender, EventArgs e)
        {
         //aDesignation = new Designation();
         //   designationComboBox.Items.Clear();
         //   anEmployeeManager.GetDesognationList();
            //foreach (Designation aDesignations in designationlList)
            //{
            //    designationComboBox.Items.Add(aDesignation);
            //}
            EmployeeManager anEmployeeManager=new EmployeeManager();
            designationComboBox.DisplayMember = "Code";
            designationComboBox.ValueMember = "Id";
            designationComboBox.DataSource = null;
            designationComboBox.DataSource = anEmployeeManager.GetDesognationList();
            ////}

        }

        }
    }

