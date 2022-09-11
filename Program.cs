using System;

namespace tp1
{
    class Program
    {
        static void Main (string [] args)
        {
            ArbolBinario<int> a1 = new ArbolBinario<int>(4);
            ArbolBinario<int> b1 = new ArbolBinario<int>(3);
            ArbolBinario<int> b2 = new ArbolBinario<int>(2);
            ArbolBinario<int> c3 = new ArbolBinario<int>(1);
            ArbolBinario<int> c2 = new ArbolBinario<int>(5);


            a1.agregarHijoIzquierdo(b1);
            a1.agregarHijoDerecho(b2);
            b2.agregarHijoDerecho(c3);
            b2.agregarHijoIzquierdo(c2);

            a1.preorden();
            Console.WriteLine("");
            a1.inorden();
            Console.WriteLine("");
            Console.WriteLine(a1.contarHojas());
            a1.recorridoEntreNiveles();
        }
    }
}