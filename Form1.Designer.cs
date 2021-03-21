
namespace textbox
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
            this.txt1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt2 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt3 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt4 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.bunifuMaterialTextbox1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt1
            // 
            this.txt1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt1.HintForeColor = System.Drawing.Color.Empty;
            this.txt1.HintText = "";
            this.txt1.isPassword = false;
            this.txt1.LineFocusedColor = System.Drawing.Color.Blue;
            this.txt1.LineIdleColor = System.Drawing.Color.Gray;
            this.txt1.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txt1.LineThickness = 3;
            this.txt1.Location = new System.Drawing.Point(4, 16);
            this.txt1.Margin = new System.Windows.Forms.Padding(4);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(269, 44);
            this.txt1.TabIndex = 0;
            this.txt1.Text = "Name";
            this.txt1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt1.Enter += new System.EventHandler(this.OnClick);
            this.txt1.Leave += new System.EventHandler(this.OnLeave);
            // 
            // txt2
            // 
            this.txt2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt2.HintForeColor = System.Drawing.Color.Empty;
            this.txt2.HintText = "";
            this.txt2.isPassword = false;
            this.txt2.LineFocusedColor = System.Drawing.Color.Blue;
            this.txt2.LineIdleColor = System.Drawing.Color.Gray;
            this.txt2.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txt2.LineThickness = 3;
            this.txt2.Location = new System.Drawing.Point(4, 68);
            this.txt2.Margin = new System.Windows.Forms.Padding(4);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(269, 44);
            this.txt2.TabIndex = 1;
            this.txt2.Text = "Email";
            this.txt2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt2.Enter += new System.EventHandler(this.OnClick);
            this.txt2.Leave += new System.EventHandler(this.OnLeave);
            // 
            // txt3
            // 
            this.txt3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt3.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt3.HintForeColor = System.Drawing.Color.Empty;
            this.txt3.HintText = "";
            this.txt3.isPassword = false;
            this.txt3.LineFocusedColor = System.Drawing.Color.Blue;
            this.txt3.LineIdleColor = System.Drawing.Color.Gray;
            this.txt3.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txt3.LineThickness = 3;
            this.txt3.Location = new System.Drawing.Point(4, 120);
            this.txt3.Margin = new System.Windows.Forms.Padding(4);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(269, 44);
            this.txt3.TabIndex = 2;
            this.txt3.Text = "Adress";
            this.txt3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt3.Enter += new System.EventHandler(this.OnClick);
            this.txt3.Leave += new System.EventHandler(this.OnLeave);
            // 
            // txt4
            // 
            this.txt4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt4.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt4.HintForeColor = System.Drawing.Color.Empty;
            this.txt4.HintText = "";
            this.txt4.isPassword = false;
            this.txt4.LineFocusedColor = System.Drawing.Color.Blue;
            this.txt4.LineIdleColor = System.Drawing.Color.Gray;
            this.txt4.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txt4.LineThickness = 3;
            this.txt4.Location = new System.Drawing.Point(4, 172);
            this.txt4.Margin = new System.Windows.Forms.Padding(4);
            this.txt4.Name = "txt4";
            this.txt4.Size = new System.Drawing.Size(269, 44);
            this.txt4.TabIndex = 3;
            this.txt4.Text = "Cp No.";
            this.txt4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt4.Enter += new System.EventHandler(this.OnClick);
            this.txt4.Leave += new System.EventHandler(this.OnLeave);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.txt1);
            this.guna2Panel1.Controls.Add(this.txt4);
            this.guna2Panel1.Controls.Add(this.txt2);
            this.guna2Panel1.Controls.Add(this.txt3);
            this.guna2Panel1.Location = new System.Drawing.Point(257, 43);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(288, 244);
            this.guna2Panel1.TabIndex = 4;
            // 
            // bunifuMaterialTextbox1
            // 
            this.bunifuMaterialTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextbox1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuMaterialTextbox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMaterialTextbox1.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextbox1.HintText = "";
            this.bunifuMaterialTextbox1.isPassword = false;
            this.bunifuMaterialTextbox1.LineFocusedColor = System.Drawing.Color.Blue;
            this.bunifuMaterialTextbox1.LineIdleColor = System.Drawing.Color.Gray;
            this.bunifuMaterialTextbox1.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.bunifuMaterialTextbox1.LineThickness = 3;
            this.bunifuMaterialTextbox1.Location = new System.Drawing.Point(261, 330);
            this.bunifuMaterialTextbox1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMaterialTextbox1.Name = "bunifuMaterialTextbox1";
            this.bunifuMaterialTextbox1.Size = new System.Drawing.Size(269, 44);
            this.bunifuMaterialTextbox1.TabIndex = 0;
            this.bunifuMaterialTextbox1.Text = "Age";
            this.bunifuMaterialTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuMaterialTextbox1.Enter += new System.EventHandler(this.OnClick);
            this.bunifuMaterialTextbox1.Leave += new System.EventHandler(this.OnLeave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bunifuMaterialTextbox1);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMaterialTextbox txt1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt4;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox1;
    }
}

