using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GTA_ToolBox.Actions
{
    class KillAction : AbstractAction
    {
        public KillAction(TextBox textBox) : base(textBox, "kill") { }

        public override Dictionary<string, string> GetSavables()
        {
            return base.GetSavables();
        }

        protected override void InnerExecute(Process gta)
        {
            gta.Kill();
        }

        protected override void InnerTickLoad(string keys)
        {
            throw new NotImplementedException();
        }
    }
}
