using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace menusacoplados
{
    internal class Bicola
    {
        NodoBicola primero, ultimo;
        public void EncolarDerecha(int valor)
        {
            NodoBicola nuevo = new NodoBicola(valor, primero, ultimo);
            nuevo.dato = valor;
            if (primero == null)
            {
                primero = nuevo;
                primero.anterior = null;
                primero.siguiente = null;
                ultimo = primero;
            }
            else
            {
                ultimo.siguiente = nuevo;
                nuevo.siguiente = null;
                nuevo.anterior = ultimo;
                ultimo = nuevo;
            }
        }
        public void EncolarIzquierda(int valor)
        {
            NodoBicola nuevo = new NodoBicola(valor, primero, ultimo);
            nuevo.dato = valor;
            if (primero == null)
            {
                primero = nuevo;
                primero.anterior = null;
                primero.siguiente = null;
                ultimo = primero;
            }
            else
            {
                primero.anterior = nuevo;
                nuevo.anterior = null;
                nuevo.siguiente = primero;
                primero = nuevo;
            }
        }
        public void verBicola(TextBox bicola)
        {
            NodoBicola actual = primero;
            while (actual != null)
            {
                bicola.Text += actual.dato + " <=> ";
                actual = actual.siguiente;
            }
        }
        public void buscar(int valor)
        {
            NodoBicola actual = primero;
            bool flag = false;
            while (actual != null && flag == false)
            {
                if (actual.dato == valor)
                {
                    flag = true;
                    MessageBox.Show(valor + " está en la bicola", "Bicolas",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                actual = actual.siguiente;
            }
            if (flag == false)
                MessageBox.Show(valor + " NO está en la bicola", "Bicolas",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public void modificar(int valor, int nuevo)
        {
            NodoBicola actual = primero;
            bool flag = false;
            while (actual != null && flag == false)
            {
                if (actual.dato == valor)
                {
                    flag = true;
                    actual.dato = nuevo;
                    MessageBox.Show("Se actualizó la bicola", "Bicolas",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                actual = actual.siguiente;
            }
            if (flag == false)
                MessageBox.Show(valor + " NO está en la bicola", "Bicolas",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public void desencolarD()
        {
            ultimo.anterior.siguiente = null;
            ultimo = ultimo.anterior;
        }
        public void desencolarI()
        {
            primero.siguiente.anterior = null;
            primero = primero.siguiente;
        }
    }
}
