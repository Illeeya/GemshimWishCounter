using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenshinPityCounter
{
    public partial class MainForm : Form
    {
        int fourStarWishes { get; set; }
        int fiveStarWishes { get; set; }
        bool isFiveStar { get; set; }

        public MainForm()
        {
            
            fourStarWishes = int.Parse(ConfigurationManager.AppSettings["fourStarCounter"]);
            fiveStarWishes = int.Parse(ConfigurationManager.AppSettings["fiveStarCounter"]);
            
            InitializeComponent();
            this.BackColor = Color.FromArgb(115, 0, 153);
            this.starSelectCB.SelectedIndex = 1;
            isFiveStar = true;
            calculateValues();
            
        }

        private void starSelectCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(starSelectCB.SelectedIndex == 0)
            {
                this.BackColor = Color.FromArgb(115, 0, 153);
                wishesSinceLbl.Text = "Wishes since last 4-star:";
                chanceLbl.Text = "Thoretical chance for 4-star:";
                wishesNeededLbl.Text = "Wishes to guaranteed 4-star:";

                isFiveStar = false;
                wishCounterValue.Value = fourStarWishes;
                calculateValues();
            }
            else
            {
                this.BackColor = Color.FromArgb(153, 77, 0);
                wishesSinceLbl.Text = "Wishes since last 5-star:";
                chanceLbl.Text = "Thoretical chance for 5-star:";
                wishesNeededLbl.Text = "Wishes to guaranteed 5-star:";

                isFiveStar = true;
                wishCounterValue.Value = fiveStarWishes;
                calculateValues();
            }
        }

        private void calculateValues()
        {
            if(isFiveStar)
            {
                if(wishCounterValue.Value < 89)
                {
                    decimal chance = wishCounterValue.Value * 0.6m;
                    chanceValueLbl.Text = chance.ToString("0.00")+"%*";
                    wishesNeededValueLbl.Text = (90-wishCounterValue.Value).ToString();
                }
                else if (wishCounterValue.Value == 89)
                {
                    chanceValueLbl.Text = "100%*";
                    wishesNeededValueLbl.Text = "NEXT WISH";
                }
                else
                {
                    chanceValueLbl.Text = "Reset Counter";
                    wishesNeededValueLbl.Text = "Reset Counter";
                }
            }
            else
            {
                if (wishCounterValue.Value < 9)
                {
                    decimal chance = wishCounterValue.Value * 5.1m;
                    chanceValueLbl.Text = chance.ToString("0.00") + "%*";
                    wishesNeededValueLbl.Text = (10 - wishCounterValue.Value).ToString();
                }
                else if (wishCounterValue.Value == 9)
                {
                    chanceValueLbl.Text = "100%*";
                    wishesNeededValueLbl.Text = "NEXT WISH";
                }
                else
                {
                    chanceValueLbl.Text = "Reset Counter";
                    wishesNeededValueLbl.Text = "Reset Counter";
                }
            }
        }

        private void wishCounterValue_ValueChanged(object sender, EventArgs e)
        {
            if(isFiveStar)
            {
                fiveStarWishes = (int)wishCounterValue.Value;
            }
            else
            {
                fourStarWishes = (int)wishCounterValue.Value;
            }
            calculateValues();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            wishCounterValue.Value = 0;
        }

        private void decrementCounterLbl_Click(object sender, EventArgs e)
        {
            wishCounterValue.Value -= wishCounterValue.Value > 0 ? 1 : 0;
        }

        private void incrementCouterLbl_Click(object sender, EventArgs e)
        {
            wishCounterValue.Value += wishCounterValue.Value < 200 ? 1 : 0;
        }

        private void Form1_Closing(object sender, FormClosingEventArgs e)
        {
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings.Remove("fiveStarCounter");
            config.AppSettings.Settings.Remove("fourStarCounter");
            config.AppSettings.Settings.Add("fiveStarCounter", fiveStarWishes.ToString());
            config.AppSettings.Settings.Add("fourStarCounter", fourStarWishes.ToString());
            config.Save(ConfigurationSaveMode.Modified);
        }

    }
}
