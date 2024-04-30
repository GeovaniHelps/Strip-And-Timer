using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmProgramas : Form
    {
        public frmProgramas()
        {
            InitializeComponent();
        }

        private void menusair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void wordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            prcExecultador.StartInfo.FileName = "C:\\Program Files (x86)\\Microsoft Office\\Office14\\WinWord.Exe";
            prcExecultador.Start();
        }

        private void excelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            prcExecultador.StartInfo.FileName = "C:\\Program Files (x86)\\Microsoft Office\\Office14\\excel.Exe";
            prcExecultador.Start();
        }

        private void calculadorasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            prcExecultador.StartInfo.FileName = "C:\\Windows\\system32\\calc.exe";
            prcExecultador.Start();
        }

        private void frmProgramas_Load(object sender, EventArgs e)
        {
            tspMessage.Text = "Ola eu sou goku";
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tspData.Text = DateTime.Now.ToString("dd/MM/yyyy");
            tspHora.Text = DateTime.Now.ToString("HH:mm:ss");



        }

        private void prcExecultador_Exited(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
