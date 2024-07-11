using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winform_Component
{
    public class Sanpham
    {
        [Key]
        public Guid Ma { get; set; }
        public string Ten { get; set; }
        public int Gia { get; set; } 
        public int Soluong { get; set; }
        public string ImgURL { get; set; }
        public int Trangthai { get; set; }
        public void ABC(int a, string b) // Argument
        {
            Console.WriteLine("álkjaskldj");
        }
        public void XYZ()
        {
            ABC(1, "vui vẻ");
        }
    }
}
