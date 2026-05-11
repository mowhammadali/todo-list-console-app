namespace TodoApp.TodoList;

interface ITodoList
{
    public List<UserTask> todos { get; }

    public void AddTodo(UserTask task);
    public void RemoveTodo(int todoNumber);
    public void RemoveAllTodos();
}

class TodoList : ITodoList
{
    public List<UserTask> todos { get; }

    public void AddTodo(UserTask task)
    {
        todos.Add(task);
    }

    public void RemoveTodo(int todoNumber)
    {
        todos.RemoveAt(todoNumber - 1);
    }

    public void RemoveAllTodos()
    {
        todos.Clear();
    }
}