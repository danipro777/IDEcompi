using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;


namespace Proyecto1Compi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string archivoVbs;
        string rutaArchivoExeCompilador = @"C:\Users\ROG STRIX\Documents\UNIVERISIDAD MESOAMERICANA\SEXTO SEMESTRE\COMPILADORES\ProyectoFinal\proyecto.exe"; // Ruta al archivo ejecutable
        string rutaDeSalida = @"C:\Users\ROG STRIX\Documents\UNIVERISIDAD MESOAMERICANA\SEXTO SEMESTRE\COMPILADORES\Pdfsalida"; //Ruta de la salida y donde se guardara
        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialogTexto = new OpenFileDialog();

            // Configura OpenFileDialog
            openFileDialogTexto.Title = "Seleccione un Archivo";
            openFileDialogTexto.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            openFileDialogTexto.FilterIndex = 1;

            //cuadro de diálogo de seleccion de archivo
            if (openFileDialogTexto.ShowDialog() == DialogResult.OK)
            {
                //Obtener la ruta 
                archivoVbs = openFileDialogTexto.FileName;

                //instrucciones de archivo
                MessageBox.Show("Se ha seleccionado: " + archivoVbs);
            }
        }

        private void btnCompilar_Click(object sender, EventArgs e)
        {
            string rutaArchivoVbs = archivoVbs; // Ruta al archivo a utilizar

            //Verifica existencia de archivos
            if (File.Exists(rutaArchivoExeCompilador) && File.Exists(rutaArchivoVbs))
            {
                //Crear carpeta para salidas
                Directory.CreateDirectory(rutaDeSalida);

                //Process para interactuar con los archivos del sistema y procesos difentes
                using (Process procesoSalida = new Process())
                {
                    //La funcion para ejecutar el archivo
                    ProcessStartInfo empezarStart = new ProcessStartInfo
                    {
                        //Buscar ejecutable a utilizar
                        FileName = rutaArchivoExeCompilador,
                        //ingreso de entradas para el ejecutable
                        RedirectStandardInput = true,
                        //Leer salida a utilizar para el ejecutable
                        RedirectStandardOutput = true,
                        UseShellExecute = false,
                        CreateNoWindow = true
                    };

                    //ejecutar archivo.exe
                    procesoSalida.StartInfo = empezarStart;
                    procesoSalida.Start();

                    //leer archivo de entrada
                    string contenidoVBS = File.ReadAllText(rutaArchivoVbs);
                    using (StreamWriter sw = procesoSalida.StandardInput)
                    {
                        if (sw.BaseStream.CanWrite)
                        {
                            sw.Write(contenidoVBS);
                        }
                    }

                    //leer salida y guardar en variable
                    string salidaPDFS = procesoSalida.StandardOutput.ReadToEnd();
                    //esperar para salir ejecucion
                    procesoSalida.WaitForExit();

                    //metodo que se utiliza para separar desde un parametro seleccionado o ingresado
                    string[] SepararPDf = salidaPDFS.Split(new[] { "PDF1" }, StringSplitOptions.RemoveEmptyEntries);

                    //Generar salidas
                    for (int i = 0; i < SepararPDf.Length; i++)
                    {
                        string salidaIndividual = SepararPDf[i].Trim();

                        //Generar nombres
                        string nombrePDF = Path.Combine(rutaDeSalida, $"PDF{i + 1}.pdf");

                        //crear pdf
                        using (FileStream fs = new FileStream(nombrePDF, FileMode.Create))
                        {
                            Document PDF = new Document();
                            PdfWriter writer = PdfWriter.GetInstance(PDF, fs);
                            PDF.Open();

                            //agregar informacion de pdf agregado
                            PDF.Add(new Paragraph($"PDF{i + 1} del analizador:"));
                            PDF.Add(new Paragraph(salidaIndividual));

                            PDF.Close();
                        }
                        //Mensaje de exito en caso de encontrar el archivo
                        MessageBox.Show($"PDF{i + 1} Guardado en: {nombrePDF}", "Proceso realizado :D", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {//Mensaje de error en caso de no encontrar el archivo
                MessageBox.Show($"Error al buscar el archivo :d", "ERROR!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}