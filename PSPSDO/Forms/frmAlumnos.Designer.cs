﻿namespace PSPSDO.Forms
{
    partial class frmAlumnos
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
            this.btnActualiAlumnos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnActualiAlumnos
            // 
            this.btnActualiAlumnos.Location = new System.Drawing.Point(446, 110);
            this.btnActualiAlumnos.Name = "btnActualiAlumnos";
            this.btnActualiAlumnos.Size = new System.Drawing.Size(75, 23);
            this.btnActualiAlumnos.TabIndex = 0;
            this.btnActualiAlumnos.Text = "Actualizar";
            this.btnActualiAlumnos.UseVisualStyleBackColor = true;
            // 
            // frmAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnActualiAlumnos);
            this.Name = "frmAlumnos";
            this.Text = "frmAlumnos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnActualiAlumnos;
    }
}