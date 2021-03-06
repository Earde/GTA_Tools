﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GTA_ToolBox.Actions
{
    class SoloSessionAction : AbstractAction
    {
        public SoloSessionAction(TextBox textBox) : base(textBox, "soloSession") { }

        public override Dictionary<string, string> GetSavables()
        {
            return base.GetSavables();
        }

        protected override void InnerExecute(Process gta)
        {
            ProcessExtension.Suspend(gta);
            Thread.Sleep(15000);
            ProcessExtension.Resume(gta);
        }

        protected override void InnerTickLoad(string keys)
        {
            throw new NotImplementedException();
        }
    }
}
