
using GerenciadorDeTarefas.Communication.Requests;
using GerenciadorDeTarefas.Communication.Responses;

namespace GerenciadorDeTarefas.Application.Tarefas.Register;

public class RegisterTarefaUseCase
{
    public ResponseRegisterTarefaJson Execute(RequestTarefaJson request)
    {
        return new ResponseRegisterTarefaJson
        {
            Id = request.Id,
            Name = request.Name,
            Description = request.Description
        };
    }
}
