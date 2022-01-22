Public Class Form3


    Dim z As String
    Dim s0(,) As String = {{"01", "00", "11", "10"}, {"11", "10", "01", "00"}, {"00", "10", "01", "11"}, {"11", "01", "11", "10"}}
    Dim s1(,) As String = {{"00", "01", "10", "11"}, {"10", "00", "01", "11"}, {"11", "00", "01", "10"}, {"10", "01", "00", "11"}}

    'Variables in step 1 :
    Dim LP As String
    Dim RP As String
    Dim LSE As String     ' LSE----> for the left side do shift ( E---> expon)
    Dim RSE As String     ' RSE----> for the right side do shift ( E---> expon)
    Dim rowl As String   ' S0
    Dim coll As String   ' S0
    Dim rowR As String   ' S1
    Dim colR As String   ' S1
    Dim cont As String
    Dim result1 As String  ' for the final answer in s0
    Dim result2 As String  ' for the final answer in s1

    Dim ro As String
    Dim co As String
    Dim ro1 As String
    Dim co1 As String




    'Variables in step 2 :
    Dim LP2 As String
    Dim RP2 As String
    Dim LSE2 As String     ' LSE2----> for the left side do shift ( E---> expon) 
    Dim RSE2 As String     ' RSE2----> for the left side do shift ( E---> expon) 
    Dim cont2 As String
    Dim cont3 As String
    Dim cont4 As String
    Dim result4 As String  ' for the final answer in s0
    Dim result5 As String  ' for the final answer in s1
    Dim rowl2 As String   ' S0
    Dim coll2 As String   ' S0
    Dim rowR2 As String   ' S1
    Dim colR2 As String   ' S1
    Dim ro2 As String
    Dim co2 As String
    Dim ro3 As String
    Dim co3 As String






    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'STEP 1


        z = t1.Text



        For ii As Integer = 8 To z.Length Step 8

            Dim a As String = ""
            Dim c As String = ""
            Dim s As String = ""
            Dim c2 As String = ""
            Dim c3 As String = ""
            Dim rr As String = ""
            Dim rr1 As String = ""
            Dim rr2 As String = ""
            Dim result3 As String = ""


            For jj As Integer = ii - 8 To ii - 1
                a &= z.Chars(jj)

            Next


            Dim k1 As String = Form1.t2.Text
            t3.Text = k1
            Dim k2 As String = Form1.t3.Text
            t4.Text = k2

            Dim IP As String     ' IP = (2,6,3,1,4,8,5,7)
            IP = (a.Chars(1) & a.Chars(5) & a.Chars(2) & a.Chars(0) & a.Chars(3) & a.Chars(7) & a.Chars(4) & a.Chars(6))


            LP = (IP.Chars(0) & IP.Chars(1) & IP.Chars(2) & IP.Chars(3))
            RP = (IP.Chars(4) & IP.Chars(5) & IP.Chars(6) & IP.Chars(7))


            Dim Expo As String = ""          'Expo = (4,1,2,3,2,3,4,1)
            Expo = (RP.Chars(3) & RP.Chars(0) & RP.Chars(1) & RP.Chars(2) & RP.Chars(1) & RP.Chars(2) & RP.Chars(3) & RP.Chars(0))


            'XOR

            For i As Integer = 0 To 7
                If Expo.Chars(i) = k2.Chars(i) Then
                    rr &= "0"
                Else
                    rr &= "1"
                End If
            Next

            c &= rr



            LSE = (c.Chars(0) & c.Chars(1) & c.Chars(2) & c.Chars(3))
            RSE = (c.Chars(4) & c.Chars(5) & c.Chars(6) & c.Chars(7))



            rowl = (LSE.Chars(0) & LSE.Chars(3))
            coll = (LSE.Chars(1) & LSE.Chars(2))

            'S-BOX
            If rowl = "00" Then
                ro = 0
            ElseIf rowl = "01" Then
                ro = 1
            ElseIf rowl = "10" Then
                ro = 2
            Else
                ro = 3
            End If
            ''''''''''''''''''''''''
            If coll = "00" Then
                co = 0
            ElseIf coll = "01" Then
                co = 1
            ElseIf coll = "10" Then
                co = 2
            Else
                co = 3
            End If

            result1 = s0(ro, co)



            rowR = (RSE.Chars(0) & RSE.Chars(3))
            colR = (RSE.Chars(1) & RSE.Chars(2))

            'S-BOX
            If rowR = "00" Then
                ro1 = 0
            ElseIf rowR = "01" Then
                ro1 = 1
            ElseIf rowR = "10" Then
                ro1 = 2
            Else
                ro1 = 3
            End If
            ''''''''''''''''''''''''
            If colR = "00" Then
                co1 = 0
            ElseIf colR = "01" Then
                co1 = 1
            ElseIf colR = "10" Then
                co1 = 2
            Else
                co1 = 3
            End If


            result2 = s1(ro1, co1)


            cont = result1 & result2


            Dim p4 As String = ""    ' p4 = (2,4,3,1)
            p4 = (cont.Chars(1) & cont.Chars(3) & cont.Chars(2) & cont.Chars(0))


            'XOR
            For q As Integer = 0 To 3
                If p4.Chars(q) = LP.Chars(q) Then
                    s &= "0"
                Else
                    s &= "1"
                End If
            Next

            result3 &= s


            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            'STEP 2

            cont2 = RP & result3


            LP2 = (cont2.Chars(0) & cont2.Chars(1) & cont2.Chars(2) & cont2.Chars(3))
            RP2 = (cont2.Chars(4) & cont2.Chars(5) & cont2.Chars(6) & cont2.Chars(7))


            Expo = (RP2.Chars(3) & RP2.Chars(0) & RP2.Chars(1) & RP2.Chars(2) & RP2.Chars(1) & RP2.Chars(2) & RP2.Chars(3) & RP2.Chars(0))


            'XOR
            For j As Integer = 0 To 7
                If Expo.Chars(j) = k1.Chars(j) Then
                    rr1 &= "0"
                Else
                    rr1 &= "1"
                End If
            Next

            c2 &= rr1




            LSE2 = (c2.Chars(0) & c2.Chars(1) & c2.Chars(2) & c2.Chars(3))
            RSE2 = (c2.Chars(4) & c2.Chars(5) & c2.Chars(6) & c2.Chars(7))


            rowl2 = (LSE2.Chars(0) & LSE2.Chars(3))
            coll2 = (LSE2.Chars(1) & LSE2.Chars(2))

            'S-BOX
            If rowl2 = "00" Then
                ro2 = 0
            ElseIf rowl2 = "01" Then
                ro2 = 1
            ElseIf rowl2 = "10" Then
                ro2 = 2
            Else
                ro2 = 3
            End If
            ''''''''''''''''''''''''
            If coll2 = "00" Then
                co2 = 0
            ElseIf coll2 = "01" Then
                co2 = 1
            ElseIf coll2 = "10" Then
                co2 = 2
            Else
                co2 = 3
            End If

            result4 = s0(ro2, co2)


            rowR2 = (RSE2.Chars(0) & RSE2.Chars(3))
            colR2 = (RSE2.Chars(1) & RSE2.Chars(2))

            'S-BOX
            If rowR2 = "00" Then
                ro3 = 0
            ElseIf rowR2 = "01" Then
                ro3 = 1
            ElseIf rowR2 = "10" Then
                ro3 = 2
            Else
                ro3 = 3
            End If
            ''''''''''''''''''''''''
            If colR2 = "00" Then
                co3 = 0
            ElseIf colR2 = "01" Then
                co3 = 1
            ElseIf colR2 = "10" Then
                co3 = 2
            Else
                co3 = 3
            End If

            result5 = s1(ro3, co3)



            cont3 = result4 & result5


            p4 = (cont3.Chars(1) & cont3.Chars(3) & cont3.Chars(2) & cont3.Chars(0))


            'XOR
            For w As Integer = 0 To 3
                If LP2.Chars(w) = p4.Chars(w) Then
                    rr2 &= "0"
                Else
                    rr2 &= "1"
                End If
            Next
            c3 &= rr2


            cont4 = c3 & RP2


            Dim IPInverse As String = ""  ' IP ^ -1 = (4,1,3,5,7,2,8,6)
            IPInverse = (cont4.Chars(3) & cont4.Chars(0) & cont4.Chars(2) & cont4.Chars(4) & cont4.Chars(6) & cont4.Chars(1) & cont4.Chars(7) & cont4.Chars(5))


            t2.Text &= IPInverse


        Next


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Me.Close()
        Form1.Show()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        If (OpenFileDialog1.ShowDialog = DialogResult.OK) Then
            t1.Text = My.Computer.FileSystem.ReadAllText(OpenFileDialog1.FileName)
        End If

        If OpenFileDialog1.FileName = "" Then
            Exit Sub
        End If

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim str = t2.Text
        Dim tempString As String = ""
        Dim Character As String = System.Text.RegularExpressions.Regex.Replace(str, " [^ 0 1] ", "")
        Dim Bytes((Character.Length / 8) - 1) As Byte
        For Index As Integer = 0 To Bytes.Length - 1
            Bytes(Index) = Convert.ToByte(Character.Substring(Index * 8, 8), 2)
        Next
        tempString = System.Text.ASCIIEncoding.ASCII.GetString(Bytes)
        t5.Text = tempString

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        Dim writer As New System.IO.StreamWriter("C:\Folder\Text.txt")

        writer.Write(t5.Text)
        writer.Close()
        MessageBox.Show("Exported")
    End Sub
End Class