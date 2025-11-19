namespace Entities.LinkModels
{
    public class LinksCollectionWrapper<T> : LinkResourceBase
    {
        public List<T> Value { get; set; } = new();

        public LinksCollectionWrapper() { }

        public LinksCollectionWrapper(List<T> value) => Value = value;
    }
}