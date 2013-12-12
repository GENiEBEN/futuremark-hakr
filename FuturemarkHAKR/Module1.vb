Imports System.Environment
Module Module1

    'Sub Main()
    '    Dim s() As String = GetCommandLineArgs()
    '    Dim filenameIn As String = Mid(s(1), 2, Len(s(1)) - 1)
    '    Dim filenameOut As String = Mid(s(2), 2, Len(s(2)) - 1)
    '    Dim benchname As String = Mid(s(3), 2, Len(s(3)) - 1)
    '    Dim hackname As String = Mid(s(4), 2, Len(s(4)) - 1)


    '    Console.WriteLine("Reading " & filenameIn)
    '    Dim bytes() As Byte = IO.File.ReadAllBytes(filenameIn)
    '    For i As Integer = 0 To (bytes.Length - 1)

    '        'If bytes(i) = &H19 Then bytes(i) = System.Text.Encoding.ASCII.GetBytes("K")(0) 'EM
    '        'If bytes(i) = System.Text.UnicodeEncoding.Default.GetBytes("~")(0) Then bytes(i) = System.Text.Encoding.ASCII.GetBytes("=")(0)

    '        Select Case benchname
    '            Case "1" '3Dmark12 for Windows

    '            Case "2" '3DMark11

    '        End Select






    '    Next
    '    Console.WriteLine("Saved as " & filenameOut)
    '    IO.File.WriteAllBytes(filenameOut, bytes)
    '    'Console.ReadKey()
    'End Sub

End Module
