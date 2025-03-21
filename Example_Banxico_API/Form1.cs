namespace Example_Banxico_API
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //close program
            this.Close();
        }

        private void BtnGetInto_Click(object sender, EventArgs e)
        {
            //save data TextBox in variable
            string dataUser = TextBoxUser.Text;
            string dataPass = TextBoxPassword.Text;

            Dolar_menu data_Dolar = new Dolar_menu();
            data_Dolar.Show();

        }
    }
}
