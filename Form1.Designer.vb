<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        txtFirstnum = New TextBox()
        Label3 = New Label()
        txtSecondnum = New TextBox()
        btnDivide = New Button()
        lblResult = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(133, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(124, 15)
        Label1.TabIndex = 0
        Label1.Text = "Division Calculator 3.0"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(56, 56)
        Label2.Name = "Label2"
        Label2.Size = New Size(82, 15)
        Label2.TabIndex = 1
        Label2.Text = "First Number: "
        ' 
        ' txtFirstnum
        ' 
        txtFirstnum.Location = New Point(214, 48)
        txtFirstnum.Name = "txtFirstnum"
        txtFirstnum.Size = New Size(135, 23)
        txtFirstnum.TabIndex = 2
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(56, 95)
        Label3.Name = "Label3"
        Label3.Size = New Size(96, 15)
        Label3.TabIndex = 1
        Label3.Text = "Second Number:"
        ' 
        ' txtSecondnum
        ' 
        txtSecondnum.Location = New Point(214, 87)
        txtSecondnum.Name = "txtSecondnum"
        txtSecondnum.Size = New Size(135, 23)
        txtSecondnum.TabIndex = 2
        ' 
        ' btnDivide
        ' 
        btnDivide.Location = New Point(56, 136)
        btnDivide.Name = "btnDivide"
        btnDivide.Size = New Size(75, 23)
        btnDivide.TabIndex = 3
        btnDivide.Text = "Divide"
        btnDivide.UseVisualStyleBackColor = True
        ' 
        ' lblResult
        ' 
        lblResult.AutoSize = True
        lblResult.Font = New Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point)
        lblResult.Location = New Point(255, 131)
        lblResult.Name = "lblResult"
        lblResult.Size = New Size(64, 28)
        lblResult.TabIndex = 4
        lblResult.Text = "Result"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(385, 197)
        Controls.Add(lblResult)
        Controls.Add(btnDivide)
        Controls.Add(txtSecondnum)
        Controls.Add(Label3)
        Controls.Add(txtFirstnum)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtFirstnum As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtSecondnum As TextBox
    Friend WithEvents btnDivide As Button
    Friend WithEvents lblResult As Label
End Class
