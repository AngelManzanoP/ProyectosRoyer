using System.Collections;

namespace piedra_Papel_o_Tijera
{
    public partial class Form1 : Form
    {


        jugador j=new jugador();
        

  


        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (comboBox1.SelectedItem)
            {
                case "piedra":
                    pictureBox1.Image = Properties.Resources.piedra;
                    break;
                case "tijera":
                    pictureBox1.Image = Properties.Resources.tijera;
                    break;
                case "papel":
                    pictureBox1.Image = Properties.Resources.papel;
                    break;
                default:
                    pictureBox1.Image = null;
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            maquina tiraPiedra = new piedra();
            maquina tiraPapel = new papel();
            maquina tiraTijera = new tijera();
            Dictionary <maquina,maquina> jugadas=new Dictionary<maquina,maquina>();
            jugadas.Add(tiraTijera, tiraTijera);
            jugadas.Add(tiraPapel,tiraPapel);
            jugadas.Add(tiraPiedra,tiraPiedra);
            foreach(var i in jugadas.Keys)
            {
                textBox1.Text=i.tirar();
            }


            if(comboBox1.SelectedItem="piedra" && textBox1.Text = "papel")
            {
                MessageBox.Show("GANA JUGADOR");
            }
            else if(comboBox1.SelectedItem="papel" && textBox1.Text = "tijera")
            {
                MessageBox.Show("GANA MAQUINA");
            }

            MessageBox.Show("GANA JUGADOR");
        }
    }
}

