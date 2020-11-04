using System;
using System.Collections;
using System.Net.Configuration;

namespace ColeccionesG4
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList coleccionDulces = new ArrayList(4);

            coleccionDulces.Add("Carlos V");
            coleccionDulces.Add("Tamborcito");
            coleccionDulces.Add("Mazapan");
            coleccionDulces.Add("Picafresas");

            coleccionDulces.Insert(2, "Totis");
            coleccionDulces.Insert(3, "Papas");
            coleccionDulces.Insert(4, "Paleta");
            coleccionDulces.Insert(5, "Bombón");
            coleccionDulces.Insert(6, "Boing");
            float precio = 22.5F;
            coleccionDulces.Add(precio);



            for (int i = 0; i < coleccionDulces.Count; i++)
            {
                if (i < coleccionDulces.Count - 1)
                {
                    Console.WriteLine("Dulces: {0}", coleccionDulces[i].ToString());
                }
                else
                {
                    precio = (float)coleccionDulces[i];
                    Console.WriteLine("IVA aplicadado al dulce es: ${0} ", precio * 0.16F);
                }               


            }




 /*         foreach (string dulce in coleccionDulces )
            {
                Console.WriteLine("Dulce: {0}", dulce);
            }
            Console.WriteLine(" Capacidad: {0} ", coleccionDulces.Capacity);
            Console.WriteLine("Indicando posición de dulce");
            int indice = coleccionDulces.IndexOf("Mazapan");
            Console.WriteLine("El Mazapan está en la posición: {0}",indice);
            coleccionDulces.RemoveAt(indice);
            foreach (string dulce in coleccionDulces)
            {
                Console.WriteLine("Dulce: {0}", dulce);
            }

            Console.WriteLine("Vaciando bolsa");
            coleccionDulces.Clear();
            Console.WriteLine("Cantidad de dulces:{0}", coleccionDulces.Count);
*/

        }
    }
}
