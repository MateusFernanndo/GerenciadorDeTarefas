using GerenciadorDeTarefas.Communication.Enums;

namespace GerenciadorDeTarefas.Communication.Requests;
public class RequestTarefaJson
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public DateTime dueDate { get; set; }
    public TarefasPriority Priority { get; set; }
    public TarefasStatus Status { get; set; }
}
