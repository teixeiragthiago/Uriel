using MediatR;
using Microsoft.AspNetCore.Mvc;
using Uriel.Domain.Customer.Commands.Requests;
using Uriel.Domain.Customer.Handlers;
using Uriel.Domain.Customer.Handlers.FindById;

namespace Uriel.Api.Controllers
{
    [ApiController]
    [Route("api/customers")]
    public class CustomerController : ControllerBase
    {
        private readonly IMediator _mediatr;

        public CustomerController(IMediator mediator)
        {
            _mediatr = mediator;
        }

        [HttpPost]
        public IActionResult Post(CreateCustomerRequest command)
        {
            var response = _mediatr.Send(command);

            return Ok(response);
        }

        [HttpGet("findbyid")]
        public IActionResult FindById(FindCustomerByIdRequest command)
        {
            var result = _mediatr.Send(command);

            return Ok(result.Result);
        }

    }
}
