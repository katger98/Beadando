
namespace IRF_IT6NSI
{
    partial class Form1
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
            this.dgwApp = new System.Windows.Forms.DataGridView();
            this.dgwAcc = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAcc = new System.Windows.Forms.Button();
            this.btnDen = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwApp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwAcc)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwApp
            // 
            this.dgwApp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwApp.Location = new System.Drawing.Point(12, 26);
            this.dgwApp.Name = "dgwApp";
            this.dgwApp.Size = new System.Drawing.Size(457, 368);
            this.dgwApp.TabIndex = 0;
            this.dgwApp.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwApp_CellClick);
            // 
            // dgwAcc
            // 
            this.dgwAcc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwAcc.Location = new System.Drawing.Point(553, 26);
            this.dgwAcc.Name = "dgwAcc";
            this.dgwAcc.Size = new System.Drawing.Size(422, 368);
            this.dgwAcc.TabIndex = 1;
            this.dgwAcc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwAcc_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "A jelentkezők listája";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(553, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "A kiválasztott fellépők";
            // 
            // btnAcc
            // 
            this.btnAcc.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcc.Location = new System.Drawing.Point(484, 126);
            this.btnAcc.Name = "btnAcc";
            this.btnAcc.Size = new System.Drawing.Size(47, 45);
            this.btnAcc.TabIndex = 8;
            this.btnAcc.Text = ">";
            this.btnAcc.UseVisualStyleBackColor = true;
            this.btnAcc.Click += new System.EventHandler(this.btnAcc_Click);
            // 
            // btnDen
            // 
            this.btnDen.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDen.Location = new System.Drawing.Point(484, 223);
            this.btnDen.Name = "btnDen";
            this.btnDen.Size = new System.Drawing.Size(47, 45);
            this.btnDen.TabIndex = 9;
            this.btnDen.Text = "<";
            this.btnDen.UseVisualStyleBackColor = true;
            this.btnDen.Click += new System.EventHandler(this.btnDen_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(484, 323);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(47, 45);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.CancelButton = this.btnAcc;
            this.ClientSize = new System.Drawing.Size(987, 576);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDen);
            this.Controls.Add(this.btnAcc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgwAcc);
            this.Controls.Add(this.dgwApp);
            this.Name = "Form1";
            this.Text = "Koncert";
            ((System.ComponentModel.ISupportInitialize)(this.dgwApp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwAcc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwApp;
        private System.Windows.Forms.DataGridView dgwAcc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAcc;
        private System.Windows.Forms.Button btnDen;
        private System.Windows.Forms.Button btnSave;
    }
}

