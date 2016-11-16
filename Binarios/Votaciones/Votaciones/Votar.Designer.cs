namespace Votaciones
{
    partial class Votar
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CantidadVotos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btVotar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txNumero = new System.Windows.Forms.TextBox();
            this.btSalir = new System.Windows.Forms.Button();
            this.bDCandidatosDataSet = new Votaciones.BDCandidatosDataSet();
            this.candidatosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.candidatosTableAdapter = new Votaciones.BDCandidatosDataSetTableAdapters.CandidatosTableAdapter();
            this.numeroTargetonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadVotosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDCandidatosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.candidatosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CantidadVotos,
            this.numeroTargetonDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.cantidadVotosDataGridViewTextBoxColumn,
            this.partidoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.candidatosBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(37, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(453, 227);
            this.dataGridView1.TabIndex = 0;
            // 
            // CantidadVotos
            // 
            this.CantidadVotos.DataPropertyName = "CantidadVotos";
            this.CantidadVotos.HeaderText = "CantidadVotos";
            this.CantidadVotos.Name = "CantidadVotos";
            // 
            // btVotar
            // 
            this.btVotar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVotar.Location = new System.Drawing.Point(210, 325);
            this.btVotar.Name = "btVotar";
            this.btVotar.Size = new System.Drawing.Size(106, 44);
            this.btVotar.TabIndex = 1;
            this.btVotar.Text = "Votar";
            this.btVotar.UseVisualStyleBackColor = true;
            this.btVotar.Click += new System.EventHandler(this.btVotar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 279);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(354, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Digite El Numero Del Targenton Para Votar";
            // 
            // txNumero
            // 
            this.txNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txNumero.Location = new System.Drawing.Point(393, 273);
            this.txNumero.Name = "txNumero";
            this.txNumero.Size = new System.Drawing.Size(100, 29);
            this.txNumero.TabIndex = 3;
            // 
            // btSalir
            // 
            this.btSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalir.Location = new System.Drawing.Point(393, 332);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(106, 31);
            this.btSalir.TabIndex = 5;
            this.btSalir.Text = "Salir";
            this.btSalir.UseVisualStyleBackColor = true;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // bDCandidatosDataSet
            // 
            this.bDCandidatosDataSet.DataSetName = "BDCandidatosDataSet";
            this.bDCandidatosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // candidatosBindingSource
            // 
            this.candidatosBindingSource.DataMember = "Candidatos";
            this.candidatosBindingSource.DataSource = this.bDCandidatosDataSet;
            // 
            // candidatosTableAdapter
            // 
            this.candidatosTableAdapter.ClearBeforeFill = true;
            // 
            // numeroTargetonDataGridViewTextBoxColumn
            // 
            this.numeroTargetonDataGridViewTextBoxColumn.DataPropertyName = "NumeroTargeton";
            this.numeroTargetonDataGridViewTextBoxColumn.HeaderText = "NumeroTargeton";
            this.numeroTargetonDataGridViewTextBoxColumn.Name = "numeroTargetonDataGridViewTextBoxColumn";
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
            // partidoDataGridViewTextBoxColumn
            // 
            this.partidoDataGridViewTextBoxColumn.DataPropertyName = "Partido";
            this.partidoDataGridViewTextBoxColumn.HeaderText = "Partido";
            this.partidoDataGridViewTextBoxColumn.Name = "partidoDataGridViewTextBoxColumn";
            // 
            // Votar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 391);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.txNumero);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btVotar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Votar";
            this.Text = "Votar";
            this.Load += new System.EventHandler(this.Votar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDCandidatosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.candidatosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btVotar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadVotos;
        private System.Windows.Forms.Button btSalir;
        private BDCandidatosDataSet bDCandidatosDataSet;
        private System.Windows.Forms.BindingSource candidatosBindingSource;
        private BDCandidatosDataSetTableAdapters.CandidatosTableAdapter candidatosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroTargetonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadVotosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partidoDataGridViewTextBoxColumn;
    }
}