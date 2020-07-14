using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GTA_ToolBox.Actions
{
    class Kill_Internet : AbstractAction
    {
        public Kill_Internet() : base("killInternet") { }

        public override Dictionary<string, string> GetSavables(Form1 form)
        {
            return new Dictionary<string, string> {
                { id, form.killInternetTextbox.Text }
            };
        }

        protected override void InnerExecute(Process gta)
        {
            Process.Start("ipconfig", "/release");
            Thread.Sleep(10000);
            Process.Start("ipconfig", "/renew");
        }

        protected override void InnerLoad(Form1 form, string keys)
        {
            form.killInternetTextbox.Text = keys;
        }

        protected override void InnerTickLoad(Form1 form, string keys)
        {
            throw new NotImplementedException();
        }
    }
}
