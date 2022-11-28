using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr1
{
    class DisposePatternImplementer:CloseableResource, IDisposable
    {
        bool disposed = false;
        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
                return;

            if (disposing)
            {
                Console.WriteLine("Disposing by developer");
                Close();
            }
            disposed = true;
        }

        ~DisposePatternImplementer()
        {
            Dispose(disposing: false);
            Console.WriteLine("Disposing by GC");
            Close();
        }
    }
}
