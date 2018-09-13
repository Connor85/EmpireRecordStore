using System.Collections.Generic;

namespace Empire.Models
{
  public class Artist
  {
    private string _name;
    private static List<Artist> _instances = new List<Artist> {};

    public Artist(string name)
    {
      _name = name;
    }

    public string GetName()
    {
      return _name;
    }
    public void SetName(string name)
    {
      _name = name;
    }
  }
}
