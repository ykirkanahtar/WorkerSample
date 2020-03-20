using WorkerSample.Logic.Models;

namespace WorkerSample.Logic.Business
{
    public class DailyWageVisit : ISalaryVisitor
    {
        private readonly int _workCount;
        private readonly decimal _dailyWage;

        public DailyWageVisit(int workCount, decimal dailyWage)
        {
            _workCount = workCount;
            _dailyWage = dailyWage;
        }

        public void Visit(Worker baseWorker)
        {
            baseWorker.SetSalary(_workCount * _dailyWage);
        }
    }
}
