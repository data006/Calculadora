using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraCS
{
	public partial class CalculadoraCS : Form
	{

		double primerNumero = 0;
		double segundoNumero = 0;
		bool punto = false;
		bool repeticion = false;

		int estado = 0;

		string operacionRealizar = " ";


		public CalculadoraCS()
		{
			InitializeComponent();
		}

		private void btn0_Click(object sender, EventArgs e)
		{
			repeticion = false;

			if (estado == 0)
				{
				txtDisplay.Text = txtDisplay.Text + "0";
				}
			else
			{
				txtDisplay.Text = "0";
				estado = 0;
			}
		}

		private void btn1_Click(object sender, EventArgs e)
		{
			repeticion = false;

			if (estado == 0)
			{
				txtDisplay.Text = txtDisplay.Text + "1";
			}
			else
			{
				txtDisplay.Text = "1";
				estado = 0;
			}
		}

		private void btn2_Click(object sender, EventArgs e)
		{
			repeticion = false;

			if (estado == 0)
			{
				txtDisplay.Text = txtDisplay.Text + "2";
			}
			else
			{
				txtDisplay.Text = "2";
				estado = 0;
			}
		}

		private void btn3_Click(object sender, EventArgs e)
		{
			repeticion = false;

			if (estado == 0)
			{
				txtDisplay.Text = txtDisplay.Text + "3";
			}
			else
			{
				txtDisplay.Text = "3";
				estado = 0;
			}
		}

		private void btn4_Click(object sender, EventArgs e)
		{
			repeticion = false;

			if (estado == 0)
			{
				txtDisplay.Text = txtDisplay.Text + "4";
			}
			else
			{
				txtDisplay.Text = "4";
				estado = 0;
			}
		}

		private void btn5_Click(object sender, EventArgs e)
		{
			repeticion = false;

			if (estado == 0)
			{
				txtDisplay.Text = txtDisplay.Text + "5";
			}
			else
			{
				txtDisplay.Text = "5";
				estado = 0;
			}
		}

		private void btn6_Click(object sender, EventArgs e)
		{
			repeticion = false;

			if (estado == 0)
			{
				txtDisplay.Text = txtDisplay.Text + "6";
			}
			else
			{
				txtDisplay.Text = "6";
				estado = 0;
			}
		}

		private void btn7_Click(object sender, EventArgs e)
		{
			repeticion = false;

			if (estado == 0)
			{
				txtDisplay.Text = txtDisplay.Text + "7";
			}
			else
			{
				txtDisplay.Text = "7";
				estado = 0;
			}
		}

		private void btn8_Click(object sender, EventArgs e)
		{
			repeticion = false;

			if (estado == 0)
			{
				txtDisplay.Text = txtDisplay.Text + "8";
			}
			else
			{
				txtDisplay.Text = "8";
				estado = 0;
			}
		}

		private void btn9_Click(object sender, EventArgs e)
		{
			repeticion = false;

			if (estado == 0)
			{
				txtDisplay.Text = txtDisplay.Text + "9";
			}
			else
			{
				txtDisplay.Text = "9";
				estado = 0;
			}
		}

		private void btnPunto_Click(object sender, EventArgs e)
		{

			if (estado == 0)
			{
				if (punto == false)
				{
					txtDisplay.Text = txtDisplay.Text + ".";
					punto = true;
					repeticion = false;
				}
				else if (punto == true)
				{
					punto = true;
				}
			}
			else
			{
				if (punto == false)
				{
					txtDisplay.Text = ".";
					estado = 0;
					punto = true;
					repeticion = false;
				}
				else if (punto == true)
				{
					punto = true;
				}
			}
		}













		private void btnSumar_Click(object sender, EventArgs e)
		{

			if (repeticion == false)
			{

				repeticion = true;

				if(operacionRealizar == " ")
				{
					primerNumero = Convert.ToDouble(txtDisplay.Text);
					txtDisplay.Text = " ";
					operacionRealizar = "Suma";
					punto = false;
				}
				else if (operacionRealizar == "Suma")
				{
					segundoNumero = Convert.ToDouble(txtDisplay.Text);
					primerNumero = primerNumero + segundoNumero;
					txtDisplay.Text = Convert.ToString(primerNumero);
					estado = 1;
					operacionRealizar = "Suma";
					punto = false;
				}
				else if (operacionRealizar == "Resta")
				{
					segundoNumero = Convert.ToDouble(txtDisplay.Text);
					primerNumero = primerNumero - segundoNumero;
					txtDisplay.Text = Convert.ToString(primerNumero);
					estado = 1;
					operacionRealizar = "Suma";
					punto = false;
				}
				else if (operacionRealizar == "Multiplicacion")
				{
					segundoNumero = Convert.ToDouble(txtDisplay.Text);
					primerNumero = primerNumero * segundoNumero;
					txtDisplay.Text = Convert.ToString(primerNumero);
					estado = 1;
					operacionRealizar = "Suma";
					punto = false;
				}
				else if (operacionRealizar == "Division")
				{
					segundoNumero = Convert.ToDouble(txtDisplay.Text);
					primerNumero = primerNumero / segundoNumero;
					txtDisplay.Text = Convert.ToString(primerNumero);
					estado = 1;
					operacionRealizar = "Suma";
					punto = false;
				}
				else if (operacionRealizar == "Pow")
				{
					segundoNumero = Convert.ToDouble(txtDisplay.Text);
					primerNumero = Math.Pow((primerNumero),(segundoNumero));
					txtDisplay.Text = Convert.ToString(primerNumero);
					estado = 1;
					operacionRealizar = "Suma";
					punto = false;
				}

			}

		}




		private void btnRestar_Click(object sender, EventArgs e)
		{
			if (repeticion == false)
			{

				repeticion = true;

				if (operacionRealizar == " ")
				{
					primerNumero = Convert.ToDouble(txtDisplay.Text);
					txtDisplay.Text = " ";
					operacionRealizar = "Resta";
					punto = false;
				}
				else if (operacionRealizar == "Suma")
				{
					segundoNumero = Convert.ToDouble(txtDisplay.Text);
					primerNumero = primerNumero + segundoNumero;
					txtDisplay.Text = Convert.ToString(primerNumero);
					estado = 1;
					operacionRealizar = "Resta";
					punto = false;
				}
				else if (operacionRealizar == "Resta")
				{
					segundoNumero = Convert.ToDouble(txtDisplay.Text);
					primerNumero = primerNumero - segundoNumero;
					txtDisplay.Text = Convert.ToString(primerNumero);
					estado = 1;
					operacionRealizar = "Resta";
					punto = false;
				}
				else if (operacionRealizar == "Multiplicacion")
				{
					segundoNumero = Convert.ToDouble(txtDisplay.Text);
					primerNumero = primerNumero * segundoNumero;
					txtDisplay.Text = Convert.ToString(primerNumero);
					estado = 1;
					operacionRealizar = "Resta";
					punto = false;
				}
				else if (operacionRealizar == "Division")
				{
					segundoNumero = Convert.ToDouble(txtDisplay.Text);
					primerNumero = primerNumero / segundoNumero;
					txtDisplay.Text = Convert.ToString(primerNumero);
					estado = 1;
					operacionRealizar = "Resta";
					punto = false;
				}
				else if (operacionRealizar == "Pow")
				{
					segundoNumero = Convert.ToDouble(txtDisplay.Text);
					primerNumero = Math.Pow((primerNumero), (segundoNumero));
					txtDisplay.Text = Convert.ToString(primerNumero);
					estado = 1;
					operacionRealizar = "Resta";
					punto = false;
				}

			}
		}

		private void btnMultiplicar_Click(object sender, EventArgs e)
		{
			if (repeticion == false)
			{

				repeticion = true;

				if (operacionRealizar == " ")
				{
					primerNumero = Convert.ToDouble(txtDisplay.Text);
					txtDisplay.Text = " ";
					operacionRealizar = "Multiplicacion";
					punto = false;
				}
				else if (operacionRealizar == "Suma")
				{
					segundoNumero = Convert.ToDouble(txtDisplay.Text);
					primerNumero = primerNumero + segundoNumero;
					txtDisplay.Text = Convert.ToString(primerNumero);
					estado = 1;
					operacionRealizar = "Multiplicacion";
					punto = false;
				}
				else if (operacionRealizar == "Resta")
				{
					segundoNumero = Convert.ToDouble(txtDisplay.Text);
					primerNumero = primerNumero - segundoNumero;
					txtDisplay.Text = Convert.ToString(primerNumero);
					estado = 1;
					operacionRealizar = "Multiplicacion";
					punto = false;
				}
				else if (operacionRealizar == "Multiplicacion")
				{
					segundoNumero = Convert.ToDouble(txtDisplay.Text);
					primerNumero = primerNumero * segundoNumero;
					txtDisplay.Text = Convert.ToString(primerNumero);
					estado = 1;
					operacionRealizar = "Multiplicacion";
					punto = false;
				}
				else if (operacionRealizar == "Division")
				{
					segundoNumero = Convert.ToDouble(txtDisplay.Text);
					primerNumero = primerNumero / segundoNumero;
					txtDisplay.Text = Convert.ToString(primerNumero);
					estado = 1;
					operacionRealizar = "Multiplicacion";
					punto = false;
				}
				else if (operacionRealizar == "Pow")
				{
					segundoNumero = Convert.ToDouble(txtDisplay.Text);
					primerNumero = Math.Pow((primerNumero), (segundoNumero));
					txtDisplay.Text = Convert.ToString(primerNumero);
					estado = 1;
					operacionRealizar = "Multiplicacion";
					punto = false;
				}

			}
		}

		private void btnDividir_Click(object sender, EventArgs e)
		{
			if (repeticion == false)
			{

				repeticion = true;

				if (operacionRealizar == " ")
				{
					primerNumero = Convert.ToDouble(txtDisplay.Text);
					txtDisplay.Text = " ";
					operacionRealizar = "Division";
					punto = false;
				}
				else if (operacionRealizar == "Suma")
				{
					segundoNumero = Convert.ToDouble(txtDisplay.Text);
					primerNumero = primerNumero + segundoNumero;
					txtDisplay.Text = Convert.ToString(primerNumero);
					estado = 1;
					operacionRealizar = "Division";
					punto = false;
				}
				else if (operacionRealizar == "Resta")
				{
					segundoNumero = Convert.ToDouble(txtDisplay.Text);
					primerNumero = primerNumero - segundoNumero;
					txtDisplay.Text = Convert.ToString(primerNumero);
					estado = 1;
					operacionRealizar = "Division";
					punto = false;
				}
				else if (operacionRealizar == "Multiplicacion")
				{
					segundoNumero = Convert.ToDouble(txtDisplay.Text);
					primerNumero = primerNumero * segundoNumero;
					txtDisplay.Text = Convert.ToString(primerNumero);
					estado = 1;
					operacionRealizar = "Division";
					punto = false;
				}
				else if (operacionRealizar == "Division")
				{
					segundoNumero = Convert.ToDouble(txtDisplay.Text);
					primerNumero = primerNumero / segundoNumero;
					txtDisplay.Text = Convert.ToString(primerNumero);
					estado = 1;
					operacionRealizar = "Division";
					punto = false;
				}
				else if (operacionRealizar == "Pow")
				{
					segundoNumero = Convert.ToDouble(txtDisplay.Text);
					primerNumero = Math.Pow((primerNumero), (segundoNumero));
					txtDisplay.Text = Convert.ToString(primerNumero);
					estado = 1;
					operacionRealizar = "Division";
					punto = false;
				}

			}
		}

		private void btnPow_Click(object sender, EventArgs e)
		{
			if (repeticion == false)
			{

				repeticion = true;

				if (operacionRealizar == " ")
				{
					primerNumero = Convert.ToDouble(txtDisplay.Text);
					txtDisplay.Text = " ";
					operacionRealizar = "Pow";
					punto = false;
				}
				else if (operacionRealizar == "Suma")
				{
					segundoNumero = Convert.ToDouble(txtDisplay.Text);
					primerNumero = primerNumero + segundoNumero;
					txtDisplay.Text = Convert.ToString(primerNumero);
					estado = 1;
					operacionRealizar = "Pow";
					punto = false;
				}
				else if (operacionRealizar == "Resta")
				{
					segundoNumero = Convert.ToDouble(txtDisplay.Text);
					primerNumero = primerNumero - segundoNumero;
					txtDisplay.Text = Convert.ToString(primerNumero);
					estado = 1;
					operacionRealizar = "Pow";
					punto = false;
				}
				else if (operacionRealizar == "Multiplicacion")
				{
					segundoNumero = Convert.ToDouble(txtDisplay.Text);
					primerNumero = primerNumero * segundoNumero;
					txtDisplay.Text = Convert.ToString(primerNumero);
					estado = 1;
					operacionRealizar = "Pow";
					punto = false;
				}
				else if (operacionRealizar == "Division")
				{
					segundoNumero = Convert.ToDouble(txtDisplay.Text);
					primerNumero = primerNumero / segundoNumero;
					txtDisplay.Text = Convert.ToString(primerNumero);
					estado = 1;
					operacionRealizar = "Pow";
					punto = false;
				}
				else if (operacionRealizar == "Pow")
				{
					segundoNumero = Convert.ToDouble(txtDisplay.Text);
					primerNumero = Math.Pow((primerNumero), (segundoNumero));
					txtDisplay.Text = Convert.ToString(primerNumero);
					estado = 1;
					operacionRealizar = "Pow";
					punto = false;
				}

			}
			else
			{
				txtDisplay.Text = "";
			}
		}

		private void btnIgual_Click(object sender, EventArgs e)
		{

			if (txtDisplay.Text != "")
			{

				if(operacionRealizar == " ")
				{
					primerNumero = Convert.ToDouble(txtDisplay.Text);
					txtDisplay.Text = Convert.ToString(primerNumero);
					operacionRealizar = " ";
					punto = false;
				}
				else if (operacionRealizar == "Suma")
				{
					segundoNumero = Convert.ToDouble(txtDisplay.Text);

					primerNumero = primerNumero + segundoNumero;

					txtDisplay.Text = Convert.ToString(primerNumero);
					estado = 1;
					operacionRealizar = " ";
					punto = false;
				}
				else if (operacionRealizar == "Resta")
				{
					segundoNumero = Convert.ToDouble(txtDisplay.Text);

					primerNumero = primerNumero - segundoNumero;

					txtDisplay.Text = Convert.ToString(primerNumero);
					estado = 1;
					operacionRealizar = " ";
					punto = false;
				}
				else if (operacionRealizar == "Multiplicacion")
				{
					segundoNumero = Convert.ToDouble(txtDisplay.Text);

					primerNumero = primerNumero * segundoNumero;

					txtDisplay.Text = Convert.ToString(primerNumero);
					estado = 1;
					operacionRealizar = " ";
					punto = false;
				}
				else if (operacionRealizar == "Division")
				{
					segundoNumero = Convert.ToDouble(txtDisplay.Text);

					primerNumero = primerNumero / segundoNumero;

					txtDisplay.Text = Convert.ToString(primerNumero);
					estado = 1;
					operacionRealizar = " ";
					punto = false;
				}
				else if (operacionRealizar == "Pow")
				{
					segundoNumero = Convert.ToDouble(txtDisplay.Text);

					primerNumero = Math.Pow(primerNumero,segundoNumero);

					txtDisplay.Text = Convert.ToString(primerNumero);
					estado = 1;
					operacionRealizar = " ";
					punto = false;
				}

			}

		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			txtDisplay.Text = " ";

			operacionRealizar = " ";

			punto = false;

			estado = 0;

			primerNumero = 0;

			segundoNumero = 0;
		}

		private void btnNeg_Click(object sender, EventArgs e)
		{
			if (txtDisplay.Text != ""){
				txtDisplay.Text = Convert.ToString(Convert.ToInt32(txtDisplay.Text) * (-1));
			}

			
		}
	}
}
