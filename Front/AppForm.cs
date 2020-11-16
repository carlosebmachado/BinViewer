using BinViewer.Back;
using System;
using System.Collections;
using System.ComponentModel;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace BinViewer.Front
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

			cboViewMode.DropDownStyle = ComboBoxStyle.DropDownList;
			cboBytesByLine.DropDownStyle = ComboBoxStyle.DropDownList;
			cboBytesByGroup.DropDownStyle = ComboBoxStyle.DropDownList;

			tsslViewMode.Text = lblViewMode.Text + ": " + cboViewMode.Items[cboViewMode.SelectedIndex].ToString();
			tsslBytesByLine.Text = lblBytesByLine.Text + ": " + cboBytesByLine.Items[cboBytesByLine.SelectedIndex].ToString();
			tsslBytesByGroup.Text = lblBytesByGroup.Text + ": " + cboBytesByGroup.Items[cboBytesByGroup.SelectedIndex].ToString();

			_started = true;
		}

		private void Open(object sender, EventArgs e)
		{
			openFileDialog.ShowDialog();
		}

		private void Close(object sender, EventArgs e)
		{
			rtbFileViewer.Text = "";
			_fileOpen = false;
			tsslFileName.Text = "File name: -";
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
				if (i == Const.ASCII || i == Const.UTF8 || i == Const.BASE64)
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
			var name = sp[sp.Length-1];
			tsslFileName.Text = "File name: " + name;
			_fileOpen = true;
			ShowFileUpdate();
		}

		private void ShowFileUpdate()
		{
			int encode = cboViewMode.SelectedIndex;
			int bbline = int.Parse(cboBytesByLine.Items[cboBytesByLine.SelectedIndex].ToString()[0].ToString());
			int bgroup = int.Parse(cboBytesByGroup.Items[cboBytesByGroup.SelectedIndex].ToString()[0].ToString());

			string newText = "";
			int lCount = 0;
			int gCount = 0;
			int line = 1;

			switch (encode)
			{
				case Const.BIT:
					{
						var bitFile = new BitArray(_file);

						//bbline *= 8;
						//bgroup *= 8;
						//MessageBox.Show("Bytes: " + _file.Length + "\nBits: " + bitFile.Length);
						//MessageBox.Show("Bytes by line: " + bbline + "\nByte group: " + bgroup);

						newText += line + "\t";

						for (int i = 0; i < bitFile.Length; i += 8)
						{
							for (int j = i + 7; j >= i; j--)
							{
								if (bitFile[j])
								{
									newText += "1";
								}
								else
								{
									newText += "0";
								}
							}

							lCount++;
							gCount++;
							if (gCount >= bgroup)
							{
								newText += " ";
								gCount = 0;
							}
							if (lCount >= bbline)
							{
								line++;
								newText += "\n" + line + "\t";
								lCount = 0;
							}
						}

						break;
					}
				case Const.BYTE:
					{
						newText += line + "\t";
						foreach (var b in _file)
						{
							if (b < 10)
							{
								newText += "00" + b;
							}
							else if (b < 100)
							{
								newText += "0" + b;
							}
							else
							{
								newText += b;
							}

							lCount++;
							gCount++;
							if (gCount >= bgroup)
							{
								newText += " ";
								gCount = 0;
							}
							if (lCount >= bbline)
							{
								line++;
								newText += "\n" + line + "\t";
								lCount = 0;
							}
						}

						break;
					}
				case Const.OCTAL:
					{
						newText += line + "\t";
						foreach (var b in _file)
						{
							string sb8 = Convert.ToString(b, 8);
							
							if (sb8.Length == 1)
							{
								newText += "00" + sb8;
							}
							else if (sb8.Length == 2)
							{
								newText += "0" + sb8;
							}
							else
							{
								newText += sb8;
							}

							lCount++;
							gCount++;
							if (gCount >= bgroup)
							{
								newText += " ";
								gCount = 0;
							}
							if (lCount >= bbline)
							{
								line++;
								newText += "\n" + line + "\t";
								lCount = 0;
							}
						}

						break;
					}
				case Const.DECIMAL:
					{
						newText += line + "\t";
						foreach (var b in _file)
						{
							string sb10 = Convert.ToString(b, 10);

							if (sb10.Length == 1)
							{
								newText += "00" + sb10;
							}
							else if (sb10.Length == 2)
							{
								newText += "0" + sb10;
							}
							else
							{
								newText += sb10;
							}

							lCount++;
							gCount++;
							if (gCount >= bgroup)
							{
								newText += " ";
								gCount = 0;
							}
							if (lCount >= bbline)
							{
								line++;
								newText += "\n" + line + "\t";
								lCount = 0;
							}
						}

						break;
					}
				case Const.HEXADECIMAL:
					{
						newText += line + "\t";
						foreach (var b in _file)
						{
							string sb16 = Convert.ToString(b, 16);

							if (sb16.Length == 1)
							{
								newText += "0" + sb16;
							}
							else
							{
								newText += sb16;
							}

							lCount++;
							gCount++;
							if (gCount >= bgroup)
							{
								newText += " ";
								gCount = 0;
							}
							if (lCount >= bbline)
							{
								line++;
								newText += "\n" + line + "\t";
								lCount = 0;
							}
						}

						break;
					}
				case Const.ASCII:
					{
						newText += Encoding.ASCII.GetString(_file,0,_file.Length);

						break;
					}
				case Const.UTF8:
					{
						newText += Encoding.UTF8.GetString(_file, 0, _file.Length);

						break;
					}
				case Const.BASE64:
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
			new NumericBaseConverterForm().Show();
		}
	}
}
