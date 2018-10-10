using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;
using DS;
using BE;

namespace DAL
{
    public class Dal_XML_imp : Idal
    {
        const string ChildPath = @"ChildPath_.xml";
        const string NannyPath = @"NannyPath_.xml";
        const string MotherdPath = @"MotherPath_.xml";
        const string ContractPath = @"ContractPath_.xml";
        const string ConfigPath = @"configXml.xml";
        XElement ChildXml, configXml;
        private static int? contractId = 10000000;

        public Dal_XML_imp()
        {
            OpenFiles();
            DataSource.NannyList = Xml_To_List<Nanny>(NannyPath);
            DataSource.MotherList = Xml_To_List<Mother>(MotherdPath);
            DataSource.ContractList = Xml_To_List<Contract>(ContractPath);
        }

        private void OpenFiles()
        {
            if (!File.Exists(ConfigPath))
            {
                configXml = new XElement("Contract_Code");
                configXml.Save(ConfigPath);
                var code = new XElement("Coded", contractId);
                configXml.Add(code);
                configXml.Save(ConfigPath);
            }
            else
            {
                try
                {
                    configXml = XElement.Load(ConfigPath);
                    contractId = Convert.ToInt32(configXml.Element("Coded").Value);
                }
                catch
                {
                    var code = new XElement("Coded", contractId);
                    configXml.Add(code);
                    configXml.Save(ConfigPath);
                }
            }

            if (!File.Exists(ChildPath))
            {
                ChildXml = new XElement("ChildRoot");
                ChildXml.Save(ChildPath);
            }
            else
                ChildXml = XElement.Load(ChildPath);

            if (!File.Exists(ContractPath))
            {
                List_To_Xml(new List<Contract>(), ContractPath);
            }

            if (!File.Exists(MotherdPath))
            {
                List_To_Xml(new List<Mother>(), MotherdPath);
            }

            if (!File.Exists(NannyPath))
            {
                List_To_Xml(new List<Nanny>(), NannyPath);
            }
        }

        #region Get Child/Mother/Nanny/Contract Lists
        public List<Child> ChildList()
        {
            return (from Child in ChildXml.Elements()
                    select new Child
                    {
                        id_child = Convert.ToInt32(Child.Element("id_child").Value),
                        id_mother = Convert.ToInt32(Child.Element("id_mother").Value),
                        Special_needs = Child.Element("Special_needs").Value,
                        name = Child.Element("name").Value,
                        date_of_birth = DateTime.Parse(Child.Element("date_of_birth").Value),
                        Has_Nanny = Convert.ToBoolean(Child.Element("Has_Nanny").Value),
                        special_needs = Convert.ToBoolean(Child.Element("special_needs").Value),
                    }).ToList();
        }

        public List<Contract> ContractList()
        {
            return DataSource.ContractList;
        }

        public List<Mother> MotherList()
        {
            return DataSource.MotherList;
        }

        public List<Nanny> NannyList()
        {
            return DataSource.NannyList;
        }

        private void List_To_Xml<T>(List<T> list, string path)
        {
            try
            {
                XmlSerializer serialize = new XmlSerializer(list.GetType());
                FileStream stream = new FileStream(path, FileMode.Create);
                serialize.Serialize(stream, list);
                stream.Close();
            }
            catch
            {
                throw new Exception("error when trying to receive data from database");
            }
        }

        public List<T> Xml_To_List<T>(string path)
        {
            try
            {
                List<T> list;
                XmlSerializer deSerialize = new XmlSerializer(typeof(List<T>));
                FileStream Stream = new FileStream(path, FileMode.Open);
                list = (List<T>)deSerialize.Deserialize(Stream);
                Stream.Close();
                return list;
            }
            catch
            {
                throw new Exception("error when trying to save data to database");
            }
        }

        #endregion

        #region Add Child/Mother/Nanny/Contract
        /// <summary>
        /// add child
        /// </summary>
        /// <param name="child">child to add</param>
        public void addChild(Child child)
        {
            var found_child = (from Child in ChildXml.Elements()
                               where Convert.ToInt32(Child.Element("id_child").Value) == child.id_child
                               select Child).ToList();

            if (found_child.Count != 0)
                throw new Exception("...הילד כבר קיים במערכת");

            var clone = new XElement("Child", new XElement("id_child", child.id_child),
                                              new XElement("id_mother", child.id_mother),
                                              new XElement("name", child.name),
                                              new XElement("special_needs", child.special_needs),
                                              new XElement("Special_needs", child.Special_needs),
                                              new XElement("Has_Nanny", child.Has_Nanny),
                                              new XElement("date_of_birth", child.date_of_birth));
            ChildXml.Add(clone);
            ChildXml.Save(ChildPath);
        }

        /// <summary>
        /// add a contarct
        /// </summary>
        /// <param name="contract">contract to add</param>
        /// <param name="num">num of the contarct(id)</param>
        public void addContract(Contract contract, int? num)
        {
            var found_mom = DataSource.MotherList.Find(item => item.id == contract.id_mother);
            var fount_nanny = DataSource.NannyList.Find(item => item.id == contract.id_nanny);
            if (found_mom == null || fount_nanny == null)
                throw new Exception("...האמא או המטפלת אינם קיימות במערכת");
            if (num == 0)
            {
                contract.num_of_contract = contractId++;
            }
            else
            {
                contract.num_of_contract = num;
            }
            configXml.Element("Coded").Value = contractId.ToString();
            configXml.Save(ConfigPath);
            DataSource.ContractList.Add(contract);
            List_To_Xml(DataSource.ContractList, ContractPath);
        }

        /// <summary>
        /// add mother
        /// </summary>
        /// <param name="mother">mother to add</param>
        public void addMother(Mother mother)
        {
            if (DataSource.MotherList.Exists(item => item.id == mother.id))
                throw new Exception("...האמא כבר קיימת במערכת");

            DataSource.MotherList.Add(mother);
            List_To_Xml(DS.DataSource.MotherList, MotherdPath);
        }

        /// <summary>
        /// add nanny
        /// </summary>
        /// <param name="nanny">nanny to add</param>
        public void addNanny(Nanny nanny)
        {
            if (DataSource.NannyList.Exists(item => item.id == nanny.id))
                throw new Exception("...המטפלת כבר קיימת במערכת");

            DataSource.NannyList.Add(nanny);
            List_To_Xml(DataSource.NannyList, NannyPath);
        }

        #endregion

        #region Remove Child/Mother/Nanny/Contract

        /// <summary>
        /// ramove nanny
        /// </summary>
        /// <param name="_id">remove by id</param>
        public void removeNanny(int? _id)
        {
            var found = DataSource.NannyList.Find(item => item.id == _id);
            if (found == null)
                throw new Exception("...המטפלת לא קיימת במערכת");

            DataSource.NannyList.Remove(found);
            try
            {
                List_To_Xml(DataSource.NannyList, NannyPath);
            }
            catch
            {
                throw new Exception("Error in deleting Nanny.");
            }
        }

        /// <summary>
        /// remove a child
        /// </summary>
        /// <param name="_id">remove by id</param>
        public void removeChild(int? _id)
        {
            var found = from Child in ChildXml.Elements()
                        where Convert.ToInt32(Child.Element("id_child").Value) == _id
                        select Child;
            if (found == null)
                throw new Exception("...הילד אינו קיים במערכת");

            try
            {
                (from Child in ChildXml.Elements()
                 where Convert.ToInt32(Child.Element("id_child").Value) == _id
                 select Child).FirstOrDefault().Remove();
                ChildXml.Save(ChildPath);
            }
            catch
            {
                throw new Exception("Error in deleting Child");
            }
        }

        /// <summary>
        /// remove a contract
        /// </summary>
        /// <param name="code">remove by id</param>
        public void removeContract(int? code)
        {
            var found = DataSource.ContractList.Find(item => item.num_of_contract == code);
            if (found == null)
                throw new Exception("...חוזה זה אינו קיים במערכת");

            DataSource.ContractList.Remove(found);
            try
            {
                List_To_Xml(DataSource.ContractList, ContractPath);
            }
            catch
            {
                throw new Exception("Error in deleting contract.");
            }
        }

        /// <summary>
        /// remove a mother
        /// </summary>
        /// <param name="_id">remove by id</param>
        public void removeMother(int? _id)
        {
            var found = DataSource.MotherList.Find(item => item.id == _id);
            if (found == null)
                throw new Exception("...האמא אינה קיימת במערכת");

            DataSource.MotherList.Remove(found);
            try
            {
                List_To_Xml(DataSource.MotherList, MotherdPath);
            }
            catch
            {
                throw new Exception("Error in deleting Mother");
            }

        }
        #endregion

        #region Update details Child/Mother/Nanny/Contract

        /// <summary>
        /// update a child
        /// </summary>
        /// <param name="child">childto update</param>
        public void update_detail_Child(Child child)
        {
            XElement updateChild = (from Child in ChildXml.Elements()
                                    where Convert.ToInt32(Child.Element("id_child").Value) == child.id_child
                                    select Child).FirstOrDefault();
            if (updateChild == null)
                throw new Exception("...הילד אינו קיים במערכת");

            updateChild.Element("id_child").Value = child.id_child.ToString();
            updateChild.Element("id_mother").Value = child.id_mother.ToString();
            updateChild.Element("Has_Nanny").Value = child.Has_Nanny.ToString();
            updateChild.Element("special_needs").Value = child.special_needs.ToString();
            updateChild.Element("Special_needs").Value = child.Special_needs;
            updateChild.Element("name").Value = child.name;
            updateChild.Element("date_of_birth").Value = child.date_of_birth.ToString();
            ChildXml.Save(ChildPath);
        }

        /// <summary>
        /// update a contract
        /// </summary>
        /// <param name="contract">contract to update</param>
        public void update_detail_Contract(Contract contract)
        {
            var found = DataSource.ContractList.Find(item => item.num_of_contract == contract.num_of_contract);
            if (found == null)
                throw new Exception("...חוזה זה אינו קיים במערכת");

            DataSource.ContractList.Remove(found);
            DataSource.ContractList.Add(contract);
            List_To_Xml(DataSource.ContractList, ContractPath);
        }

        /// <summary>
        /// update a mother
        /// </summary>
        /// <param name="mother">mother to update</param>
        public void update_detail_Mother(Mother mother)
        {
            var found = DataSource.MotherList.Find(item => item.id == mother.id);
            if (found == null)
                throw new Exception("...האמא אינה קיימת במערכת");

            DataSource.MotherList.Remove(found);
            DataSource.MotherList.Add(mother);
            List_To_Xml(DataSource.MotherList, MotherdPath);
        }

        /// <summary>
        /// update nanny
        /// </summary>
        /// <param name="nanny">nanny to update</param>
        public void update_details_Nanny(Nanny nanny)
        {
            var found = DataSource.NannyList.Find(item => item.id == nanny.id);
            if (found == null)
                throw new Exception("...המטפלת לא קיימת במערכת");

            DataSource.NannyList.Remove(found);
            DataSource.NannyList.Add(nanny);
            List_To_Xml(DataSource.NannyList, NannyPath);
        }
        #endregion

        #region get Child/Mother/Nanny/Contract

        /// <summary>
        /// get specific mother by his id
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
        /// get specific child by his id
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
        /// get specific nanny by his id
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
        /// get specific contract by his id
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

        #endregion
    }
}
