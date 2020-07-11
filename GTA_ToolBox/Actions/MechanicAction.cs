using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GTA_ToolBox.Actions
{
    class MechanicAction : AbstractAction
    {
        TextBox tick;
        public MechanicAction(TextBox tick) : base("mechanic", tick.Name) {
            this.tick = tick;
        }

        public override Dictionary<string, string> GetSavables(Form1 form)
        {
            return new Dictionary<string, string> {
                {id, form.mechTextbox.Text },
                {tick.Name, tick.Text }
            };
        }

        protected override void InnerExecute(Process gta)
        {
            WindowsMessageService.SendSingleKey((short)DirectXKeys.ArrowUp, 1000);
            WindowsMessageService.SendSingleKey((short)DirectXKeys.ArrowUp, 250);
            WindowsMessageService.SendSingleKey((short)DirectXKeys.ArrowRight, 250);
            WindowsMessageService.SendSingleKey((short)DirectXKeys.Enter, 1000);
            int ticks;
            if (!int.TryParse(tick.Text, out ticks))
            {
                ticks = 1;
            }
            for (int i = 0; i < ticks; i++)
            {
                WindowsMessageService.SendSingleKey((short)DirectXKeys.ArrowUp, 250);
            }
            WindowsMessageService.SendSingleKey((short)DirectXKeys.Enter);
        }

        protected override void InnerLoad(Form1 form, string keys)
        {
            form.mechTextbox.Text = keys;
        }

        protected override void InnerTickLoad(Form1 form, string keys)
        {
            this.tick.Text = keys;
        }
    }
}
