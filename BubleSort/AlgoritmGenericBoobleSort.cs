using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubleSort
{
    public class AloritmGenericBoobleSort<T> where T: IComparable
    {
        public List<T> Items { get; set; } = new List<T>();

        //метод обмена элементов
        protected void Swop(int eA, int eB)
        {
            if (eA < Items.Count && eB < Items.Count)
            {
                var temp = eA;
                eA = eB;
                eB = temp;
            }

        }

        //сортировка пузырьком
        public virtual void Sort()
        {
            Items.Sort();
        }

    }
}
