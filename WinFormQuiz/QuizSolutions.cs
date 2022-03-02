using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormQuiz
{
    public partial class QuizSolutions : Form
    {
        Quiz quiz;

        public QuizSolutions(Quiz _quiz)
        {
            InitializeComponent();
            quiz = _quiz;
        }


        private void QuizSolutions_Load(object sender, EventArgs e)
        {
            gridView_results.RowCount = quiz.questionsAmount;
            gridView_results.ColumnCount = 5;
            gridView_results.Columns[0].HeaderText = "Num";
            gridView_results.Columns[1].HeaderText = "Correct";
            gridView_results.Columns[2].HeaderText = "Question";
            gridView_results.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            gridView_results.Columns[3].HeaderText = "User Answer";
            gridView_results.Columns[4].HeaderText = "Correct Answer";

            var userAnswers = quiz.verifyUserAnswers();

            for (int i = 0; i < quiz.questionsAmount; i++)
            {
                var row = gridView_results.Rows[i];

                row.Cells[0].Value = $"Q. {i + 1}";

                row.Cells[1].Value = userAnswers[i].correct ? "Correct" : "Incorrect";
                row.Cells[1].Style.BackColor = userAnswers[i].correct ? Color.Green : Color.Red;
                row.Cells[1].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                row.Cells[2].Value = quiz.questions[i];
                row.Cells[3].Value = userAnswers[i].userAnswer;
                row.Cells[4].Value = quiz.correctAnswers[i];
            }
        }
    }
}
