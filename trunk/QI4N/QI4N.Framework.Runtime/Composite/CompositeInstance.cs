namespace QI4N.Framework.Runtime
{
    public interface CompositeInstance : InvocationHandler
    {
        object[] Mixins { get; set; }

        Composite Proxy { get; set; }

        CompositeModel CompositeModel { get; }

        string ToURI();
    }
}