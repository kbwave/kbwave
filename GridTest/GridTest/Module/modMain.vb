''' <summary>
''' 本Projのメインモジュール
''' </summary>
''' <remarks></remarks>
Module modMain

	Private _windowMain As windowMain = Nothing


	''' <summary>
	''' エントリーポイント
	''' </summary>
	''' <remarks></remarks>
	<STAThread> _
	Public Sub Main()

		_windowMain = New windowMain

		_windowMain.ShowDialog()
		_windowMain.Dispose()

	End Sub

	''' <summary>
	''' 指定したグリッドに列タイトルを設定
	''' </summary>
	''' <param name="grdControl"></param>
	''' <remarks></remarks>
	Public Sub SetGridTitle(ByRef grdControl As DataGridView)
		Dim titleList As List(Of String) = Nothing

		titleList = GetGridTitleList()

		If titleList Is Nothing OrElse titleList.Count = 0 Then Return

		With grdControl
			.Rows.Clear()
			.ColumnCount = titleList.Count

			For i As Integer = 0 To titleList.Count - 1
				.Columns(i).HeaderText = titleList(i)
			Next
		End With
	End Sub

	''' <summary>
	''' グリッドの列のタイトルをリストで取得
	''' </summary>
	''' <returns></returns>
	''' <remarks></remarks>
	Private Function GetGridTitleList() As List(Of String)
		Dim titleList As List(Of String) = Nothing

		titleList = New List(Of String)

		titleList.Add("わん")
		titleList.Add("つー")
		titleList.Add("すり")
		titleList.Add("ふぉ")

		Return titleList
	End Function

End Module
