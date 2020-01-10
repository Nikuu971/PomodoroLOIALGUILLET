using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PomoTestUnit
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int m, s;
            int NbrPomodo = 0;
            int NbrPause = 0;
            bool pauseSwitch = false;

            void Init()
            {
                if (!pauseSwitch)
                {
                    m = 25;
                    s = 1;
                  
                }
                if (pauseSwitch)
                {
                    m = 5;
                    s = 1;
                    pauseSwitch = false;
                   
                }
                if (NbrPomodo > 4)
                {
                    m = 15;
                    s = 1;
                    NbrPomodo = 0;
                }
 
            }

            Init();

        }
    }
}
