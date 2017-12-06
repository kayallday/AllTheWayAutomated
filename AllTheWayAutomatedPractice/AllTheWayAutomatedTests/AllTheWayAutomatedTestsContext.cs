using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllTheWayAutomatedTests
{
    [TestFixture]
    public class AllTheWayAutomatedTestsContext
    {
       public static TestContext Context { get; private set; }

        public static void AssemblyInit(TestContext context)
        {
            Context = context;
        }
    }
}
