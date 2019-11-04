using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Ordenamiento
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<int> miLista = new ObservableCollection<int>();
        ObservableCollection<Alumno> alumnos = new ObservableCollection<Alumno>();

        public MainWindow()
        {
            InitializeComponent();
            /*miLista.Add(58);
            miLista.Add(35);
            miLista.Add(20);
            miLista.Add(16);
            miLista.Add(14);
            miLista.Add(12);
            miLista.Add(60);
            miLista.Add(4);*/

            alumnos.Add(new Alumno("Damian", 9.1f, 2));
            alumnos.Add(new Alumno("Bryan", 9.8f, 0));
            alumnos.Add(new Alumno("Jose", 6.4f, 14));
            alumnos.Add(new Alumno("Maria", 8.5f, 4));
            alumnos.Add(new Alumno("Dora", 7.7f, 4));
            lstNumeros.ItemsSource = alumnos;
        }

        private void btnOrdenar_Click(object sender, RoutedEventArgs e)
        {
            /*var temp = miLista[0];
         miLista[0] = miLista[3];
         miLista[3] = temp;*/

            int gap, i;
            gap = alumnos.Count / 2;

            while (gap > 0)
            {
                for (i = 0; i < alumnos.Count; i++)
                {
                    if (gap + i < alumnos.Count && alumnos[i].Promedio > alumnos[gap + i].Promedio)
                    {
                        var temp = alumnos[i];
                        alumnos[i] = alumnos[gap + i];
                        alumnos[gap + i] = temp;

                    }
                }

                gap--;
            }
        }

        private void btnOrdenar_Bubble_Click(object sender, RoutedEventArgs e)
        {
            bool intercambio = false;

            do
            {
                intercambio = false;
                for (int i = 0; i < alumnos.Count - 1; i++)
                {
                    if (alumnos[i].Promedio > alumnos[i + 1].Promedio)
                    {
                        var temp = alumnos[i];
                        alumnos[i] = alumnos[i + 1];
                        alumnos[i + 1] = temp;
                        intercambio = true;
                    }
                }
            } while (intercambio);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            int gap, i;
            gap = alumnos.Count / 2;

            while (gap > 0)
            {
                for (i = 0; i < alumnos.Count; i++)
                {
                    if (gap + i < alumnos.Count && alumnos[i].Faltas > alumnos[gap + i].Faltas)
                    {
                        var temp = alumnos[i];
                        alumnos[i] = alumnos[gap + i];
                        alumnos[gap + i] = temp;

                    }
                }

                gap--;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            bool intercambio = false;

            do
            {
                intercambio = false;
                for (int i = 0; i < alumnos.Count - 1; i++)
                {
                    if (alumnos[i].Faltas > alumnos[i + 1].Faltas)
                    {
                        var temp = alumnos[i];
                        alumnos[i] = alumnos[i + 1];
                        alumnos[i + 1] = temp;
                        intercambio = true;
                    }
                }
            } while (intercambio);
        }
    }
}
