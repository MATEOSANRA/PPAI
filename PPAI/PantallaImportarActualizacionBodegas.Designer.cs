namespace PPAI
{
    partial class PantallaImportarActualizacionBodegas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            checkedListBox1 = new CheckedListBox();
            btnActualizar = new Button();
            label1 = new Label();
            lblBienvenida = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(274, 29);
            button1.Name = "button1";
            button1.Size = new Size(195, 43);
            button1.TabIndex = 0;
            button1.Text = "Importar actualización";
            button1.UseVisualStyleBackColor = true;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(189, 78);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(369, 274);
            checkedListBox1.TabIndex = 2;
            checkedListBox1.SelectedIndexChanged += checkedListBox1_SelectedIndexChanged;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(575, 299);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(88, 53);
            btnActualizar.TabIndex = 3;
            btnActualizar.Text = "ACTUALIZAR";
            btnActualizar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 78);
            label1.Name = "label1";
            label1.Size = new Size(177, 15);
            label1.TabIndex = 4;
            label1.Text = "Seleccione los vinos a actualizar:";
            // 
            // lblBienvenida
            // 
            lblBienvenida.AutoSize = true;
            lblBienvenida.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblBienvenida.ForeColor = Color.IndianRed;
            lblBienvenida.Location = new Point(12, 397);
            lblBienvenida.Name = "lblBienvenida";
            lblBienvenida.Size = new Size(96, 37);
            lblBienvenida.TabIndex = 5;
            lblBienvenida.Text = "label2";
            // 
            // PantallaImportarActualizacionBodegas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(758, 443);
            Controls.Add(lblBienvenida);
            Controls.Add(label1);
            Controls.Add(btnActualizar);
            Controls.Add(checkedListBox1);
            Controls.Add(button1);
            MaximizeBox = false;
            Name = "PantallaImportarActualizacionBodegas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Importar actualización vinos de bodega";
            Load += PantallaImportarActualizacionBodegas_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private CheckedListBox checkedListBox1;
        private Button btnActualizar;
        private Label label1;
        private Label lblBienvenida;
    }
}