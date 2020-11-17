using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GTA_ToolBox.Actions
{
    class AFKAction : AbstractAction
    {
        private bool AFK = false;

        public AFKAction(TextBox textBox) : base(textBox, "afk") { }

        public override Dictionary<string, string> GetSavables()
        {
            return base.GetSavables();
        }

        protected override void InnerExecute(Process gta)
        {
            if (AFK) WindowsMessageService.SendKey((short)DirectXKeys.CapsLock, KeyFlag.KeyDown);
            else WindowsMessageService.SendKey((short)DirectXKeys.CapsLock, KeyFlag.KeyUp);
            AFK = !AFK;
        }

        protected override void InnerTickLoad(string keys)
        {
            throw new NotImplementedException();
        }
    }
}
