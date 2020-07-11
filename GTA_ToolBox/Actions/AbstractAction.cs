using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTA_ToolBox.Actions
{
    abstract class AbstractAction
    {
        public string id, tickId;

        public AbstractAction(string id, string tickId = "none")
        {
            this.id = id;
            this.tickId = tickId;
        }

        protected abstract void InnerExecute(Process gta);

        public void Execute(Process gta)
        {
            if (gta != null && !gta.HasExited)
            {
                InnerExecute(gta);
            }
        }

        public abstract Dictionary<string, string> GetSavables(Form1 form);

        public void Load(Form1 form, string jsonId, string keys)
        {
            if (id.Equals(jsonId))
            {
                InnerLoad(form, keys);
            } else if (tickId.Equals(jsonId))
            {
                InnerTickLoad(form, keys);
            }
        }

        protected abstract void InnerLoad(Form1 form, string keys);
        protected abstract void InnerTickLoad(Form1 form, string keys);
    }
}
