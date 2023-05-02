
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.groupBoxSpinnerParameters = new System.Windows.Forms.GroupBox();
            this.labelParameterRounding = new System.Windows.Forms.Label();
            this.textBoxRounding = new System.Windows.Forms.TextBox();
            this.labelRounding = new System.Windows.Forms.Label();
            this.labelParameterOuterRings = new System.Windows.Forms.Label();
            this.labelParameterThickness = new System.Windows.Forms.Label();
            this.textBoxDiameter = new System.Windows.Forms.TextBox();
            this.textBoxThickness = new System.Windows.Forms.TextBox();
            this.labelThickness = new System.Windows.Forms.Label();
            this.labelDiameter = new System.Windows.Forms.Label();
            this.labelParameterLength = new System.Windows.Forms.Label();
            this.labelParameterInnerRings = new System.Windows.Forms.Label();
            this.labelParameterDiameter = new System.Windows.Forms.Label();
            this.textBoxOuterRings = new System.Windows.Forms.TextBox();
            this.labelOuterRings = new System.Windows.Forms.Label();
            this.textBoxLength = new System.Windows.Forms.TextBox();
            this.labelLength = new System.Windows.Forms.Label();
            this.textBoxInnerRings = new System.Windows.Forms.TextBox();
            this.labelInnerRings = new System.Windows.Forms.Label();
            this.groupBoxDefaultParameters = new System.Windows.Forms.GroupBox();
            this.buttonMaximum = new System.Windows.Forms.Button();
            this.buttonAverage = new System.Windows.Forms.Button();
            this.buttonMimimum = new System.Windows.Forms.Button();
            this.buttonBuild = new System.Windows.Forms.Button();
            this.pictureBoxSpinner = new System.Windows.Forms.PictureBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBoxSpinnerParameters.SuspendLayout();
            this.groupBoxDefaultParameters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSpinner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxSpinnerParameters
            // 
            this.groupBoxSpinnerParameters.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxSpinnerParameters.Controls.Add(this.labelParameterRounding);
            this.groupBoxSpinnerParameters.Controls.Add(this.textBoxRounding);
            this.groupBoxSpinnerParameters.Controls.Add(this.labelRounding);
            this.groupBoxSpinnerParameters.Controls.Add(this.labelParameterOuterRings);
            this.groupBoxSpinnerParameters.Controls.Add(this.labelParameterThickness);
            this.groupBoxSpinnerParameters.Controls.Add(this.textBoxDiameter);
            this.groupBoxSpinnerParameters.Controls.Add(this.textBoxThickness);
            this.groupBoxSpinnerParameters.Controls.Add(this.labelThickness);
            this.groupBoxSpinnerParameters.Controls.Add(this.labelDiameter);
            this.groupBoxSpinnerParameters.Controls.Add(this.labelParameterLength);
            this.groupBoxSpinnerParameters.Controls.Add(this.labelParameterInnerRings);
            this.groupBoxSpinnerParameters.Controls.Add(this.labelParameterDiameter);
            this.groupBoxSpinnerParameters.Controls.Add(this.textBoxOuterRings);
            this.groupBoxSpinnerParameters.Controls.Add(this.labelOuterRings);
            this.groupBoxSpinnerParameters.Controls.Add(this.textBoxLength);
            this.groupBoxSpinnerParameters.Controls.Add(this.labelLength);
            this.groupBoxSpinnerParameters.Controls.Add(this.textBoxInnerRings);
            this.groupBoxSpinnerParameters.Controls.Add(this.labelInnerRings);
            this.groupBoxSpinnerParameters.Location = new System.Drawing.Point(12, 12);
            this.groupBoxSpinnerParameters.Name = "groupBoxSpinnerParameters";
            this.groupBoxSpinnerParameters.Size = new System.Drawing.Size(262, 436);
            this.groupBoxSpinnerParameters.TabIndex = 1;
            this.groupBoxSpinnerParameters.TabStop = false;
            this.groupBoxSpinnerParameters.Text = "Spinner Parameters";
            // 
            // labelParameterRounding
            // 
            this.labelParameterRounding.AutoSize = true;
            this.labelParameterRounding.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelParameterRounding.Location = new System.Drawing.Point(6, 402);
            this.labelParameterRounding.Name = "labelParameterRounding";
            this.labelParameterRounding.Size = new System.Drawing.Size(179, 17);
            this.labelParameterRounding.TabIndex = 17;
            this.labelParameterRounding.Text = "(min - 0.5 mm, max - 2 mm)";
            // 
            // textBoxRounding
            // 
            this.textBoxRounding.Location = new System.Drawing.Point(6, 377);
            this.textBoxRounding.MaxLength = 5;
            this.textBoxRounding.Name = "textBoxRounding";
            this.textBoxRounding.Size = new System.Drawing.Size(100, 22);
            this.textBoxRounding.TabIndex = 16;
            this.textBoxRounding.Click += new System.EventHandler(this.ClearField);
            this.textBoxRounding.TextChanged += new System.EventHandler(this.SetParameter);
            // 
            // labelRounding
            // 
            this.labelRounding.AutoSize = true;
            this.labelRounding.Location = new System.Drawing.Point(3, 357);
            this.labelRounding.Name = "labelRounding";
            this.labelRounding.Size = new System.Drawing.Size(91, 17);
            this.labelRounding.TabIndex = 15;
            this.labelRounding.Text = "Rounding - Z";
            // 
            // labelParameterOuterRings
            // 
            this.labelParameterOuterRings.AutoSize = true;
            this.labelParameterOuterRings.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelParameterOuterRings.Location = new System.Drawing.Point(6, 269);
            this.labelParameterOuterRings.Name = "labelParameterOuterRings";
            this.labelParameterOuterRings.Size = new System.Drawing.Size(183, 17);
            this.labelParameterOuterRings.TabIndex = 14;
            this.labelParameterOuterRings.Text = "(min - 20 mm, max - 35 mm)";
            // 
            // labelParameterThickness
            // 
            this.labelParameterThickness.AutoSize = true;
            this.labelParameterThickness.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelParameterThickness.Location = new System.Drawing.Point(3, 339);
            this.labelParameterThickness.Name = "labelParameterThickness";
            this.labelParameterThickness.Size = new System.Drawing.Size(183, 17);
            this.labelParameterThickness.TabIndex = 11;
            this.labelParameterThickness.Text = "(min - 10 mm, max - 30 mm)";
            // 
            // textBoxDiameter
            // 
            this.textBoxDiameter.Location = new System.Drawing.Point(6, 109);
            this.textBoxDiameter.MaxLength = 5;
            this.textBoxDiameter.Name = "textBoxDiameter";
            this.textBoxDiameter.Size = new System.Drawing.Size(100, 22);
            this.textBoxDiameter.TabIndex = 1;
            this.textBoxDiameter.Click += new System.EventHandler(this.ClearField);
            this.textBoxDiameter.TextChanged += new System.EventHandler(this.SetParameter);
            // 
            // textBoxThickness
            // 
            this.textBoxThickness.Location = new System.Drawing.Point(6, 314);
            this.textBoxThickness.MaxLength = 5;
            this.textBoxThickness.Name = "textBoxThickness";
            this.textBoxThickness.Size = new System.Drawing.Size(100, 22);
            this.textBoxThickness.TabIndex = 3;
            this.textBoxThickness.Click += new System.EventHandler(this.ClearField);
            this.textBoxThickness.TextChanged += new System.EventHandler(this.SetParameter);
            // 
            // labelThickness
            // 
            this.labelThickness.AutoSize = true;
            this.labelThickness.Location = new System.Drawing.Point(3, 294);
            this.labelThickness.Name = "labelThickness";
            this.labelThickness.Size = new System.Drawing.Size(94, 17);
            this.labelThickness.TabIndex = 2;
            this.labelThickness.Text = "Thickness - C";
            // 
            // labelDiameter
            // 
            this.labelDiameter.AutoSize = true;
            this.labelDiameter.Location = new System.Drawing.Point(3, 89);
            this.labelDiameter.Name = "labelDiameter";
            this.labelDiameter.Size = new System.Drawing.Size(88, 17);
            this.labelDiameter.TabIndex = 0;
            this.labelDiameter.Text = "Diameter - D";
            // 
            // labelParameterLength
            // 
            this.labelParameterLength.AutoSize = true;
            this.labelParameterLength.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelParameterLength.Location = new System.Drawing.Point(6, 201);
            this.labelParameterLength.Name = "labelParameterLength";
            this.labelParameterLength.Size = new System.Drawing.Size(183, 17);
            this.labelParameterLength.TabIndex = 13;
            this.labelParameterLength.Text = "(min - 45 mm, max - 90 mm)";
            // 
            // labelParameterInnerRings
            // 
            this.labelParameterInnerRings.AutoSize = true;
            this.labelParameterInnerRings.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelParameterInnerRings.Location = new System.Drawing.Point(3, 68);
            this.labelParameterInnerRings.Name = "labelParameterInnerRings";
            this.labelParameterInnerRings.Size = new System.Drawing.Size(183, 17);
            this.labelParameterInnerRings.TabIndex = 12;
            this.labelParameterInnerRings.Text = "(min - 30 mm, max - 60 mm)";
            // 
            // labelParameterDiameter
            // 
            this.labelParameterDiameter.AutoSize = true;
            this.labelParameterDiameter.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelParameterDiameter.Location = new System.Drawing.Point(6, 134);
            this.labelParameterDiameter.Name = "labelParameterDiameter";
            this.labelParameterDiameter.Size = new System.Drawing.Size(183, 17);
            this.labelParameterDiameter.TabIndex = 10;
            this.labelParameterDiameter.Text = "(min - 21 mm, max - 42 mm)";
            // 
            // textBoxOuterRings
            // 
            this.textBoxOuterRings.Location = new System.Drawing.Point(6, 244);
            this.textBoxOuterRings.MaxLength = 5;
            this.textBoxOuterRings.Name = "textBoxOuterRings";
            this.textBoxOuterRings.Size = new System.Drawing.Size(100, 22);
            this.textBoxOuterRings.TabIndex = 9;
            this.textBoxOuterRings.Click += new System.EventHandler(this.ClearField);
            this.textBoxOuterRings.TextChanged += new System.EventHandler(this.SetParameter);
            // 
            // labelOuterRings
            // 
            this.labelOuterRings.AutoSize = true;
            this.labelOuterRings.Location = new System.Drawing.Point(3, 224);
            this.labelOuterRings.Name = "labelOuterRings";
            this.labelOuterRings.Size = new System.Drawing.Size(163, 17);
            this.labelOuterRings.TabIndex = 8;
            this.labelOuterRings.Text = "Radius of outer rings - R";
            // 
            // textBoxLength
            // 
            this.textBoxLength.Location = new System.Drawing.Point(6, 176);
            this.textBoxLength.MaxLength = 5;
            this.textBoxLength.Name = "textBoxLength";
            this.textBoxLength.Size = new System.Drawing.Size(100, 22);
            this.textBoxLength.TabIndex = 7;
            this.textBoxLength.Click += new System.EventHandler(this.ClearField);
            this.textBoxLength.TextChanged += new System.EventHandler(this.SetParameter);
            // 
            // labelLength
            // 
            this.labelLength.AutoSize = true;
            this.labelLength.Location = new System.Drawing.Point(3, 156);
            this.labelLength.Name = "labelLength";
            this.labelLength.Size = new System.Drawing.Size(74, 17);
            this.labelLength.TabIndex = 6;
            this.labelLength.Text = "Length - А";
            // 
            // textBoxInnerRings
            // 
            this.textBoxInnerRings.Location = new System.Drawing.Point(6, 43);
            this.textBoxInnerRings.MaxLength = 5;
            this.textBoxInnerRings.Name = "textBoxInnerRings";
            this.textBoxInnerRings.Size = new System.Drawing.Size(100, 22);
            this.textBoxInnerRings.TabIndex = 5;
            this.textBoxInnerRings.Click += new System.EventHandler(this.ClearField);
            this.textBoxInnerRings.TextChanged += new System.EventHandler(this.SetParameter);
            // 
            // labelInnerRings
            // 
            this.labelInnerRings.AutoSize = true;
            this.labelInnerRings.Location = new System.Drawing.Point(2, 23);
            this.labelInnerRings.Name = "labelInnerRings";
            this.labelInnerRings.Size = new System.Drawing.Size(152, 17);
            this.labelInnerRings.TabIndex = 4;
            this.labelInnerRings.Text = "Diameter inner rings - I";
            // 
            // groupBoxDefaultParameters
            // 
            this.groupBoxDefaultParameters.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxDefaultParameters.Controls.Add(this.buttonMaximum);
            this.groupBoxDefaultParameters.Controls.Add(this.buttonAverage);
            this.groupBoxDefaultParameters.Controls.Add(this.buttonMimimum);
            this.groupBoxDefaultParameters.Location = new System.Drawing.Point(12, 458);
            this.groupBoxDefaultParameters.Name = "groupBoxDefaultParameters";
            this.groupBoxDefaultParameters.Size = new System.Drawing.Size(262, 159);
            this.groupBoxDefaultParameters.TabIndex = 15;
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
            this.buttonMaximum.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SetDefaultParameters);
            // 
            // buttonAverage
            // 
            this.buttonAverage.Location = new System.Drawing.Point(9, 71);
            this.buttonAverage.Name = "buttonAverage";
            this.buttonAverage.Size = new System.Drawing.Size(238, 37);
            this.buttonAverage.TabIndex = 1;
            this.buttonAverage.Text = "Average";
            this.buttonAverage.UseVisualStyleBackColor = true;
            this.buttonAverage.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SetDefaultParameters);
            // 
            // buttonMimimum
            // 
            this.buttonMimimum.Location = new System.Drawing.Point(9, 30);
            this.buttonMimimum.Name = "buttonMimimum";
            this.buttonMimimum.Size = new System.Drawing.Size(238, 35);
            this.buttonMimimum.TabIndex = 0;
            this.buttonMimimum.Text = "Minimum";
            this.buttonMimimum.UseVisualStyleBackColor = true;
            this.buttonMimimum.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SetDefaultParameters);
            // 
            // buttonBuild
            // 
            this.buttonBuild.Location = new System.Drawing.Point(508, 550);
            this.buttonBuild.Name = "buttonBuild";
            this.buttonBuild.Size = new System.Drawing.Size(355, 57);
            this.buttonBuild.TabIndex = 4;
            this.buttonBuild.Text = "Build";
            this.buttonBuild.UseVisualStyleBackColor = true;
            this.buttonBuild.Click += new System.EventHandler(this.Build);
            // 
            // pictureBoxSpinner
            // 
            this.pictureBoxSpinner.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSpinner.Image")));
            this.pictureBoxSpinner.Location = new System.Drawing.Point(280, 12);
            this.pictureBoxSpinner.Name = "pictureBoxSpinner";
            this.pictureBoxSpinner.Size = new System.Drawing.Size(800, 510);
            this.pictureBoxSpinner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSpinner.TabIndex = 16;
            this.pictureBoxSpinner.TabStop = false;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 629);
            this.Controls.Add(this.pictureBoxSpinner);
            this.Controls.Add(this.buttonBuild);
            this.Controls.Add(this.groupBoxDefaultParameters);
            this.Controls.Add(this.groupBoxSpinnerParameters);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Spinner Plugin";
            this.Load += new System.EventHandler(this.SetDefaultParameters);
            this.groupBoxSpinnerParameters.ResumeLayout(false);
            this.groupBoxSpinnerParameters.PerformLayout();
            this.groupBoxDefaultParameters.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSpinner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxSpinnerParameters;
        private System.Windows.Forms.Label labelParameterOuterRings;
        private System.Windows.Forms.Label labelParameterLength;
        private System.Windows.Forms.Label labelParameterInnerRings;
        private System.Windows.Forms.Label labelParameterThickness;
        private System.Windows.Forms.Label labelParameterDiameter;
        private System.Windows.Forms.TextBox textBoxOuterRings;
        private System.Windows.Forms.Label labelOuterRings;
        private System.Windows.Forms.TextBox textBoxLength;
        private System.Windows.Forms.Label labelLength;
        private System.Windows.Forms.TextBox textBoxInnerRings;
        private System.Windows.Forms.Label labelInnerRings;
        private System.Windows.Forms.TextBox textBoxThickness;
        private System.Windows.Forms.Label labelThickness;
        private System.Windows.Forms.TextBox textBoxDiameter;
        private System.Windows.Forms.Label labelDiameter;
        private System.Windows.Forms.GroupBox groupBoxDefaultParameters;
        private System.Windows.Forms.Button buttonMaximum;
        private System.Windows.Forms.Button buttonAverage;
        private System.Windows.Forms.Button buttonMimimum;
        private System.Windows.Forms.Button buttonBuild;
        private System.Windows.Forms.PictureBox pictureBoxSpinner;
        private System.Windows.Forms.Label labelParameterRounding;
        private System.Windows.Forms.TextBox textBoxRounding;
        private System.Windows.Forms.Label labelRounding;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}