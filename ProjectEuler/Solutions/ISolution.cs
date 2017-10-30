namespace ProjectEuler.Solutions
{
    public interface ISolution
    {
        string Description { get; }
        TOutput GetAnswer<TInput, TOutput>(TInput input);
    }
}
