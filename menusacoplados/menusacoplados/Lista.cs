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
        private Nodo primero = new Nodo();

        private Nodo ultimo= new Nodo();

        public Lista()
        {
            primero = null;
            ultimo = null;
        }
        public void insertarNodo(int dato)
        { 
            Nodo nuevo = new Nodo(); 
            nuevo.dato = dato; 
            if (primero == null) 
            { primero = nuevo; 
                primero.siguiente = primero; 
                ultimo = primero; 
            } 
            else 
            { 
                ultimo.siguiente = nuevo; 
                nuevo.siguiente = primero;
                ultimo = nuevo; 
            } 
        }

        public void verLista(TextBox lista) 
        { 
            Nodo actual = new Nodo(); 
            actual = primero; 
            if (actual != null) 
            { 
                do 
                { 
                    lista.Text += actual.dato + " -> "; 
                    actual = actual.siguiente; 
                } 
                while (actual != primero); 
            } 
            else 
            { 
                MessageBox.Show("Lista vacia"); 
            } 
        }

        public void buscarNodo(int dato)
        {
            Nodo actual = new Nodo(); 
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
            Nodo actual = new Nodo(); 
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
            Nodo actual = new Nodo(); 
            actual = primero; 
            Nodo anterior = new Nodo();
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
