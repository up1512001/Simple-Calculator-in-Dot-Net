Imports System.Data

Class MainWindow
    Private Sub DataGrid_SelectionChanged(sender As Object, e As SelectionChangedEventArgs)

    End Sub

    Private Sub Button_Click_2(sender As Object, e As RoutedEventArgs)
        TextBox1.Text += "1"

    End Sub

    Private Sub Button_Click_3(sender As Object, e As RoutedEventArgs)
        TextBox1.Text += "2"
    End Sub

    Private Sub Button_Click_4(sender As Object, e As RoutedEventArgs)
        TextBox1.Text += "3"
    End Sub

    Private Sub Button_Click_5(sender As Object, e As RoutedEventArgs)
        TextBox1_Copy.Text += TextBox1.Text + "+"
        TextBox1.Text = ""

    End Sub

    Private Sub Button_Click_6(sender As Object, e As RoutedEventArgs)
        TextBox1.Text += "4"
    End Sub

    Private Sub Button_Click_7(sender As Object, e As RoutedEventArgs)
        TextBox1.Text += "5"
    End Sub

    Private Sub Button_Click_8(sender As Object, e As RoutedEventArgs)
        TextBox1.Text += "6"
    End Sub

    Private Sub Button_Click_9(sender As Object, e As RoutedEventArgs)
        TextBox1_Copy.Text += TextBox1.Text + "-"
        TextBox1.Text = ""
    End Sub

    Private Sub Button_Click_10(sender As Object, e As RoutedEventArgs)
        TextBox1.Text += "7"
    End Sub

    Private Sub Button_Click_11(sender As Object, e As RoutedEventArgs)
        TextBox1.Text += "8"
    End Sub

    Private Sub Button_Click_12(sender As Object, e As RoutedEventArgs)
        TextBox1.Text += "9"
    End Sub

    Private Sub Button_Click_13(sender As Object, e As RoutedEventArgs)
        TextBox1_Copy.Text += TextBox1.Text + "*"
        TextBox1.Text = ""
    End Sub

    Private Sub Button_Click_14(sender As Object, e As RoutedEventArgs)
        TextBox1.Text += "0"
    End Sub

    Private Sub Button_Click_15(sender As Object, e As RoutedEventArgs)
        TextBox1.Clear()
        TextBox1_Copy.Clear()

    End Sub

    Private Sub Button_Click_16(sender As Object, e As RoutedEventArgs)
        Dim temp = TextBox1_Copy.Text + TextBox1.Text
        Dim tbl = New DataTable()
        Dim result = Convert.ToDouble(tbl.Compute(temp, Nothing))
        TextBox1_Copy.Text = result
        TextBox1.Text = ""

    End Sub

    Private Sub Button_Click_17(sender As Object, e As RoutedEventArgs)
        TextBox1_Copy.Text += TextBox1.Text + "/"
        TextBox1.Text = ""
    End Sub


    Private Sub TextBox_TextChanged(sender As Object, e As TextChangedEventArgs)

    End Sub
End Class
