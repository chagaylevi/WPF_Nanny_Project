using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// this namespace deal with the buisness logic of the program
/// </summary>
namespace DAL
{
    /// <summary>
    /// return the type of realization
    /// </summary>
    public class FactoryDAL
    {
        static Idal idal = null;
        public static Idal getDAL()
        {
            if (idal == null)
                idal = new Dal_XML_imp();
            return idal;
        }
    }
}
