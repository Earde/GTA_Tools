using Gma.System.MouseKeyHook;
using GTA_ToolBox.Actions;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace GTA_ToolBox
{
    public partial class Form1 : Form
    {
        private Process gta = null;
        private bool isExecuting = false, isCapturing = false;
        private System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        private Settings settings = new Settings();
        private List<AbstractAction> actions = new List<AbstractAction>();

        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            LoadActions();
            settings.Load(this, actions);
            GetProcess(null, null);
            timer.Tick += new EventHandler(GetProcess);
            timer.Interval = 5000;
            timer.Start();
        }

        private void LoadActions()
        {
            actions.Add(new SoloSessionAction());
            actions.Add(new ArmorAction());
            actions.Add(new MMIAction(this.mmiTicksTextbox));
            actions.Add(new MechanicAction(this.mechTicksTextbox));
            actions.Add(new LesterAction(this.lesterTicksTextbox));
            actions.Add(new KillAction());
        }

        private void runButton_Click(object sender, EventArgs e)
        {
            if (!isCapturing)
            {
                try
                {
                    StartCapturing();
                    settings.Save(this, actions);
                }
                catch
                {
                    statusLabel.ForeColor = Color.Red;
                    toolsLabel.Text = "ERROR!";
                }
            }
        }

        private void StartCapturing()
        {
            var assignments = new Dictionary<Combination, Action>
            {
                {Combination.FromString(pssTextbox.Text), () => actions[0].Execute(gta)},
                {Combination.FromString(armorTextbox.Text), () => actions[1].Execute(gta)},
                {Combination.FromString(mmiTextbox.Text), () => actions[2].Execute(gta)},
                {Combination.FromString(mechTextbox.Text), () => actions[3].Execute(gta)},
                {Combination.FromString(lesterTextbox.Text), () => actions[4].Execute(gta)},
                {Combination.FromString(killTextbox.Text), () => actions[5].Execute(gta)}
            };
            Hook.GlobalEvents().OnCombination(assignments);
            toolsLabel.Text = "Active";
            toolsLabel.ForeColor = Color.Green;
            isCapturing = true; // Prevent multiple capturing
            // Disable UI controls
            runButton.Enabled = false;
            pssTextbox.Enabled = false;
            armorTextbox.Enabled = false;
            mmiTextbox.Enabled = false;
            mmiTicksTextbox.Enabled = false;
            mechTextbox.Enabled = false;
            mechTicksTextbox.Enabled = false;
            lesterTextbox.Enabled = false;
            lesterTicksTextbox.Enabled = false;
            killTextbox.Enabled = false;
        }

        void GetProcess(object sender, EventArgs ea)
        {
            Process[] processes = Process.GetProcessesByName("gta5");
            if (processes.Length > 0)
            {
                gta = processes[0];
            }
            if (gta == null || gta.HasExited)
            {
                gta = null;
                statusLabel.Text = "Inactive";
                statusLabel.ForeColor = Color.Red;
            }
            else
            {
                statusLabel.Text = "Active";
                statusLabel.ForeColor = Color.Green;
            }
        }
    }
}
