Public Class MainWindow

    Private Sub MainWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim bytes() As Byte
        Label2.Text = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Wow6432Node\Futuremark\3DMark\InstallationInfo\", "TargetDir", "")
        If Label2.Text = Nothing Then
            Label2.Text = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Futuremark\3DMark\InstallationInfo\", "TargetDir", "")
        End If
        Label2.Text += "\data0001.dat"

        Select Case ComboBox1.Text
            Case "Ice Storm GT1 - Reduced Render Time"
                bytes = IO.File.ReadAllBytes(Label2.Text)
                bytes(91490) = System.Text.UnicodeEncoding.Default.GetBytes(">")(0)
                bytes(91491) = System.Text.UnicodeEncoding.Default.GetBytes(">")(0)
                IO.File.WriteAllBytes(Label2.Text, bytes)

            Case "Ice Storm GT2 - Reduced Render Time"
                bytes = IO.File.ReadAllBytes(Label2.Text)
                bytes(91852) = System.Text.UnicodeEncoding.Default.GetBytes(">")(0)
                bytes(91853) = System.Text.UnicodeEncoding.Default.GetBytes(">")(0)
                IO.File.WriteAllBytes(Label2.Text, bytes)

            Case "Ice Storm Physics - Reduced Render Time"
                bytes = IO.File.ReadAllBytes(Label2.Text)
                bytes(91187) = System.Text.UnicodeEncoding.Default.GetBytes("¾")(0)
                IO.File.WriteAllBytes(Label2.Text, bytes)

            Case "Cloud Gate GT1 - Reduced Render Time"
                bytes = IO.File.ReadAllBytes(Label2.Text)
                bytes(99768) = System.Text.UnicodeEncoding.Default.GetBytes(">")(0)
                bytes(99769) = System.Text.UnicodeEncoding.Default.GetBytes(">")(0)
                IO.File.WriteAllBytes(Label2.Text, bytes)

            Case "Cloud Gate GT2 - Reduced Render Time"
                bytes = IO.File.ReadAllBytes(Label2.Text)
                bytes(100992) = System.Text.UnicodeEncoding.Default.GetBytes(">")(0)
                bytes(100993) = System.Text.UnicodeEncoding.Default.GetBytes(">")(0)
                IO.File.WriteAllBytes(Label2.Text, bytes)

            Case "Cloud Gate Physics - Reduced Render Time"
                bytes = IO.File.ReadAllBytes(Label2.Text)
                bytes(99448) = System.Text.UnicodeEncoding.Default.GetBytes("ž")(0)

                IO.File.WriteAllBytes(Label2.Text, bytes)

            Case Else

        End Select
    End Sub
End Class