﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBikeRental
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
        Me.picBikes = New System.Windows.Forms.PictureBox()
        Me.lblCostHeading = New System.Windows.Forms.Label()
        Me.lblNumberOfBike = New System.Windows.Forms.Label()
        Me.txtNumberOfBikes = New System.Windows.Forms.TextBox()
        Me.lblTotalCostLabel = New System.Windows.Forms.Label()
        Me.lblTotalCost = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        CType(Me.picBikes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Cooper Black", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblHeading.Location = New System.Drawing.Point(91, 21)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(226, 27)
        Me.lblHeading.TabIndex = 0
        Me.lblHeading.Text = "City Bike Rentals"
        '
        'picBikes
        '
        Me.picBikes.Image = Global.CityBikeRental.My.Resources.Resources.Bikes
        Me.picBikes.Location = New System.Drawing.Point(1, 284)
        Me.picBikes.Name = "picBikes"
        Me.picBikes.Size = New System.Drawing.Size(407, 175)
        Me.picBikes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBikes.TabIndex = 1
        Me.picBikes.TabStop = False
        '
        'lblCostHeading
        '
        Me.lblCostHeading.AutoSize = True
        Me.lblCostHeading.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCostHeading.Location = New System.Drawing.Point(96, 65)
        Me.lblCostHeading.Name = "lblCostHeading"
        Me.lblCostHeading.Size = New System.Drawing.Size(217, 20)
        Me.lblCostHeading.TabIndex = 2
        Me.lblCostHeading.Text = "$X. XX per Bike for 24 Hours."
        '
        'lblNumberOfBike
        '
        Me.lblNumberOfBike.AutoSize = True
        Me.lblNumberOfBike.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumberOfBike.Location = New System.Drawing.Point(34, 116)
        Me.lblNumberOfBike.Name = "lblNumberOfBike"
        Me.lblNumberOfBike.Size = New System.Drawing.Size(183, 20)
        Me.lblNumberOfBike.TabIndex = 3
        Me.lblNumberOfBike.Text = "Number Of Bike Rentals:"
        '
        'txtNumberOfBikes
        '
        Me.txtNumberOfBikes.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumberOfBikes.Location = New System.Drawing.Point(275, 113)
        Me.txtNumberOfBikes.Name = "txtNumberOfBikes"
        Me.txtNumberOfBikes.Size = New System.Drawing.Size(38, 26)
        Me.txtNumberOfBikes.TabIndex = 4
        Me.txtNumberOfBikes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblTotalCostLabel
        '
        Me.lblTotalCostLabel.AutoSize = True
        Me.lblTotalCostLabel.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCostLabel.Location = New System.Drawing.Point(34, 156)
        Me.lblTotalCostLabel.Name = "lblTotalCostLabel"
        Me.lblTotalCostLabel.Size = New System.Drawing.Size(199, 20)
        Me.lblTotalCostLabel.TabIndex = 5
        Me.lblTotalCostLabel.Text = "Total Cost of Bikes Rented:"
        '
        'lblTotalCost
        '
        Me.lblTotalCost.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCost.Location = New System.Drawing.Point(264, 156)
        Me.lblTotalCost.Name = "lblTotalCost"
        Me.lblTotalCost.Size = New System.Drawing.Size(61, 20)
        Me.lblTotalCost.TabIndex = 6
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.ForeColor = System.Drawing.Color.RoyalBlue
        Me.btnCalculate.Location = New System.Drawing.Point(22, 220)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(109, 25)
        Me.btnCalculate.TabIndex = 7
        Me.btnCalculate.Text = "Calculate Cost"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.RoyalBlue
        Me.btnClear.Location = New System.Drawing.Point(150, 220)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(109, 25)
        Me.btnClear.TabIndex = 8
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.RoyalBlue
        Me.btnExit.Location = New System.Drawing.Point(278, 220)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(109, 25)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmBikeRental
        '
        Me.AcceptButton = Me.btnCalculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.btnClear
        Me.ClientSize = New System.Drawing.Size(409, 461)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblTotalCost)
        Me.Controls.Add(Me.lblTotalCostLabel)
        Me.Controls.Add(Me.txtNumberOfBikes)
        Me.Controls.Add(Me.lblNumberOfBike)
        Me.Controls.Add(Me.lblCostHeading)
        Me.Controls.Add(Me.picBikes)
        Me.Controls.Add(Me.lblHeading)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Name = "frmBikeRental"
        Me.Text = "                                        City Bike Rental"
        Me.TopMost = True
        CType(Me.picBikes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeading As Label
    Friend WithEvents picBikes As PictureBox
    Friend WithEvents lblCostHeading As Label
    Friend WithEvents lblNumberOfBike As Label
    Friend WithEvents txtNumberOfBikes As TextBox
    Friend WithEvents lblTotalCostLabel As Label
    Friend WithEvents lblTotalCost As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
End Class
