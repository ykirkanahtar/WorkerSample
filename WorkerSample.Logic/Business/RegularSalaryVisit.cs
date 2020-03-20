using WorkerSample.Logic.Models;

namespace WorkerSample.Logic.Business
{
    public class RegularSalaryVisit : ISalaryVisitor
    {
        private readonly decimal _salary;

        public RegularSalaryVisit(decimal salary)
        {
            _salary = salary;
        }

        public void Visit(Worker baseWorker)
        {
            baseWorker.SetSalary(_salary);
        }
    }
}
