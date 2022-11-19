using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Final_Project
{
    static class ListManager
    {
        public static List<Recipe> entreeList = new List<Recipe>();
        public static List<Recipe> sideList = new List<Recipe>();
        public static List<Recipe> dessertList = new List<Recipe>();
        public static List<Recipe> snackList = new List<Recipe>();
        //public static List<string> vsLinkList = new List<string>();
        public static List<string> addsIngList = new List<string>();
        public static List<string> addsAmtList = new List<string>();
        public static List<string> addsUnitList = new List<string>();
        public static List<LinkLabel> entreeLinkLabels = new List<LinkLabel>();
        public static List<LinkLabel> sideLinkLabels = new List<LinkLabel>();
        public static List<LinkLabel> dessertLinkLabels = new List<LinkLabel>();
        public static List<LinkLabel> snackLinkLabels = new List<LinkLabel>();

        public static void createLinkLabelsLists()
        {
            entreeLinkLabels.Add(FormManager.vs.linkLabel1);
            entreeLinkLabels.Add(FormManager.vs.linkLabel2);
            entreeLinkLabels.Add(FormManager.vs.linkLabel3);
            entreeLinkLabels.Add(FormManager.vs.linkLabel4);
            entreeLinkLabels.Add(FormManager.vs.linkLabel5);
            entreeLinkLabels.Add(FormManager.vs.linkLabel6);
            entreeLinkLabels.Add(FormManager.vs.linkLabel7);
            entreeLinkLabels.Add(FormManager.vs.linkLabel8);
            entreeLinkLabels.Add(FormManager.vs.linkLabel9);
            entreeLinkLabels.Add(FormManager.vs.linkLabel10);
            sideLinkLabels.Add(FormManager.vs.linkLabel11);
            sideLinkLabels.Add(FormManager.vs.linkLabel12);
            sideLinkLabels.Add(FormManager.vs.linkLabel13);
            sideLinkLabels.Add(FormManager.vs.linkLabel14);
            sideLinkLabels.Add(FormManager.vs.linkLabel15);
            sideLinkLabels.Add(FormManager.vs.linkLabel16);
            sideLinkLabels.Add(FormManager.vs.linkLabel17);
            sideLinkLabels.Add(FormManager.vs.linkLabel18);
            sideLinkLabels.Add(FormManager.vs.linkLabel19);
            sideLinkLabels.Add(FormManager.vs.linkLabel20);
            dessertLinkLabels.Add(FormManager.vs.linkLabel21);
            dessertLinkLabels.Add(FormManager.vs.linkLabel22);
            dessertLinkLabels.Add(FormManager.vs.linkLabel23);
            dessertLinkLabels.Add(FormManager.vs.linkLabel24);
            dessertLinkLabels.Add(FormManager.vs.linkLabel25);
            dessertLinkLabels.Add(FormManager.vs.linkLabel26);
            dessertLinkLabels.Add(FormManager.vs.linkLabel27);
            dessertLinkLabels.Add(FormManager.vs.linkLabel28);
            dessertLinkLabels.Add(FormManager.vs.linkLabel29);
            dessertLinkLabels.Add(FormManager.vs.linkLabel30);
            snackLinkLabels.Add(FormManager.vs.linkLabel31);
            snackLinkLabels.Add(FormManager.vs.linkLabel32);
            snackLinkLabels.Add(FormManager.vs.linkLabel33);
            snackLinkLabels.Add(FormManager.vs.linkLabel34);
            snackLinkLabels.Add(FormManager.vs.linkLabel35);
            snackLinkLabels.Add(FormManager.vs.linkLabel36);
            snackLinkLabels.Add(FormManager.vs.linkLabel37);
            snackLinkLabels.Add(FormManager.vs.linkLabel38);
            snackLinkLabels.Add(FormManager.vs.linkLabel39);
            snackLinkLabels.Add(FormManager.vs.linkLabel40);
        }

        public static void createAddsIngList()
        {
            for (int i = 1; i < 10; i++)
            {
                addsIngList.Add("ingTB" + i + ".Text");
            }
        }

        public static void createAddsAmtList()
        {
            for (int i = 1; i < 10; i++)
            {
                addsAmtList.Add("amtTB" + i + ".Text");
            }
        }

        public static void createAddsUnitList()
        {
            for (int i = 1; i < 10; i++)
            {
                addsUnitList.Add("unitTB" + i + ".Text");
            }
        }

        public static void SerializeLists()
        {
            var xmlSerializer = new XmlSerializer(typeof(List<Recipe>));
            using (var s = System.IO.File.Create(@"Entrees.xml"))
            {
                xmlSerializer.Serialize(s, entreeList);
            }
            using (var s = System.IO.File.Create(@"Sides.xml"))
            {
                xmlSerializer.Serialize(s, sideList);
            }
            using (var s = System.IO.File.Create(@"Desserts.xml"))
            {
                xmlSerializer.Serialize(s, dessertList);
            }
            using (var s = System.IO.File.Create(@"Snacks.xml"))
            {
                xmlSerializer.Serialize(s, snackList);
            }
        }

        public static void DeserializeLists()
        {
            var serializer = new XmlSerializer(typeof(List<Recipe>));
            using (var reader = new System.IO.StreamReader("entrees.xml"))
            {
                entreeList = (List<Recipe>)serializer.Deserialize(reader);
            }
            using (var reader = new System.IO.StreamReader("sides.xml"))
            {
                sideList = (List<Recipe>)serializer.Deserialize(reader);
            }
            using (var reader = new System.IO.StreamReader("desserts.xml"))
            {
                dessertList = (List<Recipe>)serializer.Deserialize(reader);
            }
            using (var reader = new System.IO.StreamReader("snacks.xml"))
            {
                snackList = (List<Recipe>)serializer.Deserialize(reader);
            }
        }
    }
}
