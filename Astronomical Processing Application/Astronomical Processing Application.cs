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


// Kyle Watson (30048165)
// Date: 4/09/22


namespace Astronomical_Processing_Application
{
    public partial class AstronomcalProcessingApplication : Form
    {

        public AstronomcalProcessingApplication()
        {
            InitializeComponent();
            Console.WriteLine("The current UI culture: {0}",
                        CultureInfo.CurrentUICulture.Name);

        }

        static List<Data> dataCollection = new List<Data>();
        //public int[] CustomColors { get; set; }
        private void changeForegroundColour_Click(object sender, EventArgs e)
        {


        }

        private void changeBackgroundColour_Click(object sender, EventArgs e)
        {
            PickColour();
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
            if (String.IsNullOrEmpty(textBoxStarVelocity.Text) && String.IsNullOrEmpty(textBoxEventHorizon.Text) && String.IsNullOrEmpty(textBoxTemperatureKelvin.Text) && String.IsNullOrEmpty(textBoxStarDistance.Text))
            {
                MessageBox.Show("Error");
            }
            else
            {
                Data data = new Data(textBoxStarVelocity.Text, textBoxEventHorizon.Text, textBoxTemperatureKelvin.Text, textBoxStarDistance.Text);
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

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            DeleteMethod();
            DisplayList();
        }



        public void ChangeLanguage(string language)
        {
            foreach (Control c in this.Controls)
            {
                if (c.HasChildren)
                {

                }
            }
            Controls.Clear();
            InitializeComponent();
        }

        private void testButton_Click(object sender, EventArgs e)
        {
            //Console.WriteLine(Control.ControlCollection.Find());
        }
        //M
        public void PickColour()
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
    }

}
