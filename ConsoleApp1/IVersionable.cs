

namespace Task001
{
    interface IVersionable
    {
        byte [] Version { get; set; }
        void ReadVersion(byte[] array);
        void InstallVersion(byte[] array);
    }
}
