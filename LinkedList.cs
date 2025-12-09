public class Node
{
  public int data;
  public Node? next;
  public Node (int data)
  {
    this.data = data;
    next = null;
  }
}

public class LinkedList
{
  private Node? head = null;
  void insertAtBeginning(int data)
  {
    Node newNode = new Node(data);
    //Node temp = head;
    newNode.next = head;
    head = newNode;
    
  }

  void insertAtEnd (int data)
  {
    Node newNode = new Node (data);
    Node temp = head;
    if (head == null)
    {
      insertAtBeginning(data);
      return;
    }
    while(temp.next != null)
    {
      temp = temp.next;
    }
    temp.next = newNode;
  }
  void insertAtIndex( int index, int data)
  {
    if (index == 0)
    {
      insertAtBeginning(data);
      return;
    }
    Node newNode = new Node(data);
    Node temp = head;
    for (int i = 0; i < index - 1; i++)
    {
      temp = temp.next;
    }
    newNode.next = temp.next;;
    temp.next = newNode;  
  }
  void display()
  {
    Node? temp = head;
    while (temp != null)
    {
      System.Console.Write(temp.data + "->");
      temp = temp.next;
    }
    System.Console.WriteLine("Done");
  }
  public static void Main (string [] args)
  {
    LinkedList ll = new LinkedList();
    ll.insertAtBeginning(10);
    ll.insertAtBeginning(20);
    ll.insertAtBeginning(30);
    ll.display();

    ll.insertAtEnd(5);
    ll.display();

    ll.insertAtIndex(2, 15);
    ll.display();


  }
}