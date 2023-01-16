using App_1.Models;

namespace App_1.Services
{
    public class TodoService
    {


        public List<Todo> AllTodos()
        {
            var todos = new List<Todo>();

            var todo1 = new Todo
            {
                Id = 1,
                Title = "books",
                Description = "books for school",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(5),
                Status = TodoStatus.New

            };
            todos.Add(todo1);


            var todo2 = new Todo
            {
                Id = 2,
                Title = "vegetables",
                Description = "vegies for home",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(2),
                Status = TodoStatus.New

            };
            todos.Add(todo2);

            var todo3 = new Todo
            {
                Id = 3,
                Title = "books",
                Description = "books for school",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(5),
                Status = TodoStatus.New

            };
            todos.Add(todo3);

            return todos;

        }
    }
}
