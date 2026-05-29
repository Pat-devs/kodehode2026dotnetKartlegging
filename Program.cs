// Console based todolist app (CLI-app) Command Line Interface
// data related things

List<string> todolist = new List<string>();
// add a few items:
todolist.Add("eat");
todolist.Add("sleep");
todolist.Add("code");
//

// I. Show user initial UI menu

// Todolist Menu:
// 1. Add task
// 2. List all tasks
// 3. Delete a task
// 4. Exit



bool running = true;

// II. Await user input (in an infinite loop)

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
         Console.WriteLine();
        foreach (var task in todolist)
        {
            Console.WriteLine(task);
        }    
    }
    else if (choice == "3")
    {
    }
    else if (choice == "4")
    {
        // terminate program (in this case no code needed)
        running = false;
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
    string newTodo = Console.ReadLine();
    todolist.Add(newTodo);
}