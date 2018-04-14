using System;
using System.Windows.Forms;

namespace TestXmlTransform
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void BtnXml_Click(object sender, EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog();
            if (od.ShowDialog() == DialogResult.OK)
                Xslt.xml = od.OpenFile();
        }

        private void BtnXslt_Click(object sender, EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog();
            if (od.ShowDialog() == DialogResult.OK)
                Xslt.xslt = od.OpenFile();
        }

        private void BtnRun_Click(object sender, EventArgs e)
        {
            Xslt.transform(outPath.Text, OutFName.Text, OutFExt.Text);
        }
    }

}
