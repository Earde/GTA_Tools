using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GTA_ToolBox.Actions
{
    class SoloSessionAction : AbstractAction
    {
        public SoloSessionAction() : base("soloSession") { }

        public override Dictionary<string, string> GetSavables(Form1 form)
        {
            return new Dictionary<string, string> {
                { id, form.pssTextbox.Text }
            };
        }

        protected override void InnerLoad(Form1 form, string keys)
        {
            form.pssTextbox.Text = keys;
        }

        protected override void InnerExecute(Process gta)
        {
            ProcessExtension.Suspend(gta);
            Thread.Sleep(15000);
            ProcessExtension.Resume(gta);
        }

        protected override void InnerTickLoad(Form1 form, string keys)
        {
            throw new NotImplementedException();
        }
    }
}
