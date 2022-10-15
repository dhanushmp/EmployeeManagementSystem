using StudentMangement.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.DataAccessLayer
{
    public class EmployeeDataAccessLayer
    {
        public int AddEmployee(Employee employee)
        {
            try
            {
                SqlConnection sqlConnection;
                string connectionString = @"Data Source=MC1JULY168;Initial Catalog=EmployeeDB;User ID=sa;Password=pass@word1";
                sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();
                string insertQuery = "INSERT INTO Employee(Id,Name,Age)VALUES(" + employee.Id + ",'" + employee.Name + "'," + employee.Age + ")";
                SqlCommand insertCommand = new SqlCommand(insertQuery, sqlConnection);
                insertCommand.ExecuteNonQuery();
                Console.WriteLine("Informatiom added from Database");
            }
            catch
            {
                Console.WriteLine("error from AddEmployee");
            }
            return 0;
        }
        public int UpdateEmployee(Employee employee)
        {
            try
            {
                SqlConnection sqlConnection;
                string connectionString = @"Data Source=MC1JULY168;Initial Catalog=EmployeeDB;User ID=sa;Password=pass@word1";
                sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();
                string updatequery = "update dbo.Employee set Name='" + employee.Name + "',Age=" + employee.Age + " where Id=" + employee.Id + "";
                SqlCommand updateCommand = new SqlCommand(updatequery, sqlConnection);
                updateCommand.ExecuteNonQuery();
                Console.WriteLine("Information updated from Database");
            }
            catch
            {
                Console.WriteLine("error update Employee");
            }
            return 0;
        }
        public int DisplayEmployee(Employee employee)
        {
            try
            {
                SqlConnection sqlConnection;
                string connectionString = @"Data Source=MC1JULY168;Initial Catalog=EmployeeDB;User ID=sa;Password=pass@word1";
                sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();
                string Displayquery = "select * from Employee";
                SqlCommand updateCommand = new SqlCommand(Displayquery, sqlConnection);
                updateCommand.ExecuteNonQuery();
                Console.WriteLine("Information Displayed Successfully ");

               
            }
            catch
            {
                Console.WriteLine("error from display employee");
            }
            return 0;
        }
        public int DeleteEmployee(Employee student)
        {
            try
            {
                SqlConnection sqlConnection;
                string connectionString = @"Data Source=MC1JULY168;Initial Catalog=EmployeeDB;User ID=sa;Password=pass@word1";
                sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();
                string Deletequery = "delete from Employee where Id=" + student.Id + " ";
                SqlCommand updateCommand = new SqlCommand(Deletequery, sqlConnection);
                updateCommand.ExecuteNonQuery();
                Console.WriteLine(" Information  Successfully deleted from Database!!!");
            }
            catch(Exception ex)
            {
                Console.WriteLine("error from delete employee");
            }
            return 0;
        }


    }
}
