using All_List.Clases.Listas;
using Listas.Clases;
using System;

namespace Listas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random Random = new Random();
            Auto Automatic = new Auto();
            Console.WriteLine("*****Listas*****\n[1]Simple.\n[2]Circular.\n[3]Doble enlazada.\n[4]Cicular doble enlazada.\n[5]Salir");
            Console.Write("Opcion: ");
            int Opn = int.Parse(Console.ReadLine());
            switch (Opn)
            {
                case 1:
                    Console.Clear();
                    SimpleList Lista_Simple = new SimpleList();
                    Automatic.Auto_Add_SimpleList(Lista_Simple, Random);
                    Automatic.Auto_Delete_SimpleList(Lista_Simple, Random);
                    Automatic.Auto_Search_SimpleList(Lista_Simple, Random);
                    Console.ReadKey();
                    break;
                case 2:
                    Console.Clear();
                    CircularList Circular_List = new CircularList();
                    Automatic.Auto_Add_CircularList(Circular_List, Random);
                    Automatic.Auto_Delete_CircularList(Circular_List, Random);
                    Automatic.Auto_Search_CircularList(Circular_List, Random);
                    Console.ReadKey();
                    break;
                case 3:
                    Console.Clear();
                    DoublyListLinked Doubly_List_Linked = new DoublyListLinked();
                    Automatic.Auto_Add_DoublyListLinked(Doubly_List_Linked, Random);
                    Automatic.Auto_Delete_DoublyListLinked(Doubly_List_Linked, Random);
                    Automatic.Auto_Search_DoublyListLinked(Doubly_List_Linked, Random);
                    Console.ReadKey();
                    break;
                case 4:
                    Console.Clear();
                    CircularDoublyLinkedList Circular_Doubly_Linked_List = new CircularDoublyLinkedList();
                    Automatic.Auto_Add_CircularDoublyLinkedList(Circular_Doubly_Linked_List, Random);
                    Automatic.Auto_Delete_CircularDoublyLinkedList(Circular_Doubly_Linked_List, Random);
                    Automatic.Auto_Search_CircularDoublyLinkedList(Circular_Doubly_Linked_List, Random);
                    Console.ReadKey();
                    break;
                default:
                    break;
            }
        }
    }
}