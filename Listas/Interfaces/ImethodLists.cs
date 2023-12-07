namespace Listas.Interfaces
{
    public interface ImethodLists
    {
        void Add(int data);
        void Delete(int data);
        void Search(int data);
        void Show();
        bool IsEmpty();
        void Clear();
    }
}