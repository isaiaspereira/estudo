namespace Livraria.Application.Interface.InterfaceSecurity
{
    public interface ISecurity
    {
        string EncryptPassword(string hasPassword);
        bool DecryptPassword(string passwordUser, string passwordDb);
    }
}
