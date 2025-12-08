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
  }
}