﻿using Kiosco_Whimsy.Backend.Modelos;
using Kiosco_Whimsy.MVVM;
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

namespace Kiosco_Whimsy.Frontend.ControlUsuario
{
    /// <summary>
    /// Lógica de interacción para UCVentas.xaml
    /// </summary>
    public partial class UCVentas : UserControl
    {
        private KioscoContext kioscoContext;
        private MVVenta mvVenta;
        //private MVProducto mvProducto;

        public UCVentas(KioscoContext kioscoContext, Usuario usuLogin)
        {
            InitializeComponent();
            this.kioscoContext = kioscoContext;
            mvVenta = new MVVenta(kioscoContext, usuLogin);
            this.DataContext = mvVenta;
        }

        private void btnCategoria_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnProducto_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
