using System;
using System.Collections.Generic;
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

namespace WPFmatricesTextbox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int m, n;
        Matrix matrixA;

        public MainWindow()
        {
            InitializeComponent();
            textBoxMatrixA.Clear();
            listBoxMatA.Items.Clear();
        }

        private void buttonRead_Click(object sender, RoutedEventArgs e)
        {
            string[] split;

            try
            {
                for (int i = 0; i < m; i++)
                {
                    split = textBoxMatrixA.GetLineText(i).Split(',');

                    for (int j = 0; j < n; j++)
                    {
                        matrixA.Elem[i, j] = double.Parse(split[j]);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Error en la entrada de datos.\nIngrese solo números");
            }
        }

        private void buttonPrint_Click(object sender, RoutedEventArgs e)
        {
            string aux;

            for (int i = 0; i < m; i++)
            {
                aux = " ";
                for (int j = 0; j < n; j++)
                {
                    aux += matrixA.Elem[i, j] + " \t";
                }

                listBoxMatA.Items.Add(aux);
            }
        }

        private void buttonSize_Click(object sender, RoutedEventArgs e)
        {
            m = int.Parse(textBoxM.Text);
            n = int.Parse(textBoxN.Text);
            matrixA = new Matrix(m, n);
        }
    }
}
