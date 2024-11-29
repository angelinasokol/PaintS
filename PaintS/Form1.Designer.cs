namespace PaintS
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
            panel1 = new Panel();
            btnClear = new Button();
            btnSave = new Button();
            btnTriangle = new Button();
            btnRectang = new Button();
            btnEllipse = new Button();
            btnLine = new Button();
            btnPaint = new Button();
            btnColor = new Button();
            pic = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Tan;
            panel1.Controls.Add(btnClear);
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(btnTriangle);
            panel1.Controls.Add(btnRectang);
            panel1.Controls.Add(btnEllipse);
            panel1.Controls.Add(btnLine);
            panel1.Controls.Add(btnPaint);
            panel1.Controls.Add(btnColor);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(206, 722);
            panel1.TabIndex = 0;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Comic Sans MS", 15F, FontStyle.Italic, GraphicsUnit.Point);
            btnClear.Location = new Point(5, 642);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 41);
            btnClear.TabIndex = 8;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += BtnClear_Click;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Comic Sans MS", 15F, FontStyle.Italic, GraphicsUnit.Point);
            btnSave.Location = new Point(105, 642);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 41);
            btnSave.TabIndex = 6;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnTriangle
            // 
            btnTriangle.BackgroundImage = Properties.Resources._1697703098_flomaster_top_p_chernii_treugolnik_risunok_vkontakte_48;
            btnTriangle.BackgroundImageLayout = ImageLayout.Zoom;
            btnTriangle.Location = new Point(44, 517);
            btnTriangle.Name = "btnTriangle";
            btnTriangle.Size = new Size(98, 79);
            btnTriangle.TabIndex = 7;
            btnTriangle.UseVisualStyleBackColor = true;
            btnTriangle.Click += btnTriangle_Click;
            // 
            // btnRectang
            // 
            btnRectang.BackgroundImage = Properties.Resources._76c79aa1347c4c35c6b736aa8cb69067;
            btnRectang.BackgroundImageLayout = ImageLayout.Zoom;
            btnRectang.Location = new Point(44, 415);
            btnRectang.Name = "btnRectang";
            btnRectang.Size = new Size(98, 79);
            btnRectang.TabIndex = 5;
            btnRectang.UseVisualStyleBackColor = true;
            btnRectang.Click += btnRectang_Click;
            // 
            // btnEllipse
            // 
            btnEllipse.BackgroundImage = Properties.Resources._1681840505_kartinki_pibig_info_p_kartinka_belii_krug_arti_vkontakte_12;
            btnEllipse.BackgroundImageLayout = ImageLayout.Zoom;
            btnEllipse.Location = new Point(44, 317);
            btnEllipse.Name = "btnEllipse";
            btnEllipse.Size = new Size(98, 79);
            btnEllipse.TabIndex = 4;
            btnEllipse.UseVisualStyleBackColor = true;
            btnEllipse.Click += btnEllipse_Click;
            // 
            // btnLine
            // 
            btnLine.BackgroundImage = Properties.Resources._5cff802d48d74607ac929ec2751684e9;
            btnLine.BackgroundImageLayout = ImageLayout.Zoom;
            btnLine.Location = new Point(44, 218);
            btnLine.Name = "btnLine";
            btnLine.Size = new Size(98, 79);
            btnLine.TabIndex = 3;
            btnLine.UseVisualStyleBackColor = true;
            btnLine.Click += btnLine_Click;
            // 
            // btnPaint
            // 
            btnPaint.BackgroundImage = Properties.Resources.pngtree_blue_paint_white_paint_bucket_water_droplet_paint_paint_decoration_png_image_407650;
            btnPaint.BackgroundImageLayout = ImageLayout.Zoom;
            btnPaint.Location = new Point(44, 120);
            btnPaint.Name = "btnPaint";
            btnPaint.Size = new Size(98, 79);
            btnPaint.TabIndex = 2;
            btnPaint.UseVisualStyleBackColor = true;
            btnPaint.Click += btnPaint_Click;
            // 
            // btnColor
            // 
            btnColor.BackgroundImage = Properties.Resources.e85fb1190dbc6bcbc52084bdc2bca106;
            btnColor.BackgroundImageLayout = ImageLayout.Zoom;
            btnColor.Location = new Point(44, 21);
            btnColor.Name = "btnColor";
            btnColor.Size = new Size(98, 79);
            btnColor.TabIndex = 1;
            btnColor.UseVisualStyleBackColor = true;
            btnColor.Click += btnColor_Click;
            // 
            // pic
            // 
            pic.Dock = DockStyle.Fill;
            pic.Location = new Point(206, 0);
            pic.Name = "pic";
            pic.Size = new Size(667, 722);
            pic.TabIndex = 0;
            pic.TabStop = false;
            pic.MouseClick += pic_MouseClick;
            pic.MouseDown += pic_MouseDown;
            pic.MouseMove += pic_MouseMove;
            pic.MouseUp += pic_MouseUp;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(873, 722);
            Controls.Add(pic);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pic).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnSave;
        private Button btnTriangle;
        private Button btnRectang;
        private Button btnEllipse;
        private Button btnLine;
        private Button btnPaint;
        private Button btnColor;
        private PictureBox pic;
        private Button btnClear;
    }
}