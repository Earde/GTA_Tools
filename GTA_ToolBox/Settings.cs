using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace GTA_ToolBox
{
    class Settings
    {
        private readonly string fileName = "\\gtaToolSettings.json";

        public void Save(Form1 form)
        {
            Dictionary<string, string> keyValuePairs = new Dictionary<string, string>()
            {
                { "pss", form.pssTextbox.Text },
                { "ea", form.armorTextbox.Text },
                { "cm", form.mmiTextbox.Text },
                { "mech", form.mechTextbox.Text },
                { "mecht", form.mechTicksTextbox.Text },
                { "lester", form.lesterTextbox.Text },
                { "lestert", form.lesterTicksTextbox.Text }

            };
            string json = JsonConvert.SerializeObject(keyValuePairs);
            File.WriteAllText(Directory.GetCurrentDirectory() + fileName, json);
        }

        public void Load(Form1 form)
        {
            try
            {
                string json = File.ReadAllText(Directory.GetCurrentDirectory() + fileName);
                Dictionary<string, string> keyValuePairs = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);
                form.pssTextbox.Text = keyValuePairs["pss"];
                form.armorTextbox.Text = keyValuePairs["ea"];
                form.mmiTextbox.Text = keyValuePairs["cm"];
                form.mmiTicksTextbox.Text = keyValuePairs["cmt"];
                form.mechTextbox.Text = keyValuePairs["mech"];
                form.mechTicksTextbox.Text = keyValuePairs["mecht"];
                form.lesterTextbox.Text = keyValuePairs["lester"];
                form.lesterTicksTextbox.Text = keyValuePairs["lestert"];
            }
            catch { }
        }
    }
}
