namespace GearscoreFinder
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
            this.findPlayer = new System.Windows.Forms.Button();
            this.nicknameOfPlayerToFind = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.serverOfPlayerToFind = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.playerList = new System.Windows.Forms.ListBox();
            this.clearPlayerList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // findPlayer
            // 
            this.findPlayer.Location = new System.Drawing.Point(168, 396);
            this.findPlayer.Name = "findPlayer";
            this.findPlayer.Size = new System.Drawing.Size(75, 23);
            this.findPlayer.TabIndex = 1;
            this.findPlayer.Text = "Найти";
            this.findPlayer.UseVisualStyleBackColor = true;
            this.findPlayer.Click += new System.EventHandler(this.FindPlayer_Click);
            // 
            // nicknameOfPlayerToFind
            // 
            this.nicknameOfPlayerToFind.Location = new System.Drawing.Point(16, 360);
            this.nicknameOfPlayerToFind.Name = "nicknameOfPlayerToFind";
            this.nicknameOfPlayerToFind.Size = new System.Drawing.Size(183, 20);
            this.nicknameOfPlayerToFind.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 342);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ник";
            // 
            // serverOfPlayerToFind
            // 
            this.serverOfPlayerToFind.FormattingEnabled = true;
            this.serverOfPlayerToFind.Location = new System.Drawing.Point(216, 359);
            this.serverOfPlayerToFind.Name = "serverOfPlayerToFind";
            this.serverOfPlayerToFind.Size = new System.Drawing.Size(179, 21);
            this.serverOfPlayerToFind.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(213, 342);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Сервер";
            // 
            // playerList
            // 
            this.playerList.FormattingEnabled = true;
            this.playerList.Location = new System.Drawing.Point(16, 13);
            this.playerList.Name = "playerList";
            this.playerList.Size = new System.Drawing.Size(379, 316);
            this.playerList.TabIndex = 6;
            // 
            // clearPlayerList
            // 
            this.clearPlayerList.Location = new System.Drawing.Point(16, 396);
            this.clearPlayerList.Name = "clearPlayerList";
            this.clearPlayerList.Size = new System.Drawing.Size(107, 23);
            this.clearPlayerList.TabIndex = 7;
            this.clearPlayerList.Text = "Очистить список";
            this.clearPlayerList.UseVisualStyleBackColor = true;
            this.clearPlayerList.Click += new System.EventHandler(this.ClearPlayerList_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 431);
            this.Controls.Add(this.clearPlayerList);
            this.Controls.Add(this.playerList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.serverOfPlayerToFind);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nicknameOfPlayerToFind);
            this.Controls.Add(this.findPlayer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Gearscore Finder";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button findPlayer;
        private System.Windows.Forms.TextBox nicknameOfPlayerToFind;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox serverOfPlayerToFind;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox playerList;
        private System.Windows.Forms.Button clearPlayerList;
    }
}

