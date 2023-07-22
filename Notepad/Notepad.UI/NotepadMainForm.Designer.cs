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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotepadMainForm));
            this.lblNoteList = new System.Windows.Forms.Label();
            this.btnOpenNote = new System.Windows.Forms.Button();
            this.lstbxNoteList = new System.Windows.Forms.ListBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnNewNote = new System.Windows.Forms.Button();
            this.lblMe = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNoteList
            // 
            this.lblNoteList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNoteList.AutoSize = true;
            this.lblNoteList.Location = new System.Drawing.Point(84, 127);
            this.lblNoteList.Name = "lblNoteList";
            this.lblNoteList.Size = new System.Drawing.Size(97, 19);
            this.lblNoteList.TabIndex = 2;
            this.lblNoteList.Text = "My Notes";
            // 
            // btnOpenNote
            // 
            this.btnOpenNote.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnOpenNote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.btnOpenNote.Location = new System.Drawing.Point(68, 465);
            this.btnOpenNote.Name = "btnOpenNote";
            this.btnOpenNote.Size = new System.Drawing.Size(135, 35);
            this.btnOpenNote.TabIndex = 3;
            this.btnOpenNote.Text = "Open";
            this.btnOpenNote.UseVisualStyleBackColor = false;
            this.btnOpenNote.Click += new System.EventHandler(this.btnOpenNote_Click);
            // 
            // lstbxNoteList
            // 
            this.lstbxNoteList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstbxNoteList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.lstbxNoteList.FormattingEnabled = true;
            this.lstbxNoteList.ItemHeight = 18;
            this.lstbxNoteList.Location = new System.Drawing.Point(48, 149);
            this.lstbxNoteList.Name = "lstbxNoteList";
            this.lstbxNoteList.Size = new System.Drawing.Size(175, 310);
            this.lstbxNoteList.TabIndex = 4;
//            this.lstbxNoteList.DoubleClick += new System.EventHandler(this.lstbxNoteList_DoubleClick);
//            this.lstbxNoteList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstbxNoteList_MouseDoubleClick);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnDelete.Location = new System.Drawing.Point(68, 506);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(135, 35);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnNewNote
            // 
            this.btnNewNote.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnNewNote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(255)))), ((int)(((byte)(204)))));
            this.btnNewNote.Location = new System.Drawing.Point(48, 32);
            this.btnNewNote.Name = "btnNewNote";
            this.btnNewNote.Size = new System.Drawing.Size(175, 79);
            this.btnNewNote.TabIndex = 7;
            this.btnNewNote.Text = "New Note";
            this.btnNewNote.UseVisualStyleBackColor = false;
            this.btnNewNote.Click += new System.EventHandler(this.btnNewNote_Click);
            // 
            // lblMe
            // 
            this.lblMe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblMe.AutoSize = true;
            this.lblMe.Font = new System.Drawing.Font("Lucida Console", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMe.Location = new System.Drawing.Point(12, 549);
            this.lblMe.Name = "lblMe";
            this.lblMe.Size = new System.Drawing.Size(89, 12);
            this.lblMe.TabIndex = 8;
            this.lblMe.Text = "Deniz Varıcı";
            // 
            // NotepadMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(279, 571);
            this.Controls.Add(this.lblMe);
            this.Controls.Add(this.btnNewNote);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lstbxNoteList);
            this.Controls.Add(this.btnOpenNote);
            this.Controls.Add(this.lblNoteList);
            this.Font = new System.Drawing.Font("Lucida Console", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.Label lblMe;
    }
}

