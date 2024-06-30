using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Newtonsoft.Json;
using System.Threading.Tasks;
using VanDerBrinckesBakfietsenVerdieping.Models;

namespace VanDerBrinckesBakfietsenVerdieping
{
    public class Serialization
    {
        public void SaveToJson(VanDerBrinckesModel verhuurBedrijf)
        {
            using (FileStream file = new FileStream(@"C:\Users\npere\source\Fontys\Software\VanDerBrinckesBakfietsenVerdieping\VerhuurObjecten.json.txt", FileMode.OpenOrCreate, FileAccess.Write))
            {
                using (StreamWriter writer = new StreamWriter(file))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    serializer.Serialize(writer, verhuurBedrijf);
                }
            }
        }

        public void CallFromJson(VanDerBrinckesModel verhuur)
        {

            using (FileStream file = new FileStream(@"C:\Users\npere\source\Fontys\Software\VanDerBrinckesBakfietsenVerdieping\VerhuurObjecten.json.txt", FileMode.Open, FileAccess.Read))
            {
                using (StreamReader reader = new StreamReader(file))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    verhuur = serializer.Deserialize(reader, typeof(VanDerBrinckesModel)) as VanDerBrinckesModel;
                }
            }
        }
    }
}
