using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj2.Classes
{
  public class User
  {
    // Data fields.
    private readonly string _name;

    // Constructors.
    public User(string name)
    {
      _name = name;
    }

    // Public attributes.
    public string Name => _name;
  }
}
