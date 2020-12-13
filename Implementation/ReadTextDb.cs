using DataAccess;
using Logic;
using System;
using System.Collections.Generic;
using System.Text;

namespace Implementation
{
    public class ReadTextDb : IReadService
    {
        private readonly Context _context;
        public ReadTextDb(Context context)
        {
            _context = context;
        }
        public int Read(string text)
        {
            throw new NotImplementedException();
        }
    }
}
