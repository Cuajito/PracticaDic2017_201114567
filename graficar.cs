using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WINGRAPHVIZLib;

namespace _EDD_Practica1_201114567
{
    class graficar
    {
        public static Image dibujarGrafo(String grafo_en_DOT)
        {
            WINGRAPHVIZLib.DOT dot = new WINGRAPHVIZLib.DOT();
            WINGRAPHVIZLib.BinaryImage img = dot.ToPNG(grafo_en_DOT);
            byte[] imageBytes = Convert.FromBase64String(img.ToBase64String());
            MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);
            ms.Write(imageBytes, 0, imageBytes.Length);
            Image imagen = Image.FromStream(ms, true);
            return imagen;
        }
    }
}
