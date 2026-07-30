using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Controlde_asistencias
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] estudiantes = { "Juan", "Manolo", "Pedro", "María", "Ana", "Carlos", "Luis", "Sofía", "José", "Lucía" };
            listbox_estudiante.Items.AddRange(estudiantes);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_imprimir_Click(object sender, EventArgs e)
        {
            // 1. Validar que se haya seleccionado un estudiante en el ListBox
            if (listbox_estudiante.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecciona un estudiante de la lista.", "Aviso");
                return; // Detiene la ejecución si no hay selección
            }

            // Obtener el nombre del estudiante seleccionado
            string estudiante = listbox_estudiante.SelectedItem.ToString();

            // 2. VALIDACIÓN: Evitar que el estudiante se repita en el label
            if (label_lista.Text.Contains(estudiante))
            {
                MessageBox.Show($"El estudiante {estudiante} ya fue registrado en la lista.", "Aviso");
                return; // Detiene la ejecución para que no se duplique
            }

            // 3. Condición: Solo si el CheckBox de Presente está marcado se imprime
            if (checkBox_presente.Checked)
            {
                // Agrega el texto al final del Label y da un salto de línea
                label_lista.Text += $"El estudiante {estudiante} está Presente." + Environment.NewLine;

                // Desmarca la casilla automáticamente para el siguiente estudiante
                checkBox_presente.Checked = false;
            }
            else
            {
                // Si dio al botón pero NO marcó la casilla de Presente
                MessageBox.Show($"Debes marcar la casilla de Presente para registrar a {estudiante}.", "Aviso");
            }


        }

        private void checkBox_presente_CheckedChanged(object sender, EventArgs e)
        {
            checkbox_ausente.Enabled = !checkBox_presente.Checked;
        }

        private void checkbox_ausente_CheckedChanged(object sender, EventArgs e)
        {
            checkBox_presente.Enabled = !checkbox_ausente.Checked;
        }
    }
}

