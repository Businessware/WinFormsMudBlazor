﻿namespace $safeprojectname$
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            BlazorWebView = new Microsoft.AspNetCore.Components.WebView.WindowsForms.BlazorWebView();
            SuspendLayout();
            // 
            // BlazorWebView
            // 
            BlazorWebView.Dock = DockStyle.Fill;
            BlazorWebView.Location = new Point(0, 0);
            BlazorWebView.Name = "BlazorWebView";
            BlazorWebView.Size = new Size(984, 601);
            BlazorWebView.TabIndex = 0;
            BlazorWebView.Text = "BlazorWebView";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 601);
            Controls.Add(BlazorWebView);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "$safeprojectname$";
            ResumeLayout(false);
        }

        #endregion

        public Microsoft.AspNetCore.Components.WebView.WindowsForms.BlazorWebView BlazorWebView;
    }
}
