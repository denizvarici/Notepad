namespace Notepad.UI
{
    partial class NotepadMainForm
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
            this.lblNoteList = new System.Windows.Forms.Label();
            this.btnOpenNote = new System.Windows.Forms.Button();
            this.lstbxNoteList = new System.Windows.Forms.ListBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnNewNote = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNoteList
            // 
            this.lblNoteList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNoteList.AutoSize = true;
            this.lblNoteList.Location = new System.Drawing.Point(69, 127);
            this.lblNoteList.Name = "lblNoteList";
            this.lblNoteList.Size = new System.Drawing.Size(108, 19);
            this.lblNoteList.TabIndex = 2;
            this.lblNoteList.Text = "My Notes:";
            // 
            // btnOpenNote
            // 
            this.btnOpenNote.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnOpenNote.Location = new System.Drawing.Point(68, 465);
            this.btnOpenNote.Name = "btnOpenNote";
            this.btnOpenNote.Size = new System.Drawing.Size(135, 35);
            this.btnOpenNote.TabIndex = 3;
            this.btnOpenNote.Text = "Open";
            this.btnOpenNote.UseVisualStyleBackColor = true;
            this.btnOpenNote.Click += new System.EventHandler(this.btnOpenNote_Click);
            // 
            // lstbxNoteList
            // 
            this.lstbxNoteList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstbxNoteList.FormattingEnabled = true;
            this.lstbxNoteList.ItemHeight = 18;
            this.lstbxNoteList.Location = new System.Drawing.Point(48, 149);
            this.lstbxNoteList.Name = "lstbxNoteList";
            this.lstbxNoteList.Size = new System.Drawing.Size(175, 310);
            this.lstbxNoteList.TabIndex = 4;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDelete.Location = new System.Drawing.Point(68, 506);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(135, 35);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnNewNote
            // 
            this.btnNewNote.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnNewNote.Location = new System.Drawing.Point(48, 32);
            this.btnNewNote.Name = "btnNewNote";
            this.btnNewNote.Size = new System.Drawing.Size(175, 79);
            this.btnNewNote.TabIndex = 7;
            this.btnNewNote.Text = "New Note";
            this.btnNewNote.UseVisualStyleBackColor = true;
            this.btnNewNote.Click += new System.EventHandler(this.btnNewNote_Click);
            // 
            // NotepadMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 571);
            this.Controls.Add(this.btnNewNote);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lstbxNoteList);
            this.Controls.Add(this.btnOpenNote);
            this.Controls.Add(this.lblNoteList);
            this.Font = new System.Drawing.Font("Lucida Console", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "NotepadMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DV/Notepad";
            this.Load += new System.EventHandler(this.NotepadMainForm_Load);
            this.Resize += new System.EventHandler(this.NotepadMainForm_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNoteList;
        private System.Windows.Forms.Button btnOpenNote;
        private System.Windows.Forms.ListBox lstbxNoteList;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnNewNote;
    }
}

