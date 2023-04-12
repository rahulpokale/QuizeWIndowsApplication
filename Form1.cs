using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace QuizeWIndowsApplication
{
    public partial class Form1 : Form
    {
        private int timerTicks = 0;
        private int index = 0;
        private float obtainedMarks = 0;
        private float totalMarks = 0;
        private float percentage = 0;
        FlowLayoutPanel pnl = new FlowLayoutPanel();
        
        private class Questions
        {
            public string Question { get; set; }
            public List<string> Options { get; set; }
            public string RightAnswer { get; set; }
            public int Marks { get; set; }
        }

        private List<Questions> questions = new List<Questions>
        {
            new Questions
            {
                Question = "What is the largest continent in the world?",
                Options = new List<string> { "North America", "Europe", "Asia", "Australia" },
                RightAnswer = "Asia",
                Marks = 10
            },
            new Questions
            {
                Question = "Which planet is known as the Red Planet?",
                Options = new List<string> { "Venus", "Mars", "Saturn", "Jupiter" },
                RightAnswer = "Mars",
                Marks = 5
            },
            new Questions
            {
                Question = "Who discovered the theory of relativity?",
                Options = new List<string> { "Isaac Newton", "Albert Einstein", "Galileo Galilei", "Stephen Hawking" },
                RightAnswer = "Albert Einstein",
                Marks = 10
            },
            new Questions
            {
                Question = "Which river is the longest river in the world?",
                Options = new List<string> { "Amazon River", "Yangtze River", "Nile River", "Mississippi River" },
                RightAnswer = "Nile River",
                Marks = 8
            },
            new Questions
            {
                Question = "Which is the largest bird in the world?",
                Options = new List<string> { "Ostrich", "Eagle", "Albatross", "Penguin" },
                RightAnswer = "Ostrich",
                Marks = 4
            }
        };

        public Form1()
        {
            InitializeComponent();
            List<String> instructionList = new List<String>
            {
                "* Each question will have 4 options.",
                "* You will get 10 seconds for each question.",
                "* Each question may have different marks.",
                "* After all questions, result will be displayed at the end."
            };

            instructionText.Text = String.Join(Environment.NewLine, instructionList);
            pnl.Dock = DockStyle.None;
            pnl.Location = new System.Drawing.Point(60, 128);
            pnl.Height = 300;
            pnl.Width = 300;
            pnl.Left = 220;
        }

        private void start_btn_Click(object sender, EventArgs e)
        {
            start_btn.Visible = false;
            next_btn.Visible = true;
            timeTicks_lbl.Visible = true;
            instructionText.Visible = false;

            DisplayQuestionAndOptions();
        }

        private void next_btn_Click(object sender, EventArgs e)
        {
            NextQuestion();
        }

        private void NextQuestion()
        {
            RadioButton rbSelected = pnl.Controls
                                     .OfType<RadioButton>()
                                     .FirstOrDefault(r => r.Checked);
            if (rbSelected != null && rbSelected.Text == questions[index - 1].RightAnswer)
            {
                obtainedMarks += questions[index - 1].Marks;
            }

            if (index != questions.Count)
            {
                DisplayQuestionAndOptions();
            }
            else
            {
                pnl.Controls.Clear();
                next_btn.Visible = false;
                timeTicks_lbl.Visible = false;

                percentage = (int)Math.Round((double)(obtainedMarks * 100) / totalMarks);
                result_lbl.Text = "Obtained Marks is : " + obtainedMarks + " / out of "+ totalMarks +(" + percentage + "%)";
                result_lbl.Visible = true;
            }
        }

        private void DisplayQuestionAndOptions()
        {
            question_timer.Stop();
            timerTicks = 0;
            pnl.Controls.Clear();

            Label lblobj = new Label();
            lblobj.Text = questions[index].Question + Environment.NewLine;
            lblobj.Font = new Font(lblobj.Font, lblobj.Font.Style | FontStyle.Bold);
            lblobj.BackColor = Color.Transparent;
            lblobj.ForeColor = Color.Black;
            lblobj.AutoSize = true;
            pnl.Controls.Add(lblobj);

            RadioButton[] questionOptions = new RadioButton[questions[index].Options.Count];
            totalMarks += questions[index].Marks;
            for (int i = 0; i < questions[index].Options.Count; i++)
            {
                questionOptions[i] = new RadioButton
                {
                    Name = "option_" + i,
                    Text = questions[index].Options[i],
                    AutoSize = true,
                    Font = new System.Drawing.Font("Calibri", 11F, FontStyle.Regular),
                };

                pnl.Controls.Add(questionOptions[i]);
            }
            this.Controls.Add(pnl);
            index++;

            question_timer.Start();
        }

        private void question_timer_Tick(object sender, EventArgs e)
        {
            timerTicks++;
            timeTicks_lbl.Text = timerTicks.ToString() + " seconds !";

            if (timerTicks == 10)
            {
                timeTicks_lbl.Text = "Times Up !";
                question_timer.Stop();
                timerTicks = 0;
                NextQuestion();
            }
        }
    }
}
