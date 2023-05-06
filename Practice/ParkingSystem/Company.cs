namespace ParkingSystem
{
    public class Company
    {
        public string CompanyName { get; set; }
        public int EmployeeNumber { get; set; }
        public string FoundationYear { get; set; }

        public Company() { }

        public Company(string companyName, int employeeNumber, string foundationYear)
        {
            CompanyName = companyName;
            EmployeeNumber = employeeNumber;
            FoundationYear = foundationYear;
        }
    }
}