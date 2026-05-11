namespace TodoApp.List;

static class TodoList
{
    static private List<UserTask> todos { get; } = new List<UserTask>();

    static public void ShowTodos()
    {
        if (todos.Count == 0)
        {
            Console.WriteLine("No tasks to show");
        }
        else
        {
            foreach (var task in todos)
            {
                Console.WriteLine(task);
            }
        }
    }

    static public void AddTodo(UserTask task)
    {
        todos.Add(task);
    }

    static public void RemoveTodo(int todoNumber)
    {
        todos.RemoveAt(todoNumber - 1);
    }

    static public void RemoveAllTodos()
    {
        todos.Clear();
    }
}