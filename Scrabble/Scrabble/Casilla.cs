using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Scrabble.Properties;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
namespace Scrabble
{
    class Casilla
    {
        Label label;
        int valor;
        int posX;// columnas
        int posY; // filas
        string letra; // caracter
        string estado = "devolvible"; 


        // <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<< Contructores y Encapsulamiento <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<

        public Casilla()
        {
        }
        public int Valor { get; set; }
        public int PosX { get; set; }
        public int PosY { get; set; }
        public string Letra { get; set; }
        public string PathImagen { get; set; }
        public string Estado  { get; set; }
        public Label Label { get; set; }
        


        // <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<< Metodos <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
         public void mostrar()
        {
            MessageBox.Show("ola");
        }










    }
}
