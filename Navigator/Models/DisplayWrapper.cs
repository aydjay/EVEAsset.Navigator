namespace Navigator.Models
{
    public class DisplayWrapper<T>
    {
        public T WrappedModel;

        public DisplayWrapper(T wrappedModel)
        {
            WrappedModel = wrappedModel;
        }
    }
}