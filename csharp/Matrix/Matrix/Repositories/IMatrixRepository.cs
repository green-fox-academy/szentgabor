using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Matrix.Repositories
{
    public interface IMatrixRepository<Matrixx>
    {
        void Create(Matrixx elements);
        List<Matrixx> GetAllElements();
    }
}
