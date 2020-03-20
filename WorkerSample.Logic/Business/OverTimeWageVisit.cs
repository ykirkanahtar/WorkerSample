using WorkerSample.Logic.Models;

namespace WorkerSample.Logic.Business
{
    public class OverTimeWageVisit : ISalaryVisitor
    {
        private readonly decimal _regularSalary;
        private readonly int _overTimeCountPerHour;
        private readonly int _overTimeWagePerHour;

        public OverTimeWageVisit(decimal regularSalary, int overTimeCountPerHour, int overTimeWagePerHour)
        {
            _regularSalary = regularSalary;
            _overTimeCountPerHour = overTimeCountPerHour;
            _overTimeWagePerHour = overTimeWagePerHour;
        }

        public void Visit(Worker baseWorker)
        {
            baseWorker.SetSalary(_regularSalary + _overTimeCountPerHour * _overTimeWagePerHour);
        }
    }
}
