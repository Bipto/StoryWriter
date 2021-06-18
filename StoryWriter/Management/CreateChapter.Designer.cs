
namespace StoryWriter.Management
{
    partial class CreateChapter
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
            this.TbxName = new System.Windows.Forms.TextBox();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnCreate = new System.Windows.Forms.Button();
            this.LblName = new System.Windows.Forms.Label();
            this.LblNewStory = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TbxName
            // 
            this.TbxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbxName.Location = new System.Drawing.Point(130, 77);
            this.TbxName.Name = "TbxName";
            this.TbxName.Size = new System.Drawing.Size(271, 28);
            this.TbxName.TabIndex = 11;
            this.TbxName.TextChanged += new System.EventHandler(this.TbxName_TextChanged);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancel.Location = new System.Drawing.Point(130, 120);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(81, 33);
            this.BtnCancel.TabIndex = 10;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnCreate
            // 
            this.BtnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCreate.Location = new System.Drawing.Point(231, 120);
            this.BtnCreate.Name = "BtnCreate";
            this.BtnCreate.Size = new System.Drawing.Size(81, 33);
            this.BtnCreate.TabIndex = 9;
            this.BtnCreate.Text = "Create";
            this.BtnCreate.UseVisualStyleBackColor = true;
            this.BtnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblName.Location = new System.Drawing.Point(74, 81);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(50, 24);
            this.LblName.TabIndex = 8;
            this.LblName.Text = "Title:";
            // 
            // LblNewStory
            // 
            this.LblNewStory.AutoSize = true;
            this.LblNewStory.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNewStory.Location = new System.Drawing.Point(99, 24);
            this.LblNewStory.Name = "LblNewStory";
            this.LblNewStory.Size = new System.Drawing.Size(284, 32);
            this.LblNewStory.TabIndex = 7;
            this.LblNewStory.Text = "Create a new chapter";
            // 
            // CreateChapter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 190);
            this.Controls.Add(this.TbxName);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnCreate);
            this.Controls.Add(this.LblName);
            this.Controls.Add(this.LblNewStory);
            this.MaximizeBox = false;
            this.Name = "CreateChapter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CreateChapter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TbxName;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnCreate;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Label LblNewStory;
    }
}