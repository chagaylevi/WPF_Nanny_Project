using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DS;

/// <summary>
/// this namespace deal with data in data source
/// </summary>
namespace DAL
{
    /// <summary>
    /// implement of IDAL
    /// </summary>
    public class Dal_imp : Idal
    {
        /// <summary>
        /// add nanny
        /// </summary>
        /// <param name="nanny">nanny to add</param>
        public void addNanny(Nanny nanny)
        {
            bool flag = true;
            foreach (Nanny item in DataSource.NannyList)
            {
                if (item.id == nanny.id)
                {
                    flag = false;
                    throw new Exception("מספר תעודת הזהות קיים במערכת");
                }
            }
            if (flag) DataSource.NannyList.Add(nanny);
        }

        /// <summary>
        /// ramove nanny
        /// </summary>
        /// <param name="id">remove by id</param>
        public void removeNanny(int? id)
        {
            bool flag = true;
            foreach (Nanny item in DataSource.NannyList)
            {
                if (item.id == id)
                {
                    DataSource.NannyList.Remove(item);
                    flag = false;
                    break;
                }
            }
            if (flag)
            {
                throw new Exception("מטפלת בעלת תעודת זהות זו לא קיימת ברשימה");
            }
            DataSource.ContractList.RemoveAll(x => x.id_nanny == id);//remove all the contracts with this nanny
        }

        /// <summary>
        /// update nanny
        /// </summary>
        /// <param name="nanny">nanny to update</param>
        public void update_details_Nanny(Nanny nanny)
        {
            bool flag = false;
            foreach (Nanny item in DataSource.NannyList)
            {
                if (item.id == nanny.id) flag = true;
            }
            if (flag)
            {
                int index = DataSource.NannyList.FindIndex(x => x.id == nanny.id);
                DataSource.NannyList[index] = nanny;
            }
            else throw new Exception("המטפלת לא קיימת ברשימה");
        }

        /// <summary>
        /// add mother
        /// </summary>
        /// <param name="mother">mother to add</param>
        public void addMother(Mother mother)
        {
            bool flag = true;
            foreach (Mother item in DataSource.MotherList)
            {
                if (item.id == mother.id) flag = false;
            }
            if (flag) DataSource.MotherList.Add(mother);
            else throw new Exception("אמא זו כבר קיימת במערכת");
        }

        /// <summary>
        /// remove a mother
        /// </summary>
        /// <param name="id">remove by id</param>
        public void removeMother(int? id)
        {
            bool flag = true;
            foreach (Mother item in DataSource.MotherList)
            {
                if (item.id == id)
                {
                    DataSource.MotherList.Remove(item);
                    flag = false;
                    break;
                }
            }
            if (flag) throw new Exception("אמא בעלת תעודת זהות זו לא קיימת ברשימה");
            DataSource.ContractList.RemoveAll(x => x.id_mother == id);//remove all of contracts with this mother
            DataSource.childList.RemoveAll(x => x.id_mother == id);//remove all of children with this mother
        }

        /// <summary>
        /// update a mother
        /// </summary>
        /// <param name="mother">mother to update</param>
        public void update_detail_Mother(Mother mother)
        {
            bool flag = false;
            foreach (Mother item in DataSource.MotherList)
            {
                if (item.id == mother.id) flag = true;
            }
            if (flag)
            {
                int index = DataSource.MotherList.FindIndex(x => x.id == mother.id);
                DataSource.MotherList[index] = mother;
            }
            else throw new Exception("האמא לא נמצאת ברשימה");
        }

        /// <summary>
        /// add child
        /// </summary>
        /// <param name="child">child to add</param>
        public void addChild(Child child)
        {
            bool flag = true;
            foreach (Child item in DataSource.childList)
            {
                if (item.id_child == child.id_child) flag = false;
            }
            if (flag) DataSource.childList.Add(child);
            else throw new Exception("ילד זה כבר קיים במערכת");
        }

        /// <summary>
        /// remove a child
        /// </summary>
        /// <param name="id">remove by id</param>
        public void removeChild(int? id)
        {
            bool flag = true;
            foreach (Child item in DataSource.childList)
            {
                if (item.id_child == id)
                {
                    DataSource.childList.Remove(item);
                    flag = false;
                    break;
                }
            }
            if (flag) throw new Exception("ילד בעל תעודת זהות זו לא נמצא ברשימה");
            DataSource.ContractList.RemoveAll(x => x.id_child == id);//remove all of contracts with this child
        }

        /// <summary>
        /// update a child
        /// </summary>
        /// <param name="child">childto update</param>
        public void update_detail_Child(Child child)
        {
            bool flag = false;
            foreach (Child item in DataSource.childList)
            {
                if (item.id_child == child.id_child) flag = true;
            }
            if (flag)
            {
                int index = DataSource.childList.FindIndex(x => x.id_child == child.id_child);
                DataSource.childList[index] = child;
            }
            else throw new Exception("הילד לא נמצא ברשימה");
        }

        /// <summary>
        /// id of contract
        /// </summary>
        static int? contractId = 10000000;

        /// <summary>
        /// add a contarct
        /// </summary>
        /// <param name="contract">contract to add</param>
        /// <param name="num">num of the contarct(id)</param>
        public void addContract(Contract contract, int? num)
        {
            if (num == 0)
            {
                contract.num_of_contract = contractId;
                contractId++;
            }
            else
            {
                contract.num_of_contract = num;
            }
            DataSource.ContractList.Add(contract);
        }

        /// <summary>
        /// remove a contract
        /// </summary>
        /// <param name="id">remove by id</param>
        public void removeContract(int? id)
        {
            bool flag = true;
            foreach (Contract item in DataSource.ContractList)
            {
                if (item.num_of_contract == id)
                {
                    DataSource.ContractList.Remove(item);
                    flag = false;
                    break;
                }
            }
            if (flag) throw new Exception("לא נמצא מס' חוזה כזה");
        }

        /// <summary>
        /// update a contract
        /// </summary>
        /// <param name="contract">contract to update</param>
        public void update_detail_Contract(Contract contract)
        {
            bool flag = false;
            foreach (Contract item in DataSource.ContractList)
            {
                if (item.num_of_contract == contract.num_of_contract) flag = true;
            }
            if (flag)
            {
                int index = DataSource.ContractList.FindIndex(x => x.num_of_contract == contract.num_of_contract);
                DataSource.ContractList[index] = contract;
            }
            else throw new Exception("החוזה לא נמצא ברשימה");
        }

        /// <summary>
        /// get specific object/mother by his id
        /// </summary>
        /// <param name="id">indentify object by id</param>
        /// <returns></returns>
        public Mother getMother(int? id)
        {
            foreach (Mother item in MotherList())
            {
                if (item.id == id)
                {
                    return item;
                }
            }
            throw new Exception("האמא לא קיימת במערכת");
        }

        /// <summary>
        /// get specific object/child by his id
        /// </summary>
        /// <param name="id">indentify object by id</param>
        /// <returns></returns>
        public Child getChild(int? id)
        {
            foreach (Child item in ChildList())
            {
                if (item.id_child == id)
                {
                    return item;
                }
            }
            throw new Exception("הילד לא קיים במערכת");
        }

        /// <summary>
        /// get specific object/nanny by his id
        /// </summary>
        /// <param name="id">indentify object by id</param>
        /// <returns></returns>
        public Nanny getNanny(int? id)
        {
            foreach (Nanny item in NannyList())
            {
                if (item.id == id)
                {
                    return item;
                }
            }
            throw new Exception("המטפלת לא קיימת במערכת");
        }

        /// <summary>
        /// get specific object/contract by his id
        /// </summary>
        /// <param name="id">indentify object by id</param>
        /// <returns></returns>
        public Contract getContract(int? id)
        {
            foreach (Contract item in ContractList())
            {
                if (item.num_of_contract == id)
                    return item;
            }
            throw new Exception("החוזה לא קיים במערכת");
        }

        /// <summary>
        /// return list of children
        /// </summary>
        /// <returns></returns>
        public List<Child> ChildList() { return DataSource.childList; }

        /// <summary>
        /// return list of contracts
        /// </summary>
        /// <returns></returns>
        public List<Contract> ContractList() { return DataSource.ContractList; }

        /// <summary>
        /// return list of mother
        /// </summary>
        /// <returns></returns>
        public List<Mother> MotherList() { return DataSource.MotherList; }

        /// <summary>
        /// return list of nannies
        /// </summary>
        /// <returns></returns>
        public List<Nanny> NannyList() { return DataSource.NannyList; }
    }
}
