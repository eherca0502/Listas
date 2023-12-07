namespace All_List.Clases
{
    public class DoubleNode
    { 
        public DoubleNode Back { get; set; }
        public DoubleNode Next { get; set; }
        public int Data { get; set; }

        public DoubleNode(int data)
        {
            Data = data;
            Next = null;
            Back = null;
        }
    }
}