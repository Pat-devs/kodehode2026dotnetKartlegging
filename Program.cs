// Collections (objects, lists, arrays and such structures) in C# 
// in js we could
// let todolist = ["task", "anohter task", "osv"]

// in C#
List<string> todolist = new List<string>();

todolist.Add("eat");
todolist.Add("sleep");
todolist.Add("code");

// loops in (forof array):
// forof (let element of array) etc....

// in C#

foreach (var task in todolist)
{
    Console.WriteLine(task);
}

// enkel string variable
//string name = "value"




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

bool running = true;

// II. Await user input (in an infinite loop)

while(running)
{ 

    string choice = Console.ReadLine();

    Console.WriteLine("user chose: " + choice);

    if (choice == "1") 
    {
        Console.WriteLine("user entered one");
    }
    else if (choice == "2")
    {
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