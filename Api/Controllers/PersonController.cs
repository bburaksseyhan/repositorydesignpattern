using Domain;
using Infrastructure.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonController : ControllerBase
    {
        private IUnitOfWork _unitOfWork;
        private readonly ILogger<PersonController> _logger;

        public PersonController(IUnitOfWork unitOfWork, ILogger<PersonController> logger)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Person> Get()
        {
            return _unitOfWork.PersonRepository.All();
        }
    }
}
