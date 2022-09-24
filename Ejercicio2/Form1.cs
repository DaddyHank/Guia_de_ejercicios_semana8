using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2
{
    public partial class Form1 : Form
    {
        public List<Estudiantes> listStudents = new List<Estudiantes>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text) || string.IsNullOrEmpty(txtNombres.Text) || string.IsNullOrEmpty(txtApellidos.Text))
            {
                MessageBox.Show("Para continuar debe completar todos los campos");
            }
            else
            {
                int id = int.Parse(txtId.Text);
                string nombre = txtNombres.Text;
                string apellidos = txtApellidos.Text;
                listStudents.Add(new Estudiantes(){
                    Id = id, Nombres = nombre, Apellidos = apellidos
                });
                MessageBox.Show("Su registro fue agregado con éxito :)");
                txtId.Clear();
                txtNombres.Clear();
                txtApellidos.Clear();
            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            if (listStudents.Count > 0)
            {
                f2.listStudents = this.listStudents;
                f2.Show();
            }
            else
            {
                MessageBox.Show("Favor de agragar al menos un registro...");
            }
        }
    }
}
