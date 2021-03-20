using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;


namespace SADLAB1
{
    public partial class Janela : Form
    {
        private ToolStripComboBox portaSelecionada;
        private readonly SerialPort conectorSerial;
        readonly Color Vermelho = Color.Red;
        readonly Color Verde = Color.DarkGreen;
        private readonly string diretorioInicial = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        public Janela()
        {
            InitializeComponent();
            toolStripStatusLabel1.ForeColor = Vermelho;
            toolStripStatusLabel1.Text = "Porta fechada";
            toolStripStatusLabel2.Text = "";
            string[] portas = SerialPort.GetPortNames();
            foreach (string porta in portas)
            {
                ToolStripComboBox portaSel = new ToolStripComboBox(porta);
                comboBoxPorta.Items.Add(porta);
                if (comboBoxPorta.SelectedItem == null)
                {
                    comboBoxPorta.SelectedIndex = 0;
                }
            }
            portaSelecionada = (ToolStripComboBox)comboBoxPorta.SelectedItem;
            if (comboBoxVelocidade.SelectedItem == null)
            {
                comboBoxVelocidade.SelectedIndex = 1;
            }
            int velSelecionada = (int)comboBoxVelocidade.SelectedItem;


        }

    }
}
