using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;
using System.Windows.Controls;

namespace EjercicioProgra1
{
    public partial class MainWindow : Window
    {
        public class Juego
        {
            public int Puntaje1 { get; set; }
            public int Puntaje2 { get; set; }
            public string Eq1 { get; set; }
            public string Eq2 { get; set; }
            public int Progreso { get; set; }
        }

        private string filePath;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void SelectFile_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == true)
            {
                filePath = openFileDialog.FileName;
            }
        }

        private void LoadData_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(filePath) && File.Exists(filePath))
            {
                List<Juego> juegos = new List<Juego>();

                string[] lines = File.ReadAllLines(filePath);
                foreach (string line in lines)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length == 5 &&
                        int.TryParse(parts[2], out int puntaje1) &&
                        int.TryParse(parts[3], out int puntaje2) &&
                        int.TryParse(parts[4], out int progreso))
                    {
                        juegos.Add(new Juego
                        {
                            Eq1 = parts[0],
                            Eq2 = parts[1],
                            Puntaje1 = puntaje1,
                            Puntaje2 = puntaje2,
                            Progreso = progreso
                        });
                    }
                }

                lbJuego.ItemsSource = juegos;
            }
            else
            {
                MessageBox.Show("El archivo especificado no existe o no se ha seleccionado ningún archivo.");
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (lbJuego.SelectedItem is Juego selectedJuego)
            {
                MessageBox.Show($"Juego Seleccionado: {selectedJuego.Eq1} {selectedJuego.Puntaje1} {selectedJuego.Eq2} {selectedJuego.Puntaje2}");
            }
        }
    }
}
