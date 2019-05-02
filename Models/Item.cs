using System.Collections.Generic;

namespace ToDoList.Models
{
  public class Item
  {
    private string _description;
    private int _id;
    private static List<Item> _instances = new List<Item> {};

    public Item (string description)
    {
      _description = description;
      _instances.Add(this);
      _id = _instances.Count;
    }

    public string Description { get => _description; set => _description = value;}
    public static List<Item> Instances  { get => _instances; set => _instances = value;}
    public int Id { get => _id; set => _id = value;}

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static Item Find(int searchId)
    {
      return _instances[searchId-1];
    }

  }
}
