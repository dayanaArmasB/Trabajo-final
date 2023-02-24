using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace menusacoplados
{
    internal class Lista2
    {
        private Nodo2 primero = new Nodo2();

        private Nodo2 ultimo= new Nodo2();

        public Lista2()
        {
            primero = null;
            ultimo = null;
        }
        public void insertar(int dato)
        { 
            Nodo2 nuevo = new Nodo2(); 
            nuevo.dato = dato; 
            if (primero == null) 
            { primero = nuevo; 
                primero.siguiente = null;
                primero.atras = null;
                ultimo = primero; 
            } 
            else 
            { 
                ultimo.siguiente = nuevo; 
                nuevo.siguiente = null;
                nuevo.atras = ultimo;
                ultimo = nuevo; 
            } 
        }

        public void verListaID(ListBox lista, TextBox lista2) 
        { 
            Nodo2 actual = new Nodo2(); 
            actual = primero; 
            while(actual != null)
            {
                lista.Items.Add(actual.dato);
                lista2.Text += actual.dato + " -->";
                actual = actual.siguiente;
            }
            
        }
        public void verListaDI(ListBox lista, TextBox lista2)
        {
            Nodo2 actual = new Nodo2();
            actual = ultimo;
            while (actual != null)
            {
                lista.Items.Add(actual.dato);
                lista2.Text += actual.dato + " -->";
                actual = actual.atras;
            }

        }


        public void buscarNodo(int dato)
        {
            Nodo2 actual = new Nodo2(); 
            actual = primero;
            bool encontrado = false; 
            int buscado = dato; 
            if (actual != null) 
            { 
                do 
                { 
                    if 
                        (actual.dato == buscado) 
                    { 
                        MessageBox.Show("Nodo " + buscado + " encontrado"); 
                        encontrado = true; 
                    } 
                    actual = actual.siguiente; 
                } 
                while (actual != primero); 
                if (encontrado == false) 
                    MessageBox.Show(buscado + " No está en la lista"); 
            } 
            else 
            { 
                MessageBox.Show("Lista vacia"); 
            }
        }

        public void modificarNodo(int dato1, int dato2) 
        { 
            Nodo2 actual = new Nodo2(); 
            actual = primero; 
            bool encontrado = false; 
            int buscado = dato1; 
            if (actual != null) 
            { 
                do 
                { 
                    if (actual.dato == buscado) 
                    { MessageBox.Show("Nodo " + buscado + " encontrado"); 
                        actual.dato = dato2; 
                        encontrado = true; 
                        MessageBox.Show("Nodo modificado"); 
                    } 
                    actual = actual.siguiente; 
                } while (actual != primero); 
                if (encontrado == false) 
                    MessageBox.Show(buscado + " No está en la lista"); 
            } 
            else 
            { 
                MessageBox.Show("Lista vacia"); 
            } 
        }

        public void eliminarNodo(int dato)
        {
            Nodo2 actual = new Nodo2(); 
            actual = primero; 
            Nodo2 anterior = new Nodo2();
            bool encontrado = false;
            int buscado = dato; 
            if (actual != null) 
            { 
                do 
                { 
                    if (actual.dato == buscado) 
                    { 
                        MessageBox.Show("Nodo " + buscado + " encontrado"); 
                        if (actual == primero) 
                        { 
                            primero = primero.siguiente; 
                            ultimo.siguiente = primero; 
                        } 
                        else 
                        if (actual == ultimo) 
                        {
                            anterior.siguiente = primero; 
                            ultimo = anterior; 
                        } 
                        else 
                        { 
                            anterior.siguiente = actual.siguiente; 
                        } 
                        MessageBox.Show("Nodo eliminado"); 
                        encontrado = true; 
                    } 
                    anterior = actual; 
                    actual = actual.siguiente; 
                } 
                while (actual != primero); 
                if (encontrado == false) 
                    MessageBox.Show(buscado + " No está en la lista"); 
            } 
            else 
            { 
                MessageBox.Show("Lista vacia"); 
            }
        }
    }
}
