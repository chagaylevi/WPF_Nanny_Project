using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// this namespace deal with the buisness logic of the program
/// </summary>
namespace BL
{
    /// <summary>
    /// return the specific implement of BL
    /// </summary>
    public class FactoryBL
    {
        static BL.IBL bl = null;
        public static IBL getBL()
        {
            if (bl == null)
                bl = new BL_imp();
            return bl;
        }
    }
}
