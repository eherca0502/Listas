using Listas.Interfaces;
using System;

namespace All_List.Clases.Listas
{
    public class SimpleList : ImethodLists
    {
        private Node Head { get; set; }

        public SimpleList()
        {
            Clear();
        }

        public void Add(int data)
        {
            //Caso 0: Creamos un nuevo nodo
            Node NewNode = new Node(data);
            //Caso 1: Insertamso al inicio
            if (IsEmpty())
            {
                Head = NewNode;
                return;
            }
            //Caso 2: Impedimos datos repetidos
            if (Exist(NewNode.Data))
            {
                return;
            }
            //Caso 3: Insertamos el dato al inicio de la lista
            if (NewNode.Data < Head.Data)
            {
                NewNode.Next = Head;
                Head = NewNode;
                return;
            }
            //Caso 4: Recorremos la lista
            Node CurrentNode = Head;
            while (CurrentNode.Next != null && CurrentNode.Next.Data < NewNode.Data)
            {
                CurrentNode = CurrentNode.Next;
            }
            //Caso 5: Insertamos en X posicion o al final de la lista
            NewNode.Next = CurrentNode.Next;
            CurrentNode.Next = NewNode;
        }

        public void Delete(int data)
        {
            //Caso 1: Si la lista esta vacia
            if (IsEmpty())
            {
                return;
            }
            //Caso 2: Si el dato esta al inicio
            if (Head.Data == data)
            {
                Head = Head.Next;
                Console.WriteLine($"- Dato[{data}] Eliminado de la lista");
                return;
            }
            //Caso 3: Recorremos la lista
            Node CurrentNode = Head;
            while (CurrentNode.Next != null && CurrentNode.Next.Data < data)
            {
                CurrentNode = CurrentNode.Next;
            }
            //Caso 4: Si el dato esta en X posicion
            if (CurrentNode.Next != null && CurrentNode.Next.Data == data)
            {
                CurrentNode.Next = CurrentNode.Next.Next;
                Console.WriteLine($"- Dato[{data}] Eliminado de la lista");
                return;
            }
            //Caso 5: No se encontro el dato
            Console.WriteLine($"- Dato[{data}] No encontrado/eliminado de la lista");
        }

        public void Search(int data)
        {
            //Caso 1: Si la lista esta vacia
            if (IsEmpty())
            {
                return;
            }
            //Case 2: Si el dato esta al inicio
            if (Head.Data == data)
            {
                Console.WriteLine($"- Dato[{data}] Existe en la lista");
                return;
            }
            //Caso 3: Recorremos la lista
            Node CurrentNode = Head;
            while (CurrentNode.Next != null && CurrentNode.Next.Data <= data)
            {
                CurrentNode = CurrentNode.Next;
            }
            //Caso 4: Si el dato esta en X posicion
            if (CurrentNode.Data == data)
            {
                Console.WriteLine($"- Dato[{data}] Existe en la lista");
                return;
            }
            //Caso 5: No existe el dato
            Console.WriteLine($"- Dato[{data}] No Existe en la lista ");
        }

        public void Show()
        {
            //Caso 1: Si la lista esta vacia
            if (IsEmpty())
            {
                Console.WriteLine("Lista vacia");
                return;
            }
            //Caso 2: Recorremos la lista
            int i = 0;
            Node CurrentNode = Head;
            Console.WriteLine("=== Mi lista simple ===");
            while (CurrentNode != null)
            {
                Console.WriteLine($"- Nodo[{i}] y dato: " + CurrentNode.Data);
                CurrentNode = CurrentNode.Next;
                i++;
            }
        }

        public bool Exist(int data)
        {
            //Caso 1: Si la lista esta vacia
            if (IsEmpty())
            {
                return false;
            }
            //Caso 2: Si el primer nodo contiene el dato
            if (Head.Data == data)
            {
                return true;
            }
            //Caso 3: Empezamos a recorrer la lista
            Node CurrentNode = Head;
            while (CurrentNode.Next != null && CurrentNode.Next.Data <= data)
            {
                CurrentNode = CurrentNode.Next;
            }
            //Caso 4: El dato existe en el ultimo elemento
            if (CurrentNode.Data == data)
            {
                return true;
            }
            //Caso 5: El dato no existe en la lista
            return false;
        }

        public bool IsEmpty()
        {
            return Head == null;
        }

        public void Clear()
        {
            Head = null;
        }
    }
}