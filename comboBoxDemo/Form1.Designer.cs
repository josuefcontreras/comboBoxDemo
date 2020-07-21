using System;
using System.Drawing;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace comboBoxDemo
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
            this.comboBoxColorPicker = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // comboBoxColorPicker
            // 
            this.comboBoxColorPicker.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxColorPicker.FormattingEnabled = true;
            this.comboBoxColorPicker.Location = new System.Drawing.Point(217, 160);
            this.comboBoxColorPicker.Name = "comboBoxColorPicker";
            this.comboBoxColorPicker.Size = new System.Drawing.Size(374, 48);
            this.comboBoxColorPicker.TabIndex = 0;
            this.comboBoxColorPicker.SelectedIndexChanged += new System.EventHandler(this.comboBoxColorPicker_SelectedIndexChanged);
            this.populate(this.comboBoxColorPicker);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBoxColorPicker);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
        }

        private void populate(ComboBox comboBoxColorPicker)
        {
            foreach (System.Reflection.PropertyInfo prop in typeof(Color).GetProperties())
            {
                if (prop.PropertyType.FullName == "System.Drawing.Color")
                    comboBoxColorPicker.Items.Add(prop.Name);
            }
        }

        #endregion
        private List<Color> colors = new List<Color>();

        private ComboBox comboBoxColorPicker;
    }
}

