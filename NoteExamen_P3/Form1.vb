Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'On ajoute des valeurs dans notre liste 
        ComboBox1.Items.Add(TextBox1.Text)
        Dim x As Integer = CInt(TextBox1.Text)
        If x <= 100 And x >= 90 Then
            Dim excellent As Integer = 0
            excellent = excellent + 1
            Label3.Text = excellent
            MsgBox("val" & Label3.Text)
        End If
        TextBox1.Clear()
        'Label1.Text = ComboBox1.Items.Count()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Label1.Text = ComboBox1.Items.Count()
        '  Dim excellent As Integer = CInt(Label3.Text)
        For i As Integer = 0 To (ComboBox1.Items.Count() - 1) Step 1
            If CInt(ComboBox1.Items(i)) <= 100 And CInt(ComboBox1.Items(i)) >= 90 Then
                ' MsgBox(" excellent" & CInt(ComboBox1.Items(i)))
                Dim excellent As Integer = 0
                excellent = excellent + 1
                Label6.Text = excellent
                ' MsgBox("val" & Label3.Text)

            ElseIf CInt(ComboBox1.Items(i)) <= 89 And CInt(ComboBox1.Items(i)) >= 80 Then
                Dim Tbon As Integer = 0
                Tbon = Tbon + 1
                Label7.Text = Tbon
                'MsgBox("Bon 80")

            ElseIf CInt(ComboBox1.Items(i)) <= 79 And CInt(ComboBox1.Items(i)) >= 70 Then
                Dim bon As Integer = 0
                bon = bon + 1
                Label8.Text = bon
                ' MsgBox("Bon 70")

            ElseIf CInt(ComboBox1.Items(i)) <= 69 And CInt(ComboBox1.Items(i)) >= 60 Then
                Dim Aameliorer As Integer = 0
                Aameliorer = Aameliorer + 1
                Label9.Text = Aameliorer
                'MsgBox("Bon 60")

            ElseIf CInt(ComboBox1.Items(i)) <= 59 And CInt(ComboBox1.Items(i)) >= 0 Then
                Dim Insatis As Integer = 0
                Insatis += 1
                Label11.Text = Insatis
                'MsgBox("Bon 50")

            End If
        Next
    End Sub

    Private Sub InformationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InformationToolStripMenuItem.Click
        MsgBox("Nom du projet : Note_Examen 
                Langage utilisé est Vba
                Programmé par Hamet DIOP
")
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub
End Class
