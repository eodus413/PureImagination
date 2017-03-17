namespace ProjectSpace
{
    public interface IMachine
    {
        Battery battery { get; }
        void Use();
    }
}