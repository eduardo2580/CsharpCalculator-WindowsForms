namespace CalculadoraSimples
{
    partial class CalculadoraSimples
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnSeven = new System.Windows.Forms.Button();
            this.btnEight = new System.Windows.Forms.Button();
            this.btnNine = new System.Windows.Forms.Button();
            this.btnFour = new System.Windows.Forms.Button();
            this.btnFive = new System.Windows.Forms.Button();
            this.btnSix = new System.Windows.Forms.Button();
            this.btnMulti = new System.Windows.Forms.Button();
            this.btnOne = new System.Windows.Forms.Button();
            this.btnTwo = new System.Windows.Forms.Button();
            this.btnThree = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btnZero = new System.Windows.Forms.Button();
            this.btnEquals = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.txtDisplay, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(616, 885);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // txtDisplay
            // 
            this.txtDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisplay.Location = new System.Drawing.Point(6, 6);
            this.txtDisplay.Margin = new System.Windows.Forms.Padding(6);
            this.txtDisplay.Multiline = true;
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.ReadOnly = true;
            this.txtDisplay.Size = new System.Drawing.Size(604, 165);
            this.txtDisplay.TabIndex = 0;
            this.txtDisplay.TextChanged += new System.EventHandler(this.txtDisplay_TextChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.btnClear, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnCopy, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnReset, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnPlus, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnSeven, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnEight, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnNine, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnFour, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.btnFive, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.btnSix, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.btnMulti, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.btnOne, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.btnTwo, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.btnThree, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.btnDiv, 3, 3);
            this.tableLayoutPanel2.Controls.Add(this.btnZero, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.btnEquals, 3, 4);
            this.tableLayoutPanel2.Controls.Add(this.btnMinus, 3, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 183);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(6);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(604, 696);
            this.tableLayoutPanel2.TabIndex = 1;
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // btnClear
            // 
            this.btnClear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(6, 6);
            this.btnClear.Margin = new System.Windows.Forms.Padding(6);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(139, 127);
            this.btnClear.TabIndex = 0;
            this.btnClear.Text = "Apagar";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopy.Location = new System.Drawing.Point(157, 6);
            this.btnCopy.Margin = new System.Windows.Forms.Padding(6);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(139, 127);
            this.btnCopy.TabIndex = 1;
            this.btnCopy.Text = "Copiar";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnReset
            // 
            this.btnReset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(308, 6);
            this.btnReset.Margin = new System.Windows.Forms.Padding(6);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(139, 127);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Limpar";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlus.Location = new System.Drawing.Point(459, 6);
            this.btnPlus.Margin = new System.Windows.Forms.Padding(6);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(139, 127);
            this.btnPlus.TabIndex = 3;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnSeven
            // 
            this.btnSeven.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSeven.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeven.Location = new System.Drawing.Point(6, 145);
            this.btnSeven.Margin = new System.Windows.Forms.Padding(6);
            this.btnSeven.Name = "btnSeven";
            this.btnSeven.Size = new System.Drawing.Size(139, 127);
            this.btnSeven.TabIndex = 4;
            this.btnSeven.Text = "7";
            this.btnSeven.UseVisualStyleBackColor = true;
            this.btnSeven.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btnEight
            // 
            this.btnEight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEight.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEight.Location = new System.Drawing.Point(157, 145);
            this.btnEight.Margin = new System.Windows.Forms.Padding(6);
            this.btnEight.Name = "btnEight";
            this.btnEight.Size = new System.Drawing.Size(139, 127);
            this.btnEight.TabIndex = 5;
            this.btnEight.Text = "8";
            this.btnEight.UseVisualStyleBackColor = true;
            this.btnEight.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btnNine
            // 
            this.btnNine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNine.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNine.Location = new System.Drawing.Point(308, 145);
            this.btnNine.Margin = new System.Windows.Forms.Padding(6);
            this.btnNine.Name = "btnNine";
            this.btnNine.Size = new System.Drawing.Size(139, 127);
            this.btnNine.TabIndex = 6;
            this.btnNine.Text = "9";
            this.btnNine.UseVisualStyleBackColor = true;
            this.btnNine.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btnFour
            // 
            this.btnFour.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFour.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFour.Location = new System.Drawing.Point(6, 284);
            this.btnFour.Margin = new System.Windows.Forms.Padding(6);
            this.btnFour.Name = "btnFour";
            this.btnFour.Size = new System.Drawing.Size(139, 127);
            this.btnFour.TabIndex = 8;
            this.btnFour.Text = "4";
            this.btnFour.UseVisualStyleBackColor = true;
            this.btnFour.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btnFive
            // 
            this.btnFive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFive.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFive.Location = new System.Drawing.Point(157, 284);
            this.btnFive.Margin = new System.Windows.Forms.Padding(6);
            this.btnFive.Name = "btnFive";
            this.btnFive.Size = new System.Drawing.Size(139, 127);
            this.btnFive.TabIndex = 9;
            this.btnFive.Text = "5";
            this.btnFive.UseVisualStyleBackColor = true;
            this.btnFive.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btnSix
            // 
            this.btnSix.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSix.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSix.Location = new System.Drawing.Point(308, 284);
            this.btnSix.Margin = new System.Windows.Forms.Padding(6);
            this.btnSix.Name = "btnSix";
            this.btnSix.Size = new System.Drawing.Size(139, 127);
            this.btnSix.TabIndex = 10;
            this.btnSix.Text = "6";
            this.btnSix.UseVisualStyleBackColor = true;
            this.btnSix.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btnMulti
            // 
            this.btnMulti.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMulti.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMulti.Location = new System.Drawing.Point(459, 284);
            this.btnMulti.Margin = new System.Windows.Forms.Padding(6);
            this.btnMulti.Name = "btnMulti";
            this.btnMulti.Size = new System.Drawing.Size(139, 127);
            this.btnMulti.TabIndex = 11;
            this.btnMulti.Text = "*";
            this.btnMulti.UseVisualStyleBackColor = true;
            this.btnMulti.Click += new System.EventHandler(this.btnMulti_Click);
            // 
            // btnOne
            // 
            this.btnOne.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOne.Location = new System.Drawing.Point(6, 423);
            this.btnOne.Margin = new System.Windows.Forms.Padding(6);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(139, 127);
            this.btnOne.TabIndex = 12;
            this.btnOne.Text = "1";
            this.btnOne.UseVisualStyleBackColor = true;
            this.btnOne.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btnTwo
            // 
            this.btnTwo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTwo.Location = new System.Drawing.Point(157, 423);
            this.btnTwo.Margin = new System.Windows.Forms.Padding(6);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.Size = new System.Drawing.Size(139, 127);
            this.btnTwo.TabIndex = 13;
            this.btnTwo.Text = "2";
            this.btnTwo.UseVisualStyleBackColor = true;
            this.btnTwo.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btnThree
            // 
            this.btnThree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnThree.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThree.Location = new System.Drawing.Point(308, 423);
            this.btnThree.Margin = new System.Windows.Forms.Padding(6);
            this.btnThree.Name = "btnThree";
            this.btnThree.Size = new System.Drawing.Size(139, 127);
            this.btnThree.TabIndex = 14;
            this.btnThree.Text = "3";
            this.btnThree.UseVisualStyleBackColor = true;
            this.btnThree.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiv.Location = new System.Drawing.Point(459, 423);
            this.btnDiv.Margin = new System.Windows.Forms.Padding(6);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(139, 127);
            this.btnDiv.TabIndex = 15;
            this.btnDiv.Text = "/";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.btnDiv_Click);
            // 
            // btnZero
            // 
            this.btnZero.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnZero.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZero.Location = new System.Drawing.Point(157, 562);
            this.btnZero.Margin = new System.Windows.Forms.Padding(6);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(139, 128);
            this.btnZero.TabIndex = 17;
            this.btnZero.Text = "0";
            this.btnZero.UseVisualStyleBackColor = true;
            this.btnZero.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btnEquals
            // 
            this.btnEquals.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEquals.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEquals.Location = new System.Drawing.Point(459, 562);
            this.btnEquals.Margin = new System.Windows.Forms.Padding(6);
            this.btnEquals.Name = "btnEquals";
            this.btnEquals.Size = new System.Drawing.Size(139, 128);
            this.btnEquals.TabIndex = 19;
            this.btnEquals.Text = "=";
            this.btnEquals.UseVisualStyleBackColor = true;
            this.btnEquals.Click += new System.EventHandler(this.btnEquals_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinus.Location = new System.Drawing.Point(459, 145);
            this.btnMinus.Margin = new System.Windows.Forms.Padding(6);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(139, 127);
            this.btnMinus.TabIndex = 7;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // CalculadoraSimples
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 885);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(642, 956);
            this.MinimumSize = new System.Drawing.Size(642, 956);
            this.Name = "CalculadoraSimples";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora Simples";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnSeven;
        private System.Windows.Forms.Button btnEight;
        private System.Windows.Forms.Button btnNine;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnFour;
        private System.Windows.Forms.Button btnFive;
        private System.Windows.Forms.Button btnSix;
        private System.Windows.Forms.Button btnMulti;
        private System.Windows.Forms.Button btnOne;
        private System.Windows.Forms.Button btnTwo;
        private System.Windows.Forms.Button btnThree;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btnZero;
        private System.Windows.Forms.Button btnEquals;
    }
}

