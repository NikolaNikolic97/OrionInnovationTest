using FluentAssertions;
using Implementation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Xunit;

namespace TextTests
{
    public class FileTests
    {
        private const string OriginalPath = "../../../../OrionInnovationTest/Text.txt";
        private const string CopyPath = "../../../../OrionInnovationTest/TextTesting.txt";

        public FileTests()
        {
            if (File.Exists(CopyPath))
            {
                File.Delete(CopyPath);
            }
            File.Copy(OriginalPath, CopyPath);
        }
        [Fact]
        public void TestRead()
        {
            File.WriteAllText(CopyPath, String.Empty);
            File.AppendAllText(CopyPath, "test  test    ");
            var textFile = new ReadTextFile(CopyPath);
            var result = textFile.Read(null);

            result.Should().Be(2);
        }
    }
}
