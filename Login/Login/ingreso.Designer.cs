﻿namespace Login
{
    partial class ingreso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ingreso));
            this.Username_Text_Box = new System.Windows.Forms.TextBox();
            this.Label_Username = new System.Windows.Forms.Label();
            this.Label_Password = new System.Windows.Forms.Label();
            this.Password_TextBox = new System.Windows.Forms.TextBox();
            this.BtnIngresar = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // Username_Text_Box
            // 
            this.Username_Text_Box.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.Username_Text_Box.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Username_Text_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username_Text_Box.Location = new System.Drawing.Point(182, 76);
            this.Username_Text_Box.Name = "Username_Text_Box";
            this.Username_Text_Box.Size = new System.Drawing.Size(582, 29);
            this.Username_Text_Box.TabIndex = 0;
            this.Username_Text_Box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Password_TextBox_KeyPress);
            // 
            // Label_Username
            // 
            this.Label_Username.AutoSize = true;
            this.Label_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Username.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Label_Username.Location = new System.Drawing.Point(48, 76);
            this.Label_Username.Name = "Label_Username";
            this.Label_Username.Size = new System.Drawing.Size(102, 24);
            this.Label_Username.TabIndex = 1;
            this.Label_Username.Text = "Username:";
            // 
            // Label_Password
            // 
            this.Label_Password.AutoSize = true;
            this.Label_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Password.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Label_Password.Location = new System.Drawing.Point(48, 180);
            this.Label_Password.Name = "Label_Password";
            this.Label_Password.Size = new System.Drawing.Size(97, 24);
            this.Label_Password.TabIndex = 2;
            this.Label_Password.Text = "Password:";
            // 
            // Password_TextBox
            // 
            this.Password_TextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.Password_TextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Password_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_TextBox.Location = new System.Drawing.Point(182, 180);
            this.Password_TextBox.Name = "Password_TextBox";
            this.Password_TextBox.Size = new System.Drawing.Size(582, 29);
            this.Password_TextBox.TabIndex = 3;
            this.Password_TextBox.UseSystemPasswordChar = true;
            this.Password_TextBox.TextChanged += new System.EventHandler(this.Password_TextBox_TextChanged);
            this.Password_TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Password_TextBox_KeyPress);
            // 
            // BtnIngresar
            // 
            this.BtnIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIngresar.Location = new System.Drawing.Point(639, 296);
            this.BtnIngresar.Name = "BtnIngresar";
            this.BtnIngresar.Size = new System.Drawing.Size(105, 34);
            this.BtnIngresar.TabIndex = 4;
            this.BtnIngresar.Text = "Ingresar";
            this.BtnIngresar.UseVisualStyleBackColor = true;
            this.BtnIngresar.Click += new System.EventHandler(this.BtnIngresar_Click);
            this.BtnIngresar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BtnIngresar_KeyPress);
            // 
            // BtnSalir
            // 
            this.BtnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.Location = new System.Drawing.Point(207, 296);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(105, 34);
            this.BtnSalir.TabIndex = 5;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(179, 234);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(131, 13);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "¿Olvidaste tu contraseña?";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // ingreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(11)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnIngresar);
            this.Controls.Add(this.Password_TextBox);
            this.Controls.Add(this.Label_Password);
            this.Controls.Add(this.Label_Username);
            this.Controls.Add(this.Username_Text_Box);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ingreso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingreso";
            this.Load += new System.EventHandler(this.ingreso_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Username_Text_Box;
        private System.Windows.Forms.Label Label_Username;
        private System.Windows.Forms.Label Label_Password;
        private System.Windows.Forms.TextBox Password_TextBox;
        private System.Windows.Forms.Button BtnIngresar;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}