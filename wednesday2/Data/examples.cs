using System;
using System.Collections.Generic; // This lets us use the 'List' class

namespace wednesday2.Data
{
    public class examples
    {
        public examples()
        {
            string[] stringArray = { "one", "two", "three" };
            // can't do this - there's no more space in the array
            //stringArray << "four";

            // Lists are like expandable arrays!
            List<string> stringList = new List<string> { "one", "two", "three" };
            // now we can add to it!
            stringList.Add("four");

            // The <thing inside the nixons> tells us what type this list holds.
            // Here's a list of Jeans: List<Jean>
        }
    }
}
