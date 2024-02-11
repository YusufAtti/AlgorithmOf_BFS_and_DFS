using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Prolab2_1
{
    abstract class BaseIzgara
    {
        private string path;
        private int boyut;
        private List<List<Button>> buttons = new List<List<Button>>();
        private int[,] lastIzgara;
        private Image wall = Image.FromFile("C://Users//yusuf//OneDrive//Masaüstü//2.sınıf 2.dönem//P1//Prolab2_1//9last//Prolab2_1//Prolab2_1//img//111.jpg");

        public abstract List<List<Button>> generateIzgara();


        public string Path { get => path; set => path = value; }
        public int Boyut { get => boyut; set => boyut = value; }
        public List<List<Button>> Buttons { get => buttons; set => buttons = value; }
        public int[,] LastIzgara { get => lastIzgara; set => lastIzgara = value; }
        public Image Wall { get => wall; set => wall = value; }
    }
}
