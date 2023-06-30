namespace ProyectoDiseñoSoft
{
    public partial class InicioSesion : Form
    {
        public InicioSesion()
        {
            InitializeComponent();
            linkCrear.LinkClicked += linkCrearCuenta_LinkClicked;
            linkAdministrador.LinkClicked += linkAdministrador_LinkClicked;
        }

        private void linkCrearCuenta_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Para abrir el formulario CrearCuenta
            CrearCuenta crearCuenta = new CrearCuenta();
            crearCuenta.Show();
            this.Hide(); 
        }

        private void linkAdministrador_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Para abrir el formulario CuentaAdministrador
            CuentaAdministrador cuentaAdministrador = new CuentaAdministrador();
            cuentaAdministrador.Show();
            this.Hide();
      
        }
    }
}