using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTA_ToolBox.Actions
{
    class KillAction : AbstractAction
    {
        public KillAction() : base("kill") { }

        public override Dictionary<string, string> GetSavables(Form1 form)
        {
            return new Dictionary<string, string> {
                { id, form.killTextbox.Text }
            };
        }

        protected override void InnerExecute(Process gta)
        {
            gta.Kill();
        }

        protected override void InnerLoad(Form1 form, string keys)
        {
            form.killTextbox.Text = keys;
        }

        protected override void InnerTickLoad(Form1 form, string keys)
        {
            throw new NotImplementedException();
        }
    }
}
