using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTestSystem
{
    class TestStorage
    {
        private TestUnit[] testList = null;

        private static TestStorage testStorage;

            private TestStorage()
        {

        }

        public static TestStorage getInstance() {
            if (testStorage == null) testStorage = new TestStorage();
            return testStorage;
        }
    }
}
