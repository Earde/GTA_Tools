using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GTA_ToolBox.Actions
{
    class LesterAction : AbstractAction
    {
        TextBox tick;
        public LesterAction(TextBox textBox, TextBox tick) : base(textBox, "lester", tick.Name) {
            this.tick = tick;
        }

        public override Dictionary<string, string> GetSavables()
        {
            Dictionary<string, string> output =  base.GetSavables();
            output.Add(tick.Name, tick.Text);
            return output;
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

        protected override void InnerTickLoad(string keys)
        {
            this.tick.Text = keys;
        }
    }
}
