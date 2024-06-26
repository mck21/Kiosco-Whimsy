﻿using Kiosco_Whimsy.Backend.Modelos;
using Kiosco_Whimsy.Frontend.Dialogos;
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
    /// Lógica de interacción para UCUsuarios.xaml
    /// </summary>
    public partial class UCUsuarios : UserControl
    {
        /// <summary>
        /// Contexto de la base de datos
        /// </summary>
        private KioscoContext kioscoContext;
        /// <summary>
        /// ViewModel de Usuario
        /// </summary>
        private MVUsuario mvUsuario;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="kioscoContext">Contexto de la base de datos</param>
        public UCUsuarios(KioscoContext kioscoContext)
        {
            InitializeComponent();
            this.kioscoContext = kioscoContext;
            inicializa();
        }

        /// <summary>
        /// Método que instancia los objetos necesarios
        /// </summary>
        private void inicializa()
        {
            mvUsuario = new MVUsuario(kioscoContext);
            this.DataContext = mvUsuario;
        }

        private void btnEliminarItem_Click(object sender, RoutedEventArgs e)
        {
            //No son necesarios formularios para la gestion de usuarios
        }

        private void btnEditarItem_Click(object sender, RoutedEventArgs e)
        {
            //No son necesarios formularios para la gestion de usuarios
        }

        private void btnAnyadirUsuario_Click(object sender, RoutedEventArgs e)
        {
            //No son necesarios formularios para la gestion de usuarios
        }
    }
}
