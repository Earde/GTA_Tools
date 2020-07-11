using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTA_ToolBox.Actions
{
    class ArmorAction : AbstractAction
    {
        public ArmorAction() : base("armor") { }

        public override Dictionary<string, string> GetSavables(Form1 form)
        {
            return new Dictionary<string, string> {
                { id, form.armorTextbox.Text }
            };
        }

        protected override void InnerExecute(Process gta)
        {
            WindowsMessageService.SendSingleKey((short)DirectXKeys.M);
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

        protected override void InnerLoad(Form1 form, string keys)
        {
            form.armorTextbox.Text = keys;
        }

        protected override void InnerTickLoad(Form1 form, string keys)
        {
            throw new NotImplementedException();
        }
    }
}
