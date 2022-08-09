
namespace DATA_ENTRY
{
    partial class Form1
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
            this.InfoListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.StudentNoTextBox = new System.Windows.Forms.TextBox();
            this.StudentNameTextBox = new System.Windows.Forms.TextBox();
            this.CourseTextBox = new System.Windows.Forms.TextBox();
            this.NewButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.ViewButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // InfoListView
            // 
            this.InfoListView.BackColor = System.Drawing.Color.WhiteSmoke;
            this.InfoListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.InfoListView.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InfoListView.FullRowSelect = true;
            this.InfoListView.GridLines = true;
            this.InfoListView.HideSelection = false;
            this.InfoListView.Location = new System.Drawing.Point(28, 249);
            this.InfoListView.Name = "InfoListView";
            this.InfoListView.Size = new System.Drawing.Size(403, 182);
            this.InfoListView.TabIndex = 0;
            this.InfoListView.UseCompatibleStateImageBehavior = false;
            this.InfoListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Student #";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Student Name";
            this.columnHeader2.Width = 180;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Course";
            this.columnHeader3.Width = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(160, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "DATA ENTRY";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(28, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Student #:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(125, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 27);
            this.label3.TabIndex = 3;
            this.label3.Text = "Student Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(319, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 27);
            this.label4.TabIndex = 4;
            this.label4.Text = "Course:";
            // 
            // StudentNoTextBox
            // 
            this.StudentNoTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.StudentNoTextBox.Location = new System.Drawing.Point(28, 91);
            this.StudentNoTextBox.MaxLength = 3;
            this.StudentNoTextBox.Name = "StudentNoTextBox";
            this.StudentNoTextBox.Size = new System.Drawing.Size(76, 27);
            this.StudentNoTextBox.TabIndex = 5;
            // 
            // StudentNameTextBox
            // 
            this.StudentNameTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.StudentNameTextBox.Location = new System.Drawing.Point(119, 91);
            this.StudentNameTextBox.Name = "StudentNameTextBox";
            this.StudentNameTextBox.Size = new System.Drawing.Size(176, 27);
            this.StudentNameTextBox.TabIndex = 6;
            // 
            // CourseTextBox
            // 
            this.CourseTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CourseTextBox.Location = new System.Drawing.Point(319, 91);
            this.CourseTextBox.Name = "CourseTextBox";
            this.CourseTextBox.Size = new System.Drawing.Size(112, 27);
            this.CourseTextBox.TabIndex = 7;
            // 
            // NewButton
            // 
            this.NewButton.BackColor = System.Drawing.Color.LightCoral;
            this.NewButton.ForeColor = System.Drawing.Color.Snow;
            this.NewButton.Location = new System.Drawing.Point(125, 132);
            this.NewButton.Name = "NewButton";
            this.NewButton.Size = new System.Drawing.Size(94, 29);
            this.NewButton.TabIndex = 8;
            this.NewButton.Text = "New";
            this.NewButton.UseVisualStyleBackColor = false;
            this.NewButton.Click += new System.EventHandler(this.NewButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.LightCoral;
            this.SaveButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.SaveButton.Location = new System.Drawing.Point(225, 132);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(94, 29);
            this.SaveButton.TabIndex = 8;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // ViewButton
            // 
            this.ViewButton.BackColor = System.Drawing.Color.LightCoral;
            this.ViewButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ViewButton.Location = new System.Drawing.Point(28, 210);
            this.ViewButton.Name = "ViewButton";
            this.ViewButton.Size = new System.Drawing.Size(117, 29);
            this.ViewButton.TabIndex = 9;
            this.ViewButton.Text = "View Record";
            this.ViewButton.UseVisualStyleBackColor = false;
            this.ViewButton.Click += new System.EventHandler(this.ViewButton_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.BackColor = System.Drawing.Color.LightCoral;
            this.RemoveButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.RemoveButton.Location = new System.Drawing.Point(296, 210);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(135, 29);
            this.RemoveButton.TabIndex = 10;
            this.RemoveButton.Text = "Remove Record";
            this.RemoveButton.UseVisualStyleBackColor = false;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Red;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(1, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(452, 6);
            this.label5.TabIndex = 11;
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::DATA_ENTRY.Properties.Resources.wallpapers___red_abstract_polygons__white_bg__by_kaminohunter_dau2co6_pre;
            this.ClientSize = new System.Drawing.Size(453, 443);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.ViewButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.NewButton);
            this.Controls.Add(this.CourseTextBox);
            this.Controls.Add(this.StudentNameTextBox);
            this.Controls.Add(this.StudentNoTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InfoListView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.Gray;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView InfoListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox StudentNoTextBox;
        private System.Windows.Forms.TextBox StudentNameTextBox;
        private System.Windows.Forms.TextBox CourseTextBox;
        private System.Windows.Forms.Button NewButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button ViewButton;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Label label5;
    }
}

