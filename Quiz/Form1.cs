using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //variables
        int timeLeft = 600, min, sec;
        int trueAnswers = 0;

        private void buttonStart_Click(object sender, EventArgs e)
        {
            labelGL.Text += textBox1.Text;
            panel1.Visible = false;
            timer1.Enabled = true;
        }

        private void buttonfinish_Click(object sender, EventArgs e)
        {
            result();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(timeLeft > 0)
            {
                timeLeft -= 1;
                min = timeLeft / 60;
                sec = timeLeft % 60;
                labelTime.Text = "Remaining Time " + min.ToString() + ":";

                //baraye neshan dadande sanie haye yek raqami ba yek sefr qabl az an
                if (sec > 9) labelTime.Text += sec.ToString();
                else labelTime.Text += "0" + sec.ToString();
            }
            else
            {
                timer1.Stop();
                result();
            }
        }

        void result()
        {
            //pishfarz javabe hame soalat gozine 2 hastand!
            if (radioButton1_2.Checked == true) trueAnswers += 1;
            if (radioButton2_2.Checked == true) trueAnswers += 1;
            if (radioButton3_2.Checked == true) trueAnswers += 1;
            if (radioButton4_2.Checked == true) trueAnswers += 1;
            if (radioButton5_2.Checked == true) trueAnswers += 1;
            if (radioButton6_2.Checked == true) trueAnswers += 1;
            if (radioButton7_2.Checked == true) trueAnswers += 1;
            if (radioButton8_2.Checked == true) trueAnswers += 1;
            if (radioButton9_2.Checked == true) trueAnswers += 1;
            if (radioButton10_2.Checked == true) trueAnswers += 1;
            if (radioButton11_2.Checked == true) trueAnswers += 1;
            if (radioButton12_2.Checked == true) trueAnswers += 1;
            if (radioButton13_2.Checked == true) trueAnswers += 1;
            if (radioButton14_2.Checked == true) trueAnswers += 1;
            if (radioButton15_2.Checked == true) trueAnswers += 1;
            if (radioButton16_2.Checked == true) trueAnswers += 1;
            if (radioButton17_2.Checked == true) trueAnswers += 1;
            if (radioButton18_2.Checked == true) trueAnswers += 1;
            if (radioButton19_2.Checked == true) trueAnswers += 1;
            if (radioButton20_2.Checked == true) trueAnswers += 1;

            //mohasebeye darsade pasokhe sahih ba tavajoh be nomre manfi
            //falseAnswers = 20 - trueAnswers
            float accuracy = (trueAnswers - ((20 - trueAnswers) / 3)) * 5;
            if (accuracy >= 50)
                MessageBox.Show("Congratulations! you answered " + trueAnswers
                + " out of 20 questions. Your accuracy rate is " + accuracy + "%", "You passed the Quiz!"
                , MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Oops, Sorry! you answered " + trueAnswers
                + " out of 20 questions. Your accuracy rate is " + accuracy + "%", "You failed the Quiz!"
                , MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
