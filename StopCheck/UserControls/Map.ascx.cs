using System;
using System.Web.UI;

namespace StopCheck.UserControls
{
    public partial class Map : UserControl
    {
        public int Size { get; set; }
        public float Latitude { get; set; }
        public float Longitude { get; set; }
        public int Zoom { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        { }
    }
}