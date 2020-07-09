using Gma.System.MouseKeyHook;
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

        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            settings.Load(this);
            GetProcess(null, null);
            timer.Tick += new EventHandler(GetProcess);
            timer.Interval = 5000;
            timer.Start();
        }

        private void runButton_Click(object sender, EventArgs e)
        {
            if (!isCapturing)
            {
                try
                {
                    StartCapturing();
                    settings.Save(this);
                } catch
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
                {Combination.FromString(pssTextbox.Text), PrivateSoloSession},
                {Combination.FromString(armorTextbox.Text), EquipArmor},
                {Combination.FromString(mmiTextbox.Text), CallMMI},
                {Combination.FromString(mechTextbox.Text), CallMechanic},
                {Combination.FromString(lesterTextbox.Text), CallLester}
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
            } else
            {
                statusLabel.Text = "Active";
                statusLabel.ForeColor = Color.Green;
            }
        }

        void PrivateSoloSession()
        {
            if (gta != null && !gta.HasExited && !isExecuting)
            {
                isExecuting = true;
                ProcessExtension.Suspend(gta);
                Thread.Sleep(15000);
                ProcessExtension.Resume(gta);
                isExecuting = false;
            }
        }

        void EquipArmor()
        {
            if (gta != null && !gta.HasExited && !isExecuting)
            {
                isExecuting = true;
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
                isExecuting = false;
            }
        }

        void CallMMI()
        {
            int ticks;
            if (!int.TryParse(mmiTicksTextbox.Text, out ticks))
            {
                ticks = 1;
            }
            CallPerson(ticks);
        }

        void CallMechanic()
        {
            int ticks;
            if (!int.TryParse(mechTicksTextbox.Text, out ticks))
            {
                ticks = 1;
            }
            CallPerson(ticks);
        }

        void CallLester()
        {
            int ticks;
            if (!int.TryParse(lesterTicksTextbox.Text, out ticks))
            {
                ticks = 1;
            }
            CallPerson(ticks);
        }

        void CallPerson(int ticks)
        {
            if (gta != null && !gta.HasExited && !isExecuting)
            {
                isExecuting = true;
                WindowsMessageService.SendSingleKey((short)DirectXKeys.ArrowUp, 1000);
                WindowsMessageService.SendSingleKey((short)DirectXKeys.ArrowUp, 250);
                WindowsMessageService.SendSingleKey((short)DirectXKeys.ArrowRight, 250);
                WindowsMessageService.SendSingleKey((short)DirectXKeys.Enter, 1000);
                for (int i = 0; i < ticks; i++)
                {
                    WindowsMessageService.SendSingleKey((short)DirectXKeys.ArrowUp, 250);
                }
                WindowsMessageService.SendSingleKey((short)DirectXKeys.Enter);
                isExecuting = false;
            }
        }
    }
}
