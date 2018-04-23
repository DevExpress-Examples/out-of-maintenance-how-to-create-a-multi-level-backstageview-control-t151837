Namespace WindowsFormsApplication12
    Partial Public Class UserControl1
        ''' <summary> 
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary> 
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Component Designer generated code"

        ''' <summary> 
        ''' Required method for Designer support - do not modify 
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(UserControl1))
            Me.label1 = New System.Windows.Forms.Label()
            Me.label2 = New System.Windows.Forms.Label()
            Me.SuspendLayout()
            ' 
            ' label1
            ' 
            Me.label1.Dock = System.Windows.Forms.DockStyle.Top
            Me.label1.Font = New System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
            Me.label1.Location = New System.Drawing.Point(0, 0)
            Me.label1.Margin = New System.Windows.Forms.Padding(3, 15, 3, 0)
            Me.label1.Name = "label1"
            Me.label1.Padding = New System.Windows.Forms.Padding(0, 15, 0, 0)
            Me.label1.Size = New System.Drawing.Size(642, 48)
            Me.label1.TabIndex = 0
            Me.label1.Text = "Tab Item Content"
            Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            ' 
            ' label2
            ' 
            Me.label2.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
            Me.label2.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
            Me.label2.Location = New System.Drawing.Point(0, 48)
            Me.label2.Name = "label2"
            Me.label2.Padding = New System.Windows.Forms.Padding(20)
            Me.label2.Size = New System.Drawing.Size(642, 409)
            Me.label2.TabIndex = 1
            Me.label2.Text = resources.GetString("label2.Text")
            Me.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            ' 
            ' UserControl1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.label1)
            Me.Controls.Add(Me.label2)
            Me.Name = "UserControl1"
            Me.Size = New System.Drawing.Size(642, 457)
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private label1 As System.Windows.Forms.Label
        Private label2 As System.Windows.Forms.Label

    End Class
End Namespace
