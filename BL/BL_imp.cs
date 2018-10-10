using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GoogleMapsApi.Entities.Directions.Request;
using GoogleMapsApi.Entities.Directions.Response;
using GoogleMapsApi.Entities.PlacesText.Request;
using BE;
using DAL;
using System.Threading;

/// <summary>
/// this namespace deal with the buisness logic of the program
/// </summary>
namespace BL
{
    /// <summary>
    /// this class implement the interface IBL 
    /// </summary>
    public class BL_imp : IBL
    {
        Idal mydal;

        /// <summary>
        /// return the implement of IDAL which we deal with
        /// </summary>
        public BL_imp()
        {
            mydal = DAL.FactoryDAL.getDAL();
            //strat();//initial program
        }

        /*void strat()
        {
            Mother mother1 = new Mother
            {
                address = "נחל יעלה 3 בית שמש",
                search_area = "נחל צאלים 8 בית שמש",
                count_of_children = 1,
                firstName = "orna",
                lastName = "zohar",
                signle_mother = false,
                id = 111111,
                phone = "0504171895",
            };
            BE.Mother mother2 = new BE.Mother
            {
                address = "הרצל 134 בית שמש ",
                search_area = "נחל קטלב 5 בית שמש",
                count_of_children = 1,
                firstName = "ronit",
                lastName = "tzur",
                signle_mother = false,
                id = 222222,
                phone = "0544171877"
            };
            BE.Mother mother3 = new BE.Mother
            {
                address = "נחל איילון 7 בית שמש",
                search_area = "נחל שמשון 9 בית שמש",
                count_of_children = 1,
                firstName = "orna",
                signle_mother = false,
                id = 666666,
                lastName = "zohar",
                phone = "0504171895"
            };
            BE.Mother mother4 = new BE.Mother
            {
                address = "נחל תמנה 5 בית שמש",
                comments = "good Nanny!!!",
                search_area = "נחל דולב 84 בית שמש",
                count_of_children = 2,
                firstName = "leha",
                signle_mother = true,
                id = 444444,
                lastName = "levy",
                phone = "0504171892"
            };
            for (int i = 0; i < 6; i++)
            {
                mother1.set_workdays(true, i);
                mother2.set_workdays(true, i);
                mother3.set_workdays(true, i);
                mother4.set_workdays(true, i);
                mother1.set_workhours(i, 8.5, 13.5);
                mother2.set_workhours(i, 9.5, 16.5);
                mother3.set_workhours(i, 9.5, 16.5);
                mother4.set_workhours(i, 9.5, 16.5);
            }//updating the hours that mothers need a nanny
            this.addMother(mother1);
            this.addMother(mother2);
            this.addMother(mother3);
            this.addMother(mother4);
            BE.Child c1 = new BE.Child
            {
                id_child = 111111,
                date_of_birth = DateTime.Parse("12/02/2011"),
                id_mother = 111111,
                name = "yosi",
                special_needs = true,
                Has_Nanny = false
            };
            BE.Child c2 = new BE.Child
            {
                id_child = 222222,
                date_of_birth = DateTime.Parse("12/02/2015"),
                id_mother = 111111,
                name = "yehuda",
                special_needs = true,
                Has_Nanny = false
            };
            BE.Child c3 = new BE.Child
            {
                id_child = 333333,
                date_of_birth = DateTime.Parse("12/02/2015"),
                id_mother = 222222,
                name = "yoram",
                special_needs = true,
                Has_Nanny = false
            };
            BE.Child c4 = new BE.Child
            {
                id_child = 444444,
                date_of_birth = DateTime.Parse("12/02/2015"),
                id_mother = 333333,
                name = "ishay",
                special_needs = true,
                Has_Nanny = false
            };
            BE.Child c5 = new BE.Child
            {
                id_child = 555555,
                date_of_birth = DateTime.Parse("12/02/2016"),
                id_mother = 444444,
                name = "ishay",
                special_needs = true,
                Has_Nanny = false
            };
            this.addChild(c1);
            this.addChild(c2);
            this.addChild(c3);
            this.addChild(c4);
            this.addChild(c5);
            BE.Nanny nanny1 = new BE.Nanny
            {
                address = "נחל הבשור 4 בית שמש ",
                floor = 2,
                elevators = true,
                firstName = "chana",
                lastName = "levi",
                max_age = 4,
                id = 111111,
                years_of_experience = 5,
                phone = "0504444444",
                TMTorEDU = true,
                recommendations = "good nanny",
                min_age = 1,
                max_of_children = 11,
                hourly_rate = 40,
                monthly_rate = 2000,
                per_hour = true,
                date_of_birth = DateTime.Parse("12/08/1991"),
            };
            BE.Nanny nanny2 = new BE.Nanny
            {
                address = "גוש עציון",
                floor = 2,
                elevators = true,
                firstName = "Lea",
                lastName = "kaplan",
                max_age = 4,
                id = 222222,
                years_of_experience = 6,
                phone = "050443244",
                TMTorEDU = true,
                recommendations = "good nanny",
                min_age = 1,
                max_of_children = 11,
                hourly_rate = 40,
                monthly_rate = 2000,
                per_hour = true,
                date_of_birth = DateTime.Parse("12/08/1991"),
            };
            BE.Nanny nanny3 = new BE.Nanny
            {
                address = "שדרות בן זאב 8 בית שמש",
                floor = 2,
                elevators = true,
                firstName = "hen",
                lastName = "lev",
                max_age = 4,
                id = 333333,
                years_of_experience = 6,
                phone = "050443244",
                TMTorEDU = true,
                recommendations = "good nanny",
                min_age = 1,
                max_of_children = 11,
                hourly_rate = 40,
                monthly_rate = 2500,
                per_hour = true,
                date_of_birth = DateTime.Parse("12/08/1992"),
            };
            BE.Nanny nanny4 = new BE.Nanny
            {
                address = "שדרות בן זאב 8 בית שמש",
                floor = 2,
                elevators = true,
                firstName = "flora",
                lastName = "cohen",
                max_age = 4,
                id = 444444,
                years_of_experience = 6,
                phone = "050443244",
                TMTorEDU = true,
                recommendations = "good nanny",
                min_age = 1,
                max_of_children = 11,
                hourly_rate = 40,
                monthly_rate = 2500,
                per_hour = true,
                date_of_birth = DateTime.Parse("12/08/1992"),
            };
            BE.Nanny nanny5 = new BE.Nanny
            {
                address = "שדרות בן זאב 8 בית שמש",
                floor = 2,
                elevators = true,
                firstName = "rivka",
                lastName = "toledano",
                max_age = 4,
                id = 555555,
                years_of_experience = 6,
                phone = "050443244",
                TMTorEDU = true,
                recommendations = "good nanny",
                min_age = 1,
                max_of_children = 11,
                hourly_rate = 40,
                monthly_rate = 2500,
                per_hour = true,
                date_of_birth = DateTime.Parse("12/08/1992"),
            };
            for (int i = 0; i < 6; i++)
            {
                nanny2.set_workdays(true, i);
                nanny1.set_workdays(true, i);
                nanny3.set_workdays(true, i);
                nanny3.set_workdays(true, i);
                nanny1.set_workhours(i, 11.5, 14.5);
                nanny2.set_workhours(i, 9.5, 12.5);
                nanny3.set_workhours(i, 11.5, 14.5);
                nanny4.set_workhours(i, 9.5, 12.5);
            }//updating hours that nannies work
            this.addNanny(nanny1);
            this.addNanny(nanny2);
            this.addNanny(nanny3);
            this.addNanny(nanny4);
            this.addNanny(nanny5);
            Console.WriteLine("the nannies with over 5 years of expeirence are:");
            List<BE.Nanny> list1 = more_5_years();
            foreach (BE.Nanny item in list1)
            {
                Console.WriteLine(item.firstName + " " + item.lastName);
            }
            List<BE.Nanny> list2 = properList(mother1);
            Console.WriteLine("the relevant nannies for the mother-orna zohar are:");
            foreach (BE.Nanny item in list2)
            {
                Console.WriteLine(item.firstName + " " + item.lastName);
            }

            Contract con1 = new BE.Contract
            {
                id_child = 111111,
                hour_or_month = true,
                per_hour = 35,
                per_month = 2000,
                id_nanny = 111111,
                meeting = true,
                name_nanny = "orna",
                NannyAddres = "נחל הבשור 4 בית שמש",
                signing_a_contract = false,
                name_child = "yosi",
                MotherAddress = "נחל דולב 84 בית שמש",
                id_mother = 111111,
                date_of_begin = DateTime.Parse("12/12/2017"),
                date_of_end = DateTime.Parse("06/06/2018")
            };
            BE.Contract con2 = new BE.Contract
            {
                id_child = 222222,
                hour_or_month = true,
                per_hour = 35,
                per_month = 2000,
                id_nanny = 111111,
                meeting = true,
                name_nanny = "orna",
                NannyAddres = "נחל הבשור 4 בית שמש",
                signing_a_contract = true,
                name_child = "yehuda",
                MotherAddress = "נחל דולב 84 בית שמש",
                id_mother = 111111,
                date_of_begin = DateTime.Parse("12/12/2017"),
                date_of_end = DateTime.Parse("06/06/2018")
            };
            BE.Contract con3 = new BE.Contract
            {
                id_child = 333333,
                hour_or_month = true,
                per_hour = 50,
                per_month = 2400,
                id_nanny = 222222,
                meeting = true,
                name_nanny = "tirtza",
                NannyAddres = "גוש עציון ",
                signing_a_contract = true,
                name_child = "yoram",
                MotherAddress = "נחל איילון 7 בית שמש",
                id_mother = 222222,
                date_of_begin = DateTime.Parse("12/12/2017"),
                date_of_end = DateTime.Parse("06/06/2018")
            };
            this.addContract(con1, mother1, nanny1, c1);
            this.addContract(con2, mother1, nanny1, c2);
            this.addContract(con3, mother2, nanny2, c3);

            Console.WriteLine("the contracts( group by distance )are:");
            var result = ContractsByGroups();
            foreach (IGrouping<int, BE.Contract> item in result)
            {
                switch (item.Key)
                {
                    case 1:
                        Console.WriteLine("Up to 5 kilometers:");
                        foreach (BE.Contract it in item)
                            Console.WriteLine(it.name_nanny);
                        break;
                    case 2:
                        Console.WriteLine("Up to 10 kilometers:");
                        foreach (BE.Contract it in item)
                            Console.WriteLine(it.name_nanny);
                        break;
                    case 3:
                        Console.WriteLine("Up to 15 kilometers:");
                        foreach (BE.Contract it in item)
                            Console.WriteLine(it.name_nanny);
                        break;
                    case 4:
                        Console.WriteLine("Up to 20 kilometers:");
                        foreach (BE.Contract it in item)
                            Console.WriteLine(it.name_nanny);
                        break;
                    default:
                        break;

                }
            }
        }*///end of the initial program

        //*******************************special functions*********************

        /// <summary>
        /// a fanc that checks whether the id exists
        /// </summary>
        /// <param name="_id">id for check</param>
        public void _ID(int _id)
        {
            foreach (Nanny item in NannyList())
            {
                if (_id == item.id)
                {
                    throw new Exception("מספר תעודת הזהות קיים במערכת");
                }
            }
            return;
        }

        /// <summary>
        /// all nannies with more 5 years of experience
        /// </summary>
        /// <returns>list of nannies with over 5 years of experience</returns>
        public List<Nanny> more_5_years()
        {
            return mydal.NannyList().FindAll(x => x.years_of_experience >= 5);
        }

        /// <summary>
        /// return all children with special needs
        /// </summary>
        /// <returns></returns>
        public List<Child> special_needs()
        {
            return mydal.ChildList().FindAll(x => x.special_needs);
        }

        /// <summary>
        ///return all mothers who are "signle mother" with more 2 children
        /// </summary>
        /// <returns></returns>
        public List<Mother> Urgent_list()
        {
            return mydal.MotherList().FindAll(x => x.signle_mother && x.count_of_children > 2);
        }

        /// <summary>
        ///return All contracts that have already been signed and the parties met
        /// </summary>
        /// <returns></returns>
        public List<Contract> relevent_contracts()
        {
            return mydal.ContractList().FindAll(x => x.meeting && x.signing_a_contract);
        }

        /// <summary>
        /// grouping the nannies by distance(km:) from the mother 
        /// </summary>
        /// <param name="mother">specific mother</param>
        /// <returns></returns>
        public IEnumerable<IGrouping<int, Nanny>> Nanny_Groups(Mother mother)
        {
            IEnumerable<IGrouping<int, Nanny>> result;
            result = from item in mydal.NannyList()
                     group item by priority((int)distance(mother.address, item.address) * 5);
            return result;
        }

        /// <summary>
        /// remove from the list all children over the age of 4
        /// </summary>
        public void refresh()
        {
            foreach (Child item in ChildList())
            {
                if (DateTime.Compare(DateTime.Now.AddYears(-4), item.date_of_birth) > 0)
                    removeChild(item.id_child);
            }
        }

        /// <summary>
        /// return all nannies who lives in floor selected or have elevator
        /// </summary>
        /// <param name="max">max floor that mother agrees </param>
        /// <returns></returns>
        public List<Nanny> Floor(int max)
        {
            return NannyList().FindAll(item => item.floor <= max || item.elevators);
        }


        //************************Required functions**************************

        /// <summary>
        /// return all children with no nanny
        /// </summary>
        /// <returns></returns>
        public List<Child> has_no_Nanny()//return all children with no nanny
        {
            return mydal.ChildList().FindAll(item => item.Has_Nanny == false);
        }

        /// <summary>
        /// return the amount of nannies who get vacation by TMT
        /// </summary>
        /// <returns></returns>
        public List<Nanny> Nanny_TMT()//return the amount of nannies who get vacation by TMT
        {
            return mydal.NannyList().FindAll(item => item.TMTorEDU == true);
        }

        Func<Nanny, Mother, bool> func = Working_times;

        /// <summary>
        /// return the best offers for mother
        /// </summary>
        /// <param name="mother">this mother will be check for nannies</param>
        /// <returns></returns>
        public List<Nanny> properList(Mother mother)
        {
            List<Nanny> allNannies = new List<Nanny>();
            foreach (Nanny item in mydal.NannyList())
            {
                if (matching(item, mother))
                    allNannies.Add(item);
            }
            if (allNannies.Count != 0)
                return allNannies;
            else return defaultList(mother);//if there is no full match for mother so give default list
        }

        /// <summary>
        /// checking matching between mother and nanny
        /// </summary>
        /// <param name="nanny">this specific nanny would be checked</param>
        /// <param name="mother">this specific mother would be checked</param>
        /// <returns></returns>
        static bool matching(Nanny nanny, Mother mother)
        {
            bool flag = false;
            for (int i = 0; i < 6; i++)
            {
                flag = false;
                if (mother.get_workdays(i) == true && nanny.get_workdays(i) == false) { flag = false; break; }
                else
                {
                    if (mother.get_workhours_start(i) >= nanny.get_workhours_start(i) && mother.get_workhours_end(i) <=
                        nanny.get_workhours_end(i)) flag = true;
                }
            }
            return flag;
        }

        /// <summary>
        /// a fanc that compares the times of a nanny with times of mother
        /// </summary>
        /// <param name="nanny">this specific nanny would be checked</param>
        /// <param name="mother">this specific mother would be checked</param>
        /// <returns></returns>
        static bool Working_times(Nanny nanny, Mother mother)
        {
            bool flag = true;
            for (int i = 0; i < 6; i++)
            {
                if (mother.get_workdays(i) == true && nanny.get_workdays(i) == false)
                {
                    flag = false;
                    break;
                }
                if (mother.get_workdays(i) == true && nanny.get_workdays(i) == true)
                    if (mother.get_workhours_start(i) < nanny.get_workhours_start(i) || nanny.get_workhours_end(i) < mother.get_workhours_end(i))
                        flag = false;
                break;
            }
            return flag;
        }

        /// <summary>
        /// grouping the contracts by the distance between mother and nanny
        /// </summary>
        /// <param name="sorted">bool ver that indicates if return sorted list</param>
        /// <returns></returns>
        public IEnumerable<IGrouping<int, Contract>> ContractsByGroups(bool sorted = false)
        {
            Thread thread1;
            foreach (Contract item in mydal.ContractList())
            {
                thread1 = new Thread((object n) => { item.distance = distance(item.MotherAddress, item.NannyAddres); });
                thread1.Start(item);
                thread1.Join();
            }

            IEnumerable<IGrouping<int, Contract>> result;
            result = from item in mydal.ContractList()
                     group item by priority((int)item.distance);
            if (sorted)
            {
                result = from item in mydal.ContractList()
                         orderby item.num_of_contract
                         group item by priority((int)item.distance);
            }
            return result;
        }

        /// <summary>
        /// help function for grouping of contracts
        /// </summary>
        /// <param name="num">this num is the distance(km)between mother and nanny</param>
        /// <returns></returns>
        static int priority(int num)
        {
            int i = 1;
            while ((num / 5) != 0)
            {
                num -= 5;
                i++;
            }
            return i;
        }

        /// <summary>
        /// grouping the nannies by ageof children
        /// </summary>
        /// <param name="sort">if user wont sort</param>
        /// <param name="min_max">groupe by max or min</param>
        /// <returns></returns>
        public IEnumerable<IGrouping<int, Nanny>> Groups_by_age(bool sort, bool min_max)
        {
            IEnumerable<IGrouping<int, Nanny>> mymin;
            IEnumerable<IGrouping<int, Nanny>> mymax;
            mymin = from item in NannyList()
                    group item by check(item.min_age);
            mymax = from item in NannyList()
                    group item by check(item.max_age);
            if (min_max)
            {
                if (sort)
                {
                    mymin = from item in NannyList()
                            orderby item.firstName
                            group item by check(item.min_age);
                }
                return mymin;
            }
            if (sort)
            {
                mymax = from item in NannyList()
                        orderby item.firstName
                        group item by check(item.max_age);
            }
            return mymax;
        }

        /// <summary>
        /// help fun for grouping nanies
        /// </summary>
        /// <param name="age">age of the children</param>
        /// <returns></returns>
        public int check(int age)
        {
            int i = 1;
            while ((age - 6) > 0)
            {
                age -= 6;
                i++;
            }
            return i;
        }

        /// <summary>
        /// delegate for the next functions
        /// </summary>
        /// <param name="contract"></param>
        /// <returns></returns>
        public delegate bool Condition(Contract contract);

        /// <summary>
        /// return All contracts that meet certain conditions
        /// </summary>
        /// <param name="cond"></param>
        /// <returns></returns>
        List<Contract> list_condition(Condition cond)//All contracts that meet certain conditions
        {
            return mydal.ContractList().FindAll(item => cond(item) == true);
        }

        /// <summary>
        /// the amount of contracts that meet certain conditions
        /// </summary>
        /// <param name="cond"></param>
        /// <returns></returns>
        public int num_condition(Condition cond)//the amount of contracts that meet certain conditions
        {
            int counter = 0;
            foreach (Contract item in mydal.ContractList())
            {
                if (cond(item))
                    counter++;
            }
            return counter;
        }

        /// <summary>
        /// returns the five nannies who live near to the mother
        /// </summary>
        /// <param name="mother">mother that we send her the list with all nannies around</param>
        /// <returns></returns>
        public List<Nanny> Nannies_around(Mother mother)//fun returns the  nannies who live near to the mother
        {
            List<Nanny> aroundingList = new List<Nanny>();
            string destination;
            if (mother.search_area != "" || mother.search_area == null) destination = mother.search_area;
            else
                destination = mother.address;
            List<double> Must = new List<double>();
            foreach (Nanny item in mydal.NannyList())
            {
                if (matching(item, mother))
                    aroundingList.Add(item);
            }
            Thread thread1;
            foreach (Nanny item in aroundingList)
            {
                thread1 = new Thread((object n) => { mydal.getNanny(item.id).MyDistance = distance(item.address, destination); });
                thread1.Start(item);
                thread1.Join();
            }
            List<Nanny> help = new List<Nanny>();
            foreach (Nanny item in aroundingList)
            {
                if (item.MyDistance < 2)
                {
                    help.Add(item);
                }
            }
            foreach (Nanny item in help)
            {
                item.MyDistance = 0;
            }
            return help;
        }

        /// <summary>
        /// return 5 nannies by 1) distance ,2) years of experience
        /// </summary>
        /// <param name="mother">mother we send her a default list of nannies</param>
        /// <returns></returns>
        public List<Nanny> defaultList(Mother mother)
        {
            string destination = mother.address;
            List<Nanny> ListOfFive = new List<Nanny>();
            Thread thread1;
            foreach (Nanny item in mydal.NannyList())
            {
                thread1 = new Thread((object n) => { item.MyDistance = distance(item.address, destination); });
                thread1.Start(item);
                thread1.Join();
            }
            var v = from item in mydal.NannyList()
                    orderby item.MyDistance, item.years_of_experience descending
                    select item;
            int count = 1;
            foreach (Nanny item in v)
            {
                if (count == 5) break;
                ListOfFive.Add(item);
                count++;
            }
            foreach (Nanny item in mydal.NannyList())
            {
                item.MyDistance = 0;
            }
            return ListOfFive;//five nannies who are most relevant for the mother
        }

        /// <summary>
        ///return the distance by google maps(km)
        /// </summary>
        /// <param name="source">nanny address</param>
        /// <param name="dest">mother address</param>
        /// <returns></returns>
        public static double distance(string source, string dest)//distance by google maps
        {
            var v = new DirectionsRequest { TravelMode = TravelMode.Walking, Origin = source, Destination = dest };
            DirectionsResponse direction = GoogleMapsApi.GoogleMaps.Directions.Query(v);
            Route route = direction.Routes.First();
            Leg leg = route.Legs.First();
            return (double)leg.Distance.Value / 1000;
        }

        /// <summary>
        /// list that holds the current num of contract
        /// </summary>
        static List<int> num_contracts = new List<int>();

        /// <summary>
        /// return the current num of contract
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public int Num_contracts(int num = 0)
        {
            if (num != 0)
            {
                num_contracts.Add(num);
                num_contracts.Sort();
                return 0;
            }
            if (num_contracts.Count == 0)
            {
                return 0;
            }
            return num_contracts.First();
        }


        //*************contract************

        /// <summary>
        /// check the conditions of the contract ,and update salary 
        /// </summary>
        /// <param name="contract">the contract we deal with</param>
        /// <param name="mother">mother of the child</param>
        /// <param name="nanny">nanny</param>
        /// <param name="child">the child who needs the nanny</param>
        /// <returns> return the contract ready</returns>
        public Contract CheckContract(Contract contract, Mother mother, Nanny nanny, Child child)
        {
            contract.name_nanny = nanny.firstName;
            contract.id_mother = mother.id;
            contract.id_nanny = nanny.id;
            contract.MotherAddress = mother.address;
            contract.per_hour = nanny.hourly_rate;
            contract.per_month = nanny.monthly_rate;
            contract.NannyAddres = nanny.address;
            contract.dateOfBirth = child.date_of_birth;
            contract.name_child = child.name;
            if (child.Has_Nanny == true) throw new Exception("לילד זה כבר קיימת מטפלת");
            if (DateTime.Compare(DateTime.Now.AddMonths(-3), child.date_of_birth) < 1)
            {
                throw new Exception("הילד צעיר מידי");
            }
            if (DateTime.Compare(DateTime.Now.AddYears(-nanny.max_age), child.date_of_birth) >= 1)
                throw new Exception("מטפלת זו לא מטפלת בילד בגיל מבוגר זה ");
            if (DateTime.Compare(DateTime.Now.AddYears(-nanny.min_age), child.date_of_birth) < 1)
                throw new Exception("מטפלת זו לא מטפלת בילד בגיל צעיר זה");
            int counter = 0;
            float percent = 0;
            foreach (Contract item in mydal.ContractList())
            {
                if (item.id_nanny == nanny.id && item.id_mother == mother.id)
                {
                    counter += 2;
                }
            }
            foreach (Contract item in nanny.MyContract)
            {
                if (item.id_nanny == nanny.id && item.id_mother == mother.id)
                {
                    counter += 2;
                }
            }
            percent = (float)(100 - counter) / 100;
            contract.per_hour *= percent;
            contract.per_month *= (float)percent;
            double sum_of_hours = 0;
            if (contract.hour_or_month == true && nanny.per_hour == true)//if mother wants per hour,and also nanny do, so..
            {
                for (int i = 0; i < 6; i++)
                {
                    if (mother.work_days[i] == true)
                    {
                        sum_of_hours +=
                         (mother.get_workhours_end(i) - mother.get_workhours_start(i)).Hours;
                    }
                }
                contract.payment = contract.per_hour * sum_of_hours * 4;
            }
            else
            {
                contract.payment = contract.per_month;
            }
            counter = 0;
            foreach (Contract item in mydal.ContractList())
            {
                if (item.id_nanny == nanny.id)
                {
                    counter++;
                }
            }
            if (counter >= nanny.max_of_children)
            {
                throw new Exception("מצטערים המטפלת במכסה מלאה של ילדים");
            }
            return contract;
        }

        /// <summary>
        /// adding the contract to data source
        /// </summary>
        /// <param name="contract">this contract will be added to data source</param>
        public void addContract(Contract contract)
        {
            mydal.getNanny(contract.id_nanny).max_of_children--;
            mydal.getChild(contract.id_child).Has_Nanny = true;
            contract.signing_a_contract = true;
            int num = Num_contracts();
            mydal.addContract(contract, num);
        }

        /// <summary>
        /// this function implements removing contract
        /// </summary>
        /// <param name="id">we removing by id</param>
        public void removeContract(int? id)
        {
            mydal.removeContract(id);
        }

        /// <summary>
        /// this function implements updating contract
        /// </summary>
        /// <param name="contract">contract to update</param>
        public void update_detail_Contract(Contract contract)
        {
            mydal.update_detail_Contract(contract);
        }

        //********nanny*******
        /// <summary>
        /// this function implements adding nanny to the list of nannies
        /// </summary>
        /// <param name="nanny">nanny to add</param>
        public void addNanny(Nanny nanny)
        {
            if (DateTime.Compare(DateTime.Now.AddYears(-18), nanny.date_of_birth) < 0)
            {
                throw new Exception("מטפלת זו צעירה מידי");
            }
            if (nanny.max_age <= nanny.min_age) throw new Exception("...לא נבחר טווח גילאים נכון");
            if (nanny.max_of_children == 0) throw new Exception("...לא נבחרה כמות מקסימלית של ילדים");
            bool flag = true;
            for (int i = 0; i < 6; i++)
            {
                if (nanny.get_workdays(i) == true)
                    flag = false;
            }
            if (flag) throw new Exception("לא נבחרו ימי טיפול");
            mydal.addNanny(nanny);
        }

        /// <summary>
        /// this function implements removing nanny to the list of nannies
        /// </summary>
        /// <param name="id"></param>
        public void removeNanny(int? id)
        {
            mydal.removeNanny(id);
        }

        /// <summary>
        ///  this function implements updating nanny to the list of nannies
        /// </summary>
        /// <param name="nanny">nanny to update</param>
        public void update_details_Nanny(Nanny nanny)
        {
            mydal.update_details_Nanny(nanny);
        }

        //*******mother*********

        /// <summary>
        /// this function implements adding mother to the list of mother
        /// </summary>
        /// <param name="mother">mother to add</param>
        public void addMother(Mother mother)
        {
            bool flag = true;
            for (int i = 0; i < 6; i++)
            {
                if (mother.get_workdays(i) == true)
                    flag = false;
            }
            if (flag) throw new Exception("לא נבחרו ימי טיפול ");
            mydal.addMother(mother);
        }

        /// <summary>
        /// this function implements removing mother to the list of mother
        /// </summary>
        /// <param name="id">ew removing by id</param>
        public void removeMother(int? id)
        {
            mydal.removeMother(id);
        }

        /// <summary>
        /// this function implements updating mother to the list of mother
        /// </summary>
        /// <param name="mother">mother to update</param>
        public void update_detail_Mother(Mother mother)
        {
            mydal.update_detail_Mother(mother);
        }

        //***************child**************

        /// <summary>
        /// this function implements adding child to the list of children
        /// </summary>
        /// <param name="child">child to add</param>
        public void addChild(Child child)
        {
            if (DateTime.Compare(DateTime.Now.AddYears(-4), child.date_of_birth) > 0)
            {
                throw new Exception("הילד מעל גיל 4 ולא ניתן להכניסו למערכת אנא הרשמי תחילה");
            }
            bool flag = false;
            foreach (Mother item in mydal.MotherList())
            {
                if (child.id_mother == item.id)
                {
                    flag = true; break;
                }
            }
            if (flag) mydal.addChild(child);
            else throw new Exception("לא קיימת אמא במערכת עבור הילד");
        }

        /// <summary>
        ///  this function implements removing child to the list of children
        /// </summary>
        /// <param name="id">we removing by id</param>
        public void removeChild(int? id)
        {
            mydal.removeChild(id);
        }

        /// <summary>
        ///  this function implements updating child to the list of children
        /// </summary>
        /// <param name="child">child to update</param>
        public void update_detail_Child(Child child)
        {
            mydal.update_detail_Child(child);
        }

        // <summary>
        /// return list of children
        /// </summary>
        /// <returns></returns>
        public List<Child> ChildList()
        {
            return mydal.ChildList();
        }

        /// <summary>
        /// return list of contracts
        /// </summary>
        /// <returns></returns>
        public List<Contract> ContractList()
        {
            return mydal.ContractList();
        }

        /// <summary>
        /// return list of mother
        /// </summary>
        /// <returns></returns>
        public List<Mother> MotherList()
        {
            return mydal.MotherList();
        }

        /// <summary>
        /// return list of nannies
        /// </summary>
        /// <returns></returns>
        public List<Nanny> NannyList()
        {
            return mydal.NannyList();
        }

        /// <summary>
        /// get specific object/child by his id
        /// </summary>
        /// <param name="id">indentify object by id</param>
        /// <returns></returns>
        public Child getChild(int? id)
        {
            return mydal.getChild(id);
        }

        /// <summary>
        /// get specific object/contract by his id
        /// </summary>
        /// <param name="id">indentify object by id</param>
        /// <returns></returns>
        public Contract getContract(int? id)
        {
            return mydal.getContract(id);
        }

        /// <summary>
        /// get specific object/mother by his id
        /// </summary>
        /// <param name="id">indentify object by id</param>
        /// <returns></returns>
        public Mother getMother(int? id)
        {
            return mydal.getMother(id);
        }

        /// <summary>
        /// get specific object/nanny by his id
        /// </summary>
        /// <param name="id">indentify object by id</param>
        /// <returns></returns>
        public Nanny getNanny(int? id)
        {
            return mydal.getNanny(id);
        }
    }
}
