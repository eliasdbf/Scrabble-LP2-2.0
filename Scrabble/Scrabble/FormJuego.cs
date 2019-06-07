using Scrabble.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Scrabble
{
    public partial class FormJuego : Form
    {
        Label[,] labels = new Label[15, 15];
        Label[] letrasJugador = new Label[7];  // letras que el usuario dispone
        Label[] letrasJarvis = new Label[7];   // letras de jarvis 
        string letra = "";                         // letra seleccionada
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }
        const int WM_SYSCOMMAND = 0x112;
        const int MOUSE_MOVE = 0xF012;

        // Declaraciones del API 
        [System.Runtime.InteropServices.DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        // 
        [System.Runtime.InteropServices.DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        // 
        // función privada usada para mover el formulario actual 

        private void moverForm()
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, MOUSE_MOVE, 0);
        }

        private void Form1_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            moverForm();
        }

        public FormJuego()
        {
            InitializeComponent();
        }

        public void RepartirLetras(ref Label sender, int semilla, EventArgs e)
        {

            Random random = new Random(semilla);

            int numeroRamdom = random.Next(1, 28);
            if (sender is Label)
            {
                if (numeroRamdom != 7 || numeroRamdom != 6 || numeroRamdom != 9)
                {
                    switch (numeroRamdom)
                    {
                        case 1:
                            (sender as Label).Text = "A";
                            break;
                        case 2:
                            (sender as Label).Text = "B";
                            break;
                        case 3:
                            (sender as Label).Text = "C";
                            break;
                        case 4:
                            (sender as Label).Text = "CH";
                            break;
                        case 5:
                            (sender as Label).Text = "D";
                            break;
                        case 6:
                            (sender as Label).Text = "E";
                            break;
                        case 7:
                            (sender as Label).Text = "F";
                            break;
                        case 8:
                            (sender as Label).Text = "G";
                            break;
                        case 9:
                            (sender as Label).Text = "H";
                            break;
                        case 10:
                            (sender as Label).Text = "I";
                            break;
                        case 11:
                            (sender as Label).Text = "J";
                            break;
                        case 12:
                            (sender as Label).Text = "L";
                            break;
                        case 13:
                            (sender as Label).Text = "LL";
                            break;
                        case 14:
                            (sender as Label).Text = "M";
                            break;
                        case 15:
                            (sender as Label).Text = "N";
                            break;
                        case 16:
                            (sender as Label).Text = "Ñ";
                            break;
                        case 17:
                            (sender as Label).Text = "O";
                            break;
                        case 18:
                            (sender as Label).Text = "P";
                            break;
                        case 19:
                            (sender as Label).Text = "Q";
                            break;
                        case 20:
                            (sender as Label).Text = "R";
                            break;
                        case 21:
                            (sender as Label).Text = "RR";
                            break;
                        case 22:
                            (sender as Label).Text = "S";
                            break;
                        case 23:
                            (sender as Label).Text = "T";
                            break;
                        case 24:
                            (sender as Label).Text = "U";
                            break;
                        case 25:
                            (sender as Label).Text = "V";
                            break;
                        case 26:
                            (sender as Label).Text = "X";
                            break;
                        case 27:
                            (sender as Label).Text = "Y";
                            break;
                        case 28:
                            (sender as Label).Text = "Z";
                            break;
                    }

                }
                else RepartirLetras(ref sender, semilla, e);
            }
            (sender as Label).Image = Image.FromFile(@"D:\Scrabble\Scrabble\reursos\LetrasImagenes\asdas\" + (sender as Label).Text.ToLower() + ".png");
            
        }

        public void Insertar(object sender, EventArgs e)
        {

            (sender as Label).Text = letra;
            if (sender is Label) // se asigna una letra en el tablero
            {
                switch (letra)
                {
                    case "A":
                        (sender as Label).Image = Image.FromFile(@"D:\Scrabble\Scrabble\reursos\LetrasImagenes\asdas\a.png");
                        break;
                    case "B":
                        (sender as Label).Image = Image.FromFile(@"D:\Scrabble\Scrabble\reursos\LetrasImagenes\asdas\b.png");
                        break;
                    case "C":
                        (sender as Label).Image = Image.FromFile(@"D:\Scrabble\Scrabble\reursos\LetrasImagenes\asdas\c.png");
                        break;
                    case "D":
                        (sender as Label).Image = Image.FromFile(@"D:\Scrabble\Scrabble\reursos\LetrasImagenes\asdas\d.png");
                        break;
                    case "E":
                        (sender as Label).Image = Image.FromFile(@"D:\Scrabble\Scrabble\reursos\LetrasImagenes\asdas\e.png");
                        break;
                    case "F":
                        (sender as Label).Image = Image.FromFile(@"D:\Scrabble\Scrabble\reursos\LetrasImagenes\asdas\f.png");
                        break;
                    case "G":
                        (sender as Label).Image = Image.FromFile(@"D:\Scrabble\Scrabble\reursos\LetrasImagenes\asdas\g.png");
                        break;
                    case "H":
                        (sender as Label).Image = Image.FromFile(@"D:\Scrabble\Scrabble\reursos\LetrasImagenes\asdas\h.png");
                        break;
                    case "I":
                        (sender as Label).Image = Image.FromFile(@"D:\Scrabble\Scrabble\reursos\LetrasImagenes\asdas\i.png");
                        break;
                    case "J":
                        (sender as Label).Image = Image.FromFile(@"D:\Scrabble\Scrabble\reursos\LetrasImagenes\asdas\j.png");
                        break;
                    case "L":
                        (sender as Label).Image = Image.FromFile(@"D:\Scrabble\Scrabble\reursos\LetrasImagenes\asdas\l.png");
                        break;
                    case "M":
                        (sender as Label).Image = Image.FromFile(@"D:\Scrabble\Scrabble\reursos\LetrasImagenes\asdas\m.png");
                        break;
                    case "N":
                        (sender as Label).Image = Image.FromFile(@"D:\Scrabble\Scrabble\reursos\LetrasImagenes\asdas\n.png");
                        break;
                    case "O":
                        (sender as Label).Image = Image.FromFile(@"D:\Scrabble\Scrabble\reursos\LetrasImagenes\asdas\o.png");
                        break;
                    case "P":
                        (sender as Label).Image = Image.FromFile(@"D:\Scrabble\Scrabble\reursos\LetrasImagenes\asdas\p.png");
                        break;
                    case "Q":
                        (sender as Label).Image = Image.FromFile(@"D:\Scrabble\Scrabble\reursos\LetrasImagenes\asdas\q.png");
                        break;
                    case "R":
                        (sender as Label).Image = Image.FromFile(@"D:\Scrabble\Scrabble\reursos\LetrasImagenes\asdas\r.png");
                        break;
                    case "S":
                        (sender as Label).Image = Image.FromFile(@"D:\Scrabble\Scrabble\reursos\LetrasImagenes\asdas\s.png");
                        break;
                    case "T":
                        (sender as Label).Image = Image.FromFile(@"D:\Scrabble\Scrabble\reursos\LetrasImagenes\asdas\t.png");
                        break;
                    case "U":
                        (sender as Label).Image = Image.FromFile(@"D:\Scrabble\Scrabble\reursos\LetrasImagenes\asdas\u.png");
                        break;
                    case "V":
                        (sender as Label).Image = Image.FromFile(@"D:\Scrabble\Scrabble\reursos\LetrasImagenes\asdas\v.png");
                        break;
                    case "X":
                        (sender as Label).Image = Image.FromFile(@"D:\Scrabble\Scrabble\reursos\LetrasImagenes\asdas\x.png");
                        break;
                    case "Y":
                        (sender as Label).Image = Image.FromFile(@"D:\Scrabble\Scrabble\reursos\LetrasImagenes\asdas\y.png");
                        break;
                    case "Z":
                        (sender as Label).Image = Image.FromFile(@"D:\Scrabble\Scrabble\reursos\LetrasImagenes\asdas\z.png");
                        break;
                    case "LL":
                        (sender as Label).Image = Image.FromFile(@"D:\Scrabble\Scrabble\reursos\LetrasImagenes\asdas\ll.png");
                        break;
                    case "RR":
                        (sender as Label).Image = Image.FromFile(@"D:\Scrabble\Scrabble\reursos\LetrasImagenes\asdas\rr.png");
                        break;
                    case "Ñ":
                        (sender as Label).Image = Image.FromFile(@"D:\Scrabble\Scrabble\reursos\LetrasImagenes\asdas\ñ.png");
                        break;
                    case "CH":
                        (sender as Label).Image = Image.FromFile(@"D:\Scrabble\Scrabble\reursos\LetrasImagenes\asdas\ch.png");
                        break;
                    default:
                        break;
                }
                if (letrasJugador[0] == null) { letrasJugador[0] = (sender as Label); MessageBox.Show(letrasJugador[0].Name); }
                else if (letrasJugador[1] == null)  letrasJugador[1] = (sender as Label);
                else if (letrasJugador[2] == null)  letrasJugador[2] = (sender as Label);
                else if (letrasJugador[3] == null)  letrasJugador[3] = (sender as Label);
                else if (letrasJugador[4] == null)  letrasJugador[4] = (sender as Label);
                else if (letrasJugador[5] == null)  letrasJugador[5] = (sender as Label);
                else if (letrasJugador[6] == null)  letrasJugador[6] = (sender as Label);
                }
            Letra1.Enabled = true; Letra2.Enabled = true; Letra3.Enabled = true; Letra4.Enabled = true; Letra5.Enabled = true; Letra6.Enabled = true; Letra7.Enabled = true;
            letra = "";
        }

        private void FormJuego_Load(object sender, EventArgs e)
        {
            
            Asignar(sender, e);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);

            MessageBox.Show("holad");
            /*RepartirLetras(ref Letra1, Environment.TickCount+1, e);
            RepartirLetras(ref Letra2, Environment.TickCount+2, e);
            RepartirLetras(ref Letra3, Environment.TickCount+3, e);
            RepartirLetras(ref Letra4, Environment.TickCount+4, e);
            RepartirLetras(ref Letra5, Environment.TickCount+5, e);
            RepartirLetras(ref Letra6, Environment.TickCount+6, e);
            RepartirLetras(ref Letra7, Environment.TickCount + 7, e);*/
            Letra1.Text = "A";
            Letra1.Image = Image.FromFile(@"D:\Scrabble\Scrabble\reursos\LetrasImagenes\asdas\a.png");
            Letra2.Text = "B";
            Letra2.Image = Image.FromFile(@"D:\Scrabble\Scrabble\reursos\LetrasImagenes\asdas\b.png");
            Letra3.Text = "A";
            Letra3.Image = Image.FromFile(@"D:\Scrabble\Scrabble\reursos\LetrasImagenes\asdas\a.png");
            Letra4.Text = "A";
            Letra4.Image = Image.FromFile(@"D:\Scrabble\Scrabble\reursos\LetrasImagenes\asdas\a.png");
            Letra5.Text = "B";
            Letra5.Image = Image.FromFile(@"D:\Scrabble\Scrabble\reursos\LetrasImagenes\asdas\b.png");
            Letra6.Text = "A";
            Letra6.Image = Image.FromFile(@"D:\Scrabble\Scrabble\reursos\LetrasImagenes\asdas\a.png");
            Letra7.Text = "D";
            Letra7.Image = Image.FromFile(@"D:\Scrabble\Scrabble\reursos\LetrasImagenes\asdas\d.png");

        }
       
        private void BtnTerminarTurno_Click(object sender, EventArgs e)
        {
          
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Diccionario diccionario = new Diccionario();
            diccionario.Show();
        }

        private void label1_DoubleClick(object sender, EventArgs e)
        {

        }

        public void clickLetra(object sender,EventArgs e)
        {
            if ((sender as Label).Text == "")
            {

            }
            else
            {
                letra = (sender as Label).Text;
                (sender as Label).Visible = false;
                Letra1.Enabled = false; Letra2.Enabled = false; Letra3.Enabled = false; Letra4.Enabled = false; Letra5.Enabled = false; Letra6.Enabled = false; Letra7.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e) // desplegar diccionario
        {
            Diccionario diccionario = new Diccionario();
            diccionario.Show();
        }

        private void button5_Click(object sender, EventArgs e) // boton para pedir fichas
        {
            if (Letra1.Visible == true && Letra2.Visible == true && Letra3.Visible == true && Letra4.Visible == true && Letra5.Visible == true && Letra6.Visible == true && Letra7.Visible == true)
            {
                RepartirLetras(ref Letra1, Environment.TickCount + 1, e);
                RepartirLetras(ref Letra2, Environment.TickCount + 2, e);
                RepartirLetras(ref Letra3, Environment.TickCount + 3, e);
                RepartirLetras(ref Letra4, Environment.TickCount + 4, e);
                RepartirLetras(ref Letra5, Environment.TickCount + 5, e);
                RepartirLetras(ref Letra6, Environment.TickCount + 6, e);
                RepartirLetras(ref Letra7, Environment.TickCount + 7, e);
            }
            else MessageBox.Show("Todavia posee letras en el tablero,devuelva las existentes antes de pedir otras", "No puede realizar esta accion");
        } 

        private void button3_Click(object sender, EventArgs e) // devolver fichas (editar)
        {
            Letra1.Visible = true;
            Letra2.Visible = true;
            Letra3.Visible = true;
            Letra4.Visible = true;
            Letra5.Visible = true;
            Letra6.Visible = true;
            Letra7.Visible = true;
            letrasJugador[0]= null;
            letrasJugador[1]= null;
            letrasJugador[2]= null;
            letrasJugador[3]= null;
            letrasJugador[4]= null;
            letrasJugador[5]= null;
            letrasJugador[6]= null;
            for (int i = 0; i < 15; i++)
            {
                for(int j = 0; j < 15; j++)
                {
                    if (labels[i, j].Enabled == true)
                    {
                        labels[i, j].Image = null;
                        labels[i, j].Text = "";

                    }
                }
            }
        }

        public void VerificarPalabra(object sender, EventArgs e)
        {

        }
        public void Asignar(object sender, EventArgs e)
        {
            // Fila 0
            labels[0, 0] = new Label(); labels[0, 0] = label_0_0;
            labels[0, 1] = new Label(); labels[0, 1] = label_0_1;
            labels[0, 2] = new Label(); labels[0, 2] = label_0_2;
            labels[0, 3] = new Label(); labels[0, 3] = label_0_3;
            labels[0, 4] = new Label(); labels[0, 4] = label_0_4;
            labels[0, 5] = new Label(); labels[0, 5] = label_0_5;
            labels[0, 6] = new Label(); labels[0, 6] = label_0_6;
            labels[0, 7] = new Label(); labels[0, 7] = label_0_7;
            labels[0, 8] = new Label(); labels[0, 8] = label_0_8;
            labels[0, 9] = new Label(); labels[0, 9] = label_0_9;
            labels[0, 10] = new Label(); labels[0, 10] = label_0_10;
            labels[0, 11] = new Label(); labels[0, 11] = label_0_11;
            labels[0, 12] = new Label(); labels[0, 12] = label_0_12;
            labels[0, 13] = new Label(); labels[0, 13] = label_0_13;
            labels[0, 14] = new Label(); labels[0, 14] = label_0_14;
            // fila 1
            labels[1, 0] = new Label(); labels[1, 0] = label_1_0;
            labels[1, 1] = new Label(); labels[1, 1] = label_1_1;
            labels[1, 2] = new Label(); labels[1, 2] = label_1_2;
            labels[1, 3] = new Label(); labels[1, 3] = label_1_3;
            labels[1, 4] = new Label(); labels[1, 4] = label_1_4;
            labels[1, 5] = new Label(); labels[1, 5] = label_1_5;
            labels[1, 6] = new Label(); labels[1, 6] = label_1_6;
            labels[1, 7] = new Label(); labels[1, 7] = label_1_7;
            labels[1, 8] = new Label(); labels[1, 8] = label_1_8;
            labels[1, 9] = new Label(); labels[1, 9] = label_1_9;
            labels[1, 10] = new Label(); labels[1, 10] = label_1_10;
            labels[1, 11] = new Label(); labels[1, 11] = label_1_11;
            labels[1, 12] = new Label(); labels[1, 12] = label_1_12;
            labels[1, 13] = new Label(); labels[1, 13] = label_1_13;
            labels[1, 14] = new Label(); labels[1, 14] = label_1_14;
            // fila 2
            labels[2, 0] = new Label(); labels[2, 0] = label_2_0;
            labels[2, 1] = new Label(); labels[2, 1] = label_2_1;
            labels[2, 2] = new Label(); labels[2, 2] = label_2_2;
            labels[2, 2] = new Label(); labels[2, 2] = label_2_2;
            labels[2, 3] = new Label(); labels[2, 3] = label_2_3;
            labels[2, 4] = new Label(); labels[2, 4] = label_2_4;
            labels[2, 5] = new Label(); labels[2, 5] = label_2_5;
            labels[2, 6] = new Label(); labels[2, 6] = label_2_6;
            labels[2, 7] = new Label(); labels[2, 7] = label_2_7;
            labels[2, 8] = new Label(); labels[2, 8] = label_2_8;
            labels[2, 9] = new Label(); labels[2, 9] = label_2_9;
            labels[2, 10] = new Label(); labels[2, 10] = label_2_10;
            labels[2, 11] = new Label(); labels[2, 11] = label_2_11;
            labels[2, 12] = new Label(); labels[2, 12] = label_2_12;
            labels[2, 13] = new Label(); labels[2, 13] = label_2_13;
            labels[2, 14] = new Label(); labels[2, 14] = label_2_14;
            // fila 3
            labels[3, 0] = new Label(); labels[3, 0] = label_3_0;
            labels[3, 1] = new Label(); labels[3, 1] = label_3_1;
            labels[3, 2] = new Label(); labels[3, 2] = label_3_2;
            labels[3, 3] = new Label(); labels[3, 3] = label_3_3;
            labels[3, 4] = new Label(); labels[3, 4] = label_3_4;
            labels[3, 5] = new Label(); labels[3, 5] = label_3_5;
            labels[3, 6] = new Label(); labels[3, 6] = label_3_6;
            labels[3, 7] = new Label(); labels[3, 7] = label_3_7;
            labels[3, 8] = new Label(); labels[3, 8] = label_3_8;
            labels[3, 9] = new Label(); labels[3, 9] = label_3_9;
            labels[3, 10] = new Label(); labels[3, 10] = label_3_10;
            labels[3, 11] = new Label(); labels[3, 11] = label_3_11;
            labels[3, 12] = new Label(); labels[3, 12] = label_3_12;
            labels[3, 13] = new Label(); labels[3, 13] = label_3_13;
            labels[3, 14] = new Label(); labels[3, 14] = label_3_14;
            //fila 4
            labels[4, 0] = new Label(); labels[4, 0] = label_4_0;
            labels[4, 1] = new Label(); labels[4, 1] = label_4_1;
            labels[4, 2] = new Label(); labels[4, 2] = label_4_2;
            labels[4, 3] = new Label(); labels[4, 3] = label_4_3;
            labels[4, 4] = new Label(); labels[4, 4] = label_4_4;
            labels[4, 5] = new Label(); labels[4, 5] = label_4_5;
            labels[4, 6] = new Label(); labels[4, 6] = label_4_6;
            labels[4, 7] = new Label(); labels[4, 7] = label_4_7;
            labels[4, 8] = new Label(); labels[4, 8] = label_4_8;
            labels[4, 9] = new Label(); labels[4, 9] = label_4_9;
            labels[4, 10] = new Label(); labels[4, 10] = label_4_10;
            labels[4, 11] = new Label(); labels[4, 11] = label_4_11;
            labels[4, 12] = new Label(); labels[4, 12] = label_4_12;
            labels[4, 13] = new Label(); labels[4, 13] = label_4_13;
            labels[4, 14] = new Label(); labels[4, 14] = label_4_14;
            // fila 5
            labels[5, 0] = new Label(); labels[5, 0] = label_5_0;
            labels[5, 1] = new Label(); labels[5, 1] = label_5_1;
            labels[5, 2] = new Label(); labels[5, 2] = label_5_2;
            labels[5, 3] = new Label(); labels[5, 3] = label_5_3;
            labels[5, 4] = new Label(); labels[5, 4] = label_5_4;
            labels[5, 5] = new Label(); labels[5, 5] = label_5_5;
            labels[5, 6] = new Label(); labels[5, 6] = label_5_6;
            labels[5, 7] = new Label(); labels[5, 7] = label_5_7;
            labels[5, 8] = new Label(); labels[5, 8] = label_5_8;
            labels[5, 9] = new Label(); labels[5, 9] = label_5_9;
            labels[5, 10] = new Label(); labels[5, 10] = label_5_10;
            labels[5, 11] = new Label(); labels[5, 11] = label_5_11;
            labels[5, 12] = new Label(); labels[5, 12] = label_5_12;
            labels[5, 13] = new Label(); labels[5, 13] = label_5_13;
            labels[5, 14] = new Label(); labels[5, 14] = label_5_14;
            // fila 6
            labels[6, 0] = new Label(); labels[6, 0] = label_6_0;
            labels[6, 1] = new Label(); labels[6, 1] = label_6_1;
            labels[6, 2] = new Label(); labels[6, 2] = label_6_2;
            labels[6, 3] = new Label(); labels[6, 3] = label_6_3;
            labels[6, 4] = new Label(); labels[6, 4] = label_6_4;
            labels[6, 5] = new Label(); labels[6, 5] = label_6_5;
            labels[6, 6] = new Label(); labels[6, 6] = label_6_6;
            labels[6, 7] = new Label(); labels[6, 7] = label_6_7;
            labels[6, 8] = new Label(); labels[6, 8] = label_6_8;
            labels[6, 9] = new Label(); labels[6, 9] = label_6_9;
            labels[6, 10] = new Label(); labels[6, 10] = label_6_10;
            labels[6, 11] = new Label(); labels[6, 11] = label_6_11;
            labels[6, 12] = new Label(); labels[6, 12] = label_6_12;
            labels[6, 13] = new Label(); labels[6, 13] = label_6_13;
            labels[6, 14] = new Label(); labels[6, 14] = label_6_14;
            //fila 7
            labels[7, 0] = new Label(); labels[7, 0] = label_7_0;
            labels[7, 1] = new Label(); labels[7, 1] = label_7_1;
            labels[7, 2] = new Label(); labels[7, 2] = label_7_2;
            labels[7, 3] = new Label(); labels[7, 3] = label_7_3;
            labels[7, 4] = new Label(); labels[7, 4] = label_7_4;
            labels[7, 5] = new Label(); labels[7, 5] = label_7_5;
            labels[7, 6] = new Label(); labels[7, 6] = label_7_6;
            labels[7, 7] = new Label(); labels[7, 7] = label_7_7;
            labels[7, 8] = new Label(); labels[7, 8] = label_7_8;
            labels[7, 9] = new Label(); labels[7, 9] = label_7_9;
            labels[7, 10] = new Label(); labels[7, 10] = label_7_10;
            labels[7, 11] = new Label(); labels[7, 11] = label_7_11;
            labels[7, 12] = new Label(); labels[7, 12] = label_7_12;
            labels[7, 13] = new Label(); labels[7, 13] = label_7_13;
            labels[7, 14] = new Label(); labels[7, 14] = label_7_14;
            //fila 8
            labels[8, 0] = new Label(); labels[8, 0] = label_8_0;
            labels[8, 1] = new Label(); labels[8, 1] = label_8_1;
            labels[8, 2] = new Label(); labels[8, 2] = label_8_2;
            labels[8, 3] = new Label(); labels[8, 3] = label_8_3;
            labels[8, 4] = new Label(); labels[8, 4] = label_8_4;
            labels[8, 5] = new Label(); labels[8, 5] = label_8_5;
            labels[8, 6] = new Label(); labels[8, 6] = label_8_6;
            labels[8, 7] = new Label(); labels[8, 7] = label_8_7;
            labels[8, 8] = new Label(); labels[8, 8] = label_8_8;
            labels[8, 9] = new Label(); labels[8, 9] = label_8_9;
            labels[8, 10] = new Label(); labels[8, 10] = label_8_10;
            labels[8, 11] = new Label(); labels[8, 11] = label_8_11;
            labels[8, 12] = new Label(); labels[8, 12] = label_8_12;
            labels[8, 13] = new Label(); labels[8, 13] = label_8_13;
            labels[8, 14] = new Label(); labels[8, 14] = label_8_14;
            //fila 9
            labels[9, 0] = new Label(); labels[9, 0] = label_9_0;
            labels[9, 1] = new Label(); labels[9, 1] = label_9_1;
            labels[9, 2] = new Label(); labels[9, 2] = label_9_2;
            labels[9, 3] = new Label(); labels[9, 3] = label_9_3;
            labels[9, 4] = new Label(); labels[9, 4] = label_9_4;
            labels[9, 5] = new Label(); labels[9, 5] = label_9_5;
            labels[9, 6] = new Label(); labels[9, 6] = label_9_6;
            labels[9, 7] = new Label(); labels[9, 7] = label_9_7;
            labels[9, 8] = new Label(); labels[9, 8] = label_9_8;
            labels[9, 9] = new Label(); labels[9, 9] = label_9_9;
            labels[9, 10] = new Label(); labels[9, 10] = label_9_10;
            labels[9, 11] = new Label(); labels[9, 11] = label_9_11;
            labels[9, 12] = new Label(); labels[9, 12] = label_9_12;
            labels[9, 13] = new Label(); labels[9, 13] = label_9_13;
            labels[9, 14] = new Label(); labels[9, 14] = label_9_14;
            // fila 10
            labels[10, 0] = new Label(); labels[10, 0] = label_10_0;
            labels[10, 1] = new Label(); labels[10, 1] = label_10_1;
            labels[10, 2] = new Label(); labels[10, 2] = label_10_2;
            labels[10, 3] = new Label(); labels[10, 3] = label_10_3;
            labels[10, 4] = new Label(); labels[10, 4] = label_10_4;
            labels[10, 5] = new Label(); labels[10, 5] = label_10_5;
            labels[10, 6] = new Label(); labels[10, 6] = label_10_6;
            labels[10, 7] = new Label(); labels[10, 7] = label_10_7;
            labels[10, 8] = new Label(); labels[10, 8] = label_10_8;
            labels[10, 9] = new Label(); labels[10, 9] = label_10_9;
            labels[10, 10] = new Label(); labels[10, 10] = label_10_10;
            labels[10, 11] = new Label(); labels[10, 11] = label_10_11;
            labels[10, 12] = new Label(); labels[10, 12] = label_10_12;
            labels[10, 13] = new Label(); labels[10, 13] = label_10_13;
            labels[10, 14] = new Label(); labels[10, 14] = label_10_14;
            // fila 11
            labels[11, 0] = new Label(); labels[11, 0] = label_11_0;
            labels[11, 1] = new Label(); labels[11, 1] = label_11_1;
            labels[11, 2] = new Label(); labels[11, 2] = label_11_2;
            labels[11, 3] = new Label(); labels[11, 3] = label_11_3;
            labels[11, 4] = new Label(); labels[11, 4] = label_11_4;
            labels[11, 5] = new Label(); labels[11, 5] = label_11_5;
            labels[11, 6] = new Label(); labels[11, 6] = label_11_6;
            labels[11, 7] = new Label(); labels[11, 7] = label_11_7;
            labels[11, 8] = new Label(); labels[11, 8] = label_11_8;
            labels[11, 9] = new Label(); labels[11, 9] = label_11_9;
            labels[11, 10] = new Label(); labels[11, 10] = label_11_10;
            labels[11, 11] = new Label(); labels[11, 11] = label_11_11;
            labels[11, 12] = new Label(); labels[11, 12] = label_11_12;
            labels[11, 13] = new Label(); labels[11, 13] = label_11_13;
            labels[11, 14] = new Label(); labels[11, 14] = label_11_14;
            // fila 12
            labels[12, 0] = new Label(); labels[12, 0] = label_12_0;
            labels[12, 1] = new Label(); labels[12, 1] = label_12_1;
            labels[12, 2] = new Label(); labels[12, 2] = label_12_2;
            labels[12, 3] = new Label(); labels[12, 3] = label_12_3;
            labels[12, 4] = new Label(); labels[12, 4] = label_12_4;
            labels[12, 5] = new Label(); labels[12, 5] = label_12_5;
            labels[12, 6] = new Label(); labels[12, 6] = label_12_6;
            labels[12, 7] = new Label(); labels[12, 7] = label_12_7;
            labels[12, 8] = new Label(); labels[12, 8] = label_12_8;
            labels[12, 9] = new Label(); labels[12, 9] = label_12_9;
            labels[12, 10] = new Label(); labels[12, 10] = label_12_10;
            labels[12, 11] = new Label(); labels[12, 11] = label_12_11;
            labels[12, 12] = new Label(); labels[12, 12] = label_12_12;
            labels[12, 13] = new Label(); labels[12, 13] = label_12_13;
            labels[12, 14] = new Label(); labels[12, 14] = label_12_14;
            //fila 13
            labels[13, 0] = new Label(); labels[13, 0] = label_13_0;
            labels[13, 1] = new Label(); labels[13, 1] = label_13_1;
            labels[13, 2] = new Label(); labels[13, 2] = label_13_2;
            labels[13, 3] = new Label(); labels[13, 3] = label_13_3;
            labels[13, 4] = new Label(); labels[13, 4] = label_13_4;
            labels[13, 5] = new Label(); labels[13, 5] = label_13_5;
            labels[13, 6] = new Label(); labels[13, 6] = label_13_6;
            labels[13, 7] = new Label(); labels[13, 7] = label_13_7;
            labels[13, 8] = new Label(); labels[13, 8] = label_13_8;
            labels[13, 9] = new Label(); labels[13, 9] = label_13_9;
            labels[13, 10] = new Label(); labels[13, 10] = label_13_10;
            labels[13, 11] = new Label(); labels[13, 11] = label_13_11;
            labels[13, 12] = new Label(); labels[13, 12] = label_13_12;
            labels[13, 13] = new Label(); labels[13, 13] = label_13_13;
            labels[13, 14] = new Label(); labels[13, 14] = label_13_14;
            //fila 14
            labels[14, 0] = new Label(); labels[14, 0] = label_14_0;
            labels[14, 1] = new Label(); labels[14, 1] = label_14_1;
            labels[14, 2] = new Label(); labels[14, 2] = label_14_2;
            labels[14, 3] = new Label(); labels[14, 3] = label_14_3;
            labels[14, 4] = new Label(); labels[14, 4] = label_14_4;
            labels[14, 5] = new Label(); labels[14, 5] = label_14_5;
            labels[14, 6] = new Label(); labels[14, 6] = label_14_6;
            labels[14, 7] = new Label(); labels[14, 7] = label_14_7;
            labels[14, 8] = new Label(); labels[14, 8] = label_14_8;
            labels[14, 9] = new Label(); labels[14, 9] = label_14_9;
            labels[14, 10] = new Label(); labels[14, 10] = label_14_10;
            labels[14, 11] = new Label(); labels[14, 11] = label_14_11;
            labels[14, 12] = new Label(); labels[14, 12] = label_14_12;
            labels[14, 13] = new Label(); labels[14, 13] = label_14_13;
            labels[14, 14] = new Label(); labels[14, 14] = label_14_14;

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            VerificarPalabra(sender, e);
        }
    }
}
