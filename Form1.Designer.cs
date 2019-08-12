namespace MovieRent
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
            this.DGV_Rentmovie = new System.Windows.Forms.DataGridView();
            this.btn_rentoutM = new System.Windows.Forms.Button();
            this.btn_allMovie = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Rentmovie)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_Rentmovie
            // 
            this.DGV_Rentmovie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Rentmovie.Location = new System.Drawing.Point(31, 22);
            this.DGV_Rentmovie.Name = "DGV_Rentmovie";
            this.DGV_Rentmovie.Size = new System.Drawing.Size(501, 211);
            this.DGV_Rentmovie.TabIndex = 0;
            this.DGV_Rentmovie.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Rentmovie_CellContentClick);
            // 
            // btn_rentoutM
            // 
            this.btn_rentoutM.Location = new System.Drawing.Point(417, 294);
            this.btn_rentoutM.Name = "btn_rentoutM";
            this.btn_rentoutM.Size = new System.Drawing.Size(115, 23);
            this.btn_rentoutM.TabIndex = 1;
            this.btn_rentoutM.Text = "Rent Out Movie";
            this.btn_rentoutM.UseVisualStyleBackColor = true;
            this.btn_rentoutM.Click += new System.EventHandler(this.Btn_rentoutM_Click);
            // 
            // btn_allMovie
            // 
            this.btn_allMovie.Location = new System.Drawing.Point(313, 294);
            this.btn_allMovie.Name = "btn_allMovie";
            this.btn_allMovie.Size = new System.Drawing.Size(75, 23);
            this.btn_allMovie.TabIndex = 2;
            this.btn_allMovie.Text = "All Movie";
            this.btn_allMovie.UseVisualStyleBackColor = true;
            this.btn_allMovie.Click += new System.EventHandler(this.Btn_allMovie_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 401);
            this.Controls.Add(this.btn_allMovie);
            this.Controls.Add(this.btn_rentoutM);
            this.Controls.Add(this.DGV_Rentmovie);
            this.Name = "Form1";
            this.Text = "Rent Movie";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Rentmovie)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_Rentmovie;
        private System.Windows.Forms.Button btn_rentoutM;
        private System.Windows.Forms.Button btn_allMovie;
    }
}

