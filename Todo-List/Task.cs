namespace TodoApp.Task;

interface IUserTask
{
    public string Title { get; }
    public string Description { get; }
    public DateTime Date { get; }
    public bool IsDone { get; }
}

class UserTask : IUserTask
{
    public UserTask(string title, string description, DateTime date, bool isDone)
    {
        Title = title;
        Description = description;
        Date = date;
        IsDone = isDone;
    }

    public string Title { get; private set; }
    public string Description { get; private set; }
    public DateTime Date { get; private set; }
    public bool IsDone { get; private set; }
}