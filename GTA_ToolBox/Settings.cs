using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GTA_ToolBox.Actions;
using Newtonsoft.Json;

namespace GTA_ToolBox
{
    class Settings
    {
        private readonly string fileName = "\\gtaToolSettings.json";

        public void Save(List<AbstractAction> actions)
        {
            Dictionary<string, string> keyValuePairs = new Dictionary<string, string>();
            foreach (AbstractAction action in actions)
            {
                Dictionary<string, string> dict = action.GetSavables();
                foreach (KeyValuePair<string, string> keyValuePair in dict)
                {
                    keyValuePairs.Add(keyValuePair.Key, keyValuePair.Value);
                }
            }
            string json = JsonConvert.SerializeObject(keyValuePairs);
            File.WriteAllText(Directory.GetCurrentDirectory() + fileName, json);
        }

        public void Load(Form1 form, List<AbstractAction> actions)
        {
            try
            {
                string json = File.ReadAllText(Directory.GetCurrentDirectory() + fileName);
                Dictionary<string, string> keyValuePairs = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);
                foreach(KeyValuePair<string, string> keyValuePair in keyValuePairs)
                {
                    foreach (AbstractAction action in actions)
                    {
                        action.Load(keyValuePair.Key, keyValuePair.Value);
                    }
                }
            }
            catch { }
        }
    }
}
