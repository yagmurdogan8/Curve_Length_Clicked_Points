//author YD

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgrammingLanguageConceptsA3
{
    public partial class ViewerForm : Form
    {
        //creating curve obj from Curve class to use its methods
        Curve curve;
      
        int x, y;

        public ViewerForm()
        {
            InitializeComponent();
            this.curve = new Curve();
        }

        private void paint(object sender, PaintEventArgs e)
        {
            Graphics graphicsObj = e.Graphics;

            Pen pen; // to use to draw line with DrawLine 
            Brush brush; // to use to draw point as an ellipse 

            // getting combobox's selected item as a text and storing them to use later
            string lineColor = cmbLineColor.Text;
            string pointColor = cmbPointColor.Text;

            // to make lines proper and smooth 
            graphicsObj.SmoothingMode = SmoothingMode.HighQuality;

            Invalidate();  

                // switch case is used to change the color as selected values from combobox 
                switch (pointColor)
                {
                    case "Black":
                        brush = Brushes.Black;                        
                        break;

                    case "Blue":
                        brush = Brushes.Blue;                     
                        break;

                    case "Red":
                        brush = Brushes.Red;                        
                        break;

                    default:
                        brush = Brushes.Black;                        
                        break;
                }

            // with for loop the clicked points, program draws the points as it is clicked
            for (int i = 0; i < curve.pointList.Count; i++)
            {
                    e.Graphics.FillEllipse(brush, curve.pointList[i].PointX - 1, curve.pointList[i].PointY - 1, 3, 3);
            }

            // switch case is used to change the color as selected values from combobox 
            switch (lineColor)
            {
                 case "Black":
                    pen = new Pen(Color.Black, 3);
                 break;
                    
                 case "Blue":
                    pen = new Pen(Color.Blue, 3);
                 break;

                 case "Red":
                    pen = new Pen(Color.Red, 3);
                 break;

                 default:
                    pen = new Pen(Color.Black, 3);
                 break;
            }

            // with for loop the clicked points, program draws the line as the points clicked
            for (int i = 1; i < curve.pointList.Count; i++)
            {
                if (curve.pointList.Count >= 2)
                {
                    e.Graphics.DrawLine(pen, curve.pointList[i - 1].PointX,
                    curve.pointList[i - 1].PointY, curve.pointList[i].PointX,
                    curve.pointList[i].PointY);
                }                
            }
        }

        // button for exit makes sure that the program finishes
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }   

        // button for calculating the curve length calls curve class' CurveLength method to calculate the length
        private void btnCurveLength_Click(object sender, EventArgs e)
        {
            double txt = curve.CurveLength();
            lblCurveLength.Text = txt.ToString();
        }
        
        // when mouse leaves the picturebox, x - y axises values disappear
        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            labelX.Text = "";
            labelY.Text = "";
        }

        // when mouse is moving inside the picturebox, x - y axises values appear on the screen (panel2)
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            labelX.Text = "X = " + e.X.ToString();
            labelY.Text = "Y = " + e.Y.ToString();
        }

        // checked if the mouse click is right or left to run different features
        // still calling and using the curve class' methods as AddPoint and Remove Point
        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            this.x = e.X;
            this.y = e.Y;
            
            if(e.Button == MouseButtons.Left)
            {
                curve.AddPoint(e.X, e.Y);
            }
            else
            {
                bool ok = false;

                for (int p = 0; p < curve.pointList.Count; p++)
                {
                    if (curve.pointList[p].PointX == this.x && curve.pointList[p].PointY == this.y)
                    {
                        ok = true;
                        curve.RemovePoint(this.x, this.y);                       
                    } 
                }
                
                if(ok == !true)
                {
                    curve.RemovePoint(curve.pointList[curve.pointList.Count - 1]);
                }
                
            }
            Refresh();
            pictureBox1.Paint += new PaintEventHandler(paint);            
        }
    }
}