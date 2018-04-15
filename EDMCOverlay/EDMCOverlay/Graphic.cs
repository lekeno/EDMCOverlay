﻿using System;

namespace EDMCOverlay
{
    public class Graphic
    {
        public String Id { get; set; }

        // The message to display, setting this to empty or null will
        // delete the text
        public String Text { get; set; }

        // normal or large
        public String Size { get; set; }

        // a colour name "red", "yellow", "green", "blue" or "#rrggbb" or "#aarrggbb"
        public String Color { get; set; }

        // a shape fill colour name "red", "yellow", "green", "blue" or "#rrggbb" or "#aarrggbb"
        public String Fill { get; set; }

        // divide the screen by 10 rows
        public int Y { get; set; }

        // divide the screen by 12 cols
        public int X { get; set; }

        // anchor the graphic to an edge of the screen, N E S W NE NW SE SW
        public string Anchor { get; set; }

        // seconds to display, if zero this will default to a 10 second life,
        // any negative number will display the message forever (or until the client quits)
        public int TTL { get; set; }

        // width of shape
        public int W { get; set; }
        
        // height of shape
        public int H { get; set; }

        // Shape name
        public String Shape { get; set; }

        // Vector
        public VectorPoint[] Vector { get; set; }

        public int OldX { get; set; }
        public int OldY { get; set; }

        // Command
        // Commands can be "exit" or "noop"
        public String Command { get; set; }
    }
}