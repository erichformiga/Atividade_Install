using System;
using System.Drawing;
using System.Windows.Forms;

namespace LoginProduto
{
    public partial class FormNome : Form
    {
        private Label nameLabel;
        private TextBox nameTextBox;
        private Button FechaButton;
        private Button OlaButton;
        private Button conexaoButton;

        public FormNome()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            // Configurações da janela do formulário
            this.ClientSize = new System.Drawing.Size(300, 400);
            this.Text = "Login";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;

            // Configurações do rótulo de nome de usuário
            nameLabel = new Label();
            nameLabel.Text = "Usuário:";
            nameLabel.Location = new Point(20, 30);
            nameLabel.Size = new Size(80, 20);
            this.Controls.Add(nameLabel);

            // Configurações do campo de texto de nome de usuário
            nameTextBox = new TextBox();
            nameTextBox.Location = new Point(100, 30);
            nameTextBox.Size = new Size(150, 20);
            this.Controls.Add(nameTextBox);

            // Configurações do botão de Fecha
            FechaButton = new Button();
            FechaButton.Text = "Fechar";
            FechaButton.Location = new Point(70, 100);
            FechaButton.Size = new Size(80, 30);
            FechaButton.Click += new EventHandler(Ola_Click);
            this.Controls.Add(FechaButton);

            
            // Configurações do botão de Olá
            OlaButton = new Button();
            OlaButton.Text = "Olá!!";
            OlaButton.Location = new Point(70, 250);
            OlaButton.Size = new Size(80, 30);
            OlaButton.Click += new EventHandler(Fechar_Click);
            this.Controls.Add(OlaButton);
        }
           

        private void Ola_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Você realmente deseja sair?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
                //Application.Exit();
            }

        }
       
        private void Fechar_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("Olá, " + this.nameTextBox.Text);
        }

    }

    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormNome());
        }
    }
}