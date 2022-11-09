using DevExpress.Xpf.Bars;
using DevExpress.Xpf.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;


namespace IU.Aemet
{
    /// <summary>
    /// Interaction logic for AemetObservation.xaml
    /// </summary>
    public partial class AemetObservation : ThemedWindow
    {
        public AemetObservation()
        {
            InitializeComponent();
        }

        private void bSaveData_ItemClick(object sender, ItemClickEventArgs e)
        {
            MessageBox.Show("Almacenaríamos los datos en base de datos usando Entity Framework 6, de esta manera tendríamos los datos para nuestras estadísticas");
        }
    }
}
