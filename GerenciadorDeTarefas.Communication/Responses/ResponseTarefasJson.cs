using GerenciadorDeTarefas.Communication.Enums;

namespace GerenciadorDeTarefas.Communication.Responses;
public class ResponseTarefasJson
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public DateTime dueDate { get; set; }
    public TarefasPriority Priority { get; set; }
    public TarefasStatus Status { get; set; }
}
