namespace SharpExam
{
    partial class QuestionsForm
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
            this.components = new System.ComponentModel.Container();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.questionIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.questionNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.questionAskedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.answerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.questionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TxtBoxQuestionAsked = new System.Windows.Forms.TextBox();
            this.LabelQuestionAsked = new System.Windows.Forms.Label();
            this.TxtBoxQuestionName = new System.Windows.Forms.TextBox();
            this.LabelQuestionName = new System.Windows.Forms.Label();
            this.Btn_Add = new System.Windows.Forms.Button();
            this.cmbAnswer = new System.Windows.Forms.ComboBox();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToOrderColumns = true;
            this.dataGrid.AutoGenerateColumns = false;
            this.dataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.questionIdDataGridViewTextBoxColumn,
            this.questionNameDataGridViewTextBoxColumn,
            this.questionAskedDataGridViewTextBoxColumn,
            this.answerDataGridViewTextBoxColumn});
            this.dataGrid.DataSource = this.questionsBindingSource;
            this.dataGrid.Location = new System.Drawing.Point(298, 24);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(413, 311);
            this.dataGrid.TabIndex = 15;
            this.dataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_CellContentClick);
            // 
            // questionIdDataGridViewTextBoxColumn
            // 
            this.questionIdDataGridViewTextBoxColumn.DataPropertyName = "QuestionId";
            this.questionIdDataGridViewTextBoxColumn.HeaderText = "QuestionId";
            this.questionIdDataGridViewTextBoxColumn.Name = "questionIdDataGridViewTextBoxColumn";
            this.questionIdDataGridViewTextBoxColumn.Width = 83;
            // 
            // questionNameDataGridViewTextBoxColumn
            // 
            this.questionNameDataGridViewTextBoxColumn.DataPropertyName = "QuestionName";
            this.questionNameDataGridViewTextBoxColumn.HeaderText = "QuestionName";
            this.questionNameDataGridViewTextBoxColumn.Name = "questionNameDataGridViewTextBoxColumn";
            this.questionNameDataGridViewTextBoxColumn.Width = 102;
            // 
            // questionAskedDataGridViewTextBoxColumn
            // 
            this.questionAskedDataGridViewTextBoxColumn.DataPropertyName = "QuestionAsked";
            this.questionAskedDataGridViewTextBoxColumn.HeaderText = "QuestionAsked";
            this.questionAskedDataGridViewTextBoxColumn.Name = "questionAskedDataGridViewTextBoxColumn";
            this.questionAskedDataGridViewTextBoxColumn.Width = 104;
            // 
            // answerDataGridViewTextBoxColumn
            // 
            this.answerDataGridViewTextBoxColumn.DataPropertyName = "Answer";
            this.answerDataGridViewTextBoxColumn.HeaderText = "Answer";
            this.answerDataGridViewTextBoxColumn.Name = "answerDataGridViewTextBoxColumn";
            this.answerDataGridViewTextBoxColumn.Width = 67;
            // 
            // questionsBindingSource
            // 
            this.questionsBindingSource.DataSource = typeof(SharpExam.Models.Questions);
            // 
            // TxtBoxQuestionAsked
            // 
            this.TxtBoxQuestionAsked.Location = new System.Drawing.Point(31, 121);
            this.TxtBoxQuestionAsked.Multiline = true;
            this.TxtBoxQuestionAsked.Name = "TxtBoxQuestionAsked";
            this.TxtBoxQuestionAsked.Size = new System.Drawing.Size(187, 57);
            this.TxtBoxQuestionAsked.TabIndex = 14;
            // 
            // LabelQuestionAsked
            // 
            this.LabelQuestionAsked.AutoSize = true;
            this.LabelQuestionAsked.Location = new System.Drawing.Point(16, 105);
            this.LabelQuestionAsked.Name = "LabelQuestionAsked";
            this.LabelQuestionAsked.Size = new System.Drawing.Size(68, 13);
            this.LabelQuestionAsked.TabIndex = 13;
            this.LabelQuestionAsked.Text = "Ask question";
            // 
            // TxtBoxQuestionName
            // 
            this.TxtBoxQuestionName.Location = new System.Drawing.Point(118, 78);
            this.TxtBoxQuestionName.Name = "TxtBoxQuestionName";
            this.TxtBoxQuestionName.Size = new System.Drawing.Size(100, 20);
            this.TxtBoxQuestionName.TabIndex = 12;
            this.TxtBoxQuestionName.TextChanged += new System.EventHandler(this.TxtBoxQuestionName_TextChanged);
            // 
            // LabelQuestionName
            // 
            this.LabelQuestionName.AutoSize = true;
            this.LabelQuestionName.Location = new System.Drawing.Point(16, 81);
            this.LabelQuestionName.Name = "LabelQuestionName";
            this.LabelQuestionName.Size = new System.Drawing.Size(95, 13);
            this.LabelQuestionName.TabIndex = 11;
            this.LabelQuestionName.Text = "Questions heading";
            // 
            // Btn_Add
            // 
            this.Btn_Add.Location = new System.Drawing.Point(31, 184);
            this.Btn_Add.Name = "Btn_Add";
            this.Btn_Add.Size = new System.Drawing.Size(100, 23);
            this.Btn_Add.TabIndex = 10;
            this.Btn_Add.Text = "Add";
            this.Btn_Add.UseVisualStyleBackColor = true;
            this.Btn_Add.Click += new System.EventHandler(this.Btn_AddQuestion_Click);
            // 
            // cmbAnswer
            // 
            this.cmbAnswer.FormattingEnabled = true;
            this.cmbAnswer.Items.AddRange(new object[] {
            "Yes",
            "No",
            "Maybe",
            "Hard to tell",
            "Not answering"});
            this.cmbAnswer.Location = new System.Drawing.Point(31, 227);
            this.cmbAnswer.Name = "cmbAnswer";
            this.cmbAnswer.Size = new System.Drawing.Size(121, 21);
            this.cmbAnswer.TabIndex = 16;
            // 
            // btn_Edit
            // 
            this.btn_Edit.Location = new System.Drawing.Point(139, 312);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(100, 23);
            this.btn_Edit.TabIndex = 17;
            this.btn_Edit.Text = "Edit";
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(19, 312);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(100, 23);
            this.btn_Delete.TabIndex = 18;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(169, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Answer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // QuestionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 356);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.cmbAnswer);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.TxtBoxQuestionAsked);
            this.Controls.Add(this.LabelQuestionAsked);
            this.Controls.Add(this.TxtBoxQuestionName);
            this.Controls.Add(this.LabelQuestionName);
            this.Controls.Add(this.Btn_Add);
            this.Name = "QuestionsForm";
            this.Text = "QuestionsForm";
            this.Load += new System.EventHandler(this.QuestionsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.TextBox TxtBoxQuestionAsked;
        private System.Windows.Forms.Label LabelQuestionAsked;
        private System.Windows.Forms.TextBox TxtBoxQuestionName;
        private System.Windows.Forms.Label LabelQuestionName;
        private System.Windows.Forms.Button Btn_Add;
        private System.Windows.Forms.BindingSource questionsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn questionIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn questionNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn questionAskedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn answerDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox cmbAnswer;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button button1;
    }
}