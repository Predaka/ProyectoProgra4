Imports Microsoft.VisualBasic

Public Module ModuloDB

#Region "General"
    Dim DB As New Data.OleDb.OleDbConnection
    Public Sub ConectarDB()
        DB.Close()
        DB.ConnectionString = "Provider=SQLOLEDB.1;Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Music;Data Source=EQUIPO"
        DB.Open()
    End Sub

    Public Sub DesconectarDB()
        DB.Close()
    End Sub

    Public Sub EjecutaSQL(ByVal SQL As String) ' recibe insert, update,delete
        ConectarDB()

        Dim Comando As New Data.OleDb.OleDbCommand(SQL, DB)
        Comando.ExecuteNonQuery()

        DesconectarDB()
    End Sub

    Public Sub LlenarDS(ByRef DS As Data.DataSet, ByVal SQL As String) ' recibe Select y lo devuelve en un Objeto DataSet
        ConectarDB()

        Dim Adaptador As New Data.OleDb.OleDbDataAdapter(SQL, DB)
        Adaptador.Fill(DS)

        DesconectarDB()
    End Sub

    Public Function DatoRepetidoDB(ByVal Tabla As String, ByVal CampoLlave As String, ByVal Valor As String) As Boolean
        Dim SQL As String
        Dim DS As New Data.DataSet

        SQL = "select * from " & Tabla & " where " & CampoLlave & " = '" & Valor & "'"

        LlenarDS(DS, SQL)

        If DS.Tables(0).Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function VerificarVoto(ByVal Tabla As String, ByVal CampoLlave As String, ByVal Valor As String, ByVal user As String) As Boolean
        Dim SQL As String
        Dim DS As New Data.DataSet

        SQL = "select * from " & Tabla & " where " & CampoLlave & " = '" & Valor & "' and Email = '" & user & "';"

        LlenarDS(DS, SQL)

        If DS.Tables(0).Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
#End Region
#Region "Inserts"
    Public Function insertarUsuario(ByVal cedula As Integer, ByVal nombre As String, ByVal pass As String, ByVal email As String, ByVal provincia As String, ByVal direccion As String, ByVal fecha As Date) As Boolean
        Dim SQL As String
        Dim DS As New Data.DataSet

        SQL = "insert into Usuarios values(" & cedula & ",'" & nombre & "','" & pass & "','" & email & "','" & provincia & "','" & direccion & "','" & fecha & "');"

        If DatoRepetidoDB("Usuarios", "cedula", cedula) Then
            Return False
            Exit Function
        Else
            EjecutaSQL(SQL)
            Return True
        End If

        Return True
    End Function
    Public Function insertarSolicitud(ByVal email As String, ByVal asunto As String, ByVal descripcion As String) As Boolean
        Dim SQL As String
        Dim DS As New Data.DataSet
        Dim FechaLocal = DateTime.UtcNow
        SQL = "insert into Solicitudes values(GETDATE(),'" & email & "','" & asunto & "','" & descripcion & "',null);"

        If DatoRepetidoDB("Solicitudes", "Asunto", asunto) Then
            Return False
            Exit Function
        Else
            EjecutaSQL(SQL)
            Return True
        End If

        Return True
        Return True
    End Function
    Public Function insertarVoto(ByVal id As String, ByVal user As String) As Boolean
        Dim SQL As String
        Dim DS As New Data.DataSet
        Dim FechaLocal = DateTime.UtcNow
        SQL = "insert into Votos values(GETDATE()," & id & ",'" & user & "');"
        EjecutaSQL(SQL)
        Return True
    End Function
#End Region
    'Carga de Datos 
    Public Function CargarBandas() As Data.DataSet
        Dim SQL As String
        Dim DS As New Data.DataSet

        SQL = "select idBanda,Nombre,Imagen from Bandas where  estado = 'true'"

        LlenarDS(DS, SQL)

        Return DS
    End Function
    Public Function BandaInfo(ByVal id As Integer) As Data.DataSet
        Dim SQL As String
        Dim DS As New Data.DataSet

        SQL = "select Imagen,Audio,Informacion from Bandas where idBanda = " & id & ""

        LlenarDS(DS, SQL)

        Return DS
    End Function
    Public Function CargarSolicitudes_User(ByVal Valor As String) As Data.DataSet
        Dim SQL As String
        Dim DS As New Data.DataSet

        SQL = "select idSolicitud,Asunto,Descripcion,Estado from Solicitudes where Usuario_Ingresa = '" & Valor & "';"

        LlenarDS(DS, SQL)

        Return DS
    End Function
    Public Function CargarDatosUser(ByVal Valor As String) As Data.DataSet
        Dim SQL As String
        Dim DS As New Data.DataSet

        SQL = "select Nombre,Email,Imagen from Usuarios where Email = '" & Valor & "';"

        LlenarDS(DS, SQL)

        Return DS
    End Function
    Public Function CargarSolicitud(ByVal id As Integer) As Data.DataSet
        Dim SQL As String
        Dim DS As New Data.DataSet

        SQL = "select Asunto,Descripcion from Solicitudes where idSolicitud = '" & id & "';"

        LlenarDS(DS, SQL)

        Return DS
    End Function
End Module
