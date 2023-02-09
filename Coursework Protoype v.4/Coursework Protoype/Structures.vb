Public Module storage
    'store all of the order data
    Public AllOrders As New List(Of Order)
    'store all of the stock data
    Public AllStock As New List(Of Stock)
    'store all of the orderstock data
    Public AllOrderStock As New List(Of orderStock)
    'store all of the user data
    Public AllUsers As New List(Of user)
    Public AllCPUs As New List(Of CPU)
    Public AllGPUs As New List(Of GPU)
    Public AllRAMs As New List(Of RAM)
    Public AllCases As New List(Of cases)
    Public AllMoba As New List(Of motherboard)
    Public AllStorage As New List(Of store)
    Public AllPSUs As New List(Of PSU)


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

Public Structure CPU
    Dim ID As Integer
    Dim name As String
    Dim manufacturer As String
    Dim socket As String
    Dim cores As String
    Dim baseSpeed As Decimal
    Dim boostSpeed As Decimal
    Dim TPD As Integer
    Dim price As Decimal
End Structure

Public Structure RAM
    Dim ID As Integer
    Dim name As String
    Dim manufacturer As String
    Dim latency As Integer
    Dim speed As Integer
    Dim ddr As Integer
    Dim tpd As Integer
    Dim dims As Integer
    Dim price As Decimal
End Structure

Public Structure GPU
    Dim ID As Integer
    Dim Series As String
    Dim Model As String
    Dim manufacturer As String
    Dim chipManufacturer As String
    Dim baseClock As Integer
    Dim VRAM As Decimal
    Dim price As Decimal
End Structure

Public Structure PSU
    Dim ID As Integer
    Dim name As String
    Dim manufacturer As String
    Dim efficiency As String
    Dim modular As String
    Dim power As Integer
    Dim price As Decimal
End Structure

Public Structure motherboard
    Dim id As Integer
    Dim name As String
    Dim manufacturer As String
    Dim ramSlots As Integer
    Dim socket As String
    Dim SATAs As Integer
    Dim m2s As Integer
    Dim price As Decimal
End Structure

Public Structure store
    Dim ID As Integer
    Dim name As String
    Dim manufacturer As String
    Dim type As String
    Dim speed As Integer
    Dim capacity As Decimal
    Dim connection As Decimal
    Dim price As Decimal
End Structure

Public Structure cases
    Dim id As Integer
    Dim name As Integer
    Dim manufacturer As String
    Dim HDDs As Integer
    Dim SSDs As Integer
    Dim price As Decimal
End Structure