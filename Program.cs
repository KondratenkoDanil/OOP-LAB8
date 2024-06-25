using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace TextEditor
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        // Метод відкриття нового вікна редактора
        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditorForm newEditor = new EditorForm();
            newEditor.Show();
        }

        // Метод виходу з програми
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Метод для зміни мови інтерфейсу на англійську
        private void EnglishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeLanguage("en");
        }

        // Метод для зміни мови інтерфейсу на українську
        private void UkrainianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeLanguage("uk");
        }

        // Метод для зміни мови інтерфейсу
        private void ChangeLanguage(string languageCode)
        {
            foreach (Control control in Controls)
            {
                ComponentResourceManager resources = new ComponentResourceManager(typeof(MainForm));
                resources.ApplyResources(control, control.Name, new CultureInfo(languageCode));
            }
        }
    }

    // Форма редактора
    public partial class EditorForm : Form
    {
        public EditorForm()
        {
            InitializeComponent();
        }

        // Метод для вирівнювання тексту зліва
        private void LeftAlignToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.SelectionAlignment = HorizontalAlignment.Left;
        }

        // Метод для вирівнювання тексту по центру
        private void CenterAlignToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.SelectionAlignment = HorizontalAlignment.Center;
        }

        // Метод для вирівнювання тексту справа
        private void RightAlignToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.SelectionAlignment = HorizontalAlignment.Right;
        }
    }
}
