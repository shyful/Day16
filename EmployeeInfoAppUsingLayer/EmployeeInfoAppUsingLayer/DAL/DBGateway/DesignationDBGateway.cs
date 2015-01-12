using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeInfoAppUsingLayer.DAL.DAO;

namespace EmployeeInfoAppUsingLayer.DAL.DBGateway
{
    class DesignationDBGateway
    {
        string ConnectionString = @"Data Source = SHIFU; Database=EmployeeInfoDB; Integrated Security = true";
        private SqlConnection connection;
        private SqlCommand command;
        public DesignationDBGateway()
        {
            connection = new SqlConnection(ConnectionString);
        }
        public void Save(Designation aDesignation)
        {
            
            connection.Open();
            string sqlQuery = "insert into t_Designation values('" + aDesignation.Code + "', '" + aDesignation.Title + "')";
            command = new SqlCommand(sqlQuery, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public Designation Find(string code)
        {
            connection.Open();
            string sqlQuery = "SELECT * FROM t_Designation WHERE Code='"+code+"'";
            command = new SqlCommand(sqlQuery, connection);
            SqlDataReader aSqlDataReader=command.ExecuteReader();
            if (aSqlDataReader.HasRows)
            {
                Designation aDesignation=new Designation();
                aSqlDataReader.Read();
                aDesignation.Id = Convert.ToInt32(aSqlDataReader["ID"]);
                aDesignation.Code = aSqlDataReader["Code"].ToString();
                aDesignation.Title = aSqlDataReader["Title"].ToString();
                aSqlDataReader.Close();
                connection.Close();
                return aDesignation;
            }
            else
            {
             
            connection.Close();
            return null;
            }
           

        }
    }
}
