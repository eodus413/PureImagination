namespace ProjectSpace
{
    public interface IEletronicSource
    {
        int energy { get; }
        float upDelay { get; }
        bool isOn { get; }

        void On();
        void Off();
    }
}