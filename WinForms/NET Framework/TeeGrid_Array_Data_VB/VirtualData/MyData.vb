Imports System.ComponentModel

Namespace VirtualData
    Public Class Address
        Public Property Street As String
        Public Property Number As Integer
        Public Property City As String
        Public Property Country As String
    End Class

    Public Class Person
        Public Property Name As String
        Public Property Address As Address
        Public Property BirthDate As DateTime
        Public Property Children As Integer
        Public Property Extravert As Boolean
        Public Property Height As Double
        Public Property Car As Car
    End Class

    Public Class Vehicle
        Public Property Motor As EnergySource
    End Class

    Public Enum EnergySource
        Petrol
        Diesel
        Hybrid
        Electric
        Manual
    End Enum

    Public Enum Manufacturer
        Ford
        Volvo
        Volkswagen
        BMW
        Chevrolet
        Tata
    End Enum

    Public Class Car
        Inherits Vehicle

        Public Property Manufacturer As Manufacturer
        Public Property kW As Integer
        Public Property AllWheelDrive As Boolean
    End Class

    Public Class Location
        Public Property Name As String
        Public Property Country As String
    End Class

    Public Class SortableBindingList(Of T)
        Inherits BindingList(Of T)

        Private isSortedValue As Boolean
        Private sortDirectionValue As ListSortDirection
        Private sortPropertyValue As PropertyDescriptor

        Public Sub New()
        End Sub

        Public Sub New(ByVal list As IList(Of T))
            For Each o As Object In list
                Add(o)
            Next
        End Sub

        Protected Overrides Sub RemoveSortCore()
        End Sub

        Protected Overrides Sub ApplySortCore(ByVal prop As PropertyDescriptor, ByVal direction As ListSortDirection)
            Dim interfaceType As Type = prop.PropertyType.GetInterface("IComparable")

            If interfaceType Is Nothing AndAlso prop.PropertyType.IsValueType Then
                Dim underlyingType As Type = Nullable.GetUnderlyingType(prop.PropertyType)

                If underlyingType IsNot Nothing Then
                    interfaceType = underlyingType.GetInterface("IComparable")
                End If
            End If

            If interfaceType IsNot Nothing Then
                sortPropertyValue = prop
                sortDirectionValue = direction
                Dim query As IEnumerable(Of T) = MyBase.Items

                If direction = ListSortDirection.Ascending Then
                    query = query.OrderBy(Function(i) prop.GetValue(i))
                Else
                    query = query.OrderByDescending(Function(i) prop.GetValue(i))
                End If

                Dim newIndex As Integer = 0

                For Each item As Object In query
                    Items(newIndex) = CType(item, T)
                    newIndex += 1
                Next

                isSortedValue = True
                OnListChanged(New ListChangedEventArgs(ListChangedType.Reset, -1))
            Else
                Throw New NotSupportedException("Cannot sort by " & prop.Name & ". This" & prop.PropertyType.ToString() & " does not implement IComparable")
            End If
        End Sub

        Protected Overrides ReadOnly Property SortPropertyCore As PropertyDescriptor
            Get
                Return sortPropertyValue
            End Get
        End Property

        Protected Overrides ReadOnly Property SortDirectionCore As ListSortDirection
            Get
                Return sortDirectionValue
            End Get
        End Property

        Protected Overrides ReadOnly Property SupportsSortingCore As Boolean
            Get
                Return True
            End Get
        End Property

        Protected Overrides ReadOnly Property IsSortedCore As Boolean
            Get
                Return isSortedValue
            End Get
        End Property
    End Class

    Friend Module MyData
        Public Sub FillMyData(ByVal data As IList(Of Person), ByVal count As Integer)
            data.Clear()

            For t As Integer = 0 To count - 1
                data.Add(RandomPerson)
            Next
        End Sub

        Public Sub FillMyData(ByVal data As IList(Of Car), ByVal count As Integer)
            For t As Integer = 0 To count - 1
                data.Add(RandomCar)
            Next
        End Sub

        Public Sub FillMyData(ByVal data As IList(Of Address), ByVal count As Integer)
            For t As Integer = 0 To count - 1
                data.Add(RandomAddress)
            Next
        End Sub

        Public Sub FillMyData(ByVal data As Car(), ByVal count As Integer)
            For t As Integer = 0 To count - 1
                data(t) = RandomCar
            Next
        End Sub

        Private ReadOnly _random As Random = New Random()

        Private Function Random(ByVal count As Integer) As Integer
            Return _random.[Next](count)
        End Function

        Private ReadOnly Property RandomName As String
            Get

                Select Case Random(6)
                    Case 0
                        Return "Anna"
                    Case 1
                        Return "Mike"
                    Case 2
                        Return "Paula"
                    Case 3
                        Return "Linda"
                    Case 4
                        Return "Peter"
                    Case Else
                        Return "Bob"
                End Select
            End Get
        End Property

        Private ReadOnly Property RandomStreet As String
            Get

                Select Case Random(6)
                    Case 0
                        Return "Lamps Ave"
                    Case 1
                        Return "Caps St"
                    Case 2
                        Return "Plain Rd"
                    Case 3
                        Return "56th St"
                    Case 4
                        Return "Sand Rock St" & Environment.NewLine & "Santa Cristina by the Sea"
                    Case Else
                        Return "Moon Ave"
                End Select
            End Get
        End Property

        Private _locations As List(Of Location)

        Private ReadOnly Property RandomLocation As Location
            Get

                If _locations Is Nothing Then
                    _locations = New List(Of Location) From {
                        New Location() With {
                        .Name = "New York",
                        .Country = "USA"
                    },
                        New Location() With {
                        .Name = "Barcelona",
                        .Country = "Catalonia"
                    },
                        New Location() With {
                        .Name = "Tokyo",
                        .Country = "Japan"
                    },
                        New Location() With {
                        .Name = "Sao Paulo",
                        .Country = "Brazil"
                    },
                        New Location() With {
                        .Name = "Santa Cruz",
                        .Country = "USA"
                    },
                        New Location() With {
                        .Name = "Oslo",
                        .Country = "Norway"
                    }
                    }
                End If

                Return _locations(Random(6))
            End Get
        End Property

        Private ReadOnly Property RandomDate As DateTime
            Get
                Return New DateTime(1980 + Random(20), 1 + Random(12), 1 + Random(28))
            End Get
        End Property

        Private ReadOnly Property RandomPerson As Person
            Get
                Dim person As Person = New Person With {
                    .Name = RandomName,
                    .Address = RandomAddress,
                    .BirthDate = RandomDate,
                    .Children = Random(5),
                    .Extravert = Random(10) < 5,
                    .Height = Math.Round((1.5 + (Random(450) * 0.001)), 2),
                    .Car = RandomCar
                }
                Return person
            End Get
        End Property

        Private ReadOnly Property RandomAddress As Address
            Get
                Dim location As Location = RandomLocation
                Dim address As Address = New Address With {
                    .Street = RandomStreet,
                    .Number = 1 + Random(1000),
                    .City = location.Name,
                    .Country = location.Country
                }
                Return address
            End Get
        End Property

        Private ReadOnly Property RandomCar As Car
            Get
                Dim car As Car = New Car With {
                    .Manufacturer = Random(6),
                    .kW = 50 + Random(150),
                    .Motor = Random(4),
                    .AllWheelDrive = Random(10) < 5
                }
                Return car
            End Get
        End Property
    End Module
End Namespace
