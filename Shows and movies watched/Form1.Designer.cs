namespace Shows_and_movies_watched
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listView1 = new ListView();
            columnTitle = new ColumnHeader();
            columnCatagory = new ColumnHeader();
            columnRating = new ColumnHeader();
            columnDescription = new ColumnHeader();
            btnDelete = new Button();
            label1 = new Label();
            linkLabel1 = new LinkLabel();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnTitle, columnCatagory, columnRating, columnDescription });
            listView1.Location = new Point(27, 177);
            listView1.Name = "listView1";
            listView1.Size = new Size(495, 234);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnTitle
            // 
            columnTitle.Text = "Title";
            columnTitle.Width = 100;
            // 
            // columnCatagory
            // 
            columnCatagory.Text = "Catagory";
            columnCatagory.Width = 100;
            // 
            // columnRating
            // 
            columnRating.Text = "Rating /10";
            columnRating.Width = 90;
            // 
            // columnDescription
            // 
            columnDescription.Text = "Description";
            columnDescription.Width = 200;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(0, 0, 192);
            btnDelete.Font = new Font("Broadway", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(561, 261);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 51);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Delete and Save";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Broadway", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(173, 9);
            label1.Name = "label1";
            label1.Size = new Size(334, 24);
            label1.TabIndex = 2;
            label1.Text = "Movie and TV Show Rating";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Broadway", 9F, FontStyle.Bold, GraphicsUnit.Point);
            linkLabel1.Location = new Point(439, 160);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(83, 14);
            linkLabel1.TabIndex = 3;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Add New +";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(674, 449);
            Controls.Add(linkLabel1);
            Controls.Add(label1);
            Controls.Add(btnDelete);
            Controls.Add(listView1);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private ColumnHeader columnTitle;
        private ColumnHeader columnCatagory;
        private ColumnHeader columnRating;
        private ColumnHeader columnDescription;
        private Button btnDelete;
        private Label label1;
        private LinkLabel linkLabel1;
    }
}