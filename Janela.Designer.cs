
namespace SADLAB1
{
    partial class Janela
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabVoltimetro = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.tabAmperimetro = new System.Windows.Forms.TabPage();
            this.tabEspectro = new System.Windows.Forms.TabPage();
            this.tabVCiclica = new System.Windows.Forms.TabPage();
            this.tabVOQuadrada = new System.Windows.Forms.TabPage();
            this.statusBarra = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuSair = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPorta = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBoxPorta = new System.Windows.Forms.ToolStripComboBox();
            this.menuVelocidade = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBoxVelocidade = new System.Windows.Forms.ToolStripComboBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.tabControl1.SuspendLayout();
            this.tabVoltimetro.SuspendLayout();
            this.statusBarra.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabVoltimetro);
            this.tabControl1.Controls.Add(this.tabAmperimetro);
            this.tabControl1.Controls.Add(this.tabEspectro);
            this.tabControl1.Controls.Add(this.tabVCiclica);
            this.tabControl1.Controls.Add(this.tabVOQuadrada);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabVoltimetro
            // 
            this.tabVoltimetro.BackColor = System.Drawing.SystemColors.Control;
            this.tabVoltimetro.Controls.Add(this.button1);
            this.tabVoltimetro.Controls.Add(this.checkBox2);
            this.tabVoltimetro.Controls.Add(this.checkBox1);
            this.tabVoltimetro.Location = new System.Drawing.Point(4, 25);
            this.tabVoltimetro.Name = "tabVoltimetro";
            this.tabVoltimetro.Padding = new System.Windows.Forms.Padding(3);
            this.tabVoltimetro.Size = new System.Drawing.Size(792, 421);
            this.tabVoltimetro.TabIndex = 0;
            this.tabVoltimetro.Text = "Voltímetro";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(56, 224);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 65);
            this.button1.TabIndex = 2;
            this.button1.Text = "Ler";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(49, 127);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(78, 21);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Canal 2";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(49, 39);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(78, 21);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Canal 1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // tabAmperimetro
            // 
            this.tabAmperimetro.BackColor = System.Drawing.SystemColors.Control;
            this.tabAmperimetro.Location = new System.Drawing.Point(4, 25);
            this.tabAmperimetro.Name = "tabAmperimetro";
            this.tabAmperimetro.Padding = new System.Windows.Forms.Padding(3);
            this.tabAmperimetro.Size = new System.Drawing.Size(792, 421);
            this.tabAmperimetro.TabIndex = 1;
            this.tabAmperimetro.Text = "Amperímetro";
            // 
            // tabEspectro
            // 
            this.tabEspectro.BackColor = System.Drawing.SystemColors.Control;
            this.tabEspectro.Location = new System.Drawing.Point(4, 25);
            this.tabEspectro.Name = "tabEspectro";
            this.tabEspectro.Padding = new System.Windows.Forms.Padding(3);
            this.tabEspectro.Size = new System.Drawing.Size(792, 421);
            this.tabEspectro.TabIndex = 2;
            this.tabEspectro.Text = "Espectrofotômetro";
            // 
            // tabVCiclica
            // 
            this.tabVCiclica.BackColor = System.Drawing.SystemColors.Control;
            this.tabVCiclica.Location = new System.Drawing.Point(4, 25);
            this.tabVCiclica.Name = "tabVCiclica";
            this.tabVCiclica.Padding = new System.Windows.Forms.Padding(3);
            this.tabVCiclica.Size = new System.Drawing.Size(792, 421);
            this.tabVCiclica.TabIndex = 3;
            this.tabVCiclica.Text = "Voltametria cíclica";
            // 
            // tabVOQuadrada
            // 
            this.tabVOQuadrada.BackColor = System.Drawing.SystemColors.Control;
            this.tabVOQuadrada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabVOQuadrada.Location = new System.Drawing.Point(4, 25);
            this.tabVOQuadrada.Name = "tabVOQuadrada";
            this.tabVOQuadrada.Padding = new System.Windows.Forms.Padding(3);
            this.tabVOQuadrada.Size = new System.Drawing.Size(792, 421);
            this.tabVOQuadrada.TabIndex = 4;
            this.tabVOQuadrada.Text = "Voltametria de Onda Quadrada";
            // 
            // statusBarra
            // 
            this.statusBarra.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.statusBarra.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusBarra.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusBarra.Location = new System.Drawing.Point(0, 424);
            this.statusBarra.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.statusBarra.Name = "statusBarra";
            this.statusBarra.Size = new System.Drawing.Size(800, 26);
            this.statusBarra.TabIndex = 1;
            this.statusBarra.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(151, 20);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(151, 20);
            this.toolStripStatusLabel2.Text = "toolStripStatusLabel2";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSair,
            this.menuPorta,
            this.menuVelocidade});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuSair
            // 
            this.menuSair.Name = "menuSair";
            this.menuSair.Size = new System.Drawing.Size(48, 24);
            this.menuSair.Text = "Sair";
            // 
            // menuPorta
            // 
            this.menuPorta.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comboBoxPorta});
            this.menuPorta.Name = "menuPorta";
            this.menuPorta.Size = new System.Drawing.Size(57, 24);
            this.menuPorta.Text = "Porta";
            // 
            // comboBoxPorta
            // 
            this.comboBoxPorta.Name = "comboBoxPorta";
            this.comboBoxPorta.Size = new System.Drawing.Size(121, 28);
            // 
            // menuVelocidade
            // 
            this.menuVelocidade.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comboBoxVelocidade});
            this.menuVelocidade.Name = "menuVelocidade";
            this.menuVelocidade.Size = new System.Drawing.Size(97, 24);
            this.menuVelocidade.Text = "Velocidade";
            // 
            // comboBoxVelocidade
            // 
            this.comboBoxVelocidade.Items.AddRange(new object[] {
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200",
            "230400",
            "250000"});
            this.comboBoxVelocidade.Name = "comboBoxVelocidade";
            this.comboBoxVelocidade.Size = new System.Drawing.Size(121, 28);
            // 
            // Janela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusBarra);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.tabControl1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Janela";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabVoltimetro.ResumeLayout(false);
            this.tabVoltimetro.PerformLayout();
            this.statusBarra.ResumeLayout(false);
            this.statusBarra.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabVoltimetro;
        private System.Windows.Forms.TabPage tabAmperimetro;
        private System.Windows.Forms.TabPage tabEspectro;
        private System.Windows.Forms.TabPage tabVCiclica;
        private System.Windows.Forms.TabPage tabVOQuadrada;
        private System.Windows.Forms.StatusStrip statusBarra;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ToolStripMenuItem menuSair;
        private System.Windows.Forms.ToolStripMenuItem menuPorta;
        private System.Windows.Forms.ToolStripComboBox comboBoxPorta;
        private System.Windows.Forms.ToolStripMenuItem menuVelocidade;
        private System.Windows.Forms.ToolStripComboBox comboBoxVelocidade;
    }
}

