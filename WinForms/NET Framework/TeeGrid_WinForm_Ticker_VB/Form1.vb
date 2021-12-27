Imports Steema.TeeGrid.Columns
Imports Steema.TeeGrid.Data.Strings
Imports Steema.TeeGrid.Ticker
Imports Steema.TeeGrid.WinForm.Editors

Public Class Form1
    Private Sub TBSpeed_Scroll(sender As Object, e As EventArgs) Handles tBSpeed.Scroll
        timer1.Interval = tBSpeed.Value
        RefreshSpeed()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles timer1.Tick
        Dim col As Integer = Nothing, row As Integer = Nothing
        RandomCell(col, row)
        Dim tmp As Column = TGrid1.Columns(col)
        Dim oldValue As Integer = Integer.Parse(Data.AsString(tmp, row))
        Data.SetValue(tmp, row, (oldValue + rnd.[Next](100) - 50).ToString())
        Ticker.ChangeTicker(col, row, oldValue)
    End Sub

    Private Sub RandomCell(ByRef col As Integer, ByRef row As Integer)
        Do
            col = rnd.[Next](TGrid1.Columns.Count)
        Loop While TGrid1.Columns(col).Header.Text = Product

        row = rnd.[Next](TGrid1.Data.Count())
    End Sub

    Private Sub RefreshSpeed()
        LSpeed.Text = timer1.Interval.ToString() & " msec"
    End Sub

    Private Sub FillNames()
        Data.Headers(0) = Product
        Data.Headers(1) = "Sales"
        Data.Headers(2) = "Stock"
        Data.Headers(3) = "Orders"
        Data.Headers(4) = "Returns"
        Data(0, 0) = "Cars"
        Data(0, 1) = "Chairs"
        Data(0, 2) = "Keyboards"
        Data(0, 3) = "Lamps"
        Data(0, 4) = "Monitors"
        Data(0, 5) = "Tables"
        Data(0, 6) = "Umbrellas"
        Data(0, 7) = "Windows"
    End Sub
    Private Sub CustomFormat()
        Dim col As Column = TGrid1.Columns(0)
        col.ParentFormat = False
        col.Format.Font.Style = Steema.TeeGrid.Format.FontStyle.Bold
        col.Format.Font.Color = Color.Navy
    End Sub

    Private Sub ColumnTextAlign()
        For col As Integer = 1 To TGrid1.Columns.Count - 1
            Dim tmp As Column = TGrid1.Columns(col)
            tmp.ParentFormat = False
            tmp.TextAlignment = Steema.TeeGrid.Columns.ColumnTextAlign.Custom
            tmp.TextAlign.Horizontal = Steema.TeeGrid.Painter.HorizontalAlign.Right
        Next
    End Sub

    Private Sub FillRandomValues()
        For col As Integer = 1 To TGrid1.Columns.Count - 1

            For row As Integer = 0 To Data.Count() - 1
                Data(col, row) = rnd.[Next](col * 2000).ToString()
            Next
        Next
    End Sub

    Private Ticker As GridTicker
    Private Data As StringsData
    Private Const Product As String = "Product"
    Private rnd As Random = New Random()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BackColor = Color.White
        Steema.TeeGrid.Themes.GridThemes.Flat.ApplyTo(TGrid1.Grid)
        Data = New StringsData(5, 8)
        TGrid1.Data = Data
        FillNames()
        FillRandomValues()
        ColumnTextAlign()
        CustomFormat()
        RefreshSpeed()
        Ticker = New GridTicker(TGrid1.Grid.Current)
        GridTickerEditor.Embed(SplitContainer2.Panel2, Ticker)
        timer1.Enabled = True
    End Sub
End Class
