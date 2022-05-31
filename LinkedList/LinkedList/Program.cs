LinkedList.LinkedList list = new LinkedList.LinkedList();
Console.WriteLine("LinkedList Operations:\n0.Exit\n2.Add\n3.Display\nEnter your choice:");
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
        default:
            Console.WriteLine("Invalid option.");
            break;
    }
}
