using System.Collections.Generic;

namespace ToDoList.Models
{
  public class Category
  {
    private static List<Category> _instances = new List<Category> {};
    private string _name;
    private int _id;
    private List<Item> _items;

    public Category(string categoryName)
    {
      _name = categoryName;
      _instances.Add(this);
      _id = _instances.Count;
      _items = new List<Item>{};
    }

    public string Name { get => _name; set => _name = value; }
    public int Id { get => _id; set => _id = value; }
    public static List<Category> Instances { get => _instances; set => _instances = value; }
    public List<Item> Items { get => _items; set => _items = value; }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static Category Find(int searchId)
    {
      return _instances[searchId-1];
    }
    //Also, notice we subtract 1 from the provided searchId because indexes in the _instances array begin at 0, whereas our _id properties will begin at 1.
    public void AddItem(Item item)
    {
      _items.Add(item);
    }
  }

}
