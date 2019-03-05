namespace PdfmakeCSharp.Interfaces
{
    public interface IPdfmake<T> : IBasePdfMake<T>
    {
        void Download();
        void Open();
        void Print();
    }
}
