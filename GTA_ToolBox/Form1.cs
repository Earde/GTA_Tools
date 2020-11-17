using Gma.System.MouseKeyHook;
using GTA_ToolBox.Actions;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace GTA_ToolBox
{
    public partial class Form1 : Form
    {
        private Process gta = null;
        private bool isCapturing = false;
        private System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        private Settings settings = new Settings();
        private Dictionary<TextBox, AbstractAction> textBoxActions = new Dictionary<TextBox, AbstractAction>();

        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            LoadActions();
            settings.Load(this, textBoxActions.Values.ToList());
            GetProcess(null, null);
            timer.Tick += new EventHandler(GetProcess);
            timer.Interval = 5000;
            timer.Start();
        }

        private void LoadActions()
        {
            textBoxActions.Add(pssTextbox, new SoloSessionAction(pssTextbox));
            textBoxActions.Add(armorTextbox, new ArmorAction(armorTextbox));
            textBoxActions.Add(mmiTextbox, new MMIAction(mmiTextbox, this.mmiTicksTextbox));
            textBoxActions.Add(mechTextbox, new MechanicAction(mechTextbox, this.mechTicksTextbox));
            textBoxActions.Add(lesterTextbox, new LesterAction(lesterTextbox, this.lesterTicksTextbox));
            textBoxActions.Add(killTextbox, new KillAction(killTextbox));
            textBoxActions.Add(killInternetTextbox, new Kill_InternetAction(killInternetTextbox));
            textBoxActions.Add(afkTextBox, new AFKAction(afkTextBox));
        }

        private void runButton_Click(object sender, EventArgs e)
        {
            if (!isCapturing)
            {
                try
                {
                    StartCapturing();
                    settings.Save(textBoxActions.Values.ToList());
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
            Dictionary<Combination, Action> assignments = new Dictionary<Combination, Action>();
            foreach (KeyValuePair<TextBox, AbstractAction> kv in textBoxActions)
            {
                assignments.Add(Combination.FromString(kv.Key.Text), () => kv.Value.Execute(gta));
                kv.Key.Enabled = false;
            }
            Hook.GlobalEvents().OnCombination(assignments);
            toolsLabel.Text = "Active";
            toolsLabel.ForeColor = Color.Green;
            isCapturing = true; // Prevent multiple capturing
            // Disable UI controls
            runButton.Enabled = false;
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
