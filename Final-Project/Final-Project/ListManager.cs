using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Final_Project
{
    static class ListManager
    {
        public static List<Recipe> entreeList = new List<Recipe>();
        public static List<Recipe> sideList = new List<Recipe>();
        public static List<Recipe> dessertList = new List<Recipe>();
        public static List<Recipe> snackList = new List<Recipe>();
        public static List<string> vsLinkList = new List<string>();
        public static List<string> addsIngList = new List<string>();
        public static List<string> addsAmtList = new List<string>();
        public static List<string> addsUnitList = new List<string>();

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
