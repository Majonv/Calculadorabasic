Public Class Interfaz

    Private Sub Interfaz_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub Botton1_Click(sender As Object, e As EventArgs) Handles btSUMAR.Click

        Dim num1, num2, res As Double
        num1 = TextBox1.Text
        num2 = TextBox2.Text

        res = num1 + num2

        Label1.Text = res

    End Sub

    Private Sub Botton4_Click(sender As Object, e As EventArgs) Handles btRESTAR.Click
        Dim num1, num2, res As Double
        num1 = TextBox1.Text
        num2 = TextBox2.Text

        res = num1 - num2

        Label1.Text = res
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub btMULTIPLICAR_Click(sender As Object, e As EventArgs) Handles btMULTIPLICAR.Click
        Dim num1, num2, res As Double
        num1 = TextBox1.Text
        num2 = TextBox2.Text

        res = num1 * num2

        Label1.Text = res
    End Sub

    Private Sub btDIVIDIR_Click(sender As Object, e As EventArgs) Handles btDIVIDIR.Click

        Dim num1, num2, res As Double
        num1 = TextBox1.Text
        num2 = TextBox2.Text

        res = num1 / num2

        Label1.Text = res
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class
