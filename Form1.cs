using MySql.Data.MySqlClient;

namespace CubiculosBiblioteca
{
    public partial class Form1 : Form
    {
        private BD mConexion;
        public Form1()
        {
            InitializeComponent();
            mConexion = new BD();
        }
        private void mandarDatos(int codigo, int cubiculo, string estatus)
        {
            DateTime localDate = DateTime.Now;
            string consulta = "insert into peticiones values ('" + codigo + "','" + cubiculo + "', '" + localDate.ToString("yyyy-MM-dd H:mm:ss") + "','" + estatus + "')";
            try
            {
                mConexion.getConexion().Open();
                MySqlCommand cmd = new MySqlCommand(consulta, mConexion.getConexion());
                cmd.ExecuteNonQuery();
                mConexion.getConexion().Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error en la peticion");
            }
        }
        private string checarCodigo()
        {
            string codigo = Convert.ToString(txtCodigo.Text);
            if (codigo.LongCount() != 9)
            {
                return "0";
            }
            return codigo;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(checarCodigo());
            if (codigo != 0) {
                int cubiculo = 0;
                string estatus = "Ocupado";
                if (chbCubiculo1.Enabled)
                {
                    lblCubiculo1.Text = "Ocupado";
                    lblCubiculo1.BackColor = SystemColors.ControlDark;
                    cubiculo = 1;
                }
                if (chbCubiculo2.Enabled)
                {
                    lblCubiculo2.Text = "Ocupado";
                    lblCubiculo2.BackColor = SystemColors.ControlDark;
                    cubiculo = 2;
                }
                if (chbCubiculo3.Enabled)
                {
                    lblCubiculo3.Text = "Ocupado";
                    lblCubiculo3.BackColor = SystemColors.ControlDark;
                    cubiculo = 3;
                }
                mandarDatos(codigo, cubiculo, estatus);
            }
            else 
            {
                MessageBox.Show("Ingrese bien el codigo");
            }
            txtCodigo.Text = "";
            chbCubiculo1.Checked = false;
            chbCubiculo2.Checked = false;
            chbCubiculo3.Checked = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(checarCodigo());
            if (codigo != 0)
            {
                int cubiculo = 0;
                string estatus = "Disponible";
                if (chbCubiculo1.Enabled)
                {
                    lblCubiculo1.Text = "Disponible";
                    lblCubiculo1.BackColor = SystemColors.HotTrack;
                    cubiculo = 1;
                }
                if (chbCubiculo2.Enabled)
                {
                    lblCubiculo2.Text = "Disponible";
                    lblCubiculo2.BackColor = SystemColors.HotTrack;
                    cubiculo = 2;
                }
                if (chbCubiculo3.Enabled)
                {
                    lblCubiculo3.Text = "Disponible";
                    lblCubiculo3.BackColor = SystemColors.HotTrack;
                    cubiculo = 3;
                }
                mandarDatos(codigo, cubiculo, estatus);
            }
            else
            {
                MessageBox.Show("Ingrese bien el codigo");
            }
            txtCodigo.Text = "";
            chbCubiculo1.Checked = false;
            chbCubiculo2.Checked = false;
            chbCubiculo3.Checked = false;
        }

        private void BtnConectar_Click(object sender, EventArgs e)
        {
            string result = "";
            string consulta = "select * from peticiones";
            try
            {
                mConexion.getConexion().Open();
                MySqlCommand cmd = new MySqlCommand(consulta, mConexion.getConexion());
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    result += "\nCodigo: " + reader["codigo"];
                    result += " Cubiculo: " + reader["cubiculo"];
                    result += " Fecha y hora: " + reader["fechaHora"];
                    result += " Estatus: " + reader["estatus"];
                }
                MessageBox.Show(result);
                mConexion.getConexion().Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al conectar");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void chbCubiculo1_CheckedChanged(object sender, EventArgs e)
        {
            if (chbCubiculo2.Enabled||chbCubiculo3.Enabled)
            {
                chbCubiculo2.Enabled = false;
                chbCubiculo3.Enabled = false;
                if (lblCubiculo1.Text == "Disponible")
                {
                    btnOcupar.Enabled = true;
                    btnDesocupar.Enabled = false;
                }
                else
                {
                    btnDesocupar.Enabled = true;
                }
            }
            else{
                btnOcupar.Enabled = false;
                btnDesocupar.Enabled = false;
                chbCubiculo2.Enabled = true;
                chbCubiculo3.Enabled = true;
            }
            
        }

        private void chbCubiculo2_CheckedChanged(object sender, EventArgs e)
        {
            if (chbCubiculo1.Enabled||chbCubiculo3.Enabled)
            {
                btnDesocupar.Enabled = true;
                chbCubiculo1.Enabled = false;
                chbCubiculo3.Enabled = false;
                if (lblCubiculo2.Text == "Disponible")
                {
                    btnOcupar.Enabled = true;
                    btnDesocupar.Enabled = false;
                }
                else
                {
                    btnDesocupar.Enabled = true;
                }
            }
            else
            {
                btnOcupar.Enabled = false;
                btnDesocupar.Enabled = false;
                chbCubiculo1.Enabled = true;
                chbCubiculo3.Enabled = true;
            }
        }

        private void chbCubiculo3_CheckedChanged(object sender, EventArgs e)
        {
            if (chbCubiculo1.Enabled||chbCubiculo2.Enabled)
            {
                chbCubiculo1.Enabled = false;
                chbCubiculo2.Enabled = false;
                if (lblCubiculo3.Text == "Disponible")
                {
                    btnOcupar.Enabled = true;
                    btnDesocupar.Enabled = false;
                }
                else
                {
                    btnDesocupar.Enabled = true;
                }
            }
            else
            {
                btnOcupar.Enabled = false;
                btnDesocupar.Enabled = false;
                chbCubiculo1.Enabled = true;
                chbCubiculo2.Enabled = true;
            }
        }

        private void lblCubiculo1_Click(object sender, EventArgs e)
        {

        }

        private void lblCubiculo2_Click(object sender, EventArgs e)
        {

        }
    }
}