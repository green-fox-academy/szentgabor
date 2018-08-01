using Matrix.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Matrix.Repositories
{
    public class MatrixRepository : IMatrixRepository<Matrixx>
    {
        private MatrixContext matrixContext;

        public MatrixRepository(MatrixContext matrixContext)
        {
            this.matrixContext = matrixContext;
        }

        public void Create(Matrixx elements)
        {
            matrixContext.Add(elements);
            matrixContext.SaveChanges();
        }

        public List<Matrixx> GetAllElements()
        {
            return matrixContext.Matrixes.ToList();
        }
    }
}
