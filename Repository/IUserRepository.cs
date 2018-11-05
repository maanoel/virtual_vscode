using LojaVirtual.Model;
using LojaVirtual.Repository.Generic;

namespace LojaVirtual.Business
{
    public interface IUserRepository :IRepository<User>
    {
        User FindByLogin(string login);
    }
}
