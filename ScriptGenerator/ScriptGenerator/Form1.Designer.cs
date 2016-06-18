namespace ScriptGenerator
{
    partial class frm_ScriptGenerator
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            } 
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbp_Input = new System.Windows.Forms.TabPage();
            this.btn_Input_file = new System.Windows.Forms.Button();
            this.rtb_Input = new System.Windows.Forms.RichTextBox();
            this.tbp_Pattern = new System.Windows.Forms.TabPage();
            this.btn_SavePattern = new System.Windows.Forms.Button();
            this.lbl_Pattern = new System.Windows.Forms.Label();
            this.rtb_Pattern = new System.Windows.Forms.RichTextBox();
            this.btn_Pattern = new System.Windows.Forms.Button();
            this.tbp_Output = new System.Windows.Forms.TabPage();
            this.btn_generateScript = new System.Windows.Forms.Button();
            this.rtb_Output = new System.Windows.Forms.RichTextBox();
            this.btn_saveScript = new System.Windows.Forms.Button();
            this.openPatternFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openInputFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1.SuspendLayout();
            this.tbp_Input.SuspendLayout();
            this.tbp_Pattern.SuspendLayout();
            this.tbp_Output.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbp_Input);
            this.tabControl1.Controls.Add(this.tbp_Pattern);
            this.tabControl1.Controls.Add(this.tbp_Output);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(954, 581);
            this.tabControl1.TabIndex = 0;
            // 
            // tbp_Input
            // 
            this.tbp_Input.Controls.Add(this.btn_Input_file);
            this.tbp_Input.Controls.Add(this.rtb_Input);
            this.tbp_Input.Location = new System.Drawing.Point(4, 22);
            this.tbp_Input.Name = "tbp_Input";
            this.tbp_Input.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_Input.Size = new System.Drawing.Size(946, 555);
            this.tbp_Input.TabIndex = 0;
            this.tbp_Input.Text = "Input";
            this.tbp_Input.UseVisualStyleBackColor = true;
            // 
            // btn_Input_file
            // 
            this.btn_Input_file.Location = new System.Drawing.Point(5, 5);
            this.btn_Input_file.Name = "btn_Input_file";
            this.btn_Input_file.Size = new System.Drawing.Size(75, 23);
            this.btn_Input_file.TabIndex = 0;
            this.btn_Input_file.Text = "Input File";
            this.btn_Input_file.UseVisualStyleBackColor = true;
            this.btn_Input_file.Click += new System.EventHandler(this.btn_OpenInput_Click);
            // 
            // rtb_Input
            // 
            this.rtb_Input.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtb_Input.Location = new System.Drawing.Point(5, 35);
            this.rtb_Input.Name = "rtb_Input";
            this.rtb_Input.Size = new System.Drawing.Size(937, 517);
            this.rtb_Input.TabIndex = 1;
            this.rtb_Input.Text = "";
            this.rtb_Input.WordWrap = false;
            // 
            // tbp_Pattern
            // 
            this.tbp_Pattern.Controls.Add(this.btn_SavePattern);
            this.tbp_Pattern.Controls.Add(this.lbl_Pattern);
            this.tbp_Pattern.Controls.Add(this.rtb_Pattern);
            this.tbp_Pattern.Controls.Add(this.btn_Pattern);
            this.tbp_Pattern.Location = new System.Drawing.Point(4, 22);
            this.tbp_Pattern.Name = "tbp_Pattern";
            this.tbp_Pattern.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_Pattern.Size = new System.Drawing.Size(946, 555);
            this.tbp_Pattern.TabIndex = 1;
            this.tbp_Pattern.Text = "Pattern";
            this.tbp_Pattern.UseVisualStyleBackColor = true;
            // 
            // btn_SavePattern
            // 
            this.btn_SavePattern.Location = new System.Drawing.Point(86, 5);
            this.btn_SavePattern.Name = "btn_SavePattern";
            this.btn_SavePattern.Size = new System.Drawing.Size(79, 23);
            this.btn_SavePattern.TabIndex = 3;
            this.btn_SavePattern.Text = "Save Pattern";
            this.btn_SavePattern.UseVisualStyleBackColor = true;
            this.btn_SavePattern.Click += new System.EventHandler(this.btn_SavePattern_Click);
            // 
            // lbl_Pattern
            // 
            this.lbl_Pattern.Location = new System.Drawing.Point(170, 5);
            this.lbl_Pattern.Name = "lbl_Pattern";
            this.lbl_Pattern.Size = new System.Drawing.Size(215, 23);
            this.lbl_Pattern.TabIndex = 2;
            this.lbl_Pattern.Text = "Ersetzt wird die Zeichenfolge %%variable%%";
            this.lbl_Pattern.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rtb_Pattern
            // 
            this.rtb_Pattern.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtb_Pattern.Location = new System.Drawing.Point(5, 35);
            this.rtb_Pattern.Name = "rtb_Pattern";
            this.rtb_Pattern.Size = new System.Drawing.Size(937, 517);
            this.rtb_Pattern.TabIndex = 1;
            this.rtb_Pattern.Text = "";
            this.rtb_Pattern.WordWrap = false;
            // 
            // btn_Pattern
            // 
            this.btn_Pattern.Location = new System.Drawing.Point(5, 5);
            this.btn_Pattern.Name = "btn_Pattern";
            this.btn_Pattern.Size = new System.Drawing.Size(75, 23);
            this.btn_Pattern.TabIndex = 0;
            this.btn_Pattern.Text = "Pattern File";
            this.btn_Pattern.UseVisualStyleBackColor = true;
            this.btn_Pattern.Click += new System.EventHandler(this.btn_OpenPattern_Click_1);
            // 
            // tbp_Output
            // 
            this.tbp_Output.Controls.Add(this.btn_generateScript);
            this.tbp_Output.Controls.Add(this.rtb_Output);
            this.tbp_Output.Controls.Add(this.btn_saveScript);
            this.tbp_Output.Location = new System.Drawing.Point(4, 22);
            this.tbp_Output.Name = "tbp_Output";
            this.tbp_Output.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_Output.Size = new System.Drawing.Size(946, 555);
            this.tbp_Output.TabIndex = 2;
            this.tbp_Output.Text = "Output";
            this.tbp_Output.UseVisualStyleBackColor = true;
            // 
            // btn_generateScript
            // 
            this.btn_generateScript.Location = new System.Drawing.Point(5, 5);
            this.btn_generateScript.Name = "btn_generateScript";
            this.btn_generateScript.Size = new System.Drawing.Size(142, 23);
            this.btn_generateScript.TabIndex = 2;
            this.btn_generateScript.Text = "Generate Script";
            this.btn_generateScript.UseVisualStyleBackColor = true;
            this.btn_generateScript.Click += new System.EventHandler(this.btn_GenerateScript_Click);
            // 
            // rtb_Output
            // 
            this.rtb_Output.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtb_Output.Location = new System.Drawing.Point(5, 35);
            this.rtb_Output.Name = "rtb_Output";
            this.rtb_Output.Size = new System.Drawing.Size(937, 517);
            this.rtb_Output.TabIndex = 1;
            this.rtb_Output.Text = "";
            this.rtb_Output.WordWrap = false;
            // 
            // btn_saveScript
            // 
            this.btn_saveScript.Location = new System.Drawing.Point(153, 5);
            this.btn_saveScript.Name = "btn_saveScript";
            this.btn_saveScript.Size = new System.Drawing.Size(75, 23);
            this.btn_saveScript.TabIndex = 0;
            this.btn_saveScript.Text = "Save Script";
            this.btn_saveScript.UseVisualStyleBackColor = true;
            this.btn_saveScript.Click += new System.EventHandler(this.btn_saveScript_Click);
            // 
            // openPatternFileDialog
            // 
            this.openPatternFileDialog.Filter = "Textdateien (*.txt)|*.txt";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "Textdateien (*.txt)|*.txt";
            // 
            // openInputFileDialog
            // 
            this.openInputFileDialog.Filter = "Textdateien (*.txt)|*.txt";
            // 
            // frm_ScriptGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 581);
            this.Controls.Add(this.tabControl1);
            this.Name = "frm_ScriptGenerator";
            this.Text = "Script Generator";
            this.tabControl1.ResumeLayout(false);
            this.tbp_Input.ResumeLayout(false);
            this.tbp_Pattern.ResumeLayout(false);
            this.tbp_Output.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbp_Input;
        private System.Windows.Forms.TabPage tbp_Pattern;
        private System.Windows.Forms.TabPage tbp_Output;
        private System.Windows.Forms.RichTextBox rtb_Input;
        private System.Windows.Forms.Button btn_Input_file;
        private System.Windows.Forms.OpenFileDialog openPatternFileDialog;
        private System.Windows.Forms.RichTextBox rtb_Pattern;
        private System.Windows.Forms.Button btn_Pattern;
        private System.Windows.Forms.RichTextBox rtb_Output;
        private System.Windows.Forms.Button btn_saveScript;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Button btn_generateScript;
        private System.Windows.Forms.Label lbl_Pattern;
        private System.Windows.Forms.Button btn_SavePattern;
        private System.Windows.Forms.OpenFileDialog openInputFileDialog;
    }
}

