using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaColaStefaniaM
{
    class Cola
    { 
        Nodo inicio;
    public void Encolar(Nodo unNodo)
    {
        if (inicio == null)
        {
            inicio = unNodo;
        }
        else
        {
            Nodo aux = Ultimo(inicio);
            aux.siguiente = unNodo;

        }
    }

    private Nodo Ultimo(Nodo unNodo)
    {
        if (unNodo.siguiente == null)
        {
            return unNodo;
        }
        else
        {
            return Ultimo(unNodo.siguiente);
        }
    }
    public void Desencolar()
    {
        inicio = inicio.siguiente;
    }

    public Nodo Inicio
    {
        get
        {
            return inicio;
        }

    }
    
    public bool Vacia ()
        {
            return (inicio == null);
        }

    }

}
