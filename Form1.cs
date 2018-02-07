using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoPedraPapelTesoura
{
    public partial class Form1 : Form
    {
        enum Opcoes { Pedra, Papel, Tesoura };
        Opcoes jogador = new Opcoes();


        public Form1()
        {
            InitializeComponent();
        }

        private void botaoPedra_Click(object sender, EventArgs e)
        {
            jogador = Opcoes.Pedra;
            EscolhaJogador();
        }

        private void botaoPapel_Click(object sender, EventArgs e)
        {
            jogador = Opcoes.Papel;
        }

        private void botaoTesoura_Click(object sender, EventArgs e)
        {
            jogador = Opcoes.Tesoura;
        }

        void EscolhaJogador()
        {
            switch (jogador)
            {
                case Opcoes.Pedra:
                    ImgEscolhaJogador.BackgroundImage = Image.FromFile("c:/OneDrive");
                    break;
            }
        }
    }
}
