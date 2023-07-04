using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace NazmoxKeyPresser
{
    public class Config
    {
        public List<Keys> Keys= new List<Keys>();
        public int Mintime { get; set; }
        public int Maxtime { get; set; }
        public Config(List<Keys> keys, int mintime, int maxtime)
        {
            List<Keys> curentlist = new List<Keys>();
            foreach (var item in keys)
            {
                curentlist.Add(item);
            }
            this.Mintime = mintime;
            this.Maxtime = maxtime;
            Keys = curentlist;
        }
        public Config()
        {
            List<Keys> keys = new List<Keys>();
            foreach (var item in keys)
            {
                Keys.Add(item);
            }
            this.Mintime = 300;
            this.Maxtime = 500;
        }


        public static Keys ConvertToKey(string keyString)
        {
            try
            {
                Keys key = (Keys)Enum.Parse(typeof(Keys), keyString);
                Console.WriteLine("The parsed key is: " + key);
                return key;
            }
            catch (ArgumentException)
            {
                throw new Exception("Invalid key string.");
            }
        }


        //Első sorba kerül a min és a max value
        public void CreateBasicConfig() {
            string jsonString = JsonConvert.SerializeObject(this);

            // Write JSON to a file
            File.WriteAllText("config.json", jsonString);

            Console.WriteLine("config.json file created successfully.");
        }
        public Config LoadConfig()
        {
            // Read JSON from a file
            string jsonString = File.ReadAllText("config.json");

            // Deserialize JSON to object
            Config config = JsonConvert.DeserializeObject<Config>(jsonString);
            return config;
        }
        public void Save(List<Keys> keys,int mintime, int maxtime)
        {
            this.Mintime = mintime;
            this.Maxtime = maxtime;
            this.Keys = keys;
            string jsonString = JsonConvert.SerializeObject(this);

            // Write JSON to a file
            File.WriteAllText("config.json", jsonString);

            Console.WriteLine("config.json file updated successfully.");

        }
    }
}
