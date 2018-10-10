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
    ///this class contains all details of a mother
    /// </summary>
    public class Mother
    {
        public int? id { set; get; }
        public string firstName { set; get; }
        public string lastName { set; get; }
        public string phone { set; get; }
        public string address { set; get; }
        private string mySearchArea = "";
        public string search_area { set { mySearchArea = value; } get { return mySearchArea; } }
        public bool signle_mother { set; get; }
        public int? count_of_children { set; get; }
        //***************//
        public bool[] work_days { get; set; } = new bool[6];
        public void set_workdays(bool day, int i)
        {
            work_days[i] = day;
        }
        public bool get_workdays(int i)
        {
            return work_days[i];
        }
        //***************//
        public TimeSpan[] start_hours { get; set; } = new TimeSpan[6];
        public TimeSpan[] end_hours { get; set; } = new TimeSpan[6];
        public void set_workhours(int i, TimeSpan start, TimeSpan end)
        {
            start_hours[i] = start;
            end_hours[i] = end;
        }
        public TimeSpan get_workhours_start(int i)
        {
            return start_hours[i];
        }
        public TimeSpan get_workhours_end(int i)
        {
            return end_hours[i];
        }
        public string comments { set; get; }
        public override string ToString()
        {
            return "MOTHER: \n" + "the id: " + id + " the firstName: " + firstName + " the lastName: " + lastName + " the phone: " + phone + " the address: " + address;
        }
    }
}
