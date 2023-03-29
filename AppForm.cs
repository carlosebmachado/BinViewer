using BinViewer.Utils;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace BinViewer
{
    public partial class AppForm : Form
    {
        private bool _fileOpen = false;
        private byte[] _file;

        private bool _started = false;

        public AppForm()
        {
            InitializeComponent();
        }

        private void MainFormLoad(object sender, EventArgs e)
        {
            cboViewMode.SelectedIndex = 4;
            cboBytesByLine.SelectedIndex = 3;
            cboBytesByGroup.SelectedIndex = 1;

            tsslFileName.Text = "No file";
            tsslViewMode.Text = lblViewMode.Text + ": " + cboViewMode.Items[cboViewMode.SelectedIndex].ToString();
            tsslBytesByLine.Text = lblBytesByLine.Text + ": " + cboBytesByLine.Items[cboBytesByLine.SelectedIndex].ToString();
            tsslBytesByGroup.Text = lblBytesByGroup.Text + ": " + cboBytesByGroup.Items[cboBytesByGroup.SelectedIndex].ToString();

            _started = true;
        }

        private void OpenFile(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
        }

        [Obsolete]
        private void CloseFile(object sender, EventArgs e)
        {
            rtbFileViewer.Text = "";
            _fileOpen = false;
            tsslFileName.Text = "No file";
        }

        private void SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!_started) return;

            tsslViewMode.Text = lblViewMode.Text + ": " + cboViewMode.Items[cboViewMode.SelectedIndex].ToString();
            tsslBytesByLine.Text = lblBytesByLine.Text + ": " + cboBytesByLine.Items[cboBytesByLine.SelectedIndex].ToString();
            tsslBytesByGroup.Text = lblBytesByGroup.Text + ": " + cboBytesByGroup.Items[cboBytesByGroup.SelectedIndex].ToString();

            if (sender == cboViewMode)
            {
                int i = cboViewMode.SelectedIndex;
                if (i == Constants.ASCII || i == Constants.UTF8 || i == Constants.BASE64)
                {
                    cboBytesByLine.Enabled = false;
                    cboBytesByGroup.Enabled = false;

                    tsslBytesByLine.Text = lblBytesByLine.Text + ": -";
                    tsslBytesByGroup.Text = lblBytesByGroup.Text + ": -";
                }
                else
                {
                    cboBytesByLine.Enabled = true;
                    cboBytesByGroup.Enabled = true;
                }
            }

            if (cboBytesByGroup.SelectedIndex > cboBytesByLine.SelectedIndex)
            {
                cboBytesByGroup.SelectedIndex = cboBytesByLine.SelectedIndex;
            }

            if (_fileOpen)
            {
                ShowFileUpdate();
            }
        }

        private void LoadFile(object sender, CancelEventArgs e)
        {
            _file = File.ReadAllBytes(openFileDialog.FileName);
            var sp = openFileDialog.FileName.Split('\\');
            var name = sp[sp.Length - 1];
            tsslFileName.Text = "File name: " + name;
            _fileOpen = true;
            ShowFileUpdate();
        }

        private void ShowFileUpdate()
        {
            int viewMode = cboViewMode.SelectedIndex;
            int bytesByLine = int.Parse(cboBytesByLine.Items[cboBytesByLine.SelectedIndex].ToString()[0].ToString());
            int byteGroupSize = int.Parse(cboBytesByGroup.Items[cboBytesByGroup.SelectedIndex].ToString()[0].ToString());
            string newText = "";

            switch (viewMode)
            {
                case Constants.BIT:
                    {
                        newText = CustomEncoding.ToBitString(_file, bytesByLine, byteGroupSize);
                        break;
                    }
                case Constants.BYTE:
                    {
                        newText = CustomEncoding.ToByteString(_file, bytesByLine, byteGroupSize);
                        break;
                    }
                case Constants.OCTAL:
                    {
                        newText = CustomEncoding.ToOctalString(_file, bytesByLine, byteGroupSize);
                        break;
                    }
                case Constants.DECIMAL:
                    {
                        newText = CustomEncoding.ToDecimalString(_file, bytesByLine, byteGroupSize);
                        break;
                    }
                case Constants.HEXADECIMAL:
                    {
                        newText = CustomEncoding.ToHexadecimalString(_file, bytesByLine, byteGroupSize);
                        break;
                    }
                case Constants.ASCII:
                    {
                        newText += Encoding.ASCII.GetString(_file, 0, _file.Length);
                        break;
                    }
                case Constants.UTF8:
                    {
                        newText += Encoding.UTF8.GetString(_file, 0, _file.Length);
                        break;
                    }
                case Constants.BASE64:
                    {
                        newText += Convert.ToBase64String(_file);
                        break;
                    }
            }

            //lc-3 = big endian
            //windows = little endian

            rtbFileViewer.Text = newText;
        }

        private void tsmiNumericBaseConverter_Click(object sender, EventArgs e)
        {
            new NumericBaseConverterForm().ShowDialog();
        }

        private void tsmiAbout_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/carlosebmachado/BinViewer");
        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
