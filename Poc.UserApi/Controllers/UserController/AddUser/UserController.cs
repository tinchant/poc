using Microsoft.AspNetCore.Mvc;
using Poc.UserDomain.AddUserCommandAggregation;

namespace Poc.UserApi.Controllers.UserController
{
    public partial class UserController : IAddUserOutputPort
    {
        [HttpPost]
        public async Task<IActionResult> AddUser([FromServices]AddUserCommandUseCase useCase, [FromBody]AddUserDto dto)
        {
            useCase.SetOutputPort(this);
            await useCase.Exec(dto);
            return Result;
        }

        public void OnError(Exception exception)
        {
            Result = base.StatusCode(500, exception);
        }

        public void OnFailure(string message)
        {
            Result = BadRequest(message);
        }

        public void OnSuccess()
        {
            Result = Ok();
        }
    }
}
