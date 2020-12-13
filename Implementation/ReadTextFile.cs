using Logic;
using System;
using System.Collections.Generic;
using System.Text;

namespace Implementation
{
    public class ReadTextFile : IReadService
    {
        private readonly string _path;
        public ReadTextFile(string path)
        {
            _path = path;
        }
        public int Read(string text)
        {
            throw new NotImplementedException();
        }
    }
}
