using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_MVC
{
    public partial class Form1 : Form
    {
        private Escola escola = new Escola();
        private ComboBox optionsComboBox;
        private Button executeButton;

        public Form1()
        {
            optionsComboBox = new ComboBox();
            optionsComboBox.Items.AddRange(new object[]
            {
            "0. Sair",
            "1. Adicionar curso",
            "2. Pesquisar curso",
            "3. Remover curso",
            "4. Adicionar disciplina no curso",
            "5. Pesquisar disciplina",
            "6. Remover disciplina do curso",
            "7. Matricular aluno na disciplina",
            "8. Remover aluno da disciplina",
            "9. Pesquisar aluno"
            });
            optionsComboBox.SelectedIndex = 0;

            executeButton = new Button { Text = "Executar" };
            executeButton.Click += ExecuteButton_Click;

            Controls.Add(optionsComboBox);
            Controls.Add(executeButton);
        }

        private void ExecuteButton_Click(object sender, EventArgs e)
        {
            switch (optionsComboBox.SelectedIndex)
            {
                case 0:
                    Close();
                    break;
                case 1:
                    // Lógica para adicionar curso
                    break;
                case 2:
                    // Lógica para pesquisar curso
                    break;
                case 3:
                    // Lógica para remover curso
                    break;
                case 4:
                    // Lógica para adicionar disciplina
                    break;
                case 5:
                    // Lógica para pesquisar disciplina
                    break;
                case 6:
                    // Lógica para remover disciplina
                    break;
                case 7:
                    // Lógica para matricular aluno
                    break;
                case 8:
                    // Lógica para remover aluno
                    break;
                case 9:
                    // Lógica para pesquisar aluno
                    break;
            }
        }

        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Sair";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(109, 101);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome do Curso";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(215, 101);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Pesquisar Curso";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(25, 136);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nome da Disciplina";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(109, 254);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 6;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(215, 252);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(174, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Pesquisar Disciplina do Curso";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(26, 301);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(166, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "Remover Disciplina do Curso";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(25, 350);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(120, 95);
            this.listBox2.TabIndex = 9;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(26, 463);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(120, 23);
            this.button5.TabIndex = 10;
            this.button5.Text = "Remover Aluno";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(215, 507);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(131, 23);
            this.button6.TabIndex = 11;
            this.button6.Text = "Pesquisar Aluno";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(109, 509);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 513);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Nome do Aluno";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(919, 583);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Button button1;
        private TextBox textBox1;

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private Label label1;
        private Button button2;
        private ListBox listBox1;
        private Label label2;
        private TextBox textBox2;
        private Button button3;
        private Button button4;
        private ListBox listBox2;
        private Button button5;
        private Button button6;
        private TextBox textBox3;
        private Label label3;

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string texto = textBox1.Text;
            label1.Text = texto;
        }
    }
}
