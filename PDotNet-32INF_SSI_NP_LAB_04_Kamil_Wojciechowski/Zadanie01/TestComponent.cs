using System.ComponentModel;
using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using Timer = System.Timers.Timer;

namespace Zadanie01
{
	public partial class TestComponent : Component
	{

		private Timer timer;
		private bool isGreenVisible = true;
		private bool isRedVisible = true;
		private Container controlContainer;


		public TestComponent()
		{
			InitializeComponent();
			InitializeLights();
			StartTimer();
		}

		public TestComponent(IContainer container)
		{
			container.Add(this);

			InitializeComponent();
			InitializeLights();
			StartTimer();
		}

		private void InitializeLights()
		{
			controlContainer = new Container();

			// Utwórz kontrolki świateł (kwadratowe)
			Panel greenLight = new Panel();
			greenLight.BackColor = Color.Green;
			greenLight.Visible = isGreenVisible;
			greenLight.Size = new Size(100, 100);
			greenLight.Location = new Point(50, 50);

			Panel redLight = new Panel();
			redLight.BackColor = Color.Red;
			redLight.Visible = isRedVisible;
			redLight.Size = new Size(100, 100);
			redLight.Location = new Point(50, 200);

			// Dodaj kontrolki do kontenera
			controlContainer.Add(greenLight, "GreenLight");
			controlContainer.Add(redLight, "RedLight");
		}

		private void StartTimer()
		{
			timer = new Timer(TimerCallback, null, 5000, 5000);
		}

		private void TimerCallback(object state)
		{
			// Zmień widoczność świateł
			isGreenVisible = !isGreenVisible;
			isRedVisible = !isRedVisible;

			// Wykonaj operację na wątku interfejsu użytkownika
			if (InvokeRequired)
			{
				BeginInvoke((Action)UpdateLightsVisibility);
			}
			else
			{
				UpdateLightsVisibility();
			}
		}

		private void UpdateLightsVisibility()
		{
			// Pobierz kontrolki ze środowiska
			Panel greenLight = (Panel)controlContainer.Components["GreenLight"];
			Panel redLight = (Panel)controlContainer.Components["RedLight"];

			greenLight.Visible = isGreenVisible;
			redLight.Visible = isRedVisible;
		}
	}
  }
