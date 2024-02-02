




Stack<int> stack = new Stack<int>();    
stack.Push(100);
stack.Push(200);
stack.Push(300);


Console.WriteLine($"Элементов в стэке = {stack.Count}");
Console.WriteLine($"Извлек элемент = {stack.Pop()}");



while (stack.Count > 0)
{
    Console.WriteLine(stack.Pop());
}

Console.WriteLine($"Осталось");

// перебор всех элементов

foreach (var item in stack)
{
    Console.WriteLine(item);
}


Queue<string> queue = new Queue<string>();    
queue.Enqueue("Андрей");
queue.Enqueue("Max");
queue.Enqueue("Kat");

while (queue.Count > 0)
{
    Console.WriteLine(queue.Dequeue());
}

Console.WriteLine("Доктор закончил осматривать пациентов");

foreach (var item in queue)
{
    Console.WriteLine(item);
}


Console.ReadKey();