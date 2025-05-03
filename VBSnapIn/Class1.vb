Imports CommonSnappableTypes
<CompanyInfo (CompanyName:="Chunky's Software",
              CompanyUrl:="www.ChunkySoft.com")>
Public Class VBSnapIn
    Implements IAppFunctionality
    Public Sub DoIt() Implements CommonSnappableTypes.IAppFunctionality.DoIt
        Console.WriteLine("You have just used the VB snap in!")
    End Sub
End Class