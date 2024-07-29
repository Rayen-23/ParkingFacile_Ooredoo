using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ParkingFacile
{
    [Serializable]
    internal class Check
    {
       public String Username { get; set; }
        public String payer {  get; set; }
        public void Save (String filePath)
        {
            using (FileStream fs = new FileStream(filePath, FileMode.Create))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fs, this);
            }
        }
        public static Check Load(String filePath)
        {
            if(!File.Exists(filePath))
                return new Check();
            using (FileStream fs = new FileStream(filePath, FileMode.Open))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                return (Check)formatter.Deserialize(fs);
            }
        }
    }
}
