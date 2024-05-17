using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace Urna_Eletronica
{
    public partial class Form1 : Form
    {
        private String candidatoVotado;
        private static System.Timers.Timer aTimer;
        
        public Form1()
        {
            InitializeComponent();
            visor.Text = "Digite o número do candidato \n\r";
        }

        private void visor_TextChanged(object sender, EventArgs e)
        {

        }
        private void bt1_Click(object sender, EventArgs e)
        {
            visor.Text += "1";
            candidatoVotado += "1";
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            visor.Text += "2";
            candidatoVotado += "2";

        }

        private void bt3_Click(object sender, EventArgs e)
        {
            visor.Text += "3";
            candidatoVotado += "3";
        }

        private void bt4_Click(object sender, EventArgs e)
        {
            visor.Text += "4";
            candidatoVotado += "4";
        }

        private void bt5_Click(object sender, EventArgs e)
        {
            visor.Text += "5";
            candidatoVotado += "5";
        }

        private void bt6_Click(object sender, EventArgs e)
        {
            visor.Text += "6";
            candidatoVotado += "6";
        }

        private void bt7_Click(object sender, EventArgs e)
        {
            visor.Text += "7";
            candidatoVotado += "7";
        }

        private void bt8_Click(object sender, EventArgs e)
        {
            visor.Text += "8";
            candidatoVotado += "8";
        }

        private void bt9_Click(object sender, EventArgs e)
        {
            visor.Text += "9";
            candidatoVotado += "9";
        }

        private void bt0_Click(object sender, EventArgs e)
        {
            visor.Text += "0";
            candidatoVotado += "0";
        }

        private void nulo_Click(object sender, EventArgs e)
        {
            visor.Text = "Voto Anulado";
            candidatoVotado = "nulo";
            
        }

        private void cancela_Click(object sender, EventArgs e)
        {
            visor.Text = "Digite o número do candidato \n\r";
            candidatoVotado = "";
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            SetTimer();
            visor.Text = "Voto : " + candidatoVotado;
            visor.Text = "/n/n VOTO COMPUTADO !!!";
            
            aTimer.Dispose();
            visor.Text = "Digite o número do candidato \n\r";

        }
        private static void SetTimer()
        {
            // Create a timer with a two second interval.
            aTimer = new System.Timers.Timer(20000);
            // Hook up the Elapsed event for the timer. 
            aTimer.Elapsed += OnTimedEvent;
            aTimer.AutoReset = true;
            aTimer.Enabled = true;
        }
        private static void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            Console.WriteLine("The Elapsed event was raised at {0:HH:mm:ss.fff}",
                              e.SignalTime);
        }
    }
}


