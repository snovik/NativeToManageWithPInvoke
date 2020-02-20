using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ManagedApp.Console
{
    public class ManagedWorker : IDisposable
    {
        [DllImport("NativeWorker.dll", EntryPoint = "compute", CallingConvention = CallingConvention.Cdecl)]
        protected static extern int _Compute(int value);
        
        private void ReleaseUnmanagedResources()
        {
            // TODO release unmanaged resources here
        }

        public void Dispose()
        {
            ReleaseUnmanagedResources();
            GC.SuppressFinalize(this);
        }

        ~ManagedWorker()
        {
            ReleaseUnmanagedResources();
        }

        public int Compute(int value)
        {
            int val = _Compute(value);
            return val;
        }
    }
}
