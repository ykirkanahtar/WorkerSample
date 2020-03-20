using WorkerSample.Logic.Business;

namespace WorkerSample.Logic.Models
{
    public class Worker
    {
        public Worker(string identityNumber, string firstName, string lastName)
        {
            IdentityNumber = identityNumber;
            FirstName = firstName;
            LastName = lastName;
        }

        public string IdentityNumber { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public decimal Salary { get; private set; }

        internal void SetSalary(decimal salary)
        {
            Salary = salary;
        }

        public void Accept(ISalaryVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
