Public Class Form1
    Private Sub AceptarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AceptarToolStripMenuItem.Click
        If index < 9 Then

            Nombre(index) = TxtNombre.Text
            Valor(index) = TxtValor.Text
            Peso(index) = TxtPeso.Text
            Impuesto(index) = Impuesto(index)

            If CbxForma.SelectedItem = "Camión" Then
                Pagoparcial(index) = pagocamion + Valor(index)
            ElseIf CbxForma.SelectedItem = "Motocicleta" Then
                Pagoparcial(index) = Valor(index) + pagomoto
            End If

            If CbxTipos.SelectedItem = "Documentos" Then
                Impuesto(index) = porcentajedocumentos * Pagoparcial(index)
            ElseIf CbxTipos.SelectedItem = "Ropa" Then
                Impuesto(index) = porcentajeropa * Pagoparcial(index)
            ElseIf CbxTipos.SelectedItem = "Artículos no pedecederos" Then
                Impuesto(index) = porcentajepedecederos * Pagoparcial(index)
            ElseIf CbxTipos.SelectedItem = "Artículos de plástico" Then
                Impuesto(index) = porcentajeplastico * Pagoparcial(index)
            ElseIf CbxTipos.SelectedItem = "Lociones" Then
                Impuesto(index) = porcentajelociones * Pagoparcial(index)

            End If

            PagoTotal(index) = Pagoparcial(index) + Impuesto(index)



            DataGridView1.Rows.Add(Nombre(index), Valor(index), Peso(index), Pagoparcial(index), Impuesto(index), PagoTotal(index))

                index = 0 + 1

            End If
    End Sub

    Private Sub EntradasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EntradasToolStripMenuItem.Click
        limpiar_Entrada()

    End Sub

    Private Sub VectoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VectoresToolStripMenuItem.Click
        limpiar_vectores()

    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        If MsgBox("¿Desea Salir?", vbYesNo) = vbYes Then
        End If
    End Sub
End Class
