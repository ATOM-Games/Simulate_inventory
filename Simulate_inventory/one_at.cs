using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Simulate_inventory
{
    public partial class one_at : UserControl
    {
        public int _ID = 0;
        private int _X, _Y;
        private Form1 mathForm;

        


        public one_at(int x, int y, Form1 f)
        {
            InitializeComponent();
            this._X = x;
            this._Y = y;
            this.mathForm = f;
        }

        public void SelectState() {
            mathForm.Text = "[ " + _ID + " " + _X + "-" + _Y + " ]";
            this.panel1.BackColor = Color.Green;
        }
        public void SelectState(Color cv)
        {
            mathForm.Text = "[ " + _ID + " " + _X + "-" + _Y + " ]";
            this.panel1.BackColor = cv;
        }

        public void defaultState() {
            if(_ID==0){
                this.panel1.BackColor = Color.White;
            }else{
                this.panel1.BackColor = Color.Gray;
            }
        }


    }
}
