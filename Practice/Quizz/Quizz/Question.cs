using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheQuizz
{
    // Or we can use internal (when we are using it in the same project)
    public class Question
    {
        public string Text { get; private set; }
        public string[] Options { get; private set; }
        public string Answer { get; private set; }


        public Question(string text, string answer, string[]? options)
        {
            Text = text ?? throw new ArgumentNullException(nameof(text));
            Answer = answer ?? throw new ArgumentNullException(nameof(answer));
            Options = options ?? new string[0];
        }
    }
}
