# Todolist backend

Program.cs (main program):
 - Handles UI, and uses the TodoService

TodoService:
 - Handles business logic of todo
 - temporary (also works a in memory Database)

TodoItem:
 - model for each item


## Future plan:

Create a TodoRepository class
TodoRepository
 - Contains methods (functions) to read and store data.

## Future plan (for UI):

 - Remove everything from Program.cs excpt call to services:
   - TodoListService
   - Other services
   - Uis
   - and so on.