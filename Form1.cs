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
        private List<Candidatos> candidatos = new List<Candidatos>();

        public Form1()
        {
            InitializeComponent();
            var breno = new Candidatos(13,"Breno");
            var larissa = new Candidatos(25, "Larissa");
            var armando = new Candidatos(52, "Armando");
            candidatos.Add(breno);
            candidatos.Add(larissa);
            candidatos.Add(armando);
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
            var votado = candidatos.FindAll(c => c.numero.ToString() == candidatoVotado);
            if (votado.Count > 0)
            {
                visor.Text = "Voto : " + votado[0].nome;
                visor.Text += " VOTO COMPUTADO !!!";
            }
            else
                Console.WriteLine(visor.Text = "Voto inválido");

            aTimer.Dispose();
            //visor.Text = "Digite o número do candidato \n\r";

        }
        private static void SetTimer()
        {
            // Create a timer with a two second interval.
            aTimer = new System.Timers.Timer(2000);
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


