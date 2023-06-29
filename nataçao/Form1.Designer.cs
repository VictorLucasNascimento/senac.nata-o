namespace nataçao
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
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtProfessor = new TextBox();
            txtAula = new TextBox();
            txtNome = new TextBox();
            txtOlaSejaBemVido = new Label();
            btnCadastrar = new Button();
            txtMarcaçaoDeAula = new DateTimePicker();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 113);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 0;
            label2.Text = "Professor";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 183);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 1;
            label1.Text = "Nome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(389, 113);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 2;
            label3.Text = "Aula";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(389, 183);
            label4.Name = "label4";
            label4.Size = new Size(103, 15);
            label4.TabIndex = 3;
            label4.Text = "Marcação De Aula";
            // 
            // txtProfessor
            // 
            txtProfessor.Location = new Point(28, 144);
            txtProfessor.Name = "txtProfessor";
            txtProfessor.Size = new Size(231, 23);
            txtProfessor.TabIndex = 4;
            // 
            // txtAula
            // 
            txtAula.Location = new Point(389, 144);
            txtAula.Name = "txtAula";
            txtAula.Size = new Size(200, 23);
            txtAula.TabIndex = 5;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(28, 215);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(231, 23);
            txtNome.TabIndex = 6;
            // 
            // txtOlaSejaBemVido
            // 
            txtOlaSejaBemVido.AutoSize = true;
            txtOlaSejaBemVido.Font = new Font("Tempus Sans ITC", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            txtOlaSejaBemVido.Location = new Point(297, 41);
            txtOlaSejaBemVido.Name = "txtOlaSejaBemVido";
            txtOlaSejaBemVido.Size = new Size(158, 20);
            txtOlaSejaBemVido.TabIndex = 8;
            txtOlaSejaBemVido.Text = "Olá,Seja Bem Vindo";
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(659, 349);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(72, 28);
            btnCadastrar.TabIndex = 9;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // txtMarcaçaoDeAula
            // 
            txtMarcaçaoDeAula.Location = new Point(389, 215);
            txtMarcaçaoDeAula.Name = "txtMarcaçaoDeAula";
            txtMarcaçaoDeAula.Size = new Size(200, 23);
            txtMarcaçaoDeAula.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtMarcaçaoDeAula);
            Controls.Add(btnCadastrar);
            Controls.Add(txtOlaSejaBemVido);
            Controls.Add(txtNome);
            Controls.Add(txtAula);
            Controls.Add(txtProfessor);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private TextBox txtProfessor;
        private TextBox txtAula;
        private TextBox txtNome;
        private TextBox ll;
        private Label txtOlaSejaBemVido;
        private Button btnCadastrar;
        private DateTimePicker txtMarcaçaoDeAula;
    }
}