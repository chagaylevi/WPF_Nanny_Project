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
    ///this class contains all details of a nanny
    /// </summary>
    public class Nanny
    {
        public List<Contract> MyContract = new List<Contract>();
        public int? id { set; get; }
        public string firstName { set; get; }
        public string lastName { set; get; }
        public DateTime date_of_birth { set; get; } = DateTime.Now;
        public string phone { set; get; }
        public string address { set; get; }
        public bool elevators { set; get; }
        public int floor { set; get; }
        public double years_of_experience { set; get; }
        public int max_of_children { set; get; }
        public int count_of_children { set; get; }
        public int min_age { set; get; }
        public int max_age { set; get; }
        public bool per_hour { set; get; }
        public double MyDistance { set; get; }
        public double hourly_rate { set; get; }
        public int monthly_rate { set; get; }
        public bool[] work_days { set; get; } = new bool[6];
        public void set_workdays(bool day, int i)
        {
            work_days[i] = day;
        }
        public bool get_workdays(int i)
        {
            return work_days[i];
        }
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
        public bool TMTorEDU { set; get; }
        public string recommendations { set; get; }
        public override string ToString()
        {
            return "NANNY:\n" + "the id: " + id + " the firstName: " + firstName + " the lastName: " + lastName + " the phone: " + phone + " the address: " + address;
        }
    }
}
