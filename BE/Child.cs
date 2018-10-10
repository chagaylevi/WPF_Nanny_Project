using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// this namespace contains all objects of the program
/// </summary>
namespace BE
{
    /// <summary>
    ///this class contains all details of a child
    /// </summary>
    public class Child
    {
        public int? id_child { set; get; }
        public int? id_mother { set; get; }
        public string name { set; get; }
        public DateTime date_of_birth { set; get; } = DateTime.Now;
        public bool special_needs { set; get; }
        public string Special_needs { set; get; }
        public bool Has_Nanny { set; get; }
        public override string ToString()
        {
            return "CHILD: \n" + "id of child: " + id_child + " id of mother: " + id_mother + "the name of the child: " + name;
        }
    }
}
