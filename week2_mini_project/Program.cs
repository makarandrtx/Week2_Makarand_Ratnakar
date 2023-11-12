using System.Runtime.CompilerServices;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hola amigo! Welcome to Tasker!");
        List<string> taskList = new List<string>();
        string? choice = "";


        while(choice != "e") {

            Console.WriteLine("Enter 1 to add a task to the list");
            Console.WriteLine("Enter 2 to see all tasks in the list");
            Console.WriteLine("Enter 3 to update existing task on the list");
            Console.WriteLine("Enter 4 to delete a task from the list");
            Console.WriteLine("Enter e to exit");
            Console.WriteLine("");

            choice = Console.ReadLine();

            if (choice == "1") {
                Console.Write("Enter task: ");
                string? task = Console.ReadLine() ?? "system entry occured due to empty string";
                taskList.Add(task);
                Console.WriteLine("Task added successfully!");
                Console.WriteLine("");
            }
            else if(choice == "2") {
                Console.WriteLine("Tasks to be done: ");
                for(int i = 0; i < taskList.Count; i++) {
                    Console.WriteLine($"{i + 1}: {taskList[i]}");
                }
                Console.WriteLine("");
            }
            else if (choice == "3") {
                Console.Write("Enter task number to be updated: ");
                int taskNumber = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter updated task: ");
                string? updatedTask = Console.ReadLine();
                taskList[taskNumber - 1] = updatedTask ?? "system entry occured due to empty string";
                Console.WriteLine("Task updated successfully!");
                Console.WriteLine("");
            }
            else if (choice == "4") {
                Console.Write("Enter task number to be deleted: ");
                int taskNumber = Convert.ToInt32(Console.ReadLine());
                taskList.RemoveAt(taskNumber - 1);
                Console.WriteLine("Task removed successfully!");
                Console.WriteLine("");
            }
        }
    }
}