using Flunt.Notifications;
using Todo.Domain.Commands;
using Todo.Domain.Commands.Contracts;
using Todo.Domain.Handlers.Contracts;

namespace Todo.Domain.Handlers
{
    public class TodoHandler
    : Notifiable,
    IHandler<CreateTodoCommand>
    {
        public ICommandResult Handle(CreateTodoCommand command)
        {
            // Fail Fast Validation

            // Gera o TodoItem

            // Salva no banco
            
            // Retorna o resultado

            throw new System.NotImplementedException();
        }
    }
}