
namespace SpinnerPlugin.View
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.splitContainerSpinnerPlugin = new System.Windows.Forms.SplitContainer();
            this.groupBoxDefaultParameters = new System.Windows.Forms.GroupBox();
            this.buttonMaximum = new System.Windows.Forms.Button();
            this.buttonAverage = new System.Windows.Forms.Button();
            this.buttonMimimum = new System.Windows.Forms.Button();
            this.groupBoxSpinnerParameters = new System.Windows.Forms.GroupBox();
            this.labelParameterWidth = new System.Windows.Forms.Label();
            this.labelParameterLength = new System.Windows.Forms.Label();
            this.labelParameterRadius = new System.Windows.Forms.Label();
            this.labelParameterThickness = new System.Windows.Forms.Label();
            this.labelParameterDiameter = new System.Windows.Forms.Label();
            this.textBoxWidth = new System.Windows.Forms.TextBox();
            this.labelWidth = new System.Windows.Forms.Label();
            this.textBoxLength = new System.Windows.Forms.TextBox();
            this.labelLength = new System.Windows.Forms.Label();
            this.textBoxRadius = new System.Windows.Forms.TextBox();
            this.labelRadius = new System.Windows.Forms.Label();
            this.textBoxThickness = new System.Windows.Forms.TextBox();
            this.labelThickness = new System.Windows.Forms.Label();
            this.textBoxDiameter = new System.Windows.Forms.TextBox();
            this.labelDiameter = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonBuild = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerSpinnerPlugin)).BeginInit();
            this.splitContainerSpinnerPlugin.Panel1.SuspendLayout();
            this.splitContainerSpinnerPlugin.Panel2.SuspendLayout();
            this.splitContainerSpinnerPlugin.SuspendLayout();
            this.groupBoxDefaultParameters.SuspendLayout();
            this.groupBoxSpinnerParameters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerSpinnerPlugin
            // 
            this.splitContainerSpinnerPlugin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerSpinnerPlugin.Location = new System.Drawing.Point(0, 0);
            this.splitContainerSpinnerPlugin.Name = "splitContainerSpinnerPlugin";
            // 
            // splitContainerSpinnerPlugin.Panel1
            // 
            this.splitContainerSpinnerPlugin.Panel1.Controls.Add(this.groupBoxDefaultParameters);
            this.splitContainerSpinnerPlugin.Panel1.Controls.Add(this.groupBoxSpinnerParameters);
            // 
            // splitContainerSpinnerPlugin.Panel2
            // 
            this.splitContainerSpinnerPlugin.Panel2.Controls.Add(this.panel1);
            this.splitContainerSpinnerPlugin.Panel2.Controls.Add(this.buttonBuild);
            this.splitContainerSpinnerPlugin.Size = new System.Drawing.Size(936, 601);
            this.splitContainerSpinnerPlugin.SplitterDistance = 262;
            this.splitContainerSpinnerPlugin.TabIndex = 0;
            // 
            // groupBoxDefaultParameters
            // 
            this.groupBoxDefaultParameters.Controls.Add(this.buttonMaximum);
            this.groupBoxDefaultParameters.Controls.Add(this.buttonAverage);
            this.groupBoxDefaultParameters.Controls.Add(this.buttonMimimum);
            this.groupBoxDefaultParameters.Location = new System.Drawing.Point(3, 426);
            this.groupBoxDefaultParameters.Name = "groupBoxDefaultParameters";
            this.groupBoxDefaultParameters.Size = new System.Drawing.Size(255, 172);
            this.groupBoxDefaultParameters.TabIndex = 1;
            this.groupBoxDefaultParameters.TabStop = false;
            this.groupBoxDefaultParameters.Text = "Default parameters";
            // 
            // buttonMaximum
            // 
            this.buttonMaximum.Location = new System.Drawing.Point(9, 114);
            this.buttonMaximum.Name = "buttonMaximum";
            this.buttonMaximum.Size = new System.Drawing.Size(238, 35);
            this.buttonMaximum.TabIndex = 2;
            this.buttonMaximum.Text = "Maximum";
            this.buttonMaximum.UseVisualStyleBackColor = true;
            // 
            // buttonAverage
            // 
            this.buttonAverage.Location = new System.Drawing.Point(9, 71);
            this.buttonAverage.Name = "buttonAverage";
            this.buttonAverage.Size = new System.Drawing.Size(238, 37);
            this.buttonAverage.TabIndex = 1;
            this.buttonAverage.Text = "Average";
            this.buttonAverage.UseVisualStyleBackColor = true;
            // 
            // buttonMimimum
            // 
            this.buttonMimimum.Location = new System.Drawing.Point(9, 30);
            this.buttonMimimum.Name = "buttonMimimum";
            this.buttonMimimum.Size = new System.Drawing.Size(238, 35);
            this.buttonMimimum.TabIndex = 0;
            this.buttonMimimum.Text = "Minimum";
            this.buttonMimimum.UseVisualStyleBackColor = true;
            // 
            // groupBoxSpinnerParameters
            // 
            this.groupBoxSpinnerParameters.Controls.Add(this.labelParameterWidth);
            this.groupBoxSpinnerParameters.Controls.Add(this.labelParameterLength);
            this.groupBoxSpinnerParameters.Controls.Add(this.labelParameterRadius);
            this.groupBoxSpinnerParameters.Controls.Add(this.labelParameterThickness);
            this.groupBoxSpinnerParameters.Controls.Add(this.labelParameterDiameter);
            this.groupBoxSpinnerParameters.Controls.Add(this.textBoxWidth);
            this.groupBoxSpinnerParameters.Controls.Add(this.labelWidth);
            this.groupBoxSpinnerParameters.Controls.Add(this.textBoxLength);
            this.groupBoxSpinnerParameters.Controls.Add(this.labelLength);
            this.groupBoxSpinnerParameters.Controls.Add(this.textBoxRadius);
            this.groupBoxSpinnerParameters.Controls.Add(this.labelRadius);
            this.groupBoxSpinnerParameters.Controls.Add(this.textBoxThickness);
            this.groupBoxSpinnerParameters.Controls.Add(this.labelThickness);
            this.groupBoxSpinnerParameters.Controls.Add(this.textBoxDiameter);
            this.groupBoxSpinnerParameters.Controls.Add(this.labelDiameter);
            this.groupBoxSpinnerParameters.Location = new System.Drawing.Point(3, 3);
            this.groupBoxSpinnerParameters.Name = "groupBoxSpinnerParameters";
            this.groupBoxSpinnerParameters.Size = new System.Drawing.Size(255, 417);
            this.groupBoxSpinnerParameters.TabIndex = 0;
            this.groupBoxSpinnerParameters.TabStop = false;
            this.groupBoxSpinnerParameters.Text = "Spinner Parameters";
            // 
            // labelParameterWidth
            // 
            this.labelParameterWidth.AutoSize = true;
            this.labelParameterWidth.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelParameterWidth.Location = new System.Drawing.Point(6, 364);
            this.labelParameterWidth.Name = "labelParameterWidth";
            this.labelParameterWidth.Size = new System.Drawing.Size(223, 17);
            this.labelParameterWidth.TabIndex = 14;
            this.labelParameterWidth.Text = "(min - 86.25 mm, max - 287.5 mm)";
            // 
            // labelParameterLength
            // 
            this.labelParameterLength.AutoSize = true;
            this.labelParameterLength.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelParameterLength.Location = new System.Drawing.Point(6, 290);
            this.labelParameterLength.Name = "labelParameterLength";
            this.labelParameterLength.Size = new System.Drawing.Size(191, 17);
            this.labelParameterLength.TabIndex = 13;
            this.labelParameterLength.Text = "(min - 75 mm, max - 250 mm)";
            // 
            // labelParameterRadius
            // 
            this.labelParameterRadius.AutoSize = true;
            this.labelParameterRadius.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelParameterRadius.Location = new System.Drawing.Point(4, 217);
            this.labelParameterRadius.Name = "labelParameterRadius";
            this.labelParameterRadius.Size = new System.Drawing.Size(183, 17);
            this.labelParameterRadius.TabIndex = 12;
            this.labelParameterRadius.Text = "(min - 20 mm, max - 60 mm)";
            // 
            // labelParameterThickness
            // 
            this.labelParameterThickness.AutoSize = true;
            this.labelParameterThickness.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelParameterThickness.Location = new System.Drawing.Point(3, 148);
            this.labelParameterThickness.Name = "labelParameterThickness";
            this.labelParameterThickness.Size = new System.Drawing.Size(183, 17);
            this.labelParameterThickness.TabIndex = 11;
            this.labelParameterThickness.Text = "(min - 10 mm, max - 50 mm)";
            // 
            // labelParameterDiameter
            // 
            this.labelParameterDiameter.AutoSize = true;
            this.labelParameterDiameter.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelParameterDiameter.Location = new System.Drawing.Point(6, 77);
            this.labelParameterDiameter.Name = "labelParameterDiameter";
            this.labelParameterDiameter.Size = new System.Drawing.Size(191, 17);
            this.labelParameterDiameter.TabIndex = 10;
            this.labelParameterDiameter.Text = "(min - 30 mm, max - 100 mm)";
            // 
            // textBoxWidth
            // 
            this.textBoxWidth.Location = new System.Drawing.Point(6, 339);
            this.textBoxWidth.MaxLength = 5;
            this.textBoxWidth.Name = "textBoxWidth";
            this.textBoxWidth.Size = new System.Drawing.Size(100, 22);
            this.textBoxWidth.TabIndex = 9;
            // 
            // labelWidth
            // 
            this.labelWidth.AutoSize = true;
            this.labelWidth.Location = new System.Drawing.Point(9, 319);
            this.labelWidth.Name = "labelWidth";
            this.labelWidth.Size = new System.Drawing.Size(44, 17);
            this.labelWidth.TabIndex = 8;
            this.labelWidth.Text = "Width";
            // 
            // textBoxLength
            // 
            this.textBoxLength.Location = new System.Drawing.Point(6, 265);
            this.textBoxLength.MaxLength = 3;
            this.textBoxLength.Name = "textBoxLength";
            this.textBoxLength.Size = new System.Drawing.Size(100, 22);
            this.textBoxLength.TabIndex = 7;
            // 
            // labelLength
            // 
            this.labelLength.AutoSize = true;
            this.labelLength.Location = new System.Drawing.Point(9, 245);
            this.labelLength.Name = "labelLength";
            this.labelLength.Size = new System.Drawing.Size(52, 17);
            this.labelLength.TabIndex = 6;
            this.labelLength.Text = "Length";
            // 
            // textBoxRadius
            // 
            this.textBoxRadius.Location = new System.Drawing.Point(7, 192);
            this.textBoxRadius.MaxLength = 3;
            this.textBoxRadius.Name = "textBoxRadius";
            this.textBoxRadius.Size = new System.Drawing.Size(100, 22);
            this.textBoxRadius.TabIndex = 5;
            // 
            // labelRadius
            // 
            this.labelRadius.AutoSize = true;
            this.labelRadius.Location = new System.Drawing.Point(9, 172);
            this.labelRadius.Name = "labelRadius";
            this.labelRadius.Size = new System.Drawing.Size(52, 17);
            this.labelRadius.TabIndex = 4;
            this.labelRadius.Text = "Radius";
            // 
            // textBoxThickness
            // 
            this.textBoxThickness.Location = new System.Drawing.Point(6, 123);
            this.textBoxThickness.MaxLength = 3;
            this.textBoxThickness.Name = "textBoxThickness";
            this.textBoxThickness.Size = new System.Drawing.Size(100, 22);
            this.textBoxThickness.TabIndex = 3;
            // 
            // labelThickness
            // 
            this.labelThickness.AutoSize = true;
            this.labelThickness.Location = new System.Drawing.Point(9, 103);
            this.labelThickness.Name = "labelThickness";
            this.labelThickness.Size = new System.Drawing.Size(72, 17);
            this.labelThickness.TabIndex = 2;
            this.labelThickness.Text = "Thickness";
            // 
            // textBoxDiameter
            // 
            this.textBoxDiameter.Location = new System.Drawing.Point(6, 52);
            this.textBoxDiameter.MaxLength = 3;
            this.textBoxDiameter.Name = "textBoxDiameter";
            this.textBoxDiameter.Size = new System.Drawing.Size(100, 22);
            this.textBoxDiameter.TabIndex = 1;
            this.textBoxDiameter.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxDiameter_Validating);
            // 
            // labelDiameter
            // 
            this.labelDiameter.AutoSize = true;
            this.labelDiameter.Location = new System.Drawing.Point(9, 32);
            this.labelDiameter.Name = "labelDiameter";
            this.labelDiameter.Size = new System.Drawing.Size(65, 17);
            this.labelDiameter.TabIndex = 0;
            this.labelDiameter.Text = "Diameter";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(19, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(623, 493);
            this.panel1.TabIndex = 4;
            // 
            // buttonBuild
            // 
            this.buttonBuild.Location = new System.Drawing.Point(182, 520);
            this.buttonBuild.Name = "buttonBuild";
            this.buttonBuild.Size = new System.Drawing.Size(355, 57);
            this.buttonBuild.TabIndex = 3;
            this.buttonBuild.Text = "Build";
            this.buttonBuild.UseVisualStyleBackColor = true;
            this.buttonBuild.Click += new System.EventHandler(this.buttonBuild_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 601);
            this.Controls.Add(this.splitContainerSpinnerPlugin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Spinner Plugin";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.splitContainerSpinnerPlugin.Panel1.ResumeLayout(false);
            this.splitContainerSpinnerPlugin.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerSpinnerPlugin)).EndInit();
            this.splitContainerSpinnerPlugin.ResumeLayout(false);
            this.groupBoxDefaultParameters.ResumeLayout(false);
            this.groupBoxSpinnerParameters.ResumeLayout(false);
            this.groupBoxSpinnerParameters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainerSpinnerPlugin;
        private System.Windows.Forms.GroupBox groupBoxDefaultParameters;
        private System.Windows.Forms.Button buttonMaximum;
        private System.Windows.Forms.Button buttonAverage;
        private System.Windows.Forms.Button buttonMimimum;
        private System.Windows.Forms.GroupBox groupBoxSpinnerParameters;
        private System.Windows.Forms.TextBox textBoxWidth;
        private System.Windows.Forms.Label labelWidth;
        private System.Windows.Forms.TextBox textBoxLength;
        private System.Windows.Forms.Label labelLength;
        private System.Windows.Forms.TextBox textBoxRadius;
        private System.Windows.Forms.Label labelRadius;
        private System.Windows.Forms.TextBox textBoxThickness;
        private System.Windows.Forms.Label labelThickness;
        private System.Windows.Forms.TextBox textBoxDiameter;
        private System.Windows.Forms.Label labelDiameter;
        private System.Windows.Forms.Button buttonBuild;
        private System.Windows.Forms.Label labelParameterWidth;
        private System.Windows.Forms.Label labelParameterLength;
        private System.Windows.Forms.Label labelParameterRadius;
        private System.Windows.Forms.Label labelParameterThickness;
        private System.Windows.Forms.Label labelParameterDiameter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}