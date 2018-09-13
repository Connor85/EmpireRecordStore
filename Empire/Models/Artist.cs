using System.Collections.Generic;

namespace Empire.Models
{
  public class Artist
  {
    private string _name;
    private static List<Artist> _instances = new List<Artist> {};
    private List<Artist> _artist;
    private int _id;

    public Artist(string name)
    {
      _name = name;
      _instances.Add(this);
      _artist = new List<Artist>{};
      _id = _instances.Count;
    }

    public string GetName()
    {
      return _name;
    }
    public void SetName(string name)
    {
      _name = name;
    }
    public static List<Artist> GetAll()
    {
      return _instances;
    }
    public void Save()
    {
      _instances.Add(this);
    }
    public static List<Artist> GetArtists()
    {
      return _instances;
    }
    public void AddArtist(Artist artist)
    {
      _artist.Add(artist);
    }
    public int GetId()
    {
      return _id;
    }
    public static Artist Find(int searchId)
    {
      return _instances[searchId-1];
    }
  }
}
