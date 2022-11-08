
namespace Homework_2_WF
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
            this.Byte = new System.Windows.Forms.Button();
            this.Sbyte = new System.Windows.Forms.Button();
            this.Short = new System.Windows.Forms.Button();
            this.Ushort = new System.Windows.Forms.Button();
            this.Int = new System.Windows.Forms.Button();
            this.Uint = new System.Windows.Forms.Button();
            this.Long = new System.Windows.Forms.Button();
            this.Ulong = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Byte
            // 
            this.Byte.Location = new System.Drawing.Point(42, 12);
            this.Byte.Name = "Byte";
            this.Byte.Size = new System.Drawing.Size(94, 29);
            this.Byte.TabIndex = 0;
            this.Byte.Text = "Byte";
            this.Byte.UseVisualStyleBackColor = true;
            this.Byte.Click += new System.EventHandler(this.Byte_Click);
            // 
            // Sbyte
            // 
            this.Sbyte.Location = new System.Drawing.Point(42, 47);
            this.Sbyte.Name = "Sbyte";
            this.Sbyte.Size = new System.Drawing.Size(94, 29);
            this.Sbyte.TabIndex = 1;
            this.Sbyte.Text = "Sbyte";
            this.Sbyte.UseVisualStyleBackColor = true;
            this.Sbyte.Click += new System.EventHandler(this.Sbyte_Click);
            // 
            // Short
            // 
            this.Short.Location = new System.Drawing.Point(42, 82);
            this.Short.Name = "Short";
            this.Short.Size = new System.Drawing.Size(94, 29);
            this.Short.TabIndex = 2;
            this.Short.Text = "Short";
            this.Short.UseVisualStyleBackColor = true;
            this.Short.Click += new System.EventHandler(this.Short_Click);
            // 
            // Ushort
            // 
            this.Ushort.Location = new System.Drawing.Point(42, 117);
            this.Ushort.Name = "Ushort";
            this.Ushort.Size = new System.Drawing.Size(94, 29);
            this.Ushort.TabIndex = 3;
            this.Ushort.Text = "Ushort";
            this.Ushort.UseVisualStyleBackColor = true;
            this.Ushort.Click += new System.EventHandler(this.Ushort_Click);
            // 
            // Int
            // 
            this.Int.Location = new System.Drawing.Point(241, 12);
            this.Int.Name = "Int";
            this.Int.Size = new System.Drawing.Size(94, 29);
            this.Int.TabIndex = 4;
            this.Int.Text = "Int";
            this.Int.UseVisualStyleBackColor = true;
            this.Int.Click += new System.EventHandler(this.Int_Click);
            // 
            // Uint
            // 
            this.Uint.Location = new System.Drawing.Point(241, 47);
            this.Uint.Name = "Uint";
            this.Uint.Size = new System.Drawing.Size(94, 29);
            this.Uint.TabIndex = 5;
            this.Uint.Text = "Uint";
            this.Uint.UseVisualStyleBackColor = true;
            this.Uint.Click += new System.EventHandler(this.Uint_Click);
            // 
            // Long
            // 
            this.Long.Location = new System.Drawing.Point(241, 82);
            this.Long.Name = "Long";
            this.Long.Size = new System.Drawing.Size(94, 29);
            this.Long.TabIndex = 6;
            this.Long.Text = "Long";
            this.Long.UseVisualStyleBackColor = true;
            this.Long.Click += new System.EventHandler(this.Long_Click);
            // 
            // Ulong
            // 
            this.Ulong.Location = new System.Drawing.Point(241, 117);
            this.Ulong.Name = "Ulong";
            this.Ulong.Size = new System.Drawing.Size(94, 29);
            this.Ulong.TabIndex = 7;
            this.Ulong.Text = "Ulong";
            this.Ulong.UseVisualStyleBackColor = true;
            this.Ulong.Click += new System.EventHandler(this.Ulong_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 163);
            this.Controls.Add(this.Ulong);
            this.Controls.Add(this.Long);
            this.Controls.Add(this.Uint);
            this.Controls.Add(this.Int);
            this.Controls.Add(this.Ushort);
            this.Controls.Add(this.Short);
            this.Controls.Add(this.Sbyte);
            this.Controls.Add(this.Byte);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Byte;
        private System.Windows.Forms.Button Sbyte;
        private System.Windows.Forms.Button Short;
        private System.Windows.Forms.Button Ushort;
        private System.Windows.Forms.Button Int;
        private System.Windows.Forms.Button Uint;
        private System.Windows.Forms.Button Long;
        private System.Windows.Forms.Button Ulong;
    }
}

