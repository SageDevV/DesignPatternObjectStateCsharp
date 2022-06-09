using ObjectStatePattern;

class Program
{
    static void Main(string[] args)
    {
        var context = new Context(new ConcreteStateA());
        context.Requisicao1();
        context.Requisicao2();
    }
}
