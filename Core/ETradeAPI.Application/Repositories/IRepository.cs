using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ETradeAPI.Domain.Entities.Common;
using Microsoft.EntityFrameworkCore;

namespace ETradeAPI.Application.Repositories
{
    public interface IRepository <T>  where  T : BaseEntity
    {
        DbSet<T> Table { get; }
    }
}
