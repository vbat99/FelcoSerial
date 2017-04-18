Public Structure Customer
    Dim Company As String
    Dim FirstName As String
    Dim LastName As String
    Dim Address1 As String
    Dim Address2 As String
    Dim Address3 As String
    Dim City As String
    Dim PostCode As Integer
    Dim Email As String
    Dim Phone As String
    Sub New(ByVal SetDefaults As Boolean)
        Company = ""
        FirstName = ""
        LastName = ""
        Address1 = ""
        Address2 = ""
        Address3 = ""
        City = ""
        PostCode = Nothing
        Email = ""
        Phone = ""
    End Sub
End Structure
