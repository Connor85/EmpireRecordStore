using System.Collections.Generic;

namespace Empire.Models
{
  public class CD
  {
    private string _title;
    // private string _genre;
    private static List<CD> _instances = new List<CD> {};
    private List<CD> _cd;
    private int _id;

    public CD(string title)
    {
      _title = title;
      // _genre = genre;
      _cd = new List<CD>{};
      _id = _instances.Count;
      _instances.Add(this);
    }

    public string GetTitle()
    {
      return _title;
    }
    public void SetTitle(string title)
    {
      _title = title;
    }
    // public string GetGenre()
    // {
    //   return _genre;
    // }
    // public void SetGenre(string genre)
    // {
    //   _genre = genre;
    // }
    public static List<CD> GetCD()
    {
      return _instances;
    }
    public static List<CD> GetAll()
    {
      return _instances;
    }
    public void AddCD(CD cd)
    {
      _cd.Add(cd);
    }
    public int GetId()
    {
      return _id;
    }
    public void Save()
    {
      _instances.Add(this);
    }
    public static CD Find(int searchId)
    {
      return _instances[searchId-1];
    }

  }
}
