namespace TodoApp.ManageTodoList;

enum UserOptions
{
    Show = 1,
    Add = 2,
    Remove = 3,
    RemoveAll = 4,
}

static class ManageTodos
{
    static public void ShowOptions()
    {
        Console.WriteLine("Please choose your option:");
        Console.Write("1.Show todo list  2.Add new todo");
        Console.WriteLine();
        Console.Write("3.Remove a todo  4.Remove all todos");
        Console.WriteLine();
        Console.Write("Enter option: ");

        string option = Console.ReadLine();
        CheckOptionInput(option);
    }

    static private void CheckOptionInput(string option)
    {
        if (int.TryParse(option, out int optionInt))
        {
            switch (optionInt)
            {
                case (int)UserOptions.Show:
                    TodoList.ShowTodos();
                    ShowOptions();
                    break;
                case (int)UserOptions.Add:
                    TodoList.AddTodo(CreateTodo());
                    ShowOptions();
                    break;
                case (int)UserOptions.Remove:
                    Console.WriteLine("C");
                    break;
                case (int)UserOptions.RemoveAll:
                    Console.WriteLine("D");
                    break;
                default:
                    ReinvokeShowOptions("***Invalid option***");
                    break;
            }
        }
        else
        {
            ReinvokeShowOptions("***Invalid option***");
        }
    }

    static private void ReinvokeShowOptions(string message)
    {
        Console.WriteLine();
        Console.WriteLine(message);
        Console.WriteLine();
        ShowOptions();
    }

    static private UserTask CreateTodo()
    {
        Console.Write("Enter your title: ");
        string title = Console.ReadLine();

        Console.WriteLine();

        Console.Write("Enter your description: ");
        string description = Console.ReadLine();

        Console.WriteLine();

        Guid id = Guid.NewGuid();

        UserTask task = new UserTask(id, title, description, DateTime.Now, false);

        return task;
    }
}