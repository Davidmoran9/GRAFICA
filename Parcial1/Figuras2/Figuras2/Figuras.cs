using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.MonthCalendar;

namespace Figuras2
{
    public partial class Figuras : Form
    {
        public Figuras()
        {
            InitializeComponent();
        }
        private void OcultarParametros()
        {
            lblParametro1.Visible = false; txtParametro1.Visible = false;
            lblParametro2.Visible = false; txtParametro2.Visible = false;
            lblParametro3.Visible = false; txtParametro3.Visible = false;
            lblParametro4.Visible = false; txtParametro4.Visible = false;
            lblParametro5.Visible = false; txtParametro5.Visible = false;
            lblParametro6.Visible = false; txtParametro6.Visible = false;
            IbIParametro8.Visible = false; txtParametro8.Visible = false;

        }

        private void Figuras_Load(object sender, EventArgs e)
        {
            cmbFiguras.Items.AddRange(new string[]
{
        "Círculo", "Cuadrado", "Rectángulo", "Triángulo", "Rombo", "Romboide",
        "Trapecio", "Trapecio Isósceles", "Trapezoide", "Elipse", "Óvalo",
        "Pentágono", "Hexágono", "Heptágono", "Octágono", "Eneágono", "Decágono", "Deltoide"
});

            cmbFiguras.SelectedIndex = 0; 

            OcultarParametros();
        }

        private void cmbFiguras_SelectedIndexChanged(object sender, EventArgs e)
        {
            OcultarParametros(); 

            string figura = cmbFiguras.SelectedItem.ToString();

            switch (figura)
            {
                case "Círculo":
                    lblParametro1.Text = "Radio:";
                    lblParametro1.Visible = true; txtParametro1.Visible = true;
                    break;

                case "Cuadrado":
                    lblParametro1.Text = "Lado:";
                    lblParametro1.Visible = true; txtParametro1.Visible = true;
                    break;

                case "Rectángulo":
                    lblParametro1.Text = "Base:";
                    lblParametro2.Text = "Altura:";
                    lblParametro1.Visible = true; txtParametro1.Visible = true;
                    lblParametro2.Visible = true; txtParametro2.Visible = true;
                    break;

                case "Triángulo":
                    lblParametro1.Text = "Base:";
                    lblParametro2.Text = "Altura:";
                    lblParametro3.Text = "Lado 1:";
                    lblParametro4.Text = "Lado 2:";
                    lblParametro5.Text = "Lado 3:";
                    lblParametro1.Visible = true; txtParametro1.Visible = true;
                    lblParametro2.Visible = true; txtParametro2.Visible = true;
                    lblParametro3.Visible = true; txtParametro3.Visible = true;
                    lblParametro4.Visible = true; txtParametro4.Visible = true;
                    lblParametro5.Visible = true; txtParametro5.Visible = true;
                    break;
                case "Decágono":
                    lblParametro1.Text = "Lado:";
                    lblParametro1.Visible = true; txtParametro1.Visible = true;
                    break;

                case "Deltoide":
                    lblParametro1.Text = "Diagonal mayor:";
                    lblParametro2.Text = "Diagonal menor:";
                    lblParametro3.Text = "Lado A:";
                    lblParametro4.Text = "Lado B:";
                    lblParametro1.Visible = true; txtParametro1.Visible = true;
                    lblParametro2.Visible = true; txtParametro2.Visible = true;
                    lblParametro3.Visible = true; txtParametro3.Visible = true;
                    lblParametro4.Visible = true; txtParametro4.Visible = true;
                    break;
                case "Eneágono":
                    lblParametro1.Text = "Lado:";
                    lblParametro1.Visible = true; txtParametro1.Visible = true;
                    break;
                case "Heptágono":
                    lblParametro1.Text = "Lado:";
                    lblParametro1.Visible = true; txtParametro1.Visible = true;
                    break;
                case "Octágono":
                    lblParametro1.Text = "Lado:";
                    lblParametro1.Visible = true; txtParametro1.Visible = true;
                    break;
                case "Óvalo":
                    lblParametro1.Text = "Eje Mayor:";
                    lblParametro2.Text = "Eje Menor:";
                    lblParametro1.Visible = true; txtParametro1.Visible = true;
                    lblParametro2.Visible = true; txtParametro2.Visible = true;
                    break;
                case "Pentágono":
                    lblParametro1.Text = "Lado:";
                    lblParametro1.Visible = true; txtParametro1.Visible = true;
                    break;

                case "Romboide":
                    lblParametro1.Text = "Base:";
                    lblParametro2.Text = "Altura:";
                    lblParametro3.Text = "Lado:";
                    lblParametro1.Visible = true; txtParametro1.Visible = true;
                    lblParametro2.Visible = true; txtParametro2.Visible = true;
                    lblParametro3.Visible = true; txtParametro3.Visible = true;
                    break;
                case "Trapecio Isósceles":
                    lblParametro1.Text = "Base Mayor:";
                    lblParametro2.Text = "Base Menor:";
                    lblParametro3.Text = "Altura:";
                    lblParametro4.Text = "Lado Igual:";
                    lblParametro1.Visible = true; txtParametro1.Visible = true;
                    lblParametro2.Visible = true; txtParametro2.Visible = true;
                    lblParametro3.Visible = true; txtParametro3.Visible = true;
                    lblParametro4.Visible = true; txtParametro4.Visible = true;
                    break;
                case "Trapezoide":
                    lblParametro1.Text = "Lado 1:";
                    lblParametro2.Text = "Lado 2:";
                    lblParametro3.Text = "Lado 3:";
                    lblParametro4.Text = "Lado 4:";
                    lblParametro5.Text = "Base Mayor:";
                    lblParametro6.Text = "Base Menor:";
                    IbIParametro8.Text = "Altura:";
                    lblParametro1.Visible = true; txtParametro1.Visible = true;
                    lblParametro2.Visible = true; txtParametro2.Visible = true;
                    lblParametro3.Visible = true; txtParametro3.Visible = true;
                    lblParametro4.Visible = true; txtParametro4.Visible = true;
                    lblParametro5.Visible = true; txtParametro5.Visible = true;
                    lblParametro6.Visible = true; txtParametro6.Visible = true;
                    IbIParametro8.Visible = true; txtParametro8.Visible = true;
                    break;
                case "Trapecio":
                    lblParametro1.Text = "Base Mayor:";
                    lblParametro2.Text = "Base Menor:";
                    lblParametro3.Text = "Altura:";
                    lblParametro4.Text = "Lado 1:";
                    lblParametro5.Text = "Lado 2:";
                    lblParametro1.Visible = true; txtParametro1.Visible = true;
                    lblParametro2.Visible = true; txtParametro2.Visible = true;
                    lblParametro3.Visible = true; txtParametro3.Visible = true;
                    lblParametro4.Visible = true; txtParametro4.Visible = true;
                    lblParametro5.Visible = true; txtParametro5.Visible = true;
                    lblParametro6.Visible = false; txtParametro6.Visible = false;
                    IbIParametro8.Visible = false; txtParametro8.Visible = false;
                    break;
                case "Elipse":
                    lblParametro1.Text = "Eje Mayor:";
                    lblParametro2.Text = "Eje Menor:";
                    lblParametro1.Visible = true; txtParametro1.Visible = true;
                    lblParametro2.Visible = true; txtParametro2.Visible = true;
                    
                    lblParametro3.Visible = false; txtParametro3.Visible = false;
                    lblParametro4.Visible = false; txtParametro4.Visible = false;
                    lblParametro5.Visible = false; txtParametro5.Visible = false;
                    lblParametro6.Visible = false; txtParametro6.Visible = false;
                    IbIParametro8.Visible = false; txtParametro8.Visible = false;
                    break;
                case "Hexágono":  
                    lblParametro1.Text = "Lado:";
                    lblParametro1.Visible = true;
                    txtParametro1.Visible = true;

                    
                    lblParametro2.Visible = false; txtParametro2.Visible = false;
                    lblParametro3.Visible = false; txtParametro3.Visible = false;
                    lblParametro4.Visible = false; txtParametro4.Visible = false;
                    lblParametro5.Visible = false; txtParametro5.Visible = false;
                    lblParametro6.Visible = false; txtParametro6.Visible = false;
                    IbIParametro8.Visible = false; txtParametro8.Visible = false;
                    break;


                case "Rombo":
                    lblParametro1.Text = "Diagonal mayor:";
                    lblParametro2.Text = "Diagonal menor:";
                    lblParametro3.Text = "Lado:";
                    lblParametro1.Visible = true; txtParametro1.Visible = true;
                    lblParametro2.Visible = true; txtParametro2.Visible = true;
                    lblParametro3.Visible = true; txtParametro3.Visible = true;
                    break;
            }
        }


        private IEnumerable<TextBox> ObtenerTodosLosTextBox(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c is TextBox txt)
                    yield return txt;
                else
                {
                    foreach (TextBox hijo in ObtenerTodosLosTextBox(c))
                        yield return hijo;
                }
            }
        }


        private void btnCalcular_Click(object sender, EventArgs e)
        {
            foreach (TextBox txt in ObtenerTodosLosTextBox(this))
            {
                if (txt.Visible)
                {
                    if (string.IsNullOrWhiteSpace(txt.Text))
                    {
                        MessageBox.Show("Por favor, complete todos los campos numéricos.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txt.Focus();
                        return;
                    }

                    if (!double.TryParse(txt.Text, out _))
                    {
                        MessageBox.Show("Ingrese solo valores numéricos válidos (no letras ni símbolos).", "Valor inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt.Focus();
                        return;
                    }
                }
            }
            try
            {
                string figura = cmbFiguras.SelectedItem.ToString();
                FiguraGeometrica figuraSeleccionada = null;

                switch (figura)
                {
                    case "Círculo":
                        double radio = Convert.ToDouble(txtParametro1.Text);
                        figuraSeleccionada = new Circulo(radio);
                        break;

                    case "Cuadrado":
                        double lado = Convert.ToDouble(txtParametro1.Text);
                        figuraSeleccionada = new Rectangulo(lado, lado); 
                        break;

                    case "Rectángulo":
                        double baseR = Convert.ToDouble(txtParametro1.Text);
                        double alturaR = Convert.ToDouble(txtParametro2.Text);
                        figuraSeleccionada = new Rectangulo(baseR, alturaR);
                        break;

                    case "Triángulo":
                        double baseT = Convert.ToDouble(txtParametro1.Text);
                        double alturaT = Convert.ToDouble(txtParametro2.Text);
                        double lado1 = Convert.ToDouble(txtParametro3.Text);
                        double lado2 = Convert.ToDouble(txtParametro4.Text);
                        double lado3 = Convert.ToDouble(txtParametro5.Text);
                        figuraSeleccionada = new Triangulo(lado1, lado2, lado3);
                        break;

                    case "Rombo":
                        double diagonalMayor = Convert.ToDouble(txtParametro1.Text);
                        double diagonalMenor = Convert.ToDouble(txtParametro2.Text);
                        figuraSeleccionada = new Rombo(diagonalMayor, diagonalMenor);
                        break;

                    case "Hexágono":
                        double ladoHex = Convert.ToDouble(txtParametro1.Text);
                        figuraSeleccionada = new Hexagono(ladoHex);
                        break;

                    case "Elipse":
                        double ejeMayor = Convert.ToDouble(txtParametro1.Text);
                        double ejeMenor = Convert.ToDouble(txtParametro2.Text);
                        figuraSeleccionada = new Elipse(ejeMayor, ejeMenor);
                        break;
                    case "Decágono":
                        double ladoDeca = Convert.ToDouble(txtParametro1.Text);
                        figuraSeleccionada = new Decagono(ladoDeca);
                        break;
                    case "Deltoide":
                        double diagMayor = Convert.ToDouble(txtParametro1.Text);
                        double diagMenor = Convert.ToDouble(txtParametro2.Text);
                        double ladoA = Convert.ToDouble(txtParametro3.Text);
                        double ladoB = Convert.ToDouble(txtParametro4.Text);
                        figuraSeleccionada = new Deltoide(diagMayor, diagMenor, ladoA, ladoB);
                        break;
                    case "Eneágono":
                        double ladoEneagono = Convert.ToDouble(txtParametro1.Text);
                        figuraSeleccionada = new Eneagono(ladoEneagono);
                        break;
                    case "Heptágono":
                        double ladoHeptagono = Convert.ToDouble(txtParametro1.Text);
                        figuraSeleccionada = new Heptagono(ladoHeptagono);
                        break;
                    case "Octágono":
                        double ladoOctagono = Convert.ToDouble(txtParametro1.Text);
                        figuraSeleccionada = new Octagono(ladoOctagono);
                        break;
                    case "Óvalo":
                        double ejeMayorOvalo = Convert.ToDouble(txtParametro1.Text);
                        double ejeMenorOvalo = Convert.ToDouble(txtParametro2.Text);
                        figuraSeleccionada = new Ovalo(ejeMayorOvalo, ejeMenorOvalo);
                        break;
                    case "Pentágono":
                        double ladoPentagono = Convert.ToDouble(txtParametro1.Text);
                        figuraSeleccionada = new Pentagono(ladoPentagono);
                        break;
                    case "Romboide":
                        double baseRomboide = Convert.ToDouble(txtParametro1.Text);
                        double alturaRomboide = Convert.ToDouble(txtParametro2.Text);
                        double ladoRomboide = Convert.ToDouble(txtParametro3.Text);
                        figuraSeleccionada = new Romboide(baseRomboide, alturaRomboide, ladoRomboide);
                        break;
                    case "Trapecio Isósceles":
                        double baseMayor = Convert.ToDouble(txtParametro1.Text);
                        double baseMenor = Convert.ToDouble(txtParametro2.Text);
                        double altura = Convert.ToDouble(txtParametro3.Text);
                        double ladoIgual = Convert.ToDouble(txtParametro4.Text);
                        figuraSeleccionada = new TrapecioIsosceles(baseMayor, baseMenor, altura, ladoIgual);
                        break;
                    case "Trapezoide":
                        double ladoT1 = Convert.ToDouble(txtParametro1.Text);
                        double ladoT2 = Convert.ToDouble(txtParametro2.Text);
                        double ladoT3 = Convert.ToDouble(txtParametro3.Text);
                        double ladoT4 = Convert.ToDouble(txtParametro4.Text);
                        double baseMayorT = Convert.ToDouble(txtParametro5.Text);
                        double baseMenorT = Convert.ToDouble(txtParametro6.Text);
                        double alturaTr = Convert.ToDouble(txtParametro8.Text);
                        figuraSeleccionada = new Trapezoide(ladoT1, ladoT2, ladoT3, ladoT4, baseMayorT, baseMenorT, alturaTr);
                        break;
                    case "Trapecio":
                        double baseMayorN = Convert.ToDouble(txtParametro1.Text);
                        double baseMenorN = Convert.ToDouble(txtParametro2.Text);
                        double alturaN = Convert.ToDouble(txtParametro3.Text);
                        double lado1N = Convert.ToDouble(txtParametro4.Text);
                        double lado2N = Convert.ToDouble(txtParametro5.Text);
                        figuraSeleccionada = new Trapecio(baseMayorN, baseMenorN, alturaN, lado1N, lado2N);
                        break;

                }

                if (figuraSeleccionada != null)
                {
                    double area = figuraSeleccionada.CalcularArea();
                    double perimetro = figuraSeleccionada.CalcularPerimetro();

                    MessageBox.Show($"Área: {area}\nPerímetro: {perimetro}", "Resultado");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error");
            }
        }


    }
}
