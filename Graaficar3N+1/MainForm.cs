using Microsoft.VisualBasic;
using System;
using System.Windows.Forms;

namespace Graaficar3N_1
{
    public partial class MainForm : Form
    {
        #region Inicialize
        public MainForm() { InitializeComponent(); }
        #endregion

        #region Variables
        Random RNG = new Random();

        Double
            DefaultNum = 0,
            outputNum = 0,
            TopNum = 0,
            BottomNum = 0;
        #endregion

        #region Funciones y eventos

        #region Funciones
        void Graficar3NPlus1()
        {
            TopNum = 0;
            BottomNum = outputNum;

            Waiting_Panel.Visible = false;
            chart.Visible = true;

            try
            { chart.Series[0].Points.Clear(); }
            catch { }

            ConsoleSeparator();
            Double counter = 0;

            do
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                counter++;

                //Si el número es impar
                if ((outputNum % 2) != 0)
                {
                    Console.WriteLine("\nNúmero de pasos dados: " + counter +
                        "\n----------------------------" +
                        "\n\n1. El número: " + outputNum + " es impar." +
                        "\n2. Lo multiplicamos por \"3\" que serían:\n    " + outputNum + " x 3 = " + (outputNum * 3) +
                        "\n3. le sumamos \"1\" que serían:\n    " + (outputNum * 3) + " + 1 = " + ((outputNum * 3) + 1) + "\"");

                    outputNum = (outputNum * 3) + 1;
                }

                //Si el número es par
                else
                {
                    Console.WriteLine("\nNúmero de pasos dados: " + counter +
                        "\n----------------------------" +
                        "\n\n1. El número: " + outputNum + " es par." +
                        "\n2. Lo dividímos entre \"2\" que serían: \n    " + outputNum + " / 2 = " + (outputNum / 2));

                    outputNum = outputNum / 2;
                }

                //Graficando punto.
                chart.Series[0].Points.Add(outputNum);

                if ((outputNum > TopNum))
                    TopNum = outputNum;

                if ((outputNum < BottomNum) && (outputNum != 4) && (outputNum != 2) && (outputNum != 1) && (outputNum != 0))
                    BottomNum = outputNum;

            }
            while (outputNum != 1);

            //Finalizando ciclo.
            if (outputNum == 1)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\nNúmero de pasos dados: " + counter +
                        "\n----------------------------" +
                        "\n\n1. El número: " + outputNum + " es impar." +
                        "\n2. Lo multiplicamos por \"3\" que serían:\n    " + outputNum + " x 3 = " + (outputNum * 3) +
                        "\n3. le sumamos \"1\" que serían:\n    " + (outputNum * 3) + " + 1 = " + ((outputNum * 3) + 1));
                Console.ForegroundColor = ConsoleColor.White;

                outputNum = (outputNum * 3) + 1;

                Console.WriteLine("\nNúmero de pasos dados: " + counter);
                ConsoleSeparator();

                Console.ForegroundColor = ConsoleColor.Green;
                //Resultado - Salida - Consola final.
                Console.WriteLine("\n¡Ciclo finalizado!\n------------------" +
                    "\nNúmero de pasos requeridos: " + counter +
                    "\nNúmero más alto alcanzado: " + TopNum +
                    "\nNúmero más bajo (obviando 4, 2 y 1): " + BottomNum +
                    "\nNúmero inicializador: " + DefaultNum +
                    "\nPróximo paso: Volver al paso " + (counter - 2));
                Console.ForegroundColor = ConsoleColor.White;

                //Graficando punto final.
                chart.Series[0].Points.Add(outputNum);

            }
        }

        /// <summary>
        /// Agregando un separador a la consola para verse más ordenada.
        /// </summary>
        void ConsoleSeparator()
        { Console.WriteLine("------------------------------------------------------------------------------"); }
        #endregion

        #region Eventos (Controles)
        /// <summary>
        /// Botón de salir de la aplicación.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Está seguro que desea salir del programa?", "¡Está saliendo de la aplicación!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);

            if (dialogResult == DialogResult.Yes)
                Application.Exit();
        }

        /// <summary>
        /// Función que se ejecutará al cargar completamente el formulario, no al mostrar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("¡Programa compilado con éxito!.\nEsperando acciones...");
        }

        /// <summary>
        /// Al dar clikc en el botón de "Insertar número para graficar."
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InsertNum_Button_Click(object sender, EventArgs e)
        {
            Console.Clear();

            DefaultNum = RNG.Next(0, 99999);

            string _Input = Interaction.InputBox("Digita el número de un número que desea ver su gráfica...\n\nValores negativos no permitidos.", "Se espera un valor.", DefaultNum.ToString());

            Console.WriteLine("\nIntentando hacer la conversión de la variable \"_Input\" string a \"outputNum\" en \"Double...");
            try
            {
                outputNum = Double.Parse(_Input);
                DefaultNum = outputNum;
                Console.WriteLine("\nSe convertio la variable \"outputNum\" en \"Double (Número entero)\" correctamente.");
            }
            catch (Exception error)
            {
                Console.WriteLine("\nNo se pudo convertir la variable \"outputNum\" = \"" + _Input + "\" en \"int (Número entero)\"" +
                  "\nCausa del error: " + error.Message + "" +
                  "\ncódigo del error: " + error.HResult);

                MessageBox.Show("No se puede trabajar con caracteres invalidos.", "La operación ha sido cancelada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            if (outputNum <= 0)
                MessageBox.Show("No se puede trabajar con números inferiores a \"1\"", "La operación ha sido cancelada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (!String.IsNullOrWhiteSpace(_Input))
                Graficar3NPlus1();
        }
        #endregion

        #endregion
    }
}
