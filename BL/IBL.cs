﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

/// <summary>
/// this namespace deal with the buisness logic of the program
/// </summary>
namespace BL
{
    /// <summary>
    /// interface which define how to do the logic 
    /// </summary>
    public interface IBL
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
        void addContract(Contract contract);

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
        /// lists of data source
        /// </summary>
        List<Child> ChildList();
        List<Contract> ContractList();
        List<Mother> MotherList();
        List<Nanny> NannyList();
    }
}
