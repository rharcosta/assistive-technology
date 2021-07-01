using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace tcc
{
    public partial class FrmPrinc : Form
    {
        public FrmPrinc()
        {
            InitializeComponent();
        }

        private void fecharToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair?", "Aguardando resposta", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                this.Close();
            }
          
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = System.DateTime.Now.ToLongTimeString();
            toolStripStatusLabel3.Text = System.DateTime.Now.ToLongDateString();
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Calc.exe");
        }

        private void windowsExplorerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Explorer.exe");
        }

        private void internetExploresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("IExplore.exe");
        }

        private void editorDeTextoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("WinWord.exe");
        }

        private void tecladoAssistivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTeclado Teclado = new FrmTeclado();
            Teclado.Show();
        }

       
        private void calendárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCalendario Calendario = new FrmCalendario();
            Calendario.Show();

        }

        private void sobreOSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSistema Sistema = new FrmSistema();
            Sistema.Show(); 
        }

        private void sobreOsProgramadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProgramadores Programadores = new FrmProgramadores();
            Programadores.Show(); 
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
