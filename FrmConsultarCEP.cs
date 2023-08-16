namespace ConsultarCEP
{
    public partial class FrmConsultarCEP : Form
    {


        public FrmConsultarCEP()
        {
            InitializeComponent();
        }




        private void InitializeComponent()
        {
            label1 = new Label();
            btnCEP = new Button();
            groupBox1 = new GroupBox();
            txtLogradouro = new TextBox();
            label5 = new Label();
            txtBairro = new TextBox();
            label4 = new Label();
            txtCidade = new TextBox();
            label3 = new Label();
            txtEstado = new TextBox();
            label2 = new Label();
            txtCEP = new TextBox();
            btnLimpar = new Button();
            btnSair = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 0;
            label1.Text = "CEP:";
            // 
            // btnCEP
            // 
            btnCEP.BackgroundImage = Properties.Resources.logo;
            btnCEP.BackgroundImageLayout = ImageLayout.Stretch;
            btnCEP.Location = new Point(184, 12);
            btnCEP.Name = "btnCEP";
            btnCEP.Size = new Size(159, 42);
            btnCEP.TabIndex = 1;
            btnCEP.TextImageRelation = TextImageRelation.TextAboveImage;
            btnCEP.UseVisualStyleBackColor = true;
            btnCEP.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtLogradouro);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtBairro);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtCidade);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtEstado);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 54);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(349, 211);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Resultado";
            // 
            // txtLogradouro
            // 
            txtLogradouro.Location = new Point(6, 182);
            txtLogradouro.Name = "txtLogradouro";
            txtLogradouro.Size = new Size(325, 23);
            txtLogradouro.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 164);
            label5.Name = "label5";
            label5.Size = new Size(72, 15);
            label5.TabIndex = 9;
            label5.Text = "Logradouro:";
            // 
            // txtBairro
            // 
            txtBairro.Location = new Point(6, 132);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(325, 23);
            txtBairro.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 114);
            label4.Name = "label4";
            label4.Size = new Size(41, 15);
            label4.TabIndex = 7;
            label4.Text = "Bairro:";
            label4.Click += label4_Click;
            // 
            // txtCidade
            // 
            txtCidade.Location = new Point(6, 85);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(325, 23);
            txtCidade.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 67);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 5;
            label3.Text = "Cidade:";
            // 
            // txtEstado
            // 
            txtEstado.Location = new Point(6, 37);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(325, 23);
            txtEstado.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 19);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 1;
            label2.Text = "Estado:";
            // 
            // txtCEP
            // 
            txtCEP.BackColor = SystemColors.Info;
            txtCEP.Location = new Point(12, 25);
            txtCEP.Name = "txtCEP";
            txtCEP.Size = new Size(100, 23);
            txtCEP.TabIndex = 3;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(195, 272);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(75, 23);
            btnLimpar.TabIndex = 4;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnSair
            // 
            btnSair.Location = new Point(286, 272);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(75, 23);
            btnSair.TabIndex = 5;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // FrmConsultarCEP
            // 
            ClientSize = new Size(373, 307);
            Controls.Add(btnSair);
            Controls.Add(btnLimpar);
            Controls.Add(txtCEP);
            Controls.Add(groupBox1);
            Controls.Add(btnCEP);
            Controls.Add(label1);
            Name = "FrmConsultarCEP";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if( string.IsNullOrEmpty( txtCEP.Text ))
            {
                MessageBox.Show("Informe um CEP válido!", Text, MessageBoxButtons.OK);
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private Label label1;
        private Button btnCEP;
        private TextBox txtLogradouro;
        private Label label5;
        private TextBox txtBairro;
        private Label label4;
        private TextBox txtCidade;
        private Label label3;
        private TextBox txtEstado;
        private Label label2;
        private TextBox txtCEP;
        private Button btnLimpar;
        private Button btnSair;
        private GroupBox groupBox1;

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtBairro.Text = string.Empty;
            txtCidade.Text = string.Empty;
            txtEstado.Text = string.Empty;
            txtCEP.Text = string.Empty;
            txtLogradouro.Text = string.Empty;
        }   
    }
}