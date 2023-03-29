using BinViewer.Utils;
using System;
using System.Windows.Forms;

namespace BinViewer
{
    public partial class NumericBaseConverterForm : Form
    {
        private bool _hexTyped = false;
        private bool _binTyped = false;
        private bool _decTyped = false;
        private bool _octTyped = false;

        public NumericBaseConverterForm()
        {
            InitializeComponent();
        }

        private void TBsKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
            {
                ((TextBox)sender).SelectAll();
            }

            if (e.Control && e.KeyCode == Keys.X)
            {
                ((TextBox)sender).Cut();
            }

            if (e.Control && e.KeyCode == Keys.C)
            {
                ((TextBox)sender).Copy();
            }

            if (e.Control && e.KeyCode == Keys.V)
            {
                ((TextBox)sender).Paste();
            }

            if (e.Control && e.KeyCode == Keys.Z)
            {
                ((TextBox)sender).Undo();
            }

            if (e.KeyCode == Keys.Escape)
            {
                ((TextBox)sender).DeselectAll();
            }

            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Delete)
            {
                if ((TextBox)sender == txtHexadecimal)
                {
                    _hexTyped = true;
                }
                else if ((TextBox)sender == txtBinary)
                {
                    _binTyped = true;
                }
                else if ((TextBox)sender == txtDecimal)
                {
                    _decTyped = true;
                }
                else if ((TextBox)sender == txtOctal)
                {
                    _octTyped = true;
                }
                UpdateTBs((TextBox)sender);
            }
        }

        private bool HexadecimalValidKey(char c)
        {
            return char.IsDigit(c) || c == (char)8 ||
                (c >= 'a' && c <= 'f') || (c >= 'A' && c <= 'F');
        }

        private bool BinaryValidKey(char c)
        {
            return c == '0' || c == '1' || c == (char)8;
        }

        private bool DecimalValidKey(char c)
        {
            return char.IsDigit(c) || c == (char)8;
        }

        private bool OctalValidKey(char c)
        {
            return (c >= '0' && c <= '7') || c == (char)8;
        }

        private void TBsKeyPress(object sender, KeyPressEventArgs e)
        {
            if ((TextBox)sender == txtHexadecimal)
            {
                _hexTyped = true;
                if (!HexadecimalValidKey(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
            else if ((TextBox)sender == txtBinary)
            {
                _binTyped = true;
                if (!BinaryValidKey(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
            else if ((TextBox)sender == txtDecimal)
            {
                _decTyped = true;
                if (!DecimalValidKey(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
            else if ((TextBox)sender == txtOctal)
            {
                _octTyped = true;
                if (!OctalValidKey(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

        private void TBsTextChanged(object sender, EventArgs e)
        {
            UpdateTBs((TextBox)sender);
        }

        private void UpdateTBs(TextBox textBox)
        {
            var val = textBox.Text;

            if (val.Equals(""))
            {
                txtHexadecimal.Text = "";
                txtBinary.Text = "";
                txtDecimal.Text = "";
                txtOctal.Text = "";
                return;
            }

            if (_hexTyped)
            {
                _hexTyped = false;
                val = val.ToUpper();
                if (val.Length > 16)
                {
                    val = val.Substring(0, 16);
                }
                txtHexadecimal.Text = val;
                txtHexadecimal.SelectionStart = val.Length;
                txtHexadecimal.SelectionLength = 0;
                txtBinary.Text = StringBaseConverter.HexToBit(val);
                txtDecimal.Text = StringBaseConverter.HexToDec(val);
                txtOctal.Text = StringBaseConverter.HexToOct(val);
            }
            else if (_binTyped)
            {
                _binTyped = false;
                if (val.Length > 64)
                {
                    val = val.Substring(0, 64);
                    txtBinary.Text = val;
                }
                txtHexadecimal.Text = StringBaseConverter.BinToHex(val);
                txtDecimal.Text = StringBaseConverter.BinToDec(val);
                txtOctal.Text = StringBaseConverter.BinToOct(val);
            }
            else if (_decTyped)
            {
                _decTyped = false;
                try
                {
                    txtHexadecimal.Text = StringBaseConverter.DecToHex(val);
                    txtBinary.Text = StringBaseConverter.DecToBin(val);
                    txtOctal.Text = StringBaseConverter.DecToOct(val);
                }
                catch
                {
                    val = ulong.MaxValue.ToString();
                    txtDecimal.Text = val;

                    txtHexadecimal.Text = StringBaseConverter.DecToHex(val);
                    txtBinary.Text = StringBaseConverter.DecToBin(val);
                    txtOctal.Text = StringBaseConverter.DecToOct(val);
                }
            }
            else if (_octTyped)
            {
                _octTyped = false;
                try
                {
                    txtHexadecimal.Text = StringBaseConverter.OctToHex(val);
                    txtBinary.Text = StringBaseConverter.OctToBin(val);
                    txtDecimal.Text = StringBaseConverter.OctToDec(val);
                }
                catch
                {
                    val = "1777777777777777777777";
                    txtOctal.Text = val;

                    txtHexadecimal.Text = StringBaseConverter.OctToHex(val);
                    txtBinary.Text = StringBaseConverter.OctToBin(val);
                    txtDecimal.Text = StringBaseConverter.OctToDec(val);
                }
            }
        }
    }
}
