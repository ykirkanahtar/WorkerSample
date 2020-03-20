using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WorkerSample.Logic.Business;
using WorkerSample.Logic.Models;

namespace WorkerSample.WebApi.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class WorkerController : ControllerBase
    {
        private IList<Worker> workers = new List<Worker>();
        private readonly ILogger<WorkerController> _logger;

        public WorkerController(ILogger<WorkerController> logger)
        {
            _logger = logger;
            SetDummyDatas();
        }

        private void SetDummyDatas()
        {
            var workerType1 = new Worker("123", "Ali", "Veli");
            var workerType2 = new Worker("345", "Elif", "Melis");
            var workerType3 = new Worker("678", "Osman", "Nuri");

            workerType1.Accept(new RegularSalaryVisit(5000));
            workerType2.Accept(new DailyWageVisit(20, 500));
            workerType3.Accept(new OverTimeWageVisit(2500, 100, 20));

            workers.Add(workerType1);
            workers.Add(workerType2);
            workers.Add(workerType2);
        }

        [HttpGet]
        public IList<Worker> GetAllWorkers()
        {
            return workers;
        }
    }
}
