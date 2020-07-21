using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizGame
{
    public partial class Form1 : Form
    {

        int correctAnswer;
        int questionNumber = 1;
        int score;
        int percentage;
        int totalQuestions;
        int time;

        public Form1()
        {
            InitializeComponent();
            timer1.Start();
            askQuestion(questionNumber);
            totalQuestions = 8;
        }

        private void lblQuestion_Click(object sender, EventArgs e)
        {

        }

        private void checkAnswerEvent(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;

            int buttonTag = Convert.ToInt32(senderObject.Tag);

            if (buttonTag == correctAnswer)
            {
                score++;
            }

            if (questionNumber == totalQuestions)
            {

                percentage = (int)Math.Round((double)(score * 100) / totalQuestions);

                MessageBox.Show(
                    "Quiz Ended!" + Environment.NewLine +
                    "You have answered " + score + " questions correctly." + Environment.NewLine +
                    "Your total percentage is " + percentage + "%" + Environment.NewLine +
                    "Click OK to play again"
                    );

                score = 0;
                questionNumber = 0;
                askQuestion(questionNumber);

            }

            questionNumber++;
            askQuestion(questionNumber);

        }

        private void askQuestion(int qnum)
        {
            switch (qnum)
            {
                case 1:
                    pictureBox1.Image = Properties.Resources.Spiderman;

                    lblQuestion.Text = "What is the name of this super hero?";

                    button1.Text = "Spider Man";
                    button2.Text = "Ant Man";
                    button3.Text = "Aqua Man";
                    button4.Text = "Deadpool";

                    correctAnswer = 1;

                    break;
                case 2:
                    pictureBox1.Image = Properties.Resources.IronMan;

                    lblQuestion.Text = "What is the name of the main character from Iron Man?";

                    button1.Text = "Bruce Wayne";
                    button2.Text = "Tony Stark";
                    button3.Text = "Jughead";
                    button4.Text = "Peter Parker";

                    correctAnswer = 2;

                    break;
                case 3:
                    pictureBox1.Image = Properties.Resources.ben10;

                    lblQuestion.Text = "What is the name of the author of this cartoon?";

                    button1.Text = "Benjamin Franklin";
                    button2.Text = "J.K Rowlings";
                    button3.Text = "Walt Disney";
                    button4.Text = "Man of Action";

                    correctAnswer = 4;

                    break;
                case 4:
                    pictureBox1.Image = Properties.Resources.Batman;

                    lblQuestion.Text = "Which Publisher made this character?";

                    button1.Text = "Warner Bros.";
                    button2.Text = "Marvel";
                    button3.Text = "DC Comics";
                    button4.Text = "Disney";

                    correctAnswer = 3;

                    break;

                case 5:
                    pictureBox1.Image = Properties.Resources.CaptainAmerica;

                    lblQuestion.Text = "Whats the name of this super hero?";

                    button1.Text = "Captain America";
                    button2.Text = "Aquilar";
                    button3.Text = "Thor";
                    button4.Text = "Hulk";

                    correctAnswer = 1;

                    break;

                case 6:
                    pictureBox1.Image = Properties.Resources.SonGoku;

                    lblQuestion.Text = "The character above belongs to which comic?";

                    button1.Text = "DC Comic";
                    button2.Text = "Maus";
                    button3.Text = "Manga";
                    button4.Text = "Stormwatch";

                    correctAnswer = 3;

                    break;

                case 7:
                    pictureBox1.Image = Properties.Resources.superman;

                    lblQuestion.Text = "What is the name of the main character from Superman??";

                    button1.Text = "Peter Parker";
                    button2.Text = "Bruce Wayne";
                    button3.Text = "Clark Kent";
                    button4.Text = "Tony Stark";

                    correctAnswer = 3;

                    break;

                case 8:
                    pictureBox1.Image = Properties.Resources.Robin;

                    lblQuestion.Text = "What is the name of this character?";

                    button1.Text = "Beast Boy";
                    button2.Text = "Star Fire";
                    button3.Text = "Cyborg";
                    button4.Text = "Robin";

                    correctAnswer = 4;

                    break;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time++;
            lblTimer.Text = time.ToString();
        }
    }
}
