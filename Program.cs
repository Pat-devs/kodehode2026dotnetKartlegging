// Console based todolist app (CLI-app) Command Line Interface

// Separation of Concerns
// create an instance of the TodoService
TodoService todoService = new TodoService();





bool running = true; // UI 

while(running)
{ 
    ShowMenu(); // show the menu
    
    string choice = Console.ReadLine();

    Console.WriteLine("user chose: " + choice);

    if (choice == "1") // 1. Add a task
    {
        AddTask();    
    }
    else if (choice == "2") // 2. List all tasks
    {
        ListAllTasks();
    }
    else if (choice == "3") // 3. Delete a task
    {
        DeleteTask();
    }
    else if (choice == "4") // 4. Exit 
    {
        ExitTodoApp();
    }
}

void ShowMenu()
{
    Console.WriteLine();
    Console.WriteLine("Todolist menu");

    Console.WriteLine("1. Add task");
    Console.WriteLine("2. List all tasks");
    Console.WriteLine("3. Delete a task");
    Console.WriteLine("4. Exit");
    Console.WriteLine("Enter an option: ");
}

void AddTask()
{
    Console.WriteLine("Enter what you want to do: ");
    // Create a new instance of TodoItem
    //TodoItem newTodo = new TodoItem();
    // put data in the new todo
    // invoke AddTodo method from todoService instance:
    todoService.AddTodo(Console.ReadLine());


    // todolist.Add(newTodo);
}

void ListAllTasks()
{
    Console.WriteLine();
    foreach (TodoItem task in todolist)
    {
        Console.WriteLine(task.TaskName);
    } 
}

void DeleteTask()
{
    
}

void ExitTodoApp()
{
    running = false;
}

