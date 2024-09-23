namespace WinFormsApp1
{
    partial class Consulta
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
            components = new System.ComponentModel.Container();
            textBox1 = new TextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            toolStripComboBox1 = new ToolStripComboBox();
            lblId = new Label();
            lblNome = new Label();
            lblanimal = new Label();
            lblRaca = new Label();
            lblDataNascimento = new Label();
            lblPeso = new Label();
            lblTelefone = new Label();
            label1 = new Label();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 298);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(346, 140);
            textBox1.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { toolStripComboBox1 });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(182, 31);
            // 
            // toolStripComboBox1
            // 
            toolStripComboBox1.Name = "toolStripComboBox1";
            toolStripComboBox1.Size = new Size(121, 23);
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Segoe UI", 11F);
            lblId.Location = new Point(2, 42);
            lblId.Name = "lblId";
            lblId.Size = new Size(50, 20);
            lblId.TabIndex = 1;
            lblId.Text = "label1";
            lblId.Click += label1_Click;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 11F);
            lblNome.Location = new Point(49, 42);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(50, 20);
            lblNome.TabIndex = 2;
            lblNome.Text = "label1";
            // 
            // lblanimal
            // 
            lblanimal.AutoSize = true;
            lblanimal.Font = new Font("Segoe UI", 11F);
            lblanimal.Location = new Point(139, 42);
            lblanimal.Name = "lblanimal";
            lblanimal.Size = new Size(50, 20);
            lblanimal.TabIndex = 3;
            lblanimal.Text = "label1";
            lblanimal.Click += label1_Click_1;
            // 
            // lblRaca
            // 
            lblRaca.AutoSize = true;
            lblRaca.Font = new Font("Segoe UI", 11F);
            lblRaca.Location = new Point(250, 42);
            lblRaca.Name = "lblRaca";
            lblRaca.Size = new Size(50, 20);
            lblRaca.TabIndex = 4;
            lblRaca.Text = "label1";
            // 
            // lblDataNascimento
            // 
            lblDataNascimento.AutoSize = true;
            lblDataNascimento.Font = new Font("Segoe UI", 11F);
            lblDataNascimento.Location = new Point(350, 42);
            lblDataNascimento.Name = "lblDataNascimento";
            lblDataNascimento.Size = new Size(50, 20);
            lblDataNascimento.TabIndex = 5;
            lblDataNascimento.Text = "label1";
            lblDataNascimento.Click += lblDataNascimento_Click;
            // 
            // lblPeso
            // 
            lblPeso.AutoSize = true;
            lblPeso.Font = new Font("Segoe UI", 11F);
            lblPeso.Location = new Point(477, 42);
            lblPeso.Name = "lblPeso";
            lblPeso.Size = new Size(50, 20);
            lblPeso.TabIndex = 6;
            lblPeso.Text = "label2";
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Font = new Font("Segoe UI", 11F);
            lblTelefone.Location = new Point(578, 42);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(50, 20);
            lblTelefone.TabIndex = 7;
            lblTelefone.Text = "label3";
            lblTelefone.Click += label3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(12, 275);
            label1.Name = "label1";
            label1.Size = new Size(151, 20);
            label1.TabIndex = 8;
            label1.Text = "Descreva os sintomas";
            label1.Click += label1_Click_2;
            // 
            // Consulta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(lblTelefone);
            Controls.Add(lblPeso);
            Controls.Add(lblDataNascimento);
            Controls.Add(lblRaca);
            Controls.Add(lblanimal);
            Controls.Add(lblNome);
            Controls.Add(lblId);
            Controls.Add(textBox1);
            Name = "Consulta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Consulta";
            Load += Consulta_Load;
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripComboBox toolStripComboBox1;
        private Label lblId;
        private Label lblNome;
        private Label lblanimal;
        private Label lblRaca;
        private Label lblDataNascimento;
        private Label lblPeso;
        private Label lblTelefone;
        private Label label1;
    }
}