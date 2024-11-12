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
        tbnTest = New Button()
        SuspendLayout()
        ' 
        ' tbnTest
        ' 
        tbnTest.Location = New Point(242, 182)
        tbnTest.Margin = New Padding(5)
        tbnTest.Name = "tbnTest"
        tbnTest.Size = New Size(204, 58)
        tbnTest.TabIndex = 0
        tbnTest.Text = "MYSQL TEST"
        tbnTest.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(12F, 24F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1371, 720)
        Controls.Add(tbnTest)
        Font = New Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Margin = New Padding(5)
        Name = "Form1"
        Text = "MYSQLDB DATA CONNECTION"
        ResumeLayout(False)
    End Sub

    Friend WithEvents tbnTest As Button

End Class
