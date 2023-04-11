
namespace AtulamAdmin
{
    partial class TestCommande
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
            this.grille = new ControlsBase.Atulam_Grille();
            this.gv = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.grille)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv)).BeginInit();
            this.SuspendLayout();
            // 
            // grille
            // 
            this.grille.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grille.EnabledControl = true;
            this.grille.Location = new System.Drawing.Point(0, 10);
            this.grille.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.grille.LookAndFeel.UseDefaultLookAndFeel = false;
            this.grille.MainView = this.gv;
            this.grille.Name = "grille";
            this.grille.Size = new System.Drawing.Size(1519, 773);
            this.grille.TabIndex = 5;
            this.grille.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv});
            // 
            // gv
            // 
            this.gv.GridControl = this.grille;
            this.gv.Name = "gv";
            // 
            // TestCommande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1519, 783);
            this.Controls.Add(this.grille);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(395, 289);
            this.Name = "TestCommande";
            this.Text = "TestCommande";
            this.Controls.SetChildIndex(this.grille, 0);
            ((System.ComponentModel.ISupportInitialize)(this.grille)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ControlsBase.Atulam_Grille grille;
        private DevExpress.XtraGrid.Views.Grid.GridView gv;
    }
}