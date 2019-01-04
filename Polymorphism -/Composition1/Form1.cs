using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// inclass 4 ben powers 

namespace Polymorphism1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //design a class object
        public abstract class Shape //abstract class
        {
            public virtual double Area(){return 0;} // gets area of 2d shapes
            public virtual string Name(){return null;} // gets names of all 2d and 3d shapes
            public virtual double Volume() { return 0; } // gets volume of 3d shapes
        }
      
        //inheritance
        public class Triangle : Shape  // triangle class using inheritance of shape
        {           
            private double tbase ;    
            private double height;
 
            //property Accessor Methods 
            public double Tbase // get set triangle base
            {
                set { tbase = value; }
                get { return tbase; }
            }
            //property Accessor Methods 
            public double Height // get set Height of triangle
            {
                set { height = value; }
                get { return height; }
            }

            public override double Area() // Override method to calculate area 
            {
                return 0.5*tbase*height;
            }
            public override string Name() // Override method to receive input and return it
            {
                return "Shape:Triangle";
            }
        }

        //inheritance
        public class Circle : Shape // circle class using inheritance for shape
        {
            private double radius;

            //property Accessor Methods 
            public double Radius // get set Radius of circle
            {
                set { radius = value; }
                get { return radius; }
            }

            public override double Area() // Override method to calculate area
            {
                return radius*radius * Math.PI;
            }
            public override string Name() // override method to receive inputn and return it
            {
                return "Shape:Circle";
            }
        }

        //inheritance
        public class Rectangle : Shape // rectangle class using inheritance for shape
        {
            private double length;
            private double width;

            //property Accessor Methods 
            public double Length // get set Length
            {
                set { length = value; }
                get { return length; }
            }
            //property Accessor Methods 
            public double Width // get set Width
            {
                set { width = value; }
                get { return width; }
            }

            public override double Area() // override method to calculate area 
            { 
                return width*length; 
            }
            public override string Name() // override method to recieve input and return it
            {
                return "Shape:Rectangle";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Circle myCircle = new Circle(); // instance of circle
            Rectangle myRectangle = new Rectangle(); // instance of rectangle
            Triangle myTriangle = new Triangle(); // instance of triangle 

            myCircle.Radius = Convert.ToDouble(textBox_radius.Text); // calling radius from circle class and converting it to double 
            myRectangle.Length = Convert.ToDouble(textBox_sqLength.Text); // calling length from rectangle class and converting to to double 
            myRectangle.Width = Convert.ToDouble(textBox_sqWidth.Text); // calling width from rectangle class and converting to to double
            myTriangle.Tbase = Convert.ToDouble(textBox_triBase.Text); // calling triangle base from triangle class and converting it to double 
            myTriangle.Height = Convert.ToDouble(textBox_triHeight.Text); // calling triagnle height from triangle class and converting it to double

            Box myBox = new Box(myRectangle.Length, myRectangle.Width); // instance of box (3d rectangle)
            Pyramid myPyramid = new Pyramid(myTriangle.Tbase, myTriangle.Height); // instance of pyramid(3d triangle)
            Sphere mySphere = new Sphere(myCircle.Radius); // instance of sphere(3d circle)

            mySphere.HeightS = Convert.ToDouble(textBox_Z1.Text); // calling height from sphere and converting it to double
            myBox.Height = Convert.ToDouble(textBox_Z2.Text); // calling height from box and converting it to double 
            myPyramid.HeightP = Convert.ToDouble(textBox_Z3.Text); // calling height from pyramid and converting it to double

            Shape[] myShapes = new Shape[6]; // array of all 6 shapes 
            myShapes[0] = myCircle; // circle is 1
            myShapes[1] = myTriangle; // triangle is 2
            myShapes[2] = myRectangle; // rectangle is 3
            myShapes[3] = myBox; // box is 4
            myShapes[4] = myPyramid; // pyramid is 5
            myShapes[5] = mySphere; // sphere is 6 

            outputLabel.Text = "";


            outputLabel.Text = "";
            foreach (Shape thisShape in myShapes) // for loop 
            {
                string name = thisShape.Name();

                if (name.Contains("Box") || name.Contains("Pyramid") || name.Contains("Sphere"))
                    outputLabel.Text += "\n " + thisShape.Name() + " volume= " + thisShape.Volume();
                else
                    outputLabel.Text += "\n " + thisShape.Name() + " area= " + thisShape.Area();
            }
        }

        public class Sphere : Circle // public class Sphere using circle as inheritance
        {
            Circle circle = new Circle(); // instance of circle 

            public double HeightS { get; set; } // get set Height

            public Sphere(double radius) // declaring that the radius from circle class is radius in sphere class
            {
                circle.Radius = radius;
            }

            public override double Volume() // override method calculating volume of a sphere
            {
                return (double)(4 / 3) * circle.Area() * circle.Radius;
            }

            public override string Name() // override method for names 
            {
                return "Volume: Sphere";
            }
        }

        public class Box : Rectangle // public class Box using Rectangle as inheritance
        {
            Rectangle rectangle = new Rectangle(); // instance of rectangle
            public Box(double length, double width) // declaring that the length and width from rectangle class is now in Box class
            {
                rectangle.Length = length;
                rectangle.Width = width;
            }

            public double Height { get; set; } // get set height
            public override double Volume() // override method to calculate volume 
            {
                return (double)(rectangle.Area() * Height);
            }

            public override string Name() // override method for names
            {
                return "Volume: Box";
            }
        }

        public class Pyramid : Triangle // public class for Pyramid using triangle as inheritance
        {
            Triangle triangle = new Triangle(); // instance of triangle

            public double HeightP { get; set; } // get set heightP
            public Pyramid(double tbase, double height) // declaring that the tbase and height from the triangle class is now in Pyramid class
            {
                triangle.Tbase = tbase;
                triangle.Height = height;
            }

            public override double Volume() // override method to calculate volume of pyramid
            {
                return (double)(triangle.Area() / 3 * HeightP);
            }

            public override string Name() // override method for names
            {
                return "Volume: Pyramid";
            }
        }
    }
}
