<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConversion
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.lblEnterandChoose = New System.Windows.Forms.Label()
        Me.btnConvert = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.radInchestoMeters = New System.Windows.Forms.RadioButton()
        Me.radMeterstoInches = New System.Windows.Forms.RadioButton()
        Me.txtEnterValue = New System.Windows.Forms.TextBox()
        Me.lblMeasurementOutput = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.grpConvertMeasurement = New System.Windows.Forms.GroupBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpConvertMeasurement.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.Location = New System.Drawing.Point(405, 42)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(246, 37)
        Me.lblHeading.TabIndex = 0
        Me.lblHeading.Text = "Converter App "
        '
        'lblEnterandChoose
        '
        Me.lblEnterandChoose.AutoSize = True
        Me.lblEnterandChoose.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnterandChoose.Location = New System.Drawing.Point(328, 107)
        Me.lblEnterandChoose.Name = "lblEnterandChoose"
        Me.lblEnterandChoose.Size = New System.Drawing.Size(209, 50)
        Me.lblEnterandChoose.TabIndex = 1
        Me.lblEnterandChoose.Text = "Enter a Value and " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Choose Conversion "
        '
        'btnConvert
        '
        Me.btnConvert.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConvert.Location = New System.Drawing.Point(103, 371)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(135, 41)
        Me.btnConvert.TabIndex = 3
        Me.btnConvert.Text = "Convert "
        Me.btnConvert.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(333, 371)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(135, 41)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "Clear "
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(560, 371)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(135, 41)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit "
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'radInchestoMeters
        '
        Me.radInchestoMeters.AutoSize = True
        Me.radInchestoMeters.Location = New System.Drawing.Point(19, 25)
        Me.radInchestoMeters.Name = "radInchestoMeters"
        Me.radInchestoMeters.Size = New System.Drawing.Size(174, 24)
        Me.radInchestoMeters.TabIndex = 6
        Me.radInchestoMeters.TabStop = True
        Me.radInchestoMeters.Text = "Inches to Meters "
        Me.radInchestoMeters.UseVisualStyleBackColor = True
        '
        'radMeterstoInches
        '
        Me.radMeterstoInches.AutoSize = True
        Me.radMeterstoInches.Location = New System.Drawing.Point(19, 70)
        Me.radMeterstoInches.Name = "radMeterstoInches"
        Me.radMeterstoInches.Size = New System.Drawing.Size(174, 24)
        Me.radMeterstoInches.TabIndex = 7
        Me.radMeterstoInches.TabStop = True
        Me.radMeterstoInches.Text = "Meters to Inches "
        Me.radMeterstoInches.UseVisualStyleBackColor = True
        '
        'txtEnterValue
        '
        Me.txtEnterValue.Location = New System.Drawing.Point(586, 108)
        Me.txtEnterValue.Name = "txtEnterValue"
        Me.txtEnterValue.Size = New System.Drawing.Size(65, 26)
        Me.txtEnterValue.TabIndex = 8
        '
        'lblMeasurementOutput
        '
        Me.lblMeasurementOutput.AutoSize = True
        Me.lblMeasurementOutput.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMeasurementOutput.Location = New System.Drawing.Point(388, 322)
        Me.lblMeasurementOutput.Name = "lblMeasurementOutput"
        Me.lblMeasurementOutput.Size = New System.Drawing.Size(246, 25)
        Me.lblMeasurementOutput.TabIndex = 9
        Me.lblMeasurementOutput.Text = "XX meters is XX inches "
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Midterm.My.Resources.Resources.building
        Me.PictureBox1.Location = New System.Drawing.Point(25, 29)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(213, 149)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'grpConvertMeasurement
        '
        Me.grpConvertMeasurement.Controls.Add(Me.radInchestoMeters)
        Me.grpConvertMeasurement.Controls.Add(Me.radMeterstoInches)
        Me.grpConvertMeasurement.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpConvertMeasurement.Location = New System.Drawing.Point(393, 183)
        Me.grpConvertMeasurement.Name = "grpConvertMeasurement"
        Me.grpConvertMeasurement.Size = New System.Drawing.Size(258, 122)
        Me.grpConvertMeasurement.TabIndex = 11
        Me.grpConvertMeasurement.TabStop = False
        Me.grpConvertMeasurement.Text = "Convert Measurement"
        '
        'frmConversion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.grpConvertMeasurement)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblMeasurementOutput)
        Me.Controls.Add(Me.txtEnterValue)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnConvert)
        Me.Controls.Add(Me.lblEnterandChoose)
        Me.Controls.Add(Me.lblHeading)
        Me.Name = "frmConversion"
        Me.Text = "Building Plans Conversion "
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpConvertMeasurement.ResumeLayout(False)
        Me.grpConvertMeasurement.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeading As Label
    Friend WithEvents lblEnterandChoose As Label
    Friend WithEvents btnConvert As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents radInchestoMeters As RadioButton
    Friend WithEvents radMeterstoInches As RadioButton
    Friend WithEvents txtEnterValue As TextBox
    Friend WithEvents lblMeasurementOutput As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents grpConvertMeasurement As GroupBox
End Class
