namespace WinFormsExercicio_1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_Produto = new System.Windows.Forms.TextBox();
            this.textBox_Quantidade = new System.Windows.Forms.TextBox();
            this.textBox_PrecoUnitario = new System.Windows.Forms.TextBox();
            this.textBox_SubTotal = new System.Windows.Forms.TextBox();
            this.button_AdicionarProduto = new System.Windows.Forms.Button();
            this.button_CancelarVenda = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.richTextBox_SubTotal = new System.Windows.Forms.RichTextBox();
            this.richTextBox_precoUnitario = new System.Windows.Forms.RichTextBox();
            this.richTextBox_Quantidade = new System.Windows.Forms.RichTextBox();
            this.richTextBox_Produto = new System.Windows.Forms.RichTextBox();
            this.button_RemoverProduto = new System.Windows.Forms.Button();
            this.button_FecharVenda = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_Total = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Produto:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(229, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Quantidade:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(380, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Preço Unitário:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(529, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Sub Total:";
            // 
            // textBox_Produto
            // 
            this.textBox_Produto.Location = new System.Drawing.Point(79, 87);
            this.textBox_Produto.Name = "textBox_Produto";
            this.textBox_Produto.Size = new System.Drawing.Size(125, 27);
            this.textBox_Produto.TabIndex = 4;
            // 
            // textBox_Quantidade
            // 
            this.textBox_Quantidade.Location = new System.Drawing.Point(229, 87);
            this.textBox_Quantidade.Name = "textBox_Quantidade";
            this.textBox_Quantidade.Size = new System.Drawing.Size(125, 27);
            this.textBox_Quantidade.TabIndex = 5;
            this.textBox_Quantidade.TextChanged += new System.EventHandler(this.textBox_Quantidade_TextChanged);
            this.textBox_Quantidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Quantidade_KeyPress);
            // 
            // textBox_PrecoUnitario
            // 
            this.textBox_PrecoUnitario.Location = new System.Drawing.Point(380, 87);
            this.textBox_PrecoUnitario.Name = "textBox_PrecoUnitario";
            this.textBox_PrecoUnitario.Size = new System.Drawing.Size(125, 27);
            this.textBox_PrecoUnitario.TabIndex = 6;
            this.textBox_PrecoUnitario.TextChanged += new System.EventHandler(this.textBox_PrecoUnitario_TextChanged);
            this.textBox_PrecoUnitario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_PrecoUnitario_KeyPress);
            // 
            // textBox_SubTotal
            // 
            this.textBox_SubTotal.Enabled = false;
            this.textBox_SubTotal.Location = new System.Drawing.Point(529, 87);
            this.textBox_SubTotal.Name = "textBox_SubTotal";
            this.textBox_SubTotal.ReadOnly = true;
            this.textBox_SubTotal.Size = new System.Drawing.Size(125, 27);
            this.textBox_SubTotal.TabIndex = 7;
            // 
            // button_AdicionarProduto
            // 
            this.button_AdicionarProduto.Location = new System.Drawing.Point(79, 131);
            this.button_AdicionarProduto.Name = "button_AdicionarProduto";
            this.button_AdicionarProduto.Size = new System.Drawing.Size(275, 29);
            this.button_AdicionarProduto.TabIndex = 8;
            this.button_AdicionarProduto.Text = "Adicionar Produto na Lista";
            this.button_AdicionarProduto.UseVisualStyleBackColor = true;
            this.button_AdicionarProduto.Click += new System.EventHandler(this.button_AdicionarProduto_Click);
            // 
            // button_CancelarVenda
            // 
            this.button_CancelarVenda.Location = new System.Drawing.Point(529, 131);
            this.button_CancelarVenda.Name = "button_CancelarVenda";
            this.button_CancelarVenda.Size = new System.Drawing.Size(125, 29);
            this.button_CancelarVenda.TabIndex = 9;
            this.button_CancelarVenda.Text = "Cancelar Venda";
            this.button_CancelarVenda.UseVisualStyleBackColor = true;
            this.button_CancelarVenda.Click += new System.EventHandler(this.button_CancelarVenda_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(429, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Sub Total";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(286, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Preço Unitário";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(155, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Quantidade";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 20);
            this.label8.TabIndex = 10;
            this.label8.Text = "Produto";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.richTextBox_SubTotal);
            this.groupBox1.Controls.Add(this.richTextBox_precoUnitario);
            this.groupBox1.Controls.Add(this.richTextBox_Quantidade);
            this.groupBox1.Controls.Add(this.richTextBox_Produto);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(79, 177);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(575, 239);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista";
            // 
            // richTextBox_SubTotal
            // 
            this.richTextBox_SubTotal.Location = new System.Drawing.Point(429, 64);
            this.richTextBox_SubTotal.Name = "richTextBox_SubTotal";
            this.richTextBox_SubTotal.ReadOnly = true;
            this.richTextBox_SubTotal.Size = new System.Drawing.Size(125, 156);
            this.richTextBox_SubTotal.TabIndex = 17;
            this.richTextBox_SubTotal.Text = "";
            // 
            // richTextBox_precoUnitario
            // 
            this.richTextBox_precoUnitario.Location = new System.Drawing.Point(286, 64);
            this.richTextBox_precoUnitario.Name = "richTextBox_precoUnitario";
            this.richTextBox_precoUnitario.ReadOnly = true;
            this.richTextBox_precoUnitario.Size = new System.Drawing.Size(125, 156);
            this.richTextBox_precoUnitario.TabIndex = 16;
            this.richTextBox_precoUnitario.Text = "";
            // 
            // richTextBox_Quantidade
            // 
            this.richTextBox_Quantidade.Location = new System.Drawing.Point(155, 64);
            this.richTextBox_Quantidade.Name = "richTextBox_Quantidade";
            this.richTextBox_Quantidade.ReadOnly = true;
            this.richTextBox_Quantidade.Size = new System.Drawing.Size(125, 156);
            this.richTextBox_Quantidade.TabIndex = 15;
            this.richTextBox_Quantidade.Text = "";
            // 
            // richTextBox_Produto
            // 
            this.richTextBox_Produto.Location = new System.Drawing.Point(24, 64);
            this.richTextBox_Produto.Name = "richTextBox_Produto";
            this.richTextBox_Produto.ReadOnly = true;
            this.richTextBox_Produto.Size = new System.Drawing.Size(125, 156);
            this.richTextBox_Produto.TabIndex = 14;
            this.richTextBox_Produto.Text = "";
            // 
            // button_RemoverProduto
            // 
            this.button_RemoverProduto.Location = new System.Drawing.Point(79, 422);
            this.button_RemoverProduto.Name = "button_RemoverProduto";
            this.button_RemoverProduto.Size = new System.Drawing.Size(575, 29);
            this.button_RemoverProduto.TabIndex = 15;
            this.button_RemoverProduto.Text = "Remover um produto da lista de compras";
            this.button_RemoverProduto.UseVisualStyleBackColor = true;
            this.button_RemoverProduto.Click += new System.EventHandler(this.button_RemoverProduto_Click);
            // 
            // button_FecharVenda
            // 
            this.button_FecharVenda.Location = new System.Drawing.Point(79, 457);
            this.button_FecharVenda.Name = "button_FecharVenda";
            this.button_FecharVenda.Size = new System.Drawing.Size(134, 29);
            this.button_FecharVenda.TabIndex = 16;
            this.button_FecharVenda.Text = "Fechar Venda";
            this.button_FecharVenda.UseVisualStyleBackColor = true;
            this.button_FecharVenda.Click += new System.EventHandler(this.button_FecharVenda_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(388, 466);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "Total a Pagar: ";
            // 
            // textBox_Total
            // 
            this.textBox_Total.Location = new System.Drawing.Point(508, 459);
            this.textBox_Total.Name = "textBox_Total";
            this.textBox_Total.ReadOnly = true;
            this.textBox_Total.Size = new System.Drawing.Size(146, 27);
            this.textBox_Total.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 518);
            this.Controls.Add(this.textBox_Total);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button_FecharVenda);
            this.Controls.Add(this.button_RemoverProduto);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_CancelarVenda);
            this.Controls.Add(this.button_AdicionarProduto);
            this.Controls.Add(this.textBox_SubTotal);
            this.Controls.Add(this.textBox_PrecoUnitario);
            this.Controls.Add(this.textBox_Quantidade);
            this.Controls.Add(this.textBox_Produto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox_Produto;
        private TextBox textBox_Quantidade;
        private TextBox textBox_PrecoUnitario;
        private TextBox textBox_SubTotal;
        private Button button_AdicionarProduto;
        private Button button_CancelarVenda;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private GroupBox groupBox1;
        private RichTextBox richTextBox_SubTotal;
        private RichTextBox richTextBox_precoUnitario;
        private RichTextBox richTextBox_Quantidade;
        private RichTextBox richTextBox_Produto;
        private Button button_RemoverProduto;
        private Button button_FecharVenda;
        private Label label9;
        private TextBox textBox_Total;
    }
}