using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using asibproject.Models;

namespace asibproject.Controllers
{
    [ApiController]
    public class UseersController : ControllerBase
    {

        private readonly ILogger<UseersController> _logger;

        static readonly IUseerRepository repository = new UseerRepository();

        public UseersController(ILogger<UseersController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("api/useers")]
        public IEnumerable<UseerModel> GetAlluseers()
        {
            return repository.GetAll();
        }

        [HttpPost]
        [Route("api/useer")]
        [Consumes("application/json")]
        public UseerModel Postuseer(UseerModel item)
        {
            return repository.Add(item);
        }
        

    }
}
