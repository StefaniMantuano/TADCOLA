using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaColaStefaniaM
{
    public partial class Form1 : Form
    {
        Cola cola = new Cola();
        public Form1()
        {
            InitializeComponent();
        }

        private void bEncolar_Click(object sender, EventArgs e)
        {
            if (txtNombreNodo.Text.Length ==0)
            {
                MessageBox.Show("Debe ingresar un nombre de nodo: ");
            }
            else
            {
                Nodo nuevoNodo = new Nodo();
                nuevoNodo.Nombre = txtNombreNodo.Text;
                cola.Encolar(nuevoNodo);
                MostrarCola();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cola.Vacia()) 
            {
                MessageBox.Show("La cola esta vacia");
            }
            else
            {
                cola.Desencolar();
                MostrarCola();
            } 
        }

         private void MostrarCola()
        {
            lstCola.Items.Clear();
            MostrarNodos(cola.Inicio);

        }




        private void MostrarNodos(Nodo unNodo)
        {
            if ( unNodo != null)
            {
                lstCola.Items.Add(unNodo.Nombre);
            
             if ( unNodo.siguiente != null)
            {
                MostrarNodos(unNodo.siguiente);
            }
        }
 
     }
  }
}