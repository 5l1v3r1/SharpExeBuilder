using System;
using System.IO;
using System.Windows.Forms;

namespace Builder
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void bBuild_Click(object sender, EventArgs e)
        {
            using(SaveFileDialog fSaveDialog = new SaveFileDialog())
            {
                fSaveDialog.Filter = "Executable(*.exe)|*.exe";
                
                if(fSaveDialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllBytes(fSaveDialog.FileName, Properties.Resources.Stub);

                    using(FileStream fStream = new FileStream(fSaveDialog.FileName, FileMode.Open))
                    {
                        fStream.Position = 0xE0A;
                        
                        foreach(byte bByte in System.Text.Encoding.Default.GetBytes(tText.Text))
                        {
                            fStream.WriteByte(bByte);
                        }
                    }
                }
            }
        }
    }
}
