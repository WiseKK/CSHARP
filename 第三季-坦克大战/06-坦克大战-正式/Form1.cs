using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06_坦克大战_正式
{
    public partial class Form1 : Form
    {
        private Thread t;
        private Graphics g;
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            g = this.CreateGraphics();
            GameFramework.g = g;

            t = new Thread(new ThreadStart(GameMainThread));//新线程
            t.Start();//线程启动了
        }

        private static void GameMainThread()
        {
            //GameFramework
            GameFramework.Start();
            int sleepTime = 1000 / 60;//保持60帧(有问题)
            while (true)
            {
                GameFramework.g.Clear(Color.Black);
                GameFramework.Update();
                Thread.Sleep(sleepTime);
            }
        }

        private void Form1_FormClosing (object sender, FormClosingEventArgs e)
        {
            t.Abort();
        }
    }
}
