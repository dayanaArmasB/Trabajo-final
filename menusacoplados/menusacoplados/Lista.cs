using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace menusacoplados
{
    internal class Lista
    {
        private NodoList primero = new NodoList();
        private NodoList ultimo = new NodoList();

        public Lista()
        {
            primero = null;
            ultimo = null;
        }
        public void insertar(string persona)
        {
            NodoList nuevo = new NodoList();
            nuevo.Persona = persona;
            if (primero == null)
            {
                primero = nuevo;
                primero.Siguiente = primero;
                ultimo = primero;
            }
            else
            {
                ultimo.Siguiente = nuevo;
                nuevo.Siguiente = primero;
                ultimo = nuevo;
            }

        }
        public void verlista(TextBox lista)
        {
            NodoList actual = new NodoList();
            actual = primero;
            if (actual != null)
            {
                do
                {
                    lista.Text += actual.Persona + "->";
                    actual = actual.Siguiente;
                } while (actual != primero);
            }
            else
            {
                MessageBox.Show("Lista vacia", "Lista", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        public void buscar(string dato)
        {
            NodoList actual = new NodoList();
            actual = primero;
            bool flag = false;
            string valBuscado = dato;
            if (actual != null)
            {
                do
                {
                    if (actual.Persona == valBuscado)
                    {
                        MessageBox.Show(valBuscado + "esta en la lista", "Lista", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        flag = true;
                    }
                    actual = actual.Siguiente;
                } while (actual != primero);
                if (flag == false)

                    MessageBox.Show(valBuscado + " no esta en la lista", "Lista", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                MessageBox.Show("Lista vacia", "Lista", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void modificar(string persona1, string persona2)
        {
            NodoList actual = new NodoList();
            actual = primero;
            bool flag = false;
            string valBuscado = persona1;
            if (actual != null)
            {
                do
                {
                    if (actual.Persona == valBuscado)
                    {
                        MessageBox.Show(valBuscado + "se ha MODIFICADO", "Lista", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        flag = true;
                        actual.Persona = persona2;
                    }
                    actual = actual.Siguiente;
                } while (actual != primero);
                if (flag == false)
                    MessageBox.Show(valBuscado + "No esta en la lista ", "Lista", MessageBoxButtons.OK, MessageBoxIcon.Information);

                else
                {

                    MessageBox.Show("Lista Vacia ", "Lista", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }
        public void eliminar(string persona)
        {
            NodoList actual = new NodoList();
            actual = primero;
            NodoList anterior = new NodoList();
            bool encontrado = false;
            string buscado = persona;
            if (actual != null)
            {
                do
                {
                    if (actual.Persona == buscado)
                    {
                        MessageBox.Show("Nodo " + buscado + " encontrado");
                        if (actual == primero)
                        {
                            primero = primero.Siguiente; ultimo.Siguiente = primero;
                        }
                        else
                        if (actual == ultimo)
                        {
                            anterior.Siguiente = primero;
                            ultimo = anterior;
                        }
                        else { anterior.Siguiente = actual.Siguiente; }
                        MessageBox.Show("Nodo eliminado"); encontrado = true;
                    }
                    anterior = actual; actual = actual.Siguiente;
                } while (actual != primero);
                if (encontrado == false)
                {
                    MessageBox.Show(buscado + " No está en la lista");
                }
                else
                {
                    MessageBox.Show("Lista vacia");
                }
            }
        }
    }
}
