using System;
using System.Collections.Generic;
using System.Text;

namespace CursoBasicoCSharp
{
    class Song : IMedia
    {
        public long Second { get; set; }
        public string Title { get; set; }

        public void Play()
        {
            Console.WriteLine($"Playing {Title}!");
        }
    }
}
