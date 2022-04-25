namespace Conversor_VML_OBJ
{
    partial class frmConversaoVMLOBJ
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
            this.ofdArquivoAbrir = new System.Windows.Forms.OpenFileDialog();
            this.btnAbrirArquivo = new System.Windows.Forms.Button();
            this.sfdArquivoSalvar = new System.Windows.Forms.SaveFileDialog();
            this.btnSalvarArquivo = new System.Windows.Forms.Button();
            this.chkCabecalhoObj = new System.Windows.Forms.CheckBox();
            this.chkMesmaLinha = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // ofdArquivoAbrir
            // 
            this.ofdArquivoAbrir.DefaultExt = "VML (*.vml)";
            this.ofdArquivoAbrir.Filter = "VML|*.vml";
            // 
            // btnAbrirArquivo
            // 
            this.btnAbrirArquivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrirArquivo.Location = new System.Drawing.Point(12, 58);
            this.btnAbrirArquivo.Name = "btnAbrirArquivo";
            this.btnAbrirArquivo.Size = new System.Drawing.Size(270, 64);
            this.btnAbrirArquivo.TabIndex = 0;
            this.btnAbrirArquivo.Text = "Abrir e converter arquivo VML";
            this.btnAbrirArquivo.UseVisualStyleBackColor = true;
            this.btnAbrirArquivo.Click += new System.EventHandler(this.btnAbrirArquivo_Click);
            // 
            // sfdArquivoSalvar
            // 
            this.sfdArquivoSalvar.DefaultExt = "OBJ (*.obj)";
            this.sfdArquivoSalvar.Filter = "OBJ|*.obj";
            // 
            // btnSalvarArquivo
            // 
            this.btnSalvarArquivo.Enabled = false;
            this.btnSalvarArquivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarArquivo.Location = new System.Drawing.Point(12, 128);
            this.btnSalvarArquivo.Name = "btnSalvarArquivo";
            this.btnSalvarArquivo.Size = new System.Drawing.Size(270, 64);
            this.btnSalvarArquivo.TabIndex = 1;
            this.btnSalvarArquivo.Text = "Salvar arquivo OBJ";
            this.btnSalvarArquivo.UseVisualStyleBackColor = true;
            this.btnSalvarArquivo.Click += new System.EventHandler(this.btnSalvarArquivo_Click);
            // 
            // chkCabecalhoObj
            // 
            this.chkCabecalhoObj.AutoSize = true;
            this.chkCabecalhoObj.Checked = true;
            this.chkCabecalhoObj.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCabecalhoObj.Location = new System.Drawing.Point(12, 12);
            this.chkCabecalhoObj.Name = "chkCabecalhoObj";
            this.chkCabecalhoObj.Size = new System.Drawing.Size(123, 17);
            this.chkCabecalhoObj.TabIndex = 2;
            this.chkCabecalhoObj.Text = "Com cabeçalho OBJ";
            this.chkCabecalhoObj.UseVisualStyleBackColor = true;
            // 
            // chkMesmaLinha
            // 
            this.chkMesmaLinha.AutoSize = true;
            this.chkMesmaLinha.Location = new System.Drawing.Point(12, 35);
            this.chkMesmaLinha.Name = "chkMesmaLinha";
            this.chkMesmaLinha.Size = new System.Drawing.Size(127, 17);
            this.chkMesmaLinha.TabIndex = 3;
            this.chkMesmaLinha.Text = "Tudo na mesma linha";
            this.chkMesmaLinha.UseVisualStyleBackColor = true;
            // 
            // frmConversaoVMLOBJ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 212);
            this.Controls.Add(this.chkMesmaLinha);
            this.Controls.Add(this.chkCabecalhoObj);
            this.Controls.Add(this.btnSalvarArquivo);
            this.Controls.Add(this.btnAbrirArquivo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmConversaoVMLOBJ";
            this.Text = "Conversor de VML para OBJ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog ofdArquivoAbrir;
        private System.Windows.Forms.Button btnAbrirArquivo;
        private System.Windows.Forms.SaveFileDialog sfdArquivoSalvar;
        private System.Windows.Forms.Button btnSalvarArquivo;
        private System.Windows.Forms.CheckBox chkCabecalhoObj;
        private System.Windows.Forms.CheckBox chkMesmaLinha;
    }
}

