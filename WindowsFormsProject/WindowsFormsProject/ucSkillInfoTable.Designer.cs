﻿namespace WindowsFormsProject
{
    partial class ucSkillInfoTable
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucSkillInfoTable));
            this.pbSearch = new System.Windows.Forms.PictureBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.pbAdd = new System.Windows.Forms.PictureBox();
            this.lblPage = new System.Windows.Forms.Label();
            this.lblBack = new System.Windows.Forms.Label();
            this.lblNext = new System.Windows.Forms.Label();
            this.ucSkillInfo1 = new WindowsFormsProject.ucSkillInfo();
            this.ucSkillInfo2 = new WindowsFormsProject.ucSkillInfo();
            this.ucSkillInfo4 = new WindowsFormsProject.ucSkillInfo();
            this.ucSkillInfo3 = new WindowsFormsProject.ucSkillInfo();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // pbSearch
            // 
            this.pbSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbSearch.Image = global::WindowsFormsProject.Properties.Resources.google_web_search_16;
            this.pbSearch.Location = new System.Drawing.Point(127, 12);
            this.pbSearch.Name = "pbSearch";
            this.pbSearch.Size = new System.Drawing.Size(24, 24);
            this.pbSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbSearch.TabIndex = 41;
            this.pbSearch.TabStop = false;
            this.pbSearch.Click += new System.EventHandler(this.pbSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(157, 12);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(462, 20);
            this.txtSearch.TabIndex = 40;
            this.txtSearch.Text = "Search by First Name";
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // pbAdd
            // 
            this.pbAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbAdd.Image = ((System.Drawing.Image)(resources.GetObject("pbAdd.Image")));
            this.pbAdd.Location = new System.Drawing.Point(0, 0);
            this.pbAdd.Name = "pbAdd";
            this.pbAdd.Size = new System.Drawing.Size(24, 24);
            this.pbAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbAdd.TabIndex = 39;
            this.pbAdd.TabStop = false;
            this.pbAdd.Tag = "0";
            this.pbAdd.Click += new System.EventHandler(this.pbAdd_Click);
            // 
            // lblPage
            // 
            this.lblPage.AutoSize = true;
            this.lblPage.Location = new System.Drawing.Point(356, 328);
            this.lblPage.Name = "lblPage";
            this.lblPage.Size = new System.Drawing.Size(30, 13);
            this.lblPage.TabIndex = 38;
            this.lblPage.Tag = "1";
            this.lblPage.Text = "1/10";
            // 
            // lblBack
            // 
            this.lblBack.AutoSize = true;
            this.lblBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblBack.Location = new System.Drawing.Point(331, 328);
            this.lblBack.Name = "lblBack";
            this.lblBack.Size = new System.Drawing.Size(19, 13);
            this.lblBack.TabIndex = 37;
            this.lblBack.Text = "<<";
            this.lblBack.Click += new System.EventHandler(this.lblBack_Click);
            // 
            // lblNext
            // 
            this.lblNext.AutoSize = true;
            this.lblNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblNext.Location = new System.Drawing.Point(392, 328);
            this.lblNext.Name = "lblNext";
            this.lblNext.Size = new System.Drawing.Size(19, 13);
            this.lblNext.TabIndex = 36;
            this.lblNext.Text = ">>";
            this.lblNext.Click += new System.EventHandler(this.lblNext_Click);
            // 
            // ucSkillInfo1
            // 
            this.ucSkillInfo1.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ucSkillInfo1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ucSkillInfo1.Location = new System.Drawing.Point(127, 42);
            this.ucSkillInfo1.Name = "ucSkillInfo1";
            this.ucSkillInfo1.Size = new System.Drawing.Size(234, 134);
            this.ucSkillInfo1.TabIndex = 46;
            // 
            // ucSkillInfo2
            // 
            this.ucSkillInfo2.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ucSkillInfo2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ucSkillInfo2.Location = new System.Drawing.Point(385, 42);
            this.ucSkillInfo2.Name = "ucSkillInfo2";
            this.ucSkillInfo2.Size = new System.Drawing.Size(234, 134);
            this.ucSkillInfo2.TabIndex = 47;
            // 
            // ucSkillInfo4
            // 
            this.ucSkillInfo4.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ucSkillInfo4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ucSkillInfo4.Location = new System.Drawing.Point(385, 191);
            this.ucSkillInfo4.Name = "ucSkillInfo4";
            this.ucSkillInfo4.Size = new System.Drawing.Size(234, 134);
            this.ucSkillInfo4.TabIndex = 48;
            // 
            // ucSkillInfo3
            // 
            this.ucSkillInfo3.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ucSkillInfo3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ucSkillInfo3.Location = new System.Drawing.Point(127, 191);
            this.ucSkillInfo3.Name = "ucSkillInfo3";
            this.ucSkillInfo3.Size = new System.Drawing.Size(234, 134);
            this.ucSkillInfo3.TabIndex = 49;
            // 
            // ucSkillInfoTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ucSkillInfo3);
            this.Controls.Add(this.ucSkillInfo4);
            this.Controls.Add(this.ucSkillInfo2);
            this.Controls.Add(this.ucSkillInfo1);
            this.Controls.Add(this.pbSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.pbAdd);
            this.Controls.Add(this.lblPage);
            this.Controls.Add(this.lblBack);
            this.Controls.Add(this.lblNext);
            this.Name = "ucSkillInfoTable";
            this.Size = new System.Drawing.Size(756, 369);
            this.Load += new System.EventHandler(this.ucSkillInfoTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pbSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.PictureBox pbAdd;
        private System.Windows.Forms.Label lblPage;
        private System.Windows.Forms.Label lblBack;
        private System.Windows.Forms.Label lblNext;
        private ucSkillInfo ucSkillInfo1;
        private ucSkillInfo ucSkillInfo2;
        private ucSkillInfo ucSkillInfo4;
        private ucSkillInfo ucSkillInfo3;
    }
}
