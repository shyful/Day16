using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeInfoAppUsingLayer.DAL.DAO;
using EmployeeInfoAppUsingLayer.DAL.DBGateway;
using EmployeeInfoAppUsingLayer.UI;

namespace EmployeeInfoAppUsingLayer.BLL
{
    class EmployeeManager
    {
        //List<Designation> designationlList = new List<Designation>();
        private EmployeeInfoDBGateway anEmployeeInfoDbGateway;
        Designation aDesignation=new Designation();
        public string Save(Employee anEmployee)
        {
           anEmployeeInfoDbGateway=new EmployeeInfoDBGateway();
            Employee employee = anEmployeeInfoDbGateway.FindMail(anEmployee.Email);
            if (employee==null)
            {
                anEmployeeInfoDbGateway.Save(anEmployee);
                 return "Saved";  
            }
            else
            {
            return "Duplicate Email Has Found";
            }
        }

        public List<Designation> GetDesognationList()
        {
            anEmployeeInfoDbGateway = new EmployeeInfoDBGateway();
           return anEmployeeInfoDbGateway.GetDesognationList();
        }


        public List<Employee> ShowEmployeelist(string name)
        {
           EmployeeInfoDBGateway anEmployeeInfoDbGateway=new EmployeeInfoDBGateway();
            return anEmployeeInfoDbGateway.ShowEmployeeList(name);
        }

        
    }
}
