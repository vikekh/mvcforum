using System;
using MVCForum.Domain.DomainModel.Entities;

namespace MVCForum.Domain.Interfaces.Services
{
    using MvcForum.Core.DomainModel.Entities;

    public partial interface IBlockService
    {
        Block Add(Block block);        
        void Delete(Block block);
        Block Get(Guid id);
    }
}
