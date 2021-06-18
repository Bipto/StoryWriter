
namespace StoryWriter.Management
{
    partial class CreateStory
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
            this.LblNewStory = new System.Windows.Forms.Label();
            this.LblName = new System.Windows.Forms.Label();
            this.LblAuthor = new System.Windows.Forms.Label();
            this.BtnCreate = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.TbxName = new System.Windows.Forms.TextBox();
            this.TbxAuthor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LblNewStory
            // 
            this.LblNewStory.AutoSize = true;
            this.LblNewStory.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNewStory.Location = new System.Drawing.Point(152, 21);
            this.LblNewStory.Name = "LblNewStory";
            this.LblNewStory.Size = new System.Drawing.Size(250, 32);
            this.LblNewStory.TabIndex = 0;
            this.LblNewStory.Text = "Create a new story";
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblName.Location = new System.Drawing.Point(93, 75);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(50, 24);
            this.LblName.TabIndex = 1;
            this.LblName.Text = "Title:";
            // 
            // LblAuthor
            // 
            this.LblAuthor.AutoSize = true;
            this.LblAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAuthor.Location = new System.Drawing.Point(72, 109);
            this.LblAuthor.Name = "LblAuthor";
            this.LblAuthor.Size = new System.Drawing.Size(71, 24);
            this.LblAuthor.TabIndex = 2;
            this.LblAuthor.Text = "Author:";
            // 
            // BtnCreate
            // 
            this.BtnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCreate.Location = new System.Drawing.Point(304, 157);
            this.BtnCreate.Name = "BtnCreate";
            this.BtnCreate.Size = new System.Drawing.Size(81, 33);
            this.BtnCreate.TabIndex = 4;
            this.BtnCreate.Text = "Create";
            this.BtnCreate.UseVisualStyleBackColor = true;
            this.BtnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancel.Location = new System.Drawing.Point(158, 157);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(81, 33);
            this.BtnCancel.TabIndex = 5;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // TbxName
            // 
            this.TbxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbxName.Location = new System.Drawing.Point(158, 71);
            this.TbxName.Name = "TbxName";
            this.TbxName.Size = new System.Drawing.Size(271, 28);
            this.TbxName.TabIndex = 6;
            this.TbxName.TextChanged += new System.EventHandler(this.TbxName_TextChanged);
            // 
            // TbxAuthor
            // 
            this.TbxAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbxAuthor.Location = new System.Drawing.Point(158, 109);
            this.TbxAuthor.Name = "TbxAuthor";
            this.TbxAuthor.Size = new System.Drawing.Size(271, 28);
            this.TbxAuthor.TabIndex = 7;
            this.TbxAuthor.TextChanged += new System.EventHandler(this.TbxAuthor_TextChanged);
            // 
            // CreateStory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 228);
            this.Controls.Add(this.TbxAuthor);
            this.Controls.Add(this.TbxName);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnCreate);
            this.Controls.Add(this.LblAuthor);
            this.Controls.Add(this.LblName);
            this.Controls.Add(this.LblNewStory);
            this.MaximizeBox = false;
            this.Name = "CreateStory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Create Story";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblNewStory;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Label LblAuthor;
        private System.Windows.Forms.Button BtnCreate;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.TextBox TbxName;
        private System.Windows.Forms.TextBox TbxAuthor;
    }
}