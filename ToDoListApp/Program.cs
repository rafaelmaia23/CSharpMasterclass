using System;

string userOption = "";

List<string> todos = new List<string>();
//List<string> todos = new List<string>()
//{
//    "Comprar melância",
//    "Trocar o relógio do papagaio",
//    "Cheirar as flores",
//    "Correr no mato atrás da capivara"
//};
int NumRescueBoats(int[] people, int limit)
{
    Array.Sort(people);
    Dictionary<int, int> map = new Dictionary<int, int>();
    foreach (var person in people)
    {
        if (map.ContainsKey(person)) map[person]++;
        else map[person] = 1;
    }
    var maxKey = 0;
    var numberOfBoats = 0;
    int sumOfPeopleWeigth = 0;

    while (map.Count > 0)
    {
        maxKey = map.Keys.Max();
        sumOfPeopleWeigth = maxKey;
        map[maxKey]--;
        if (map[maxKey] <= 0) map.Remove(maxKey);
        int tempKey = maxKey + maxKey > limit ? maxKey - 1 : maxKey;
        while (sumOfPeopleWeigth < limit && tempKey > 0)
        {
            if (map.ContainsKey(tempKey))
            {
                if (sumOfPeopleWeigth + tempKey <= limit)
                {
                    sumOfPeopleWeigth += tempKey;
                    map[tempKey]--;
                }
                if (map[tempKey] <= 0) map.Remove(tempKey);
                if (sumOfPeopleWeigth + tempKey > limit) tempKey--;
            }
            else tempKey--;
        }
        numberOfBoats++;
    }
    return numberOfBoats;
}

NumRescueBoats(new int[] { 3,2,3,2,2 }, 5);

//Console.WriteLine("Hello!");

//while (userOption != "E")
//{
//    Console.WriteLine("");
//    Console.WriteLine(@"What do you want do to?
//[S]ee all TODOs
//[A]dd a TODO
//[R]emove a TODO
//[E]xit");
//    Console.WriteLine("");

//    userOption = Console.ReadLine().ToUpper();

//    switch (userOption)
//    {
//        case "S":
//            GetTodos();
//            break;
//        case "A":
//            PostTodo();
//            break;
//        case "R":
//            RemoveTodo();
//            break;
//        case "E":
//            Console.WriteLine("Goodbye");
//            break;
//        default:
//            Console.WriteLine("Incorrect input");
//            break;
//    }
//}

//void GetTodos()
//{
//    Console.WriteLine("");
//    if (todos.Count == 0)
//    {
//        PrintNoTodoInList();
//        return;
//    }
//    Console.WriteLine("TODOs:");
//    for (int i = 0; i < todos.Count; i++)
//    {
//        Console.WriteLine($"{i + 1}. " + todos[i]);
//    }
//}

//void PostTodo()
//{
//    string todo;
//    do
//    {
//        Console.WriteLine("");
//        Console.WriteLine("Enter the TODO description:");
//        todo = Console.ReadLine();
//    }
//    while (!IsTodoValid(todo));

//    todos.Add(todo);
//    Console.WriteLine($"TODO successfully added: " + todo);
//}

//bool IsTodoValid(string todo)
//{
//    if (String.IsNullOrEmpty(todo))
//    {
//        Console.WriteLine("The description cannot be empty.");
//        return false;
//    }
//    else if (todos.Contains(todo))
//    {
//        Console.WriteLine("The description must be unique.");
//        return false;
//    }
//    return true;
//}

//void RemoveTodo()
//{

//    if (todos.Count == 0)
//    {
//        PrintNoTodoInList();
//        return;
//    }

//    int index;
//    do
//    {
//        Console.WriteLine("");
//        Console.WriteLine("Select the index of the TODO you want to remove:");

//        GetTodos();

//        Console.WriteLine("");
//    }
//    while (!TryReadIndex(out index));

//    RemoveTodoAtIndex(index - 1);
//}

//void RemoveTodoAtIndex(int index)
//{
//    var todoRemoved = todos[index];
//    todos.RemoveAt(index);
//    Console.WriteLine($"TODO removed: {todoRemoved}");
//}

//bool TryReadIndex(out int index)
//{
//    var userInput = Console.ReadLine();
//    if (String.IsNullOrEmpty(userInput))
//    {
//        index = 0;
//        Console.WriteLine("Selected index cannot be empty.");
//        return false;
//    }

//    if (int.TryParse(userInput, out index) &&
//            index >= 1 &&
//            index <= todos.Count)
//    {
//        return true;
//    }
//    Console.WriteLine("The given index is not valid.");
//    return false;
//}

//static void PrintNoTodoInList()
//{
//    Console.WriteLine("No TODOs have been added yet.");
//}
