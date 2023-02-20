using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Binary2Decimal
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void dec_Click(object sender, EventArgs e)
		{
			if (binIn.Text != "")
			{
				decOut.Text = Converters.ConvertToDecimal(binIn.Text).ToString();
			}
			else
			{
				MessageBox.Show("Please type a binary expression in the box.", "No text", MessageBoxButtons.OK, MessageBoxIcon.Question);
			}
			
		}

		private void binary_Click(object sender, EventArgs e)
		{
			if (decIn.Text != "")
			{
				binaryOut.Text = Converters.ConvertToBinary(decIn.Text);
			}
			else
			{
				MessageBox.Show("Please type a number in the box.", "No text", MessageBoxButtons.OK, MessageBoxIcon.Question);
			}
		}
	}
}
