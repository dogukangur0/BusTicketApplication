
namespace BusTicketApplication
{
    partial class TicketCancel
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
            this.textBoxSeatNo = new System.Windows.Forms.TextBox();
            this.textBoxJourneyId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxSeatNo
            // 
            this.textBoxSeatNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBoxSeatNo.Location = new System.Drawing.Point(178, 118);
            this.textBoxSeatNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxSeatNo.Name = "textBoxSeatNo";
            this.textBoxSeatNo.Size = new System.Drawing.Size(165, 28);
            this.textBoxSeatNo.TabIndex = 19;
            // 
            // textBoxJourneyId
            // 
            this.textBoxJourneyId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBoxJourneyId.Location = new System.Drawing.Point(175, 70);
            this.textBoxJourneyId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxJourneyId.Name = "textBoxJourneyId";
            this.textBoxJourneyId.Size = new System.Drawing.Size(167, 28);
            this.textBoxJourneyId.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.Location = new System.Drawing.Point(86, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 24);
            this.label2.TabIndex = 17;
            this.label2.Text = "Seat no:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(86, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 24);
            this.label1.TabIndex = 16;
            this.label1.Text = "Journey:";
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.IndianRed;
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.buttonCancel.Location = new System.Drawing.Point(210, 168);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(133, 37);
            this.buttonCancel.TabIndex = 15;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.BurlyWood;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnBack.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBack.Location = new System.Drawing.Point(12, 11);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(133, 37);
            this.btnBack.TabIndex = 15;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // TicketCancel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 239);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.textBoxSeatNo);
            this.Controls.Add(this.textBoxJourneyId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCancel);
            this.Name = "TicketCancel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TicketCancel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSeatNo;
        private System.Windows.Forms.TextBox textBoxJourneyId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button btnBack;
    }
}