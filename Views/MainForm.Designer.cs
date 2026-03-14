namespace HastaneRandevuSistemi.Views;

partial class MainForm
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
        panel1 = new Panel();
        SuspendLayout();
        // 
        // panel1
        // 
        panel1.Location = new Point(1, 0);
        panel1.Name = "panel1";
        panel1.Size = new Size(1264, 720);
        panel1.TabIndex = 0;
        panel1.Paint += panel1_Paint;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(30, 39, 46);
        ClientSize = new Size(1264, 721);
        Controls.Add(panel1);
        MaximumSize = new Size(1280, 760);
        MinimumSize = new Size(1280, 760);
        Name = "MainForm";
        Text = "Form1";
        Load += Form1_Load;
        ResumeLayout(false);
    }

    #endregion

    private Panel panel1;
}
