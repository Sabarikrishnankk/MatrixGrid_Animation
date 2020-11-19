using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace matrix123
{
    public partial class Form1 : Form
    {
        public int m_width;
        public int m_height;
        public int m_NoOfRows;
        public int m_NoOfCols;
        public int m_Xoffset;
        public int m_Yoffset;
        public int m_iCount = 3;
        public int m_iGridMaxSize = 3;
        public const int DEFAULT_X_OFFSET = 100;
        public const int DEFAULT_Y_OFFSET = 50;
        public const int DEFAULT_NO_ROWS = 3;
        public const int DEFAULT_NO_COLS = 3;
        public const int DEFAULT_WIDTH = 60;
        public const int DEFAULT_HEIGHT = 60;
        public Form1()
        {
            Initialize();
            InitializeComponent();
            bThreadStatus = false;
            
        }

        private void OnPaint(object sender, EventArgs e)
        {
            DrawGrid();
        }
        public void Initialize()
        {
            m_NoOfRows = DEFAULT_NO_ROWS;
            m_NoOfCols = DEFAULT_NO_COLS;
            m_width = DEFAULT_WIDTH;
            m_height = DEFAULT_HEIGHT;
            m_Xoffset = DEFAULT_X_OFFSET;
            m_Yoffset = DEFAULT_Y_OFFSET;

        }
        private void DrawGrid()
        {
            Graphics boardLayout = this.CreateGraphics();
            Pen layoutPen = new Pen(Color.Red);
            layoutPen.Width = 5;
            int X = DEFAULT_X_OFFSET;
            int Y = DEFAULT_Y_OFFSET;
            for (int i = 0; i <= m_iCount; i++)
            {
                boardLayout.DrawLine(layoutPen, X, Y, X + this.m_width * this.m_iCount, Y);
                Y = Y + m_height;
            }
            X = DEFAULT_X_OFFSET;
            Y = DEFAULT_Y_OFFSET;
            for (int j = 0; j <= m_iCount; j++)


            {
                boardLayout.DrawLine(layoutPen, X, Y, X, Y + this.m_height * this.m_iCount);
                X = X + this.m_width; ;


            }
        }

        [Obsolete]
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            CounterThread.Resume();
        }

        [Obsolete]
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            CounterThread.Suspend();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            CounterThread = new Thread(new ThreadStart(ThreadCounter));
            CounterThread.Start();
            bThreadStatus = true;
        }

        private void size4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m_iGridMaxSize = 4;
            this.Refresh();
        }

        private void size5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m_iGridMaxSize = 5;
            this.Refresh();
        }

        private void size6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m_iGridMaxSize = 6;
            this.Refresh();
        }

        private void size7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m_iGridMaxSize = 7;
            this.Refresh();
        }
        public void ThreadCounter()
        {
            try
            {
                while (true)
                {
                    m_iCount++;
                    if (m_iCount > m_iGridMaxSize)
                    {
                        m_iCount = 3;

                    }
                    Invalidate();
                    Thread.Sleep(500);

                }

            }
            catch (Exception ex)
            { }
        }
    }
}

    

