using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GTA_ToolBox.Actions
{
    class Kill_InternetAction : AbstractAction
    {
        public Kill_InternetAction(TextBox textBox) : base(textBox, "killInternet") { }

        public override Dictionary<string, string> GetSavables()
        {
            return base.GetSavables();
        }

        protected override void InnerExecute(Process gta)
        {
            DisableAdapter();
            Thread.Sleep(5000);
            EnableAdapter();

        }

        private static void EnableAdapter()
        {
            Process.Start("ipconfig", "/renew");
        }

        private static void DisableAdapter()
        {
            Process.Start("ipconfig", "/release");
        }

        protected override void InnerTickLoad(string keys)
        {
            throw new NotImplementedException();
        }
    }
}
