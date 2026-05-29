class TodoItem // a class is a blueprint
{
    // class body goes here (code)
    public int Id { get; set; } // this will come from a database
    public string TaskName { get; set; } // user input
    public bool isDone { get; set; } // task done or not yet
}