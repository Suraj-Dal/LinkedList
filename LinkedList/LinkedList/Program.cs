LinkedList.LinkedList list = new LinkedList.LinkedList();
Console.WriteLine("\nLinkedList Operations:\n0.Exit\n1.Add\n2.Display\n3.Append\nEnter your choice:");
int choice = Convert.ToInt32(Console.ReadLine());
while (choice != 0 )
{
    switch (choice)
    {
        case 1:
            Console.WriteLine("Enter data to add.");
            int data = Convert.ToInt32(Console.ReadLine());
            list.Add(data);
            break;
        case 2:
            list.Display();
            break;
        case 3:
            Console.WriteLine("Enter data to append.");
            int value = Convert.ToInt32(Console.ReadLine());
            list.Append(value);
            break;
        default:
            Console.WriteLine("Invalid option.");
            break;
    }
    Console.WriteLine("\nLinkedList Operations:\n0.Exit\n1.Add\n2.Display\n3.Append\nEnter your choice:");
    choice = Convert.ToInt32(Console.ReadLine());
}
