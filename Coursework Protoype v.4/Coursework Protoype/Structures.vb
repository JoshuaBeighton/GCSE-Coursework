Public Module storage
    Public AllOrders As New List(Of Order)
    Public AllStock As New List(Of Stock)
    Public AllOrderStock As New List(Of orderStock)
    Public AllUsers As New List(Of user)
End Module
Public Structure Order
    Dim id As Integer
    Dim customer As String 'this will be changed to integer in the production model, however i do not have a database to index to in this prototype, so just the name will suffice
    Dim due As Date
    Dim price As Decimal
End Structure

Public Structure Stock
    Dim ID As Integer
    Dim type As String
    Dim part As String 'there is not a part for the prototype so i will store this as a string of the name
    Dim ordered As Date
    Dim Due As Date
    Dim arrived As Boolean
    Dim cost As Integer
End Structure

Public Structure orderStock
    Dim ID As Integer
    Dim order As Integer
    Dim stock As Integer
End Structure

Public Structure user
    Dim ID As Integer
    Dim username As String
    Dim password As String
    Dim permission As Char
End Structure
