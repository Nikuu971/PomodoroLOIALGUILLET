using System;
using System.Timers;
using System.Windows.Forms;

namespace pomodoro_Final
{
    public partial class Form1 : Form
    {
        System.Timers.Timer t;
        bool Marche = false;
        int m, s;
        int NbrPomodo=0;
        int NbrPause=0;
        bool DebutCycle = true;
        bool pauseSwitch = false;
        string tag;
        ListViewItem listTag;
        int NbrCycle = 0;

        public Form1()
        {
            InitializeComponent();
            t = new System.Timers.Timer();
            t.Interval = 1000;
            t.Elapsed += OnTimeEvent;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            t = new System.Timers.Timer();
            t.Interval = 1000;
            t.Elapsed += OnTimeEvent;
        }



        private void OnTimeEvent(object sender, ElapsedEventArgs e)
        {
            Invoke(new Action(() =>
            {
                if (DebutCycle)
                {
                    Init();
                    DebutCycle = false;
                }

                s -= 1;
                if (s < 0)
                {
                    s = 59;
                    m -= 1;
                }

                if (m == 0 && s==0)
                {
                    DebutCycle = true;
                    pauseSwitch = EnPause();
                    t.Stop();
                }
                txtResult.Text = string.Format("{0}:{1}", m.ToString().PadLeft(2, '0'), s.ToString().PadLeft(2, '0'));
            }));
        }

        public void Init()
        {
            if(!pauseSwitch)
            {
                m = 25;
                s = 1;
                NbrPomodo += 1;
            }
            if(pauseSwitch)
            {
                m = 5;
                s = 1;
                pauseSwitch = false;
                NbrPause += 1;
            }
            if(NbrPomodo>4)
            {
                m = 15;
                s = 1;
                NbrPomodo = 0;
                NbrCycle += 1;
                if (m == 0 && s == 0)
                {
                    Reset();
                }
            }
            
        }
        public bool EnPause()
        {
            if(NbrPause==NbrPomodo)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            if (!Marche)
            {
                listTag = new ListViewItem();
                tag = tagTxtBox.Text;
                label3.Text = tagTxtBox.Text;
                tagTxtBox.Text = "";
                Marche = true;
                Console.WriteLine(listTag);
                listeview.Items.Add(listTag);
            }
            t.Start();
        }


        private void StopBtn_Click_1(object sender, EventArgs e)
        {
            Marche = false;
            t.Stop();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            t.Stop();
            Application.DoEvents();
        }

        void Reset()
        {
            m = 0;
            s = 0;
            NbrPomodo = 0;
            NbrPause = 0;
            DebutCycle = true;
            pauseSwitch = false;
            t.Stop();
            txtResult.Text = "00:00";
        }

        private void Hrst_Click(object sender, EventArgs e)
        {
            
            Reset();
            
        }

        private void tagTxtBox_TextChanged(object sender, EventArgs e)
        {
            // Method intentionally left empty.
        }

        private void StopBtn_Click(object sender, EventArgs e)
        {
            // Method intentionally left empty.
        }

        //private void Rst_Click(object sender, EventArgs e)
        //{
        //    if(EnPause())
        //    {
        //        m = 5;
        //        s = 1;
        //        t.Stop();
        //        txtResult.Text = "00:00";
        //    }
        //    if(!EnPause())
        //    {
        //        m = 25;
        //        s = 1;
        //        t.Stop();
        //        txtResult.Text = "00:00";
        //    }
        //    if (NbrPomodo > 4)
        //    {
        //        m = 15;
        //        s = 1;
        //        t.Stop();
        //        txtResult.Text = "00:00";
        //    }
        //}
    }
}
