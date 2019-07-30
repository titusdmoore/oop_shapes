using System;
using System.Collections.Generic;
using System.Text;

namespace OOPShapesProject {
    class Rectangle : Quad {
        private int side1 { get; set; }
        private int side2 { get; set; }

        public Rectangle(int side1, int side2) 
            : base(side1, side2, side1, side2) {
            this.side1 = side1;
            this.side2 = side2;
        }

        public int CalcArea () {
            return side1 * side2;
        }
    }
}
