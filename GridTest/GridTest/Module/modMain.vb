Module modMain

	Private _windowMain As windowMain = Nothing

	<STAThread> _
	Public Sub Main()

		_windowMain = New windowMain

		_windowMain.ShowDialog()
		_windowMain.Dispose()

	End Sub

End Module
