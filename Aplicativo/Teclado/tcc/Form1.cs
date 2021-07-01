using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace tcc
{
    public partial class FrmTeclado : Form
    {
        List<string> lstPalavras = null;
        public FrmTeclado()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {

            // implementação dos métodos p executar as sinteses

            // instanciar a classe criada 

            Fala Speech = Fala.getInstance(ref btnExecutar);

            Speech.Velocidade = (int)tkbVelocidade.Value;

            Speech.Volume = (int)tkbVolume.Value;


            // executar a sintese de voz

            Speech.Falar(CaixaTexto.Text);

        }

        private void btnBotao_Click(object sender, EventArgs e)
        {

            if(!(sender is Button)) return;

            var btn = (Button)sender;
            CaixaTexto.Text = CaixaTexto.Text + btn.Text;

            verificarLista();
        }

        private void verificarLista()
        {
            string digitado = CaixaTexto.Text;
            var resultado = lstPalavras.Where(o => o.StartsWith(digitado.ToLower())).OrderBy(p => p.Length).ThenBy(o => o).ToList();
            if (resultado.Count > 0)
            {
                // Tem alguém
                while (resultado.Count > 3) resultado.RemoveAt(resultado.Count - 1);
                lblPrevisao.Text = string.Join(" ", resultado);
            }
            else
            {
                // Não tem
                lblPrevisao.Text = "Não sei =(";
            }
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            CaixaTexto.Text = CaixaTexto.Text + "A";
        }

        private void btnS_Click(object sender, EventArgs e)
        {
            CaixaTexto.Text = CaixaTexto.Text + "S";
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            CaixaTexto.Text = CaixaTexto.Text + "D";
        }

        private void btnF_Click(object sender, EventArgs e)
        {
            CaixaTexto.Text = CaixaTexto.Text + "F";
        }

        private void btnG_Click(object sender, EventArgs e)
        {
            CaixaTexto.Text = CaixaTexto.Text + "G";
        }

        private void btnH_Click(object sender, EventArgs e)
        {
            CaixaTexto.Text = CaixaTexto.Text + "H";
        }

        private void btnJ_Click(object sender, EventArgs e)
        {
            CaixaTexto.Text = CaixaTexto.Text + "J";
        }

        private void btnK_Click(object sender, EventArgs e)
        {
            CaixaTexto.Text = CaixaTexto.Text + "K";
        }

        private void btnL_Click(object sender, EventArgs e)
        {
            CaixaTexto.Text = CaixaTexto.Text + "L";
        }

        private void btnÇ_Click(object sender, EventArgs e)
        {
            CaixaTexto.Text = CaixaTexto.Text + "Ç";
        }

        private void btnZ_Click(object sender, EventArgs e)
        {
            CaixaTexto.Text = CaixaTexto.Text + "Z";
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            CaixaTexto.Text = CaixaTexto.Text + "X";
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            CaixaTexto.Text = CaixaTexto.Text + "C";
        }

        private void btnV_Click(object sender, EventArgs e)
        {
            CaixaTexto.Text = CaixaTexto.Text + "V";
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            CaixaTexto.Text = CaixaTexto.Text + "B";
        }

        private void btnN_Click(object sender, EventArgs e)
        {
            CaixaTexto.Text = CaixaTexto.Text + "N";
        }

        private void btnM_Click(object sender, EventArgs e)
        {
            CaixaTexto.Text = CaixaTexto.Text + "M";
        }

        private void button27_Click(object sender, EventArgs e)
        {
            CaixaTexto.Text = CaixaTexto.Text + ",";
        }

        private void button28_Click(object sender, EventArgs e)
        {
            CaixaTexto.Text = CaixaTexto.Text + ".";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CaixaTexto.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CaixaTexto.Text = CaixaTexto.Text.Remove(CaixaTexto.Text.Length - 1, 1);
        }


        // mudar cor botao - timer

        private void Form1_Load(object sender, EventArgs e)
        {
            Timer Tempo = new Timer();
            Tempo.Interval = 20000;
            Tempo.Tick += new EventHandler(timer1_Tick);
            Tempo.Start();

            var linhas = Resource1.dicionario.ToLower().Replace("\r", "").Split('\n');
            lstPalavras = new List<string>(linhas);
        }

        

        private void timer1_Tick(object sender, EventArgs e)
        {
   
            toolStripStatusLabel1.Text = System.DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CaixaTexto.Text = CaixaTexto.Text + Environment.NewLine;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmSplash novo = new FrmSplash();
            novo.Show(); 
        }


        private void button5_Click(object sender, EventArgs e)
        {
            CaixaTexto.Text = CaixaTexto.Text + "7"; 
        }

        private void button6_Click(object sender, EventArgs e)
        {
            CaixaTexto.Text = CaixaTexto.Text + "8"; 
        }

        private void button7_Click(object sender, EventArgs e)
        {
            CaixaTexto.Text = CaixaTexto.Text + "9"; 
        }

        private void button8_Click(object sender, EventArgs e)
        {
            CaixaTexto.Text = CaixaTexto.Text + "4"; 
        }

        private void button9_Click(object sender, EventArgs e)
        {
            CaixaTexto.Text = CaixaTexto.Text + "5"; 
        }

        private void button10_Click(object sender, EventArgs e)
        {
            CaixaTexto.Text = CaixaTexto.Text + "6"; 
        }

        private void button11_Click(object sender, EventArgs e)
        {
            CaixaTexto.Text = CaixaTexto.Text + "1"; 
        }

        private void button12_Click(object sender, EventArgs e)
        {
            CaixaTexto.Text = CaixaTexto.Text + "2"; 
        }

        private void button13_Click(object sender, EventArgs e)
        {
            CaixaTexto.Text = CaixaTexto.Text + "3"; 
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            CaixaTexto.Text = CaixaTexto.Text + "0"; 
        }

        private void btnSPACE_Click(object sender, EventArgs e)
        {
            CaixaTexto.Text = CaixaTexto.Text + " "; 
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            FrmPrinc Principal = new FrmPrinc();
            Principal.Show(); 
        }

       
    }
}
