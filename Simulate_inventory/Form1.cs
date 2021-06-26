using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Simulate_inventory
{
    public partial class Form1 : Form
    {
        private ObjectInv[] obss = new ObjectInv[5];
        public Form1()
        {
            InitializeComponent();
            InitInv1();
            obss[0] = new ObjectInv();
            obss[1] = new ObjectInv(1, 1, "101|010|101");
            obss[2] = new ObjectInv(1, 1, "1111|1001|1001|1111");
            obss[3] = new ObjectInv(2, 2, "01110|10001|10001|10001|01110");
            obss[4] = new ObjectInv(4, 4, "11000011|11000011|00000000|00111100|01100110|01100110");
            this.inv_1[5, 5]._ID = 19;
            this.inv_1[1, 10]._AtSos = -5;
            clearSelect();
        }

        public void clearSelect() {
            for (int i = 0; i < this.inv_1.GetLength(0); i++) {
                for (int j = 0; j < this.inv_1.GetLength(1); j++)
                {
                    this.inv_1[i, j].defaultState();
                }
            }
        }

        public void checkedd(int x, int y){
            obss[int.Parse(seles.Value+"")].SelectInInv(ref this.inv_1, x, y);
        }
    }
}
