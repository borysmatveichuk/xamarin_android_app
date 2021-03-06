﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    class Question
    {
        public string Id;
        public string Content { get; set; }
        public InputType inputType;
        public string Validator { get; set; }
        public List<Answer> Answers { get; set; }
        public int Points { get; set; }
        public string Next { get; set; }
    }
}