using System;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;

namespace ChangeIPDcom
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] list_device;
        private void btn_GetDevice_Click(object sender, EventArgs e)
        {
            try
            {
          

                this.data_ListDevice.DataSource = null;
                this.data_ListDevice.Rows.Clear();
                this.data_ListDevice.Columns.Clear();
                this.data_ListDevice.Refresh();
            }
            catch { }

            try
            {
                this.cb_ListDevice.Items.Clear();
            }
            catch { }
            

            var p = Process.Start(
             new ProcessStartInfo("rasdial")
             {
                 CreateNoWindow = true,
                 UseShellExecute = false,
                 RedirectStandardError = true,
                 RedirectStandardOutput = true,
                 WorkingDirectory = Environment.CurrentDirectory
             });

            p.WaitForExit();
            string branchName = p.StandardOutput.ReadToEnd().TrimEnd();
            string errorInfoIfAny = p.StandardError.ReadToEnd().TrimEnd();

            if (errorInfoIfAny.Length != 0)
            {
                MessageBox.Show($"error: {errorInfoIfAny}");
            }
            else
            {
                list_device = branchName.Split('\n');
                try
                {
                    list_device = list_device.Where(o => o != "Connected to").ToArray();
                }
                catch (Exception ex)
                {
                    try
                    {
                        list_device = list_device.Where(o => o != "No connections").ToArray();
                    }
                    catch
                    {
                    }
                }

                list_device = list_device.Where(o => o != "Command completed successfully.").ToArray();
            }

            if (list_device.Length > 0)
            {
                BindingSource bs = new BindingSource();
                bs.DataSource = list_device;
                cb_ListDevice.DataSource = bs;


                data_ListDevice.Columns.Add("Device", "Device");
                data_ListDevice.Columns.Add("Ip", "Ip");
            }




        }

        private void btn_ChangeIP_Click(object sender, EventArgs e)
        {
            string selected = this.cb_ListDevice.GetItemText(this.cb_ListDevice.SelectedItem);
            if (selected == "No connections") { MessageBox.Show("Not found device"); }
            else {
                if (selected != null)
                {
                    // disconnect
                    string disconnect_command = $"rasdial {selected} /disconnect";
                    // connect
                    string connect_commnad = $"rasdial {selected}";

                    System.Diagnostics.Process process = new System.Diagnostics.Process();
                    System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                    startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                    startInfo.FileName = "cmd.exe";
                    startInfo.Arguments = "/C  " + disconnect_command;
                    process.StartInfo = startInfo;
                    process.Start();



                    System.Diagnostics.Process _process = new System.Diagnostics.Process();
                    System.Diagnostics.ProcessStartInfo _startInfo = new System.Diagnostics.ProcessStartInfo();
                    _startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                    _startInfo.FileName = "cmd.exe";
                    _startInfo.Arguments = "/C  " + connect_commnad;
                    _process.StartInfo = _startInfo;
                    _process.Start();

                    MessageBox.Show("Success");
                    // run disconnect 
                    //var disconnect = Process.Start(
                    // new ProcessStartInfo(disconnect_command)
                    // {
                    //     CreateNoWindow = true,
                    //     UseShellExecute = false,
                    //     RedirectStandardError = true,
                    //     RedirectStandardOutput = true,
                    //     WorkingDirectory = Environment.CurrentDirectory
                    // });

                    //disconnect.WaitForExit();
                    //string branchName_disconnect = disconnect.StandardOutput.ReadToEnd().TrimEnd();
                    //string errorInfoIfAny_disconnect = disconnect.StandardError.ReadToEnd().TrimEnd();

                    //if (errorInfoIfAny_disconnect.Length != 0)
                    //{
                    //    MessageBox.Show($"error: {errorInfoIfAny_disconnect}");
                    //}
                    //else{
                    //MessageBox.Show($"{branchName_disconnect}");
                    //}


                    //// run reconnect
                    //var reconnect = Process.Start(
                    //new ProcessStartInfo(connect_commnad)
                    //{
                    //    CreateNoWindow = true,
                    //    UseShellExecute = false,
                    //    RedirectStandardError = true,
                    //    RedirectStandardOutput = true,
                    //    WorkingDirectory = Environment.CurrentDirectory
                    //});

                    //reconnect.WaitForExit();
                    //string branchName_reconnect = reconnect.StandardOutput.ReadToEnd().TrimEnd();
                    //string errorInfoIfAny_reconnect = reconnect.StandardError.ReadToEnd().TrimEnd();

                    //if (errorInfoIfAny_reconnect.Length != 0)
                    //{
                    //    MessageBox.Show($"error: {errorInfoIfAny_reconnect}");
                    //}
                    //else
                    //{
                    //    MessageBox.Show($"{branchName_reconnect}");
                    //}

                }
            }
            
        }
    }
}


