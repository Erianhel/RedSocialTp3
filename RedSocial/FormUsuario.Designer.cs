﻿namespace RedSocial
{
    partial class FormUsuario
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
            this.textBox_MailReg = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_DNIReg = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_apellidoRegistro = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_NombreReg = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonModificar = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxBloqueado = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // textBox_MailReg
            // 
            this.textBox_MailReg.Location = new System.Drawing.Point(215, 170);
            this.textBox_MailReg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_MailReg.Name = "textBox_MailReg";
            this.textBox_MailReg.Size = new System.Drawing.Size(110, 23);
            this.textBox_MailReg.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(130, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 15);
            this.label7.TabIndex = 23;
            this.label7.Text = "Mail";
            // 
            // textBox_DNIReg
            // 
            this.textBox_DNIReg.Location = new System.Drawing.Point(215, 146);
            this.textBox_DNIReg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_DNIReg.Name = "textBox_DNIReg";
            this.textBox_DNIReg.Size = new System.Drawing.Size(110, 23);
            this.textBox_DNIReg.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(130, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 15);
            this.label6.TabIndex = 21;
            this.label6.Text = "DNI";
            // 
            // textBox_apellidoRegistro
            // 
            this.textBox_apellidoRegistro.Location = new System.Drawing.Point(215, 121);
            this.textBox_apellidoRegistro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_apellidoRegistro.Name = "textBox_apellidoRegistro";
            this.textBox_apellidoRegistro.Size = new System.Drawing.Size(110, 23);
            this.textBox_apellidoRegistro.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(130, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 15);
            this.label5.TabIndex = 19;
            this.label5.Text = "Apellido";
            // 
            // textBox_NombreReg
            // 
            this.textBox_NombreReg.Location = new System.Drawing.Point(215, 96);
            this.textBox_NombreReg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_NombreReg.Name = "textBox_NombreReg";
            this.textBox_NombreReg.Size = new System.Drawing.Size(110, 23);
            this.textBox_NombreReg.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(130, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 17;
            this.label4.Text = "Nombre";
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(21, 298);
            this.buttonCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(82, 22);
            this.buttonCancelar.TabIndex = 27;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonModificar
            // 
            this.buttonModificar.Location = new System.Drawing.Point(410, 254);
            this.buttonModificar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.Size = new System.Drawing.Size(82, 22);
            this.buttonModificar.TabIndex = 28;
            this.buttonModificar.Text = "Modificar";
            this.buttonModificar.UseVisualStyleBackColor = true;
            this.buttonModificar.Click += new System.EventHandler(this.buttonModificar_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Location = new System.Drawing.Point(533, 254);
            this.buttonEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(82, 22);
            this.buttonEliminar.TabIndex = 29;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(24, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 32);
            this.label1.TabIndex = 30;
            this.label1.Text = "Administrador de Usuario";
            // 
            // checkBoxBloqueado
            // 
            this.checkBoxBloqueado.AutoSize = true;
            this.checkBoxBloqueado.Location = new System.Drawing.Point(417, 98);
            this.checkBoxBloqueado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxBloqueado.Name = "checkBoxBloqueado";
            this.checkBoxBloqueado.Size = new System.Drawing.Size(107, 19);
            this.checkBoxBloqueado.TabIndex = 31;
            this.checkBoxBloqueado.Text = "Esta Bloqueado";
            this.checkBoxBloqueado.UseVisualStyleBackColor = true;
            // 
            // FormUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 338);
            this.Controls.Add(this.checkBoxBloqueado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonModificar);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.textBox_MailReg);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox_DNIReg);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_apellidoRegistro);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_NombreReg);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormUsuario";
            this.Load += new System.EventHandler(this.FormUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox_MailReg;
        private Label label7;
        private TextBox textBox_DNIReg;
        private Label label6;
        private TextBox textBox_apellidoRegistro;
        private Label label5;
        private TextBox textBox_NombreReg;
        private Label label4;
        private Button buttonCancelar;
        private Button buttonModificar;
        private Button buttonEliminar;
        private Label label1;
        private CheckBox checkBoxBloqueado;
    }
}