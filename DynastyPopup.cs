using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace L5R
{
    partial class DynastyPopup : Form
    {
        public DynastyPopup()
        {
            InitializeComponent();
            Console.WriteLine("Dynasty selector initilised");
        }

        private void buttonPurchase_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Number of Cards that can be bought:" + purchaseTableLayoutPanel.Controls.Count.ToString());
            foreach (RadioButton ctrl in purchaseTableLayoutPanel.Controls)
            {

                if (ctrl.Checked == true)
                {
                    Console.WriteLine(ctrl.Text + " is selected:" + ctrl.Checked.ToString() + " Card number:" + ctrl.Tag.ToString());
                    this.currentPlayer.recruitCardFromProvence((int)ctrl.Tag);
                }
            }
        }

       


        public System.Windows.Forms.TableLayoutPanel getPurchaseTableLayoutPanel()
        {
            return purchaseTableLayoutPanel;
        }

        private L5R.Player currentPlayer;

        public L5R.Player CurrentPlayer
        {
            get
            {
                return currentPlayer;
            }
            set
            {
                currentPlayer = value;
            }
        }
    }
}
