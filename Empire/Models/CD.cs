using System.Collections.Generic;

namespace Empire.Models
{
  public class CD
  {
    private string _title;
    private string _genre;

    public CD(string title, string genre)
    {
      title = _title;
      genre = _genre;
    }

    public string GetTitle()
    {
      return _title;
    }
    public void SetTitle(string title)
    {
      _title = title;
    }
    public string GetGenre()
    {
      return _genre;
    }
    public void SetGenre(string genre)
    {
      _genre = genre;
    }
  }
}
