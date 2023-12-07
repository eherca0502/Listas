using All_List.Clases.Listas;
using System;

namespace Listas.Clases
{
    public class Auto
    {
        public void Auto_Add_SimpleList(SimpleList lista, Random R)
        {
            Console.Write("Cuantos datos quieres añadir: ");
            int cant = int.Parse(Console.ReadLine());
            for (int i = 0; i < cant; i++)
            {
                lista.Add(R.Next(25));
            }
            lista.Show();
        }

        public void Auto_Delete_SimpleList(SimpleList lista, Random R)
        {
            Console.Write("Cuantos datos quieres borrar: ");
            int cant = int.Parse(Console.ReadLine());
            for (int i = 0; i < cant; i++)
            {
                lista.Delete(R.Next(25));
            }
            lista.Show();
        }

        public void Auto_Search_SimpleList(SimpleList lista, Random R)
        {
            Console.Write("Cuantos datos quieres buscar: ");
            int cant = int.Parse(Console.ReadLine());
            for (int i = 0; i < cant; i++)
            {
                lista.Search(R.Next(25));
            }
        }

        public void Auto_Add_CircularList(CircularList lista, Random R)
        {
            Console.Write("Cuantos datos quieres añadir: ");
            int cant = int.Parse(Console.ReadLine());
            for (int i = 0; i < cant; i++)
            {
                lista.Add(R.Next(25));
            }
            lista.Show();
        }

        public void Auto_Delete_CircularList(CircularList lista, Random R)
        {
            Console.Write("Cuantos datos quieres borrar: ");
            int cant = int.Parse(Console.ReadLine());
            for (int i = 0; i < cant; i++)
            {
                lista.Delete(R.Next(25));
            }
            lista.Show();
        }

        public void Auto_Search_CircularList(CircularList lista, Random R)
        {
            Console.Write("Cuantos datos quieres buscar: ");
            int cant = int.Parse(Console.ReadLine());
            for (int i = 0; i < cant; i++)
            {
                lista.Search(R.Next(25));
            }
        }

        public void Auto_Add_DoublyListLinked(DoublyListLinked lista, Random R)
        {
            Console.Write("Cuantos datos quieres añadir: ");
            int cant = int.Parse(Console.ReadLine());
            for (int i = 0; i < cant; i++)
            {
                lista.Add(R.Next(25));
            }
            lista.Show();
        }

        public void Auto_Delete_DoublyListLinked(DoublyListLinked lista, Random R)
        {
            Console.Write("Cuantos datos quieres borrar: ");
            int cant = int.Parse(Console.ReadLine());
            for (int i = 0; i < cant; i++)
            {
                lista.Delete(R.Next(25));
            }
            lista.Show();
        }

        public void Auto_Search_DoublyListLinked(DoublyListLinked lista, Random R)
        {
            Console.Write("Cuantos datos quieres buscar: ");
            int cant = int.Parse(Console.ReadLine());
            for (int i = 0; i < cant; i++)
            {
                lista.Search(R.Next(25));
            }
        }

        public void Auto_Add_CircularDoublyLinkedList(CircularDoublyLinkedList lista, Random R)
        {
            Console.Write("Cuantos datos quieres añadir: ");
            int cant = int.Parse(Console.ReadLine());
            for (int i = 0; i < cant; i++)
            {
                lista.Add(R.Next(25));
            }
            lista.Show();
        }

        public void Auto_Delete_CircularDoublyLinkedList(CircularDoublyLinkedList lista, Random R)
        {
            Console.Write("Cuantos datos quieres borrar: ");
            int cant = int.Parse(Console.ReadLine());
            for (int i = 0; i < cant; i++)
            {
                lista.Delete(R.Next(25));
            }
            lista.Show();
        }

        public void Auto_Search_CircularDoublyLinkedList(CircularDoublyLinkedList lista, Random R)
        {
            Console.Write("Cuantos datos quieres buscar: ");
            int cant = int.Parse(Console.ReadLine());
            for (int i = 0; i < cant; i++)
            {
                lista.Search(R.Next(25));
            }
        }
    }
}
