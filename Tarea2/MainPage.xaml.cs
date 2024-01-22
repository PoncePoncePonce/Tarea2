namespace Tarea2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        //Metodo que ejecuta el boton
        private void Aceptar_Clicked(object sender, EventArgs e)
        {
            //Se agrega el texto del entry al label de resultado
            label_resultado.Text = "Resultado\r\n" + entry_info.Text;
        }
    }

}
