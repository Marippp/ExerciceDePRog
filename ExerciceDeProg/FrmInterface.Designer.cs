namespace ExerciceDeProg
{
    partial class FrmInterface
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnBrasser = new System.Windows.Forms.Button();
            this.lblTypeDeDe = new System.Windows.Forms.Label();
            this.lblValeurDuDe = new System.Windows.Forms.Label();
            this.lblTotalDesPoints = new System.Windows.Forms.Label();
            this.lblAfficherTotalPoints = new System.Windows.Forms.Label();
            this.lblAfficherValeur = new System.Windows.Forms.Label();
            this.lblAfficherType = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBrasser
            // 
            this.btnBrasser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrasser.Location = new System.Drawing.Point(58, 151);
            this.btnBrasser.Name = "btnBrasser";
            this.btnBrasser.Size = new System.Drawing.Size(75, 32);
            this.btnBrasser.TabIndex = 0;
            this.btnBrasser.Text = "Brasser";
            this.btnBrasser.UseVisualStyleBackColor = true;
            this.btnBrasser.Click += new System.EventHandler(this.btnBrasser_Click);
            // 
            // lblTypeDeDe
            // 
            this.lblTypeDeDe.AutoSize = true;
            this.lblTypeDeDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTypeDeDe.Location = new System.Drawing.Point(13, 13);
            this.lblTypeDeDe.Name = "lblTypeDeDe";
            this.lblTypeDeDe.Size = new System.Drawing.Size(157, 20);
            this.lblTypeDeDe.TabIndex = 1;
            this.lblTypeDeDe.Text = "Type de dé courant : ";
            // 
            // lblValeurDuDe
            // 
            this.lblValeurDuDe.AutoSize = true;
            this.lblValeurDuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValeurDuDe.Location = new System.Drawing.Point(13, 57);
            this.lblValeurDuDe.Name = "lblValeurDuDe";
            this.lblValeurDuDe.Size = new System.Drawing.Size(169, 20);
            this.lblValeurDuDe.TabIndex = 2;
            this.lblValeurDuDe.Text = "Valeur du dé courant : ";
            // 
            // lblTotalDesPoints
            // 
            this.lblTotalDesPoints.AutoSize = true;
            this.lblTotalDesPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDesPoints.Location = new System.Drawing.Point(13, 102);
            this.lblTotalDesPoints.Name = "lblTotalDesPoints";
            this.lblTotalDesPoints.Size = new System.Drawing.Size(195, 20);
            this.lblTotalDesPoints.TabIndex = 3;
            this.lblTotalDesPoints.Text = "Total des points obtenus : ";
            // 
            // lblAfficherTotalPoints
            // 
            this.lblAfficherTotalPoints.AutoSize = true;
            this.lblAfficherTotalPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAfficherTotalPoints.Location = new System.Drawing.Point(214, 102);
            this.lblAfficherTotalPoints.Name = "lblAfficherTotalPoints";
            this.lblAfficherTotalPoints.Size = new System.Drawing.Size(44, 20);
            this.lblAfficherTotalPoints.TabIndex = 4;
            this.lblAfficherTotalPoints.Text = "Total";
            // 
            // lblAfficherValeur
            // 
            this.lblAfficherValeur.AutoSize = true;
            this.lblAfficherValeur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAfficherValeur.Location = new System.Drawing.Point(188, 57);
            this.lblAfficherValeur.Name = "lblAfficherValeur";
            this.lblAfficherValeur.Size = new System.Drawing.Size(55, 20);
            this.lblAfficherValeur.TabIndex = 5;
            this.lblAfficherValeur.Text = "Valeur";
            // 
            // lblAfficherType
            // 
            this.lblAfficherType.AutoSize = true;
            this.lblAfficherType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAfficherType.Location = new System.Drawing.Point(176, 13);
            this.lblAfficherType.Name = "lblAfficherType";
            this.lblAfficherType.Size = new System.Drawing.Size(43, 20);
            this.lblAfficherType.TabIndex = 6;
            this.lblAfficherType.Text = "Type";
            // 
            // FrmInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 261);
            this.Controls.Add(this.lblAfficherType);
            this.Controls.Add(this.lblAfficherValeur);
            this.Controls.Add(this.lblAfficherTotalPoints);
            this.Controls.Add(this.lblTotalDesPoints);
            this.Controls.Add(this.lblValeurDuDe);
            this.Controls.Add(this.lblTypeDeDe);
            this.Controls.Add(this.btnBrasser);
            this.Name = "FrmInterface";
            this.Text = "Interface";
            this.Load += new System.EventHandler(this.FrmInterface_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBrasser;
        private System.Windows.Forms.Label lblTypeDeDe;
        private System.Windows.Forms.Label lblValeurDuDe;
        private System.Windows.Forms.Label lblTotalDesPoints;
        private System.Windows.Forms.Label lblAfficherTotalPoints;
        private System.Windows.Forms.Label lblAfficherValeur;
        private System.Windows.Forms.Label lblAfficherType;
    }
}

