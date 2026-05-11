namespace TodoApp.ManageTodoList;

enum UserOptions
{
    A = 1,
    B = 2,
    C = 3,
    D = 4,
}

class ManageTodos
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
                case (int)UserOptions.A:
                    Console.WriteLine("A");
                    break;
                case (int)UserOptions.B:
                    Console.WriteLine("B");
                    break;
                case (int)UserOptions.C:
                    Console.WriteLine("C");
                    break;
                case (int)UserOptions.D:
                    Console.WriteLine("D");
                    break;
                default:
                    ReinvokeShowOptions("Invalid option");
                    break;
            }
        }
        else
        {
            ReinvokeShowOptions("Invalid option");
        }
    }

    static private void ReinvokeShowOptions(string message)
    {
        Console.WriteLine(message);
        ShowOptions();
    }
}