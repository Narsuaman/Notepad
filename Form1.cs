namespace Notepad
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }


        private void undoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox.Undo();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox.Copy();

        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox.Paste();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox.Cut();
        }

        private void redoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox.Redo();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox.SelectAll();

        }

    }
}