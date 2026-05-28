// Console based todolist app (CLI-app) Command Line Interface

// I. Show user initial UI menu

// Todolist Menu:
// 1. Add task
// 2. List all tasks
// 3. Delete a task
// 4. Exit

Console.WriteLine("Todolist menu");

Console.WriteLine("1. Add task");
Console.WriteLine("2. List all tasks");
Console.WriteLine("3. Delete a task");
Console.WriteLine("4. Exit");

// II. Await user input
string choice = Console.ReadLine();

Console.WriteLine("user chose: " + choice);