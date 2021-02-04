using DataLibrary.DataAccess;
using DataLibrary.Model;
using System;
using System.Collections.Generic;

namespace DataLibrary.BusinessLogic
{
    public static class EmployeeProcessor
    {
        public static int CreateEmployee(string firstName, string lastName, DateTime? dob, string email, string address,
            string phoneNumber)
        {
            EmployeeModel data = new EmployeeModel
            {
                FirstName = firstName,
                LastName = lastName,
                DateofBirth = dob,
                EmailAddress = email,
                Address = address,
                PhoneNumber = phoneNumber

            };
            string sql = @"insert into dbo.Employee(FirstName, LastName, DateofBirth, EmailAddress, Address, PhoneNumber )
                           values (@FirstName,@LastName,@DateofBirth,@EmailAddress,@Address,@PhoneNumber);";

            return SqlDataAccess.SaveData(sql, data);
        }

        public static List<EmployeeModel> LoadEmployees() 
        {
            string sql = @" select Id, FirstName, LastName, DateofBirth, EmailAddress, Address, PhoneNumber 
                            from dbo.Employee;";

            return SqlDataAccess.LoadData<EmployeeModel>(sql);
        }  
    }
}
