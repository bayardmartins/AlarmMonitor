namespace AlarmMonitor.Presentation.Views
{
    partial class FrmPanel
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
            this.lblPanel = new System.Windows.Forms.Label();
            this.lblEvent = new System.Windows.Forms.Label();
            this.grdPanel = new System.Windows.Forms.DataGridView();
            this.grdEvent = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grdPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdEvent)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPanel
            // 
            this.lblPanel.AutoSize = true;
            this.lblPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPanel.Location = new System.Drawing.Point(19, 9);
            this.lblPanel.Name = "lblPanel";
            this.lblPanel.Size = new System.Drawing.Size(60, 20);
            this.lblPanel.TabIndex = 2;
            this.lblPanel.Text = "Painéis";
            // 
            // lblEvent
            // 
            this.lblEvent.AutoSize = true;
            this.lblEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEvent.Location = new System.Drawing.Point(141, 9);
            this.lblEvent.Name = "lblEvent";
            this.lblEvent.Size = new System.Drawing.Size(67, 20);
            this.lblEvent.TabIndex = 3;
            this.lblEvent.Text = "Eventos";
            // 
            // grdPanel
            // 
            this.grdPanel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPanel.Location = new System.Drawing.Point(23, 32);
            this.grdPanel.Name = "grdPanel";
            this.grdPanel.Size = new System.Drawing.Size(92, 420);
            this.grdPanel.TabIndex = 4;
            // 
            // grdEvent
            // 
            this.grdEvent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdEvent.Location = new System.Drawing.Point(145, 32);
            this.grdEvent.Name = "grdEvent";
            this.grdEvent.Size = new System.Drawing.Size(1115, 420);
            this.grdEvent.TabIndex = 5;
            // 
            // FrmPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 464);
            this.Controls.Add(this.grdEvent);
            this.Controls.Add(this.grdPanel);
            this.Controls.Add(this.lblEvent);
            this.Controls.Add(this.lblPanel);
            this.Name = "FrmPanel";
            this.Text = "Alarm Monitor";
            ((System.ComponentModel.ISupportInitialize)(this.grdPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdEvent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblPanel;
        private System.Windows.Forms.Label lblEvent;
        private System.Windows.Forms.DataGridView grdPanel;
        private System.Windows.Forms.DataGridView grdEvent;
    }
}

