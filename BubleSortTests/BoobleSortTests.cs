using Microsoft.VisualStudio.TestTools.UnitTesting;
using BubleSort;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubleSort.Tests
{
    [TestClass()]
    public class BoobleSortTests
    {
        [TestMethod()]
        public void SortTest()
        {
            var bubble = new BoobleSort<int>();

            var rnd = new Random();

            for (int i = 0; i < 10; i++)
            {
                bubble.Items.Add(rnd.Next(0, 100));
            }

            bubble.Sort();


        }
    }
}