using System.Collections.Generic;
using System.Threading.Tasks;
using RoseBloom.Common.TCL;

namespace RoseBloom.Data.Common
{
    /// <summary>
    /// Interface for any Repository in the system 
    /// </summary>
    public interface IEntityRepository
    {
        Entity EntityType { get; }
        Task<Entity> GetById(string id);
        Task<List<Entity>> Get(); // we could use criteria
        Entity Add(Entity toAdd);
        Entity Update(Entity toUpdate);
        Entity Delete(string id);

    }
}
