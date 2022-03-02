using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net.Http.Headers;
using System.Net.Http;
using Newtonsoft.Json;

namespace WinFormQuiz
{

    public partial class WinFormQuiz : Form
    {
        private static HttpClient client = new HttpClient();

        Quiz quiz;
        int currentQuestion = 0;

        public WinFormQuiz()
        {
            InitializeComponent();
            client.BaseAddress = new Uri("https://opentdb.com/api.php/");
        }

        private async void btn_Start_Click(object sender, EventArgs e)
        {
            var category = combo_category.SelectedIndex + 8;

            var url = $"?amount={(int) numInput_questionsAmount.Value}";
            url += category == 8 ? "" : $"&category={category}";

            var apiResponse = JsonConvert.DeserializeObject<APIResponse>(await client.GetAsync(url).Result.Content.ReadAsStringAsync());

            if (apiResponse.response_code != 0)
            {
                group_score.Visible = false;
                group_question.Visible = false;

                MessageBox.Show("Some Error Ocurred.\nTry checking the category!");
                return;
            }

            quiz = new Quiz(apiResponse.results);
            currentQuestion = 0;

            changeQuestion(0);
            group_question.Visible = true;
            group_score.Visible = false;
        }

        private void btn_previousQuestion_Click(object sender, EventArgs e)
        {
            if (currentQuestion >= 1)
            {
                --currentQuestion;
                changeQuestion(currentQuestion);
            }
        }

        private void btn_nextQuestion_Click(object sender, EventArgs e)
        {

            if (quiz.questionsAmount > currentQuestion + 1)
            {
                ++currentQuestion;
                changeQuestion(currentQuestion);
            } else
            {
                endGame();
            }
        }

        private void changeQuestion (int index)
        {
            flowLayout_optionsGroup.Controls.Clear();

            foreach (string possibleAnswer in quiz.possibleAnswers[index])
            {
                var option = new RadioButton{
                    Text = possibleAnswer,
                    Size = new System.Drawing.Size(383, 24)
                };

                option.Checked = quiz.UserAnswers[index].userAnswer == possibleAnswer;

                option.Click += (object sender, EventArgs e) => { quiz.addUserAnswer(index, possibleAnswer); };

                flowLayout_optionsGroup.Controls.Add(option);
            }

            lbl_question.Text = quiz.questions[index];
            group_question.Text = "Question " + (index + 1).ToString();
        }

        private void endGame ()
        {
            group_question.Visible = false;
            group_score.Visible = true;

            var correctAnswersAmount = quiz.verifyUserAnswers().Count((x) => { return x.correct; });

            lbl_score.Text = $"You answer correctly {correctAnswersAmount} of {quiz.questionsAmount} questions!!\n\n";
            lbl_score.Text += quiz.questionsAmount / 2 <= correctAnswersAmount ? "Good Job" : "You Suck Bro";
        }

        private void btn_seeSolutions_Click(object sender, EventArgs e)
        {
            var quizScore = new QuizSolutions(quiz);
            quizScore.Show();
        }
    }
}
