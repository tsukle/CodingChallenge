using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Challenge
{
    public partial class Form1 : Form
    {
        //Declaring the variables that will be used.
        double FloorWidth, FloorDepth, WallWidth, WallHeight, WindowWidth, WindowHeight, RoomWidth, RoomHeight, RoomDepth;
        double WallArea, WindowArea, DoorArea;
        int AmountOfWindows, AmountOfDoors, AmountOfWalls;
        double FloorArea, PaintNeeded, PaintRecommended, RoomVolume;

        //Initialise.
        public Form1()
        {
            InitializeComponent();
        }

        //On program start.
        private void Form1_Load(object sender, EventArgs e)
        {
            //Reset all variables to 0
            FloorWidth = 0;
            FloorDepth = 0;
            WallWidth = 0;
            WallHeight = 0;
            WindowWidth = 0;
            WindowHeight = 0;
            RoomWidth = 0;
            RoomHeight = 0;
            RoomDepth = 0;
        }

        //On "Calculate" button click.
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //Run all functions when button is clicked.
            CalculateFloorArea();
            CalculatePaintNeeded();
            CalculateRoomVolume();
        }

        //This is responsible for calculating the Floor Area.
        void CalculateFloorArea()
        {
            //Set variables, making sure the text is converted into a double to mathematically work with them.
            FloorWidth = Convert.ToDouble(txtFloorWidth.Text);
            FloorDepth = Convert.ToDouble(txtFloorDepth.Text);

            //Calculate and print the value.
            FloorArea = FloorWidth * FloorDepth;
            lblFloorTotal.Text = FloorArea + " m²";
        }

        //This is responsible for calculating the Paint Needed.
        void CalculatePaintNeeded()
        {
            //Set variables, making sure the text is converted into a double to mathematically work with them.
            WallWidth = Convert.ToDouble(txtWallWidth.Text);
            WallHeight = Convert.ToDouble(txtWallHeight.Text);
            WindowWidth = Convert.ToDouble(txtWindowWidth.Text);
            WindowHeight = Convert.ToDouble(txtWindowHeight.Text);

            //Find basic areas.
            WallArea = WallWidth * WallHeight;
            WindowArea = WindowWidth * WindowHeight;
            DoorArea = 1.981 * 0.762;

            //Set variables, making sure the text is converted into an integer to mathematically work with them.
            AmountOfWalls = Convert.ToInt32(nudWallAmount.Value);
            AmountOfWindows = Convert.ToInt32(nudWindowAmount.Value);
            AmountOfDoors = Convert.ToInt32(nudDoorAmount.Value);

            //Multiply areas with the amount chosen.
            WallArea = WallArea * AmountOfWalls;
            WindowArea = WindowArea * AmountOfWindows;
            DoorArea = DoorArea * AmountOfDoors;

            //Subtract window and door areas and divide by 10(m² that the paint can cover per litre) to get the amount that you need.
            WallArea = WallArea - (WindowArea + DoorArea);
            PaintNeeded = WallArea / 10;
            PaintRecommended = Convert.ToInt32(PaintNeeded) + 1; //Added a recommended value with a litre over for the convenience of the customer.

            //Print values.
            lblPaintTotal.Text = "~" + Convert.ToInt32(PaintNeeded) + " Litres | Recommended - " + PaintRecommended + " Litres.";
        }

        //This is responsible for calculating the Room Volume.
        void CalculateRoomVolume()
        {
            //Set variables, making sure the text is converted into a double to mathematically work with them.
            RoomWidth = Convert.ToDouble(txtRoomWidth.Text);
            RoomHeight = Convert.ToDouble(txtRoomHeight.Text);
            RoomDepth = Convert.ToDouble(txtRoomDepth.Text);

            //Calculate and print values.
            RoomVolume = RoomWidth * RoomHeight * RoomDepth;
            lblVolumeTotal.Text = RoomVolume + " m²";
        }
    }
}
