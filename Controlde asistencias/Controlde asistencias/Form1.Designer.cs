namespace Controlde_asistencias
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listbox_estudiante = new ListBox();
            checkBox_presente = new CheckBox();
            button_imprimir = new Button();
            label_lista = new Label();
            checkbox_ausente = new CheckBox();
            SuspendLayout();
            // 
            // listbox_estudiante
            // 
            listbox_estudiante.FormattingEnabled = true;
            listbox_estudiante.Location = new Point(22, 51);
            listbox_estudiante.Name = "listbox_estudiante";
            listbox_estudiante.Size = new Size(169, 34);
            listbox_estudiante.TabIndex = 0;
            listbox_estudiante.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // checkBox_presente
            // 
            checkBox_presente.AutoSize = true;
            checkBox_presente.Location = new Point(302, 66);
            checkBox_presente.Name = "checkBox_presente";
            checkBox_presente.Size = new Size(71, 19);
            checkBox_presente.TabIndex = 1;
            checkBox_presente.Text = "Presente";
            checkBox_presente.UseVisualStyleBackColor = true;
            checkBox_presente.CheckedChanged += checkBox_presente_CheckedChanged;
            // 
            // button_imprimir
            // 
            button_imprimir.Location = new Point(22, 208);
            button_imprimir.Name = "button_imprimir";
            button_imprimir.Size = new Size(224, 71);
            button_imprimir.TabIndex = 2;
            button_imprimir.Text = "IMPRIMIR";
            button_imprimir.UseVisualStyleBackColor = true;
            button_imprimir.Click += button_imprimir_Click;
            // 
            // label_lista
            // 
            label_lista.AutoSize = true;
            label_lista.Location = new Point(397, 210);
            label_lista.Name = "label_lista";
            label_lista.Size = new Size(130, 15);
            label_lista.TabIndex = 3;
            label_lista.Text = "LISTA DE ESTUDIANTES";
            // 
            // checkbox_ausente
            // 
            checkbox_ausente.AutoSize = true;
            checkbox_ausente.Location = new Point(415, 66);
            checkbox_ausente.Name = "checkbox_ausente";
            checkbox_ausente.Size = new Size(67, 19);
            checkbox_ausente.TabIndex = 4;
            checkbox_ausente.Text = "ausente";
            checkbox_ausente.UseVisualStyleBackColor = true;
            checkbox_ausente.CheckedChanged += checkbox_ausente_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(checkbox_ausente);
            Controls.Add(label_lista);
            Controls.Add(button_imprimir);
            Controls.Add(checkBox_presente);
            Controls.Add(listbox_estudiante);
            Name = "Form1";
            Text = "estudiantes";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listbox_estudiante;
        private CheckBox checkBox_presente;
        private Button button_imprimir;
        private Label label_lista;
        private CheckBox checkbox_ausente;
    }
}
