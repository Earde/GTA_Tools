using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GTA_ToolBox.Actions
{
    class ArmorAction : AbstractAction
    {
        public ArmorAction(TextBox textBox) : base(textBox, "armor") { }

        public override Dictionary<string, string> GetSavables()
        {
            return base.GetSavables();
        }

        protected override void InnerExecute(Process gta)
        {
            WindowsMessageService.SendSingleKey((short)DirectXKeys.M);
            WindowsMessageService.SendSingleKey((short)DirectXKeys.KeyDown);
            WindowsMessageService.SendSingleKey((short)DirectXKeys.KeyDown);
            WindowsMessageService.SendSingleKey((short)DirectXKeys.KeyDown);
            WindowsMessageService.SendSingleKey((short)DirectXKeys.Enter);
            WindowsMessageService.SendSingleKey((short)DirectXKeys.KeyDown);
            WindowsMessageService.SendSingleKey((short)DirectXKeys.Enter);
            WindowsMessageService.SendSingleKey((short)DirectXKeys.KeyDown);
            WindowsMessageService.SendSingleKey((short)DirectXKeys.KeyDown);
            WindowsMessageService.SendSingleKey((short)DirectXKeys.KeyDown);
            WindowsMessageService.SendSingleKey((short)DirectXKeys.KeyDown);
            WindowsMessageService.SendSingleKey((short)DirectXKeys.Enter);
            WindowsMessageService.SendSingleKey((short)DirectXKeys.Escape);
            WindowsMessageService.SendSingleKey((short)DirectXKeys.Escape);
            WindowsMessageService.SendSingleKey((short)DirectXKeys.Escape);
        }

        protected override void InnerTickLoad(string keys)
        {
            throw new NotImplementedException();
        }
    }
}
