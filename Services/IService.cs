using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Importør.Services
{
    interface IService<T>
    {
        Task<IEnumerable<T>> GetObjectsAsync();
    }
}
