using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class Answer
    {
        public string Id { get; set; }
        public string Content { get; set; }
        public int Points { get; set; }
        public string Next { get; set; }
    }
}