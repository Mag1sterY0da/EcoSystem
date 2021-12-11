namespace Chain_of_responsibility
{
    public abstract class Handler
    {
        public Handler Successor { get; set; }
        public abstract string HandleRequest(int condition);
    }
}