using Logic;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Implementation
{
    public class ReadTextFile : BaseImplementation,IReadService
    {
        private readonly string _path;
        public ReadTextFile(string path)
        {
            _path = path;
        }
        public int Read(string text)
        {
            var allText = File.ReadAllText(_path);
            return CalculateNumberOfWords(allText.Trim());
        }
    }
}
