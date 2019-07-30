using System;
using System.Collections.Generic;
using System.Text;

namespace OOPShapesProject {
    public class Quad {

        private int side1 { get; set; }
        private int side2 { get; set; }
        private int side3 { get; set; }
        private int side4 { get; set; }

        public Quad(int Side1, int Side2, int Side3, int Side4) {
            this.side1 = Side1;
            this.side2 = Side2;
            this.side3 = Side3;
            this.side4 = Side4;
        }
            public int CalcPerim() {
            return this.side1 + this.side2 + this.side3 + this.side4;
        }
    }
}
