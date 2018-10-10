using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

/// <summary>
/// this namespace holds the data source
/// </summary>
namespace DS
{
    /// <summary>
    /// class holds the data source
    /// </summary>
    public class DataSource
    {
        public static List<Child> childList = new List<Child>();
        public static List<Contract> ContractList = new List<Contract>();
        public static List<Mother> MotherList = new List<Mother>();
        public static List<Nanny> NannyList = new List<Nanny>();
    }
}
