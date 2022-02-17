using System.Linq;
using Ewallet.Interface;

namespace Ewallet.Repositories
{
    public class VendorRepo
    {
        private ApplicationContext Context;
        public VendorRepo(ApplicationContext context)
        {
            Context = context;
        }
    }
}