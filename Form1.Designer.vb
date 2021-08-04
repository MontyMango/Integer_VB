<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.LblEnterInt = New System.Windows.Forms.Label()
        Me.txtIntegerInput = New System.Windows.Forms.TextBox()
        Me.btnDouble = New System.Windows.Forms.Button()
        Me.btnHalf = New System.Windows.Forms.Button()
        Me.btnRandomNum = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnTriple = New System.Windows.Forms.Button()
        Me.btnQuarter = New System.Windows.Forms.Button()
        Me.radKeepInput = New System.Windows.Forms.RadioButton()
        Me.radKeepTotal = New System.Windows.Forms.RadioButton()
        Me.btnUnselect = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LblEnterInt
        '
        Me.LblEnterInt.AutoSize = True
        Me.LblEnterInt.Location = New System.Drawing.Point(13, 13)
        Me.LblEnterInt.Name = "LblEnterInt"
        Me.LblEnterInt.Size = New System.Drawing.Size(110, 19)
        Me.LblEnterInt.TabIndex = 0
        Me.LblEnterInt.Text = "Enter an integer:"
        '
        'txtIntegerInput
        '
        Me.txtIntegerInput.Location = New System.Drawing.Point(129, 13)
        Me.txtIntegerInput.Name = "txtIntegerInput"
        Me.txtIntegerInput.Size = New System.Drawing.Size(62, 26)
        Me.txtIntegerInput.TabIndex = 1
        '
        'btnDouble
        '
        Me.btnDouble.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnDouble.ForeColor = System.Drawing.SystemColors.Highlight
        Me.btnDouble.Location = New System.Drawing.Point(13, 48)
        Me.btnDouble.Name = "btnDouble"
        Me.btnDouble.Size = New System.Drawing.Size(86, 26)
        Me.btnDouble.TabIndex = 2
        Me.btnDouble.Text = "Double"
        Me.btnDouble.UseVisualStyleBackColor = True
        '
        'btnHalf
        '
        Me.btnHalf.ForeColor = System.Drawing.Color.IndianRed
        Me.btnHalf.Location = New System.Drawing.Point(105, 48)
        Me.btnHalf.Name = "btnHalf"
        Me.btnHalf.Size = New System.Drawing.Size(86, 26)
        Me.btnHalf.TabIndex = 3
        Me.btnHalf.Text = "Half"
        Me.btnHalf.UseVisualStyleBackColor = True
        '
        'btnRandomNum
        '
        Me.btnRandomNum.ForeColor = System.Drawing.Color.Fuchsia
        Me.btnRandomNum.Location = New System.Drawing.Point(13, 112)
        Me.btnRandomNum.Name = "btnRandomNum"
        Me.btnRandomNum.Size = New System.Drawing.Size(178, 26)
        Me.btnRandomNum.TabIndex = 6
        Me.btnRandomNum.Text = "Random Number"
        Me.btnRandomNum.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.DarkSalmon
        Me.btnExit.ForeColor = System.Drawing.Color.Black
        Me.btnExit.Location = New System.Drawing.Point(197, 112)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(86, 26)
        Me.btnExit.TabIndex = 100
        Me.btnExit.TabStop = False
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnTriple
        '
        Me.btnTriple.ForeColor = System.Drawing.Color.Olive
        Me.btnTriple.Location = New System.Drawing.Point(13, 80)
        Me.btnTriple.Name = "btnTriple"
        Me.btnTriple.Size = New System.Drawing.Size(86, 26)
        Me.btnTriple.TabIndex = 4
        Me.btnTriple.Text = "Triple"
        Me.btnTriple.UseVisualStyleBackColor = True
        '
        'btnQuarter
        '
        Me.btnQuarter.ForeColor = System.Drawing.Color.Peru
        Me.btnQuarter.Location = New System.Drawing.Point(105, 80)
        Me.btnQuarter.Name = "btnQuarter"
        Me.btnQuarter.Size = New System.Drawing.Size(86, 26)
        Me.btnQuarter.TabIndex = 5
        Me.btnQuarter.Text = "Quarter"
        Me.btnQuarter.UseVisualStyleBackColor = True
        '
        'radKeepInput
        '
        Me.radKeepInput.AutoSize = True
        Me.radKeepInput.Location = New System.Drawing.Point(197, 51)
        Me.radKeepInput.Name = "radKeepInput"
        Me.radKeepInput.Size = New System.Drawing.Size(94, 23)
        Me.radKeepInput.TabIndex = 101
        Me.radKeepInput.Text = "Keep Input"
        Me.radKeepInput.UseVisualStyleBackColor = True
        '
        'radKeepTotal
        '
        Me.radKeepTotal.AutoSize = True
        Me.radKeepTotal.Location = New System.Drawing.Point(198, 81)
        Me.radKeepTotal.Name = "radKeepTotal"
        Me.radKeepTotal.Size = New System.Drawing.Size(90, 23)
        Me.radKeepTotal.TabIndex = 102
        Me.radKeepTotal.Text = "Keep Total"
        Me.radKeepTotal.UseVisualStyleBackColor = True
        '
        'btnUnselect
        '
        Me.btnUnselect.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnUnselect.Location = New System.Drawing.Point(197, 13)
        Me.btnUnselect.Name = "btnUnselect"
        Me.btnUnselect.Size = New System.Drawing.Size(86, 26)
        Me.btnUnselect.TabIndex = 7
        Me.btnUnselect.Text = "Unselect"
        Me.btnUnselect.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(298, 157)
        Me.Controls.Add(Me.btnUnselect)
        Me.Controls.Add(Me.radKeepTotal)
        Me.Controls.Add(Me.radKeepInput)
        Me.Controls.Add(Me.btnQuarter)
        Me.Controls.Add(Me.btnTriple)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnRandomNum)
        Me.Controls.Add(Me.btnHalf)
        Me.Controls.Add(Me.btnDouble)
        Me.Controls.Add(Me.txtIntegerInput)
        Me.Controls.Add(Me.LblEnterInt)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Integer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblEnterInt As Label
    Friend WithEvents txtIntegerInput As TextBox
    Friend WithEvents btnDouble As Button
    Friend WithEvents btnHalf As Button
    Friend WithEvents btnRandomNum As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnTriple As Button
    Friend WithEvents btnQuarter As Button
    Friend WithEvents radKeepInput As RadioButton
    Friend WithEvents radKeepTotal As RadioButton
    Friend WithEvents btnUnselect As Button
End Class
