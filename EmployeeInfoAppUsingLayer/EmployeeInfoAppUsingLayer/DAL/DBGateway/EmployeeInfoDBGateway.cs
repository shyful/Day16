using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmployeeInfoAppUsingLayer.BLL;
using EmployeeInfoAppUsingLayer.DAL.DAO;
using EmployeeInfoAppUsingLayer.UI;

namespace EmployeeInfoAppUsingLayer.DAL.DBGateway
{
    class EmployeeInfoDBGateway
    {
        private List<Employee> employees;
        string ConnectionString = @"Data Source = SHIFU; Database=EmployeeInfoDB; Integrated Security = true";
        private SqlConnection connection;
        private SqlCommand command;
        ListViewItem lvi = new ListViewItem();
        public EmployeeInfoDBGateway()
        {
            connection = new SqlConnection(ConnectionString);
        }
        public void Save(Employee anEmployee)
        {
            connection.Open();
            string sqlQuery = "INSERT INTO t_Employee VALUES('" + anEmployee.Name + "', '" + anEmployee.Email + "', '" + anEmployee.Address + "', '" + anEmployee.DesignationId + "')";
            command = new SqlCommand(sqlQuery, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public List<Designation> GetDesognationList()
        {
            List<Designation> designationlList = new List<Designation>();
            connection.Open();
            string sqlQuery = "SELECT * FROM t_Designation";
            SqlCommand command = new SqlCommand(sqlQuery, connection);
            SqlDataReader aReader = command.ExecuteReader();

            while (aReader.Read())
            {
                Designation aDesignation = new Designation();
                aDesignation.Id = (int)aReader["ID"];
                aDesignation.Code = aReader["Code"].ToString();
                //aDesignation.Title = aReader["Title"].ToString();
                designationlList.Add(aDesignation);
            }
            aReader.Close();
            connection.Close();
            return designationlList;
            //EmployeeManager anEmployeeManager = new EmployeeManager();

        }

        public List<Employee> ShowEmployeeList(string name)
        {
            employees=new List<Employee>();
            connection.Open();
            string sqlQuery = "";
            if (String.IsNullOrEmpty(name))
            {

                sqlQuery = "SELECT emp.ID,emp.Name,emp.Email,dgt.Code FROM t_Designation dgt JOIN t_Employee emp ON emp.ID=dgt.ID";
            }
            else
            {
                sqlQuery = "SELECT emp.ID,emp.Name,emp.Email,dgt.Code FROM t_Employee emp JOIN t_Designation dgt  ON emp.Name='"+name+"' AND dgt.ID=emp.ID;";
            }
            
            SqlCommand command = new SqlCommand(sqlQuery, connection);
            SqlDataReader aReader = command.ExecuteReader();
         
            while (aReader.Read())
            {
               
                Employee anEmployee=new Employee();
                anEmployee.Id = (int)aReader["ID"];
                 anEmployee.Name = aReader["Name"].ToString();
                anEmployee.Email = aReader["Email"].ToString();
                anEmployee.Address = aReader["Code"].ToString();
               
                employees.Add(anEmployee);
               
            }
            //aReader.Close();
            //connection.Close();
            return employees;
        }

        public Employee FindMail(string email)
        {
            string query = "SELECT * FROM t_Employee WHERE Email = '" + email + "'";
           connection.Open();
           SqlCommand command = new SqlCommand(query, connection);

            SqlDataReader aReader = command.ExecuteReader();

            Employee anEmployee;

            if (aReader.HasRows)
            {
                anEmployee = new Employee();
                aReader.Read();
              anEmployee.Id = (int)aReader["ID"];
                 anEmployee.Name = aReader["Name"].ToString();
                anEmployee.Email = aReader["Email"].ToString();
                anEmployee.Address = aReader["Address"].ToString();
                anEmployee.DesignationId=(int)aReader["Dstn_Id"];
                aReader.Close();
                connection.Close();
                return anEmployee;
            }
            else
            {
                aReader.Close();
                connection.Close();
                return null;
            }
            
           
            }        
        }
    }

