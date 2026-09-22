namespace A2U3_NumeroControlED3B
{
    public partial class Form1 : Form
    {
        Cola colita = new Cola(4);
        Cliente clientito;
        Cliente[] clientes;
        int turno = 0;
        public Form1()
        {
            InitializeComponent();
            Configurar();
        }
        void Configurar()
        {
            dtgDatos.ColumnCount = 5;
            dtgDatos.Columns[0].Name = "Turno";
            dtgDatos.Columns[1].Name = "Numero";
            dtgDatos.Columns[2].Name = "Nombre";
            dtgDatos.Columns[3].Name = "Operacion";
            dtgDatos.Columns[4].Name = "Llegada";
            dtgDatos.AutoSize = true;
        }
        void Actualizar()
        {
            dtgDatos.Rows.Clear();
            foreach (var c in clientes)
            {
                if (c != null)
                    dtgDatos.Rows.Add(c.NumTurno, c.NumCliente, c.Nombre, c.Operacion, c.HoraLLegada);
            }
        }

        private void btnEncolar_Click(object sender, EventArgs e)
        {
            clientito = new Cliente(turno++, int.Parse(txtNumCliente.Text), txtNombre.Text, txtOpracion.Text, DateTime.Now);
            clientes = colita.Encolar(clientito);
            Actualizar();
        }

        private void btnDesencolar_Click(object sender, EventArgs e)
        {
            clientes = colita.DesEncolar();
            Actualizar();
        }
    }
}
