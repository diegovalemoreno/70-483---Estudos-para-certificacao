using System;
using System.Threading;
using System.Windows.Forms;
using static System.Environment;

namespace _1._1___UtilizandoThreadClass
{
    public partial class Form1 : Form
    {
        private new static string Text { get; set; }
        private static bool Tjoin { get; set; }
        private static bool IsBackground { get; set; }


        public Form1()
        {
            InitializeComponent();
        }

        public static void BusyWait()
        {
            for (int i = 0; i < 10; i++)
            {
                Text += NewLine + $"ThreadProc {i} ";
                var time  = " BusyWait " +  GetTime();
                //WriteToFile(time);
                Text += time;
            }
        }

        public static void ThreadStart()
        {
            Thread t = new Thread(BusyWait) {IsBackground = IsBackground};

            //for (var i = 0; i < 4; i++)
            //{
            //    Text += NewLine + "Execucao da Thread Principal.";
            //    Thread.Sleep(0);
            //}
            t.Start();
            if (Tjoin)
            {
                t.Join();
            }

            Text += NewLine + "Finalizando o processo." + NewLine;
            var time = "ThreadStart " + GetTime();
            //WriteToFile(time);
            Text += time;
        }

        void button1_Click(object sender, EventArgs e)
        {
            IsBackground = chkIsBackground.Checked;
            Tjoin = chkThreadJoin.Checked;
            ThreadStart();
            rtbThreadOutput.Text = Text;
        }

        private static string GetTime()
        {
            TimeSpan timeSpan = DateTime.Now.TimeOfDay;
            string schedule =
                $"{timeSpan.Days} day(s) {timeSpan.Hours} hour(s) {timeSpan.Minutes} minute(s) {timeSpan.Seconds} seconds(s)";

            return schedule;
        }
        //private static void WriteToFile(string text)
        //{
        //    string path = @"C:\temp\ServiceLog.txt";
        //    using (StreamWriter writer = new StreamWriter(path, true))
        //    {
        //        writer.WriteLine(text, DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt"));
        //        writer.Close();
        //    }
        //}

        private void cbClear_Click(object sender, EventArgs e)
        {
            rtbThreadOutput.Text = "";
        }
    }

}
