
Imports System.Data.SqlClient
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim con As New SqlConnection(My.Settings.conexion)
        Dim sql As String = "SELECT Cod_Estudiante, nombre, meses_pagado, meses_pendiente from PAGO"
        Dim cmd As New SqlCommand(sql, con)

        Try
            Dim da As New SqlDataAdapter(cmd)
            Dim ds As New DataSet

            da.Fill(ds, "PAGO")

            Me.DataGridView1.DataSource = ds.Tables("PAGO")

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub
End Class
