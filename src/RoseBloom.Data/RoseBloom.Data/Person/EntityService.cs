using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RoseBloom.Common.TCL;

namespace RoseBloom.Data.Common.Person
{
    public class EntityService<T> : IEntityServce where T : Entity
    {
        public Type EntityType => typeof(T);
         Entity IEntityServce.Type => throw new NotImplementedException();

        public Task<AddEntityResult<T>> Add(T toAdd)
        {
            throw new  NotImplementedException();
        }

        Task<AddEntityResult<Entity>> IEntityServce.Add(Entity toAdd)
        {
           throw new NotImplementedException();
        }

        Task<bool> IEntityServce.Delete(string id)
        {
            throw new NotImplementedException();
        }

        Task<GetEntityResult<Entity>> IEntityServce.Get()
        {
            throw new NotImplementedException();
        }

        Task<GetEntityResult<Entity>> IEntityServce.GetById(string id)
        {
            throw new NotImplementedException();
        }

        Task<UpdateEntityResult<Entity>> IEntityServce.Update(Entity toUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
