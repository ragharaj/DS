class DynamicArray

{
  int [] arr;
  int size;
  int capacity;
  public DynamicArray
   (int capacity)
  {
    arr = new int [capacity];
    this.capacity = capacity;
    size = 0;   
  }
  void insert (int index, int val)
  {
    if (index > size)
    {
      System.Console.WriteLine("Array is full, ...");
      return;
    }
    if (size == capacity)
    {
      resize();
    }
      
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
  void resize()
  {
    int newCapacity = capacity * 2;
    int[] newArr = new int[newCapacity];
    for (int i = 0; i < size; i++)
    {
      newArr[i] = arr[i];
    }
    arr = newArr;
    capacity = newCapacity;
  }
  public static void Main (string [] args)
  {
    DynamicArray a = new DynamicArray(10);

    a.insert (0, 5);
    a.insert (1, 10);
    a.insert (1, 7);
    a.insert (3, 15); // This will work fine
    a.insert (4, 20); // This will work fine
    a.insert (5, 25); // This will work fine
    a.insert (6, 30); // This will work fine
    a.insert (7, 35); // This will work fine
    a.insert (8, 40); // This will work fine
    a.insert (9, 45); // This will work fine
    a.insert(10,55); // This will not work, array is full
    a.delete (1);

    System.Console.WriteLine ("Found 10 in position: " + a.search (10));
    a.display ();
  }
}