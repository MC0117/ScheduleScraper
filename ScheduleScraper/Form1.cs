using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ScheduleScraper.Models;
using ScheduleScraper.Properties;


namespace ScheduleScraper
{
    public partial class ScheduleForm : Form
    {
        List<Models.ScheduleModel> Launches = null;
        int i = 0;
        public ScheduleForm()
        {
            InitializeComponent();
            Launches = Scraper.GetSchedule();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CreateNewPage(i);
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            i++;
            previousBtn.Enabled = i > 0 ? true : false;
            nextBtn.Enabled = i == (Launches.Count - 1) ? false : true;
            CreateNewPage(i);
        }
        private void previousBtn_Click(object sender, EventArgs e)
        {
            i--;
            previousBtn.Enabled = i == 0 ? false : true;
            nextBtn.Enabled = i == (Launches.Count - 1) ? false : true;
            CreateNewPage(i);
        }
        private void CreateNewPage(int index)
        {
            dateLbl.Text = Launches[i].Date;
            locationLbl.Text = "Location:" + Launches[i].Location;
            modelLbl.Text = "Model: " + Launches[i].RocketModel;
            cargoLbl.Text = "Cargo: " + Launches[i].Cargo;
            descriptionTxt.Text = Launches[i].Description;
        }
    }
}
