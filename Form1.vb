Public Class Form1


    Dim x As String
    Dim Lk As String 'Lk= left k
    Dim Rk As String    'Rk= Right key 
    Dim LSk As String 'LSk= left(left sh) k
    Dim RSk As String    'RSk= Right(left sh) key 
    Dim P8o As String '' (6,3,7,4,8,5,10,9)
    Dim k1 = P8o
    Dim LS_2 As String    'LSk= left(2left shift) Lkey
    Dim RS_2 As String    'RSk= Right(2left shift) Rkey 
    Dim P8t As String '' permitation eight (6,3,7,4,8,5,10,9)
    Dim k2 = P8t
    Dim cont1 As String
    Dim cont2 As String


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        x = t1.Text

        Dim P10 As String   'P10 = permutation ten one  (3,5,2,7,4,10,1,9,8,6)
        P10 = (x.Chars(2) & x.Chars(4) & x.Chars(1) & x.Chars(6) & x.Chars(3) & x.Chars(9) & x.Chars(0) & x.Chars(8) & x.Chars(7) & x.Chars(5))




        '  Dim Lk As String    'Lk= left k
        '  Dim Rk As String    'Rk= Right key 
        Lk = (P10.Chars(0) & P10.Chars(1) & P10.Chars(2) & P10.Chars(3) & P10.Chars(4))
        Rk = (P10.Chars(5) & P10.Chars(6) & P10.Chars(7) & P10.Chars(8) & P10.Chars(9))





        'Dim LSk As String    'LSk= left(left sh) Lkey
        'Dim RSk As String    'RSk= Right(left sh) Rkey 
        LSk = (Lk.Chars(1) & Lk.Chars(2) & Lk.Chars(3) & Lk.Chars(4) & Lk.Chars(0))
        RSk = (Rk.Chars(1) & Rk.Chars(2) & Rk.Chars(3) & Rk.Chars(4) & Rk.Chars(0))


        cont1 = LSk & RSk





        'P8o = permutation eight one (6,3,7,4,8,5,10,9) 
        P8o = (cont1.Chars(5) & cont1.Chars(2) & cont1.Chars(6) & cont1.Chars(3) & cont1.Chars(7) & cont1.Chars(4) & cont1.Chars(9) & cont1.Chars(8))

        t2.Text = P8o

        Dim LLS_2 As String    'LSk= left(2left shift) Lkey
        Dim RRS_2 As String    'RSk= Right(2left shift) Rkey 

        LLS_2 = (LSk.Chars(2) & LSk.Chars(3) & LSk.Chars(4) & LSk.Chars(0) & LSk.Chars(1))
        RRS_2 = (RSk.Chars(2) & RSk.Chars(3) & RSk.Chars(4) & RSk.Chars(0) & RSk.Chars(1))



        cont2 = LLS_2 & RRS_2

        P8t = (cont2.Chars(5) & cont2.Chars(2) & cont2.Chars(6) & cont2.Chars(3) & cont2.Chars(7) & cont2.Chars(4) & cont2.Chars(9) & cont2.Chars(8))

        t3.Text = P8t



    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click


        Me.Hide()
        Form2.Show()



    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Me.Hide()
        Form3.Show()


    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If (OpenFileDialog1.ShowDialog = DialogResult.OK) Then
            t1.Text = My.Computer.FileSystem.ReadAllText(OpenFileDialog1.FileName)
        End If

        If OpenFileDialog1.FileName = "" Then
            Exit Sub
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        Dim writer As New System.IO.StreamWriter("C:\Folder\key1.txt")

        writer.Write(t2.Text)
        writer.Close()
        MessageBox.Show("Exported")


    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

        Dim writer As New System.IO.StreamWriter("C:\Folder\key2.txt")

        writer.Write(t3.Text)
        writer.Close()
        MessageBox.Show("Exported")


    End Sub
End Class
