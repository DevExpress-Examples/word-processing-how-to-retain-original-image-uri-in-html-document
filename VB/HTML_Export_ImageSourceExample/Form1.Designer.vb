Namespace Retain_Img_Src
    Partial Public Class Form1
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

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.richEditControl1 = New DevExpress.XtraRichEdit.RichEditControl()
            Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
            Me.embedImagesCheck = New DevExpress.XtraEditors.CheckEdit()
            Me.memoEdit1 = New DevExpress.XtraEditors.MemoEdit()
            Me.lblText = New DevExpress.XtraEditors.LabelControl()
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl1.SuspendLayout()
            CType(Me.embedImagesCheck.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.memoEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' richEditControl1
            ' 
            Me.richEditControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.richEditControl1.Location = New System.Drawing.Point(0, 42)
            Me.richEditControl1.Name = "richEditControl1"
            Me.richEditControl1.Size = New System.Drawing.Size(330, 519)
            Me.richEditControl1.TabIndex = 0
            Me.richEditControl1.Text = "richEditControl1"
            ' 
            ' panelControl1
            ' 
            Me.panelControl1.Controls.Add(Me.lblText)
            Me.panelControl1.Controls.Add(Me.embedImagesCheck)
            Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Top
            Me.panelControl1.Location = New System.Drawing.Point(0, 0)
            Me.panelControl1.Name = "panelControl1"
            Me.panelControl1.Size = New System.Drawing.Size(784, 42)
            Me.panelControl1.TabIndex = 3
            ' 
            ' embedImagesCheck
            ' 
            Me.embedImagesCheck.Location = New System.Drawing.Point(13, 13)
            Me.embedImagesCheck.Name = "embedImagesCheck"
            Me.embedImagesCheck.Properties.Caption = "EmbedImagesInHTML"
            Me.embedImagesCheck.Size = New System.Drawing.Size(127, 19)
            Me.embedImagesCheck.TabIndex = 0
            ' 
            ' memoEdit1
            ' 
            Me.memoEdit1.Dock = System.Windows.Forms.DockStyle.Right
            Me.memoEdit1.Location = New System.Drawing.Point(330, 42)
            Me.memoEdit1.Name = "memoEdit1"
            Me.memoEdit1.Properties.ReadOnly = True
            Me.memoEdit1.Size = New System.Drawing.Size(454, 519)
            Me.memoEdit1.TabIndex = 4
            ' 
            ' lblText
            ' 
            Me.lblText.Appearance.BackColor = System.Drawing.SystemColors.Info
            Me.lblText.Appearance.Options.UseBackColor = True
            Me.lblText.Appearance.Options.UseTextOptions = True
            Me.lblText.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.lblText.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
            Me.lblText.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
            Me.lblText.Location = New System.Drawing.Point(330, 5)
            Me.lblText.Name = "lblText"
            Me.lblText.Size = New System.Drawing.Size(442, 31)
            Me.lblText.TabIndex = 1
            Me.lblText.Text = "labelControl1"
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(784, 561)
            Me.Controls.Add(Me.richEditControl1)
            Me.Controls.Add(Me.memoEdit1)
            Me.Controls.Add(Me.panelControl1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.Name = "Form1"
            Me.Text = "Form1"
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl1.ResumeLayout(False)
            CType(Me.embedImagesCheck.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.memoEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private WithEvents richEditControl1 As DevExpress.XtraRichEdit.RichEditControl
        Private panelControl1 As DevExpress.XtraEditors.PanelControl
        Private WithEvents embedImagesCheck As DevExpress.XtraEditors.CheckEdit
        Private memoEdit1 As DevExpress.XtraEditors.MemoEdit
        Private lblText As DevExpress.XtraEditors.LabelControl
    End Class
End Namespace

