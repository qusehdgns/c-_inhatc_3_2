using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HitTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        protected const int xNum = 5;
        protected const int yNum = 4;
        protected bool[,] abChecked = new bool[yNum, xNum];
        protected bool[,] lrChecked = new bool[yNum, xNum];
        protected int cxBlock, cyBlock;

        private void Form1_Load(object sender, EventArgs e)
        {
            OnResize(EventArgs.Empty);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            cxBlock = ClientSize.Width / xNum;
            cyBlock = ClientSize.Height / yNum;
            Invalidate();
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            int x = e.X / cxBlock;
            int y = e.Y / cyBlock;
            if(e.Button == MouseButtons.Left)
            {
                if (x < xNum && y < yNum)
                {
                    if(!(abChecked[y, x]))
                    {
                        abChecked[y, x] ^= true;
                        lrChecked[y, x] = false;
                    } else
                    {
                        if(lrChecked[y, x])
                        {
                            lrChecked[y, x] = false;
                        } else
                        {
                            abChecked[y, x] ^= true;
                            lrChecked[y, x] = false;
                        }
                    }
                    Invalidate(new Rectangle(x * cxBlock, y * cyBlock, cxBlock, cyBlock));
                }
            } else if(e.Button == MouseButtons.Right)
            {
                if (x < xNum && y < yNum)
                {
                    if (!(abChecked[y, x]))
                    {
                        abChecked[y, x] ^= true;
                        lrChecked[y, x] = true;
                    }
                    else
                    {
                        if (lrChecked[y, x])
                        {
                            abChecked[y, x] ^= true;
                            lrChecked[y, x] = false;
                        }
                        else
                        {
                            lrChecked[y, x] = true;
                        }
                    }
                    Invalidate(new Rectangle(x * cxBlock, y * cyBlock, cxBlock, cyBlock));
                }
            }
            
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pen = new Pen(ForeColor);
            for (int y = 0; y < yNum; y++)
            {
                for(int x = 0; x < xNum; x++)
                {
                    g.DrawRectangle(pen, x * cxBlock, y * cyBlock, cxBlock, cyBlock);
                    if(abChecked[y, x])
                    {
                        if(lrChecked[y, x])
                        {
                            g.DrawEllipse(pen, x * cxBlock, y * cyBlock, cxBlock, cyBlock);
                        }
                        else
                        {
                            g.DrawLine(pen, x * cxBlock, y * cyBlock, (x + 1) * cxBlock, (y + 1) * cyBlock);
                            g.DrawLine(pen, x * cxBlock, (y + 1) * cyBlock, (x + 1) * cxBlock, y * cyBlock);
                        }
                    }
                }
            }
        }
    }
}
