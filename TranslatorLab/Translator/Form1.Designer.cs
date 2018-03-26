using System.Drawing;
using System.Windows.Forms;

namespace Translator
{
    partial class aForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;


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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(aForm));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aLoad = new System.Windows.Forms.ToolStripMenuItem();
            this.export = new System.Windows.Forms.ToolStripMenuItem();
            this.aList = new System.Windows.Forms.ListView();
            this.aHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.aHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.aButton1 = new System.Windows.Forms.Button();
            this.aRichBox = new System.Windows.Forms.RichTextBox();
            this.aRichBox2 = new System.Windows.Forms.RichTextBox();
            this.aToolStrip = new System.Windows.Forms.ToolStrip();
            this.aFontDropDown = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.addButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.aToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "txt";
            this.openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            this.openFileDialog1.InitialDirectory = "Computer";
            this.openFileDialog1.RestoreDirectory = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1255, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aLoad,
            this.export});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // aLoad
            // 
            this.aLoad.Name = "aLoad";
            this.aLoad.Size = new System.Drawing.Size(127, 26);
            this.aLoad.Text = "Load";
            this.aLoad.Click += new System.EventHandler(this.aLoad_Click);
            // 
            // export
            // 
            this.export.Name = "export";
            this.export.Size = new System.Drawing.Size(127, 26);
            this.export.Text = "Export";
            this.export.Click += new System.EventHandler(this.export_Click);
            // 
            // aList
            // 
            this.aList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.aList.BackColor = System.Drawing.SystemColors.HighlightText;
            this.aList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.aHeader,
            this.aHeader2});
            this.aList.FullRowSelect = true;
            this.aList.GridLines = true;
            this.aList.LabelEdit = true;
            this.aList.Location = new System.Drawing.Point(0, 33);
            this.aList.Margin = new System.Windows.Forms.Padding(4);
            this.aList.Name = "aList";
            this.aList.Size = new System.Drawing.Size(281, 542);
            this.aList.TabIndex = 6;
            this.aList.UseCompatibleStateImageBehavior = false;
            this.aList.View = System.Windows.Forms.View.Details;
            // 
            // aHeader
            // 
            this.aHeader.Text = "";
            this.aHeader.Width = 105;
            // 
            // aHeader2
            // 
            this.aHeader2.Text = "";
            this.aHeader2.Width = 105;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.aButton1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.aRichBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.aRichBox2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.aToolStrip, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(322, 67);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(933, 538);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // aButton1
            // 
            this.aButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.aButton1.Location = new System.Drawing.Point(416, 263);
            this.aButton1.Margin = new System.Windows.Forms.Padding(4);
            this.aButton1.Name = "aButton1";
            this.aButton1.Size = new System.Drawing.Size(100, 42);
            this.aButton1.TabIndex = 2;
            this.aButton1.Text = "Translate!";
            this.aButton1.UseVisualStyleBackColor = true;
            this.aButton1.Click += new System.EventHandler(this.button1_Click);
            // 
            // aRichBox
            // 
            this.aRichBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.aRichBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aRichBox.Location = new System.Drawing.Point(3, 33);
            this.aRichBox.Name = "aRichBox";
            this.aRichBox.Size = new System.Drawing.Size(927, 223);
            this.aRichBox.TabIndex = 3;
            this.aRichBox.Text = "";
            // 
            // aRichBox2
            // 
            this.aRichBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.aRichBox2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aRichBox2.Location = new System.Drawing.Point(3, 312);
            this.aRichBox2.Name = "aRichBox2";
            this.aRichBox2.Size = new System.Drawing.Size(927, 223);
            this.aRichBox2.TabIndex = 4;
            this.aRichBox2.Text = "";
            // 
            // aToolStrip
            // 
            this.aToolStrip.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.aToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.aToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.aToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aFontDropDown,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripButton5,
            this.toolStripButton2,
            this.toolStripButton1});
            this.aToolStrip.Location = new System.Drawing.Point(0, 0);
            this.aToolStrip.Name = "aToolStrip";
            this.aToolStrip.Size = new System.Drawing.Size(933, 30);
            this.aToolStrip.TabIndex = 5;
            this.aToolStrip.Text = "toolStrip1";
            // 
            // aFontDropDown
            // 
            this.aFontDropDown.AccessibleRole = System.Windows.Forms.AccessibleRole.DropList;
            this.aFontDropDown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.aFontDropDown.Image = ((System.Drawing.Image)(resources.GetObject("aFontDropDown.Image")));
            this.aFontDropDown.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.aFontDropDown.Name = "aFontDropDown";
            this.aFontDropDown.Size = new System.Drawing.Size(66, 27);
            this.aFontDropDown.Tag = "Calibri";
            this.aFontDropDown.Text = "Calibri";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(24, 27);
            this.toolStripButton3.Text = "Italic";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(24, 27);
            this.toolStripButton4.Text = "Bold";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(24, 27);
            this.toolStripButton5.Text = "Underlined";
            this.toolStripButton5.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(24, 27);
            this.toolStripButton2.Text = "fontButton";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(24, 27);
            this.toolStripButton1.Text = "backgroundButton";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.Location = new System.Drawing.Point(54, 582);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(161, 23);
            this.addButton.TabIndex = 9;
            this.addButton.Text = "Add new word";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // aForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1255, 609);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.aList);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(661, 481);
            this.Name = "aForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.aToolStrip.ResumeLayout(false);
            this.aToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aLoad;
        private System.Windows.Forms.ToolStripMenuItem export;
        private System.Windows.Forms.ListView aList;
        private System.Windows.Forms.ColumnHeader aHeader;
        private System.Windows.Forms.ColumnHeader aHeader2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button aButton1;
        private System.Windows.Forms.RichTextBox aRichBox;
        private System.Windows.Forms.RichTextBox aRichBox2;
        private System.Windows.Forms.ToolStrip aToolStrip;
        private System.Windows.Forms.ToolStripDropDownButton aFontDropDown;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.Button addButton;
    }
}

