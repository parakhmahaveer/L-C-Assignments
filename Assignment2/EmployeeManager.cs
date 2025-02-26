using MoodleAssignment2_Functions.DAL;

namespace MoodleAssignment2_Functions
{
    public class EmployeeManager
    {
        public void SaveToDatabase(Employee employee)
        {
            try
            {
                Console.WriteLine("Employee added to database.");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string PrintDetailReportXML(Employee employee)
        {
            try
            {
                return $"<Employee><Id>{employee.Id}</Id><Name>{employee.Name}</Name><Department>{employee.Department}</Department><IsWorking>{employee.Working}</IsWorking></Employee>";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string PrintDetailReportCSV(Employee employee)
        {
            try
            {
                return $"{employee.Id},{employee.Name},{employee.Department},{employee.Working}";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void TerminateEmployee(Employee employee)
        {
            try
            {
                Console.WriteLine("Employee has been kicked out.");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool IsWorking(Employee employee)
        {
            try
            {
                return employee.Working;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
