namespace Notepad.UI
{
    partial class NotepadNewScriptForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotepadNewScriptForm));
            this.richTbxTheNote = new System.Windows.Forms.RichTextBox();
            this.btnSaveNote = new System.Windows.Forms.Button();
            this.lblNoteName = new System.Windows.Forms.Label();
            this.tbxNoteName = new System.Windows.Forms.TextBox();
            this.lblMe = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // richTbxTheNote
            // 
            this.richTbxTheNote.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTbxTheNote.Font = new System.Drawing.Font("Lucida Console", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.richTbxTheNote.Location = new System.Drawing.Point(16, 14);
            this.richTbxTheNote.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.richTbxTheNote.Name = "richTbxTheNote";
            this.richTbxTheNote.Size = new System.Drawing.Size(1066, 424);
            this.richTbxTheNote.TabIndex = 0;
            this.richTbxTheNote.Text = "";
            // 
            // btnSaveNote
            // 
            this.btnSaveNote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveNote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(247)))));
            this.btnSaveNote.Location = new System.Drawing.Point(964, 453);
            this.btnSaveNote.Name = "btnSaveNote";
            this.btnSaveNote.Size = new System.Drawing.Size(118, 41);
            this.btnSaveNote.TabIndex = 1;
            this.btnSaveNote.Text = "Save";
            this.btnSaveNote.UseVisualStyleBackColor = false;
            this.btnSaveNote.Click += new System.EventHandler(this.btnSaveNote_Click);
            // 
            // lblNoteName
            // 
            this.lblNoteName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNoteName.AutoSize = true;
            this.lblNoteName.Location = new System.Drawing.Point(606, 464);
            this.lblNoteName.Name = "lblNoteName";
            this.lblNoteName.Size = new System.Drawing.Size(119, 19);
            this.lblNoteName.TabIndex = 2;
            this.lblNoteName.Text = "Note Name:";
            // 
            // tbxNoteName
            // 
            this.tbxNoteName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxNoteName.Location = new System.Drawing.Point(731, 461);
            this.tbxNoteName.Name = "tbxNoteName";
            this.tbxNoteName.Size = new System.Drawing.Size(227, 25);
            this.tbxNoteName.TabIndex = 3;
            // 
            // lblMe
            // 
            this.lblMe.AutoSize = true;
            this.lblMe.Font = new System.Drawing.Font("Lucida Console", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMe.Location = new System.Drawing.Point(13, 484);
            this.lblMe.Name = "lblMe";
            this.lblMe.Size = new System.Drawing.Size(103, 13);
            this.lblMe.TabIndex = 4;
            this.lblMe.Text = "Deniz Varıcı";
            // 
            // NotepadNewScriptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1100, 506);
            this.Controls.Add(this.lblMe);
            this.Controls.Add(this.tbxNoteName);
            this.Controls.Add(this.lblNoteName);
            this.Controls.Add(this.btnSaveNote);
            this.Controls.Add(this.richTbxTheNote);
            this.Font = new System.Drawing.Font("Lucida Console", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "NotepadNewScriptForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DV/Notepad/NewNote";
            this.Load += new System.EventHandler(this.NotepadNewScriptForm_Load);
            this.Resize += new System.EventHandler(this.NotepadNewScriptForm_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTbxTheNote;
        private System.Windows.Forms.Button btnSaveNote;
        private System.Windows.Forms.Label lblNoteName;
        private System.Windows.Forms.TextBox tbxNoteName;
        private System.Windows.Forms.Label lblMe;
    }
}