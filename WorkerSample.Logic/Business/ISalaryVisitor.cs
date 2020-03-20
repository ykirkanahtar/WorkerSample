using WorkerSample.Logic.Models;

namespace WorkerSample.Logic.Business
{
    public interface ISalaryVisitor
    {
        void Visit(Worker baseWorker);
    }
}
