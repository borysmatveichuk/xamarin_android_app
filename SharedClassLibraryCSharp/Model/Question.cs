using Newtonsoft.Json;
using System.Collections.Generic;

namespace Model
{
    public class Question
    {
        public string Id;
        [JsonProperty("question")]
        public string Content { get; set; }
        public InputType inputType;
        public string Validator { get; set; }
        public List<Answer> Answers { get; set; }
        public int? Points { get; set; }
        public string Next { get; set; }

        public bool IsLast()
        {
            return Next == null;
        }
    }
}