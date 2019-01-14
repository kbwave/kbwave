<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class windowMain
	Inherits System.Windows.Forms.Form

	'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

	'Windows フォーム デザイナーで必要です。
	Private components As System.ComponentModel.IContainer

	'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
	'Windows フォーム デザイナーを使用して変更できます。  
	'コード エディターを使って変更しないでください。
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
		Me.grdMain = New System.Windows.Forms.DataGridView()
		CType(Me.grdMain, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'grdMain
		'
		Me.grdMain.AllowUserToAddRows = False
		Me.grdMain.AllowUserToDeleteRows = False
		Me.grdMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.grdMain.Location = New System.Drawing.Point(0, 0)
		Me.grdMain.Name = "grdMain"
		Me.grdMain.ReadOnly = True
		Me.grdMain.RowHeadersVisible = False
		Me.grdMain.RowTemplate.Height = 21
		Me.grdMain.Size = New System.Drawing.Size(411, 238)
		Me.grdMain.TabIndex = 0
		'
		'windowMain
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(412, 241)
		Me.Controls.Add(Me.grdMain)
		Me.Name = "windowMain"
		Me.Text = "GridTest"
		CType(Me.grdMain, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents grdMain As System.Windows.Forms.DataGridView

End Class
