using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace WinFormQuiz
{

    public struct APIResponseQuestion
    {
        public String category;
        public String type;
        public String difficulty;
        public String question;
        public String correct_answer;
        public List<String> incorrect_answers;
    }
    public struct APIResponse
    {
        public int response_code;
        public APIResponseQuestion[] results;
    }

    public class UserAnswers
    {
        public UserAnswers(string _userAnswer, bool _correct)
        {
            userAnswer = _userAnswer;
            correct = _correct;
        }

        public string userAnswer;
        public bool correct;
    }

    public class Quiz
    {
        private static Random random = new Random();

        public Quiz(APIResponseQuestion[] apiResults)
        {
            questionsAmount = apiResults.Length;

            foreach (APIResponseQuestion question in apiResults)
            {
                var possibleQuestionAnswers = new List<String>(question.incorrect_answers.Select(a => HttpUtility.HtmlDecode(a)));
                possibleQuestionAnswers.Add(HttpUtility.HtmlDecode(question.correct_answer));

                possibleAnswers.Add(new List<String>(possibleQuestionAnswers.OrderBy(item => random.Next())));
                correctAnswers.Add(HttpUtility.HtmlDecode(question.correct_answer));
                UserAnswers.Add(new UserAnswers("", false));
                questions.Add(HttpUtility.HtmlDecode(question.question));
            }
        }

        public readonly List<UserAnswers> UserAnswers = new List<UserAnswers>();
        public void addUserAnswer (int index, string answerText)
        {
            if (answerText == correctAnswers[index])
            {
                UserAnswers[index].userAnswer = answerText;
                UserAnswers[index].correct = true;
            } else
            {
                UserAnswers[index].userAnswer = answerText;
                UserAnswers[index].correct = false;
            }
        }
        public List<UserAnswers> verifyUserAnswers ()
        {
            return UserAnswers;
        }

        public readonly int questionsAmount;
        public readonly List<List<String>> possibleAnswers = new List<List<String>>();
        public readonly List<String> correctAnswers = new List<String>();
        public readonly List<String> questions = new List<String>();
    }
}
