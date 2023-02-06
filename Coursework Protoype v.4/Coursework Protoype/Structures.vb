Public Module storage
    'store all of the order data
    Public AllOrders As New List(Of Order)
    'store all of the stock data
    Public AllStock As New List(Of Stock)
    'store all of the orderstock data
    Public AllOrderStock As New List(Of orderStock)
    'store all of the user data
    Public AllUsers As New List(Of user)
End Module

'structure for storing data about an order
Public Structure Order
    'id of the order (PK)
    Dim id As Integer
    'store which customer the order belongs to
    Dim customer As String 'this will be changed to integer in the production model, however i do not have a database to index to in this prototype, so just the name will suffice
    'store the date the order is due
    Dim due As Date
    'store the price of the order
    Dim price As Decimal
End Structure


'structure for storing data about stock
Public Structure Stock
    'id of the stock (PK)
    Dim ID As Integer
    'type of part
    Dim type As String
    'part type
    Dim part As String 'there is not a part for the prototype so i will store this as a string of the name
    'date stock was ordered
    Dim ordered As Date
    'date stock is due
    Dim Due As Date
    'date stock arrived
    Dim arrived As Boolean
    'cost of stock
    Dim cost As Integer
End Structure

'structure for linking orders and stock items
Public Structure orderStock
    'id of orderstock
    Dim ID As Integer
    'order id
    Dim order As Integer
    'stock ID
    Dim stock As Integer
End Structure

'structure for storing data abour a user
Public Structure user
    'store the ID of the user
    Dim ID As Integer
    'store the users username
    Dim username As String
    'store the users password
    Dim password As String
    'store the permission level of the user as a char
    Dim permission As Char
End Structure
