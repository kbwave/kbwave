Public Class windowMain


	Private Sub windowMain_Load(sender As Object, e As EventArgs) Handles Me.Load
		SetGrid()
	End Sub


	''' <summary>
	''' グリッドをセット
	''' </summary>
	''' <remarks></remarks>
	Private Sub SetGrid()

		With Me.grdMain
			'1列目に表示される行の選択位置を教えてくれる？列はいらない
			.RowHeadersVisible = False

			.Rows.Clear()

			'行を追加する場合は列数を設定しないと例外エラー発生
			.ColumnCount = 3

			For i As Integer = 1 To 3
				.Rows.Add()
			Next

			Select Case MessageBox.Show("行をクリアしますか？", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
				Case vbYes
					.Rows.Clear()
			End Select

			modMain.SetGridTitle(Me.grdMain)

		End With
	End Sub


End Class
