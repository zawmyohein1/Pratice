using System.Collections.Generic;
using System.Linq;

namespace DataStructures
{
    public class Lists
    {
        public List<int> RemoveAllEventNumber(List<int> inputs)
        {
            List<int> removedEvenNumbers = inputs.Where(x => x % 2 != 0).ToList();

            return removedEvenNumbers;
        }
    }
}