using System.Runtime.CompilerServices;

namespace ILove3d
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var frm = new Form2();
            frm.Show();
        }

        private void form2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm1 = new Form2();
            frm1.MdiParent = this;
            frm1.Show();
        }

        private void form3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm3 = new Form3();
            frm3 = new Form3();
            frm3.MdiParent = this;
            frm3.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach(Control control in this.Controls )
            {
                if(control is MdiClient)
                {
                    control.BackColor = Color.DarkRed;
                    break;
                }
            }
        }
    }
}