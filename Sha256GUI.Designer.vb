<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sha256Form
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Sha256Form))
        Me.button_Browse = New System.Windows.Forms.Button()
        Me.txtbox_FileSelect = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtbox_ComputedHash = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtbox_CompareHash = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.label_Version = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'button_Browse
        '
        Me.button_Browse.Location = New System.Drawing.Point(12, 51)
        Me.button_Browse.Name = "button_Browse"
        Me.button_Browse.Size = New System.Drawing.Size(75, 23)
        Me.button_Browse.TabIndex = 0
        Me.button_Browse.Text = "Browse"
        Me.button_Browse.UseVisualStyleBackColor = True
        '
        'txtbox_FileSelect
        '
        Me.txtbox_FileSelect.Location = New System.Drawing.Point(9, 25)
        Me.txtbox_FileSelect.Name = "txtbox_FileSelect"
        Me.txtbox_FileSelect.Size = New System.Drawing.Size(553, 20)
        Me.txtbox_FileSelect.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Selected File:"
        '
        'txtbox_ComputedHash
        '
        Me.txtbox_ComputedHash.Location = New System.Drawing.Point(9, 103)
        Me.txtbox_ComputedHash.Name = "txtbox_ComputedHash"
        Me.txtbox_ComputedHash.ReadOnly = True
        Me.txtbox_ComputedHash.Size = New System.Drawing.Size(553, 20)
        Me.txtbox_ComputedHash.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Computed SHA256 Hash:"
        '
        'txtbox_CompareHash
        '
        Me.txtbox_CompareHash.Location = New System.Drawing.Point(9, 145)
        Me.txtbox_CompareHash.Name = "txtbox_CompareHash"
        Me.txtbox_CompareHash.Size = New System.Drawing.Size(553, 20)
        Me.txtbox_CompareHash.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 126)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Compare to:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 168)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'label_Version
        '
        Me.label_Version.AutoSize = True
        Me.label_Version.Location = New System.Drawing.Point(531, 172)
        Me.label_Version.Name = "label_Version"
        Me.label_Version.Size = New System.Drawing.Size(29, 13)
        Me.label_Version.TabIndex = 9
        Me.label_Version.Text = "V1.1"
        '
        'Sha256Form
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(577, 195)
        Me.Controls.Add(Me.label_Version)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtbox_CompareHash)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtbox_ComputedHash)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtbox_FileSelect)
        Me.Controls.Add(Me.button_Browse)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Sha256Form"
        Me.Text = "SHA256 File Integrity Checker"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents button_Browse As System.Windows.Forms.Button
    Friend WithEvents txtbox_FileSelect As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtbox_ComputedHash As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtbox_CompareHash As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents label_Version As System.Windows.Forms.Label

End Class
