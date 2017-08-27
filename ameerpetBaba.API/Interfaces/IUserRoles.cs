using System.Collections.Generic;
using ameerpetBaba.API.DataEntities;
namespace ameerpetBaba.API.Interfaces
{
    public interface IUserRoles
    {
          List<userRoles> GetAlluserRoles();
    }
}