using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Escrito
{
    public partial class Form1 : Form
    {

        ArrayList Lista = new ArrayList();


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int anio = Convert.ToInt32(txtBox3.Text);
            MCQUEEN auto = new MCQUEEN(txtBox1.Text, txtBox2.Text, anio);

            listaBox.Items.Add(auto.Mostrar());

            Lista.Add(auto.Mostrar());

         
        }



        private void button1_Click_1(object sender, EventArgs e)
        {
            for (int x = 0; x < Lista.Count; x++)
            {
                listaBox.Items.Add(Lista[x]);
            }
        }

        private void boton3_Click(object sender, EventArgs e)
        {
         
            listaBox.Items.Remove(listaBox.SelectedItem);

            Lista.Remove(listaBox.SelectedItem);
           
        }
    }
}
