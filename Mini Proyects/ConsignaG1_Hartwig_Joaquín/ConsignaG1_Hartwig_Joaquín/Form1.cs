using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsignaG1_Hartwig_Joaquín
{
    public partial class Form1 : Form
    {
        private Queue<Paciente> colaEspera = new Queue<Paciente>();
        private Stack<Paciente> pilaHistorial = new Stack<Paciente>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (string.IsNullOrWhiteSpace(txtDNI.Text) ||
                    string.IsNullOrWhiteSpace(txtNombre.Text) ||
                    string.IsNullOrWhiteSpace(cmbPrioridad.Text))
                {
                    throw new Exception("Todos los campos (DNI, Nombre, Prioridad) son obligatorios.");
                }

              
                Paciente nuevoPaciente = new Paciente
                {
                    DNI = txtDNI.Text,
                    Nombre = txtNombre.Text,
                    Prioridad = cmbPrioridad.Text
                };

               
                colaEspera.Enqueue(nuevoPaciente);

           
                txtDNI.Clear();
                txtNombre.Clear();
                cmbPrioridad.SelectedIndex = -1;

                ActualizarListas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAtender_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (colaEspera.Count == 0)
                {
                    throw new Exception("No hay pacientes en la cola de espera.");
                }

                
                Paciente pacienteAtendido = colaEspera.Dequeue();

                
                pilaHistorial.Push(pacienteAtendido);

             
                ActualizarListas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void ActualizarListas()
        {
            
            lstEspera.Items.Clear();
            lstHistorial.Items.Clear();

           
            foreach (Paciente p in colaEspera)
            {
                lstEspera.Items.Add(p);
            }

            
            foreach (Paciente p in pilaHistorial)
            {
                lstHistorial.Items.Add(p);
            }
        }
    }
}
