using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CriptografiaCifraCesar
{
    public partial class JanelaCriptografia : Form
    {
        OpenFileDialog arquivo = new OpenFileDialog
        {
            Title = @"Abrir como",
            FileName = @"Nome Arquivo",
            Filter = @"Arquivos Textos (*.txt)|*.txt",
            InitialDirectory = @"C:\"

        };

        public JanelaCriptografia()
        {
            InitializeComponent();
        } 

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Encript_Click(object sender, EventArgs e)
        {
            //limpar a box do texto cifrado
            txtBoxEncripyt.Text = string.Empty;
            //Intera todas as letra do texto puro
            for (int i = 0; i < txtBoxN.Text.Length; i++)
            {
                //Devolve o código ASCII da letra
                int ASCII = (int)txtBoxN.Text[i];

                //Coloca a chave fixa de 10 posições a mais no número da tabela ASCII
                int ASCIIC = ASCII + 10;

                //Concatena o texto na caixa de texto do texto crifrado
                txtBoxEncripyt.Text += char.ConvertFromUtf32(ASCIIC);
            }
            txtBoxN.Clear();
            System.Windows.Forms.MessageBox.Show("Texto Criptografado");
        }

        private void btn_Decript_Click(object sender, EventArgs e)
        {
            //Limpa a caixa de texto decifrado (normal)
            txtBoxN.Text = string.Empty;
            //Intera todas as letras do texto cifrado
            for (int i = 0; i < txtBoxEncripyt.Text.Length; i++)
 
            {
                //Devolve o código ASCII da letra
                int ASCII = (int)txtBoxEncripyt.Text[i];

                //Coloca a chave fixa de 10 posições a menos no número da tabela ASCII
                int ASCIIC = ASCII - 10;

                //Concatena o texto na caixa de texto do texto decifrado
                txtBoxN.Text += char.ConvertFromUtf32(ASCIIC);
            }
            txtBoxEncripyt.Clear();
            System.Windows.Forms.MessageBox.Show("Texto Decriptografado");
        }


        private void bntEncArq_Click(object sender, EventArgs e)
        {
            string arquivo1 = System.IO.File.ReadAllText(arquivo.FileName);
            string encript = "";
            for (int i=0; i < arquivo1.Length; i++)
            {
                int ASCII = (int)arquivo1[i];
                int ASCIIC = ASCII + 10;
                encript += Char.ConvertFromUtf32(ASCIIC);
            }
            Console.Write(encript);
            StreamWriter arq = new StreamWriter(arquivo.FileName);
            arq.Write(encript);
            arq.Close();
            System.Windows.Forms.MessageBox.Show("Arquivo Criptografado");
        }

        private void btnDecArq_Click(object sender, EventArgs e)
        {
            string arquivo1 = System.IO.File.ReadAllText(arquivo.FileName);
            string encript = "";
            for (int i = 0; i < arquivo1.Length; i++)
            {
                int ASCII = (int)arquivo1[i];
                int ASCIIC = ASCII - 10;
                encript += Char.ConvertFromUtf32(ASCIIC);
            }
            Console.Write(encript);
            StreamWriter arq = new StreamWriter(arquivo.FileName);
            arq.Write(encript);
            arq.Close();
            System.Windows.Forms.MessageBox.Show("Arquivo Decriptografado");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCarrega_Click(object sender, EventArgs e)
        {
            arquivo.ShowDialog();
            textBoxArq.Text = arquivo.FileName;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}