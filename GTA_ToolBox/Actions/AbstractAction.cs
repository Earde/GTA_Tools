using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GTA_ToolBox.Actions
{
    abstract class AbstractAction
    {
        public string id, tickId;
        public TextBox textBox;

        public AbstractAction(TextBox tb, string id, string tickId = "none")
        {
            this.id = id;
            this.tickId = tickId;
            this.textBox = tb;
        }

        protected abstract void InnerExecute(Process gta);

        public void Execute(Process gta)
        {
            if (gta != null && !gta.HasExited)
            {
                InnerExecute(gta);
            }
        }

        public virtual Dictionary<string, string> GetSavables()
        {
            return new Dictionary<string, string>
            {
                { id, textBox.Text }
            };
        }

        public void Load(string jsonId, string keys)
        {
            if (id.Equals(jsonId))
            {
                InnerLoad(keys);
            } else if (tickId.Equals(jsonId))
            {
                InnerTickLoad(keys);
            }
        }

        protected void InnerLoad(string keys)
        {
            textBox.Text = keys;
        }
        protected abstract void InnerTickLoad(string keys);
    }
}
