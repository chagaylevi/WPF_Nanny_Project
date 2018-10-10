using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

/// <summary>
/// this namespace deal with data in data source
/// </summary>
namespace DAL
{
    /// <summary>
    /// this interface define how to deal with data source
    /// </summary>
    public interface Idal
    {
        /// <summary>
        /// add nanny
        /// </summary>
        /// <param name="nanny">nanny to add</param>
        void addNanny(Nanny nanny);

        /// <summary>
        /// ramove nanny
        /// </summary>
        /// <param name="id">remove by id</param>
        void removeNanny(int? id);

        /// <summary>
        /// update nanny
        /// </summary>
        /// <param name="nanny">nanny to update</param>
        void update_details_Nanny(Nanny nanny);

        /// <summary>
        /// add mother
        /// </summary>
        /// <param name="mother">mother to add</param>
        void addMother(Mother mother);

        /// <summary>
        /// remove a mother
        /// </summary>
        /// <param name="id">remove by id</param>
        void removeMother(int? id);

        /// <summary>
        /// update a mother
        /// </summary>
        /// <param name="mother">mother to update</param>
        void update_detail_Mother(Mother mother);

        /// <summary>
        /// add child
        /// </summary>
        /// <param name="child">child to add</param>
        void addChild(Child child);

        /// <summary>
        /// remove a child
        /// </summary>
        /// <param name="id">remove by id</param>
        void removeChild(int? id);

        /// <summary>
        /// update a child
        /// </summary>
        /// <param name="child">childto update</param>
        void update_detail_Child(Child child);

        /// <summary>
        /// add a contarct
        /// </summary>
        /// <param name="contract">contract to add</param>
        void addContract(Contract contract, int? _num);

        /// <summary>
        /// remove a contract
        /// </summary>
        /// <param name="id">remove by id</param>
        void removeContract(int? num);

        /// <summary>
        /// update a contract
        /// </summary>
        /// <param name="contract">contract to update</param>
        void update_detail_Contract(Contract contract);

        /// <summary>
        /// list of data source
        /// </summary>
        /// <returns></returns>
        List<Child> ChildList();
        List<Contract> ContractList();
        List<Mother> MotherList();
        List<Nanny> NannyList();

        /// <summary>
        /// get specific object/child by his id
        /// </summary>
        /// <param name="id">indentify object by id</param>
        /// <returns></returns>
        Child getChild(int? id);

        /// <summary>
        /// get specific object/contract by his id
        /// </summary>
        /// <param name="id">indentify object by id</param>
        /// <returns></returns>
        Contract getContract(int? id);

        /// <summary>
        /// get specific object/mother by his id
        /// </summary>
        /// <param name="id">indentify object by id</param>
        /// <returns></returns>
        Mother getMother(int? id);

        /// <summary>
        /// get specific object/nanny by his id
        /// </summary>
        /// <param name="id">indentify object by id</param>
        /// <returns></returns>
        Nanny getNanny(int? id);
    }
}
