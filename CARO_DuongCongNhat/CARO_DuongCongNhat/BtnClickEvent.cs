using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CARO_DuongCongNhat
{
    public class BtnClickEvent : EventArgs
    {
        private Point clickedPoint;

        public Point ClickedPoint { get => clickedPoint; set => clickedPoint = value; }
        public BtnClickEvent(Point clickedPoint)
        {
            this.ClickedPoint = clickedPoint;
        }
    }
}
