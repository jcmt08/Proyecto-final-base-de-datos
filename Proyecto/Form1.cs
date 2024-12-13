using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Capa_Entidad;
using Capa_Final;

namespace Proyecto
{
    public partial class Form1 : Form
    {
        ClassEntidad objent = new ClassEntidad();
        ClassFinal objneg = new ClassFinal();
        public Form1()
        {
            InitializeComponent();
            txtModoJuego.DropDownStyle = ComboBoxStyle.DropDownList;


        }

        void mantenimiento(String accion)
        {

            objent.id = txtID.Text;
            objent.cancion = txtCancion.Text;
            objent.artista = txtArtista.Text;
            objent.genero = txtGenero.Text;
            objent.ModoJuego = txtModoJuego.Text;
            objent.username = txtUsername.Text;
            objent.duracion = Convert.ToInt32(txtDuracion.Text);
            objent.estrellas = Convert.ToInt32(txtEstrellas.Text);
            objent.notas = Convert.ToInt32(txtNotas.Text);
            objent.FechaSubida = Convert.ToInt32(txtFechaSubida.Text);
            objent.FechaActu = Convert.ToInt32(txtFechaActu.Text);
            objent.BPM = Convert.ToInt32(txtBPM.Text);
            objent.accion = accion;
            String men = objneg.mantenimiento_canciones(objent);
            MessageBox.Show(men, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        void limpiar()
        {
            txtID.Text = "";
            txtCancion.Text = "";
            txtArtista.Text = "";
            txtGenero.Text = "";
            txtModoJuego.Text = "";
            txtUsername.Text = "";
            txtDuracion.Text = "";
            txtEstrellas.Text = "";
            txtNotas.Text = "";
            txtFechaSubida.Text = "";
            txtFechaActu.Text = "";
            txtBPM.Text = "";

            dataGridView1.DataSource = objneg.listar_canciones();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = objneg.listar_canciones();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                if (MessageBox.Show("¿Deseas registrar a " + txtCancion.Text + "?", "Mensaje",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {
                    mantenimiento("1");
                    limpiar();
                }
            }
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtID.Text != "")
            {
                if (MessageBox.Show("¿Deseas modificar a " + txtCancion.Text + "?", "Mensaje",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {
                    mantenimiento("2");
                    limpiar();
                }
            }
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtID.Text != "")
            {
                if (MessageBox.Show("¿Deseas eliminar a " + txtCancion.Text + "?", "Mensaje",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {
                    mantenimiento("3");
                    limpiar();
                }
            }
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                if (txtBusqueda.Text != "")
                {
                    objent.cancion = txtBusqueda.Text;
                    DataTable dt = new DataTable();
                    dt = objneg.buscar_canciones(objent);
                     dataGridView1.DataSource = dt;
                }
                else
                {
                    dataGridView1.DataSource = objneg.listar_canciones();
                }
            }
            else
            {
                if (radioButton2.Checked == true)
                {
                    if (txtBusqueda.Text != "")
                    {
                        objent.artista = txtBusqueda.Text;
                        DataTable dt = new DataTable();
                        dt = objneg.buscar_canciones2(objent);
                        dataGridView1.DataSource = dt;
                    }
                    else
                    {
                        dataGridView1.DataSource = objneg.listar_canciones();
                    }
                }
            }
            if (radioGenero.Checked == true)
            {
                if (txtBusqueda.Text != "")
                {
                    objent.genero = txtBusqueda.Text;
                    DataTable dt = new DataTable();
                    dt = objneg.buscar_canciones3(objent);
                    dataGridView1.DataSource = dt;
                }
                else
                {
                    dataGridView1.DataSource = objneg.listar_canciones();
                }
            }
            
            if (radioModoJuego.Checked == true)
            {
                if (txtBusqueda.Text != "")
                {
                    objent.ModoJuego = txtBusqueda.Text;
                    DataTable dt = new DataTable();
                    dt = objneg.buscar_canciones6(objent);
                    dataGridView1.DataSource = dt;
                }
                else
                {
                    dataGridView1.DataSource = objneg.listar_canciones();
                }
            }
            else
            {
                if (radioUsername.Checked == true)
                {
                    if (txtBusqueda.Text != "")
                    {
                        objent.username = txtBusqueda.Text;
                        DataTable dt = new DataTable();
                        dt = objneg.buscar_canciones7(objent);
                        dataGridView1.DataSource = dt;
                    }
                    else
                    {
                        dataGridView1.DataSource = objneg.listar_canciones();
                    }
                }
            }






        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
                int fila = dataGridView1.CurrentCell.RowIndex;

                txtID.Text = dataGridView1[0, fila].Value.ToString();
                txtCancion.Text = dataGridView1[1, fila].Value.ToString();
                txtArtista.Text = dataGridView1[2, fila].Value.ToString();
                txtGenero.Text = dataGridView1[3, fila].Value.ToString();
                txtModoJuego.Text = dataGridView1[4, fila].Value.ToString();
                txtUsername.Text = dataGridView1[5, fila].Value.ToString();
                txtDuracion.Text = dataGridView1[6, fila].Value.ToString();
                txtEstrellas.Text = dataGridView1[7, fila].Value.ToString();
                txtNotas.Text = dataGridView1[8, fila].Value.ToString();
                txtFechaSubida.Text = dataGridView1[9, fila].Value.ToString();
                txtFechaActu.Text = dataGridView1[10, fila].Value.ToString();
                txtBPM.Text = dataGridView1[11, fila].Value.ToString();
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int fila = dataGridView1.CurrentCell.RowIndex;

            txtID.Text = dataGridView1[0, fila].Value.ToString();
            txtCancion.Text = dataGridView1[1, fila].Value.ToString();
            txtArtista.Text = dataGridView1[2, fila].Value.ToString();
            txtGenero.Text = dataGridView1[3, fila].Value.ToString();
            txtModoJuego.Text = dataGridView1[4, fila].Value.ToString();
            txtUsername.Text = dataGridView1[5, fila].Value.ToString();
            txtDuracion.Text = dataGridView1[6, fila].Value.ToString();
            txtEstrellas.Text = dataGridView1[7, fila].Value.ToString();
            txtNotas.Text = dataGridView1[8, fila].Value.ToString();
            txtFechaSubida.Text = dataGridView1[9, fila].Value.ToString();
            txtFechaActu.Text = dataGridView1[10, fila].Value.ToString();
            txtBPM.Text = dataGridView1[11, fila].Value.ToString();
        }

        private void txtModoJuego_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }
    }
    }

