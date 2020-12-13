using Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Implementation
{
    public static class ImplementationFactory
    {
        public static IReadService Create(IEnumerable<IReadService> implementation, string type)
        {
            switch (type)
            {
                case "db":
                    return implementation.ElementAt(0); //database registrated in DI container
                case "file":
                    return implementation.ElementAt(1); //file registrated in DI container
                default:
                    return implementation.ElementAt(2); //userInput registrated in DI container
            }
        }
    }
}
