namespace PdfmakeCSharp
{
    //TODO Finish interface with global methods to be implemented.
    public interface IPdfmake<T> : IPdfMakeBase<T>
    {
        void Download();
        void Open();
        void Print();
    }
}
