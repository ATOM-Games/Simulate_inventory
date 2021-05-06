using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Simulate_inventory
{
    public class ObjectInv
    {
        public int rec_x, rec_y;
        public int[,] mask;

        public ObjectInv() {
            mask = new int[1, 1];
            mask[0, 0] = 1;
        }
        public ObjectInv(string ms) {
            mask = new int[ms.Split('|')[0].Length, ms.Split('|').Length];
            for (int i = 0; i < ms.Split('|')[0].Length; i++)
            {
                for (int j = 0; j < ms.Split('|').Length; j++)
                {
                    mask[i, j] = int.Parse(ms.Split('|')[j].ToCharArray()[i] + "");
                }
            }
        }
        public ObjectInv(int x, int y, string ms) {
            mask = new int[ms.Split('|')[0].Length, ms.Split('|').Length];
            for (int i = 0; i < ms.Split('|')[0].Length; i++)
            {
                for (int j = 0; j < ms.Split('|').Length; j++)
                {
                    mask[i, j] = int.Parse(ms.Split('|')[j].ToCharArray()[i]+"");
                }
            }
            rec_x = x;
            rec_y = y;
        }
        //
        public void SelectInInv(ref one_at[,] inv, int m_x, int m_y) {
            bool t = SumCheck(ref inv, m_x, m_y);
            for (int i = Math.Max((m_x - this.rec_x), 0); i < Math.Min((m_x + this.mask.GetLength(0) - this.rec_x), (inv.GetLength(0))); i++)
            {
                for (int j = Math.Max((m_y - this.rec_y), 0); j < Math.Min((m_y + this.mask.GetLength(1) - this.rec_y), (inv.GetLength(1))); j++)
                {
                    if (this.mask[(i - (m_x - this.rec_x)), (j - (m_y - this.rec_y))] > 0) {
                        inv[i, j].SelectState( (t) ? Color.Green : Color.Red );
                    }
                }
            }
        }
        public bool SumCheck(ref one_at[,] inv, int m_x, int m_y)
        {
            if (m_x - this.rec_x < 0 || inv.GetLength(0) - (m_x + (this.mask.GetLength(0) - this.rec_x)) < 0) return false;
            if (m_y - this.rec_y < 0 || inv.GetLength(1) - (m_y + (this.mask.GetLength(1) - this.rec_y)) < 0) return false;
            int sum = 0;
            for (int i = Math.Max((m_x - this.rec_x), 0); i < Math.Min((m_x + this.mask.GetLength(0) - this.rec_x), (inv.GetLength(0))); i++)
            {
                for (int j = Math.Max((m_y - this.rec_y), 0); j < Math.Min((m_y + this.mask.GetLength(1) - this.rec_y), (inv.GetLength(1))); j++)
                {
                    sum += (inv[i, j]._ID * this.mask[(i - (m_x - this.rec_x)), (j - (m_y - this.rec_y))]);
                }
            }
            return (sum == 0);
        }
    }
}
