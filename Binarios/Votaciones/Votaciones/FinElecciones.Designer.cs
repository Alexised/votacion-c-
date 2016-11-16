namespace Votaciones
{
    partial class FinElecciones
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
            this.components = new System.ComponentModel.Container();
            this.dgvXCandidato = new System.Windows.Forms.DataGridView();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadVotosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.candidatosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvXPartido = new System.Windows.Forms.DataGridView();
            this.Partido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadVotos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btXPartido = new System.Windows.Forms.Button();
            this.btXCandidato = new System.Windows.Forms.Button();
            this.btSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXCandidato)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.candidatosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXPartido)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvXCandidato
            // 
            this.dgvXCandidato.AutoGenerateColumns = false;
            this.dgvXCandidato.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvXCandidato.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreDataGridViewTextBoxColumn,
            this.cantidadVotosDataGridViewTextBoxColumn});
            this.dgvXCandidato.DataSource = this.candidatosBindingSource;
            this.dgvXCandidato.Location = new System.Drawing.Point(25, 26);
            this.dgvXCandidato.Name = "dgvXCandidato";
            this.dgvXCandidato.Size = new System.Drawing.Size(256, 248);
            this.dgvXCandidato.TabIndex = 0;
            this.dgvXCandidato.Visible = false;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // cantidadVotosDataGridViewTextBoxColumn
            // 
            this.cantidadVotosDataGridViewTextBoxColumn.DataPropertyName = "CantidadVotos";
            this.cantidadVotosDataGridViewTextBoxColumn.HeaderText = "CantidadVotos";
            this.cantidadVotosDataGridViewTextBoxColumn.Name = "cantidadVotosDataGridViewTextBoxColumn";
            // 
            // dgvXPartido
            // 
            this.dgvXPartido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvXPartido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Partido,
            this.CantidadVotos});
            this.dgvXPartido.Location = new System.Drawing.Point(398, 26);
            this.dgvXPartido.Name = "dgvXPartido";
            this.dgvXPartido.Size = new System.Drawing.Size(266, 199);
            this.dgvXPartido.TabIndex = 1;
            this.dgvXPartido.Visible = false;
            // 
            // Partido
            // 
            this.Partido.HeaderText = "Partido";
            this.Partido.Name = "Partido";
            // 
            // CantidadVotos
            // 
            this.CantidadVotos.HeaderText = "CantidadVotos";
            this.CantidadVotos.Name = "CantidadVotos";
            // 
            // btXPartido
            // 
            this.btXPartido.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXPartido.Location = new System.Drawing.Point(437, 255);
            this.btXPartido.Name = "btXPartido";
            this.btXPartido.Size = new System.Drawing.Size(190, 38);
            this.btXPartido.TabIndex = 2;
            this.btXPartido.Text = "XPartido";
            this.btXPartido.UseVisualStyleBackColor = true;
            this.btXPartido.Click += new System.EventHandler(this.button1_Click);
            // 
            // btXCandidato
            // 
            this.btXCandidato.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXCandidato.Location = new System.Drawing.Point(60, 295);
            this.btXCandidato.Name = "btXCandidato";
            this.btXCandidato.Size = new System.Drawing.Size(180, 38);
            this.btXCandidato.TabIndex = 3;
            this.btXCandidato.Text = "XCandidato";
            this.btXCandidato.UseVisualStyleBackColor = true;
            this.btXCandidato.Click += new System.EventHandler(this.btXCandidato_Click);
            // 
            // btSalir
            // 
            this.btSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalir.Location = new System.Drawing.Point(437, 329);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(125, 34);
            this.btSalir.TabIndex = 4;
            this.btSalir.Text = "Salir";
            this.btSalir.UseVisualStyleBackColor = true;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // FinElecciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 385);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.btXCandidato);
            this.Controls.Add(this.btXPartido);
            this.Controls.Add(this.dgvXPartido);
            this.Controls.Add(this.dgvXCandidato);
            this.Name = "FinElecciones";
            this.Text = "FinElecciones";
            this.Load += new System.EventHandler(this.FinElecciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvXCandidato)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.candidatosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXPartido)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvXCandidato;
        private System.Windows.Forms.BindingSource candidatosBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadVotosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dgvXPartido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Partido;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadVotos;
        private System.Windows.Forms.Button btXPartido;
        private System.Windows.Forms.Button btXCandidato;
        private System.Windows.Forms.Button btSalir;
    }
}