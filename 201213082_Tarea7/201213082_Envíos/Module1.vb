Module Module1
    Public index = 0


    Public Nombre(10) As String
    Public Valor(10) As Double
    Public Peso(10) As Double
    Public Pagoparcial(10) As Double
    Public Impuesto(10) As Double
    Public PagoTotal(10) As Double
    Public Formaenvio(10) As Double



    Public Const porcentajedocumentos = 0.015
    Public Const porcentajeropa = 0.06
    Public Const porcentajepedecederos = 0.055
    Public Const porcentajeplastico = 0.045
    Public Const porcentajelociones = 0.02
    Public Const pagocamion = 50
    Public Const pagomoto = 15




    Sub limpiar_vectores()
        Form1.DataGridView1.Rows.Clear()

        index = 0

    End Sub

    Sub limpiar_Entrada()
        Form1.TxtNombre.Text = 0
        Form1.TxtPeso.Text = 0
        Form1.TxtValor.Text = 0
        Form1.CbxTipos.SelectedIndex = False
        Form1.CbxForma.SelectedIndex = False


    End Sub

End Module
