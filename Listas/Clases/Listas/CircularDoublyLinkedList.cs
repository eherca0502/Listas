using Listas.Interfaces;
using System;

namespace All_List.Clases.Listas
{
    public class CircularDoublyLinkedList : ImethodLists
    {
        private DoubleNode Head { get; set; }
        private DoubleNode LastNode { get; set; }

        public CircularDoublyLinkedList()
        {
            Clear();
        }

        public void Add(int data)
        {
            //Caso 0: Creamos un nuevo nodo
            DoubleNode NewNode = new DoubleNode(data);
            //Caso 1: Insertamso al inicio
            if (IsEmpty())
            {
                Head = NewNode;
                NewNode.Back = Head;
                NewNode.Next = Head;
                LastNode = Head;
                return;
            }
            //Caso 2: Impedimos datos repetidos
            if (Exist(NewNode.Data))
            {
                return;
            }
            //Caso 3: Insertamos al incio si el dato es menor
            if (NewNode.Data < Head.Data)
            {
                NewNode.Next = Head;
                NewNode.Back = Head;
                Head.Next = NewNode;
                Head.Back = NewNode;
                LastNode = Head;
                Head = NewNode;
                return;
            }
            //Caso 4: Insertamos al final si el dato es mayor
            if (NewNode.Data > LastNode.Data)
            {
                NewNode.Back = LastNode;
                LastNode.Next = NewNode;
                LastNode = NewNode;
                LastNode.Next = Head;
                Head.Back = LastNode;
                return;
            }
            // caso 5: Recorremos la lista
            DoubleNode CurrentNode = Head;
            while (CurrentNode.Next != Head && CurrentNode.Next.Data < NewNode.Data)
            {
                CurrentNode = CurrentNode.Next;
            }
            //Caso 6: Insertamso en X posicion
            NewNode.Next = CurrentNode.Next;
            NewNode.Back = CurrentNode;
            CurrentNode.Next.Back = NewNode;
            CurrentNode.Next = NewNode;
        }

        public void Delete(int data)
        {
            //Caso 1: Si la lista esta vacia
            if (IsEmpty())
            {
                return;
            }
            //Caso 2: Elimnamos y comprobamso si hay solo un elemento
            if (Head.Data == LastNode.Data)
            {
                Clear();
                Console.WriteLine($"- Dato[{data}] Eliminado de la lista");
                return;
            }
            //Caso 3: El dato esta al inicio de la lista
            if (Head.Data == data)
            {
                Head = Head.Next;
                Head.Back = LastNode;
                LastNode.Next = Head;
                Console.WriteLine($"- Dato[{data}] Eliminado de la lista");
                return;
            }
            //Caso 4: El dato esta al final de la lista
            if (LastNode.Data == data)
            {
                LastNode = LastNode.Back;
                LastNode.Next = Head;
                Head.Back = LastNode;
                Console.WriteLine($"- Dato[{data}] Eliminado de la lista");
                return;
            }
            //Caso 5: Recorremos la lista
            DoubleNode CurrentNode = Head;
            while (CurrentNode.Next != Head && CurrentNode.Next.Data < data)
            {
                CurrentNode = CurrentNode.Next;
            }
            //Caso 6: El dato esta en X posicion de la lista
            if (CurrentNode.Next.Data == data)
            {
                CurrentNode.Next.Next.Back = CurrentNode;
                CurrentNode.Next = CurrentNode.Next.Next;
                Console.WriteLine($"- Dato[{data}] Eliminado de la lista");
                return;
            }
            //Caso 7: No se encontro el dato a eliminar
            Console.WriteLine($"- Dato[{data}] No encontrado/eliminado de la lista");
        }

        public void Search(int data)
        {
            //Caso 1: Si la lista esta vacia
            if (IsEmpty())
            {
                return;
            }
            //Caso 2: Si es dato esta al inicio
            if (Head.Data == data)
            {
                Console.WriteLine($"- Dato[{data}] Existe en la lista");
                return;
            }
            //Caso 3: Si es dato esta al final
            if (LastNode.Data == data)
            {
                Console.WriteLine($"- Dato[{data}] Existe en la lista");
                return;
            }
            //Caso 4: Recorremos la lista
            DoubleNode CurrentNode = Head;
            while (CurrentNode.Next != Head && CurrentNode.Next.Data <= data)
            {
                CurrentNode = CurrentNode.Next;
            }
            //Caso 5: Si existe el dato en la lista
            if (CurrentNode.Data == data)
            {
                Console.WriteLine($"- Dato[{data}] Existe en la lista");
                return;
            }
            //Caso 6: No existe el dato en la lista
            Console.WriteLine($"- Dato[{data}] No Existe en la lista ");
        }

        public void Show()
        {
            //Caso 1: Si al lista esta vacia
            if (IsEmpty())
            {
                Console.WriteLine("Lista vacia");
                return;
            }
            //Caso 2: Recorremos la lista
            DoubleNode CurrentNode = Head;
            int i = 0;
            Console.WriteLine("=== Mi Lista circular doblemente enlazada ===");
            do
            {
                Console.WriteLine($"- Nodo[{i}] y dato: " + CurrentNode.Data);
                CurrentNode = CurrentNode.Next;
                i++;
            } while (CurrentNode != Head);
        }

        public void ShowRevers()
        {
            //Caso 1: Si la lsita esta vacia
            if (IsEmpty())
            {
                Console.WriteLine("Lista vacia");
                return;
            }
            //Caso 2: Recorremos la lista
            DoubleNode CurrentNode = LastNode;
            int i = 0;
            Console.WriteLine("=== Mi Lista circular doblemente enlazada Reversa ===");
            do
            {
                Console.WriteLine($"- Nodo[{i}] y dato: " + CurrentNode.Data);
                CurrentNode = CurrentNode.Back;
                i++;
            } while (CurrentNode != LastNode);
        }

        public bool Exist(int data)
        {
            //Caso 1: Si la lista esta vacia
            if (IsEmpty())
            {
                return false;
            }
            //Caso 2: Si el primer elemento ya existe
            if (Head.Data == data)
            {
                return true;
            }
            //Caso 3: Si es dato esta al final
            if (LastNode.Data == data)
            {
                return true;
            }
            //Caso 4: Recorremos la lista
            DoubleNode CurrentNode = Head;
            while (CurrentNode.Next != Head && CurrentNode.Next.Data <= data)
            {
                CurrentNode = CurrentNode.Next;
            }
            //Caso 5: El dato ingresado existe en X posicion
            if (CurrentNode.Data == data)
            {
                return true;
            }
            //Caso 6: El dato no existe en la lista
            return false;
        }

        public bool IsEmpty()
        {
            return Head == null;
        }

        public void Clear()
        {
            Head = null;
            LastNode = null;
        }
    }
}