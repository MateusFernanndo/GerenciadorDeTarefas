using GerenciadorDeTarefas.Communication.Responses;

namespace GerenciadorDeTarefas.Application.Tarefas.GetById;
public class GetTarefaByIdUseCase
{
    public ResponseTarefasJson Execute(int id)
    {
        return new ResponseTarefasJson
        {
            Id = id,
            Name = "Atividade escolar",
            Description = "Fazer dever de casa",
            Priority = Communication.Enums.TarefasPriority.high,
            Status = Communication.Enums.TarefasStatus.pending,
            dueDate = new DateTime(year: 2026, month: 1, day: 1)
        };
    }
}
