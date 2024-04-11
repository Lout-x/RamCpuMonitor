using System;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Linq;

namespace RamCpuMonitor
{
    public partial class Main : Form
    {
        string fname = string.Empty;
        private int processId;

        public Main()
        {
            InitializeComponent();
        }

        private void processLoader_Click(object sender, EventArgs e)
        {
            //Инициализация загрузки процессов в комбобокс
            processname.Items.Clear();
            if (pid.Checked != true)
            {
                //грузим по имени
                Process[] allProc = Process.GetProcesses();
                foreach (Process p in allProc)
                {
                    processname.Items.Add(p.ProcessName);
                }
            }
            else
            {
                //грузим по PID
                Process[] allProc = Process.GetProcesses();
                foreach (Process p in allProc)
                {
                    processname.Items.Add(p.Id);
                }
            }
            
        }

        private void processName_TextChanged(object sender, EventArgs e)
        {
            //При изменении текста в текстбоксе запрашиваем у системы текущее значение использования ОЗУ
            if (pid.Checked)
                processId = Int32.Parse(processname.Text);
            else
                processId = Process.GetProcessesByName(processname.Text).First().Id;

            realtimememory.Text = (Process.GetProcessById(processId).WorkingSet64 / 1024).ToString() + "KB";
        }

        private void start_Click(object sender, EventArgs e)
        {
            //Запуск мониторинга, создание текстового файла для логирования
            if (timers.Text != "" && processname.Text != "") 
            {
                string stmon = "Monitoring started success!\nMonitoring timeout (sec): "+timers.Text;
                pid.Enabled = false;
                timers.Enabled = false;
                fname = "monitoring_process_" + processname.Text + ".log";
                StreamWriter monfile = new StreamWriter(fname);
                monfile.WriteLine(stmon);
                monfile.Close();
                start.Enabled = false;
                montime.Start();
            }
            
            else
            {
                MessageBox.Show("error");
                start.Enabled = true;
            }
        }

        private void monTime_Tick(object sender, EventArgs e)
        {
            //Инициализация таймера для мониторинга и передача ему значения в мс
            int inter = Int32.Parse(timers.Text) * 1000;
            montime.Interval = inter;
            WriteFunc();
            
        }

        public void WriteFunc()
        {
            //Запись в файл при разных условиях (PID либо имя процесса)
            var process = Process.GetProcessById(processId);
            process.Refresh();

            float workingSet = process.WorkingSet64 / 1024;
            float allocatedMemory = process.PrivateMemorySize64 / 1024;

            var counter = new PerformanceCounter("Process", "Working Set - Private", process.ProcessName);
            float activeMemory = counter.NextValue() / 1024;
            counter.Close();
            counter.Dispose();

            realtimememory.Text = (process.WorkingSet64 / 1024).ToString() + "KB";
            ftime.Text = DateTime.Now.ToString();
            StreamWriter sw = new StreamWriter(fname, true);
            sw.WriteLineAsync($"Process {process.ProcessName} ({process.Id}): Memory {realtimememory.Text} {DateTime.Now}");
            sw.WriteLineAsync($"workingSet = {workingSet}, allocatedMemory = {allocatedMemory}, activeMemory = {activeMemory}\n");
            sw.Close();
        }


        public void StopMonit()
        {
            //Останавливает мониторинг за процессом
            string stmon = "---> Monitoring End <---";
            montime.Enabled = false;
            StreamWriter monfile = new StreamWriter(fname, true);
            monfile.WriteLineAsync(stmon);
            monfile.Close();
            pid.Enabled = true;
            timers.Enabled = true;
            start.Enabled = true;
        }

        private void stopmon_Click(object sender, EventArgs e)
        {
            StopMonit();
        }
    }
}
