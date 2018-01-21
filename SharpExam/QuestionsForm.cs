using SharpExam.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SharpExam
{
    public partial class QuestionsForm : Form
    {
        private ApplicationModel model;
        public QuestionsForm()
        {
            InitializeComponent();

            model = new ApplicationModel();
        }

        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGrid.CurrentRow == null) return;

            var question = dataGrid.CurrentRow.DataBoundItem as Questions;
            TxtBoxQuestionName.Text = question.QuestionName;
            TxtBoxQuestionAsked.Text = question.QuestionAsked;
            cmbAnswer.SelectedItem = question.Answer;



        }

        private void TxtBoxQuestionName_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_AddQuestion_Click(object sender, EventArgs e)
        {
            
            try
            {
                
                Questions questions = new Questions { QuestionName = TxtBoxQuestionName.Text, QuestionAsked = TxtBoxQuestionAsked.Text,  UserId = ActiveUser.ActiveUserId };
                model.Questions.Add(questions);
                model.SaveChanges();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Please fill all the fields!");
            }
        }

        private void QuestionsForm_Load(object sender, EventArgs e)
        {
            model.Questions.Load();
            dataGrid.DataSource = model.Questions.Local.ToBindingList();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                var question = dataGrid.CurrentRow.DataBoundItem as Questions;

                var db = model.Questions.Where(u => u.QuestionId.Equals(question.QuestionId)).FirstOrDefault();

                model.Questions.Remove(db);
                model.SaveChanges();
            }
            catch (Exception)
            {
                MessageBox.Show("Nothing to delete!");
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            var question = dataGrid.CurrentRow.DataBoundItem as Questions;
            if (question != null)
            {
                question.QuestionName = TxtBoxQuestionName.Text;
                question.QuestionAsked = TxtBoxQuestionAsked.Text;
                question.Answer = cmbAnswer.SelectedItem.ToString();

                model.Entry(question).State = EntityState.Modified;
                model.Questions.AddOrUpdate(question);
                model.SaveChanges();
                dataGrid.Refresh();
            }
            else MessageBox.Show("Please select something!");



        }

        private void button1_Click(object sender, EventArgs e)
        {
            string comboAnswer = cmbAnswer.SelectedItem.ToString();
            
            var question = dataGrid.CurrentRow.DataBoundItem as Questions;

            var db = model.Questions.Where(u => u.QuestionId.Equals(question.QuestionId)).FirstOrDefault();

        }
    }
}
