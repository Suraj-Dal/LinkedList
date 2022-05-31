LinkedList.LinkedList list = new LinkedList.LinkedList();
Console.WriteLine("\nLinkedList Operations:\n0.Exit\n1.Add\n2.Display\n3.Append\n4.Insert at position\n5.Delete First Node\n6.Delete Last Node\nEnter your choice:");
int choice = Convert.ToInt32(Console.ReadLine());
while (choice != 0 )
{
    switch (choice)
    {
        case 1:
            Console.WriteLine("How many elements you want to add:");
            int no = Convert.ToInt32(Console.ReadLine());
            while (no != 0)
            {
                Console.WriteLine("Enter data to add.");
                int data = Convert.ToInt32(Console.ReadLine());
                list.Add(data);
                no--;
            }
            break;
        case 2:
            list.Display();
            break;
        case 3:
            Console.WriteLine("Enter data to append.");
            int value = Convert.ToInt32(Console.ReadLine());
            list.Append(value);
            break;
        case 4:
            Console.WriteLine("Enter data to append.");
            int ele = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter position:");
            int pos = Convert.ToInt32(Console.ReadLine());
            list.InsertAtPosition(pos, ele);
            break;
        case 5:
            list.DeleteFirst();
            break;
        case 6:
            list.DeleteLast();
            break;
        default:
            Console.WriteLine("Invalid option.");
            break;
    }
    Console.WriteLine("\nLinkedList Operations:\n0.Exit\n1.Add\n2.Display\n3.Append\n4.Insert at position\n5.Delete First Node\n6.Delete Last node\nEnter your choice:");
    choice = Convert.ToInt32(Console.ReadLine());
}
