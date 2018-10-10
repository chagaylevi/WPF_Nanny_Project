using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// this namespace contains all objects of the program
/// </summary>
namespace BE

{/// <summary>
///this class contains all details of a contract
/// </summary>
    public class Contract
    {
        public int? num_of_contract { set; get; }
        public int? id_nanny { set; get; }
        public int? id_child { set; get; }
        public int? id_mother { set; get; }
        public string name_nanny { set; get; }
        public string name_mother { set; get; }
        public string name_child { set; get; }
        public string MotherAddress { set; get; }
        public string NannyAddres { set; get; }
        public double distance { set; get; }
        public bool meeting { set; get; }
        public bool signing_a_contract { set; get; }
        public double? per_hour { set; get; }
        public double? per_month { set; get; }
        public bool hour_or_month { set; get; }
        public DateTime dateOfBirth { set; get; } = DateTime.Now;
        public DateTime date_of_begin { set; get; } = DateTime.Now;
        public DateTime date_of_end { set; get; } = DateTime.Now;
        public double? payment { set; get; }
        public override string ToString()
        {
            return "CONTRACT: \n" + "the num of contract: " + num_of_contract + " the id of nanny: " + id_nanny + " the id of child: " + id_child + " the id of mother: " + id_mother;
        }
    }
}
