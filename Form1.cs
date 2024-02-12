namespace Estudiante_datos_27_1_24
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Ingresar_Click(object sender, EventArgs e)
        {
            string Matricula = "", Nombre = "", Apellido = "", Edad = "", Correo = "";





            Matricula = txt_Matricula.Text;
            Nombre = txt_Nombre.Text;
            Apellido = txt_Apellido.Text;
            Edad = txt_Edad.Text;
            Correo = txt_Correo.Text;


            txt_datos.Text = Matricula.ToString() + Nombre.ToString() + Apellido.ToString() +
               Edad.ToString() + Correo.ToString();


        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            txt_Matricula.Clear();
            txt_Nombre.Clear();
            txt_Apellido.Clear();
            txt_Edad.Clear();
            txt_Correo.Clear();
            txt_datos.Clear();

        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txt_Matricula_TextChanged(object sender, EventArgs e)
        {

        }
    }
}