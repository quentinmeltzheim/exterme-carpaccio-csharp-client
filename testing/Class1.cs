using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using xCarpaccio.client;

namespace testing
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void newBillReturn0IfOrderIsNull()
        {
            Bill bill = new Bill(null);
         
        }
    }
}
