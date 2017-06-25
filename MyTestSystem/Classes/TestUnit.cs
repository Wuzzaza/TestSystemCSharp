using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTestSystem
{
    class TestUnit
    {
        struct answer {
            string answerTest;
            bool isCorrect;
        }

        string testQuestionText;
        answer[] answers;

        public TestUnit() {
            answers = new answer[4];

        }
    }
}
