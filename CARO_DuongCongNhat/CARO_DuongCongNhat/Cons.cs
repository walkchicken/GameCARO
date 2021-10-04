using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CARO_DuongCongNhat
{
    class Cons
    {
        //kich thuo tung o co
        public static int CellWidth = 60;
        public static int CellHeight = 60;

        //kich thuoc cua ban co
        public static int nColsY = 14;
        public static int nRowsX = 14;

        public static int CountDownStep = 100; //ms
        public static int CountDownTime = 10000; // 10 giay = 10000 ms
        public static int CountDownInterval = 100; //sau ba0 lau prcb tang len 1 lan (ms)
    }
}
