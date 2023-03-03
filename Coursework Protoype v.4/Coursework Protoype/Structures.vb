Public Module Structures
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
    Public AllLogs As New List(Of log)

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
    Dim part As Integer 'there is not a part for the prototype so i will store this as a string of the name
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


'structure for storing data about a CPU
Public Structure CPU
    'store the ID of the CPU (PK)
    Dim ID As Integer
    'store the name of the CPU
    Dim name As String
    'store who manufactured the CPU
    Dim manufacturer As String
    'store what socket the CPU uses
    Dim socket As String
    'store how many cores the CPU has
    Dim cores As String
    'store the baseSpeed of the CPU
    Dim baseSpeed As Decimal
    'store the boosted speed (max speed) of the CPU
    Dim boostSpeed As Decimal
    'store how much power the CPU takes
    Dim TPD As Integer
    'store the price of the CPU
    Dim price As Decimal
End Structure


'store data about a RAM item
Public Structure RAM
    'store the ID of the RAM (PK)
    Dim ID As Integer
    'store the name of the RAM
    Dim name As String
    'store the manufacturer of the RAM
    Dim manufacturer As String
    'store the latency of the RAM
    Dim latency As Integer
    'store the speed of the RAM
    Dim speed As Integer
    'store what ddr classification the RAM holds
    Dim ddr As Integer
    'store the power draw of the RAM
    Dim tpd As Integer
    'store how many physical sticks of RAM are included in the kit
    Dim dims As Integer
    'store the capacity of the RAM
    Dim capacity As Decimal
    'store the price of the RAM
    Dim price As Decimal
End Structure

'store data about GPUs
Public Structure GPU
    'store the ID of the GPU (PK)
    Dim ID As Integer
    'store the series of the GPU
    Dim Series As String
    'store the model of the GPU
    Dim Model As String
    'store who made the shroud / cooler of the GPU
    Dim manufacturer As String
    'store who made the chip in the GPU
    Dim chipManufacturer As String
    'store the base speed of the GPU
    Dim baseClock As Integer
    'store how much VRAM the GPU has
    Dim VRAM As Decimal
    'store how much power the GPU draws
    Dim TPD As Integer
    'store the price of the GPU
    Dim price As Decimal
End Structure

'store the data about the PSUs
Public Structure PSU
    'store the ID of the PSU (PK)
    Dim ID As Integer
    'store the name of the PSU
    Dim name As String
    'store the manufacturer of the PSU
    Dim manufacturer As String
    'store how effecient the PSU is
    Dim efficiency As String
    'store the level of modularity of the PSU
    Dim modular As String
    'store the power that the PSU can require
    Dim power As Integer
    'store the price of the PSU
    Dim price As Decimal
End Structure

'store the data about the motherboards
Public Structure motherboard
    'store the ID of the motherboard (PK)
    Dim id As Integer
    'store the name of the motherboard
    Dim name As String
    'store who manufactured the motherboard
    Dim manufacturer As String
    'store how many ram slots the motherboard has
    Dim ramSlots As Integer
    'store the socket the motherboard has
    Dim socket As String
    'store how many SATA connections the motherboard has
    Dim SATAs As Integer
    'store how many M.2 slots the motherboard has
    Dim m2s As Integer
    'store the price of the motherboard
    Dim price As Decimal
End Structure

'store data about the storage devices
Public Structure store
    'store the ID of the storage device (PK)
    Dim ID As Integer
    'store the name of the storage device
    Dim name As String
    'store the manufacturer of the storage device 
    Dim manufacturer As String
    'store what type of storage it is (HDD/SSD)
    Dim type As String
    'store what speed the storage reads at
    Dim read As Integer
    'store what speed the storage writes at
    Dim write As Integer
    'store the capacity of the storage device
    Dim capacity As Decimal
    'store what connection the storage uses
    Dim connection As String
    'store the price of the storage device
    Dim price As Decimal
End Structure

'store the data about cases
Public Structure cases
    'store the ID of the Case (PK)
    Dim id As Integer
    'Store the name of the case
    Dim name As String
    'store the manufacturer of the case
    Dim manufacturer As String
    'store how many HDD slots the motherboard has
    Dim HDDs As Integer
    'store how many SSD slots the motherboard has
    Dim SSDs As Integer
    'store the price of the motherboard
    Dim price As Decimal
End Structure

Public Structure log
    Dim id As Integer
    Dim user As String
    Dim action As String
    Dim data As String
    Dim time As Date
End Structure