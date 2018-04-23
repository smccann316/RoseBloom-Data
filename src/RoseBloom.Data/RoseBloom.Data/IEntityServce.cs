using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RoseBloom.Common.TCL;

namespace RoseBloom.Data.Common
{
    /// <summary>
    /// the interface to define the main etry point to get data
    /// </summary>
    public interface IEntityServce
    {
        Entity Type { get; }
        Task<GetEntityResult<Entity>> Get();
        Task<GetEntityResult<Entity>> GetById(string id);
        Task<AddEntityResult<Entity>> Add(Entity toAdd);
        Task<UpdateEntityResult<Entity>> Update(Entity toUpdate);
        Task<bool> Delete(string id);

    }

}
