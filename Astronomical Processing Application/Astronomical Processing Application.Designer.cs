namespace Astronomical_Processing_Application
{
    partial class AstronomcalProcessingApplication
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AstronomcalProcessingApplication));
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.germanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.frenchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.themeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeBackgroundColour = new System.Windows.Forms.ToolStripMenuItem();
            this.changeForegroundColour = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxObservedWavelength = new System.Windows.Forms.TextBox();
            this.textBoxArcsecondAngle = new System.Windows.Forms.TextBox();
            this.textBoxTemperatureCelcius = new System.Windows.Forms.TextBox();
            this.textBoxBlackholeMass = new System.Windows.Forms.TextBox();
            this.calculateStarVelocityBtn = new System.Windows.Forms.Button();
            this.calculateStarDistance = new System.Windows.Forms.Button();
            this.calculateTemperature = new System.Windows.Forms.Button();
            this.calculateEventHorizon = new System.Windows.Forms.Button();
            this.textBoxRestWavelength = new System.Windows.Forms.TextBox();
            this.textBoxEventHorizon = new System.Windows.Forms.TextBox();
            this.textBoxTemperatureKelvin = new System.Windows.Forms.TextBox();
            this.textBoxStarDistance = new System.Windows.Forms.TextBox();
            this.textBoxStarVelocity = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnStarVelocity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnStarDistance = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnTemperature = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnEventHorizon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.testButton = new System.Windows.Forms.Button();
            this.colourStore = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.languageToolStripMenuItem,
            this.themeToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.TabStop = true;
            // 
            // languageToolStripMenuItem
            // 
            this.languageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.englishToolStripMenuItem,
            this.germanToolStripMenuItem,
            this.frenchToolStripMenuItem});
            this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            resources.ApplyResources(this.languageToolStripMenuItem, "languageToolStripMenuItem");
            // 
            // englishToolStripMenuItem
            // 
            resources.ApplyResources(this.englishToolStripMenuItem, "englishToolStripMenuItem");
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            this.englishToolStripMenuItem.Click += new System.EventHandler(this.englishToolStripMenuItem_Click);
            // 
            // germanToolStripMenuItem
            // 
            resources.ApplyResources(this.germanToolStripMenuItem, "germanToolStripMenuItem");
            this.germanToolStripMenuItem.Name = "germanToolStripMenuItem";
            this.germanToolStripMenuItem.Click += new System.EventHandler(this.germanToolStripMenuItem_Click);
            // 
            // frenchToolStripMenuItem
            // 
            resources.ApplyResources(this.frenchToolStripMenuItem, "frenchToolStripMenuItem");
            this.frenchToolStripMenuItem.Name = "frenchToolStripMenuItem";
            this.frenchToolStripMenuItem.Click += new System.EventHandler(this.frenchToolStripMenuItem_Click);
            // 
            // themeToolStripMenuItem
            // 
            this.themeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeBackgroundColour,
            this.changeForegroundColour});
            this.themeToolStripMenuItem.Name = "themeToolStripMenuItem";
            resources.ApplyResources(this.themeToolStripMenuItem, "themeToolStripMenuItem");
            // 
            // changeBackgroundColour
            // 
            this.changeBackgroundColour.Name = "changeBackgroundColour";
            resources.ApplyResources(this.changeBackgroundColour, "changeBackgroundColour");
            this.changeBackgroundColour.Click += new System.EventHandler(this.changeBackgroundColour_Click);
            // 
            // changeForegroundColour
            // 
            this.changeForegroundColour.Name = "changeForegroundColour";
            resources.ApplyResources(this.changeForegroundColour, "changeForegroundColour");
            this.changeForegroundColour.Click += new System.EventHandler(this.changeForegroundColour_Click);
            // 
            // textBoxObservedWavelength
            // 
            this.textBoxObservedWavelength.ForeColor = System.Drawing.SystemColors.ControlDark;
            resources.ApplyResources(this.textBoxObservedWavelength, "textBoxObservedWavelength");
            this.textBoxObservedWavelength.Name = "textBoxObservedWavelength";
            // 
            // textBoxArcsecondAngle
            // 
            this.textBoxArcsecondAngle.ForeColor = System.Drawing.SystemColors.ControlDark;
            resources.ApplyResources(this.textBoxArcsecondAngle, "textBoxArcsecondAngle");
            this.textBoxArcsecondAngle.Name = "textBoxArcsecondAngle";
            // 
            // textBoxTemperatureCelcius
            // 
            this.textBoxTemperatureCelcius.ForeColor = System.Drawing.SystemColors.ControlDark;
            resources.ApplyResources(this.textBoxTemperatureCelcius, "textBoxTemperatureCelcius");
            this.textBoxTemperatureCelcius.Name = "textBoxTemperatureCelcius";
            // 
            // textBoxBlackholeMass
            // 
            this.textBoxBlackholeMass.ForeColor = System.Drawing.SystemColors.ControlDark;
            resources.ApplyResources(this.textBoxBlackholeMass, "textBoxBlackholeMass");
            this.textBoxBlackholeMass.Name = "textBoxBlackholeMass";
            // 
            // calculateStarVelocityBtn
            // 
            resources.ApplyResources(this.calculateStarVelocityBtn, "calculateStarVelocityBtn");
            this.calculateStarVelocityBtn.Name = "calculateStarVelocityBtn";
            this.calculateStarVelocityBtn.UseVisualStyleBackColor = true;
            this.calculateStarVelocityBtn.Click += new System.EventHandler(this.calculateStarVelocityBtn_Click);
            // 
            // calculateStarDistance
            // 
            resources.ApplyResources(this.calculateStarDistance, "calculateStarDistance");
            this.calculateStarDistance.Name = "calculateStarDistance";
            this.calculateStarDistance.UseVisualStyleBackColor = true;
            this.calculateStarDistance.Click += new System.EventHandler(this.calculateEventHorizonBtn_Click);
            // 
            // calculateTemperature
            // 
            resources.ApplyResources(this.calculateTemperature, "calculateTemperature");
            this.calculateTemperature.Name = "calculateTemperature";
            this.calculateTemperature.UseVisualStyleBackColor = true;
            this.calculateTemperature.Click += new System.EventHandler(this.calculateTemperature_Click);
            // 
            // calculateEventHorizon
            // 
            resources.ApplyResources(this.calculateEventHorizon, "calculateEventHorizon");
            this.calculateEventHorizon.Name = "calculateEventHorizon";
            this.calculateEventHorizon.UseVisualStyleBackColor = true;
            this.calculateEventHorizon.Click += new System.EventHandler(this.calculateStarDistance_Click);
            // 
            // textBoxRestWavelength
            // 
            this.textBoxRestWavelength.ForeColor = System.Drawing.SystemColors.ControlDark;
            resources.ApplyResources(this.textBoxRestWavelength, "textBoxRestWavelength");
            this.textBoxRestWavelength.Name = "textBoxRestWavelength";
            // 
            // textBoxEventHorizon
            // 
            resources.ApplyResources(this.textBoxEventHorizon, "textBoxEventHorizon");
            this.textBoxEventHorizon.Name = "textBoxEventHorizon";
            // 
            // textBoxTemperatureKelvin
            // 
            resources.ApplyResources(this.textBoxTemperatureKelvin, "textBoxTemperatureKelvin");
            this.textBoxTemperatureKelvin.Name = "textBoxTemperatureKelvin";
            // 
            // textBoxStarDistance
            // 
            resources.ApplyResources(this.textBoxStarDistance, "textBoxStarDistance");
            this.textBoxStarDistance.Name = "textBoxStarDistance";
            // 
            // textBoxStarVelocity
            // 
            resources.ApplyResources(this.textBoxStarVelocity, "textBoxStarVelocity");
            this.textBoxStarVelocity.Name = "textBoxStarVelocity";
            // 
            // textBox12
            // 
            this.textBox12.ForeColor = System.Drawing.SystemColors.ControlDark;
            resources.ApplyResources(this.textBox12, "textBox12");
            this.textBox12.Name = "textBox12";
            this.textBox12.ReadOnly = true;
            // 
            // numericUpDown1
            // 
            resources.ApplyResources(this.numericUpDown1, "numericUpDown1");
            this.numericUpDown1.Name = "numericUpDown1";
            // 
            // buttonAdd
            // 
            resources.ApplyResources(this.buttonAdd, "buttonAdd");
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDelete
            // 
            resources.ApplyResources(this.buttonDelete, "buttonDelete");
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel,
            this.toolStripStatusLabel2});
            resources.ApplyResources(this.statusStrip1, "statusStrip1");
            this.statusStrip1.Name = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            resources.ApplyResources(this.toolStripStatusLabel1, "toolStripStatusLabel1");
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            resources.ApplyResources(this.toolStripStatusLabel, "toolStripStatusLabel");
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            resources.ApplyResources(this.toolStripStatusLabel2, "toolStripStatusLabel2");
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnStarVelocity,
            this.columnStarDistance,
            this.columnTemperature,
            this.columnEventHorizon});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            resources.ApplyResources(this.listView1, "listView1");
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // columnHeader1
            // 
            resources.ApplyResources(this.columnHeader1, "columnHeader1");
            // 
            // columnStarVelocity
            // 
            resources.ApplyResources(this.columnStarVelocity, "columnStarVelocity");
            // 
            // columnStarDistance
            // 
            resources.ApplyResources(this.columnStarDistance, "columnStarDistance");
            // 
            // columnTemperature
            // 
            resources.ApplyResources(this.columnTemperature, "columnTemperature");
            // 
            // columnEventHorizon
            // 
            resources.ApplyResources(this.columnEventHorizon, "columnEventHorizon");
            // 
            // testButton
            // 
            resources.ApplyResources(this.testButton, "testButton");
            this.testButton.Name = "testButton";
            this.testButton.UseVisualStyleBackColor = true;
            this.testButton.Click += new System.EventHandler(this.testButton_Click);
            // 
            // colourStore
            // 
            resources.ApplyResources(this.colourStore, "colourStore");
            this.colourStore.Name = "colourStore";
            // 
            // AstronomcalProcessingApplication
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.colourStore);
            this.Controls.Add(this.testButton);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.textBoxEventHorizon);
            this.Controls.Add(this.textBoxTemperatureKelvin);
            this.Controls.Add(this.textBoxStarDistance);
            this.Controls.Add(this.textBoxStarVelocity);
            this.Controls.Add(this.textBoxRestWavelength);
            this.Controls.Add(this.calculateEventHorizon);
            this.Controls.Add(this.calculateTemperature);
            this.Controls.Add(this.calculateStarDistance);
            this.Controls.Add(this.calculateStarVelocityBtn);
            this.Controls.Add(this.textBoxBlackholeMass);
            this.Controls.Add(this.textBoxTemperatureCelcius);
            this.Controls.Add(this.textBoxArcsecondAngle);
            this.Controls.Add(this.textBoxObservedWavelength);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AstronomcalProcessingApplication";
            this.Load += new System.EventHandler(this.AstronomcalProcessingApplication_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem germanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem frenchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem themeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeBackgroundColour;
        private System.Windows.Forms.ToolStripMenuItem changeForegroundColour;
        private System.Windows.Forms.TextBox textBoxObservedWavelength;
        private System.Windows.Forms.TextBox textBoxArcsecondAngle;
        private System.Windows.Forms.TextBox textBoxTemperatureCelcius;
        private System.Windows.Forms.TextBox textBoxBlackholeMass;
        private System.Windows.Forms.Button calculateStarVelocityBtn;
        private System.Windows.Forms.Button calculateStarDistance;
        private System.Windows.Forms.Button calculateTemperature;
        private System.Windows.Forms.Button calculateEventHorizon;
        private System.Windows.Forms.TextBox textBoxRestWavelength;
        private System.Windows.Forms.TextBox textBoxEventHorizon;
        private System.Windows.Forms.TextBox textBoxTemperatureKelvin;
        private System.Windows.Forms.TextBox textBoxStarDistance;
        private System.Windows.Forms.TextBox textBoxStarVelocity;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnStarVelocity;
        private System.Windows.Forms.ColumnHeader columnStarDistance;
        private System.Windows.Forms.ColumnHeader columnTemperature;
        private System.Windows.Forms.ColumnHeader columnEventHorizon;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.Button testButton;
        private System.Windows.Forms.Label colourStore;
    }
}

