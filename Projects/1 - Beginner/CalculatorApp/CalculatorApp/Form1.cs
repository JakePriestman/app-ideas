using System;
using System.Data;
using System.Windows.Forms;

namespace CalculatorApp
{
	public partial class Calculator : Form
	{
		string equation = "";
		public Calculator()
		{
			InitializeComponent();
			this.Width = 350;
			this.Height = 550;
			this.Text = "Calculator";
		}

		private void NUMBER_Click(object sender, EventArgs e)
		{
			this.TEXT.Text += (sender as Button).Text;
		}

		private void DIVIDE_Click(object sender, EventArgs e)
		{
			if(this.TEXT.Text != null || this.TEXT.Text != "")
			{
				if (!TEXT.Text.Contains("(") || TEXT.Text.Contains("(") && TEXT.Text.Contains(")"))
				{
					this.TEXT.Text += "÷";
					equation = this.TEXT.Text;
					equationText.Text = equation;
					this.TEXT.Text = ""; 
				}
				else
				{
					this.TEXT.Text += "÷";
				}
			}
		}

		private void MULTIPLY_Click(object sender, EventArgs e)
		{
			if (this.TEXT.Text != null || this.TEXT.Text != "")
			{
				if (!TEXT.Text.Contains("(") || TEXT.Text.Contains("(") && TEXT.Text.Contains(")"))
				{
					this.TEXT.Text += "x";
					equation = this.TEXT.Text;
					equationText.Text = equation;
					this.TEXT.Text = "";
				}
				else
				{
					this.TEXT.Text += "x";
				}
			}
		}

		private void PLUS_Click(object sender, EventArgs e)
		{
			if (this.TEXT.Text != null || this.TEXT.Text != "")
			{
				if (!TEXT.Text.Contains("(") || TEXT.Text.Contains("(") && TEXT.Text.Contains(")"))
				{
					this.TEXT.Text += "+";
					equation = this.TEXT.Text;
					equationText.Text = equation;
					this.TEXT.Text = "";
				}
				else
				{
					this.TEXT.Text += "+";
				}
			}
		}

		private void MINUS_Click(object sender, EventArgs e)
		{
			if (this.TEXT.Text != null || this.TEXT.Text != "")
			{
				if (!TEXT.Text.Contains("(") || TEXT.Text.Contains("(") && TEXT.Text.Contains(")"))
				{
					this.TEXT.Text += "-";
					equation = this.TEXT.Text;
					equationText.Text = equation;
					this.TEXT.Text = "";
				}
				else
				{
					this.TEXT.Text += "-";
				}
			}
		}

		private void EQUALS_Click(object sender, EventArgs e)
		{
			equation += this.TEXT.Text;
			equationText.Text = equation + "=";
			string formattedCalculation = equation.ToString().Replace("x", "*").ToString().Replace("÷", "/");
			try
			{
				this.TEXT.Text = new DataTable().Compute(formattedCalculation, null).ToString();
			}
			catch(Exception ex)
			{
				throw;
			}
		}

		private void CLEAR_Click(object sender, EventArgs e)
		{
			TEXT.Text = "";
			equation = "";
			equationText.Text = equation;
		}

		private void CLEARENTRY_Click(object sender, EventArgs e)
		{
			if(TEXT.Text != "" && !equationText.Text.Contains("="))
			{
				TEXT.Text = "";
			}
		}

		private void LEFTPARENTHESIS_Click(object sender, EventArgs e)
		{
			if (!equationText.Text.Contains("÷") || !equationText.Text.Contains("x") || !equationText.Text.Contains("+") || !equationText.Text.Contains("-"))
			{
				TEXT.Text += "(";
			}
		}

		private void RIGHTPARENTHESIS_Click(object sender, EventArgs e)
		{
			if (!equationText.Text.Contains("÷") || !equationText.Text.Contains("x") || !equationText.Text.Contains("+") || !equationText.Text.Contains("-"))
			{
				TEXT.Text += ")";
			}
		}
	}
}
