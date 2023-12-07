namespace All_List.Clases
{
    public class Node
    {
        public Node Next { get; set; }
        public int Data { get; set; }

        public Node(int d)
        {
            Data = d;
            Next = null;
        }
    }
}