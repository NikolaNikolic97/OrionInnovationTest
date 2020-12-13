using Logic;
using System;
using System.Collections.Generic;
using System.Text;

namespace Implementation
{
    public class ReadTextUserInput : BaseImplementation,IReadService
    {
        public int Read(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                throw new Exception("There is no text sent.");
            }
            return CalculateNumberOfWords(text.Trim());
        }
    }
}
