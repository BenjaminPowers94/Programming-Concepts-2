using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XYZinClass3_BenPowers
{
    public partial class Form1 : Form
    {
        int insX = 0; // inside x
        int insY = 0; // inside y
        int insZ = 0; // inside z
        int outsideX = 0; // outside x
        int outsideY = 0; // outisde y
        int outsideZ = 0; // outside z

        public Form1()
        {
            InitializeComponent();
        }

        public class Point // first class "Point"
        {
            private int x; // get set x
            private int y; // get set y
            private int z; // get set z

            public Point (int pX, int pY, int pZ) // constructor
            {
                x = pX;
                y = pY;
                z = pZ;
            }

            public int X // get set for x
            {
                get
                {
                    return x;
                }
                set
                {
                    x = value;
                }
            }

            public int Y // get set for y
            {
                get
                {
                    return y;
                }
                set
                {
                    y = value;
                }
            }

            public int Z // get set for z
            {
                get
                {
                    return z;
                }
                set
                {
                    z = value;
                }
            }
        }

        public class Line // second class "Line"
        {
            private Point pt1; // get set for point 1
            private Point pt2; // get set for point 2
            private Point pt3; // get set for point 3
            private Point pt4; // get set for point 4

            public Point Pt1 // get set for point 1
            {
                get { return pt1; }
                set { pt1 = value; }
            }
            public Point Pt2 // get set for point 2
            {
                get { return pt2; }
                set { pt2 = value; }
            }
            public Point Pt3 // get set for point 3
            {
                get { return pt3; }
                set { pt3 = value; }
            }
            public Point Pt4 // get set for point 4
            {
                get { return pt4; }
                set { pt4 = value; }
            }

            public int volumeCalc(Point pt1, Point pt2, Point pt3, Point pt4) // calculates volume for shape
            {
                return ((pt3.X - pt1.X) * (pt2.Y - pt1.Y) * (pt4.Z - pt1.Z));
            }
        }

        private void calcButton_Click(object sender, EventArgs e) // calculate button 
        {
            insX = int.Parse(insideXTextBox.Text); // calling int insX(insideX) and parsing it to insideTextBoxX
            insY = int.Parse(insideYTextBox.Text); // calling int insY(insideY) and parsing it to insideTextBoxY
            insZ = int.Parse(insideZTextBox.Text); // calling int insZ(insideZ) and parsing it to insideTextBoxZ
            outsideX = int.Parse(outsideTextBoxX.Text); // calling int outsideX and parsing it to outsideTextBoxX
            outsideY = int.Parse(outsideTextBoxY.Text); // calling int outsideY and parsing it to outsideTextBoxY
            outsideZ = int.Parse(outsideTextBoxZ.Text); // calling int outsideZ and parsing it to outsideTextBoxZ

            Point pointA = new Point(insX, insY, insZ); // ask jaey or bill what this is doing 
            Point pointB = new Point(insX, (insY + outsideY), insZ); // ask jaey or bill what this is doing 
            Point pointC = new Point((insX + outsideX), (insY + outsideY), insZ); // ask jaey or bill what this is doing 
            Point pointD = new Point((insX + outsideX), insY, insZ); // ask jaey or bill what this is doing 

            Point pointE = new Point(insX, insY, (insZ + outsideZ)); // ask jaey or bill what this is doing 
            Point pointF = new Point(insX, (insY + outsideY), (insZ + outsideZ)); // ask jaey or bill what this is doing 
            Point pointG = new Point((insX + outsideX), (insY + outsideY), (insZ + outsideZ)); // ask jaey or bill what this is doing 
            Point pointH = new Point((insX + outsideX), insY, (insZ + outsideZ)); // ask jaey or bill what this is doing 

            Line myLine = new Line(); // calling Line Class to buttonCal

            int saABCD = 0; // surface area int for points A B C D
            int saBCFG = 0; // surface area int for points B C F G
            int saCDGH = 0; // surface area int for points C D G H
            int vol = 0; // volume used to calculate the volume of the shape

            displayRich.Text = "X Y Z ORDER: \n\n" +
                            "A: " + pointA.X + ", " + pointA.Y + ", " + pointA.Z + "\n" + // concatatnating 3 points 
                            "B: " + pointB.X + ", " + pointB.Y + ", " + pointB.Z + "\n" + // concatatnating 3 points 
                            "C: " + pointC.X + ", " + pointC.Y + ", " + pointC.Z + "\n" + // concatatnating 3 points 
                            "D: " + pointD.X + ", " + pointD.Y + ", " + pointD.Z + "\n" + // concatatnating 3 points 
                            "E: " + pointE.X + ", " + pointE.Y + ", " + pointE.Z + "\n" + // concatatnating 3 points 
                            "F: " + pointF.X + ", " + pointF.Y + ", " + pointF.Z + "\n" + // concatatnating 3 points 
                            "G: " + pointG.X + ", " + pointG.Y + ", " + pointG.Z + "\n" + // concatatnating 3 points 
                            "H: " + pointH.X + ", " + pointH.Y + ", " + pointH.Z + "\n"; // concatatnating 3 points 

            saABCD = calculateSurfaceArea((pointB.Y - pointA.Y), (pointD.X - pointA.X)); // using intergers and combining two classes together to calc surface area
            saBCFG = calculateSurfaceArea((pointF.Z - pointB.Z), (pointG.X - pointF.X)); // using intergers and combining two classes together to calc surface area
            saCDGH = calculateSurfaceArea((pointC.Y - pointD.Y), (pointH.Z - pointD.Z)); // using intergers and combining two classes together to calc surface area

            // displaying surface area 
            displayRich.Text += "\nSurface Area: \n\n" +
                                        "Surface ABCD: " + saABCD + "\n" + 
                                        "Surface BCFG: " + saBCFG + "\n" +
                                        "Surface CDGH: " + saCDGH + "\n";

            vol = myLine.volumeCalc(pointA, pointB, pointD, pointE); // using volume calc to calculate the surface area

            displayRich.Text += "\nVolume: \n\n" +
                                        "Volume: " + vol + "\n";
        }

        public int calculateSurfaceArea(int a, int b) // surface area calculation
        {
            int sa = 0;

            sa = a * b;

            return sa;
        }
    }
}
