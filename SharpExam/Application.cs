using SharpExam.Models;
using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace SharpExam
{
    public partial class Application : Form
    {
        private ApplicationModel model;

        public Application()
        {
            InitializeComponent();

            model = new ApplicationModel();

        }


        private void Btn_Login_Click(object sender, EventArgs e)
        {
            using (ApplicationModel loginEntity = new ApplicationModel())
            {
                LabelError.Visible = false;
                foreach (var user in loginEntity.Users)
                {
                    if (user.Username == TxtBoxName.Text)
                    {
                        ActiveUser.ActiveUserId = user.UserId;
                        var frame = new QuestionsForm();
                        frame.Location = this.Location;
                        frame.StartPosition = FormStartPosition.Manual;
                        frame.FormClosing += delegate { this.Show(); };
                        frame.Show();
                        this.Hide();
                    }
                    else LabelError.Visible = true;

                }
            }
        }

        private void Application_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Register_Click(object sender, EventArgs e)
        {
            bool exists = model.Users.Any(x => x.Username == TxtBoxName.Text);

            if (TxtBoxName.Text == "") MessageBox.Show("Please enter name");

            else if (exists)
            {
                MessageBox.Show("Username already exists");
            }


            else if (!(exists))
            {
                Users users = new Users { Username = TxtBoxName.Text };
                model.Users.Add(users);
                model.SaveChanges();
            }
        }
    }
}
