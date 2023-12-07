using Listas.Interfaces;
using System;

namespace All_List.Clases.Listas
{
    public class CircularList : ImethodLists
    {
        private Node Head { get; set; }
        private Node LastNode { get; set; }

        public CircularList()
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
                Head.Next = Head;
                LastNode = NewNode;
                return;
            }
            //Caso 2: Impedimos datos repetidos
            if (Exist(NewNode.Data))
            {
                return;
            }
            //Caso 3: Colocamos el dato despues del primero
            if (NewNode.Data < Head.Data)
            {
                NewNode.Next = Head;
                Head = NewNode;
                LastNode.Next = Head;
                return;
            }
            //Caso 4: Recorremos la lista
            Node CurrentNode = Head;
            while (CurrentNode.Next != Head && CurrentNode.Next.Data <= NewNode.Data)
            {
                CurrentNode = CurrentNode.Next;
            }
            //Caso 5: Insertamos en X posicion
            if (NewNode.Data < CurrentNode.Next.Data)
            {
                NewNode.Next = CurrentNode.Next;
                CurrentNode.Next = NewNode;
                return;
            }
            //Caso 6: Insertamos al ultimo
            NewNode.Next = CurrentNode.Next;
            CurrentNode.Next = NewNode;
            LastNode = NewNode;
        }

        public void Delete(int data)
        {
            //Caso 1: Si la lista esta vacia
            if (IsEmpty())
            {
                return;
            }
            //Caso 2: El dato esta al inicio de la lista
            if (Head.Data == data)
            {
                Head = Head.Next;
                LastNode.Next = Head;
                Console.WriteLine($"- Dato[{data}] Eliminado de la lista");
                return;
            }
            //Caso 3: Recorremos la lista
            Node CurrentNode = Head;
            while (CurrentNode.Next != Head && CurrentNode.Next.Data < data)
            {
                CurrentNode = CurrentNode.Next;
            }
            //Caso 4: El dato esta al Final de la lista
            if (CurrentNode.Next == LastNode && CurrentNode.Next.Data == data)
            {
                CurrentNode.Next = CurrentNode.Next.Next;
                LastNode = CurrentNode;
                LastNode.Next = Head;
                Console.WriteLine($"- Dato[{data}] Eliminado de la lista");
                return;
            }
            //Caso 5: El dato esta en X posicion de la lista
            if (CurrentNode.Next.Data == data)
            {
                CurrentNode.Next = CurrentNode.Next.Next;
                Console.WriteLine($"- Dato[{data}] Eliminado de la lista");
                return;
            }
            //Caso 6: No se encontro el dato
            Console.WriteLine($"- Dato[{data}] No encontrado/eliminado de la lista");
        }

        public void Search(int data)
        {
            //Caso 1: Si la lista esta vacia
            if (IsEmpty())
            {
                return;
            }
            //Case 2: Si el dato esta al inicio de la lista
            if (Head.Data == data)
            {
                Console.WriteLine($"- Dato[{data}] Existe en la lista");
                return;
            }
            //Caso 3: Recorremos la lista
            Node CurrentNode = Head;
            while (CurrentNode.Next != Head && CurrentNode.Next.Data <= data)
            {
                CurrentNode = CurrentNode.Next;
            }
            //Caso 4: El dato ingresado existe X posicion
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
            //Caso 1: Comprobamos si al lista esta vacia
            if (IsEmpty())
            {
                Console.WriteLine("Lista vacia");
                return;
            }
            //Caso 2: Recorremos la lista
            Node CurrentNode = Head;
            int i = 0;
            Console.WriteLine("=== Mi lista Circular ===");
            do
            {
                Console.WriteLine($"- Nodo[{i}] y dato: " + CurrentNode.Data);
                CurrentNode = CurrentNode.Next;
                i++;
            } while (CurrentNode != Head);
        }

        public bool Exist(int data)
        {
            //Caso 1: Si la lista esta vacia
            if (IsEmpty())
            {
                return false;
            }
            //Caso 2: Si dato ya existe al inicio
            if (Head.Data == data)
            {
                return true;
            }
            //Caso 3: Recorremos la lista
            Node CurrentNode = Head;
            while (CurrentNode.Next != Head && CurrentNode.Next.Data <= data)
            {
                CurrentNode = CurrentNode.Next;
            }
            //Caso 4: Si dato ya existe al en X posicion/ o al final
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