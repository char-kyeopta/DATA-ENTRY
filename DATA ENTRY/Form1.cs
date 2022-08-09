using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DATA_ENTRY
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            StudentNoTextBox.Focus();
            StudentNoTextBox.Clear();
            StudentNameTextBox.Clear();
            CourseTextBox.Clear();
            StudentNoTextBox.Enabled = true;
            StudentNameTextBox.Enabled = true;
            CourseTextBox.Enabled = true;
            NewButton.Enabled = false;
            SaveButton.Enabled = true;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(StudentNoTextBox.Text) || string.IsNullOrEmpty(StudentNameTextBox.Text) || string.IsNullOrEmpty(CourseTextBox.Text))
            {
                MessageBox.Show("Please enter complete data", "Data Entry", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                StudentNoTextBox.Enabled = false;
                StudentNameTextBox.Enabled = false;
                CourseTextBox.Enabled = false;
                SaveButton.Enabled = false;
                NewButton.Enabled = true;
            }
        }

        private void ViewButton_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem(StudentNoTextBox.Text);
            item.SubItems.Add(StudentNameTextBox.Text);
            item.SubItems.Add(CourseTextBox.Text);
            InfoListView.Items.Add(item);
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            InfoListView.Items.Clear();
        }
    }
}
