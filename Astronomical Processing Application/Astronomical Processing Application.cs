using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.ServiceModel;
using System.Windows.Media;


// Kyle Watson (30048165)
// Date: 4/09/22

namespace Astronomical_Processing_Application
{
    public partial class AstronomcalProcessingApplication : Form
    {

        public AstronomcalProcessingApplication()
        {
            InitializeComponent();
        }

        static List<Data> dataCollection = new List<Data>();

        // Forecolour is stored within an empty label variable when selected from the Colour Dialog box.
        private void changeForegroundColour_Click(object sender, EventArgs e)
        {
            PickForeColour();

            foreach (Control c in this.Controls)
            {
                if (c is Label)
                {
                    c.ForeColor = colourStore.ForeColor;
                }
                if (c is Button)
                {
                    c.ForeColor = colourStore.ForeColor;
                }
                if (c is NumericUpDown)
                {
                    c.ForeColor = colourStore.ForeColor;
                }
                if (c is TextBox)
                {
                    c.ForeColor = colourStore.ForeColor;
                    // If text box is read only backcolor needs to be changed before prior foreground colour change is recognised.
                    if (checkReadOnly(c))
                    {
                        c.BackColor = colourStore.BackColor;
                    }
                }
                if (c is MenuStrip)
                {
                    c.ForeColor = colourStore.ForeColor;
                }
            }
        }

        private void changeBackgroundColour_Click(object sender, EventArgs e)
        {
            PickBackColour();
        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CultureInfo.CurrentUICulture = CultureInfo.CreateSpecificCulture("en");
            Controls.Clear();
            InitializeComponent();
            DisplayList();
        }

        private void germanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CultureInfo.CurrentUICulture = CultureInfo.CreateSpecificCulture("de");
            Controls.Clear();
            InitializeComponent();
            DisplayList();
        }

        private void frenchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CultureInfo.CurrentUICulture = CultureInfo.CreateSpecificCulture("fr");
            Controls.Clear();
            InitializeComponent();
            DisplayList();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxStarVelocity.Text) && String.IsNullOrEmpty(textBoxStarDistance.Text) && String.IsNullOrEmpty(textBoxTemperatureKelvin.Text) && String.IsNullOrEmpty(textBoxEventHorizon.Text))
            {
                MessageBox.Show("Error");
            }
            else
            {
                Data data = new Data(textBoxStarVelocity.Text, textBoxStarDistance.Text, textBoxTemperatureKelvin.Text, textBoxEventHorizon.Text);
                dataCollection.Add(data);
            }
            DisplayList();
        }

        public void DisplayList()
        {
            listView1.Items.Clear();
            for (int i = 0; i < dataCollection.Count; i++)
            {
                //Doesnt use the first listView column as it does not allow centering of the header
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.SubItems.Add(dataCollection[i].GetStarVelocity());
                    lvi.SubItems.Add(dataCollection[i].GetEventHorizon());
                    lvi.SubItems.Add(dataCollection[i].GetTemperatureKelvin());
                    lvi.SubItems.Add(dataCollection[i].GetStarDistance());
                    listView1.Items.Add(lvi);
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DeleteMethod();
            DisplayList();

        }
        // Method for deleting items with a yes/no message box
        public void DeleteMethod()
        {
            int selectedRecord = listView1.SelectedIndices[0];
            dataCollection.Remove(dataCollection[selectedRecord]);
            //button.FlatStyle = FlatStyle.Flat;
        }
        #region Method Double Click Delete
        // Method for deleting items within the list view box via double clicking
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            DeleteMethod();
            DisplayList();
        }
        #endregion


        #region Method Pick Background Colour
        // Initialises and opens a new Colour Dialogue box for setting the form background colour.
        public void PickBackColour()
        {
            System.Windows.Forms.ColorDialog MyDialog = new ColorDialog();
            // Allows the user to select or edit a custom color.
            MyDialog.AllowFullOpen = true;
            // Assigns an array of custom colors to the CustomColors property
            MyDialog.CustomColors = new int[]{6916092, 15195440, 16107657, 1836924,
   3758726, 12566463, 7526079, 7405793, 6945974, 241502, 2296476, 5130294,
   3102017, 7324121, 14993507, 11730944,};
            // Sets the initial color select to the current text color,
            // so that if the user cancels out, the original color is restored.
            MyDialog.Color = this.BackColor;
            MyDialog.ShowDialog();
            this.BackColor = MyDialog.Color;
        }
        #endregion
        #region Method Pick Foreground Colours
        // Initialises and opens a new Colour Dialogue box for setting the form foreground colours.
        public void PickForeColour()
        {
            System.Windows.Forms.ColorDialog MyDialog = new ColorDialog();
            // Allows the user to select or edit a custom color.
            MyDialog.AllowFullOpen = true;
            // Assigns an array of custom colors to the CustomColors property
            MyDialog.CustomColors = new int[]{6916092, 15195440, 16107657, 1836924,
   3758726, 12566463, 7526079, 7405793, 6945974, 241502, 2296476, 5130294,
   3102017, 7324121, 14993507, 11730944,};
            // Sets the initial color select to the current text color,
            // so that if the user cancels out, the original color is restored.
            MyDialog.Color = this.ForeColor;
            MyDialog.ShowDialog();
            // Colour is stored in a dummy label which can be applied to other controls
            colourStore.ForeColor = MyDialog.Color;
        }
        #endregion
        #region Check Read Only
        // Method checks if a text box control is read only. Supports changing foreground colour.
        private bool checkReadOnly(Control control)
        {
            return ((TextBox)control).ReadOnly;
        }
        #endregion
        // Button calculate method for star velocity
        private void calculateStarVelocityBtn_Click(object sender, EventArgs e)
        {
            IAstroContract channel = CommunicationChannel();

            double observedWavelength = double.Parse(textBoxObservedWavelength.Text);
            double restWavelength = double.Parse(textBoxRestWavelength.Text);
            var result = channel.StarVelocity(observedWavelength, restWavelength);
            textBoxStarVelocity.Text = result.ToString("F");
        }
        // Button calculate method for event horizon
        private void calculateEventHorizonBtn_Click(object sender, EventArgs e)
        {
            IAstroContract channel = CommunicationChannel();

            double blackholeMass = double.Parse(textBoxBlackholeMass.Text) * (Math.Pow(10, double.Parse(numericUpDown1.Value.ToString())));
            var result = channel.EventHorizon(blackholeMass);

            int counter = 0;
            // Handles results with a positive exponent
            if (result > 10)
            {
                while (result > 10)
                {
                    result /= 10;
                    counter++;
                }
                textBoxEventHorizon.Text = result.ToString("F") + "E" + counter;
            }
            // Handles results with a negative exponent
            if (result < 1)
            {
                while (result < 1)
                {
                    result *= 10;
                    counter++;
                }
                textBoxEventHorizon.Text = result.ToString("F") + "E-" + counter;
            }
        }
        // Button calculate method for temperature
        private void calculateTemperature_Click(object sender, EventArgs e)
        {
            IAstroContract channel = CommunicationChannel();

            double tempCelcius = double.Parse(textBoxTemperatureCelcius.Text);
            var result = channel.TemperatureKelvin(tempCelcius);
            textBoxTemperatureKelvin.Text = result.ToString("F");

        }
        // Button calculate method for star distance
        private void calculateStarDistance_Click(object sender, EventArgs e)
        {
            IAstroContract channel = CommunicationChannel();

            double arcsecondAngle = double.Parse(textBoxArcsecondAngle.Text);
            var result = channel.StarDistance(arcsecondAngle);
            textBoxStarDistance.Text = result.ToString("F");

        }

        // Method which generates a new run-time communication stack using a prepared address
        // and enables creation of a communication channel to the server without a proxy which is returned
        private Astronomical_Processing_Application.IAstroContract CommunicationChannel()
        {
            string address = "net.pipe://localhost/AstroServer";
            NetNamedPipeBinding binding = new NetNamedPipeBinding(NetNamedPipeSecurityMode.None);
            EndpointAddress ep = new EndpointAddress(address);
            IAstroContract channel = ChannelFactory<IAstroContract>.CreateChannel(binding, ep);
            return channel;
        }

        private void AstronomcalProcessingApplication_Load(object sender, EventArgs e)
        {
            // Controls the form open location - development purposes only
            this.Location = Screen.AllScreens[1].WorkingArea.Location;
        }

        // Light mode and dark mode toggle button
        private void lightDarkModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Drawing.Color foreground = new System.Drawing.Color();
            System.Drawing.Color background = new System.Drawing.Color();
            System.Drawing.Color midground = new System.Drawing.Color();

            // Light Mode
            if (lightDarkModeToolStripMenuItem.Checked == true)
            {
                lightDarkModeToolStripMenuItem.Checked = false;

                foreground = System.Drawing.Color.FromArgb(34, 34, 34);
                background = System.Drawing.Color.FromArgb(222, 228, 239);
                midground = System.Drawing.Color.FromArgb(55, 71, 79);

                this.BackColor = background;
                foreach (Control c in this.Controls)
                {
                    if (c is Label)
                    {
                        c.ForeColor = foreground;
                    }
                    if (c is Button)
                    {
                        c.ForeColor = midground;
                    }
                    if (c is NumericUpDown)
                    {
                        c.ForeColor = foreground;
                    }
                    if (c is TextBox)
                    {
                        c.ForeColor = foreground;
                        // If text box is read only backcolor needs to be changed before prior foreground colour change is recognised.
                        if (checkReadOnly(c))
                        {
                            c.BackColor = background;
                        }
                    }
                    if (c is MenuStrip)
                    {
                        c.ForeColor = foreground;
                    }
                }
            }
            // Dark Mode
            else if (lightDarkModeToolStripMenuItem.Checked == false)
            {
                lightDarkModeToolStripMenuItem.Checked = true;

                foreground = System.Drawing.Color.FromArgb(222, 228, 239);
                background = System.Drawing.Color.FromArgb(34, 34, 34);
                midground = System.Drawing.Color.FromArgb(55, 71, 79);
                this.BackColor = background;
                foreach (Control c in this.Controls)
                {
                    if (c is Label)
                    {
                        c.ForeColor = foreground;
                    }
                    if (c is Button)
                    {
                        c.ForeColor = midground;
                    }
                    if (c is NumericUpDown)
                    {
                        c.ForeColor = foreground;
                    }
                    if (c is TextBox)
                    {
                        c.ForeColor = foreground;
                        // If text box is read only backcolor needs to be changed before prior foreground colour change is recognised.
                        if (checkReadOnly(c))
                        {
                            c.BackColor = background;
                        }
                    }
                    if (c is MenuStrip)
                    {
                        c.ForeColor = midground;
                    }
                }
            }


        }
        #region Double Click Clear Input TextBoxes
        private void textBoxObservedWavelength_DoubleClick(object sender, EventArgs e)
        {
            textBoxObservedWavelength.Clear();
        }

        private void textBoxRestWavelength_DoubleClick(object sender, EventArgs e)
        {
            textBoxRestWavelength.Clear();
        }

        private void textBoxArcsecondAngle_DoubleClick(object sender, EventArgs e)
        {
            textBoxArcsecondAngle.Clear();
        }

        private void textBoxTemperatureCelcius_DoubleClick(object sender, EventArgs e)
        {
            textBoxTemperatureCelcius.Clear();
        }

        private void textBoxBlackholeMass_DoubleClick(object sender, EventArgs e)
        {
            textBoxBlackholeMass.Clear();
        }
        #endregion

        private void textBoxObservedWavelength_Enter(object sender, EventArgs e)
        {
            if (textBoxObservedWavelength.Text == "Observed Wavelength")
                textBoxObservedWavelength.Clear();
        }
        #region Input Textboxes Enter
        private void textBoxRestWavelength_Enter(object sender, EventArgs e)
        {
            if (textBoxRestWavelength.Text == "Rest Wavelength")
                textBoxRestWavelength.Clear();
        }

        private void textBoxArcsecondAngle_Enter(object sender, EventArgs e)
        {
            if (textBoxArcsecondAngle.Text == "Arcsecond Angle")
                textBoxArcsecondAngle.Clear();
        }

        private void textBoxTemperatureCelcius_Enter(object sender, EventArgs e)
        {
            if (textBoxTemperatureCelcius.Text == "Temperature (Celcius)")
                textBoxTemperatureCelcius.Clear();
        }

        private void textBoxBlackholeMass_Enter(object sender, EventArgs e)
        {
            if (textBoxBlackholeMass.Text == "Blackhole Mass")
                textBoxBlackholeMass.Clear();
        }
        #endregion
        #region Input Textboxes Leave
        private void textBoxObservedWavelength_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxObservedWavelength.Text))
                textBoxObservedWavelength.Text = "Observed Wavelength";
        }

        private void textBoxRestWavelength_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxRestWavelength.Text))
                textBoxRestWavelength.Text = "Rest Wavelength";
        }

        private void textBoxArcsecondAngle_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxArcsecondAngle.Text))
                textBoxArcsecondAngle.Text = "Arcsecond Angle";
        }

        private void textBoxTemperatureCelcius_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxTemperatureCelcius.Text))
                textBoxTemperatureCelcius.Text = "Temperature (Celcius)";
        }

        private void textBoxBlackholeMass_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxBlackholeMass.Text))
                textBoxBlackholeMass.Text = "Blackhole Mass";
        }
        #endregion
        private void AstronomcalProcessingApplication_Click(object sender, EventArgs e)
        {
            this.Focus();
        }
    }

}
