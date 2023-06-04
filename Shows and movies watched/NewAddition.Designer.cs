namespace Shows_and_movies_watched
{
    partial class NewAddition
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
            txtCatagory = new TextBox();
            txtRating = new TextBox();
            txtDescription = new TextBox();
            txtTitle = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnSave = new Button();
            SuspendLayout();
            // 
            // txtCatagory
            // 
            txtCatagory.Location = new Point(93, 143);
            txtCatagory.Name = "txtCatagory";
            txtCatagory.Size = new Size(147, 23);
            txtCatagory.TabIndex = 0;
            // 
            // txtRating
            // 
            txtRating.Location = new Point(93, 203);
            txtRating.Name = "txtRating";
            txtRating.Size = new Size(147, 23);
            txtRating.TabIndex = 1;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(311, 143);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(229, 83);
            txtDescription.TabIndex = 2;
            txtDescription.TextChanged += textBox3_TextChanged;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(93, 82);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(147, 23);
            txtTitle.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Broadway", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(93, 64);
            label1.Name = "label1";
            label1.Size = new Size(35, 14);
            label1.TabIndex = 4;
            label1.Text = "Title";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Broadway", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(311, 125);
            label2.Name = "label2";
            label2.Size = new Size(80, 14);
            label2.TabIndex = 5;
            label2.Text = "Description";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Broadway", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(93, 185);
            label3.Name = "label3";
            label3.Size = new Size(107, 14);
            label3.TabIndex = 6;
            label3.Text = "Rating out of 10";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Broadway", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(93, 125);
            label4.Name = "label4";
            label4.Size = new Size(63, 14);
            label4.TabIndex = 7;
            label4.Text = "Catagory";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(0, 0, 192);
            btnSave.Font = new Font("Broadway", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(253, 266);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 8;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // NewAddition
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(633, 301);
            Controls.Add(btnSave);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtTitle);
            Controls.Add(txtDescription);
            Controls.Add(txtRating);
            Controls.Add(txtCatagory);
            Name = "NewAddition";
            Text = "NewAddition";
            Load += NewAddition_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCatagory;
        private TextBox txtRating;
        private TextBox txtDescription;
        private TextBox txtTitle;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnSave;
    }
}