using System.Net;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Interfaces;
using WebAPI.Models;
namespace WebAPI.Controllers

{
    [ApiController]
    [Route("api/[controller]")]
    public class TaskController : ControllerBase
    {
        private readonly ILogger<TaskController> _logger;
        private readonly IService _service;

        public TaskController(ILogger<TaskController> logger, IService service)
        {
            _logger = logger;
            _service = service;

        }
        [HttpGet]
        public IEnumerable<TaskModel> getAll()
        {
            return _service.getAll();
        }
        [HttpPost]
        public HttpStatusCode Create(TaskModel task)
        {
            _service.Create(task);
            return HttpStatusCode.OK;
        }
        [HttpPut]
        public HttpStatusCode Edit(TaskModel task)
        {
            _service.Edit(task);
            return HttpStatusCode.OK;
        }
        [HttpGet("id")]
        public TaskModel GetById(int id)
        {
            return _service.GetById(id);
        }
        [HttpDelete]
        public HttpStatusCode Delete(int id)
        {
            _service.Delete(id);
            return HttpStatusCode.OK;
        }
        [HttpPost("task")]
        public HttpStatusCode CreateMutli(List<TaskModel> task)
        {
            _service.CreateMulti(task);
            return HttpStatusCode.OK;
        }
        [HttpDelete("idDeleteMulti")]
        public HttpStatusCode DeleteMulti(List<int> idDeleteMulti)
        {
            _service.DeleteMulti(idDeleteMulti);
            return HttpStatusCode.OK;
        }
    }
}