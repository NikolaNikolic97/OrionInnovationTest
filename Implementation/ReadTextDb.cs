using DataAccess;
using Logic;
using System;
using System.Collections.Generic;
using System.Text;

namespace Implementation
{
    public class ReadTextDb : BaseImplementation,IReadService
    {
        private readonly Context _context;
        public ReadTextDb(Context context)
        {
            _context = context;
        }
        public int Read(string text)
        {
            var allText = _context.Texts.Find(1).AllText.Trim();
            return CalculateNumberOfWords(allText);
        }
    }
}
