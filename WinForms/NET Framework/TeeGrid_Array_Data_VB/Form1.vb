Imports Steema.TeeGrid
Imports Steema.TeeGrid.Bands
Imports Steema.TeeGrid.Columns
Imports Steema.TeeGrid.Data
Imports Steema.TeeGrid.Data.Reflection
Imports Steema.TeeGrid.Format
Imports Steema.TeeGrid.Renders
Imports Steema.TeeGrid.Rows
Imports Steema.TeeGrid.Totals
Imports Steema.TeeGrid.WinForm.Editors
Imports TeeGrid_Array_Data.VirtualData

Public Class Form1
    Inherits Form

    Public Sub New()
        InitializeComponent()
        BRecord_Click(Me, EventArgs.Empty)
        Me.BackColor = Color.White
        Steema.TeeGrid.Themes.GridThemes.BlueFlat.ApplyTo(teeGrid1.Grid)
        teeGrid1.Rows.RowLines.Visible = True
        teeGrid1.Rows.Height.Automatic = True
    End Sub

    Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
        TeeGridEditor.Edit(teeGrid1)
    End Sub

    Private Sub button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button2.Click
        GridBandsEditor.Edit(teeGrid1.Headers)
    End Sub

    Private Sub button3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button3.Click
        GridBandsEditor.Edit(teeGrid1.Footer)
    End Sub

    Private MyListData As List(Of Person) = New List(Of Person)()
    Private SampleHeader As TextBand

    Private Sub BRecord_Click(ByVal sender As Object, ByVal e As EventArgs) Handles bRecord.Click
        MyData.FillMyData(MyListData, 10)
        teeGrid1.Data = New VirtualListData(Of Person)(MyListData)
        teeGrid1.Columns("BirthDate").DataFormat.DateTime = "dd-MM-yyyy"
        SetExpander("Name", teeGrid1.Rows)
        teeGrid1.Footer.Clear()
        Dim tmp As ColumnTotals = Totals(teeGrid1.Footer)
        TotalsHeader.CreateTotals(teeGrid1.Footer, tmp)
        AddSampleFooter()
        SampleHeader?.Dispose()
        SampleHeader = NewTitle(teeGrid1.Headers, "Header Sample" & Environment.NewLine & "Text")
        SampleHeader.Index = 0
        SetupCellEditors()
        AddHandler teeGrid1.CellEditing, AddressOf GridCellEditing
    End Sub

    Private Sub GridCellEditing(ByVal sender As Object, ByVal e As Steema.TeeGrid.WinForm.CellEditingEventArgs)
        If e.Column.Equals(teeGrid1.Columns("Children")) Then
            SetupCombo(TryCast(e.Editor, ComboBox), teeGrid1.Data.AsString(e.Column, e.Row))
        End If
    End Sub

    Private Sub SetupCombo(ByVal comboBox As ComboBox, ByVal text As String)
        comboBox.Items.Clear()

        For t As Integer = 0 To 15 - 1
            comboBox.Items.Add(t.ToString())
        Next

        comboBox.SelectedIndex = comboBox.Items.IndexOf(text)
    End Sub

    Private Sub SetupCellEditors()
        teeGrid1.Columns("BirthDate").EditorClass = GetType(DateTimePicker)
        teeGrid1.Columns("Children").EditorClass = GetType(ComboBox)
    End Sub

    Private Sub AddSampleFooter()
        Dim tmp As TextBand = NewTitle(teeGrid1.Footer, "Footer Sample" & Environment.NewLine & "Text")
        tmp.Format.Brush.Show()
        tmp.Format.Brush.InitColor(ColorTranslator.FromHtml("#6BABD0"))
        tmp.Format.Brush.Gradient.Show()
        tmp.Format.Brush.Gradient.Direction = GradientDirection.Horizontal
    End Sub

    Private Function NewTitle(ByVal collection As IObservableCollection, ByVal text As String) As TextBand
        Dim result As TextBand = New TextBand(collection)
        result.Text = text
        result.Format.Font.Size = 12
        result.Format.Font.Style = Steema.TeeGrid.Format.FontStyle.Bold
        result.Format.Font.Color = ColorTranslator.FromHtml("#034684")
        result.Format.Stroke.Visible = True
        result.Format.Stroke.Size = 3
        result.Format.Stroke.Color = ColorTranslator.FromHtml("#6BABD0")
        Return result
    End Function

    Private Function Totals(ByVal collection As IObservableCollection) As ColumnTotals
        Dim result As ColumnTotals = New ColumnTotals(collection)
        result.Calculation.Add("Name", ColumnCalculation.Count)
        result.Calculation.Add("Children", ColumnCalculation.Sum)
        result.Calculation.Add("Height", ColumnCalculation.Average)
        result.Calculation.Add(result.Columns("Address").Items("Number"), ColumnCalculation.Max)
        result.Calculation.Add(result.Columns("Car").Items("kW"), ColumnCalculation.Min)
        result.Format.Font.Style = Steema.TeeGrid.Format.FontStyle.Bold Or Steema.TeeGrid.Format.FontStyle.Italic
        Return result
    End Function

    Private Sub SetExpander(ByVal column As String, ByVal rows As Rows)
        Dim tmp As Column = teeGrid1.Columns(column)
        tmp.Render = New ExpanderRender(tmp.Changed)

        Dim expander = TryCast(tmp.Render, ExpanderRender)

        AddHandler expander.GetExpanded, AddressOf rows.IsChildrenVisible
    End Sub

    Private Shared rnd As Random = New Random()

    Private Sub bInteger_Click(ByVal sender As Object, ByVal e As EventArgs) Handles bInteger.Click
        Dim myIntegers As Integer() = New Integer(99) {}

        For t As Integer = 0 To 100 - 1
            myIntegers(t) = rnd.[Next](1000)
        Next

        teeGrid1.Data = New VirtualArrayData(Of Integer)(myIntegers)
        teeGrid1.Footer.Clear()
    End Sub

    Private Sub bFloat_Click(ByVal sender As Object, ByVal e As EventArgs) Handles bFloat.Click
        Dim myFloats As Double() = New Double(99) {}

        For t As Integer = 0 To 100 - 1
            myFloats(t) = rnd.NextDouble()
        Next

        teeGrid1.Data = New VirtualArrayData(Of Double)(myFloats)
        teeGrid1.Footer.Clear()
    End Sub

    Private Function RandomString() As String
        Dim samples As String() = New String() {"Red", "Blue", "Yellow", "Green"}
        Return samples(rnd.[Next](samples.Length - 1))
    End Function

    Private Sub bString_Click(ByVal sender As Object, ByVal e As EventArgs) Handles bString.Click
        Dim myStrings As String() = New String(99) {}

        For t As Integer = 0 To 100 - 1
            myStrings(t) = RandomString()
        Next

        teeGrid1.Data = New VirtualArrayData(Of String)(myStrings)
        teeGrid1.Footer.Clear()
    End Sub

    Private Sub bObject_Click(ByVal sender As Object, ByVal e As EventArgs) Handles bObject.Click
        Dim myCars As Car() = New Car(99) {}
        MyData.FillMyData(myCars, 100)
        teeGrid1.Data = New VirtualArrayData(Of Car)(myCars)
        teeGrid1.Footer.Clear()
    End Sub
End Class

