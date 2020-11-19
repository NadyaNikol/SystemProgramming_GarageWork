using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarLibrary;

namespace WFormGarage
{
    delegate void SetFuncThreadDel();
    public partial class Form1 : Form
    {
        object obj = new object();
        object obj2 = new object();

        Bus Bus1 = new Bus(30, 400, 10, 40);
        Truck truck1 = new Truck(20, 300, 100, 400);

        SetFuncThreadDel[] dels = new SetFuncThreadDel[4];

        System.Windows.Forms.Timer time = new System.Windows.Forms.Timer();

        public Form1()
        {
            InitializeComponent();

            time.Interval = 1000;
            time.Start();
            time.Tick += Time_Tick;


            Task task1 = new Task(() => BusUp());
            Task task2 = new Task(() => BusDown());

            task1.Start();
            task2.Start();


            lblAmountPass.Text = Bus1.Passengers.ToString();
            lblСargo.Text = truck1.Cargo.ToString();

        }

        private void Time_Tick(object sender, EventArgs e)
        {
            lblAmountPass.Text = Bus1.Passengers.ToString();
        }

        private void BusUp()
        {
            while (true)
            {
                lock (obj)
                    Bus1.Up();

                Thread.Sleep(100);
            }
        }

        private void BusDown()
        {
            while (true)
            {
                lock (obj2)
                    Bus1.Down();

                Thread.Sleep(100);
            }
        }     

        private void button1_Click(object sender, EventArgs e)
        {
            truck1.Up();
            lblСargo.Text = truck1.Cargo.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            truck1.Down();
            lblСargo.Text = truck1.Cargo.ToString();
        }

    }
}
