namespace WinFormQuiz
{
    partial class WinFormQuiz
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WinFormQuiz));
            this.btn_Start = new System.Windows.Forms.Button();
            this.numInput_questionsAmount = new System.Windows.Forms.NumericUpDown();
            this.combo_category = new System.Windows.Forms.ComboBox();
            this.group_amountOfQuestions = new System.Windows.Forms.GroupBox();
            this.group_category = new System.Windows.Forms.GroupBox();
            this.group_question = new System.Windows.Forms.GroupBox();
            this.btn_nextQuestion = new System.Windows.Forms.Button();
            this.btn_previousQuestion = new System.Windows.Forms.Button();
            this.group_options = new System.Windows.Forms.GroupBox();
            this.flowLayout_optionsGroup = new System.Windows.Forms.FlowLayoutPanel();
            this.lbl_question = new System.Windows.Forms.Label();
            this.group_score = new System.Windows.Forms.GroupBox();
            this.lbl_score = new System.Windows.Forms.Label();
            this.btn_seeSolutions = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numInput_questionsAmount)).BeginInit();
            this.group_amountOfQuestions.SuspendLayout();
            this.group_category.SuspendLayout();
            this.group_question.SuspendLayout();
            this.group_options.SuspendLayout();
            this.group_score.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Start
            // 
            this.btn_Start.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Start.Location = new System.Drawing.Point(227, 17);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(120, 47);
            this.btn_Start.TabIndex = 0;
            this.btn_Start.Text = "Start";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // numInput_questionsAmount
            // 
            this.numInput_questionsAmount.Location = new System.Drawing.Point(6, 19);
            this.numInput_questionsAmount.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numInput_questionsAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numInput_questionsAmount.Name = "numInput_questionsAmount";
            this.numInput_questionsAmount.Size = new System.Drawing.Size(197, 20);
            this.numInput_questionsAmount.TabIndex = 3;
            this.numInput_questionsAmount.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // combo_category
            // 
            this.combo_category.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.combo_category.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.combo_category.FormattingEnabled = true;
            this.combo_category.Items.AddRange(new object[] {
            "Any Category",
            "General Knowledge",
            "Entertainment: Books",
            "Entertainment: Film",
            "Entertainment: Music",
            "Entertainment: Musicals & Theatres",
            "Entertainment: Television",
            "Entertainment: Video Games",
            "Entertainment: Board Games",
            "Science & Nature",
            "Science: Computers",
            "Science: Mathematics",
            "Mythology",
            "Sports",
            "Geography",
            "History",
            "Politics",
            "Art",
            "Celebrities",
            "Animals",
            "Vehicles",
            "Entertainment: Comics",
            "Science: Gadgets",
            "Entertainment: Japanese Anime & Manga",
            "Entertainment: Cartoon & Animations"});
            this.combo_category.Location = new System.Drawing.Point(6, 19);
            this.combo_category.Name = "combo_category";
            this.combo_category.Size = new System.Drawing.Size(201, 21);
            this.combo_category.TabIndex = 4;
            this.combo_category.Text = "Any Category";
            // 
            // group_amountOfQuestions
            // 
            this.group_amountOfQuestions.Controls.Add(this.numInput_questionsAmount);
            this.group_amountOfQuestions.Location = new System.Drawing.Point(12, 17);
            this.group_amountOfQuestions.Name = "group_amountOfQuestions";
            this.group_amountOfQuestions.Size = new System.Drawing.Size(209, 47);
            this.group_amountOfQuestions.TabIndex = 7;
            this.group_amountOfQuestions.TabStop = false;
            this.group_amountOfQuestions.Text = "Amount Of Questions";
            // 
            // group_category
            // 
            this.group_category.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.group_category.Controls.Add(this.combo_category);
            this.group_category.Location = new System.Drawing.Point(353, 17);
            this.group_category.Name = "group_category";
            this.group_category.Size = new System.Drawing.Size(213, 47);
            this.group_category.TabIndex = 8;
            this.group_category.TabStop = false;
            this.group_category.Text = "Category";
            // 
            // group_question
            // 
            this.group_question.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.group_question.Controls.Add(this.btn_nextQuestion);
            this.group_question.Controls.Add(this.btn_previousQuestion);
            this.group_question.Controls.Add(this.group_options);
            this.group_question.Controls.Add(this.lbl_question);
            this.group_question.Location = new System.Drawing.Point(12, 110);
            this.group_question.Name = "group_question";
            this.group_question.Size = new System.Drawing.Size(554, 277);
            this.group_question.TabIndex = 9;
            this.group_question.TabStop = false;
            this.group_question.Text = "Question 1";
            this.group_question.Visible = false;
            // 
            // btn_nextQuestion
            // 
            this.btn_nextQuestion.Location = new System.Drawing.Point(23, 196);
            this.btn_nextQuestion.Name = "btn_nextQuestion";
            this.btn_nextQuestion.Size = new System.Drawing.Size(83, 53);
            this.btn_nextQuestion.TabIndex = 13;
            this.btn_nextQuestion.Text = "Next";
            this.btn_nextQuestion.UseVisualStyleBackColor = true;
            this.btn_nextQuestion.Click += new System.EventHandler(this.btn_nextQuestion_Click);
            // 
            // btn_previousQuestion
            // 
            this.btn_previousQuestion.Location = new System.Drawing.Point(23, 101);
            this.btn_previousQuestion.Name = "btn_previousQuestion";
            this.btn_previousQuestion.Size = new System.Drawing.Size(83, 52);
            this.btn_previousQuestion.TabIndex = 12;
            this.btn_previousQuestion.Text = "Previous";
            this.btn_previousQuestion.UseVisualStyleBackColor = true;
            this.btn_previousQuestion.Click += new System.EventHandler(this.btn_previousQuestion_Click);
            // 
            // group_options
            // 
            this.group_options.Controls.Add(this.flowLayout_optionsGroup);
            this.group_options.Location = new System.Drawing.Point(131, 101);
            this.group_options.Name = "group_options";
            this.group_options.Size = new System.Drawing.Size(398, 148);
            this.group_options.TabIndex = 10;
            this.group_options.TabStop = false;
            this.group_options.Text = "Options";
            // 
            // flowLayout_optionsGroup
            // 
            this.flowLayout_optionsGroup.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayout_optionsGroup.Location = new System.Drawing.Point(6, 19);
            this.flowLayout_optionsGroup.Name = "flowLayout_optionsGroup";
            this.flowLayout_optionsGroup.Size = new System.Drawing.Size(386, 123);
            this.flowLayout_optionsGroup.TabIndex = 0;
            // 
            // lbl_question
            // 
            this.lbl_question.Location = new System.Drawing.Point(6, 32);
            this.lbl_question.MaximumSize = new System.Drawing.Size(620, 50);
            this.lbl_question.Name = "lbl_question";
            this.lbl_question.Size = new System.Drawing.Size(542, 50);
            this.lbl_question.TabIndex = 11;
            this.lbl_question.Text = "Question";
            // 
            // group_score
            // 
            this.group_score.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.group_score.Controls.Add(this.lbl_score);
            this.group_score.Controls.Add(this.btn_seeSolutions);
            this.group_score.Location = new System.Drawing.Point(12, 110);
            this.group_score.Name = "group_score";
            this.group_score.Size = new System.Drawing.Size(550, 277);
            this.group_score.TabIndex = 15;
            this.group_score.TabStop = false;
            this.group_score.Text = "Score";
            this.group_score.Visible = false;
            // 
            // lbl_score
            // 
            this.lbl_score.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_score.Location = new System.Drawing.Point(9, 16);
            this.lbl_score.Name = "lbl_score";
            this.lbl_score.Size = new System.Drawing.Size(535, 199);
            this.lbl_score.TabIndex = 1;
            this.lbl_score.Text = "label1";
            this.lbl_score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_seeSolutions
            // 
            this.btn_seeSolutions.Location = new System.Drawing.Point(215, 218);
            this.btn_seeSolutions.Name = "btn_seeSolutions";
            this.btn_seeSolutions.Size = new System.Drawing.Size(120, 47);
            this.btn_seeSolutions.TabIndex = 0;
            this.btn_seeSolutions.Text = "See Solutions";
            this.btn_seeSolutions.UseVisualStyleBackColor = true;
            this.btn_seeSolutions.Click += new System.EventHandler(this.btn_seeSolutions_Click);
            // 
            // WinFormQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 399);
            this.Controls.Add(this.group_category);
            this.Controls.Add(this.group_amountOfQuestions);
            this.Controls.Add(this.btn_Start);
            this.Controls.Add(this.group_question);
            this.Controls.Add(this.group_score);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WinFormQuiz";
            this.Text = "Win Form Quiz";
            ((System.ComponentModel.ISupportInitialize)(this.numInput_questionsAmount)).EndInit();
            this.group_amountOfQuestions.ResumeLayout(false);
            this.group_category.ResumeLayout(false);
            this.group_question.ResumeLayout(false);
            this.group_options.ResumeLayout(false);
            this.group_score.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.NumericUpDown numInput_questionsAmount;
        private System.Windows.Forms.ComboBox combo_category;
        private System.Windows.Forms.GroupBox group_amountOfQuestions;
        private System.Windows.Forms.GroupBox group_category;
        private System.Windows.Forms.GroupBox group_question;
        private System.Windows.Forms.Label lbl_question;
        private System.Windows.Forms.GroupBox group_options;
        private System.Windows.Forms.FlowLayoutPanel flowLayout_optionsGroup;
        private System.Windows.Forms.Button btn_nextQuestion;
        private System.Windows.Forms.Button btn_previousQuestion;
        private System.Windows.Forms.GroupBox group_score;
        private System.Windows.Forms.Label lbl_score;
        private System.Windows.Forms.Button btn_seeSolutions;
    }
}

