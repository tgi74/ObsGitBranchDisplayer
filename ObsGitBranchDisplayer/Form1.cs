using System;
using System.IO;
using System.Windows.Forms;

namespace ObsGitBranchDisplayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string GetBranchName(string url)
        {
            return File.ReadAllText(url).Split('/')[2];
        }

        private void onFromClick(object sender, EventArgs args)
        {
            DialogResult r = openFileDialog1.ShowDialog();
            if(r == DialogResult.OK)
            {
                textboxFrom.Text = openFileDialog1.FileName;
            }
        }

        private void onTxtClick(object sender, EventArgs args)
        {
            DialogResult r = openFileDialog1.ShowDialog();
            if (r == DialogResult.OK)
            {
                textBoxTxt.Text = openFileDialog1.FileName;
            }
        }

        private void onFormatClick(object sender, EventArgs args)
        {
            DialogResult r = openFileDialog1.ShowDialog();
            if (r == DialogResult.OK)
            {
                textBoxFormat.Text = openFileDialog1.FileName;
            }
        }

        private void readTimer_Tick(object sender, EventArgs e)
        {
            if(textboxFrom.Text != null && textboxFrom.Text != "")
                File.WriteAllText("branch.txt", string.Format(textBoxFormat.Text, GetBranchName(textboxFrom.Text)));
        }
    }
}
