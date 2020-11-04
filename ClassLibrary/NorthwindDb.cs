using System;
using System.Data;
using System.IO;

namespace ClassLibrary
{
    public class NorthwindDb
    {
        public static string GetData()
        {
            string result = "";
            DataSet dataSet = new DataSet();
            using (StringReader reader = new StringReader(Resources.NorthwindXml))
                dataSet.ReadXml(reader);

            DataTable employeeTable = dataSet.Tables["Employees"];

            foreach (DataRow row in employeeTable.Rows)
            {
                string firstName = Convert.ToString(row["FirstName"]);
                string lastName = Convert.ToString(row["LastName"]);
                DateTime birthdate = Convert.ToDateTime(row["Birthdate"]);
                DateTime retirementDate = birthdate.AddYears(65);

                var isRetired = retirementDate < DateTime.Now;
                if (!isRetired)
                    continue;

                result += $"{firstName} {lastName}: {retirementDate}\r\n";
            }

            return result;
        }
    }
}
