using QuestPDF.Infrastructure;
using System;
using System.Windows.Forms;

namespace QuestPdfIssue914Repro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            QuestPDF.Settings.License = LicenseType.Professional;
        }
    }
}
