Public Class Form1
    Dim palabras() As String = {"Spiderman", "Hulk", "Batman", "HawkEye", "Iron Man"}
    Dim palabraSeleccionada As String
    Dim PalabraAMostrar As String = ""
    Dim Terminado As Boolean = False
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim generador As New Random()
        palabraSeleccionada = palabras(generador.Next(0, palabras.Length))

        For i As Integer = 0 To palabraSeleccionada.Length - 1
            If (palabraSeleccionada(i) = " ") Then
                PalabraAMostrar += " "
            Else
                PalabraAMostrar += "-"
            End If
        Next
        lblPalabra.Text = PalabraAMostrar
    End Sub

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        Dim PalabraConLetraAcertada As String = ""
        Dim LetraActual As String = txtLetra.Text

        For i As Integer = 0 To palabraSeleccionada.Length - 1
            If (LetraActual = palabraSeleccionada(i)) Then
                PalabraConLetraAcertada += LetraActual
            Else
                PalabraConLetraAcertada += PalabraAMostrar(i)
            End If
        Next
        PalabraAMostrar = PalabraConLetraAcertada
        lblPalabra.Text = PalabraAMostrar

        If Not PalabraAMostrar.Contains("-") Then
            Terminado = True
            MsgBox("Ganaste!!!!")
            txtLetra.Enabled = False
            btnIngresar.Enabled = False
        End If
    End Sub
End Class
