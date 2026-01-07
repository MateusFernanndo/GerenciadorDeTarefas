using GerenciadorDeTarefas.Application.Tarefas.Delete;
using GerenciadorDeTarefas.Application.Tarefas.GetAll;
using GerenciadorDeTarefas.Application.Tarefas.GetById;
using GerenciadorDeTarefas.Application.Tarefas.Register;
using GerenciadorDeTarefas.Application.Tarefas.Update;
using GerenciadorDeTarefas.Communication.Requests;
using GerenciadorDeTarefas.Communication.Responses;
using Microsoft.AspNetCore.Mvc;

namespace GerenciadorDeTarefas.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TarefasController : ControllerBase
{
    [HttpPost] //Registar
    [ProducesResponseType(typeof(ResponseRegisterTarefaJson),StatusCodes.Status201Created)]
    [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status400BadRequest)]
    public IActionResult Register([FromBody] RequestTarefaJson request)
    {
        var response = new RegisterTarefaUseCase().Execute(request);
        return Created(string.Empty, response);
    }

    [HttpGet] // listar 
    [ProducesResponseType(typeof(List<ResponseAllTarefasJson>), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult GetAll()
    {
        {
            var useCase = new GetAllTarefasUseCase();
            var response = useCase.Execute();
            if (response.Tarefas.Any())
            {
                return Ok(response);
            }
            return NoContent();
        }
    }

    [HttpGet]  //listar por Id
    [Route("{id}")]
    [ProducesResponseType(typeof(ResponseTarefasJson), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status400BadRequest)]
    public IActionResult Get(int id)
    {
        var useCase = new GetTarefaByIdUseCase();
        var response = useCase.Execute(id);
        return Ok(response);
    }

    [HttpPut] //atualizar
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status400BadRequest)]
    public IActionResult Uptade([FromRoute] int id, [FromBody] RequestTarefaJson request)
    {
        var useCase = new UptadeTarefaUseCase();
        useCase.Execute(id, request);
        return NoContent();
    }

    [HttpDelete] //deletar
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status400BadRequest)]
    public IActionResult Delete(int id)
    {
        var useCase = new DeleteTarefaByIdUseCase();
        useCase.Execute(id);
        return NoContent();
    }

}
