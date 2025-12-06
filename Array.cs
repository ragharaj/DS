class Array
{
  int [] arr;
  int size;
  int capacity;
  public Array (int capacity)
  {
    arr = new int [capacity];
    this.capacity = capacity;
    size = 0;   
  }
  void insert (int index, int val)
  {
    if (index > size || size == capacity)
      return;
    for (int  i = size; i > index; i--)
      arr [i] = arr [i - 1];
    arr [index] = val;
    size++;
  }

  void delete (int index)
  {
    if (index > size)
      return;
    for (int i = index; i < size - 1; i++)
      arr [i] = arr [i + 1];
    size--;
  }

  int search (int val)
  {
    for (int i = 0; i < size; i++)
      if (arr[i] == val)
        return i;
    return -1;
  }
  void display()
  {
    for (int i = 0; i < size; i++)
      System.Console.Write (arr [i] + " ");
  }
  public static void Main (string [] args)
  {
    Array a = new Array (10);

    a.insert (0, 5);
    a.insert (1, 10);
    a.insert (1, 7);

    a.delete (1);

    System.Console.WriteLine ("Found 10 in position: " + a.search (10));
    a.display ();
  }
}