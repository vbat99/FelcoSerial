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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_WarrantyInfo = New System.Windows.Forms.Button()
        Me.btn_ServiceData = New System.Windows.Forms.Button()
        Me.btn_EnterCustomer = New System.Windows.Forms.Button()
        Me.btn_EnterSerial = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.EnterSerialDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomerDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ServiceDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WarrantyLookupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1.SuspendLayout
        Me.MenuStrip1.SuspendLayout
        Me.SuspendLayout
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btn_WarrantyInfo)
        Me.Panel1.Controls.Add(Me.btn_ServiceData)
        Me.Panel1.Controls.Add(Me.btn_EnterCustomer)
        Me.Panel1.Controls.Add(Me.btn_EnterSerial)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(695, 605)
        Me.Panel1.TabIndex = 0
        '
        'btn_WarrantyInfo
        '
        Me.btn_WarrantyInfo.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btn_WarrantyInfo.FlatAppearance.BorderSize = 3
        Me.btn_WarrantyInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btn_WarrantyInfo.Location = New System.Drawing.Point(371, 256)
        Me.btn_WarrantyInfo.Name = "btn_WarrantyInfo"
        Me.btn_WarrantyInfo.Size = New System.Drawing.Size(182, 103)
        Me.btn_WarrantyInfo.TabIndex = 3
        Me.btn_WarrantyInfo.Text = "Warranty Information"
        Me.btn_WarrantyInfo.UseVisualStyleBackColor = true
        '
        'btn_ServiceData
        '
        Me.btn_ServiceData.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btn_ServiceData.FlatAppearance.BorderSize = 3
        Me.btn_ServiceData.Font = New System.Drawing.Font("Microsoft Sans Serif", 14!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btn_ServiceData.Location = New System.Drawing.Point(71, 256)
        Me.btn_ServiceData.Name = "btn_ServiceData"
        Me.btn_ServiceData.Size = New System.Drawing.Size(182, 103)
        Me.btn_ServiceData.TabIndex = 2
        Me.btn_ServiceData.Text = "Service"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"Records"
        Me.btn_ServiceData.UseVisualStyleBackColor = true
        '
        'btn_EnterCustomer
        '
        Me.btn_EnterCustomer.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btn_EnterCustomer.FlatAppearance.BorderSize = 3
        Me.btn_EnterCustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 14!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btn_EnterCustomer.Location = New System.Drawing.Point(371, 89)
        Me.btn_EnterCustomer.Name = "btn_EnterCustomer"
        Me.btn_EnterCustomer.Size = New System.Drawing.Size(182, 103)
        Me.btn_EnterCustomer.TabIndex = 1
        Me.btn_EnterCustomer.Text = "Customer Information"
        Me.btn_EnterCustomer.UseVisualStyleBackColor = true
        '
        'btn_EnterSerial
        '
        Me.btn_EnterSerial.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btn_EnterSerial.FlatAppearance.BorderSize = 3
        Me.btn_EnterSerial.Font = New System.Drawing.Font("Microsoft Sans Serif", 14!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btn_EnterSerial.Location = New System.Drawing.Point(71, 89)
        Me.btn_EnterSerial.Name = "btn_EnterSerial"
        Me.btn_EnterSerial.Size = New System.Drawing.Size(182, 103)
        Me.btn_EnterSerial.TabIndex = 0
        Me.btn_EnterSerial.Text = "Serial Number Entry/Edit"
        Me.btn_EnterSerial.UseVisualStyleBackColor = true
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EnterSerialDataToolStripMenuItem, Me.CustomerDataToolStripMenuItem, Me.ServiceDataToolStripMenuItem, Me.WarrantyLookupToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(695, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'EnterSerialDataToolStripMenuItem
        '
        Me.EnterSerialDataToolStripMenuItem.Name = "EnterSerialDataToolStripMenuItem"
        Me.EnterSerialDataToolStripMenuItem.Size = New System.Drawing.Size(100, 20)
        Me.EnterSerialDataToolStripMenuItem.Text = "Enter Serial Data"
        '
        'CustomerDataToolStripMenuItem
        '
        Me.CustomerDataToolStripMenuItem.Name = "CustomerDataToolStripMenuItem"
        Me.CustomerDataToolStripMenuItem.Size = New System.Drawing.Size(91, 20)
        Me.CustomerDataToolStripMenuItem.Text = "Customer Data"
        '
        'ServiceDataToolStripMenuItem
        '
        Me.ServiceDataToolStripMenuItem.Name = "ServiceDataToolStripMenuItem"
        Me.ServiceDataToolStripMenuItem.Size = New System.Drawing.Size(80, 20)
        Me.ServiceDataToolStripMenuItem.Text = "Service Data"
        '
        'WarrantyLookupToolStripMenuItem
        '
        Me.WarrantyLookupToolStripMenuItem.Name = "WarrantyLookupToolStripMenuItem"
        Me.WarrantyLookupToolStripMenuItem.Size = New System.Drawing.Size(102, 20)
        Me.WarrantyLookupToolStripMenuItem.Text = "Warranty Lookup"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(695, 629)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Felco Serial Database"
        Me.Panel1.ResumeLayout(false)
        Me.MenuStrip1.ResumeLayout(false)
        Me.MenuStrip1.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_WarrantyInfo As Button
    Friend WithEvents btn_ServiceData As Button
    Friend WithEvents btn_EnterCustomer As Button
    Friend WithEvents btn_EnterSerial As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents EnterSerialDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CustomerDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ServiceDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WarrantyLookupToolStripMenuItem As ToolStripMenuItem
End Class
