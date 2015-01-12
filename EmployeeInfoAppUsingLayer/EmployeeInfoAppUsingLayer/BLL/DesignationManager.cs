using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeInfoAppUsingLayer.DAL.DAO;
using EmployeeInfoAppUsingLayer.DAL.DBGateway;

namespace EmployeeInfoAppUsingLayer.BLL
{
    class DesignationManager
    {
        private const int MIN_LENGTH_OF_CODE = 3;
        public string Save(Designation aDesignation)
        {
            if (aDesignation.Code.Length>=MIN_LENGTH_OF_CODE)
            {
                DesignationDBGateway aDesignationDbGateway = new DesignationDBGateway();
                Designation designationFound = aDesignationDbGateway.Find(aDesignation.Code);
                if (designationFound==null)
                {
                 aDesignationDbGateway.Save(aDesignation);
                 return "Saved";
                }
                else
                {
                    return "Code Already Exists";
                }          
            }
           else
            {
                return "Code must be "+MIN_LENGTH_OF_CODE+" char";
            }
        }
    }
}
