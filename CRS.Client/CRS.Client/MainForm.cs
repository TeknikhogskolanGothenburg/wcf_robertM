using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.Windows.Forms;
using CRS.Client.CarRentalService;

namespace CRS.Client
{
	public partial class MainForm : Form
	{
		private static CarRentalServiceClient _service = new CarRentalServiceClient("WSHttpBinding_ICarRentalService");

		public MainForm()
		{
			InitializeComponent();
		}

		private void GetCarById_Click(object sender, EventArgs e)
		{
			if(txtBoxId.TextLength == 0)
			{
				SetItToNaN();
				errorMsg.Text = "Input id to search for a car";
			}
			else
			{
				try
				{
					Car car;
					int id = Convert.ToInt32(txtBoxId.Text);
					car = _service.GetCarById(id);
					if (car != null)
					{
						lblBrand.Text = car.Brand;
						lblModel.Text = car.Model;
						lblRegnumber.Text = car.Regnumber;
						lblYear.Text = car.Year.ToString();
						errorMsg.Text = string.Empty;
					}
					else
					{
						SetItToNaN();
						errorMsg.Text = "No car found!";
					}
				}
				catch (Exception)
				{
					SetItToNaN();
					errorMsg.Text = "There was an error";
				}
			}
		}

		private void GetCarByReg_Click(object sender, EventArgs e)
		{
			if(txtBoxReg.TextLength == 0)
			{
				SetItToNaN2();
				errorMsg2.Text = "Input a regnumber to search for a car";
			}
			else
			{
				try
				{
					string regnumber = txtBoxReg.Text;

					ICarRentalService client = new CarRentalServiceClient("WSHttpBinding_ICarRentalService");

					CarRequest request = new CarRequest();
					request.LicenseKey = "yggdrasil";
					request.Regnumber = regnumber;

					var car = client.GetCarByRegnum(request);

					lblBrand2.Text = car.Brand;
					lblModel2.Text = car.Model;
					lblRegnumber2.Text = car.Regnumber;
					lblYear2.Text = car.Year.ToString();
					errorMsg2.Text = string.Empty;
				}
				catch(FaultException<AccessDenied> ex)
				{
					errorMsg2.Text = ex.Detail.Info;
					SetItToNaN2();
				}
				catch (FaultException<NoDataAvaliable> ex)
				{
					errorMsg2.Text = ex.Detail.Info;
					SetItToNaN2();
				}
			}
		}

		private void SetItToNaN()
		{
			lblYear.Text = "NaN";
			lblBrand.Text = "NaN";
			lblModel.Text = "NaN";
			lblRegnumber.Text = "NaN";
			lblYear.Text = "NaN";
		}

		private void SetItToNaN2()
		{
			lblYear2.Text = "NaN";
			lblBrand2.Text = "NaN";
			lblModel2.Text = "NaN";
			lblRegnumber2.Text = "NaN";
			lblYear2.Text = "NaN";
		}
	}
}
