namespace Entities.Exceptions
{
    public sealed class ValidationAppException : Exception
    {
        public IReadOnlyDictionary<string, string[]> Errors { get; }

        public ValidationAppException(IReadOnlyDictionary<string, string[]> erros)
            : base("One ir more validation errors occured")
            => Errors = erros;
    }
}