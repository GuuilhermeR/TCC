Imports System
Imports System.IO
Imports System.Text
Imports System.Drawing
Imports MvtWindowsForms
Imports System.Data.Odbc
Imports System.Reflection
Imports System.Windows.Forms
Imports System.ComponentModel
Imports System.Security.Cryptography
Imports System.Text.RegularExpressions

Public Module modFuncoes

    ' CONEX√O
    Public tipoConexao As System.Type
    Public timerCloseInternal As Integer = 30
    Public retornaConexao As System.Delegate
    Private _conexaoPadrao As MvtConnection.MvtConnection

    ' VARI¡VEIS
    Public codEmpresa As Integer
    Public ttpComentario As New ToolTip
    Public eTag, imgStretch As Integer
    Public eName, strnomeRetorno As String
    Public strDestinoAcesso, strConnSOLCAD, strConnMDB, strConnMDBESP, strConnMDBESP2, strConnDBDEFAULT, strConnDEFAULT, strConnCACHE, strConnMySQL, strConnCACHEMF, strConnCACHEME, strConnEXCEL, strConnEXCELP, strSQL, strSenha, strPrograma, strConsulta, strUsuarioLogado, strSystemName, strSystemDescription, strPassMerisa, strMensagemEstacao, strImpressao, strConnSMPBD, strUseSkin, strTemaUsuario, strTemaPadrao, strFundoUsuario, strCampoKey, strCampoFind, codCheckList, strTipoCotacao, strTipoSugestao, strConnADODEFAULT, strConnBKPSQLSRV As String
    Public strFiltroConsulta, strcodRetorno, strSQLConsultaF3, userConf, strPrimeroCampo, strSelectConsulta, strAssuntoEmail, filtrosConsulta, strUserPlanSPDI, strUserPlanSPDM, strMercado, strCodProduto, strCodRepresentante, strCodCliente, strNomeCliente As String
    Public strTipoValorCompra, strEmailUsuario, strNomeUsuario, strCodGrupoUsuario, strNFeDir As String
    Public usuarioEhAdministrador As Boolean = False

    ' VARI¡VEIS IMPRESS√O DE ETIQUETA
    Public balPorta, balBaudRate, balDataBit, balStopBit, balTimeOut, balParity, balQtdBit, balEmpresa, balPortPrint, balClearForm, balStyle, balPeso, balAllFields, balQtd, balOper As String
    Public formRetorno As Form
    Public controleRet As Control
    Public dataRNC As Date
    Public strCheckPrograma As String
    Public modoConfig, regExiste, modoExcel, modoLocal, margemTotal, curvaItemComercial, curvaItemCtb As Boolean
    Public strRepositorio As String
    Public strRepositorioDesenho As String
    Public strRepositorioGabarito As String
    Public strVersao As String
    Public strVersaoData As Date

    ' VARI¡VEIS DE CONTROLE IMPRESS√O TESTE
    Public dtgLinhaPrint, paginaAtual, intCodGropoUsuario, tipoLiberacaoMR, intNivel As Integer
    Public strComputerName As String = ""
    Dim fluxoTexto As IO.StreamReader
    Public Property ValidarMvtForm As Boolean = True
    Public Property ExecutarComoAdmin As Boolean = False
    Public Property ExecutarComoAdminUsuario As Boolean = False
    Public Property FormMenuType As Type
    Public Property UsuarioLogado As MvtUsuario
    Public Property Conect As MvtConnection.Conect
    Public Property StrUsuarioLogadoToLower As Boolean

    Function CriarConexao(ByVal stringConexao As String) As MvtConnection.MvtConnection
        Dim retorno As MvtConnection.MvtConnection = Nothing
        If tipoConexao Is Nothing Then
            retorno = New MvtConnection.MvtConnection(stringConexao)
        Else
            retorno = Activator.CreateInstance(tipoConexao, stringConexao)
        End If
        retorno.TimerCloseInterval = timerCloseInternal
        Return retorno
    End Function

    Public Property conexaoPadrao As MvtConnection.MvtConnection
        Get
            If retornaConexao Is Nothing Then
                Return _conexaoPadrao
            Else
                Return retornaConexao.DynamicInvoke()
            End If
        End Get
        Set(value As MvtConnection.MvtConnection)
            _conexaoPadrao = value
        End Set
    End Property

    Function mCDec(ByVal vlr As Object) As Decimal
        Dim val As Decimal = 0
        If IsNumeric(vlr) Then
            Try
                If vlr >= Decimal.MinValue And vlr <= Decimal.MaxValue Then
                    val = CDec(vlr)
                End If
            Catch ex As Exception
                val = 0
            End Try
        End If
        Return val
    End Function

    Function mCDbl(ByVal vlr As Object) As Double
        Dim val As Double = 0
        If IsNumeric(vlr) Then
            Try
                If vlr >= Double.MinValue And vlr <= Double.MaxValue Then
                    val = CDbl(vlr)
                End If
            Catch ex As Exception
                val = 0
            End Try
        End If
        Return val
    End Function

    Function mCInt(ByVal vlr As Object) As Integer
        Dim val As Integer = 0
        If IsNumeric(vlr) Then
            If vlr >= Integer.MinValue And vlr <= Integer.MaxValue Then
                val = CInt(vlr)
            End If
        End If
        Return val
    End Function

    Function mCLng(ByVal vlr As Object) As Long
        Dim val As Long = 0
        If IsNumeric(vlr) Then
            If vlr >= Long.MinValue And vlr <= Long.MaxValue Then
                val = CLng(vlr)
            End If
        End If
        Return val
    End Function

    Function mCDate(ByVal value As Object, Optional ByVal retornaHoje As Boolean = False) As Date
        If IsDate(value) Then
            Return CDate(value)
        Else
            If retornaHoje = True Then
                Return Today
            End If
            Return Nothing
        End If
    End Function

    Function mCTimeN(value As Object) As TimeSpan?
        If IsNothing(value) Then Return Nothing
        If IsDBNull(value) Then Return Nothing
        If TypeOf value Is TimeSpan Then Return value
        If TypeOf value Is Date Then Return DirectCast(value, Date).TimeOfDay
        If TypeOf value Is String Then
            Dim result As TimeSpan = Nothing
            If TimeSpan.TryParse(DirectCast(value, String), result) Then
                Return result
            End If
        End If
        Return Nothing
    End Function

    Function mCTimeNToString(value As TimeSpan?) As String
        If value.HasValue Then
            Return value.Value.ToString("hh\:mm")
        End If
        Return String.Empty
    End Function

    Function mCTimeSpan(value As Object) As TimeSpan
        If value IsNot Nothing AndAlso Not IsDBNull(value) AndAlso TypeOf value Is TimeSpan Then
            Return CType(value, TimeSpan)
        Else
            Return Nothing
        End If
    End Function

    Function mCTimeSpanToString(value As Object) As String
        If value IsNot Nothing AndAlso Not IsDBNull(value) AndAlso TypeOf value Is TimeSpan Then
            Return CType(value, TimeSpan).ToString
        Else
            Return String.Empty
        End If
    End Function

    Function ObterFeriados(ByVal dataDe As Date, ByVal dataAte As Date, Optional empresa As Integer = 0) As Dictionary(Of Date, String)
        Dim feriados As New Dictionary(Of Date, String)
        Dim strSQL As String

        Try
            strSQL = "SELECT feriado" & Chr(13) & Chr(10)
            strSQL = strSQL & "FROM Mvt_Menu.Feriados" & Chr(13) & Chr(10)
            strSQL = strSQL & "WHERE feriado>=" & ValueSQLDataCache(dataDe) & Chr(13) & Chr(10)
            strSQL = strSQL & "AND feriado<=" & ValueSQLDataCache(dataAte) & Chr(13) & Chr(10)
            If empresa > 0 Then
                strSQL &= " AND codEmpresa=" & codEmpresa
            End If
        Catch
            strSQL = "SELECT feriado" & Chr(13) & Chr(10)
            strSQL = strSQL & "FROM Mvt_Menu.Feriado" & Chr(13) & Chr(10)
            strSQL = strSQL & "WHERE feriado>=" & ValueSQLDataOracle(dataDe) & Chr(13) & Chr(10)
            strSQL = strSQL & "AND feriado<=" & ValueSQLDataOracle(dataAte) & Chr(13) & Chr(10)
            If empresa > 0 Then
                strSQL &= " AND codEmpresa=" & codEmpresa
            End If
        End Try
        Using dr As IDataReader = conexaoPadrao.ReturnDataReader(strSQL)
            While dr.Read
                Dim data As Date = mCDate(dr("feriado"))
                If data.DayOfWeek = DayOfWeek.Saturday Then
                    feriados.Add(data, FeriadoFDS.Sabado)
                ElseIf data.DayOfWeek = DayOfWeek.Sunday Then
                    feriados.Add(data, FeriadoFDS.Domingo)
                Else
                    feriados.Add(data, FeriadoFDS.Feriado)
                End If
            End While
        End Using

        Return feriados
    End Function

    Public Function ObterAmbientValueEnum(value As [Enum]) As String
        Dim fi As FieldInfo = value.[GetType]().GetField(value.ToString())
        Dim attributes As AmbientValueAttribute() = DirectCast(fi.GetCustomAttributes(GetType(AmbientValueAttribute), False), AmbientValueAttribute())
        If attributes IsNot Nothing AndAlso attributes.Length > 0 Then
            Return attributes(0).Value
        Else
            Return value.ToString()
        End If
    End Function

    Public Function ObterEnumPelaDescricao(ByVal descricao As String, EnumConstant As Object) As [Enum]
        Return ObterEnumPelaDescricao(EnumConstant, descricao)
    End Function

    Public Function ObterEnumPelaDescricao(value As Type, descricao As String) As [Enum]
        For Each t As Object In [Enum].GetValues(value)
            Dim fi As FieldInfo = t.[GetType]().GetField(t.ToString())
            Dim attributes As DescriptionAttribute() = DirectCast(fi.GetCustomAttributes(GetType(DescriptionAttribute), False), DescriptionAttribute())
            If attributes IsNot Nothing AndAlso attributes.Length > 0 Then
                If attributes(0).Description = descricao Then
                    Return t
                End If
            End If
        Next
        Return Nothing
    End Function

    Public Function ObterDescricaoEnum(value As [Enum]) As String
        Dim fi As FieldInfo = value.[GetType]().GetField(value.ToString())
        Dim attributes As DescriptionAttribute() = DirectCast(fi.GetCustomAttributes(GetType(DescriptionAttribute), False), DescriptionAttribute())
        If attributes IsNot Nothing AndAlso attributes.Length > 0 Then
            Return attributes(0).Description
        Else
            Return value.ToString()
        End If
    End Function

    Public Enum FeriadoFDS
        Feriado
        Sabado
        Domingo
    End Enum

    'Function mCdec(ByVal vlr As Object) As Double
    '    Dim val As Double = 0
    '    If IsNumeric(vlr) Then
    '        val = Mcdec(vlr)
    '    End If
    '    Return val
    'End Function
    'Function MCInt(ByVal vlr As Object) As Integer
    '    Dim val As Double = 0
    '    If IsNumeric(vlr) Then
    '        val = CInt(vlr)
    '    End If
    '    Return val
    'End Function

    Sub mEliminaLogin()

        Try
            If System.IO.File.Exists(IO.Path.GetTempPath & "user.txt") Then
                System.IO.File.Delete(IO.Path.GetTempPath & "user.txt")
            End If
        Catch ex As Exception

        End Try

        Dim flagElimina As Boolean = False
        While flagElimina = False

            Try
                fluxoTexto.Close()
                fluxoTexto.Dispose()
            Catch ex As Exception

            End Try

            Try
                If System.IO.File.Exists(IO.Path.GetTempPath() & "z.mvtemp\.time\usr\2986872") Then
                    System.IO.File.Delete(IO.Path.GetTempPath() & "z.mvtemp\.time\usr\2986872")
                End If
                flagElimina = True
            Catch ex As Exception

            End Try
        End While

        Try
            If System.IO.File.Exists(IO.Path.GetTempPath() & "z.mvtemp\.time\usr\2986872emp") Then
                System.IO.File.Delete(IO.Path.GetTempPath() & "z.mvtemp\.time\usr\2986872emp")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Sub fINIConexao(Optional ByVal itemDeMenu As Boolean = False,
                    Optional DefaultConnecStr As String = "",
                    Optional AssemblyOrigem As Assembly = Nothing,
                    Optional ConexaoTipo As Type = Nothing,
                    Optional TimerCloseInternal As Integer = 30)

        If Application.StartupPath.ToUpper.Contains(":\MOVTECHFONTES\INDUMAK\") AndAlso
            IO.Directory.GetFiles(Application.StartupPath, "*conect.xml*").Length = 0 Then
            IO.File.Copy("\\192.168.28.10\sistemas\movtech\conect.xml", Application.StartupPath & "\conect.xml")
        End If

        modFuncoes.timerCloseInternal = TimerCloseInternal
        modFuncoes.tipoConexao = ConexaoTipo
        If (Application.StartupPath.ToLower.Contains("debug") Or Application.StartupPath.ToLower.Contains("release")) Then
            Dim discoLocal As String = Piece(Application.StartupPath, "\", 1)
            If Not IO.File.Exists(Application.StartupPath & "\SQLite.Interop.dll") Then
                IO.File.Copy(discoLocal & "\MovtechFontes\MOVTECHDLL\SQLite.Interop.dll", Application.StartupPath & "\SQLite.Interop.dll")
            End If
            If Not IO.File.Exists(Application.StartupPath & "\SQLite.Designer.dll") Then
                IO.File.Copy(discoLocal & "\MovtechFontes\MOVTECHDLL\SQLite.Designer.dll", Application.StartupPath & "\SQLite.Designer.dll")
            End If
            If Not IO.File.Exists(Application.StartupPath & "\System.Data.SQLite.dll") Then
                IO.File.Copy(discoLocal & "\MovtechFontes\MOVTECHDLL\System.Data.SQLite.dll", Application.StartupPath & "\System.Data.SQLite.dll")
            End If
            If Not IO.File.Exists(Application.StartupPath & "\InterSystems.Data.CacheClient.dll") Then
                IO.File.Copy(discoLocal & "\MovtechFontes\MOVTECHDLL\InterSystems.Data.CacheClient.dll", Application.StartupPath & "\InterSystems.Data.CacheClient.dll")
            End If
        End If

        Try
            System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("pt-BR")
        Catch ex As Exception
        End Try

        Try
            strComputerName = Environment.MachineName.ToString()
        Catch
        End Try

        If ValidarMvtForm Then
            Dim flagMensagem As Boolean = False
            Dim mensagem As New StringBuilder()
            Dim baseType As Type = GetType(Form)
            mensagem.Append("Os formul·rios abaixo n„o s„o do tipo MvtForm!" & vbCrLf & vbCrLf)

            For Each tipo As Type In Assembly.GetEntryAssembly.GetTypes
                Try
                    If tipo.BaseType Is baseType AndAlso tipo.Name <> "frmMenu" And tipo.Name <> "frmMvtMenu" And tipo.Name <> "__" Then
                        flagMensagem = True
                        mensagem.Append(tipo.Name & vbCrLf)
                    End If
                Catch ex As Exception
                End Try
            Next

            If flagMensagem = True Then
                mMensagemErro(mensagem.ToString)
                Environment.Exit(0)
            End If
        End If

        Dim checaFormatacao As String = Format(1000, "#,##0.0")
        If fDireita(fEsquerda(checaFormatacao, 2), 1) = "," Then
            mMensagemErro("FormataÁ„o numÈrica incorreta!" & vbCr & vbCr & "Verificar configuraÁıes regionais!")
            Environment.Exit(0)
        End If

        Dim strCaminho, strLinha, strLinhaTexto As String
        strCaminho = Application.StartupPath & "\conect.ini"
        Dim fluxoTexto As IO.StreamReader = Nothing
        strLinha = ""
        imgStretch = 0
        If System.IO.File.Exists("conect.xml") OrElse System.IO.File.Exists(Application.StartupPath & "\conect.xml") Then

            If Conect Is Nothing Then

                Conect = MvtConnection.Conect.Iniciar("")
                strConnDBDEFAULT = Conect.DBDEFAULT
                strConnDEFAULT = Conect.DBDEFAULT
                strConnMySQL = Conect.MYSQL
                strConnMDB = Conect.MDB
                strNFeDir = Conect.NFEDIR
                strConnCACHE = Conect.CACHE
                If strConnDBDEFAULT = "" Then
                    strConnDBDEFAULT = Conect.CACHE
                End If
                strConnCACHEME = Conect.CACHEME
                strConnCACHEMF = Conect.CACHEMF
                strConnEXCEL = Conect.EXCEL
                strConnEXCELP = Conect.EXCELPROD
                strDestinoAcesso = Conect.PRGACCESS

                strSystemName = Conect.SYSTEMNAME
                If codEmpresa = 0 Then
                    codEmpresa = Conect.COMPANY
                End If
                strSystemDescription = Conect.SYSTEMDESCRIPTION
                strPassMerisa = Conect.PASS
                strConnSMPBD = Conect.SMPBD
                strConnSOLCAD = Conect.SOLCAD

                strConnMDBESP = Conect.MDBESPECTRO
                strConnMDBESP2 = Conect.MDBESPECTRO2
                imgStretch = Conect.IMAGELAYOUT
                strConnADODEFAULT = Conect.ADODEFAULT
                strRepositorio = Conect.REPOSITORIO
                If My.Computer.Name.StartsWith("MVT") Then
                    strRepositorio = strRepositorio.Replace("\\alpha\sistemas\MOVTECH", "\\192.168.28.10\sistemas\MOVTECH")
                End If
                strRepositorioDesenho = Conect.REPOSITORIODESENHO
                strRepositorioGabarito = Conect.REPOSITORIOGABARITO
                strConnBKPSQLSRV = Conect.BKPSQLSRV

                strUserPlanSPDM = Conect.PLANSPDM
                If Not String.IsNullOrEmpty(DefaultConnecStr) Then
                    Dim content As String = Conect.GetCustomEntry(DefaultConnecStr.Replace("[", "").Replace("]", ""))
                    If Not String.IsNullOrEmpty(content) Then
                        strConnDBDEFAULT = content
                    End If
                End If

                If Command() = "VPN" Then
                    strRepositorio = ""
                    Conect.REPOSITORIO = ""
                    mMensagemAlerta("Sistema configurado para acesso via VPN!")
                End If

                MvtConnection.Conect.ConectAtual = Conect
            End If
        Else
            If IO.File.Exists(strCaminho) Then
                fluxoTexto = New IO.StreamReader(strCaminho)
                strLinhaTexto = fluxoTexto.ReadLine
                If strLinhaTexto.StartsWith("#") Then
                    Try
                        strLinhaTexto = AESDecrypt(Strings.Right(strLinhaTexto, strLinhaTexto.Length - 1), "mvtsystems$004195989282986872")
                    Catch ex As Exception
                        If strLinhaTexto <> "" Then
                            strLinhaTexto = (Strings.Right(strLinhaTexto, strLinhaTexto.Length - 1))
                        End If
                    End Try
                End If
                While strLinhaTexto <> Nothing
                    If Strings.Left(strLinhaTexto, 11) = "[DBDEFAULT]" Then
                        strConnDBDEFAULT = Replace(strLinhaTexto, "[DBDEFAULT]", "")
                        strConnDEFAULT = strConnDBDEFAULT
                    End If
                    If strLinhaTexto.Contains("[DBDEFAULTCRYPT]") Then
                        'Devido a leitura das strings ser condificada em UTF7 foi necess·ria a releitura do conect.ini para pegar alinha criptografada
                        For Each chave As String In Split(IO.File.ReadAllText(strCaminho), vbCrLf)
                            If chave.StartsWith("[DBDEFAULTCRYPT]") Then
                                strConnDBDEFAULT = ""
                                strConnDBDEFAULT = AESDecrypt(chave.Replace("[DBDEFAULTCRYPT]", ""), "conf1001mvtac&ssoconEctin!")
                                Exit For
                            End If
                        Next
                    End If
                    If fEsquerda(strLinhaTexto, 9) = "[DEFAULT]" Then
                        strConnDBDEFAULT = Replace(strLinhaTexto, "[DEFAULT]", "")
                        strConnDBDEFAULT = Replace(strLinhaTexto, "[DEFAULT]", "")
                        strConnDEFAULT = strConnDBDEFAULT
                    End If
                    If fEsquerda(strLinhaTexto, 7) = "[MYSQL]" Then
                        strConnMySQL = Replace(strLinhaTexto, "[MYSQL]", "")
                    End If
                    If fEsquerda(strLinhaTexto, 5) = "[MDB]" Then
                        strConnMDB = Replace(strLinhaTexto, "[MDB]", "")
                    End If
                    If strLinhaTexto.Contains("[NFEDIR]") Then
                        strNFeDir = Replace(strLinhaTexto, "[NFEDIR]", "")
                    End If
                    If fEsquerda(strLinhaTexto, 7) = "[CACHE]" Then
                        strConnCACHE = Replace(strLinhaTexto, "[CACHE]", "")
                        strConnDBDEFAULT = strConnCACHE
                    End If
                    If fEsquerda(strLinhaTexto, 9) = "[CACHEME]" Then
                        strConnCACHEME = Replace(strLinhaTexto, "[CACHEME]", "")
                        strConnDBDEFAULT = strConnCACHEME
                    End If
                    If fEsquerda(strLinhaTexto, 9) = "[CACHEMF]" Then
                        strConnCACHEMF = Replace(strLinhaTexto, "[CACHEMF]", "")
                        strConnDBDEFAULT = strConnCACHEMF
                    End If
                    If fEsquerda(strLinhaTexto, 7) = "[EXCEL]" Then
                        strConnEXCEL = Replace(strLinhaTexto, "[EXCEL]", "")
                    End If
                    If fEsquerda(strLinhaTexto, 11) = "[EXCELPROD]" Then
                        strConnEXCELP = Replace(strLinhaTexto, "[EXCELPROD]", "")
                    End If
                    If fEsquerda(strLinhaTexto, 11) = "[PRGACCESS]" Then
                        strDestinoAcesso = Replace(strLinhaTexto, "[PRGACCESS]", "")
                    End If
                    If fEsquerda(strLinhaTexto, 12) = "[SYSTEMNAME]" Then
                        strSystemName = Replace(strLinhaTexto, "[SYSTEMNAME]", "")
                    End If
                    If fEsquerda(strLinhaTexto, 9) = "[COMPANY]" Then
                        codEmpresa = Replace(strLinhaTexto, "[COMPANY]", "")
                    End If
                    If fEsquerda(strLinhaTexto, 19) = "[SYSTEMDESCRIPTION]" Then
                        strSystemDescription = Replace(strLinhaTexto, "[SYSTEMDESCRIPTION]", "")
                    End If
                    If fEsquerda(strLinhaTexto, 6) = "[PASS]" Then
                        strPassMerisa = Replace(strLinhaTexto, "[PASS]", "")
                    End If
                    If fEsquerda(strLinhaTexto, 7) = "[SMPBD]" Then
                        strConnSMPBD = Replace(strLinhaTexto, "[SMPBD]", "")
                    End If
                    If fEsquerda(strLinhaTexto, 8) = "[SOLCAD]" Then
                        strConnSOLCAD = Replace(strLinhaTexto, "[SOLCAD]", "")
                    End If
                    If fEsquerda(strLinhaTexto, 9) = "[USESKIN]" Then
                        strUseSkin = Replace(strLinhaTexto, "[USESKIN]", "")
                    End If
                    If fEsquerda(strLinhaTexto, 13) = "[DEFAULTSKIN]" Then
                        strTemaPadrao = Replace(strLinhaTexto, "[DEFAULTSKIN]", "")
                    End If
                    If fEsquerda(strLinhaTexto, 10) = "[PLANSPDI]" Then
                        strUserPlanSPDI = Replace(strLinhaTexto, "[PLANSPDI]", "")
                    End If
                    If fEsquerda(strLinhaTexto, 10) = "[PLANSPDM]" Then
                        strUserPlanSPDM = Replace(strLinhaTexto, "[PLANSPDM]", "")
                    End If
                    If fEsquerda(strLinhaTexto, 13) = "[MDBESPECTRO]" Then
                        strConnMDBESP = Replace(strLinhaTexto, "[MDBESPECTRO]", "")
                    End If
                    If fEsquerda(strLinhaTexto, 14) = "[MDBESPECTRO2]" Then
                        strConnMDBESP2 = Replace(strLinhaTexto, "[MDBESPECTRO2]", "")
                    End If
                    If fEsquerda(strLinhaTexto, 13) = "[IMAGELAYOUT]" Then
                        imgStretch = Replace(strLinhaTexto, "[IMAGELAYOUT]", "")
                    End If
                    If fEsquerda(strLinhaTexto, 12) = "[ADODEFAULT]" Then
                        strConnADODEFAULT = Replace(strLinhaTexto, "[ADODEFAULT]", "")
                    End If
                    If fEsquerda(strLinhaTexto, 13) = "[REPOSITORIO]" Then
                        strRepositorio = Replace(strLinhaTexto, "[REPOSITORIO]", "")
                    End If
                    If fEsquerda(strLinhaTexto, 20) = "[REPOSITORIODESENHO]" Then
                        strRepositorioDesenho = Replace(strLinhaTexto, "[REPOSITORIODESENHO]", "")
                    End If
                    'strRepositorioGabarito
                    If fEsquerda(strLinhaTexto, 21) = "[REPOSITORIOGABARITO]" Then
                        strRepositorioGabarito = Replace(strLinhaTexto, "[REPOSITORIOGABARITO]", "")
                    End If
                    If strLinhaTexto.StartsWith("[BKPSQLSRV]") Then
                        strConnBKPSQLSRV = Replace(strLinhaTexto, "[BKPSQLSRV]", "")
                        strConnBKPSQLSRV = strConnBKPSQLSRV
                    End If
                    If Not String.IsNullOrEmpty(DefaultConnecStr) Then
                        If fEsquerda(strLinhaTexto, DefaultConnecStr.Length) = DefaultConnecStr Then
                            strConnDBDEFAULT = Replace(strLinhaTexto, DefaultConnecStr, "")
                        End If
                    End If
                    strLinhaTexto = fluxoTexto.ReadLine
                    If strLinhaTexto <> "" Then
                        If strLinhaTexto.StartsWith("#") Then
                            Try
                                strLinhaTexto = AESDecrypt(Strings.Right(strLinhaTexto, strLinhaTexto.Length - 1), "mvtsystems$004195989282986872")
                            Catch ex As Exception

                                strLinhaTexto = (Strings.Right(strLinhaTexto, strLinhaTexto.Length - 1))

                            End Try
                        End If

                    End If

                End While
            Else
                mMensagemErro("Arquivo de conex„o n„o encontrado!" & vbCrLf & vbCrLf & "conect.ini")
                Try
                    fluxoTexto.Dispose()
                Catch
                End Try
                Environment.Exit(0)
            End If
        End If

        ''get var empresa
        Dim empresa As String = ""
        Try
            'empresa = System.IO.File.ReadAllText(IO.Path.GetTempPath() & "z.mvtemp\.time\usr\2986872emp")
            Dim caminhoArquivoEmpresa As String = IO.Path.GetTempPath() & "z.mvtemp\.time\usr\2986872emp"
            Using arquivoEmpresa As New StreamReader(System.IO.File.Open(caminhoArquivoEmpresa, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                empresa = arquivoEmpresa.ReadToEnd
            End Using
        Catch ex As Exception
            Trace.WriteLine(ex)
        End Try
        If IsNumeric(empresa) Then
            codEmpresa = empresa
        End If

        ' CARREGAR CONEX√O PADR√O
        If conexaoPadrao Is Nothing Then
            If strConnDBDEFAULT <> "" Then
                Try
                    conexaoPadrao = CriarConexao(strConnDBDEFAULT)
                    conexaoPadrao.Conect = Conect
                    If conexaoPadrao.StateActiveConnection = ConnectionState.Closed Then
                        mMensagemErro("N„o foi possÌvel conectar com o banco de dados!")
                        Environment.Exit(0)
                    End If
                Catch ex As Exception
                    mMensagemErro("Erro na conex„o!" & vbCrLf & ex.Message)
                End Try
            Else
                mMensagemErro("Vari·vel de conex„o (strConnDBDEFAULT) n„o definida!")
                'fluxoTexto.Dispose()
                Environment.Exit(0)
            End If
        End If



        Dim info As ApplicationServices.AssemblyInfo = My.Application.Info
        If AssemblyOrigem IsNot Nothing Then info = New ApplicationServices.AssemblyInfo(AssemblyOrigem)
        Dim nomePrograma As String = IIf(itemDeMenu = False, info.AssemblyName, "MENU")

        If info.ProductName <> "LOGIN" Then
            If Not ExecutarComoAdmin And Not ExecutarComoAdminUsuario Then
                If info.ProductName = "MENU" Then
                    nomePrograma = "MENU"
                End If

                strUsuarioLogado = fINIUsuario(conexaoPadrao, nomePrograma)
                If StrUsuarioLogadoToLower Then 'Supply Chain necessitou para n„o alterar o banco para case sensitive (que iria dar muito problema), adicionada esta propriedade. Existem usu·rios mai˙sculos na INDUMAK por exemplo e que na importaÁ„o est„o sendo jogados para min˙sculo
                    strUsuarioLogado = strUsuarioLogado.ToLower
                End If

                If Conect Is Nothing Then
                    Conect = New MvtConnection.Conect
                End If

                Conect.UsuarioLogado = strUsuarioLogado
                MvtConnection.Conect.ConectAtual = Conect
                If strUsuarioLogado = "" Then
                    mMensagemErro("Usu·rio inv·lido!")
                    fluxoTexto.Dispose()
                    Environment.Exit(0)
                End If
            Else
                If ExecutarComoAdmin Then
                    strUsuarioLogado = "conf"
                ElseIf ExecutarComoAdminUsuario Then
                    strUsuarioLogado = fINIUsuario(conexaoPadrao, nomePrograma)
                End If
                Conect.UsuarioLogado = strUsuarioLogado
                MvtConnection.Conect.ConectAtual = Conect
            End If
        End If
        ChecaVersaoNova()
    End Sub

    Function fINIUsuario(ByVal conexao As MvtConnection.MvtConnection, ByVal programa As String)
        If conexao Is Nothing Then
            mMensagemErro("Conex„o n„o definida!")
            Return ""
        End If

        Dim usr As String = String.Empty
        Dim usrCript As String = String.Empty
        Dim strCaminho As String = String.Empty
        Dim strLinha, strLinhaTexto As String
        Dim strSQL As String

        Try
            'usr = System.Environment.GetEnvironmentVariable("mvtUsuario", EnvironmentVariableTarget.User)
        Catch ex As Exception
        End Try

        strLinhaTexto = ""
        If System.IO.File.Exists(IO.Path.GetTempPath() & "z.mvtemp\.time\usr\2986872") Then
            strCaminho = IO.Path.GetTempPath() & "z.mvtemp\.time\usr\2986872"
        End If

        If ExecutarComoAdmin Then
            usr = "conf"
        End If

        strLinha = ""
        If IO.File.Exists(strCaminho) Then
            If ExecutarComoAdmin Or ExecutarComoAdminUsuario Then
                strLinhaTexto = IO.File.ReadAllText(strCaminho)
                usr = Split(strLinhaTexto & " ")(0)
            Else
                If Not (fluxoTexto Is Nothing) Then
                    fluxoTexto.Close()
                    fluxoTexto.Dispose()
                End If
                fluxoTexto = New IO.StreamReader(System.IO.File.Open(strCaminho, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                strLinhaTexto = fluxoTexto.ReadLine
                usr = Split(strLinhaTexto & " ")(0)
                strLinhaTexto = fluxoTexto.ReadLine
                Try
                    fluxoTexto.Close()
                    fluxoTexto.Dispose()
                    usrCript = strLinhaTexto
                Catch ex As Exception

                End Try
                ''
                ''O USUARIO AGORA SER¡ CRIPTOGRAFADO
                '' NAO IMPORTA O NOME DO USUARIO QUE ESTIVER NO ARQUIVO, ELE USAR¡ O CRIPTOGRAFADO
                ''
                If usrCript <> "" Then

                    'usrCript = DeCrypt(usrCript)

                End If
                ''usr=usrCript
            End If
        Else
            If My.Application.Info.ProductName <> "LOGIN" Then
                If strSystemDescription <> "INDUMAK" And strSystemDescription <> "EtiquetaAdlin" And Not ExecutarComoAdmin And Not ExecutarComoAdminUsuario Then
                    mMensagemErro("Dados do usu·rio n„o encontrado!")
                    Try
                        fluxoTexto.Dispose()
                        Environment.Exit(0)
                    Catch
                    End Try
                ElseIf ExecutarComoAdmin Then
                    usr = "conf"
                Else
                    usr = "padrao"
                End If
            End If
        End If
        If usr = "" Then
            If My.Application.Info.ProductName <> "LOGIN" Then
                If strSystemDescription <> "INDUMAK" And strSystemDescription <> "EtiquetaAdlin" Then
                    If strSystemDescription = "ANA-MARIA" Then
                        usr = "paulo"
                    End If
                    Environment.Exit(0)
                Else
                    usr = "padrao"
                End If
            End If
        Else
            'CHECA SE PROGRAMA FOR DIFERENTE DE MENU
            'SE FOR MENU ELE N√O FAZ A CHECAGEM, POIS O MESMO N√O POSSUIR¡ PERMISS√O CADASTRADA
            If programa.ToUpper <> "MENU" And Not (programa.ToUpper Like "FRM*" And Not (programa.ToUpper Like "*.EXE")) Then
                ''
                ''BUSCA GRUPOS DO USUARIO
                ''

                Try
                    strSQL = "SELECT +codGrupo FROM Mvt_Acesso.Usuario WHERE usuario='" & usr & "'"
                    Using dr As IDataReader = conexaoPadrao.ReturnDataReader(strSQL)
                        While dr.Read
                            intCodGropoUsuario = mCDec(dr(0))
                        End While
                        dr.Close()
                    End Using
                Catch ex As Exception
                    Trace.WriteLine(ex)
                End Try

                If usr <> "conf" Then
                    ''Levi - alterei para poder chamar pelos programas
                    Dim permissao As Boolean = ChecaPermissaoPrograma(programa, usr)
                    If Not permissao And Not ExecutarComoAdminUsuario Then
                        mMensagemErro("Sem permiss„o para acessar!")
                        Environment.Exit(0)
                    End If
                End If
            End If
        End If
        Return usr 'Replace(fEsquerda(strLinhaTexto, 20), " ", "")
    End Function

    Public Function ChecaPermissaoPrograma(programa As String, usuario As String) As Boolean
        Dim permissao As Boolean = True
        Dim strSQLPer As String

        If String.IsNullOrEmpty(usuario) Then
            usuario = strUsuarioLogado
        End If
        Dim strGrupos As String = "usuarioGrupo LIKE '" & intCodGropoUsuario & " %'"
        Try
            strSQLPer = "SELECT codGrupo" & Chr(13) & Chr(10)
            strSQLPer = strSQLPer & "FROM Mvt_Acesso.GrupoMembro" & Chr(13) & Chr(10)
            strSQLPer = strSQLPer & "WHERE usuario='" & usuario & "'" & Chr(13) & Chr(10)
            Using dr As IDataReader = conexaoPadrao.ReturnDataReader(strSQLPer)
                While dr.Read
                    strGrupos &= " OR usuarioGrupo LIKE '" & mCDec(dr(0)) & " %'"
                End While
                dr.Close()
            End Using
        Catch ex As Exception
            Trace.WriteLine(ex)
        End Try

        strSQLPer = "SELECT COUNT(0)" & Chr(13) & Chr(10)
        strSQLPer = strSQLPer & "FROM Mvt_Acesso.Permissao permissao JOIN Mvt_Menu.Item item ON item.sistema=permissao.sistema" & Chr(13) & Chr(10)
        strSQLPer = strSQLPer & "    AND item.nomeBotao=permissao.nomeBotao" & Chr(13) & Chr(10)
        strSQLPer = strSQLPer & "WHERE (upper(item.programa)='" & programa.ToUpper & "' OR upper(item.programa)='" & programa.ToUpper & ".EXE' OR " & If(programa.ToLower.StartsWith("frm") Or Environment.GetCommandLineArgs().Length <= 1, "'$'", "UPPER(item.programa)") & " LIKE '" & programa.ToUpper & "%')" & Chr(13) & Chr(10)
        strSQLPer = strSQLPer & "    AND ((permissao.tipo=1 AND " & strGrupos & ")" & Chr(13) & Chr(10)
        strSQLPer = strSQLPer & "    OR (permissao.usuarioGrupo='" & usuario & "'))" & Chr(13) & Chr(10)
        Try
            Dim ret As Integer = 0
            Using dr As IDataReader = conexaoPadrao.ReturnDataReader(strSQLPer)
                While dr.Read
                    ret = mCDec(dr(0))
                End While
                dr.Close()
            End Using
            If ret = 0 Then
                permissao = False
            End If
        Catch ex As Exception
            Trace.WriteLine(ex)
        End Try
        Return permissao
    End Function

    Function ValidatePeriodoAcesso(conexao As MvtConnection.MvtConnection, usuario As String, exibeMensagem As Boolean) As Boolean
        If conexao Is Nothing Then Throw New ArgumentNullException(NameOf(conexao))
        If String.IsNullOrEmpty(usuario) Then Throw New ArgumentNullException(NameOf(usuario))

        Dim horaInicioAcesso As TimeSpan? = Nothing
        Dim horaFimAcesso As TimeSpan? = Nothing
        Dim horaInicioIntervaloAcesso As TimeSpan? = Nothing
        Dim horaFimIntervaloAcesso As TimeSpan? = Nothing
        Dim diasSemana As New List(Of DayOfWeek)()

        Dim sql As New StringBuilder()
        sql.AppendLine("SELECT horaInicioAcesso")
        sql.AppendLine(",horaFimAcesso")
        sql.AppendLine(",horaInicioIntervaloAcesso")
        sql.AppendLine(",horaFimIntervaloAcesso")
        sql.AppendLine(",diasSemanaAcesso")
        sql.AppendLine("FROM Mvt_Acesso.Usuario")
        sql.AppendFormat("WHERE usuario={0}", ValueSQLString(usuario))

        Using dr As IDataReader = conexao.ReturnDataReader(sql.ToString())
            If dr.Read() Then
                horaInicioAcesso = mCTimeN(dr("horaInicioAcesso"))
                horaFimAcesso = mCTimeN(dr("horaFimAcesso"))
                horaInicioIntervaloAcesso = mCTimeN(dr("horaInicioIntervaloAcesso"))
                horaFimIntervaloAcesso = mCTimeN(dr("horaFimIntervaloAcesso"))
                For Each diaSemana As String In Split(dr("diasSemanaAcesso") & "", ",")
                    If Not IsNumeric(diaSemana) Then Continue For
                    diasSemana.Add(mCInt(diaSemana))
                Next
            End If
            dr.Close()
        End Using

        Dim dataHora As Date = retornaDataHoraServidor(conexao)
        If horaInicioAcesso.HasValue AndAlso horaFimAcesso.HasValue Then
            Dim dataHoraInicio As Date = dataHora.Date.Add(horaInicioAcesso.Value)
            Dim dataHoraFim As Date = dataHora.Date.Add(horaFimAcesso.Value)
            If dataHora < dataHoraInicio OrElse dataHora > dataHoraFim Then
                If exibeMensagem Then
                    mMensagemAviso("Fora do perÌodo de acesso permitido.{0}{0}Hor·rio: {1:HH:mm} atÈ {2:HH:mm}", vbCrLf, dataHoraInicio, dataHoraFim)
                End If
                Return False
            End If
        End If
        If horaInicioIntervaloAcesso.HasValue AndAlso horaFimIntervaloAcesso.HasValue Then
            Dim dataHoraInicio As Date = dataHora.Date.Add(horaInicioIntervaloAcesso.Value)
            Dim dataHoraFim As Date = dataHora.Date.Add(horaFimIntervaloAcesso.Value)
            If dataHora >= dataHoraInicio AndAlso dataHora <= dataHoraFim Then
                If exibeMensagem Then
                    mMensagemAviso("Fora do perÌodo de acesso permitido.{0}{0}Intervalo: {1:HH:mm} atÈ {2:HH:mm}", vbCrLf, dataHoraInicio, dataHoraFim)
                End If
                Return False
            End If
        End If
        If diasSemana.Count > 0 AndAlso Not diasSemana.Contains(dataHora.DayOfWeek) Then
            If exibeMensagem Then
                Dim diasSemanaFormatado As String = String.Join(", ", Array.ConvertAll(diasSemana.ToArray(), AddressOf Globalization.CultureInfo.CurrentCulture.DateTimeFormat.GetDayName))
                mMensagemAviso("Fora do perÌodo de acesso permitido.{0}{0}Dias da semana: {1}", vbCrLf, diasSemanaFormatado)
            End If
            Return False
        End If

        Return True
    End Function

    Public Function Crypt(ByVal Text As String) As String
        Dim novoTexto As String = ""
        Dim caract As String = ""
        For cont As Integer = 0 To Text.Length - 1
            caract = Text.Substring(cont, 1)
            novoTexto &= fDireita("000" & Asc(caract) + 5, 3)
        Next

        Return novoTexto

    End Function

    Public Function DeCrypt(ByVal Text As String) As String
        Dim novoTexto As String = ""
        Dim caract As String = ""
        Try
            If Text.Length <> 500 Then
                Return ""
            End If
            Text = Split(Text, " ")(0)

            For cont As Integer = 0 To Text.Length - 1 Step 3
                caract = Text.Substring(cont, 3)
                If IsNumeric(caract) Then
                    novoTexto &= Chr(caract - 5)
                Else
                    Return Text
                End If

            Next
        Catch ex As Exception

        End Try

        Return novoTexto

    End Function

    Function fINICodProduto()
        On Error Resume Next
        Dim strCaminho, strLinha, strLinhaTexto As String
        strLinhaTexto = ""
        strCaminho = IO.Path.GetTempPath & "\codProProc.txt"
        Dim fluxoTexto As IO.StreamReader
        strLinha = ""
        If IO.File.Exists(strCaminho) Then
            fluxoTexto = New IO.StreamReader(strCaminho)
            strLinhaTexto = fluxoTexto.ReadLine
        Else
        End If
        Return strLinhaTexto
    End Function

    Function fEsquerda(ByVal strTexto As String, ByVal intTamanho As Integer)
        If intTamanho < 0 Then
            intTamanho = 0
        End If
        Return Left(strTexto, intTamanho)
    End Function

    Function fDireita(ByVal strTexto As String, ByVal intTamanho As Integer)
        If intTamanho < 0 Then
            intTamanho = 0
        End If
        Return Right(strTexto, intTamanho)
    End Function

    Function mMensagemAceita(ByVal format As String, ParamArray args() As Object) As MsgBoxResult
        Return mMensagemAceita(String.Format(format, args))
    End Function

    Function mMensagemAceita(ByVal strMensagem As String) As MsgBoxResult
        Return MsgBox(strMensagem, MsgBoxStyle.Question Or MsgBoxStyle.OkCancel, MvtConnection.MvtConnection.MessageTitle)
    End Function

    Sub mMensagemAviso(ByVal format As String, ParamArray args() As Object)
        mMensagemAviso(String.Format(format, args))
    End Sub

    Sub mMensagemAviso(ByVal strMensagem As String)
        MsgBox(strMensagem, MsgBoxStyle.Exclamation, MvtConnection.MvtConnection.MessageTitle)
    End Sub

    Sub mMensagemAlerta(ByVal format As String, ParamArray args() As Object)
        mMensagemAlerta(String.Format(format, args))
    End Sub

    Sub mMensagemAlerta(ByVal strMensagem As String)
        MsgBox(strMensagem, MsgBoxStyle.Information, MvtConnection.MvtConnection.MessageTitle)
    End Sub

    Sub mMensagemErro(ByVal format As String, ParamArray args() As Object)
        mMensagemErro(String.Format(format, args))
    End Sub

    Sub mMensagemErro(ByVal strMensagem As String)
        MsgBox(strMensagem, MsgBoxStyle.Critical, MvtConnection.MvtConnection.MessageTitle)
    End Sub

    Sub mMensagemErroCache(ByVal strMensagem As String)
        On Error Resume Next
        Dim numErro As String = ""
        numErro = mCDec(fDireita(Replace(fEsquerda(strMensagem, strMensagem.IndexOf("Native Code") + 15), "]", ""), 3))
        Dim strCaminho, strLinha, strLinhaTexto As String
        strCaminho = Application.StartupPath & "\errorcache.ini"
        Dim fluxoTexto As IO.StreamReader
        strLinha = ""
        If IO.File.Exists(strCaminho) Then
            fluxoTexto = New IO.StreamReader(strCaminho)
            strLinhaTexto = fluxoTexto.ReadLine
            While strLinhaTexto <> Nothing
                If mCDec(fEsquerda(strLinhaTexto, 5)) = mCDec(numErro) Then
                    MsgBox("Erro ao acesar servidor" & vbCrLf & vbCrLf & fDireita(strLinhaTexto, strLinhaTexto.Length - 5), MsgBoxStyle.Critical, MvtConnection.MvtConnection.MessageTitle)
                    fluxoTexto.Close()
                    Exit Sub
                End If
                strLinhaTexto = fluxoTexto.ReadLine
            End While
            fluxoTexto.Close()
        Else
            mMensagemErro("Erro ao acessar servidor!" & vbCrLf & vbCrLf & strMensagem)
            'End
        End If
        mMensagemErro("Erro ao acessar servidor!" & vbCrLf & vbCrLf & strMensagem)
        '        MsgBox(strMensagem, MsgBoxStyle.Critical, My.Application.Info.ProductName)
    End Sub

    Function mMensagemConfirmaAlteracao()
        Dim msg As String
        Dim est, resp
        msg = "Confirma alteraÁ„o?"
        est = vbYesNo + vbDefaultButton1 + vbExclamation
        resp = MsgBox(msg, est, MvtConnection.MvtConnection.MessageTitle)
        Return resp
    End Function

    Function mMensagemConfirma(ByVal strMsg As String)
        Dim msg As String
        Dim est, resp
        msg = strMsg
        est = vbYesNo + vbDefaultButton2 + vbExclamation
        resp = MsgBox(msg, est, MvtConnection.MvtConnection.MessageTitle)
        Return resp
    End Function

    Function mMensagemConfirmaExclusao()
        Dim msg As String
        Dim est, resp
        msg = "Confirma exclus„o?"
        est = vbYesNo + vbDefaultButton1 + vbCritical
        resp = MsgBox(msg, est, MvtConnection.MvtConnection.MessageTitle)
        Return resp
    End Function

    Function fChecaData(ByVal datVal As String)
        On Error Resume Next
        datVal = CDate(datVal)
        If Err.Description <> "" Then
            datVal = ""
        End If
        Return datVal
    End Function

    Function mAtalho(ByVal strLetra As String)
        Dim retLetra As Double
        retLetra = 0
        If UCase(strLetra) = "A" Then
            retLetra = Keys.A
        End If
        If UCase(strLetra) = "B" Then
            retLetra = Keys.B
        End If
        If UCase(strLetra) = "D" Then
            retLetra = Keys.D
        End If

        If UCase(strLetra) = "E" Then
            retLetra = Keys.E
        End If

        If UCase(strLetra) = "F" Then
            retLetra = Keys.F
        End If

        If UCase(strLetra) = "G" Then
            retLetra = Keys.G
        End If

        If UCase(strLetra) = "H" Then
            retLetra = Keys.H
        End If

        If UCase(strLetra) = "I" Then
            retLetra = Keys.I
        End If

        If UCase(strLetra) = "J" Then
            retLetra = Keys.J
        End If

        If UCase(strLetra) = "K" Then
            retLetra = Keys.K
        End If

        If UCase(strLetra) = "L" Then
            retLetra = Keys.L
        End If

        If UCase(strLetra) = "M" Then
            retLetra = Keys.M
        End If

        If UCase(strLetra) = "N" Then
            retLetra = Keys.N
        End If

        If UCase(strLetra) = "O" Then
            retLetra = Keys.O
        End If

        If UCase(strLetra) = "P" Then
            retLetra = Keys.P
        End If
        If UCase(strLetra) = "Q" Then
            retLetra = Keys.Q
        End If

        If UCase(strLetra) = "R" Then
            retLetra = Keys.R
        End If

        If UCase(strLetra) = "S" Then
            retLetra = Keys.S
        End If

        If UCase(strLetra) = "T" Then
            retLetra = Keys.T
        End If

        If UCase(strLetra) = "U" Then
            retLetra = Keys.U
        End If

        If UCase(strLetra) = "V" Then
            retLetra = Keys.V
        End If

        If UCase(strLetra) = "W" Then
            retLetra = Keys.W
        End If
        If UCase(strLetra) = "X" Then
            retLetra = Keys.X
        End If
        If UCase(strLetra) = "Y" Then
            retLetra = Keys.Y
        End If
        If UCase(strLetra) = "Z" Then
            retLetra = Keys.Z
        End If

        Return retLetra
    End Function

    Sub mAbreFormPesquisaMDB(ByVal strSelect As String, ByVal formPai As Form, ByVal controleRetorno As Control, ByVal strCampoChave As String, ByVal strCampoPesquisa As String, ByVal filtros As String)

        'strSQLConsultaF3 = strSelect

        'formRetorno = formPai
        'controleRet = controleRetorno
        'filtrosConsulta = filtros
        'strCampoKey = strCampoChave
        'strCampoFind = strCampoPesquisa

        'frmConsulta.Show(formPai)
        Dim frmCon As New MvtWindowsForms.frmConsulta
        AddHandler frmCon.FormClosing, AddressOf FrmConClosing
        frmCon.SQLSelectFind = strSelect

        frmCon.Owner = formPai
        controleRet = controleRetorno
        frmCon.OthersFilters = filtros
        frmCon.FieldReturn = strCampoChave
        frmCon.FieldFind = strCampoPesquisa
        frmCon.FieldFilter = strCampoPesquisa

        frmCon.ShowDialog(formPai)
        'If frmCon.CodRetornado <> "" Then
        '    strcodRetorno = frmCon.CodRetornado
        'End If

    End Sub

    Function mAbreFormPesquisaCACHE(ByVal strSelect As String, ByVal formPai As Form, ByVal controleRetorno As Control, ByVal strCampoChave As String, ByVal strCampoPesquisa As String, ByVal filtros As String) As MvtWindowsForms.frmConsulta
        Return mAbreFormPesquisaCACHE(strSelect, formPai, controleRetorno, strCampoChave, strCampoPesquisa, filtros, conexaoPadrao)
    End Function

    Function mAbreFormPesquisaCACHE(ByVal strSelect As String, ByVal formPai As Form, ByVal controleRetorno As Control, ByVal strCampoChave As String, ByVal strCampoPesquisa As String, ByVal filtros As String, ByVal conexao As MvtConnection.MvtConnection) As MvtWindowsForms.frmConsulta
        Dim frmCon As New MvtWindowsForms.frmConsulta
        AddHandler frmCon.FormClosing, AddressOf FrmConClosing
        frmCon.SQLSelectFind = strSelect
        frmCon.Conexao = conexao
        frmCon.Owner = formPai
        controleRet = controleRetorno
        frmCon.OthersFilters = filtros
        frmCon.FieldReturn = strCampoChave
        frmCon.FieldFind = strCampoPesquisa
        frmCon.FieldFilter = strCampoPesquisa

        frmCon.ShowDialog()
        Return frmCon
    End Function

    Sub FrmConClosing(sender As Object, e As EventArgs)
        If TypeOf sender Is MvtWindowsForms.frmConsulta Then
            Dim frmCon = CType(sender, MvtWindowsForms.frmConsulta)
            If frmCon.CodRetornado <> "" Then
                strcodRetorno = frmCon.CodRetornado
                strnomeRetorno = frmCon.NomeRetornado
            End If
        End If
    End Sub

    Function mRetornaTextoAjustado(ByVal celula As String, ByVal fonte As Font, ByVal altura As Double, ByVal g As Graphics, ByVal larguraColunas As Integer, ByVal imprimirAteLargura As Boolean)
        'Dim intTam As Double
        Dim textoLido, textoFinal As String
        Dim cont, ultimo As Integer
        ultimo = 0
        textoLido = ""
        textoFinal = ""
        For cont = 1 To celula.Length
            textoFinal &= fDireita(fEsquerda(celula, cont), 1)
            If fDireita(fEsquerda(celula, cont), 1) = " " And DataGridViewCell.MeasureTextWidth(g, textoFinal, fonte, altura, TextFormatFlags.Bottom).ToString() > larguraColunas * 0.4 Then
                textoFinal &= vbCrLf
                textoLido &= textoFinal
                textoFinal = ""
                If imprimirAteLargura = True Then
                    Exit For
                End If
            Else
                If DataGridViewCell.MeasureTextWidth(g, textoFinal, fonte, altura, TextFormatFlags.Bottom).ToString() > larguraColunas * 0.95 Then
                    textoFinal &= vbCrLf
                    textoLido &= textoFinal
                    textoFinal = ""
                    If imprimirAteLargura = True Then
                        Exit For
                    End If
                End If
            End If

        Next
        textoLido &= textoFinal
        Return textoLido
    End Function

    Function mAlinhaTextoDireita(ByVal celula As String, ByVal fonte As Font, ByVal altura As Double, ByVal g As Graphics, ByVal larguraColunas As Integer, ByVal imprimirAteLargura As Boolean)
        Dim textoLido As String
        textoLido = celula
        'MsgBox(DataGridViewCell.MeasureTextWidth(g, textoLido, fonte, altura, TextFormatFlags.Bottom).ToString())
        Return DataGridViewCell.MeasureTextWidth(g, textoLido, fonte, altura, TextFormatFlags.Bottom).ToString()
    End Function

    Function mTransformaMesNumerico(ByVal strMes As String) As String
        On Error Resume Next
        Dim strRet As String
        strRet = strMes * 1
        strRet = Replace(strRet, 10, "Out")
        strRet = Replace(strRet, 11, "Nov")
        strRet = Replace(strRet, 12, "Dez")
        strRet = Replace(strRet, 1, "Jan")
        strRet = Replace(strRet, 2, "Fev")
        strRet = Replace(strRet, 3, "Mar")
        strRet = Replace(strRet, 4, "Abr")
        strRet = Replace(strRet, 5, "Mai")
        strRet = Replace(strRet, 6, "Jun")
        strRet = Replace(strRet, 7, "Jul")
        strRet = Replace(strRet, 8, "Ago")
        strRet = Replace(strRet, 9, "Set")
        Return strRet
    End Function

    Function mTransformaMesTexto(ByVal strMes As String) As String
        Dim strRet As String
        strRet = strMes

        strRet = Replace(strRet.ToUpper, "Janeiro".ToUpper, "01")
        strRet = Replace(strRet.ToUpper, "Feveiro".ToUpper, "02")
        strRet = Replace(strRet.ToUpper, "Fevereiro".ToUpper, "02")
        strRet = Replace(strRet.ToUpper, "MarÁo".ToUpper, "03")
        strRet = Replace(strRet.ToUpper, "Abril".ToUpper, "04")
        strRet = Replace(strRet.ToUpper, "Maio".ToUpper, "05")
        strRet = Replace(strRet.ToUpper, "Junho".ToUpper, "06")
        strRet = Replace(strRet.ToUpper, "Julho".ToUpper, "07")
        strRet = Replace(strRet.ToUpper, "Agosto".ToUpper, "08")
        strRet = Replace(strRet.ToUpper, "Setembro".ToUpper, "09")
        strRet = Replace(strRet.ToUpper, "Outubro".ToUpper, "10")
        strRet = Replace(strRet.ToUpper, "Novembro".ToUpper, "11")
        strRet = Replace(strRet.ToUpper, "Dezembro".ToUpper, "12")
        If strRet = strMes Then
            strRet = Replace(strRet.ToUpper, "Jan".ToUpper, "01")
            strRet = Replace(strRet.ToUpper, "Fev".ToUpper, "02")
            strRet = Replace(strRet.ToUpper, "Mar".ToUpper, "03")
            strRet = Replace(strRet.ToUpper, "Abr".ToUpper, "04")
            strRet = Replace(strRet.ToUpper, "Mai".ToUpper, "05")
            strRet = Replace(strRet.ToUpper, "Jun".ToUpper, "06")
            strRet = Replace(strRet.ToUpper, "Jul".ToUpper, "07")
            strRet = Replace(strRet.ToUpper, "Ago".ToUpper, "08")
            strRet = Replace(strRet.ToUpper, "Set".ToUpper, "09")
            strRet = Replace(strRet.ToUpper, "Out".ToUpper, "10")
            strRet = Replace(strRet.ToUpper, "Nov".ToUpper, "11")
            strRet = Replace(strRet.ToUpper, "Dez".ToUpper, "12")
        End If
        Return strRet
    End Function

    Function mCaracteresAEsquerda(ByVal strTextoRet As String, ByVal caractere As String, ByVal tamanho As Integer)
        Return fEsquerda(Replace("00000000000000000000000000000000000000000000000000000000", "0", caractere), tamanho - strTextoRet.Length) & strTextoRet
    End Function

    Function mCaracteresADireita(ByVal strTextoRet As String, ByVal caractere As String, ByVal tamanho As Integer)
        Return strTextoRet & fDireita(Replace("00000000000000000000000000000000000000000000000000000000", "0", caractere), tamanho - strTextoRet.Length)
    End Function

    Function mRetornaListaSeparador(ByVal strTexto As String, ByVal strSeparador As String)
        Dim cont, ultimo As Integer
        Dim listaItem As New ArrayList
        ultimo = 0
        strTexto &= ";"
        For cont = 0 To strTexto.Length
            If Right(Left(strTexto, cont), 1) = strSeparador Then
                listaItem.Add(Replace(Right(Left(strTexto, cont), cont - ultimo), strSeparador, ""))
                ultimo = cont
            End If
        Next
        Return listaItem
    End Function

    Function mRetornaNomeArquivo(ByVal strNomeArquivo As String)
        Dim cont As Integer
        Dim strNome As String = ""
        For cont = 1 To strNomeArquivo.Length
            If Strings.Left(Strings.Right(strNomeArquivo, cont), 1) = "\" Then
                strNome = Strings.Right(strNomeArquivo, cont - 1)
                Exit For
            End If
        Next
        Return strNome
    End Function

    Function mRetornaDataCliente(ByVal conexao As MvtConnection.MvtConnection, ByVal strData As String, ByVal codProduto As Integer)
        ''
        ''deve ser usada a var conexaoPadrao
        ''
        If conexaoPadrao Is Nothing Then
            conexaoPadrao = CriarConexao(strConnDBDEFAULT)
        End If

        Dim strSQL As String
        strSQL = "SELECT Menfund_Integracao.SysRegra_getDataProducaoCliente(6," & codProduto & "," & ValueSQLDataCache(mCDate(strData)) & ")"
        Dim especifica As Boolean = False
        Dim strRetorno As String = ""
        Dim strFormato As String = ""
        Using dr As IDataReader = conexaoPadrao.ReturnDataReader(strSQL)
            While dr.Read
                strRetorno = "" & dr(0) & ""
            End While
            dr.Close()
        End Using
        Return strRetorno
    End Function

    Function mRetornaDataClienteInterna(ByVal conexao As MvtConnection.MvtConnection, ByVal strData As String, ByVal codProduto As Integer, ByVal viewmsg As Boolean)

        ''
        ''deve ser usada a var conexaoPadrao
        ''
        If conexaoPadrao Is Nothing Then
            conexaoPadrao = CriarConexao(strConnDBDEFAULT)
        End If

        Dim strSQL As String
        Dim codCli As Integer
        Dim tipoData, formatoData As New String(String.Empty)

        Dim porProduto As Boolean = True
        strSQL = "SELECT codCli, tipoData, formatoData FROM Menfund_Cad.TabProCom WHERE codPro=" & codProduto
        Using dr As IDataReader = conexaoPadrao.ReturnDataReader(strSQL)
            If dr.Read() Then
                codCli = mCInt(dr("codCli"))
                tipoData = dr("tipoData").ToString()
                formatoData = dr("formatoData").ToString()
            End If
        End Using
        If String.IsNullOrEmpty(tipoData) Then
            porProduto = False
            strSQL = "SELECT tipoData, formatoData FROM Menfund_Cad.TabCliCom WHERE codCli=" & codCli
            Using dr As IDataReader = conexaoPadrao.ReturnDataReader(strSQL)
                If dr.Read() Then
                    tipoData = dr("tipoData").ToString()
                    formatoData = dr("formatoData").ToString()
                End If
            End Using
        End If
        Dim strRetorno As String = ""
        Select Case tipoData
            Case "JULINA"
                Dim data As Date = mCDate("01/01/" & Split(strData, " ")(1))
                strRetorno = DateAdd(DateInterval.Day, mCInt(Split(strData, " ")(0)) - 1, data)
            Case "NUMERALKOD"
                strRetorno = strData
                strRetorno = Replace(strRetorno, "N", 0)
                strRetorno = Replace(strRetorno, "U", 1)
                strRetorno = Replace(strRetorno, "M", 2)
                strRetorno = Replace(strRetorno, "E", 3)
                strRetorno = Replace(strRetorno, "R", 4)
                strRetorno = Replace(strRetorno, "A", 5)
                strRetorno = Replace(strRetorno, "L", 6)
                strRetorno = Replace(strRetorno, "K", 7)
                strRetorno = Replace(strRetorno, "O", 8)
                strRetorno = Replace(strRetorno, "D", 9)
                strRetorno = Format(CDate(Replace(strRetorno, "-", "/")), "dd/MM/yyyy")
            Case "ESPECIFICA", "ESPECIFICA ANO"
                Dim dia, mes, ano, semana As String
                dia = ""
                mes = ""
                ano = ""
                semana = ""
                Dim partes() As String = formatoData.Split("-")
                For parte As Integer = 0 To partes.Length - 1
                    Select Case partes(parte)
                        Case "D"
                            dia = Piece(strData, "-", parte + 1)
                        Case "Y"
                            ano = Piece(strData, "-", parte + 1)
                        Case "M"
                            mes = Piece(strData, "-", parte + 1)
                        Case "S"
                            semana = Piece(strData, "-", parte + 1)
                    End Select
                Next
                If porProduto Then
                    strSQL = "SELECT tipo, normal, especifica, tipoData FROM Menfund_Cad.TabProDataEspecifica "
                    strSQL &= " WHERE codPro=" & codProduto
                Else
                    strSQL = "SELECT tipo, normal, especifica, tipoData FROM Menfund_Cad.TabCliDataEspecifica "
                    strSQL &= " WHERE codCli=" & codCli
                End If
                strSQL &= " AND ((1=0)"
                If Not String.IsNullOrEmpty(dia) Then
                    strSQL &= " OR (tipo='dia' AND especifica=" & ValueSQLString(dia) & ")"
                End If
                strSQL &= " OR (tipo='ano' AND especifica=" & ValueSQLString(ano) & ")"
                If Not String.IsNullOrEmpty(mes) Then
                    strSQL &= " OR (tipo='mes' AND especifica=" & ValueSQLString(mes) & ")"
                End If
                strSQL &= ")"

                Using dr As IDataReader = conexaoPadrao.ReturnDataReader(strSQL)
                    While dr.Read
                        If "" & dr("tipo") & "" = "dia" Then
                            dia = "" & dr("normal") & ""
                        End If
                        If "" & dr("tipo") & "" = "mes" Then
                            mes = "" & dr("normal") & ""
                        End If
                        If "" & dr("tipo") & "" = "ano" Then
                            ano = "" & dr("normal") & ""
                        End If
                    End While
                    dr.Close()
                End Using
                If Not String.IsNullOrEmpty(semana) Then
                    mes = String.Empty
                    Dim dataInicio As Date = RetornaDataSemana(mCInt(semana), mCInt(ano), Globalization.CalendarWeekRule.FirstFourDayWeek)
                    While (dataInicio.Day <> mCInt(dia) AndAlso dataInicio.DayOfWeek <> DayOfWeek.Saturday)
                        dataInicio = dataInicio.AddDays(1)
                    End While
                    mes = dataInicio.Month
                    ano = dataInicio.Year
                End If
                strRetorno = Replace(Replace(Replace(Replace(formatoData, "D", dia), "M", mes), "Y", ano), "S", mes)
                Try
                    strRetorno = Format(CDate(Replace(strRetorno, "-", "/")), "dd/MM/yyyy")
                Catch ex As Exception
                    MsgBox("Data incorreta!", MsgBoxStyle.Critical, MvtConnection.MvtConnection.MessageTitle)
                End Try
        End Select

        If viewmsg = True Then
            If mMensagemConfirma("Converter data para especifica do cliente?") = vbNo Then
                strRetorno = "" & strData
            End If
        Else
            'strRetorno = "" & strData
        End If

        Return strRetorno
    End Function

    Public Sub frm_KeyDown(ByVal eventSender As Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs)
        If eventArgs.KeyCode = Keys.Escape Then
            Dim frmTeste As New Form
            frmTeste = eventSender
            frmTeste.Close()
        End If
    End Sub

    Public Function mPrimeiraMaiuscula(ByVal strTexto As String)
        If strTexto = "" Then
            Return strTexto
            Exit Function
        End If
        Return UCase(fEsquerda(strTexto, 1)) & LCase(fDireita(strTexto, strTexto.Length - 1))
    End Function

    Public Function formataDataDataGrid(ByVal Text As String, Optional usarHojeParaNulo As Boolean = True)
        If Text Is Nothing Then
            Text = String.Empty
        End If
        If Text.Length > 10 Then
            Text = ""
        End If
        If Text = "" AndAlso usarHojeParaNulo Then
            Text = Today
        End If
        If Text = "" Then

        End If
        If Text.IndexOf("/") < 0 Then
            If Text.Length <= 2 Then
                Text = Text & "/" & Today.Month & "/" & Today.Year
            Else
                If Text.Length = 3 Or Text.Length = 5 Or Text.Length = 7 Then
                    Text = ""
                Else
                    If Text.Length = 4 Then
                        Text = (Strings.Left(Text, 2) & "/" & Strings.Right(Text, 2) & "/" & Today.Year)
                    Else
                        If Text.Length = 6 Then
                            Text = (Strings.Left(Text, 2) & "/" & Strings.Right(Strings.Left(Text, 4), 2) & "/" & Strings.Right(Text, 2))
                        Else

                            If Text.Length = 8 Then
                                Text = (Strings.Left(Text, 2) & "/" & Strings.Right(Strings.Left(Text, 4), 2) & "/" & Strings.Right(Text, 4))
                            End If
                        End If
                    End If
                End If
            End If
        End If
        If IsDate(Text) Then
            Text = CDate(Text)
            Return Text
        Else
            Return ""
        End If

    End Function

    Public Function mFormataCodigoProduto(ByVal strTexto As String)
        If strTexto = "" Then
            Return strTexto
            Exit Function
        End If
        Dim texto As String = strTexto
        If strTexto.Length = 8 Then

            texto = fEsquerda(strTexto, 2) & "." & fDireita(fEsquerda(strTexto, 5), 3) & "." & fDireita(strTexto, 3)

        Else
            If strTexto.Length = 9 Then
                texto = fEsquerda(strTexto, 2) & "." & fDireita(fEsquerda(strTexto, 6), 4) & "." & fDireita(strTexto, 3)
            End If
        End If

        Return texto
    End Function

    Public Function mFormataAnoMes(ByVal strTexto As String)
        On Error Resume Next
        If strTexto = "" Then
            Return strTexto
            Exit Function
        End If
        Dim texto As String = strTexto

        texto = mPrimeiraMaiuscula(Format(CDate("01/" & fDireita(strTexto, 2) & "/" & fEsquerda(strTexto, 4)), "MMMM-yy"))

        Return texto
    End Function

    Public Function VerificaArquivoEmUso(ByVal arquivo As String) As Boolean
        Dim flag As Boolean
        flag = True
        On Error Resume Next
        Err.Clear()
        System.IO.File.OpenWrite(arquivo)
        If Err.Description = "" Then
            flag = False
        End If
        Return flag

    End Function

    Public Function FirstDayOfMonth() As Date
        Return FirstDayOfMonth(Today)
    End Function

    Public Function FirstDayOfMonth(ByVal data As Date) As Date
        If data = Nothing Then
            data = Today
        End If
        Return CDate("01/" & Month(data) & "/" & Year(data))
    End Function

    Public Function FirstDayOfYear(Optional ByVal data As Date = Nothing) As Date
        If data = Nothing Then
            data = Today
        End If
        Return CDate("01/01/" & Year(data))
    End Function

    Public Function LastDayOfYear(Optional ByVal data As Date = Nothing) As Date
        If data = Nothing Then
            data = Today
        End If
        Return CDate("31/12/" & Year(data))
    End Function

    Public Function LastDayOfMonth() As Date
        Return LastDayOfMonth(Today)
    End Function

    Public Function LastDayOfMonth(ByVal data As Date) As Date
        If data = Nothing Then
            data = Today
        End If
        Return DateAdd(DateInterval.Day, -1, DateAdd(DateInterval.Month, 1, FirstDayOfMonth(data)))
    End Function

    Public Sub OpenFile(ByVal FileName As String)
        Dim processo As System.Diagnostics.Process = New Process()
        processo.StartInfo.FileName = FileName
        processo.StartInfo.WindowStyle = ProcessWindowStyle.Maximized
        processo.StartInfo.UseShellExecute = True
        processo.Start()
    End Sub

    Public Function DataCache(ByVal data As Date) As String
        Return "{d '" & Format(data, "yyyy-MM-dd") & "'}"
    End Function

    Public Function DataHoraCache(ByVal data As Date) As String
        Return "{ts '" & Format(data, "yyyy-MM-dd HH:mm:ss") & "'}"
    End Function

    Public Function HoraCache(ByVal data As Date) As String
        Return "{ts '" & Format(data, "HH:mm:ss") & "'}"
    End Function

    Sub fINIConfigBalanca()

        Dim strCaminho, strLinhaTexto As String
        strCaminho = Application.StartupPath & "\balcfg.ini"
        Dim fluxoTexto As IO.StreamReader
        strUseSkin = "0"
        If IO.File.Exists(strCaminho) Then
            fluxoTexto = New IO.StreamReader(strCaminho)
            strLinhaTexto = fluxoTexto.ReadLine
            While strLinhaTexto <> Nothing
                If fEsquerda(strLinhaTexto, 6) = "[PORT]" Then
                    balPorta = Replace(Replace(strLinhaTexto, "[PORT]", ""), "COM", "")
                End If
                If fEsquerda(strLinhaTexto, 10) = "[BAUDRATE]" Then
                    balBaudRate = Replace(strLinhaTexto, "[BAUDRATE]", "")
                End If
                If fEsquerda(strLinhaTexto, 9) = "[DATABIT]" Then
                    balDataBit = Replace(strLinhaTexto, "[DATABIT]", "")
                End If
                If fEsquerda(strLinhaTexto, 9) = "[STOPBIT]" Then
                    balStopBit = Replace(strLinhaTexto, "[STOPBIT]", "")
                End If
                If fEsquerda(strLinhaTexto, 9) = "[TIMEOUT]" Then
                    balTimeOut = Replace(strLinhaTexto, "[TIMEOUT]", "")
                End If
                If fEsquerda(strLinhaTexto, 8) = "[PARITY]" Then
                    balParity = Replace(strLinhaTexto, "[PARITY]", "")
                End If
                If fEsquerda(strLinhaTexto, 8) = "[QTDBIT]" Then
                    balQtdBit = Replace(strLinhaTexto, "[QTDBIT]", "")
                End If
                If fEsquerda(strLinhaTexto, 9) = "[EMPRESA]" Then
                    balEmpresa = Replace(strLinhaTexto, "[EMPRESA]", "")
                End If
                If fEsquerda(strLinhaTexto, 11) = "[PORTPRINT]" Then
                    balPortPrint = Replace(strLinhaTexto, "[PORTPRINT]", "")
                End If
                If fEsquerda(strLinhaTexto, 11) = "[CLEARFORM]" Then
                    balClearForm = Replace(strLinhaTexto, "[CLEARFORM]", "")
                End If
                If fEsquerda(strLinhaTexto, 7) = "[STYLE]" Then
                    balStyle = Replace(strLinhaTexto, "[STYLE]", "")
                End If
                If fEsquerda(strLinhaTexto, 8) = "[WEIGHT]" Then
                    balPeso = Replace(strLinhaTexto, "[WEIGHT]", "")
                End If
                If fEsquerda(strLinhaTexto, 11) = "[ALLFIELDS]" Then
                    balAllFields = Replace(strLinhaTexto, "[ALLFIELDS]", "")
                End If
                If fEsquerda(strLinhaTexto, 5) = "[QTD]" Then
                    balQtd = Replace(strLinhaTexto, "[QTD]", "")
                End If
                If fEsquerda(strLinhaTexto, 6) = "[OPER]" Then
                    balOper = Replace(strLinhaTexto, "[OPER]", "")
                End If
                strLinhaTexto = fluxoTexto.ReadLine
            End While
        Else
            mMensagemErro("Arquivo de configuraÁ„o da balanÁa n„o encontrado!" & vbCrLf & vbCrLf & "conect.ini")
            'End
        End If
    End Sub

    Public Function dataTimeCache(ByVal data As Date) As String
        Return "{ts '" & Format(data, "yyyy-MM-dd HH:mm:ss") & "'}"
    End Function

    Public Function MesAbrev(ByVal intMes As Integer) As String
        MesAbrev = ""
        Select Case intMes
            Case 1
                MesAbrev = "Jan"
            Case 2
                MesAbrev = "Fev"
            Case 3
                MesAbrev = "Mar"
            Case 4
                MesAbrev = "Abr"
            Case 5
                MesAbrev = "Mai"
            Case 6
                MesAbrev = "Jun"
            Case 7
                MesAbrev = "Jul"
            Case 8
                MesAbrev = "Ago"
            Case 9
                MesAbrev = "Set"
            Case 10
                MesAbrev = "Out"
            Case 11
                MesAbrev = "Nov"
            Case 12
                MesAbrev = "Dez"
        End Select
        Return MesAbrev

    End Function

    Function RemoveAcento(ByVal txt)
        Const ComAcento = "‡‚ÍÙ˚„ı·ÈÌÛ˙Á¸¿¬ ‘€√’¡…Õ”⁄«‹"
        Const SemAcento = "aaeouaoaeioucuAAEOUAOAEIOUCU"
        Dim i
        Dim c
        Dim res As String = ""
        Dim pos As Integer

        For i = 1 To Len(txt)
            c = Mid(txt, i, 1)
            pos = InStr(1, ComAcento, c)

            If pos > 0 Then
                c = Mid(SemAcento, pos, 1)
            End If

            res = res + c
        Next

        RemoveAcento = res
    End Function

    Function getWeekOfYear(ByVal dateValue As Date, Optional weekRule As Globalization.CalendarWeekRule = Globalization.CalendarWeekRule.FirstFullWeek) As Integer
        Return getWeekOfYear(dateValue, DayOfWeek.Sunday, weekRule)
    End Function

    Function getWeekOfYear(ByVal dateValue As Date, weekStartDay As DayOfWeek, Optional weekRule As Globalization.CalendarWeekRule = Globalization.CalendarWeekRule.FirstFullWeek) As Integer
        Dim cult_info As System.Globalization.CultureInfo = System.Globalization.CultureInfo.CreateSpecificCulture("no")
        Dim cal As System.Globalization.Calendar = cult_info.Calendar
        Dim weekNO As Integer = cal.GetWeekOfYear(dateValue, weekRule, weekStartDay)
        Return weekNO
    End Function

    Function RetornaDataSemana(ByVal semana As Integer, ByVal ano As Integer, Optional weekRule As Globalization.CalendarWeekRule = Globalization.CalendarWeekRule.FirstFullWeek) As Date
        Dim data As Date = "01/01/" & ano

        While getWeekOfYear(data, weekRule) <> 1
            data = data.AddDays(1)
        End While

        data = DateAdd(DateInterval.WeekOfYear, semana - 1, data)

        While data.DayOfWeek > 0
            data = DateAdd(DateInterval.Day, -1, data)
        End While
        Return data
    End Function

    Function ExecutaSPODBC(ByVal conexao As MvtConnection.MvtConnection, ByVal strComando As String)
        ''
        ''deve ser usada a var conexaoPadrao
        ''
        If conexaoPadrao Is Nothing Then
            conexaoPadrao = CriarConexao(strConnDBDEFAULT)
        End If

        Using dr As IDataReader = conexaoPadrao.ReturnDataReader(strComando)
            Dim ret As String = ""
            While dr.Read
                ret = "" & dr(0) & ""
            End While
            dr.Close()
        End Using
        Return ""
    End Function

    Function ReplaceCaractersHTML(ByVal strTexto As String) As String

        strTexto = Replace(strTexto, "&", "&amp;")
        strTexto = Replace(strTexto, "¡", "&Aacute;")
        strTexto = Replace(strTexto, "·", "&aacute;")
        strTexto = Replace(strTexto, "¬", "&Acirc;")
        strTexto = Replace(strTexto, "‚", "&acirc;")
        strTexto = Replace(strTexto, "¿", "&Agrave;")
        strTexto = Replace(strTexto, "‡", "&agrave;")
        strTexto = Replace(strTexto, "≈", "&Aring;")
        strTexto = Replace(strTexto, "Â", "&aring;")
        strTexto = Replace(strTexto, "√", "&Atilde;")
        strTexto = Replace(strTexto, "„", "&atilde;")
        strTexto = Replace(strTexto, "ƒ", "&Auml;")
        strTexto = Replace(strTexto, "‰", "&auml;")
        strTexto = Replace(strTexto, "∆", "&AElig;")
        strTexto = Replace(strTexto, "Ê", "&aelig;")
        strTexto = Replace(strTexto, "…", "&Eacute;")
        strTexto = Replace(strTexto, "È", "&eacute;")
        strTexto = Replace(strTexto, " ", "&Ecirc;")
        strTexto = Replace(strTexto, "Í", "&ecirc;")
        strTexto = Replace(strTexto, "»", "&Egrave;")
        strTexto = Replace(strTexto, "Ë", "&egrave;")
        strTexto = Replace(strTexto, "À", "&Euml;")
        strTexto = Replace(strTexto, "Î", "&euml;")
        strTexto = Replace(strTexto, "–", "&ETH;")
        strTexto = Replace(strTexto, "", "&eth;")
        strTexto = Replace(strTexto, "Õ", "&Iacute;")
        strTexto = Replace(strTexto, "Ì", "&iacute;")
        strTexto = Replace(strTexto, "Œ", "&Icirc;")
        strTexto = Replace(strTexto, "Ó", "&icirc;")
        strTexto = Replace(strTexto, "Ã", "&Igrave;")
        strTexto = Replace(strTexto, "Ï", "&igrave;")
        strTexto = Replace(strTexto, "œ", "&Iuml;")
        strTexto = Replace(strTexto, "Ô", "&iuml;")
        strTexto = Replace(strTexto, "”", "&Oacute;")
        strTexto = Replace(strTexto, "Û", "&oacute;")
        strTexto = Replace(strTexto, "‘", "&Ocirc;")
        strTexto = Replace(strTexto, "Ù", "&ocirc;")
        strTexto = Replace(strTexto, "“", "&Ograve;")
        strTexto = Replace(strTexto, "Ú", "&ograve;")
        strTexto = Replace(strTexto, "ÿ", "&Oslash;")
        strTexto = Replace(strTexto, "¯", "&oslash;")
        strTexto = Replace(strTexto, "’", "&Otilde;")
        strTexto = Replace(strTexto, "ı", "&otilde;")
        strTexto = Replace(strTexto, "÷", "&Ouml;")
        strTexto = Replace(strTexto, "ˆ", "&ouml;")
        strTexto = Replace(strTexto, "⁄", "&Uacute;")
        strTexto = Replace(strTexto, "˙", "&uacute;")
        strTexto = Replace(strTexto, "€", "&Ucirc;")
        strTexto = Replace(strTexto, "˚", "&ucirc;")
        strTexto = Replace(strTexto, "Ÿ", "&Ugrave;")
        strTexto = Replace(strTexto, "˘", "&ugrave;")
        strTexto = Replace(strTexto, "‹", "&Uuml;")
        strTexto = Replace(strTexto, "¸", "&uuml;")
        strTexto = Replace(strTexto, "«", "&Ccedil;")
        strTexto = Replace(strTexto, "Á", "&ccedil;")
        strTexto = Replace(strTexto, "—", "&Ntilde;")
        strTexto = Replace(strTexto, "Ò", "&ntilde;")
        strTexto = Replace(strTexto, "<", "&lt;")
        strTexto = Replace(strTexto, ">", "&gt;")
        strTexto = Replace(strTexto, """", "&quot;")
        strTexto = Replace(strTexto, "Æ", "&reg;")
        strTexto = Replace(strTexto, "©", "&copy;")
        strTexto = Replace(strTexto, "›", "&Yacute;")
        strTexto = Replace(strTexto, "˝", "&yacute;")
        strTexto = Replace(strTexto, "ﬁ", "&THORN;")
        strTexto = Replace(strTexto, "˛", "&thorn;")
        strTexto = Replace(strTexto, "ﬂ", "&szlig;")

        Return strTexto

    End Function

    Public Function Mes(ByVal intMes As Integer) As String
        Mes = ""
        Select Case intMes
            Case 1
                Mes = "Janeiro"
            Case 2
                Mes = "Fevereiro"
            Case 3
                Mes = "MarÁo"
            Case 4
                Mes = "Abril"
            Case 5
                Mes = "Maio"
            Case 6
                Mes = "Junho"
            Case 7
                Mes = "Julho"
            Case 8
                Mes = "Agosto"
            Case 9
                Mes = "Setembro"
            Case 10
                Mes = "Outubro"
            Case 11
                Mes = "Novembro"
            Case 12
                Mes = "Dezembro"
        End Select
        Return Mes

    End Function

    Public Function MesNumerico(ByVal nomeMes As String, Optional ByVal mesAbreviado As Boolean = False) As Integer
        Dim mes As Integer = 0
        If mesAbreviado = False Then
            Select Case UCase(nomeMes)
                Case "JANEIRO"
                    mes = 1
                Case "FEVEREIRO"
                    mes = 2
                Case "MAR«O"
                    mes = 3
                Case "ABRIL"
                    mes = 4
                Case "MAIO"
                    mes = 5
                Case "JUNHO"
                    mes = 6
                Case "JULHO"
                    mes = 7
                Case "AGOSTO"
                    mes = 8
                Case "SETEMBRO"
                    mes = 9
                Case "OUTUBRO"
                    mes = 10
                Case "NOVEMBRO"
                    mes = 11
                Case "DEZEMBRO"
                    mes = 12
            End Select
        Else
            Select Case UCase(nomeMes)
                Case "JAN"
                    mes = 1
                Case "FEV"
                    mes = 2
                Case "MAR"
                    mes = 3
                Case "ABR"
                    mes = 4
                Case "MAI"
                    mes = 5
                Case "JUN"
                    mes = 6
                Case "JUL"
                    mes = 7
                Case "AGO"
                    mes = 8
                Case "SET"
                    mes = 9
                Case "OUT"
                    mes = 10
                Case "NOV"
                    mes = 11
                Case "DEZ"
                    mes = 12
            End Select
        End If
        Return mes

    End Function

    Public Function Piece(ByVal texto As String, ByVal separador As String, ByVal pedaco As Integer)
        If texto <> Nothing Then
            Dim splitText As String() = texto.Split({separador}, StringSplitOptions.None)
            If splitText.Length >= pedaco Then
                Return splitText(pedaco - 1)
            End If
        End If
        Return ""
    End Function

    Public Function NumeroPorExtenso(ByVal number As Decimal) As String

        Dim cent As Integer
        Try
            ' Verifica a parte decimal, ou seja, os cÍntimos
            cent = Decimal.Round((number - Int(number)) * 100, MidpointRounding.ToEven)
            ' Verifica apenas a parte inteira
            number = Int(number)
            ' Caso existam cÍntimos
            If cent > 0 Then
                ' Caso seja 1 n„o coloca "Reaiss" mas sim "Reais"
                If number = 1 Then
                    Return "Um Real e " + getDecimal(cent) + "Centavos"
                Else
                    Return getInteger(number) + "Reais e " + getDecimal(cent) + "Centavos"
                End If
            Else
                ' Caso seja 1 n„o coloca "Reais" mas sim "Real"
                If number = 1 Then
                    Return "Um Real"
                Else
                    Return getInteger(number) + "Reais"
                End If
            End If
        Catch ex As Exception

            Return ""

        End Try
    End Function

    Function ReturnEmailConfDePara(ByVal conexao As MvtConnection.MvtConnection, ByVal programa As String) As String
        ''
        ''deve ser usada a var conexaoPadrao
        ''
        If conexaoPadrao Is Nothing Then
            conexaoPadrao = CriarConexao(strConnDBDEFAULT)
        End If

        Dim de As String = ""
        Dim para As String = ""

        Using drEmail As IDataReader = conexaoPadrao.ReturnDataReader("SELECT de, para FROM Menfund_Menu.ConfiguracaoEmail WHERE programa='" & programa & "'")
            While drEmail.Read
                de = Replace(drEmail("de") & "", " ", "")
                para = Replace(drEmail("para") & "", " ", "")
                Exit While
            End While
            drEmail.Close()
        End Using

        If UCase(de) = "USUARIO" Then
            Using drEmail As IDataReader = conexaoPadrao.ReturnDataReader("SELECT email FROM Mvt_Acesso.Usuario WHERE usuario='" & strUsuarioLogado & "'")
                While drEmail.Read()
                    de = drEmail("email") & ""
                End While
                drEmail.Close()
            End Using

            If UCase(de) = "USUARIO" Or de = "" Then
                de = "movtech@menegotti.ind.br"
            End If
        End If

        Return de & "||" & para
    End Function

    Public Function RetornaNomeUsuario(ByVal usuario As String) As String
        ''
        ''esta funcao deve ser usada passando a var conexaoPadrao!!!
        ''
        If usuario = "" Then
            usuario = strUsuarioLogado
        End If
        Dim strSQL As String
        strSQL = "SELECT nome FROM Mvt_Acesso.Usuario WHERE usuario = '" & usuario & "'"
        Using dr As IDataReader = conexaoPadrao.ReturnDataReader(strSQL)
            While dr.Read
                Return "" & "" & dr("nome")
            End While
            dr.Close()
        End Using
        Return ""
    End Function

    Public Function RetornaGrupoUsuarioLogado() As String
        ''
        ''esta funcao deve ser usada passando a var conexaoPadrao!!!
        ''
        If conexaoPadrao Is Nothing Then
            conexaoPadrao = CriarConexao(strConnDBDEFAULT)
        End If
        Dim grupo As String = ""
        Dim strSQL2 As String = "select Grupo.codGrupo, Grupo.nomeGrupo from Mvt_Acesso.Usuario Usuario, Mvt_Acesso.Grupo Grupo WHERE usuario = '" & strUsuarioLogado & "' AND Grupo.codGrupo = Usuario.codGrupo"
        Using dr As System.Data.IDataReader = conexaoPadrao.ReturnDataReader(strSQL2)
            While dr.Read
                grupo = "" & dr(1).ToString.ToUpper
            End While
            dr.Close()
        End Using
        Return grupo
    End Function

    Public Function RetornaGrupoUsuarioLogadoCACHE() As String
        ''
        ''esta funcao deve ser usada passando a var conexaoPadrao!!!
        ''
        If conexaoPadrao Is Nothing Then
            conexaoPadrao = CriarConexao(strConnDBDEFAULT)
        End If
        Dim grupo As String = ""
        Dim strSQL2 As String = "select Grupo.codGrupo, Grupo.nomeGrupo from Mvt_Acesso.Usuario Usuario, Mvt_Acesso.Grupo Grupo WHERE usuario = '" & strUsuarioLogado & "' AND Grupo.codGrupo = Usuario.codGrupo"
        Using dr As System.Data.IDataReader = conexaoPadrao.ReturnDataReader(strSQL2)
            While dr.Read
                grupo = "" & dr(1).ToString.ToUpper
            End While
            dr.Close()
        End Using
        Return grupo
    End Function

    Function QuebraTexto(ByVal texto As String, ByVal tamanhoLinha As Integer, ByRef proximaPosicao As Integer)
        If texto = "" Then
            Return ""
            Exit Function
        End If

        Dim posicaoInicial As Integer

        posicaoInicial = proximaPosicao

        If posicaoInicial > texto.Length Then
            Return ""
            Exit Function
        End If
        If Not posicaoInicial >= texto.Length Then
            While texto.Substring(posicaoInicial, 1) <> " "
                If posicaoInicial = 0 Then
                    Exit While
                End If
                posicaoInicial -= 1
            End While
        End If
        Dim posicaofinal As Integer
        posicaofinal = posicaoInicial + tamanhoLinha

        If posicaofinal > texto.Length Then
            If posicaofinal > texto.Length Then
                posicaofinal = texto.Length
            End If
        Else

            While texto.Substring(posicaofinal - 1, 1) <> " "
                posicaofinal = posicaofinal - 1
                If posicaofinal <= 1 Then
                    Return ""
                    Exit Function
                End If
            End While
        End If

        Dim textoRetorna As String
        proximaPosicao = posicaofinal + 1
        posicaofinal = posicaofinal - posicaoInicial

        textoRetorna = texto.Substring(posicaoInicial, posicaofinal)
        Return textoRetorna
    End Function

    Function QuebraTextoConsideraVbCrLf(ByRef texto As String, ByVal tamanhoLinha As Integer, ByRef proximaPosicao As Integer)
        Dim textoRetorna As String = QuebraTexto(texto, tamanhoLinha, proximaPosicao)
        If textoRetorna.Contains(vbCrLf) Then
            proximaPosicao -= (textoRetorna.Length - Piece(textoRetorna, vbCrLf, 1).ToString.Length)
            proximaPosicao += 1
            texto = texto.Insert(proximaPosicao, " ")
            textoRetorna = Piece(textoRetorna, vbCrLf, 1)
        End If
        Return textoRetorna.Trim
    End Function

    Public Function getDecimal(ByVal number As Byte) As String
        Try
            Select Case number
                Case 0
                    Return ""
                Case 1 To 19
                    Dim strArray() As String = {"Um", "Dois", "TrÍs", "Quatro", "Cinco", "Seis", "Sete", "Oito", "Nove", "Dez", "Onze", "Doze", "Treze", "Quatorze", "Quinze", "Dezasseis", "Dezassete", "Dezoito", "Dezanove"}
                    Return strArray(number - 1) + " "
                Case 20 To 99
                    Dim strArray() As String = {"Vinte", "Trinta", "Quarenta", "Cinquenta", "Sessenta", "Setenta", "Oitenta", "Noventa"}
                    If (number Mod 10) = 0 Then
                        Return strArray(number \ 10 - 2) + " "
                    Else
                        Return strArray(number \ 10 - 2) + " e " + getDecimal(number Mod 10) + " "
                    End If
                Case Else
                    Return ""
            End Select
        Catch ex As Exception

            Return ""

        End Try

    End Function

    Public Function getInteger(ByVal number As Decimal, Optional gen As Genero = Genero.Masculino) As String
        Try
            number = Int(number)
            Select Case number
                Case Is < 0
                    Return "-" & getInteger(-number)
                Case 0
                    Return ""
                Case 1 To 19
                    Dim strArray() As String
                    If gen = Genero.Masculino Then
                        strArray = {"Um", "Dois", "TrÍs", "Quatro", "Cinco", "Seis", "Sete", "Oito", "Nove", "Dez", "Onze", "Doze", "Treze", "Quatorze", "Quinze", "Dezasseis", "Dezassete", "Dezoito", "Dezenove"}
                    Else
                        strArray = {"Uma", "Duas", "TrÍs", "Quatro", "Cinco", "Seis", "Sete", "Oito", "Nove", "Dez", "Onze", "Doze", "Treze", "Quatorze", "Quinze", "Dezasseis", "Dezassete", "Dezoito", "Dezenove"}
                    End If
                    Return strArray(number - 1) + " "
                Case 20 To 99
                    Dim strArray() As String = {"Vinte", "Trinta", "Quarenta", "Cinquenta", "Sessenta", "Setenta", "Oitenta", "Noventa"}
                    If (number Mod 10) = 0 Then
                        Return strArray(number \ 10 - 2)
                    Else
                        Return strArray(number \ 10 - 2) + " e " + getInteger(number Mod 10)
                    End If
                Case 100
                    Return "Cem"
                Case 101 To 999
                    Dim strArray() As String = {"Cento", "Duzentos", "Trezentos", "Quatrocentos", "Quinhentos", "Seiscentos", "Setecentos", "Oitocentos", "Novecentos"}
                    If (number Mod 100) = 0 Then
                        Return strArray(number \ 100 - 1) + " "
                    Else
                        Return strArray(number \ 100 - 1) + " e " + getInteger(number Mod 100)
                    End If
                Case 1000 To 1999
                    Select Case (number Mod 1000)
                        Case 0
                            Return "Mil"
                        Case Is <= 100
                            Return "Mil e " + getInteger(number Mod 1000)
                        Case Else
                            Return "Mil, " + getInteger(number Mod 1000)
                    End Select
                Case 2000 To 999999
                    Select Case (number Mod 1000)
                        Case 0
                            Return getInteger(number \ 1000) & "Mil"
                        Case Is <= 100
                            Return getInteger(number \ 1000) & "Mil e " & getInteger(number Mod 1000)
                        Case Else
                            Return getInteger(number \ 1000) & "Mil, " & getInteger(number Mod 1000)
                    End Select
                Case 1000000 To 1999999
                    Select Case (number Mod 1000000)
                        Case 0
                            Return "Um Milh„o"
                        Case Is <= 100
                            Return getInteger(number \ 1000000) + "Milh„o e " & getInteger(number Mod 1000000)
                        Case Else
                            Return getInteger(number \ 1000000) + "Milh„o, " & getInteger(number Mod 1000000)
                    End Select
                Case 2000000 To 999999999
                    Select Case (number Mod 1000000)
                        Case 0
                            Return getInteger(number \ 1000000) + " Milhıes"
                        Case Is <= 100
                            Return getInteger(number \ 1000000) + "Milhıes e " & getInteger(number Mod 1000000)
                        Case Else
                            Return getInteger(number \ 1000000) + "Milhıes, " & getInteger(number Mod 1000000)
                    End Select
                Case 1000000000 To 1999999999
                    Select Case (number Mod 1000000000)
                        Case 0
                            Return "Um Bili„o"
                        Case Is <= 100
                            Return getInteger(number \ 1000000000) + "Bili„o e " + getInteger(number Mod 1000000000)
                        Case Else
                            Return getInteger(number \ 1000000000) + "Bili„o, " + getInteger(number Mod 1000000000)
                    End Select
                Case Else
                    Select Case (number Mod 1000000000)
                        Case 0
                            Return getInteger(number \ 1000000000) + " Biliıes"
                        Case Is <= 100
                            Return getInteger(number \ 1000000000) + "Biliıes e " + getInteger(number Mod 1000000000)
                        Case Else
                            Return getInteger(number \ 1000000000) + "Biliıes, " + getInteger(number Mod 1000000000)
                    End Select
            End Select
        Catch ex As Exception

            Return ""

        End Try

    End Function

    Public Function ValueSQLString(ByVal value As String) As String
        On Error Resume Next
        Dim strValor As String = ""
        strValor = "'" & Replace(value, "'", "''") & "'"
        If value = "" Then
            strValor = "NULL"
        End If
        Return strValor
    End Function

    Public Function ValueSQLDataCache(ByVal data As Date) As String
        Return "{d '" & Format(data, "yyyy-MM-dd") & "'}"
    End Function

    Public Function ValueSQLDataOracle(ByVal data As Date) As String
        Return "TO_DATE('" & Format(data, "yyyy-MM-dd") & "','yyyy-MM-dd')"
    End Function

    Public Function ValueSqlLike(ByVal value As Object) As String

        On Error Resume Next
        Dim strValor As String = ""

        strValor = "'%" & value & "%'"

        Return strValor

    End Function

    Public Function ValueSQLDataHoraCache(ByVal data As Date) As String
        Return "{ts '" & Format(data, "yyyy-MM-dd HH:mm:ss") & "'}"
    End Function

    Public Function ValueSQLDataHoraOracle(ByVal data As Date) As String
        Return "TO_DATE('" & Format(data, "yyyy-MM-dd HH:mm:ss") & "','yyyy-MM-dd HH24:MI:SS')"
    End Function

    Public Function ValueSQLHoraCache(ByVal data As Date) As String
        Return "{ts '" & Format(data, "HH:mm:ss") & "'}"
    End Function

    Public Function ValueSQLNumber(ByVal value As Object) As String
        On Error Resume Next
        Dim strValor As String = ""
        If IsNumeric(value) AndAlso Not Double.IsNaN(value) Then
            strValor = Replace(Replace(value, ".", ""), ",", ".")
        Else
            strValor = "NULL"
        End If

        Return strValor
    End Function

    Function DataNormalParaDataWindows(ByVal dataNormal As Date) As Integer

        Return DateDiff(DateInterval.Day, CDate("01/01/1900"), dataNormal) + 2

    End Function

    Function DataCacheParaDataNormal(ByVal dataCache As Integer) As Date

        dataCache = dataCache - 21550

        Return DateAdd(DateInterval.Day, dataCache, CDate("01/01/1900"))

    End Function

    Function DataWindowsParaDataNormal(ByVal dataWindows As Integer) As Date

        dataWindows = dataWindows - 2

        Return DateAdd(DateInterval.Day, dataWindows, CDate("01/01/1900"))

    End Function

    Function ExecutaSP(ByVal conexao As MvtConnection.MvtConnection, ByVal strComando As String)
        ''
        ''deve ser usada a var conexaoPadrao
        ''
        If conexaoPadrao Is Nothing Then
            conexaoPadrao = CriarConexao(strConnDBDEFAULT)
        End If

        Dim comando As New OdbcCommand

        comando.CommandText = strComando
        comando.CommandType = CommandType.StoredProcedure
        comando.Connection = conexaoPadrao.ConnectionODBC

        Dim msgErro As New OdbcParameter()
        msgErro = New OdbcParameter()
        msgErro.Size = 300
        msgErro.Direction = ParameterDirection.ReturnValue
        msgErro = comando.Parameters.Add(msgErro)
        If comando.Connection.State = ConnectionState.Closed Then
            comando.Connection.Open()
        End If
        Using dr As IDataReader = comando.ExecuteReader()
            dr.Close()
            Return "" & comando.Parameters(0).Value
        End Using
    End Function

    Function getTraducao(ByVal expressao As String, ByVal codIdioma As Integer, ByVal conexao As MvtConnection.MvtConnection) As String
        ''
        ''deve ser usada a var conexaoPadrao
        ''
        If conexaoPadrao Is Nothing Then
            conexaoPadrao = CriarConexao(strConnDBDEFAULT)
        End If
        Dim strSQL As String

        strSQL = "SELECT expressaoEstrangeira" & Chr(13) & Chr(10)
        strSQL = strSQL & "FROM Mvt_Exportacao.Dicionario" & Chr(13) & Chr(10)
        strSQL = strSQL & "WHERE expressaoPortugues = '" & expressao & "'" & Chr(13) & Chr(10)
        strSQL = strSQL & "    AND codIdioma = " & codIdioma & Chr(13) & Chr(10)

        Using dr As System.Data.IDataReader = conexaoPadrao.ReturnDataReader(strSQL)
            While dr.Read
                Return "" & "" & dr("expressaoEstrangeira")
                Exit Function
            End While
            dr.Close()
        End Using
        Return expressao
    End Function

    Public Function dataMySql(ByVal data As String) As String
        If IsDate(data) AndAlso CDate(data).ToOADate >= 1 Then
            Return "'" & Format(CDate(data), "yyyy-MM-dd") & "'"
        End If
        Return "NULL"
    End Function

    Public Function dataHoraMySql(ByVal data As String) As String
        If IsDate(data) Then
            Return "'" & Format(CDate(data), "yyyy-MM-dd HH:mm:ss") & "'"
        End If
        Return "NULL"
    End Function

    Public Function NumeroToExtensoDolarEspanhol(ByVal number As Decimal) As String
        Dim cent As Integer
        Try
            ' se for =0 retorna 0 reais
            If number = 0 Then
                Return "Cero Dollares"
            End If
            ' Verifica a parte decimal, ou seja, os centavos
            cent = Decimal.Round((number - Int(number)) * 100, MidpointRounding.ToEven)
            ' Verifica apenas a parte inteira
            number = Int(number)
            ' Caso existam centavos
            If cent > 0 Then
                ' Caso seja 1 n„o coloca "Reais" mas sim "Real"
                If number = 1 Then
                    Return "Uno Dollar y " + getDecimalEspanhol(cent) + " cents"
                    ' Caso o valor seja inferior a 1 Real
                ElseIf number = 0 Then
                    Return getDecimalEspanhol(cent) + " cents"
                Else
                    Return getIntegerEspanhol(number) + " Dollares y " + getDecimalEspanhol(cent) + " cents"
                End If
            Else
                ' Caso seja 1 n„o coloca "Reais" mas sim "Real"
                If number = 1 Then
                    Return "Uno Dollar"
                Else
                    Return getIntegerEspanhol(number) + " Dollares"
                End If
            End If
        Catch ex As Exception
            Return ""
        End Try
    End Function

    Public Function NumeroToExtensoDolarIngles(ByVal number As Decimal) As String
        Dim cent As Integer
        Try
            ' se for =0 retorna 0 reais
            If number = 0 Then
                Return "Zero Dollares"
            End If
            ' Verifica a parte decimal, ou seja, os centavos
            cent = Decimal.Round((number - Int(number)) * 100, MidpointRounding.ToEven)
            ' Verifica apenas a parte inteira
            number = Int(number)
            ' Caso existam centavos
            If cent > 0 Then
                ' Caso seja 1 n„o coloca "Reais" mas sim "Real"
                If number = 1 Then
                    Return "One Dollar and " + getDecimalIngles(cent) + " cents"
                    ' Caso o valor seja inferior a 1 Real
                ElseIf number = 0 Then
                    Return getDecimalIngles(cent) + " cents"
                Else
                    Return getIntegerIngles(number) + " Dollares and " + getDecimalIngles(cent) + " cents"
                End If
            Else
                ' Caso seja 1 n„o coloca "Reais" mas sim "Real"
                If number = 1 Then
                    Return "One Dollar"
                Else
                    Return getIntegerIngles(number) + "Dollares"
                End If
            End If
        Catch ex As Exception
            Return ""
        End Try
    End Function

    Public Function NumeroToExtensoDolarPortugues(ByVal number As Decimal) As String
        Dim numeroRetorno As String = ""

        Dim cent As Integer
        Try
            ' se for =0 retorna 0 reais
            If number = 0 Then
                Return "Zero DÛlares"
            End If
            ' Verifica a parte decimal, ou seja, os centavos
            cent = Decimal.Round((number - Int(number)) * 100, MidpointRounding.ToEven)
            ' Verifica apenas a parte inteira
            number = Int(number)
            ' Caso existam centavos
            If cent > 0 Then
                ' Caso seja 1 n„o coloca "Reais" mas sim "Real"
                If number = 1 Then
                    Return "Um DÛlar e " + getDecimalPortugues(cent) + " centavos"
                    ' Caso o valor seja inferior a 1 Real
                ElseIf number = 0 Then
                    Return getDecimalPortugues(cent) + " centavos"
                Else
                    Return getIntegerPortugues(number) + " DÛlares e " + getDecimalPortugues(cent) + " centavos"
                End If
            Else
                ' Caso seja 1 n„o coloca "Reais" mas sim "Real"
                If number = 1 Then
                    Return "Um DÛlar".ToLower
                Else
                    Return getIntegerPortugues(number) + "DÛlares"
                End If
            End If
        Catch ex As Exception
            Return ""
        End Try
    End Function

    Function PrimeiraMaiscula(ByVal texto As String)
        If String.IsNullOrEmpty(texto) Then
            Return String.Empty
        End If
        Return texto.Substring(0, 1).ToUpper & texto.Substring(1, texto.Length - 1).ToLower
    End Function

    Function FormataCNPJ(ByVal cnpj As String) As String
        Dim mascaraCNPJ As New MaskedTextProvider("00\.000\.000/0000-00")
        mascaraCNPJ.Set(cnpj)
        Dim CNPJFormatado As String = mascaraCNPJ.ToString

        Return CNPJFormatado
    End Function

    Function FormataCPF(ByVal cpf As String) As String
        Dim mascaraCPF As New MaskedTextProvider("000\.000\.000-00")
        mascaraCPF.Set(cpf)
        Dim CPFFormatado As String = mascaraCPF.ToString

        Return CPFFormatado
    End Function

    Function FormataCEP(ByVal cep As String) As String
        Dim mascaraCEP As New MaskedTextProvider("00\.000-000")
        mascaraCEP.Set(cep)
        Dim CEPFormatado As String = mascaraCEP.ToString

        Return CEPFormatado
    End Function

    Function FormataPIS(ByVal pis As String) As String
        Dim mascaraPIS As New MaskedTextProvider("00000000\.00\.0")
        mascaraPIS.Set(pis)
        Dim PISFormatado As String = mascaraPIS.ToString

        Return PISFormatado
    End Function

    Public Function getDecimalEspanhol(ByVal number As Byte) As String
        Try
            Select Case number
                Case 0
                    Return ""
                Case 1 To 19
                    Dim strArray() As String =
                       {"Uno", "Dos", "Tres", "Cuatro", "Cinco", "Seis",
                         "Siete", "Ocho", "Nueve", "Diez", "Once",
                         "Doce", "Trece", "Catorce", "Quince",
                         "DiecisÈis", "Diecisiete", "Dieciocho", "Diecinueve"}
                    Return strArray(number - 1)
                Case 20 To 99
                    Dim strArray() As String =
                        {"Veinte", "Treinta", "Cuarenta", "Cincuenta",
                         "Sesenta", "Setenta", "Ocho", "Noventa"}
                    If (number Mod 10) = 0 Then
                        Return strArray(number \ 10 - 2)
                    Else
                        Return strArray(number \ 10 - 2) + " y " + getDecimalEspanhol(number Mod 10)
                    End If
                Case Else
                    Return ""
            End Select
        Catch ex As Exception
            Return ""
        End Try
    End Function

    Public Function getDecimalIngles(ByVal number As Byte) As String
        Try
            Select Case number
                Case 0
                    Return ""
                Case 1 To 19
                    Dim strArray() As String =
                       {"One", "Two", "Three", "Four", "Five", "Six",
                          "Seven", "Eight", "Nine", " Ten", " Once",
                          "Twelve", "Thirteen", "Fourteen", "Fifteen",
                          "Sixteen", "Seventeen", "Eighteen", "'Nineteen"}
                    Return strArray(number - 1)
                Case 20 To 99
                    Dim strArray() As String =
                        {"Twenty", "Thirty", "Forty", "Fifty",
                          "Sixty", "Seventy", "Eight", "Ninety"}
                    If (number Mod 10) = 0 Then
                        Return strArray(number \ 10 - 2)
                    Else
                        Return strArray(number \ 10 - 2) + " and " + getDecimalIngles(number Mod 10)
                    End If
                Case Else
                    Return ""
            End Select
        Catch ex As Exception
            Return ""
        End Try
    End Function

    Public Function getIntegerEspanhol(ByVal number As Decimal) As String
        Try
            number = Int(number)
            Select Case number
                Case Is < 0
                    Return "-" & getDecimalEspanhol(-number)
                Case 0
                    Return ""
                Case 1 To 19
                    Dim strArray() As String =
                        {"Uno", "Dos", "Tres", "Cuatro", "Cinco", "Seis",
                         "Siete", "Ocho", "Nueve", "Diez", "Once",
                         "Doce", "Trece", "Catorce", "Quince",
                         "DiecisÈis", "Diecisiete", "Dieciocho", "Diecinueve"}
                    Return strArray(number - 1)
                Case 20 To 99
                    Dim strArray() As String =
                        {"Veinte", "Treinta", "Cuarenta", "Cincuenta",
                         "Sesenta", "Setenta", "Ocho", "Noventa"}
                    If (number Mod 10) = 0 Then
                        Return strArray(number \ 10 - 2)
                    Else
                        Return strArray(number \ 10 - 2) + " y " + getIntegerEspanhol(number Mod 10)
                    End If
                Case 100
                    Return "Ciento"
                Case 101 To 999
                    Dim strArray() As String =
                          {"Ciento", "Doscientos", "Trescientos", "Cuatrocientos", "Cinco",
                            "Seis", "Setecientos", "Ochocientos", "Nueve"}
                    If (number Mod 100) = 0 Then
                        Return strArray(number \ 100 - 1)
                    Else
                        'Return strArray(number \ 100 - 1) + " y " + getIntegerEspanhol(number Mod 100)
                        Return strArray(number \ 100 - 1) + " " + getIntegerEspanhol(number Mod 100)
                    End If
                Case 1000 To 1999
                    Select Case (number Mod 1000)
                        Case 0
                            Return "Mil"
                        Case Is <= 100
                            Return " Mil y " + getIntegerEspanhol(number Mod 1000)
                        Case Else
                            Return " Mil, " + getIntegerEspanhol(number Mod 1000)
                    End Select
                Case 2000 To 999999
                    Select Case (number Mod 1000)
                        Case 0
                            Return getIntegerEspanhol(number \ 1000) & "Mil"
                        Case Is <= 100
                            Return getIntegerEspanhol(number \ 1000) & " Mil y " & getIntegerEspanhol(number Mod 1000)
                        Case Else
                            Return getIntegerEspanhol(number \ 1000) & " Mil, " & getIntegerEspanhol(number Mod 1000)
                    End Select
                Case 1000000 To 1999999
                    Select Case (number Mod 1000000)
                        Case 0
                            Return "Uno Millone"
                        Case Is <= 100
                            Return getIntegerEspanhol(number \ 1000000) + " Millone y " & getIntegerEspanhol(number Mod 1000000)
                        Case Else
                            Return getIntegerEspanhol(number \ 1000000) + " Millone, " & getIntegerEspanhol(number Mod 1000000)
                    End Select
                Case 2000000 To 999999999
                    Select Case (number Mod 1000000)
                        Case 0
                            Return getIntegerEspanhol(number \ 1000000) + "Millones"
                        Case Is <= 100
                            Return getIntegerEspanhol(number \ 1000000) + " Millones y " & getIntegerEspanhol(number Mod 1000000)
                        Case Else
                            Return getIntegerEspanhol(number \ 1000000) + " Millones, " & getIntegerEspanhol(number Mod 1000000)
                    End Select
                Case 1000000000 To 1999999999
                    Select Case (number Mod 1000000000)
                        Case 0
                            Return "Uno Billone"
                        Case Is <= 100
                            Return getIntegerEspanhol(number \ 1000000000) + " Billone y " + getIntegerEspanhol(number Mod 1000000000)
                        Case Else
                            Return getIntegerEspanhol(number \ 1000000000) + " Billone, " + getIntegerEspanhol(number Mod 1000000000)
                    End Select
                Case Else
                    Select Case (number Mod 1000000000)
                        Case 0
                            Return getIntegerEspanhol(number \ 1000000000) + " Billones"
                        Case Is <= 100
                            Return getIntegerEspanhol(number \ 1000000000) + " Billones y " + getIntegerEspanhol(number Mod 1000000000)
                        Case Else
                            Return getIntegerEspanhol(number \ 1000000000) + " Billones, " + getIntegerEspanhol(number Mod 1000000000)
                    End Select
            End Select
        Catch ex As Exception
            Return ""
        End Try
    End Function

    Public Function dataAccess(ByVal data As Date) As String
        Return "#" & Format(data, "yyyy-MM-dd") & "#"
    End Function

    Public Function dataHoraAccess(ByVal data As Date) As String
        Return "#" & Format(data, "yyyy-MM-dd HH:mm:ss") & "#"
    End Function

    Public Function getIntegerIngles(ByVal number As Decimal) As String
        Try
            number = Int(number)
            Select Case number
                Case Is < 0
                    Return "-" & getDecimalIngles(-number)
                Case 0
                    Return ""
                Case 1 To 19
                    Dim strArray() As String =
                        {"One", "Two", "Three", "Four", "Five", "Six",
                          "Seven", "Eight", "Nine", " Ten", " Once",
                          "Twelve", "Thirteen", "Fourteen", "Fifteen",
                          "Sixteen", "Seventeen", "Eighteen", "'Nineteen"}
                    Return strArray(number - 1)
                Case 20 To 99
                    Dim strArray() As String =
                        {"Twenty", "Thirty", "Forty", "Fifty",
                          "Sixty", "Seventy", "Eight", "Ninety"}
                    If (number Mod 10) = 0 Then
                        Return strArray(number \ 10 - 2)
                    Else
                        Return strArray(number \ 10 - 2) + " " + getIntegerIngles(number Mod 10)
                    End If
                Case 100
                    Return "Hundred"
                Case 101 To 999
                    Dim strArray() As String =
                          {"One hundred", "two hundred", "Three hundred", "Four hundred", "Five hundred",
                             "Six hundred", "Seven hundred", "Eight hundred", "Nine hundred"}
                    If (number Mod 100) = 0 Then
                        Return strArray(number \ 100 - 1)
                    Else
                        Return strArray(number \ 100 - 1) + " and " + getIntegerIngles(number Mod 100)
                    End If
                Case 1000 To 1999
                    Select Case (number Mod 1000)
                        Case 0
                            Return "One thousand"
                        Case Is <= 100
                            Return " One thousand and " + getIntegerIngles(number Mod 1000)
                        Case Else
                            Return " Thousand, " + getIntegerIngles(number Mod 1000)
                    End Select
                Case 2000 To 999999
                    Select Case (number Mod 1000)
                        Case 0
                            Return getIntegerIngles(number \ 1000) & "Thousand"
                        Case Is <= 100
                            Return getIntegerIngles(number \ 1000) & " Thousand and " & getIntegerIngles(number Mod 1000)
                        Case Else
                            Return getIntegerIngles(number \ 1000) & " Thousand, " & getIntegerIngles(number Mod 1000)
                    End Select
                Case 1000000 To 1999999
                    Select Case (number Mod 1000000)
                        Case 0
                            Return "One Million"
                        Case Is <= 100
                            Return getIntegerIngles(number \ 1000000) + " Million and " & getIntegerIngles(number Mod 1000000)
                        Case Else
                            Return getIntegerIngles(number \ 1000000) + " Million, " & getIntegerIngles(number Mod 1000000)
                    End Select
                Case 2000000 To 999999999
                    Select Case (number Mod 1000000)
                        Case 0
                            Return getIntegerIngles(number \ 1000000) + " Million"
                        Case Is <= 100
                            Return getIntegerIngles(number \ 1000000) + " Million and " & getIntegerIngles(number Mod 1000000)
                        Case Else
                            Return getIntegerIngles(number \ 1000000) + " Million, " & getIntegerIngles(number Mod 1000000)
                    End Select
                Case 1000000000 To 1999999999
                    Select Case (number Mod 1000000000)
                        Case 0
                            Return "One Billion"
                        Case Is <= 100
                            Return getIntegerIngles(number \ 1000000000) + " Billion and " + getIntegerIngles(number Mod 1000000000)
                        Case Else
                            Return getIntegerIngles(number \ 1000000000) + " Billion, " + getIntegerIngles(number Mod 1000000000)
                    End Select
                Case Else
                    Select Case (number Mod 1000000000)
                        Case 0
                            Return getIntegerIngles(number \ 1000000000) + " Billion"
                        Case Is <= 100
                            Return getIntegerIngles(number \ 1000000000) + " Billion and " + getIntegerIngles(number Mod 1000000000)
                        Case Else
                            Return getIntegerIngles(number \ 1000000000) + " Billion, " + getIntegerIngles(number Mod 1000000000)
                    End Select
            End Select
        Catch ex As Exception
            Return ""
        End Try
    End Function

    Function VerificaDiaUtil(ByVal data As Date) As Boolean

        If data.DayOfWeek = DayOfWeek.Sunday Or data.DayOfWeek = DayOfWeek.Saturday Then
            Return False
        End If
        Return True

    End Function

    Function ContaDiasUteis(ByVal dataInicial As Date, ByVal dataFinal As Date) As Integer
        Dim dataConta As Date = dataInicial
        Dim contaDias As Integer = 0
        If dataConta <= dataFinal Then
            While dataConta <= dataFinal
                If VerificaDiaUtil(dataConta) Then
                    contaDias += 1
                End If
                dataConta = DateAdd(DateInterval.Day, 1, dataConta)
            End While
        Else
            While dataFinal <= dataConta
                If VerificaDiaUtil(dataConta) Then
                    contaDias += 1
                End If
                dataFinal = DateAdd(DateInterval.Day, 1, dataFinal)
            End While
            contaDias = -contaDias + 1
        End If
        Return contaDias
    End Function

    Function OnlyTextNewPage() As String
        Dim strPag As String = ""
        For cont As Integer = 1 To 69

            strPag &= Strings.Right(cont + 10000, 3) & ":" & vbCrLf
        Next
        Return strPag & Chr(12)
    End Function

    Function OnlyTextSetText(ByVal Pag As String, ByVal column As Integer, ByVal row As Integer, ByVal Text As String)
        If Not (Pag Like "*" & vbCrLf & "*") Then
            Return ""
            Exit Function
        End If
        Dim linhaAnt As String = Split(Pag, vbCrLf)(row - 1)
        Dim linha As String = Split(Pag, vbCrLf)(row - 1)
        'verifica se o texto da linha È menor que o tamanho da coluna
        'a ser adicionada valor
        If linha.Length - 4 < (column) Then
            Dim inserir As Integer = column - (linha.Length - 4)
            'insere espacos atÈ chegar na coluna a adicionar
            For cont As Integer = 1 To inserir
                linha &= " "
            Next
        Else

        End If
        linha &= Text
        Pag = Pag.Replace(linhaAnt, linha)
        Return Pag

    End Function

    Public Function RetornaGrupoUsuario(ByVal conexao As MvtConnection.MvtConnection, Optional ByVal strUsuario As String = "") As String
        ''
        ''deve ser usada a var conexaoPadrao
        ''
        If conexaoPadrao Is Nothing Then
            conexaoPadrao = CriarConexao(strConnDBDEFAULT)
        End If
        If strUsuario = "" Then
            strUsuario = strUsuarioLogado
        End If
        Dim grupo As String = ""
        Dim strSQL2 As String = "SELECT Grupo.codGrupo, Grupo.nomeGrupo FROM Mvt_Acesso.Usuario Usuario, Mvt_Acesso.Grupo Grupo WHERE usuario = '" & strUsuario & "' AND Grupo.codGrupo = Usuario.codGrupo"
        Using dr As System.Data.IDataReader = conexaoPadrao.ReturnDataReader(strSQL2)
            While dr.Read
                grupo = "" & dr(1).ToString.ToUpper
            End While
            dr.Close()
        End Using
        Return grupo
    End Function

    Public Function RetornaCodigosGruposUsuario(conexao As MvtConnection.MvtConnection, Optional strUsuario As String = "") As List(Of Integer)
        If strUsuario = "" Then
            strUsuario = strUsuarioLogado
        End If
        Dim retorno As New List(Of Integer)
        retorno.Add(mCInt(RetornaCodigoGrupoUsuario(conexao, strUsuario)))
        strSQL = "SELECT codGrupo" & Chr(13) & Chr(10)
        strSQL = strSQL & "FROM Mvt_Acesso.GrupoMembro" & Chr(13) & Chr(10)
        strSQL = strSQL & "WHERE usuario=" & ValueSQLString(strUsuario) & Chr(13) & Chr(10)
        Using dr As IDataReader = conexao.ReturnDataReader(strSQL)
            While dr.Read
                retorno.Add(mCInt(dr("codGrupo")))
            End While
        End Using
        Return retorno
    End Function

    Public Function RetornaCodigoGrupoUsuario(ByVal conexao As MvtConnection.MvtConnection, Optional ByVal strUsuario As String = "") As String
        ''
        ''deve ser usada a var conexaoPadrao
        ''
        If conexaoPadrao Is Nothing Then
            conexaoPadrao = CriarConexao(strConnDBDEFAULT)
        End If
        If strUsuario = "" Then
            strUsuario = strUsuarioLogado
        End If
        Dim grupo As String = ""
        Dim strSQL2 As String = "SELECT Grupo.codGrupo, Grupo.nomeGrupo FROM Mvt_Acesso.Usuario Usuario, Mvt_Acesso.Grupo Grupo WHERE usuario = '" & strUsuario & "' AND Grupo.codGrupo = Usuario.codGrupo"
        Using dr As System.Data.IDataReader = conexaoPadrao.ReturnDataReader(strSQL2)
            While dr.Read
                grupo = "" & dr(0).ToString.ToUpper
            End While
            dr.Close()
        End Using
        Return grupo
    End Function

    Function fEnviaEmailMenfund(ByVal msgE As String, ByVal paraE As String, ByVal deE As String, ByVal assuntoE As String, ByVal smtpServerE As String, ByVal autenticaSimE As Boolean, ByVal autenticaE As Boolean, ByVal autenticaUserE As String, ByVal autenticaSenhaE As String, ByVal formatoHTML As Boolean, ByVal nomeServidor As String, Optional copiaE As String = "", Optional ByVal showErrorMessage As Boolean = True, Optional ByVal anexos As List(Of String) = Nothing) As Boolean
        Dim objEmail As New System.Net.Mail.MailMessage
        Dim cont, ultimo As Integer

        Dim emailInvalidos As String = ""
        ultimo = 0
        If paraE.ToString.Trim = "" Or deE.ToString.Trim = "" Then
            Return False
        End If
        If ChecaEmailValido(deE.ToString) = False Then
            If showErrorMessage Then
                mMensagemErro("O e-mail de envio È inv·lido!")
            End If
            Return False
        End If
        If fDireita(paraE, 1) <> ";" Then
            paraE = paraE & ";"
        End If
        paraE = Replace(paraE, " ", "")
        For cont = 1 To paraE.ToString.Length
            If fDireita(fEsquerda(paraE.ToString, cont), 1) = ";" Then
                If ChecaEmailValido(Replace(fDireita(fEsquerda(paraE.ToString, cont), cont - ultimo), ";", "")) = True Then
                    objEmail.To.Add(Replace(fDireita(fEsquerda(paraE.ToString, cont), cont - ultimo), ";", ""))
                Else
                    If emailInvalidos <> "" Then
                        emailInvalidos &= "; "
                    End If
                    emailInvalidos &= Replace(fDireita(fEsquerda(paraE.ToString, cont), cont - ultimo), ";", "")
                End If
                ultimo = cont
            End If
        Next
        If Not String.IsNullOrEmpty((copiaE & "").ToString) Then
            ultimo = 0
            If fDireita(copiaE, 1) <> ";" Then
                copiaE = copiaE & ";"
            End If
            copiaE = Replace(copiaE, " ", "")
            For cont = 1 To copiaE.ToString.Length
                If fDireita(fEsquerda(copiaE.ToString, cont), 1) = ";" Then
                    If ChecaEmailValido(Replace(fDireita(fEsquerda(copiaE.ToString, cont), cont - ultimo), ";", "")) = True Then
                        objEmail.CC.Add(Replace(fDireita(fEsquerda(copiaE.ToString, cont), cont - ultimo), ";", ""))
                    Else
                        If emailInvalidos <> "" Then
                            emailInvalidos &= "; "
                        End If
                        emailInvalidos &= Replace(fDireita(fEsquerda(copiaE.ToString, cont), cont - ultimo), ";", "")
                    End If
                    ultimo = cont
                End If
            Next
        End If
        If objEmail.To.Count = 0 Then
            If showErrorMessage Then
                MsgBox("Nenhum email v·lido selecionado!", MsgBoxStyle.ApplicationModal, MvtConnection.MvtConnection.MessageTitle)
            End If
            Return False
        End If
        If emailInvalidos.Trim() <> "" Then
            If showErrorMessage Then
                mMensagemAlerta("Foram encontrados os seguintes e-mails inv·lidos na lista: " & vbCrLf & emailInvalidos)
            End If
        End If
        Dim enviadoPor As New System.Net.Mail.MailAddress(deE)
        objEmail.From = enviadoPor
        objEmail.Subject = assuntoE
        objEmail.Body = msgE
        objEmail.Priority = System.Net.Mail.MailPriority.High
        'objEmail.DeliveryNotificationOptions = System.Net.Mail.DeliveryNotificationOptions.OnSuccess
        If anexos IsNot Nothing Then
            For contArr As Integer = 0 To anexos.Count - 1
                If File.Exists(anexos(contArr)) Then
                    objEmail.Attachments.Add(New System.Net.Mail.Attachment(anexos(contArr)))
                End If
            Next
        End If
        Dim servidor As New System.Net.Mail.SmtpClient
        servidor.UseDefaultCredentials = False
        servidor.Credentials = New System.Net.NetworkCredential(CStr("" & autenticaUserE), CStr("" & autenticaSenhaE))

        objEmail.IsBodyHtml = True
        servidor.Host = UCase(Piece(nomeServidor, ":", 1))
        servidor.Port = 587
        servidor.EnableSsl = UCase(Piece(nomeServidor, ":", 3)) = "SSL"

        Try
            servidor.Send(objEmail)
        Catch ex As Exception
            servidor.Port = 25
            Try
                servidor.Send(objEmail)
            Catch ex1 As Exception
                If showErrorMessage Then
                    mMensagemErro("Erro ao enviar email!" & vbCrLf & vbCrLf & "Retorno do servidor: " & ex1.Message)
                End If
                Return False
            End Try
        End Try
        Return True
        'MsgBox("Mensagem enviada com sucesso!", MsgBoxStyle.Exclamation)
    End Function

    Function VerificaDiaUtilFeriados(ByVal data As Date,
                                     ByVal conexao As MvtConnection.MvtConnection,
                                     Optional ByVal verificaFeriado As Boolean = False,
                                     Optional empresa As Integer = Nothing,
                                     Optional listaFeriados As List(Of Date) = Nothing,
                                     Optional listaDiasUteis As List(Of Date) = Nothing) As Boolean
        ''
        ''deve ser usada a var conexaoPadrao
        ''
        If conexaoPadrao Is Nothing Then
            conexaoPadrao = CriarConexao(strConnDBDEFAULT)
        End If
        If listaDiasUteis IsNot Nothing AndAlso listaDiasUteis.Contains(data) Then
            Return True
        End If
        If data.DayOfWeek = DayOfWeek.Sunday Or data.DayOfWeek = DayOfWeek.Saturday Then
            Return False
        End If
        If verificaFeriado Then
            If listaFeriados IsNot Nothing Then
                Return Not listaFeriados.Contains(data)
            End If
            Try
                strSQL = "SELECT feriado FROM Mvt_Menu.Feriado WHERE feriado = " & DataCache(data)
                If empresa > 0 Then
                    strSQL &= " AND codEmpresa=" & codEmpresa
                End If
                Using dr As IDataReader = conexaoPadrao.ReturnDataReader(strSQL)
                    While dr.Read
                        dr.Close()
                        Return False
                    End While
                    dr.Close()
                End Using
            Catch ex As Exception
                strSQL = "SELECT feriado FROM Mvt_Menu.Feriados WHERE feriado = " & DataCache(data)
                If empresa <> Nothing Then
                    strSQL &= " AND codEmpresa=" & empresa
                End If
                Using dr As IDataReader = conexaoPadrao.ReturnDataReader(strSQL)
                    If dr.Read Then
                        dr.Close()
                        Return False
                    End If
                    dr.Close()
                End Using
            End Try

        End If
        Return True
    End Function

    Public Function AdicionaDiasUteis(data As Date, dias As Integer, Optional anosAdiante As Integer = 1) As Date
        Dim feriados As Dictionary(Of Date, String) = ObterFeriados(data.AddMonths(-1), data.AddYears(anosAdiante))
        Dim count As Integer = 1
        While count <= dias

            While feriados.ContainsKey(data.AddDays(1)) OrElse
                            (data.AddDays(1).DayOfWeek = DayOfWeek.Saturday OrElse
                             data.AddDays(1).DayOfWeek = DayOfWeek.Sunday)

                data = data.AddDays(1)
            End While

            data = data.AddDays(1)
            count += 1
        End While

        Return data
    End Function

    Sub OnlyTextPrint(ByVal pag As String, ByVal PortName As String)
        Dim strPag As String = pag
        For cont As Integer = 1 To 100
            strPag = strPag.Replace(Strings.Right(10000 + cont, 3) & ":", "")
        Next
        Dim tempFile As String = System.IO.Path.GetTempPath() & Replace("file" & Now.ToString.Replace(":", "").Replace("/", ""), " ", "")
        Try
            System.IO.File.WriteAllText(tempFile, strPag)
            System.IO.File.WriteAllText(tempFile & ".txt", strPag)
        Catch ex As Exception

        End Try
        Try
            If mMensagemConfirma("Imprimir em impressora matricial?") = vbNo Then

                Dim processo As System.Diagnostics.Process = New Process()
                processo.StartInfo.FileName = tempFile & ".txt"
                processo.StartInfo.WindowStyle = ProcessWindowStyle.Maximized
                processo.StartInfo.UseShellExecute = True
                processo.Start()

            End If
        Catch ex As Exception

        End Try

        Try
            System.IO.File.Copy(tempFile, PortName)
        Catch ex As Exception

        End Try

    End Sub

    Public Function RetornaCodigoGrupoUsuarioLogado() As String
        ''
        ''esta funcao deve ser usada passando a var conexaoPadrao!!!
        ''
        If conexaoPadrao Is Nothing Then
            conexaoPadrao = CriarConexao(strConnDBDEFAULT)
        End If
        Dim grupo As String = ""
        Dim strSQL2 As String = "select Grupo.codGrupo, Grupo.nomeGrupo from Mvt_Acesso.Usuario Usuario, Mvt_Acesso.Grupo Grupo WHERE usuario = '" & strUsuarioLogado & "' AND Grupo.codGrupo = Usuario.codGrupo"
        Using dr As System.Data.IDataReader = conexaoPadrao.ReturnDataReader(strSQL2)
            While dr.Read
                grupo = "" & dr(0).ToString.ToUpper
            End While
            dr.Close()
        End Using
        Return grupo
    End Function

    Public Function RetornaCodigoGrupoUsuarioLogadoCACHE() As String
        ''
        ''esta funcao deve ser usada passando a var conexaoPadrao!!!
        ''
        If conexaoPadrao Is Nothing Then
            conexaoPadrao = CriarConexao(strConnDBDEFAULT)
        End If
        Dim grupo As String = ""
        Dim strSQL2 As String = "select Grupo.codGrupo, Grupo.nomeGrupo from Mvt_Acesso.Usuario Usuario, Mvt_Acesso.Grupo Grupo WHERE usuario = '" & strUsuarioLogado & "' AND Grupo.codGrupo = Usuario.codGrupo"
        Using dr As System.Data.IDataReader = conexaoPadrao.ReturnDataReader(strSQL2)
            While dr.Read
                grupo = "" & dr(0).ToString.ToUpper
            End While
            dr.Close()
        End Using
        Return grupo
    End Function

    Function RetornaEmailGrupo(ByVal grupo As String)
        ''
        ''esta funcao deve ser usada passando a var conexaoPadrao!!!
        ''
        If conexaoPadrao Is Nothing Then
            conexaoPadrao = CriarConexao(strConnDBDEFAULT)
        End If

        Dim strSQL2 As String
        strSQL2 = "SELECT codGrupo" & Chr(13) & Chr(10)
        If conexaoPadrao.ActiveConnection = MvtConnection.DataBase.CACHECLIENT Or conexaoPadrao.ActiveConnection = MvtConnection.DataBase.CACHE Then
            strSQL2 = strSQL2 & "FROM Mvt_Acesso.Grupo" & Chr(13) & Chr(10)
        Else
            strSQL2 = strSQL2 & "FROM MvtAcessoGrupo" & Chr(13) & Chr(10)
        End If

        strSQL2 = strSQL2 & "WHERE UPPER(nomeGrupo) = '" & grupo.ToUpper & "'" & Chr(13) & Chr(10)

        Dim email As String = ""

        Using dr As IDataReader = conexaoPadrao.ReturnDataReader(strSQL2)
            While dr.Read
                strSQL2 = "SELECT email FROM Mvt_Acesso.Usuario WHERE codGrupo = " & "" & dr("codGrupo") & " AND situacao = 'ATIVO'"
                Using dr2 As IDataReader = conexaoPadrao.ReturnDataReader(strSQL2)
                    While dr2.Read
                        If email <> "" Then
                            email &= ";"
                        End If
                        email &= "" & dr2("email")
                    End While
                    dr2.Close()
                End Using
                Return email
            End While
            dr.Close()
        End Using
        Return Nothing
    End Function

    Function ContaDiasUteisFeriado(ByVal dataInicial As Date,
                                   ByVal dataFinal As Date,
                                   Optional listaFeriados As List(Of Date) = Nothing,
                                   Optional listaDiasUteis As List(Of Date) = Nothing,
                                   Optional oracle As Boolean = False) As Integer

        If listaFeriados Is Nothing Then
            Dim strSQL As String = "SELECT feriado" & Chr(13) & Chr(10)
            strSQL = strSQL & "FROM Mvt_Menu.Feriados" & Chr(13) & Chr(10)
            If oracle Then
                strSQL = strSQL & "WHERE feriado>=" & ValueSQLDataOracle(dataInicial) & Chr(13) & Chr(10)
                strSQL = strSQL & "AND feriado<=" & ValueSQLDataOracle(dataFinal) & Chr(13) & Chr(10)
            Else
                strSQL = strSQL & "WHERE feriado>=" & ValueSQLDataCache(dataInicial) & Chr(13) & Chr(10)
                strSQL = strSQL & "AND feriado<=" & ValueSQLDataCache(dataFinal) & Chr(13) & Chr(10)
            End If

            Using dr As IDataReader = conexaoPadrao.ReturnDataReader(strSQL)
                listaFeriados = New List(Of Date)
                While dr.Read
                    listaFeriados.Add(mCDate(dr("feriado")))
                End While
            End Using
        End If
        If listaDiasUteis Is Nothing Then
            Dim strSQL As String = "SELECT diaUtil" & Chr(13) & Chr(10)
            strSQL = strSQL & "FROM Mvt_Menu.DiasUteis" & Chr(13) & Chr(10)
            strSQL = strSQL & "WHERE diaUtil>=" & ValueSQLDataCache(dataInicial) & Chr(13) & Chr(10)
            strSQL = strSQL & "AND diaUtil<=" & ValueSQLDataCache(dataFinal) & Chr(13) & Chr(10)
            Try
                Using dr As IDataReader = conexaoPadrao.ReturnDataReader(strSQL)
                    listaDiasUteis = New List(Of Date)
                    While dr.Read
                        listaDiasUteis.Add(mCDate(dr("diaUtil")))
                    End While
                End Using
            Catch ex As Exception
                Trace.WriteLine(ex)
            End Try
        End If

        Dim dataConta As Date = dataInicial
        Dim contaDias As Integer = 0
        While dataConta <= dataFinal
            If VerificaDiaUtilFeriados(dataConta, conexaoPadrao, True, , listaFeriados, listaDiasUteis) Then
                contaDias += 1
            End If
            dataConta = DateAdd(DateInterval.Day, 1, dataConta)
        End While
        Return contaDias
    End Function

    Public Function RetornaEmailUsuario(ByVal conexao As MvtConnection.MvtConnection, Optional ByVal usuario As String = Nothing) As String
        ''
        ''deve ser usada a var conexaoPadrao
        ''
        If conexaoPadrao Is Nothing Then
            conexaoPadrao = CriarConexao(strConnDBDEFAULT)
        End If
        If usuario = Nothing Then
            usuario = strUsuarioLogado
        End If
        Dim email As String = ""
        strSQL = "SELECT email from Mvt_Acesso.Usuario WHERE usuario = '" & usuario & "'"
        Using dr As System.Data.IDataReader = conexaoPadrao.ReturnDataReader(strSQL)
            While dr.Read
                email = "" & dr(0)
            End While
            dr.Close()
        End Using
        Return email
    End Function

    Public Function RetornaEmailUsuario(Optional ByVal usuario As String = Nothing) As String
        If usuario = Nothing Then
            usuario = strUsuarioLogado
        End If
        ''
        ''esta funcao deve ser usada passando a var conexaoPadrao!!!
        ''
        If conexaoPadrao Is Nothing Then
            conexaoPadrao = CriarConexao(strConnDBDEFAULT)
        End If

        strSQL = "SELECT email from Mvt_Acesso.Usuario WHERE usuario = '" & usuario & "'"
        Dim email As String = ""
        Using dr As System.Data.IDataReader = conexaoPadrao.ReturnDataReader(strSQL)
            While dr.Read
                email = "" & dr(0)
            End While
            dr.Close()
        End Using
        Return email
    End Function

    Function RetornaTipoUsuario(ByVal conexao As MvtConnection.MvtConnection, ByVal usuario As String)
        Dim retorno As String = Nothing
        ''
        ''deve ser usada a var conexaoPadrao
        ''
        If conexaoPadrao Is Nothing Then
            conexaoPadrao = CriarConexao(strConnDBDEFAULT)
        End If
        strSQL = "SELECT tipo" & Chr(13) & Chr(10)
        strSQL = strSQL & "FROM Mvt_Acesso.Usuario" & Chr(13) & Chr(10)
        strSQL = strSQL & "WHERE usuario='" & usuario & "'" & Chr(13) & Chr(10)
        Using dr As IDataReader = conexaoPadrao.ReturnDataReader(strSQL)
            If dr.Read Then retorno = dr("tipo") & ""
        End Using
        Return retorno
    End Function

    Function DataNormalParaDataCache(ByVal dataNormal As Date) As Integer

        Return DateDiff(DateInterval.Day, CDate("01/01/1900"), dataNormal) + 21550

    End Function

    Public Function RetornaImpressoraPDF()
        Dim aNomeImpressora As String = ""
        Dim selecionada As String = ""
        For Each aNomeImpressora In System.Drawing.Printing.PrinterSettings.InstalledPrinters
            If Strings.Left(aNomeImpressora, 3) = "PDF" Then
                selecionada = aNomeImpressora
                Exit For
            End If
            If aNomeImpressora Like "* PDF *" Then
                selecionada = aNomeImpressora
                Exit For
            End If
            If Strings.Left(aNomeImpressora, 25) = "Microsoft Office Document" Then
                selecionada = aNomeImpressora
            End If
        Next
        Return selecionada
    End Function

    Public Function horaMySql(ByVal hora As String)
        If hora <> "" Then
            If hora.Length > 6 Then
                Return "'00:00:00'"
            Else
                Return "'" & FormatDateTime(hora, DateFormat.LongTime) & "'"
            End If
        End If
        Return "'00:00:00'"
    End Function

    Public Function retornaImpressora(ByVal paraImprimir As String, ByVal conexao As MvtConnection.MvtConnection) As String
        ''
        ''deve ser usada a var conexaoPadrao
        ''
        If conexaoPadrao Is Nothing Then
            conexaoPadrao = CriarConexao(strConnDBDEFAULT)
        End If

        strSQL = "SELECT impressoraPadrao" & Chr(13) & Chr(10)
        strSQL = strSQL & "FROM MvtConfiguracaoImpressora" & Chr(13) & Chr(10)
        strSQL = strSQL & "WHERE codEmpresa=" & codEmpresa & Chr(13) & Chr(10)
        strSQL = strSQL & "    AND paraImprimir='" & paraImprimir & "'" & Chr(13) & Chr(10)
        strSQL = strSQL & "    AND usuario='" & strUsuarioLogado & "'" & Chr(13) & Chr(10)
        Using dr As IDataReader = conexaoPadrao.ReturnDataReader(strSQL)

            While dr.Read
                Return "" & dr("impressoraPadrao").ToString
            End While
            dr.Close()
        End Using

        Return ""
    End Function

    Function getStartOfWeek(ByVal data As Date)
        Dim dataReturn As Date = data

        While Weekday(dataReturn) > 1
            dataReturn = DateAdd(DateInterval.Day, -1, dataReturn)
        End While

        Return dataReturn
    End Function

    Function getEndOfWeek(ByVal data As Date)
        Dim dataReturn As Date = data

        While Weekday(dataReturn) < 7
            dataReturn = DateAdd(DateInterval.Day, 1, dataReturn)
        End While

        Return dataReturn
    End Function

    Function getStartOfWeek(ByVal data As Date, weekStart As DayOfWeek)
        Dim dataReturn As Date = data

        While dataReturn.DayOfWeek <> weekStart
            dataReturn = DateAdd(DateInterval.Day, -1, dataReturn)
        End While

        Return dataReturn
    End Function

    Function getEndOfWeek(ByVal data As Date, weekEnd As DayOfWeek)
        Dim dataReturn As Date = data

        While dataReturn.DayOfWeek <> weekEnd
            dataReturn = DateAdd(DateInterval.Day, 1, dataReturn)
        End While

        Return dataReturn
    End Function

    Function CountString(ByVal strTexto As String, ByVal caracter As String) As Integer
        Dim total As Integer = 0
        For cont As Integer = 1 To strTexto.Length
            If fDireita(fEsquerda(strTexto, cont), 1) = caracter Then
                total += 1
            End If
        Next
        Return total
    End Function

    Function GetCorIndiceMR(ByVal codEmpresa As Integer) As ArrayList
        strSQL = "SELECT codEmpresa, otimo,bom, regular, ruim" & Chr(13) & Chr(10)
        strSQL = strSQL & "FROM  Mvt_Vendas.EstruturaCorPercent" & Chr(13) & Chr(10)
        strSQL = strSQL & "WHERE codEmpresa in (1, " & codEmpresa & ")" & Chr(13) & Chr(10)
        Try
            Dim arr As New ArrayList
            Using dr As IDataReader = conexaoPadrao.ReturnDataReader(strSQL)
                While dr.Read
                    arr.Add("" & dr(1))
                    arr.Add("" & dr(2))
                    arr.Add("" & dr(3))
                    arr.Add("" & dr(4))
                End While
                dr.Close()
            End Using
            If arr.Count = 0 Then
                arr.Add(100)
                arr.Add(95)
                arr.Add(90)
                arr.Add(85)
            End If
            Return arr
        Catch ex As Exception
            Trace.WriteLine(ex)
            Return Nothing
        End Try
    End Function

    Function ConverteMinutosDecimaisParaHoras(ByVal parametroMinutos As Double, Optional ByVal mostraSegundos As Boolean = True) As String
        Dim dataHoraRetorna As String = ""
        Dim negativo As Boolean = False
        If parametroMinutos < 0 Then
            parametroMinutos = -1 * parametroMinutos
            negativo = True
        End If

        Dim horas As Double = Int(parametroMinutos / 60)
        Dim minutos As Double = Int(parametroMinutos - (horas * 60))
        Dim segundos As Double = (parametroMinutos - Int(parametroMinutos)) * 60

        If mostraSegundos Then
            dataHoraRetorna = Format(horas, "#,#00") & ":" & Format(minutos, "#,#00") & ":" & Format(System.Math.Round(segundos, 0), "#,#00")
        Else
            dataHoraRetorna = Format(horas, "#,#00") & ":" & Format(minutos, "#,#00")
        End If
        If negativo Then
            dataHoraRetorna = "-" & dataHoraRetorna
        End If
        Return dataHoraRetorna
    End Function

    Function FiltraCheckBox(ByVal chkCheckBox As CheckedListBox, Optional ByVal intPiece As Integer = 0, Optional ByVal separador As String = ",") As String
        Dim filtroCheck As String = ""
        For contaItem As Integer = 0 To chkCheckBox.CheckedItems.Count - 1
            If filtroCheck <> "" Then
                filtroCheck &= ","
            End If
            If intPiece > 0 Then
                If IsNumeric(Piece(chkCheckBox.CheckedItems(contaItem), separador, intPiece)) Then
                    filtroCheck &= "'" & ValueSQLNumber(mCDec(Piece(chkCheckBox.CheckedItems(contaItem), separador, intPiece))) & "'"
                Else
                    filtroCheck &= "'" & Piece(chkCheckBox.CheckedItems(contaItem), separador, intPiece) & "'"
                End If
            Else
                filtroCheck &= "'" & chkCheckBox.CheckedItems(contaItem) & "'"
            End If
        Next
        If filtroCheck <> "" Then
            filtroCheck = "(" & filtroCheck & ")"
        Else
            filtroCheck = "(NULL)"
        End If
        Return filtroCheck
    End Function

    Public Function verificaPermissaoBotao(ByVal programa As String, ByVal nomeBotao As String, ByVal usr As String) As Boolean
        Dim accessoPermitido As Boolean = False
        'If usr <> "conf" Then
        strSQL = "SELECT COUNT(0)" & Chr(13) & Chr(10)
        strSQL = strSQL & "FROM Mvt_Acesso.Permissao" & Chr(13) & Chr(10)
        strSQL = strSQL & "WHERE upper(nomeBotao)='" & programa.ToUpper & "." & nomeBotao.ToUpper & "' " & Chr(13) & Chr(10)
        strSQL = strSQL & "    AND (    (tipo=1 AND +usuarioGrupo=(SELECT +codGrupo FROM Mvt_Acesso.Usuario WHERE usuario='" & usr & "'))" & Chr(13) & Chr(10)
        strSQL = strSQL & "          OR (tipo=2 AND usuarioGrupo='" & usr & "') )" & Chr(13) & Chr(10)
        Try
            Dim ret As Integer = 0
            Using dr As IDataReader = conexaoPadrao.ReturnDataReader(strSQL)
                While dr.Read
                    ret = mCDec(dr(0))
                End While
                dr.Close()
            End Using
            If ret > 0 Then
                accessoPermitido = True
            Else
                accessoPermitido = False
            End If
        Catch ex As Exception
            accessoPermitido = False
        End Try
        'endif
        Return accessoPermitido
    End Function

    Public Function NumeroToExtensoRealPortugues(ByVal number As Decimal) As String
        Dim numeroRetorno As String = ""

        Dim cent As Integer
        Try
            ' se for =0 retorna 0 reais
            If number = 0 Then
                Return "Zero Reais"
            End If
            ' Verifica a parte decimal, ou seja, os centavos
            cent = Decimal.Round((number - Int(number)) * 100, MidpointRounding.ToEven)
            ' Verifica apenas a parte inteira
            number = Int(number)
            ' Caso existam centavos
            If cent > 0 Then
                ' Caso seja 1 n„o coloca "Reais" mas sim "Real"
                If number = 1 Then
                    Return "Um Real e " + getDecimalPortugues(cent) + " centavos"
                    ' Caso o valor seja inferior a 1 Real
                ElseIf number = 0 Then
                    Return getDecimalPortugues(cent) + " centavos"
                Else
                    Return getIntegerPortugues(number) + " Reais e " + getDecimalPortugues(cent) + " centavos"
                End If
            Else
                ' Caso seja 1 n„o coloca "Reais" mas sim "Real"
                If number = 1 Then
                    Return "Um Real".ToLower
                Else
                    Return getIntegerPortugues(number) + " Reais"
                End If
            End If
        Catch ex As Exception
            Return ""
        End Try
    End Function

    ''' <summary>
    ''' FunÁ„o auxiliar - Parte decimal a converter
    ''' </summary>
    ''' <param name="number">Parte decimal a converter</param>
    Public Function getDecimalPortugues(ByVal number As Byte) As String
        Try
            Select Case number
                Case 0
                    Return ""
                Case 1 To 19
                    Dim strArray() As String =
                       {"Um", "Dois", "Tres", "Quatro", "Cinco", "Seis",
                        "Sete", "Oito", "Nove", "Dez", "Onze",
                        "Doze", "Treze", "Quatorze", "Quinze",
                        "Dezesseis", "Dezessete", "Dezoito", "Dezenove"}
                    Return strArray(number - 1)
                Case 20 To 99
                    Dim strArray() As String =
                        {"Vinte", "Trinta", "Quarenta", "Cinquenta",
                        "Sessenta", "Setenta", "Oitenta", "Noventa"}
                    If (number Mod 10) = 0 Then
                        Return strArray(number \ 10 - 2)
                    Else
                        Return strArray(number \ 10 - 2) + " e " + getDecimalPortugues(number Mod 10)
                    End If
                Case Else
                    Return ""
            End Select
        Catch ex As Exception
            Return ""
        End Try
    End Function

    ''' <summary>
    ''' FunÁ„o auxiliar - Parte inteira a converter
    ''' </summary>
    ''' <param name="number">Parte inteira a converter</param>
    Public Function getIntegerPortugues(ByVal number As Decimal) As String
        Try
            number = Int(number)
            Select Case number
                Case Is < 0
                    Return "-" & getIntegerPortugues(-number)
                Case 0
                    Return ""
                Case 1 To 19
                    Dim strArray() As String =
                        {"Um", "Dois", "Tres", "Quatro", "Cinco", "Seis",
                        "Sete", "Oito", "Nove", "Dez", "Onze", "Doze",
                        "Treze", "Quatorze", "Quinze", "Dezesseis",
                        "Dezessete", "Dezoito", "Dezenove"}
                    Return strArray(number - 1)
                Case 20 To 99
                    Dim strArray() As String =
                        {"Vinte", "Trinta", "Quarenta", "Cinquenta",
                        "Sessenta", "Setenta", "Oitenta", "Noventa"}
                    If (number Mod 10) = 0 Then
                        Return strArray(number \ 10 - 2)
                    Else
                        Return strArray(number \ 10 - 2) + " e " + getIntegerPortugues(number Mod 10)
                    End If
                Case 100
                    Return "Cem"
                Case 101 To 999
                    Dim strArray() As String =
                           {"Cento", "Duzentos", "Trezentos", "Quatrocentos", "Quinhentos",
                           "Seiscentos", "Setecentos", "Oitocentos", "Novecentos"}
                    If (number Mod 100) = 0 Then
                        Return strArray(number \ 100 - 1)
                    Else
                        Return strArray(number \ 100 - 1) + " e " + getIntegerPortugues(number Mod 100)
                    End If
                Case 1000 To 1999
                    Select Case (number Mod 1000)
                        Case 0
                            Return "Mil"
                        Case Is <= 100
                            Return " Mil e " + getIntegerPortugues(number Mod 1000)
                        Case Else
                            Return " Mil, " + getIntegerPortugues(number Mod 1000)
                    End Select
                Case 2000 To 999999
                    Select Case (number Mod 1000)
                        Case 0
                            Return getIntegerPortugues(number \ 1000) & "Mil"
                        Case Is <= 100
                            Return getIntegerPortugues(number \ 1000) & " Mil e " & getIntegerPortugues(number Mod 1000)
                        Case Else
                            Return getIntegerPortugues(number \ 1000) & " Mil, " & getIntegerPortugues(number Mod 1000)
                    End Select
                Case 1000000 To 1999999
                    Select Case (number Mod 1000000)
                        Case 0
                            Return "Um Milhao"
                        Case Is <= 100
                            Return getIntegerPortugues(number \ 1000000) + " Milhao e " & getIntegerPortugues(number Mod 1000000)
                        Case Else
                            Return getIntegerPortugues(number \ 1000000) + " Milhao, " & getIntegerPortugues(number Mod 1000000)
                    End Select
                Case 2000000 To 999999999
                    Select Case (number Mod 1000000)
                        Case 0
                            Return getIntegerPortugues(number \ 1000000) + " Milhoes"
                        Case Is <= 100
                            Return getIntegerPortugues(number \ 1000000) + " Milhoes e " & getIntegerPortugues(number Mod 1000000)
                        Case Else
                            Return getIntegerPortugues(number \ 1000000) + " Milhoes, " & getIntegerPortugues(number Mod 1000000)
                    End Select
                Case 1000000000 To 1999999999
                    Select Case (number Mod 1000000000)
                        Case 0
                            Return "Um Bilhao"
                        Case Is <= 100
                            Return getIntegerPortugues(number \ 1000000000) + "Bilhao e " + getIntegerPortugues(number Mod 1000000000)
                        Case Else
                            Return getIntegerPortugues(number \ 1000000000) + "Bilhao, " + getIntegerPortugues(number Mod 1000000000)
                    End Select
                Case Else
                    Select Case (number Mod 1000000000)
                        Case 0
                            Return getIntegerPortugues(number \ 1000000000) + " Bilhoes"
                        Case Is <= 100
                            Return getIntegerPortugues(number \ 1000000000) + "Bilhoes e " + getIntegerPortugues(number Mod 1000000000)
                        Case Else
                            Return getIntegerPortugues(number \ 1000000000) + "Bilhoes, " + getIntegerPortugues(number Mod 1000000000)
                    End Select
            End Select
        Catch ex As Exception
            Return ""
        End Try
    End Function

    '' SE FOR PASSADO O VALOR 1.3, IR¡ RETORNAR 90 SEGUNDOS.
    Public Function ConverteMinutosNaoDecimaisEmSegundos(ByVal tempo As Double)

        Dim minutosInteiros As Integer = Int(tempo)
        Dim minutosRestantes As Double = tempo - minutosInteiros

        If minutosRestantes > 6 Then
            Return 0
            Exit Function
        End If
        ''FAZ A PROPOR«√O PARA PASSAR OS MINUTOS RESTANTES PARA UM VALOR DECIMAL
        minutosRestantes = 10 * minutosRestantes / 6

        Dim segundos As Integer = (minutosInteiros * 60) + (minutosRestantes * 60)

        Return segundos
    End Function

    '' FUNCAO INVERSA
    Public Function ConverteSegundosEmMinutosNaoDecimais(ByVal tempo As Double)

        Dim segundosInteiros As Integer = Int(tempo / 60)
        Dim segundosRestantes As Double = (tempo / 60) - (segundosInteiros)

        ''FAZ A PROPOR«√O PARA PASSAR OS MINUTOS RESTANTES PARA UM VALOR DECIMAL
        segundosRestantes = 6 * segundosRestantes / 10

        Dim minutos As Double = (segundosInteiros) + (segundosRestantes)

        Return minutos
    End Function

    Function getDataGridFromDataGridTreeView(ByVal dttDados As Object, Optional ByVal alinharColunas As Boolean = False, Optional levelArrow As Boolean = True) As MvtWindowsForms.MvtDataGridView

        Dim dtgDADOSEx As New MvtWindowsForms.MvtDataGridView
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        dtgDADOSEx.AllowUserToAddRows = False
        dtgDADOSEx.AllowUserToDeleteRows = False
        dtgDADOSEx.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        dtgDADOSEx.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        dtgDADOSEx.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 8.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(5, 0, 15, 0)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        dtgDADOSEx.DefaultCellStyle = DataGridViewCellStyle2
        dtgDADOSEx.Location = New System.Drawing.Point(415, 65)
        dtgDADOSEx.Name = "dtgDADOSEx"
        dtgDADOSEx.ReadOnly = False
        dtgDADOSEx.RowHeadersWidth = 20
        dtgDADOSEx.Size = New System.Drawing.Size(333, 203)
        dtgDADOSEx.TabIndex = 9
        dtgDADOSEx.Visible = False
        GeraDTGCol(dtgDADOSEx, dttDados, levelArrow)

        If alinharColunas Then
            dtgDADOSEx.AutoResizeColumns()
            dtgDADOSEx.Columns(0).Width = dtgDADOSEx.Columns(0).Width + 40
        End If

        Return dtgDADOSEx

    End Function

    Private Sub GeraDTGCol(ByVal dtgDADOSEx As MvtWindowsForms.MvtDataGridView, ByVal dttDados As Object, Optional levelArrow As Boolean = True)
        dtgDADOSEx.Rows.Clear()
        dtgDADOSEx.Columns.Clear()
        Dim columnIndex As Integer = 0
        Dim dicClmIndex As New Dictionary(Of Integer, Integer)

        ' COPIAR COLUNAS CONFORME DISPLAYINDEX
        While columnIndex < dttDados.Columns.Count
            For index As Integer = 0 To dttDados.Columns.Count - 1
                If dttDados.Columns(index).DisplayIndex = columnIndex Then
                    dtgDADOSEx.Columns.Add(dttDados.Columns(index).Name, dttDados.Columns(index).HeaderText)
                    dtgDADOSEx.Columns(columnIndex).DefaultCellStyle.Alignment = dttDados.Columns(index).DefaultCellStyle.Alignment
                    dtgDADOSEx.Columns(columnIndex).DefaultCellStyle.Format = dttDados.Columns(index).DefaultCellStyle.Format
                    dtgDADOSEx.Columns(columnIndex).DefaultCellStyle.BackColor = dttDados.Columns(index).DefaultCellStyle.BackColor
                    dtgDADOSEx.Columns(columnIndex).DefaultCellStyle.ForeColor = dttDados.Columns(index).DefaultCellStyle.ForeColor
                    dtgDADOSEx.Columns(columnIndex).Width = dttDados.Columns(index).Width
                    dtgDADOSEx.Columns(columnIndex).Visible = dttDados.Columns(index).Visible
                    dicClmIndex.Add(columnIndex, index)
                    Exit For
                End If
            Next
            columnIndex += 1
        End While

        GeraDTG(dtgDADOSEx, dttDados, levelArrow, dicClmIndex)
    End Sub

    Private Sub GeraDTG(ByVal dtgDADOSEx As MvtWindowsForms.MvtDataGridView, ByVal dttDados As Object, Optional levelArrow As Boolean = True, Optional dicClmIndex As Dictionary(Of Integer, Integer) = Nothing)
        If dicClmIndex Is Nothing Then
            dicClmIndex = New Dictionary(Of Integer, Integer)
        End If
        For cont As Integer = 0 To dttDados.Nodes.Count - 1
            If dttDados.Nodes(cont).Visible Then

                dtgDADOSEx.Rows.Add()
                Dim columnIndex As Integer = 0

                ' COPIAR COLUNAS CONFORME DISPLAYINDEX
                While columnIndex < dttDados.Columns.Count
                    Dim index As Integer = GetDTGColumnIndexByDisplayIndex(dttDados, dicClmIndex, columnIndex)

                    If index <> -1 Then
                        If IsNumeric(dttDados.Nodes(cont).Cells.Item(index).Value) Then
                            dtgDADOSEx.Item(columnIndex, dtgDADOSEx.Rows.Count - 1).Value = mCDec(dttDados.Nodes(cont).Cells.Item(index).Value)
                        Else
                            dtgDADOSEx.Item(columnIndex, dtgDADOSEx.Rows.Count - 1).Value = dttDados.Nodes(cont).Cells.Item(index).Value
                        End If

                        dtgDADOSEx.Item(columnIndex, dtgDADOSEx.Rows.Count - 1).Style.Format = dttDados.Nodes(cont).Cells.Item(index).Style.Format
                        dtgDADOSEx.Item(columnIndex, dtgDADOSEx.Rows.Count - 1).ToolTipText = dttDados.Nodes(cont).Cells.Item(index).ToolTipText
                        dtgDADOSEx.Item(columnIndex, dtgDADOSEx.Rows.Count - 1).Style.BackColor = dttDados.Nodes(cont).Cells.Item(index).Style.BackColor
                        dtgDADOSEx.Item(columnIndex, dtgDADOSEx.Rows.Count - 1).Style.ForeColor = dttDados.Nodes(cont).Cells.Item(index).Style.ForeColor
                    End If

                    columnIndex += 1
                End While

                dtgDADOSEx.Rows(dtgDADOSEx.RowCount - 1).DefaultCellStyle.Alignment = dttDados.Nodes(cont).DefaultCellStyle.Alignment
                dtgDADOSEx.Rows(dtgDADOSEx.RowCount - 1).DefaultCellStyle.Format = dttDados.Nodes(cont).DefaultCellStyle.Format
                dtgDADOSEx.Rows(dtgDADOSEx.RowCount - 1).DefaultCellStyle.BackColor = dttDados.Nodes(cont).DefaultCellStyle.BackColor
                dtgDADOSEx.Rows(dtgDADOSEx.RowCount - 1).DefaultCellStyle.ForeColor = dttDados.Nodes(cont).DefaultCellStyle.ForeColor
                dtgDADOSEx.Rows(dtgDADOSEx.RowCount - 1).DefaultCellStyle.Font = dttDados.Nodes(cont).DefaultCellStyle.Font

                GeraDTGLevels(dttDados.Nodes(cont), dtgDADOSEx, dttDados, levelArrow, dicClmIndex)
            End If
        Next

        dtgDADOSEx.AutoResizeRows()
    End Sub

    Private Function GetDTGColumnIndexByDisplayIndex(dttDados As Object, dicClmIndex As Dictionary(Of Integer, Integer), columnIndex As Integer) As Integer
        Dim index As Integer = -1

        If dicClmIndex.ContainsKey(columnIndex) Then
            index = dicClmIndex(columnIndex)
        Else
            For indexBusca As Integer = 0 To dttDados.Columns.Count - 1
                If dttDados.Columns(indexBusca).DisplayIndex = columnIndex Then
                    index = indexBusca
                    dicClmIndex.Add(columnIndex, index)
                    Exit For
                End If
            Next
        End If

        Return index
    End Function

    Private Sub GeraDTGLevels(ByVal nod As Object, ByVal dtgDADOSEx As MvtWindowsForms.MvtDataGridView, ByVal dttDados As Object, Optional levelArrow As Boolean = True, Optional dicClmIndex As Dictionary(Of Integer, Integer) = Nothing)
        If dicClmIndex Is Nothing Then
            dicClmIndex = New Dictionary(Of Integer, Integer)
        End If
        If nod.IsExpanded Then
            For cont As Integer = 0 To nod.Nodes.Count - 1
                If nod.nodes(cont).visible Then

                    dtgDADOSEx.Rows.Add()
                    Dim columnIndex As Integer = 0

                    ' COPIAR COLUNAS CONFORME DISPLAYINDEX
                    While columnIndex < dttDados.Columns.Count
                        Dim index = GetDTGColumnIndexByDisplayIndex(dttDados, dicClmIndex, columnIndex)
                        If index <> -1 Then
                            If index = 0 Then
                                dtgDADOSEx.Item(columnIndex, dtgDADOSEx.Rows.Count - 1).Value = RSet(" ", (nod.Nodes(cont).Level - 1) * 5) & If(levelArrow, ">", "") & (nod.Nodes(cont).Cells.Item(index).Value & "").ToString
                            Else
                                If IsNumeric(nod.Nodes(cont).Cells.Item(index).Value) Then
                                    dtgDADOSEx.Item(columnIndex, dtgDADOSEx.Rows.Count - 1).Value = mCDec(nod.Nodes(cont).Cells.Item(index).Value)
                                Else
                                    dtgDADOSEx.Item(columnIndex, dtgDADOSEx.Rows.Count - 1).Value = nod.Nodes(cont).Cells.Item(index).Value
                                End If

                            End If

                            dtgDADOSEx.Item(columnIndex, dtgDADOSEx.Rows.Count - 1).Style.Format = nod.Nodes(cont).Cells.Item(index).Style.Format
                            dtgDADOSEx.Item(columnIndex, dtgDADOSEx.Rows.Count - 1).Style.BackColor = nod.Nodes(cont).Cells.Item(index).Style.BackColor
                            dtgDADOSEx.Item(columnIndex, dtgDADOSEx.Rows.Count - 1).Style.ForeColor = nod.Nodes(cont).Cells.Item(index).Style.ForeColor
                        End If
                        'For index As Integer = 0 To dttDados.Columns.Count - 1
                        '    If dttDados.Columns(index).DisplayIndex = columnIndex Then
                        '        Exit For
                        '    End If
                        'Next

                        columnIndex += 1
                    End While

                    dtgDADOSEx.Rows(dtgDADOSEx.Rows.Count - 1).DefaultCellStyle.Alignment = nod.Nodes(cont).DefaultCellStyle.Alignment
                    dtgDADOSEx.Rows(dtgDADOSEx.Rows.Count - 1).DefaultCellStyle.Format = nod.Nodes(cont).DefaultCellStyle.Format
                    dtgDADOSEx.Rows(dtgDADOSEx.Rows.Count - 1).DefaultCellStyle.BackColor = nod.Nodes(cont).DefaultCellStyle.BackColor
                    dtgDADOSEx.Rows(dtgDADOSEx.Rows.Count - 1).DefaultCellStyle.ForeColor = nod.Nodes(cont).DefaultCellStyle.ForeColor
                    dtgDADOSEx.Rows(dtgDADOSEx.Rows.Count - 1).DefaultCellStyle.Font = nod.Nodes(cont).DefaultCellStyle.Font

                    GeraDTGLevels(nod.Nodes(cont), dtgDADOSEx, dttDados, levelArrow, dicClmIndex)
                End If
            Next
        End If
    End Sub

    Public Function getParametro(ByVal codParametro As String, Optional ByVal conexao As MvtConnection.MvtConnection = Nothing) As String

        Dim valor As String = ""
        If conexao Is Nothing Then
            conexao = conexaoPadrao
            If conexao Is Nothing Then
                mMensagemAlerta("Conex„o n„o informada ao tentar ler par‚metro no banco de dados. Par‚metro: " & codParametro)
                Return False
            End If
        End If

        Dim strSQL As String
        strSQL = "SELECT valor" & Chr(13) & Chr(10)
        strSQL = strSQL & "FROM Mvt_Cfg.Parametro" & Chr(13) & Chr(10)
        strSQL = strSQL & "WHERE codParametro='" & codParametro.ToLower & "'" & Chr(13) & Chr(10)

        Using dr As IDataReader = conexaoPadrao.ReturnDataReader(strSQL)
            While dr.Read
                valor = "" & "" & dr(0)
            End While
            dr.Close()
        End Using
        Return valor
    End Function

    Public Function getParametroStr(ByVal codParametro As String, Optional ByVal conexao As MvtConnection.MvtConnection = Nothing) As String
        Return CStr(getParametro(codParametro, conexao))
    End Function

    Public Function getParametroInt(ByVal codParametro As String, Optional ByVal conexao As MvtConnection.MvtConnection = Nothing) As Integer
        Return mCInt(getParametro(codParametro, conexao))
    End Function

    Public Function getParametroDec(ByVal codParametro As String, Optional ByVal conexao As MvtConnection.MvtConnection = Nothing) As Decimal
        Return mCDec(getParametro(codParametro, conexao))
    End Function

    Public Function getParametroDate(ByVal codParametro As String, Optional ByVal conexao As MvtConnection.MvtConnection = Nothing) As Date
        Return mCDate(CStr(getParametro(codParametro, conexao)))
    End Function

    Public Function setParametroStr(ByVal codParametro As String, ByVal valor As String, Optional ByVal conexao As MvtConnection.MvtConnection = Nothing) As Boolean
        Dim gravadoOk As Boolean = False
        If conexao Is Nothing Then
            conexao = conexaoPadrao
            If conexao Is Nothing Then
                mMensagemAlerta("Conex„o n„o informada ao tentar gravar par‚metro no banco de dados. Par‚metro: " & codParametro)
                Return False
            End If
        End If

        conexaoPadrao.NewTable("Mvt_Cfg.Parametro", False)
        conexaoPadrao.InsertKey("codParametro", "'" & codParametro.ToLower & "'")
        conexaoPadrao.InsertField("valor", "'" & valor & "'")
        conexaoPadrao.SQLComando = ""
        Try
            conexaoPadrao.ExecuteInsertUpDate(False)
            gravadoOk = True
        Catch ex As Exception
            conexaoPadrao.Exists = True
            Try
                conexaoPadrao.ExecuteInsertUpDate(False)
                gravadoOk = True
            Catch ex2 As Exception
                mMensagemAlerta("Houve um erro tentando gravar o par‚metro." & vbCrLf & vbCrLf & ex.ToString())
                gravadoOk = False
            End Try
        End Try

        Return gravadoOk
    End Function

    Public Function setParametroInt(ByVal codParametro As String, ByVal valor As Integer, Optional ByVal conexao As MvtConnection.MvtConnection = Nothing) As Boolean
        Return setParametroStr(codParametro, valor.ToString, conexao)
    End Function

    Public Function setParametroDec(ByVal codParametro As String, ByVal valor As Decimal, Optional ByVal conexao As MvtConnection.MvtConnection = Nothing) As Boolean
        Return setParametroStr(codParametro, valor.ToString, conexao)
    End Function

    Public Function setParametroDate(ByVal codParametro As String, ByVal valor As Date, Optional ByVal conexao As MvtConnection.MvtConnection = Nothing) As Boolean
        If valor = Nothing Then
            Return setParametroStr(codParametro, "", conexao)
        Else
            Return setParametroStr(codParametro, Format(valor, "yyyy/MM/dd"), conexao)
        End If
    End Function

    Public Function retornaDataHoraServidor(ByVal conexao As MvtConnection.MvtConnection) As Date
        ''
        ''deve ser usada a var conexaoPadrao
        ''
        If conexaoPadrao Is Nothing Then
            conexaoPadrao = CriarConexao(strConnDBDEFAULT)
        End If
        Dim serverDate As Date = Today
        Dim strSQL As String = Nothing
        If conexaoPadrao.ActiveConnection <> MvtConnection.DataBase.ORACLE _
            AndAlso conexaoPadrao.ActiveConnection <> MvtConnection.DataBase.ORACLECLIENT Then
            strSQL = "SELECT DISTINCT GETDATE() AS Data FROM Mvt_Acesso.UsuarioEmpresa"
        Else
            strSQL = "SELECT DISTINCT SYSDATE AS Data FROM Mvt_Acesso.UsuarioEmpresa"
        End If
        Using dr As IDataReader = conexaoPadrao.ReturnDataReader(strSQL)
            While dr.Read()
                serverDate = "" & dr(0)
            End While
        End Using
        Return serverDate
    End Function

    Public Function retornaDataHoraServidorOracle(ByVal conexao As MvtConnection.MvtConnection) As Date
        ''
        ''deve ser usada a var conexaoPadrao
        ''
        If conexaoPadrao Is Nothing Then
            conexaoPadrao = New MvtConnection.MvtConnection(strConnDBDEFAULT)
        End If
        Dim serverDate As Date = Today
        Dim strSQL As String = "SELECT DISTINCT SYSDATE AS Data FROM Mvt_Acesso.UsuarioEmpresa"
        Using dr As IDataReader = conexaoPadrao.ReturnDataReader(strSQL)
            While dr.Read()
                serverDate = "" & dr(0)
            End While
            dr.Close()
        End Using
        Return serverDate
    End Function

    Public Function retornaDataServidor(ByVal conexao As MvtConnection.MvtConnection) As Date
        Return mCDate(Format(retornaDataHoraServidor(conexao), "yyyy/MM/dd"))
    End Function

    Public Function retornaDataServidorOracle(ByVal conexao As MvtConnection.MvtConnection) As Date
        Return mCDate(Format(retornaDataHoraServidorOracle(conexao), "yyyy/MM/dd"))
    End Function

    Public Function retornaHoraServidor(ByVal conexao As MvtConnection.MvtConnection) As Date
        Return mCDate(Format(retornaDataHoraServidor(conexao), "HH:mm:ss"))
    End Function

    Public Function calculaDataPorAnoSemana(ByVal ano As Short, ByVal semana As Byte, Optional ByVal diaDaSemana As DayOfWeek = Nothing) As Date
        '' USADO NO SEQUENCIAMENTO DE COMPRAS: CUIDADO AO MUDAR!!!
        Dim gc As New System.Globalization.GregorianCalendar
        Dim ret As Date = gc.AddWeeks(New Date(ano, 1, 1), semana - 1)
        If diaDaSemana = Nothing Or ret.DayOfWeek = diaDaSemana Then
            Return ret
        Else
            Return proximoDiaDaSemana(ret, diaDaSemana, 0)
        End If
    End Function

    Public Function proximoDiaDaSemana(ByVal dataBase As Date, ByVal diaDaSemana As DayOfWeek, Optional ByVal direcao As SByte = 0) As Date
        '' USADO NO SEQUENCIAMENTO DE COMPRAS: CUIDADO AO MUDAR!!!
        Dim dias As SByte
        If dataBase = Nothing Then
            Return dataBase
        Else

            If direcao = 0 Then
                If dataBase.DayOfWeek = diaDaSemana Then
                    Return dataBase
                Else
                    If dataBase.DayOfWeek > diaDaSemana Then
                        dias = -1
                    Else
                        dias = 1
                    End If
                End If
            Else
                If direcao > 0 Then
                    dias = 1
                Else
                    dias = -1
                End If
            End If

            While (True)
                dataBase = dataBase.AddDays(dias)
                If dataBase.DayOfWeek = diaDaSemana Then
                    Return dataBase
                End If
            End While
        End If

        Return Nothing
    End Function

    Public Function geraCodigoTemporario(ByVal conexao As MvtConnection.MvtConnection, Optional ByVal nomeTabelaTemporario As String = Nothing) As Integer
        ''
        ''deve ser usada a var conexaoPadrao
        ''
        If conexaoPadrao Is Nothing Then
            conexaoPadrao = CriarConexao(strConnDBDEFAULT)
        End If
        Dim codTemporario As Integer
        Dim strSQL As String
        Dim h As System.Net.IPHostEntry = System.Net.Dns.GetHostEntry(System.Net.Dns.GetHostName)
        Dim teste As String = (h.AddressList.GetValue(0).ToString)
        If h.AddressList(0).AddressFamily <> System.Net.Sockets.AddressFamily.InterNetwork Then
            For Each ip As System.Net.IPAddress In h.AddressList
                If ip.AddressFamily = System.Net.Sockets.AddressFamily.InterNetwork Then
                    teste = ip.ToString
                    Exit For
                End If
            Next
        End If

        codTemporario = (Split(teste, ".")(2) & Split(teste, ".")(3)) * 1
        Dim contTentativas As Integer = 1
        While contTentativas <= 100
            Try

                strSQL = "DELETE FROM  Mvt_Temp.CodigosTemporarios " & Chr(13) & Chr(10)
                strSQL = strSQL & " WHERE codTemporario=" & codTemporario '& " AND dataGeracao={d '2100-01-01'} AND usuario='" & strUsuarioLogado & "' " & Chr(13) & Chr(10)
                conexaoPadrao.ExecuteNonQuery(strSQL)
            Catch ex As Exception

            End Try
            Try
                strSQL = "INSERT INTO Mvt_Temp.CodigosTemporarios(codTemporario, dataGeracao, usuario) " & Chr(13) & Chr(10)
                strSQL = strSQL & " VALUES(" & codTemporario & ", {d '2100-01-01'}, '" & strUsuarioLogado & "') " & Chr(13) & Chr(10)
                conexaoPadrao.ExecuteNonQuery(strSQL)
                Exit While
            Catch ex As Exception
                codTemporario = 0
            End Try

            contTentativas += 1
        End While

        If codTemporario = 0 Then
            Throw New Exception("N„o foi possÌvel gerar um cÛdigo de tempor·rio. Contacte o suporte.")
        End If

        If Not (nomeTabelaTemporario Is Nothing) Then
            limpaTemporario(conexao, nomeTabelaTemporario, codTemporario)
        End If

        Return codTemporario
    End Function

    Public Sub limpaTemporario(ByVal conexao As MvtConnection.MvtConnection, ByVal nomeTabelaTemporario As String, ByVal codTemporario As Integer)
        ''
        ''deve ser usada a var conexaoPadrao
        ''
        If conexao Is Nothing Then
            conexao = CriarConexao(strConnDBDEFAULT)
        End If
        Dim strSQL As String

        Try
            strSQL = "DELETE FROM " & nomeTabelaTemporario & Chr(13) & Chr(10)
            strSQL = strSQL & "WHERE codEmpresa = " & codEmpresa & Chr(13) & Chr(10)

            strSQL = strSQL & "  AND codTemporario=" & codTemporario & Chr(13) & Chr(10)

            conexao.ExecuteNonQuery(strSQL)
        Catch ex As Exception

        End Try
    End Sub

    ''' <summary>
    ''' Converte um objeto inteiro em um booleano (1=TRUE / 0=FALSE))
    ''' </summary>
    ''' <param name="int">Inteiro deve ser 1 ou 0, se for maior que 1 ou menor que 0 È retornado FALSE</param>
    ''' <returns>False se int for 0 / True se int for 1 </returns>
    ''' <remarks></remarks>
    Public Function getBooleanFromBinaryInteger(ByVal int As Integer) As Boolean
        Return ((int = 1) And (Not int = 0))
    End Function

    ''' <summary>
    ''' Converte um objeto booleano em um inteiro (TRUE=1 / FALSE=0)
    ''' </summary>
    ''' <param name="bool">Boolean a ser convertido para inteiro</param>
    ''' <returns>0 se bool for False / 1 se bool for True</returns>
    ''' <remarks></remarks>
    Public Function getBinaryIntegerFromBoolean(ByVal bool As Boolean) As Integer
        Return mCInt(bool * -1)
    End Function

    ''' <summary>
    ''' Converte o campo CNPJCPF em uma String, fazendo assim que conside
    ''' </summary>
    ''' <param name="cp">Objeto MvtWindowsForms.TextBoxCNPJCPFWithLabel que ser· lida a propriedade Text da propriedade TextBoxValue e convertido em String</param>
    ''' <returns>Objeto String contendo o CNPJCPF</returns>
    ''' <remarks></remarks>
    Public Function convertCPFCNPJ(ByVal cp As MvtWindowsForms.TextBoxCNPJCPFWithLabel) As String
        Dim CPFCNPJ As String = ""
        For Each carac As Char In cp.TextBoxValue.Text
            If IsNumeric(carac) Then
                CPFCNPJ &= carac
            End If
        Next
        Return CPFCNPJ
    End Function

    Function ChecaEmailValido(ByVal emailAddress As String) As Boolean
        If String.IsNullOrEmpty(emailAddress) Then
            Return False
        End If

        ' Pattern ou mascara de verificaÁ„o
        'Dim pattern As String = "^[a-zA-Z][\w\.-]*[a-zA-Z0-9_]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"
        Dim pattern As String = "^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" &
        "(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$"

        ' Verifica se o email corresponde a pattern/mascara
        Dim emailAddressMatch As Match = Regex.Match(emailAddress, pattern)

        ' Caso corresponda
        If emailAddressMatch.Success Then
            Return True
        Else
            Return False
        End If
    End Function

    Function GetFirstDayOfWeek(ByVal dateOf As Date) As Date
        Return dateOf.AddDays(-dateOf.DayOfWeek)
    End Function

    Function GetLastDayOfWeek(ByVal dateOf As Date) As Date
        Return dateOf.AddDays(6 - dateOf.DayOfWeek)
    End Function

    Public Function GetCorRelevancia(ByVal value As Double, ByVal valueBase As Double, ByVal colorBase As Color) As Color

        ' PERCENT
        Dim percent As Double = (100 - (((value / (valueBase + 0.0001)) * 100))) / 2
        If percent > 100 Then percent = 100
        Dim rgbValue As Integer = 0

        ' RED
        rgbValue = colorBase.R + percent
        If rgbValue > 255 Then
            colorBase = Color.FromArgb(colorBase.A, 255, colorBase.G, colorBase.B)
        ElseIf rgbValue < 0 Then
            colorBase = Color.FromArgb(colorBase.A, 0, colorBase.G, colorBase.B)
        Else
            colorBase = Color.FromArgb(colorBase.A, rgbValue, colorBase.G, colorBase.B)
        End If

        ' GREEN
        percent *= 1.5
        rgbValue = colorBase.G + percent
        If rgbValue > 255 Then
            colorBase = Color.FromArgb(colorBase.A, colorBase.R, 255, colorBase.B)
        ElseIf rgbValue < 0 Then
            colorBase = Color.FromArgb(colorBase.A, colorBase.R, 0, colorBase.B)
        Else
            colorBase = Color.FromArgb(colorBase.A, colorBase.R, rgbValue, colorBase.B)
        End If

        ' BLUE
        percent *= 2
        rgbValue = colorBase.B + percent
        If rgbValue > 255 Then
            colorBase = Color.FromArgb(colorBase.A, colorBase.R, colorBase.G, 255)
        ElseIf rgbValue < 0 Then
            colorBase = Color.FromArgb(colorBase.A, colorBase.R, colorBase.G, 0)
        Else
            colorBase = Color.FromArgb(colorBase.A, colorBase.R, colorBase.G, rgbValue)
        End If

        Return colorBase
    End Function

    Public Sub DataGridTreeViewDestacaCelula(ByVal node As Object, ByVal colunaIndice As Integer, ByVal corBase As Color)
        Dim maiorValor As Double = 0
        For indice As Integer = 0 To node.Nodes.Count - 1
            If maiorValor < mCDbl(node.Nodes(indice).Cells(colunaIndice).Value) Then
                maiorValor = mCDbl(node.Nodes(indice).Cells(colunaIndice).Value)
            End If
        Next
        For indice As Integer = 0 To node.Nodes.Count - 1
            Dim valor As Double = mCDbl(node.Nodes(indice).Cells(colunaIndice).Value)
            node.Nodes(indice).Cells(colunaIndice).Style.BackColor = GetCorRelevancia(valor, maiorValor, corBase)
            DataGridTreeViewDestacaCelula(node.Nodes(indice), colunaIndice, corBase)
        Next
    End Sub

    Public Sub DataGridViewDestacaCelula(ByVal dtg As MvtWindowsForms.MvtDataGridView, ByVal nomeColuna As String, ByVal corBase As Color)
        Dim maiorValor As Double = 0
        For linha As Integer = 0 To dtg.Rows.Count - 1
            If maiorValor < mCDbl(dtg.Item(nomeColuna, linha).Value) Then
                maiorValor = mCDbl(dtg.Item(nomeColuna, linha).Value)
            End If
        Next
        For linha As Integer = 0 To dtg.Rows.Count - 1
            Dim valor As Double = mCDbl(dtg.Item(nomeColuna, linha).Value)
            dtg.Item(nomeColuna, linha).Style.BackColor = GetCorRelevancia(valor, maiorValor, corBase)
        Next
    End Sub

    Public Sub InserirPictureBoxImageEmCelulaExcel(ByVal excelValue As Object, ByVal rangeValue As String, ByVal imagemValue As PictureBox, Optional ByVal widthValue As Integer = -1, Optional ByVal heightValue As Integer = -1)
        If widthValue < 0 Then
            widthValue = imagemValue.Size.Width
        End If
        If heightValue < 0 Then
            heightValue = imagemValue.Size.Height
        End If
        Dim nomeImagemValue As String = imagemValue.Name
        Dim bmp As New Bitmap(widthValue, heightValue, Imaging.PixelFormat.Format32bppArgb)
        imagemValue.DrawToBitmap(bmp, New Rectangle(0, 0, widthValue, heightValue))
        bmp.Save(System.IO.Path.GetTempPath() & nomeImagemValue & ".png", System.Drawing.Imaging.ImageFormat.Png)
        excelValue.Range(rangeValue).Select()
        excelValue.ActiveSheet.Pictures.Insert(System.IO.Path.GetTempPath() & nomeImagemValue & ".png")
    End Sub

    ''' <summary>
    ''' FunÁ„o chamada apÛs efetuar a soma de um Node
    ''' </summary>
    ''' <param name="nodeBase">Node Pai que est· sendo totalizado</param>
    ''' <param name="nodeFilho">Node Filho</param>
    ''' <param name="colunaSoma">Coluna que est· sendo totalizado</param>
    ''' <remarks></remarks>
    Delegate Sub somouNode(ByVal nodeBase As Object, nodeFilho As Object, colunaSoma As Integer)
    ''' <summary>
    ''' Calcula total do treeView
    ''' </summary>
    ''' <param name="nodBase">treeView ou Node inicial</param>
    ''' <param name="colunaInicial"></param>
    ''' <param name="colunaFinal"></param>
    ''' <param name="indicesColunasNaoSomar">Indices das colunas que n„o devem ser somadas (separadas por ;)</param>
    ''' <param name="zerar">zerar nodes e colunas antes de somar</param>
    ''' <param name="somarInvisivel"></param>
    ''' <param name="aposSomar">funÁ„o que ser· chamada apÛs soma do node</param>
    Public Sub CalculaTotalTreeView(ByVal nodBase As Object, ByVal colunaInicial As Integer, ByVal colunaFinal As Integer, Optional ByVal indicesColunasNaoSomar As String = Nothing, Optional ByVal zerar As Boolean = False, Optional ByVal somarInvisivel As Boolean = False, Optional ByVal aposSomar As somouNode = Nothing)
        If fEsquerda(indicesColunasNaoSomar, 1) <> ";" Then
            indicesColunasNaoSomar = ";" & indicesColunasNaoSomar
        End If
        If fDireita(indicesColunasNaoSomar, 1) <> ";" Then
            indicesColunasNaoSomar = indicesColunasNaoSomar & ";"
        End If
        For contaNode As Integer = 0 To nodBase.Nodes.Count - 1
            If nodBase.ToString <> "MvtWindowsForms.TreeGridView" And contaNode = 0 And zerar Then
                For contaColuna As Integer = colunaInicial To colunaFinal
                    Dim somarColuna As Boolean = Not (indicesColunasNaoSomar.Contains(";" & contaColuna & ";"))
                    If somarColuna Then
                        nodBase.Cells(contaColuna).Value = 0
                    End If
                Next
            End If

            If nodBase.Nodes(contaNode).Nodes.Count > 0 And (nodBase.visible Or somarInvisivel) Then
                CalculaTotalTreeView(nodBase.Nodes(contaNode), colunaInicial, colunaFinal, indicesColunasNaoSomar, zerar, somarInvisivel, aposSomar)
            End If
            If nodBase.ToString <> "MvtWindowsForms.TreeGridView" And (nodBase.visible Or somarInvisivel) Then
                For contaColuna As Integer = colunaInicial To colunaFinal
                    ''VERIFICA SE … PARA SOMAR COLUNA
                    Dim somarColuna As Boolean = Not (indicesColunasNaoSomar.Contains(";" & contaColuna & ";"))
                    If somarColuna AndAlso (nodBase.Nodes(contaNode).Visible Or somarInvisivel) Then
                        nodBase.Cells(contaColuna).Value = mCDec(nodBase.Cells(contaColuna).Value) + mCDec(nodBase.Nodes(contaNode).Cells(contaColuna).Value)
                        If aposSomar IsNot Nothing Then
                            Call aposSomar(nodBase, nodBase.Nodes(contaNode), contaColuna)
                        End If
                    End If
                Next
            End If
        Next

    End Sub

    Sub expandeTreeViewNivel(ByVal nodBase As Object, ByVal nivel As Integer)
        If nodBase.ToString = "MvtWindowsForms.TreeGridView" Then
            For cont As Integer = 0 To nodBase.Nodes.Count - 1
                expandeTreeViewNivel(nodBase.Nodes(cont), nivel)
                If nodBase.Nodes(cont).Level > nivel Then
                    nodBase.Nodes(cont).Collapse()
                ElseIf nodBase.Nodes(cont).Level <= nivel Then
                    nodBase.Nodes(cont).Expand()
                End If
            Next
        Else
            For cont As Integer = 0 To nodBase.Nodes.Count - 1
                If nodBase.Level <= nivel Then
                    nodBase.Expand()
                End If
                expandeTreeViewNivel(nodBase.Nodes(cont), nivel)
                If nodBase.Nodes(cont).Level > nivel Then
                    If nodBase.IsExpanded Then
                        nodBase.Nodes(cont).Collapse()
                    End If
                ElseIf nodBase.Nodes(cont).Level <= nivel Then
                    If nodBase.IsExpanded Then
                        nodBase.Nodes(cont).Expand()
                    End If
                End If
            Next
        End If
    End Sub

    Function criaCorNivel(ByVal corPadrao As Color, ByVal indice As Integer) As Color
        Dim varCorR As Integer = corPadrao.R + indice
        Dim varCorG As Integer = corPadrao.G + indice
        Dim varCorb As Integer = corPadrao.B + indice
        If varCorR > 255 Then
            varCorR = 255
        End If
        If varCorG > 255 Then
            varCorG = 255
        End If
        If varCorb > 255 Then
            varCorb = 255
        End If
        Return Color.FromArgb(corPadrao.A, varCorR, varCorG, varCorb)
    End Function

    Public Function DataGridViewCopiaTabelaClipboard(ByVal dtg As MvtWindowsForms.MvtDataGridView, Optional ByVal clearRows As Boolean = True, Optional ByVal columnIndexStart As Integer = 0, Optional ByVal rowIndexStart As Integer = 0, Optional ByVal separator As String = vbTab, Optional addRows As Boolean = True, Optional converterComBaseNoFormatoDaColuna As Boolean = False) As Integer
        Dim objClipboard As IDataObject = Clipboard.GetDataObject()
        If clearRows Then
            dtg.Rows.Clear()
        End If
        If objClipboard.GetDataPresent(DataFormats.Text) Then
            Dim texto As String = objClipboard.GetData(DataFormats.Text)
            Dim linha As Integer = rowIndexStart
            Dim coluna As Integer = columnIndexStart
            Dim arrDados As Array = Split(texto, vbCrLf)
            Dim limite As Integer = 1
            If dtg.AllowUserToAddRows Then
                limite = 2
            End If
            For cont As Integer = 0 To UBound(arrDados)
                Dim arrDadosLinha As Array = Split(arrDados(cont), separator)

                If arrDados(cont) <> "" Then
                    If linha > dtg.RowCount - limite Then
                        If Not addRows Then Exit For
                        dtg.Rows.Add()
                        For contCol As Integer = 0 To UBound(arrDadosLinha)
                            Try
                                If IsNumeric(arrDadosLinha(contCol)) OrElse (converterComBaseNoFormatoDaColuna AndAlso IsNumericFormat(dtg.Columns(coluna + contCol).DefaultCellStyle.Format)) Then
                                    dtg.Item(coluna + contCol, linha).Value = mCDec(arrDadosLinha(contCol))
                                Else
                                    dtg.Item(coluna + contCol, linha).Value = arrDadosLinha(contCol)
                                End If

                            Catch ex As Exception

                            End Try
                        Next
                    Else

                        For contCol As Integer = 0 To UBound(arrDadosLinha)
                            Try
                                If IsNumeric(arrDadosLinha(contCol)) OrElse (converterComBaseNoFormatoDaColuna AndAlso IsNumericFormat(dtg.Columns(coluna + contCol).DefaultCellStyle.Format)) Then
                                    dtg.Item(coluna + contCol, linha).Value = mCDec(arrDadosLinha(contCol))
                                Else
                                    dtg.Item(coluna + contCol, linha).Value = arrDadosLinha(contCol)
                                End If

                            Catch ex As Exception

                            End Try
                        Next

                    End If

                End If

                linha += 1
            Next
            Return linha - rowIndexStart
        End If
        Return 0
    End Function

    Private Function IsNumericFormat(format As String) As Boolean
        Return format.StartsWith("N") OrElse format.Contains("#") OrElse format.StartsWith("C") OrElse format.StartsWith("P")
    End Function

    Public Sub DataGridTreeViewCopiaTabelaClipboard(ByVal dtg As Object, Optional ByVal columnIndexStart As Integer = 0, Optional ByVal rowIndexStart As Integer = 0, Optional ByVal separator As String = vbTab)
        Dim objClipboard As IDataObject = Clipboard.GetDataObject()
        If objClipboard.GetDataPresent(DataFormats.Text) Then
            Dim texto As String = objClipboard.GetData(DataFormats.Text)
            Dim linha As Integer = rowIndexStart
            Dim coluna As Integer = columnIndexStart
            Dim arrDados As Array = Split(texto, vbCrLf)
            Dim limite As Integer = 1
            If dtg.AllowUserToAddRows Then
                limite = 2
            End If
            For cont As Integer = 0 To UBound(arrDados)
                Dim arrDadosLinha As Array = Split(arrDados(cont), separator)

                If arrDados(cont) <> "" Then
                    If linha > dtg.RowCount - limite Then
                        'dtg.Rows.Add()
                        For contCol As Integer = 0 To UBound(arrDadosLinha)
                            Try
                                If IsNumeric(arrDadosLinha(contCol)) Then
                                    dtg.Item(coluna + contCol, linha).Value = mCDec(arrDadosLinha(contCol))
                                Else
                                    dtg.Item(coluna + contCol, linha).Value = arrDadosLinha(contCol)
                                End If

                            Catch ex As Exception

                            End Try
                        Next

                    End If

                End If

                linha += 1
            Next
        End If
    End Sub

    Public Enum ConfigEmail
        Servidor
        EndereÁo
        ExigeAutenticaÁ„o
        Senha
    End Enum

    Function getConfigEmail(ByVal tipo As ConfigEmail)
        Dim ret = ""

        strSQL = "SELECT emailServidor," & Chr(13) & Chr(10)
        strSQL = strSQL & "     emailEndereco," & Chr(13) & Chr(10)
        strSQL = strSQL & "     emailAutenticacao," & Chr(13) & Chr(10)
        strSQL = strSQL & "     emailSenha" & Chr(13) & Chr(10)
        strSQL = strSQL & "FROM Mvt_Menu.Empresa" & Chr(13) & Chr(10)
        strSQL = strSQL & "WHERE codEmpresa=" & codEmpresa & Chr(13) & Chr(10)
        Using dr As IDataReader = conexaoPadrao.ReturnDataReader(strSQL)
            While dr.Read
                Select Case tipo
                    Case ConfigEmail.Servidor
                        ret = "" & dr("emailServidor")
                    Case ConfigEmail.EndereÁo
                        ret = "" & dr("emailEndereco")
                    Case ConfigEmail.ExigeAutenticaÁ„o
                        If ("" & dr("emailAutenticacao")).ToString.ToUpper = "SIM" Then
                            ret = True
                        Else
                            ret = False
                        End If
                    Case ConfigEmail.Senha
                        ret = "" & dr("emailSenha")
                End Select
            End While
            dr.Close()
        End Using
        Return ret
    End Function

    Function GetConfigEmail(ByVal codEmpresa As Integer) As ConfiguracaoEmail
        strSQL = "SELECT emailServidor," & Chr(13) & Chr(10)
        strSQL = strSQL & "     emailEndereco," & Chr(13) & Chr(10)
        strSQL = strSQL & "     emailAutenticacao," & Chr(13) & Chr(10)
        strSQL = strSQL & "     emailSenha" & Chr(13) & Chr(10)
        strSQL = strSQL & "FROM Mvt_Menu.Empresa" & Chr(13) & Chr(10)
        strSQL = strSQL & "WHERE codEmpresa=" & codEmpresa & Chr(13) & Chr(10)
        Dim confEmail As New ConfiguracaoEmail
        Using dr As IDataReader = conexaoPadrao.ReturnDataReader(strSQL)
            While dr.Read
                confEmail.Servidor = dr("emailServidor") & ""
                confEmail.Endereco = dr("emailEndereco") & ""
                If ("" & dr("emailAutenticacao")).ToString.ToUpper = "SIM" Then
                    confEmail.ExigeAutenticacao = True
                Else
                    confEmail.ExigeAutenticacao = False
                End If
                confEmail.Senha = dr("emailSenha") & ""
            End While
            dr.Close()
        End Using
        Return confEmail
    End Function

    Sub SetConfigEmail(ByVal configEmail As ConfiguracaoEmail)
        Try
            configEmail.Validar()
        Catch ex As Exception
            mMensagemErro(ex.Message)
            Exit Sub
        End Try

        strSQL = "SELECT COUNT(*)" & Chr(13) & Chr(10)
        strSQL = strSQL & "FROM Mvt_Menu.Empresa" & Chr(13) & Chr(10)
        strSQL = strSQL & "WHERE codempresa=" & configEmail.CodEmpresa & Chr(13) & Chr(10)
        Using dr As IDataReader = conexaoPadrao.ReturnDataReader(strSQL)
            While dr.Read
                If mCInt(dr(0)) > 0 Then
                    conexaoPadrao.NewTable("Mvt_Menu.Empresa", True)
                Else
                    conexaoPadrao.NewTable("Mvt_Menu.Empresa", False)
                End If
                conexaoPadrao.InsertKey("codEmpresa", codEmpresa)
                conexaoPadrao.InsertField("emailServidor", ValueSQLString(configEmail.Servidor))
                conexaoPadrao.InsertField("emailEndereco", ValueSQLString(configEmail.Endereco))
                If configEmail.ExigeAutenticacao Then
                    conexaoPadrao.InsertField("emailAutenticacao", ValueSQLString("SIM"))
                Else
                    conexaoPadrao.InsertField("emailAutenticacao", ValueSQLString("N√O"))
                End If
                conexaoPadrao.InsertField("emailSenha", ValueSQLString(configEmail.Senha))
                Try
                    Dim erro As String = conexaoPadrao.ExecuteInsertUpDate(False)
                    If erro <> "" Then
                        mMensagemErro(erro)
                        Exit Sub
                    End If
                Catch ex As MvtException
                    mMensagemErro("Erro ao salvar configuraÁ„o de e-mail" & vbCrLf & ex.Message)
                    Exit Sub
                End Try
                dr.Close()
                mMensagemAlerta("Salvo com sucesso")
                Exit Sub
            End While
            dr.Close()
        End Using
        MessageBox.Show("Empresa n„o encontrada", "Ops..", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
    End Sub

    ''' <summary>
    ''' Monta filtros com base analisando um DataGridTreeView e um MultiCheckListBox
    ''' </summary>
    ''' <param name="dttValue">MvtDataGridTreeView</param>
    ''' <param name="chlValue">MultiCheckListBox</param>
    ''' <returns>filtro montado</returns>
    ''' <remarks></remarks>
    Public Function MontarFiltros(ByVal dttValue As Object, ByVal chlValue As Object) As String
        If dttValue.CurrentNode IsNot Nothing And dttValue.CurrentCell IsNot Nothing Then
            'If dttValue.CurrentCell.ColumnIndex = 0 Then
            Dim nodeSel As Object = dttValue.CurrentNode
            Dim niveis As New Dictionary(Of Integer, String)
            For count As Integer = 0 To chlValue.chkList.Items.Count - 1
                If chlValue.chkList.CheckedIndices.Contains(count) Then
                    niveis.Add(chlValue.chkList.Items(count).ToString().Substring(chlValue.chkList.Items(count).ToString().Length - 1, 1), chlValue.arrSELECT(count))
                End If
            Next
            Dim filtros As String = ""
            MontarFiltros(dttValue.CurrentNode, niveis, filtros)
            Return filtros.Substring(0, filtros.Length - 5)
            'End If
        End If
        Return ""
    End Function

    Private Sub MontarFiltros(ByVal node As Object, ByVal niveis As Dictionary(Of Integer, String), ByRef filtros As String)
        If node.Level > 1 Then
            filtros &= niveis(node.Level - 1) & "='" & node.Item(0).Value & "' AND "
            If node.Parent.GetType().Name.Equals("TreeGridNode") Then
                MontarFiltros(node.Parent, niveis, filtros)
            End If
        End If
    End Sub

    Public Function GetExcelColumnName(ByVal columnNumber As Integer) As String
        Dim dividend As Integer = columnNumber
        Dim columnName As String = String.Empty
        Dim modulo As Integer

        While (dividend > 0)
            modulo = (dividend - 1) Mod 26
            columnName = Convert.ToChar(65 + modulo).ToString() + columnName
            dividend = Int(((dividend - modulo) / 26))
        End While

        Return columnName
    End Function

    Public Function MenuPendenciaCriaConfiguracao(ByVal pendencia As String, ByVal usuarioResponsavel As String, Optional ByVal programa As String = "") As String
        conexaoPadrao.NewTable("Mvt_Menu.PendenciaCfg", True)

        conexaoPadrao.InsertKey("codEmpresa", codEmpresa)
        conexaoPadrao.InsertKey("pendencia", "'" & pendencia & "'")
        conexaoPadrao.InsertField("programa", "'" & programa & "'")
        conexaoPadrao.InsertField("usuario", usuarioResponsavel)

        Dim erro = conexaoPadrao.ExecuteDelete(False)
        If erro <> "" Then
            Return erro
        End If

        conexaoPadrao.NewTable("Mvt_Menu.PendenciaCfg", False)

        conexaoPadrao.InsertKey("codEmpresa", codEmpresa)
        conexaoPadrao.InsertKey("pendencia", "'" & pendencia & "'")
        conexaoPadrao.InsertField("programa", "'" & programa & "'")
        conexaoPadrao.InsertField("usuario", usuarioResponsavel)

        erro = conexaoPadrao.ExecuteInsertUpDate(False)
        If erro <> "" Then
            Return erro
        End If

        Return ""

    End Function

    Public Function MenuPendenciaGera(ByVal empresa As Integer, ByVal pendencia As String, ByVal identificador As String, ByVal usuario As String, ByVal descricao As String, ByVal data As Date, ByVal titulo As String, ByVal responsavel As String) As Boolean

        If pendencia.Length > 30 Then
            pendencia = pendencia.Remove(30)
        End If

        Dim sc As String = ""
        ''CHECA SE PENDENCIA POSSUI CONFIGURACAO
        Dim programa As String = ""
        strSQL = "SELECT count(codEmpresa),MAX(programa) AS programa " & vbCrLf
        strSQL &= "FROM Mvt_Menu.PendenciaCfg " & vbCrLf
        strSQL &= "WHERE codEmpresa=" & empresa & " AND pendencia='" & pendencia & "'"
        Using dr As IDataReader = conexaoPadrao.ReturnDataReader(strSQL)
            While dr.Read
                sc = mCDec(dr(0))
                programa = dr("programa") & ""
            End While
            dr.Close()
        End Using
        If sc = 0 Then
            '' "Pendencia nao configurada"
            Return False
        End If

        ''CHECA SE PENDENCIA EST√Å ABERTA OU BAIXADA
        sc = ""
        Dim dataAbertura As String = ""
        Dim dataBaixa As String = ""
        Dim dataPrazo As String = ""
        Dim horaBaixa As String = ""
        strSQL = "SELECT dataAbertura,dataBaixa " & vbCrLf
        strSQL &= "FROM Mvt_Menu.Pendencia " & vbCrLf
        strSQL &= "WHERE codEmpresa=" & codEmpresa & " AND pendencia='" & pendencia & "' AND identificador='" & identificador & "'"
        Using dr As IDataReader = conexaoPadrao.ReturnDataReader(strSQL)
            While dr.Read
                sc = dr("dataAbertura") & ""
                dataBaixa = dr("dataBaixa") & ""
            End While
            dr.Close()
        End Using
        If sc <> "" Then
            ''Pendencia incorreta"
            ''"Pend√™ncia j√° baixada"
            ''"Pend√™ncia incorreta"
            Return False
        End If

        ' VERIFICA SE EXISTE
        Dim existe As Boolean = False
        Dim strSqlExiste As String = $"SELECT COUNT(1)
                                     FROM Mvt_Menu.Pendencia
                                     WHERE codEmpresa={empresa}
                                       AND pendencia={ValueSQLString(pendencia)}
                                       AND identificador={ValueSQLString(identificador)}"
        Using dr As IDataReader = conexaoPadrao.ReturnDataReader(strSqlExiste)
            If dr.Read Then
                existe = mCInt(dr(0)) > 0
            End If
        End Using

        '' BAIXA PENDENCIA
        Dim query As MvtConnection.Query.QueryTableBuilder = conexaoPadrao.NewQuery("Mvt_Menu.Pendencia", existe)

        query.AddKey("codEmpresa", empresa)
        query.AddKey("pendencia", pendencia)
        query.AddKey("identificador", identificador)

        query.AddField("dataAbertura", Today)
        query.AddField("horaAbertura", Now)
        query.AddField("prazo", data)

        query.AddField("usuarioAbertura", usuario)
        query.AddField("descricao", descricao)
        query.AddField("titulo", titulo)

        'programa
        query.AddField("programa", programa)
        query.AddField("usuarioResponsavel", responsavel)

        Dim erro As String = ""
        Try
            Dim res As MvtConnection.Query.QueryCommandResult = query.Save(conexaoPadrao)
            If Not res.AffectedRows.Equals(1) Then
                Throw New Exception("N„o foi possÌvel salvar pendÍncia!")
            End If
        Catch ex As Exception
            erro = ex.Message
        End Try

        If String.IsNullOrEmpty(erro) Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function MenuPendenciaParaUsuario(ByVal usuario As String, ByVal pendencia As String, ByVal identificador As String, Optional ByVal dataDemostracao As Date = Nothing) As String

        If pendencia.Length > 30 Then
            pendencia = pendencia.Remove(30)
        End If

        conexaoPadrao.NewTable("Mvt_Menu.PendenciaUsuarios", True)
        conexaoPadrao.InsertKey("codEmpresa", codEmpresa)
        conexaoPadrao.InsertKey("pendencia", "'" & pendencia & "'")
        conexaoPadrao.InsertKey("identificador", "'" & identificador & "'")
        conexaoPadrao.InsertKey("usuario", "'" & usuario & "'")

        Dim erro As String = conexaoPadrao.ExecuteDelete(False)
        If erro <> "" Then
            Return erro
        Else
            conexaoPadrao.Exists = False
            If dataDemostracao <> Nothing Then
                conexaoPadrao.InsertField("dataDemonstracao", "{d'" & Format(dataDemostracao, "yyyy-MM-dd") & "'}")
            End If
            erro = conexaoPadrao.ExecuteInsertUpDate(False)
            If erro <> "" Then
                Return erro
            End If
        End If

        Return ""

    End Function

    Public Function MenuPendenciaBaixa(ByVal empresa As Integer, ByVal pendencia As String, ByVal identificador As String, ByVal usuarioBaixa As String) As Boolean
        If pendencia.Length > 30 Then
            pendencia = pendencia.Remove(30)
        End If

        Dim sc As String = ""
        ''CHECA SE PENDENCIA POSSUI CONFIGURACAO
        strSQL = "SELECT count(codEmpresa) " & vbCrLf
        strSQL &= "FROM Mvt_Menu.PendenciaCfg " & vbCrLf
        strSQL &= "WHERE codEmpresa=" & empresa & " AND pendencia='" & pendencia & "'"
        Using dr As IDataReader = conexaoPadrao.ReturnDataReader(strSQL)
            While dr.Read
                sc = mCDec(dr(0))
            End While
            dr.Close()
        End Using
        If sc = 0 Then
            '' "Pendencia nao configurada"
            Return False
        End If
        ''CHECA SE PENDENCIA EST√Å ABERTA OU BAIXADA
        sc = ""
        Dim dataAbertura As String = ""
        Dim dataBaixa As String = ""
        Dim horaBaixa As String = ""
        strSQL = "SELECT dataAbertura,dataBaixa " & vbCrLf
        strSQL &= "FROM Mvt_Menu.Pendencia " & vbCrLf
        strSQL &= "WHERE codEmpresa=" & codEmpresa & " AND pendencia='" & pendencia & "' AND identificador='" & identificador & "'"
        Using dr As IDataReader = conexaoPadrao.ReturnDataReader(strSQL)
            While dr.Read
                sc = dr("dataAbertura") & ""
                dataBaixa = dr("dataBaixa") & ""
            End While
            dr.Close()
        End Using
        If dataBaixa <> "" Then
            ''Pendencia incorreta"
            ''"Pend√™ncia j√° baixada"
            ''"Pend√™ncia incorreta"
            Return False
        End If
        '' BAIXA PENDENCIA
        Dim query As MvtConnection.Query.QueryTableBuilder = conexaoPadrao.NewQuery("Mvt_Menu.Pendencia", True)

        query.AddKey("codEmpresa", empresa)
        query.AddKey("pendencia", pendencia)
        query.AddKey("identificador", identificador)

        query.AddField("dataBaixa", Today)
        query.AddField("horaBaixa", Now)
        query.AddField("usuarioBaixa", usuarioBaixa)

        Try
            query.Save(conexaoPadrao)
        Catch ex As Exception
            Return False
        End Try

        Return True
    End Function

    Public Function MenuPendenciaDeleta(ByVal empresa As Integer, ByVal pendencia As String, ByVal identificador As String) As Boolean
        If pendencia.Length > 30 Then
            pendencia = pendencia.Remove(30)
        End If
        Dim sc As String = ""
        ''CHECA SE PENDENCIA POSSUI CONFIGURACAO
        strSQL = "SELECT count(codEmpresa) " & vbCrLf
        strSQL &= "FROM Mvt_Menu.PendenciaCfg " & vbCrLf
        strSQL &= "WHERE codEmpresa=" & empresa & " AND pendencia='" & pendencia & "'"
        Using dr As IDataReader = conexaoPadrao.ReturnDataReader(strSQL)
            While dr.Read
                sc = mCDec(dr(0))
            End While
            dr.Close()
        End Using
        If sc = 0 Then
            '' "Pendencia nao configurada"
            Return False
        End If

        ''CHECA SE PENDENCIA EST√Å ABERTA OU BAIXADA
        sc = ""
        Dim dataAbertura As String = ""
        Dim dataBaixa As String = ""
        strSQL = "SELECT dataAbertura,dataBaixa " & vbCrLf
        strSQL &= "FROM Mvt_Menu.Pendencia " & vbCrLf
        strSQL &= "WHERE codEmpresa=" & codEmpresa & " AND pendencia='" & pendencia & "' AND identificador='" & identificador & "'"
        Using dr As IDataReader = conexaoPadrao.ReturnDataReader(strSQL)
            While dr.Read
                sc = dr("dataAbertura") & ""
            End While
            dr.Close()
        End Using
        If sc <> "" Then
            ''Pendencia incorreta"
            Return False
        End If
        ''DELETA PENDENCIA
        strSQL = "DELETE FROM Mvt_Menu.Pendencia " & vbCrLf
        strSQL &= "WHERE codEmpresa=" & codEmpresa & " AND pendencia='" & pendencia & "' AND identificador='" & identificador & "'"

        Return True
    End Function

    Public Sub SetRangeValue(ByVal excelApp As Object, ByVal range As String, ByVal value As Object, Optional ByVal sheetIndex As Integer = 1, Optional ByVal decimalFormat As String = "#,##0.00")
        If value.GetType().Name.ToLower = "decimal" Or value.GetType().Name.ToLower = "double" Then
            excelApp.Sheets(sheetIndex).Range(range).value = Format(mCDec(value), decimalFormat) & ""
        Else
            excelApp.Sheets(sheetIndex).Range(range).value = value & ""
        End If
    End Sub

    Public Sub SetRangeValueAspose(ByVal excelApp As Object, ByVal range As String, ByVal value As Object, Optional ByVal sheetIndex As Integer = 1, Optional ByVal decimalFormat As String = "#,##0.00")
        sheetIndex -= 1
        If (Not IsDBNull(value)) AndAlso value.ToString.StartsWith("=") Then
            If value.GetType().Name.ToLower = "decimal" Or value.GetType().Name.ToLower = "double" Then
                excelApp.Worksheets(sheetIndex).Cells(range).Formula = Format(mCDec(value), decimalFormat) & ""
            Else
                excelApp.Worksheets(sheetIndex).Cells(range).Formula = value & ""
            End If
        Else
            If value.GetType().Name.ToLower = "decimal" Or value.GetType().Name.ToLower = "double" Then
                excelApp.Worksheets(sheetIndex).Cells(range).value = Format(mCDec(value), decimalFormat) & ""
            Else
                excelApp.Worksheets(sheetIndex).Cells(range).value = value & ""
            End If
        End If
    End Sub

    Public Sub SetRangeValueAsposeWorksheet(ByVal worksheet As Object, ByVal range As String, ByVal value As Object, Optional ByVal sheetIndex As Integer = 1, Optional ByVal decimalFormat As String = "#,##0.00")
        sheetIndex -= 1
        If (Not IsDBNull(value)) AndAlso value.ToString.StartsWith("=") Then
            If value.GetType().Name.ToLower = "decimal" Or value.GetType().Name.ToLower = "double" Then
                worksheet.Cells(range).Formula = Format(mCDec(value), decimalFormat) & ""
            Else
                worksheet.Cells(range).Formula = value & ""
            End If
        Else
            If value.GetType().Name.ToLower = "decimal" Or value.GetType().Name.ToLower = "double" Then
                worksheet.Cells(range).value = Format(mCDec(value), decimalFormat) & ""
            Else
                worksheet.Cells(range).value = value & ""
            End If
        End If
    End Sub

    Public Sub AlterarPermissaoFormControls(ByVal form As Control, ByVal listaIgnorados As List(Of Control), ByVal habilitado As Boolean)
        For Each ctrl As Object In form.Controls
            If Not listaIgnorados.Contains(ctrl) Then
                If ctrl.GetType.Name.ToLower.Contains("datagrid") Then
                    ctrl.ReadOnly = Not habilitado
                Else
                    ctrl.Enabled = habilitado
                End If
                If ctrl.Controls.Count > 0 Then
                    AlterarPermissaoFormControls(ctrl, listaIgnorados, habilitado)
                End If
            End If
        Next
    End Sub

    Public Sub montaDataGridTotal(ByVal dtgBase As DataGridView, ByVal dtgTotal As DataGridView, Optional ByVal totalDe As Integer = 0, Optional ByVal totalAte As Integer = -1, Optional ByVal totalStep As Integer = 1, Optional ByVal resize As Boolean = False, Optional ByVal columnDescTotal As Integer = -1, Optional aumentarTamanhoColunas As Boolean = True, Optional createColumns As Boolean = True)
        If totalAte = -1 Then
            totalAte = dtgBase.ColumnCount - 1
        End If
        If totalAte > dtgBase.ColumnCount - 1 Then
            totalAte = dtgBase.ColumnCount - 1
        End If
        If createColumns Then
            dtgTotal.Columns.Clear()

            For contaColuna As Integer = 0 To dtgBase.ColumnCount - 1
                dtgTotal.Columns.Add(dtgBase.Columns(contaColuna).Clone)
            Next
            dtgTotal.Rows.Add()
            If aumentarTamanhoColunas Then
                dtgTotal.Font = New Font(dtgTotal.Font.Name, dtgTotal.Font.Size, FontStyle.Bold)
            End If
        Else
            If dtgTotal.RowCount > 0 Then
                For contaColuna As Integer = totalDe To totalAte Step totalStep
                    dtgTotal.Item(contaColuna, 0).Value = Nothing
                Next
            Else
                dtgTotal.Rows.Add()
            End If
            If aumentarTamanhoColunas Then
                dtgTotal.Font = New Font(dtgTotal.Font.Name, dtgTotal.Font.Size, FontStyle.Bold)
            End If
        End If

        For contaLinha As Integer = 0 To dtgBase.RowCount - 1
            If dtgBase.Rows(contaLinha).Visible Then
                For contaColuna As Integer = totalDe To totalAte Step totalStep
                    If Not IsDate(dtgBase.Item(contaColuna, contaLinha).Value) Or IsNumeric(dtgBase.Item(contaColuna, contaLinha).Value) Then
                        dtgTotal.Item(contaColuna, 0).Value += mCDec(dtgBase.Item(contaColuna, contaLinha).Value)
                    End If
                Next
            End If
        Next
        For contaColuna As Integer = 0 To dtgBase.ColumnCount - 1
            dtgTotal.Columns(contaColuna).DisplayIndex = dtgBase.Columns(contaColuna).DisplayIndex
            dtgTotal.Columns(contaColuna).Visible = dtgBase.Columns(contaColuna).Visible
        Next

        If resize Then
            dtgBase.AutoResizeColumns()
            dtgTotal.AutoResizeColumns()
        End If

        ''FORMATA TAMANHO DAS COLUNAS
        For contaColuna As Integer = 0 To dtgBase.ColumnCount - 1
            If aumentarTamanhoColunas Then
                dtgBase.Columns(contaColuna).Width += 18
            End If
            If dtgBase.Columns(contaColuna).Width >= dtgTotal.Columns(contaColuna).Width Then
                dtgTotal.Columns(contaColuna).Width = dtgBase.Columns(contaColuna).Width
            Else
                dtgBase.Columns(contaColuna).Width = dtgTotal.Columns(contaColuna).Width
            End If
        Next

        If columnDescTotal >= 0 Then
            If columnDescTotal <= dtgTotal.ColumnCount - 1 Then
                dtgTotal.Item(columnDescTotal, 0).Value = "TOTAL"
            End If
        End If
    End Sub

    ''' <summary>
    ''' Retorna a letra correspondente ao n˙mero
    ''' ex: 1=a, 2=b e etc...
    ''' </summary>
    ''' <param name="number">N˙mero as ser buscada a letra</param>
    ''' <param name="upperCase">True para letra mai˙scula</param>
    ''' <returns>a letra correspondente ao n˙mero passado por par‚metro</returns>
    ''' <remarks></remarks>
    Public Function GetLetterNumber(ByVal number As Integer, ByVal upperCase As Boolean) As String
        If upperCase Then
            If 64 + number > 90 Xor 64 + number < 65 Then
                Return Nothing
            Else
                Return Chr(64 + number)
            End If
        Else
            If 96 + number > 122 Xor 96 + number < 97 Then
                Return Nothing
            Else
                Return Chr(96 + number)
            End If
        End If
        Return Nothing
    End Function

    Public Function getMultiLineString(ByVal strText As String, ByVal intNewLineInterval As Integer) As String
        For charCount As Integer = intNewLineInterval To strText.Length - 1 Step intNewLineInterval
            Dim tempCharCount As Integer = charCount
            While strText.Substring(tempCharCount, 1) <> " "
                tempCharCount += 1
                If tempCharCount > strText.Length - 1 Then
                    Exit While
                End If
            End While
            strText = strText.Insert(tempCharCount, vbCrLf)
        Next
        Return strText
    End Function

    Public Function ConverteHoraStringParaMinutos(ByVal strHora As String) As Decimal
        Dim numHora As Decimal = mCDec(Piece(strHora, ":", 1))
        Dim numMinuto As Decimal = mCDec(Piece(strHora, ":", 2))
        Dim totalMinuto As Decimal = (numHora * 60) + numMinuto

        Return totalMinuto
    End Function

    Public Function AESEncrypt(ByVal input As String, ByVal pass As String) As String
        Dim AES As New System.Security.Cryptography.RijndaelManaged
        Dim Hash_AES As New System.Security.Cryptography.MD5CryptoServiceProvider
        Dim encrypted As String = ""
        Try
            Dim hash(31) As Byte
            Dim temp As Byte() = Hash_AES.ComputeHash(System.Text.ASCIIEncoding.ASCII.GetBytes(pass))
            Array.Copy(temp, 0, hash, 0, 16)
            Array.Copy(temp, 0, hash, 15, 16)
            AES.Key = hash
            AES.Mode = Security.Cryptography.CipherMode.ECB
            Dim DESEncrypter As System.Security.Cryptography.ICryptoTransform = AES.CreateEncryptor
            Dim Buffer As Byte() = System.Text.ASCIIEncoding.ASCII.GetBytes(input)
            encrypted = Convert.ToBase64String(DESEncrypter.TransformFinalBlock(Buffer, 0, Buffer.Length))
            Return encrypted
        Catch ex As Exception
            Return encrypted
        End Try
    End Function

    Public Function AESDecrypt(ByVal input As String, ByVal pass As String) As String
        Dim AES As New System.Security.Cryptography.RijndaelManaged
        Dim Hash_AES As New System.Security.Cryptography.MD5CryptoServiceProvider
        Dim decrypted As String = ""
        Try
            Dim hash(31) As Byte
            Dim temp As Byte() = Hash_AES.ComputeHash(System.Text.ASCIIEncoding.ASCII.GetBytes(pass))
            Array.Copy(temp, 0, hash, 0, 16)
            Array.Copy(temp, 0, hash, 15, 16)
            AES.Key = hash
            AES.Mode = Security.Cryptography.CipherMode.ECB
            Dim DESDecrypter As System.Security.Cryptography.ICryptoTransform = AES.CreateDecryptor
            Dim Buffer As Byte() = Convert.FromBase64String(input)
            decrypted = System.Text.ASCIIEncoding.ASCII.GetString(DESDecrypter.TransformFinalBlock(Buffer, 0, Buffer.Length))
            Return decrypted
        Catch ex As Exception
            Return decrypted
        End Try
    End Function

    Public Function PegaNomeFantasiaEmpresa(ByVal codEmpresa As Integer) As String
        strSQL = "SELECT fantasia" & Chr(13) & Chr(10)
        strSQL = strSQL & "FROM Mvt_Menu.Empresa" & Chr(13) & Chr(10)
        strSQL = strSQL & "WHERE codEmpresa=" & codEmpresa & Chr(13) & Chr(10)
        Dim nome As String = ""
        Using dr As IDataReader = conexaoPadrao.ReturnDataReader(strSQL)
            While dr.Read
                nome = "" & dr("fantasia")
            End While
            dr.Close()
        End Using
        Return nome
    End Function

    ''' <summary>
    ''' Retorna nÛ equivalente de um treeView com a mesma estrutura do treeView ao qual o nodOriginal pertence
    ''' </summary>
    ''' <param name="nodOriginal">NÛ ao qual se busca o equivalente</param>
    ''' <param name="trwDestino">TreeView do qual se quer buscar o nÛ equivalente ao nodOriginal</param>
    ''' <returns>nÛ equivalente ao nodOriginal no trwDestino</returns>
    ''' <remarks></remarks>
    Public Function RetornarNoEquivalente(ByVal nodOriginal As Object, ByVal trwDestino As Object) As Object
        Dim nivel As Integer = 1
        If trwDestino.Nodes.Count > 0 Then
            Dim nodRetorno As Object = trwDestino.Nodes(0)

            While nivel <= nodOriginal.Level
                Dim nodBase As Object = nodOriginal

                While nodBase.Level <> nivel
                    nodBase = nodBase.Parent
                End While

                If nivel = 1 Then
                    nodRetorno = trwDestino.Nodes(nodBase.Index)
                Else
                    nodRetorno = nodRetorno.Nodes(nodBase.Index)
                End If

                nivel += 1
            End While

            Return nodRetorno
        Else
            Return Nothing
        End If

    End Function

    Function DeleteRows(showMessage As Boolean, nomeTabela As String, ByVal ParamArray primaryKeys() As Object) As String
        If (primaryKeys.Length Mod 2) > 0 Then
            If showMessage Then mMensagemErro("Quantidade inv·lida de par‚metros! Deve ser informado campo e valor.")
            Return "Quantidade inv·lida de par‚metros! Deve ser informado campo e valor."
        End If

        conexaoPadrao.NewTable(nomeTabela, True)

        For conta As Integer = 0 To primaryKeys.Length - 1 Step 2
            conexaoPadrao.InsertKey(primaryKeys(conta), primaryKeys(conta + 1))
        Next

        Dim erro As String = conexaoPadrao.ExecuteDelete(False)
        If erro <> "" Then
            If showMessage Then mMensagemErro("Erro ao remover na tabela " & nomeTabela & "!")
        End If

        Return erro

    End Function

    Function DeleteRows(nomeTabela As String, ByVal ParamArray primaryKeys() As Object) As String
        Return modFuncoes.DeleteRows(True, nomeTabela, primaryKeys)
    End Function

    Function SaveRow(nomeTabela As String, ByVal ParamArray campos() As Campos) As String
        Return modFuncoes.SaveRow(True, nomeTabela, campos)
    End Function

    Function SaveRow(showErrorMessage As Boolean, nomeTabela As String, ByVal ParamArray campos() As Campos) As String
        Dim strSQLVerif As String = "SELECT COUNT(0) FROM " & nomeTabela & " WHERE "
        For Each campo As Campos In campos
            If campo.Chave Then
                strSQLVerif &= campo.Nome & "=" & campo.Valor & " AND" & Chr(13) & Chr(10)
            End If
        Next
        strSQLVerif = strSQLVerif.Substring(0, strSQLVerif.Length - 6)
        Dim existente As Boolean = False
        Using dr As IDataReader = conexaoPadrao.ReturnDataReader(strSQLVerif)
            If dr.Read Then
                If mCInt(dr(0)) > 0 Then
                    existente = True
                End If
            End If
            dr.Close()
        End Using
        conexaoPadrao.NewTable(nomeTabela, existente)

        Dim algumField As Boolean = False
        For Each campo As Campos In campos
            If campo.Chave Then
                conexaoPadrao.InsertKey(campo.Nome, campo.Valor)
            Else
                algumField = True
                conexaoPadrao.InsertField(campo.Nome, campo.Valor, campo.Required)
            End If
        Next
        If Not algumField And existente Then
            'Throw New Exception("Nenhum campo que n„o seja chave informado e o registro È existente, ir· gerar erro!")
            Return "Nenhum campo que n„o seja chave informado e o registro È existente, ir· gerar erro!"
        End If

        Dim erro As String = conexaoPadrao.ExecuteInsertUpDate(False)
        If erro <> "" Then
            If showErrorMessage Then mMensagemErro("Erro ao salvar na tabela " & nomeTabela & "!")
        End If

        Return erro

    End Function

    Public Class Campos

        Public Sub New()
        End Sub

        Public Sub New(nome As String, valor As Object, chave As Boolean)
            Me.Nome = nome
            Me.Valor = valor
            Me.Chave = chave
            Me.Required = False
        End Sub

        Public Property Nome As String
        Public Property Valor As Object
        Public Property Chave As Boolean
        Public Property Required As Boolean
    End Class

    Public Function ToDescriptionString(value As [Enum]) As String
        Dim result As String = Nothing
        If value IsNot Nothing Then
            Dim type As Type = value.GetType()
            Dim field As FieldInfo = type.GetField(value.ToString())
            If field IsNot Nothing Then
                Dim attributes As DescriptionAttribute() = DirectCast(field.GetCustomAttributes(GetType(DescriptionAttribute), False), DescriptionAttribute())
                result = If(attributes.Length > 0, attributes(0).Description, [Enum].GetName(type, value))
            End If
        End If
        Return result
    End Function

    Public Function FromDescriptionString(Of T)(description As String) As [Enum]
        For Each item As [Enum] In [Enum].GetValues(GetType(T))
            If ToDescriptionString(item).Equals(description) Then
                Return item
            End If
        Next
        Return Nothing
    End Function

    Public Function FromDescriptionString(t As Type, description As String) As [Enum]
        For Each item As [Enum] In [Enum].GetValues(t)
            If ToDescriptionString(item).Equals(description) Then
                Return item
            End If
        Next
        Return Nothing
    End Function

    ''' <summary>
    ''' Retorna todos os pieces a partir de uma parte especÌfica
    ''' </summary>
    ''' <param name="texto"></param>
    ''' <param name="separador"></param>
    ''' <param name="parteInicial"></param>
    ''' <param name="parteFinal"></param>
    ''' <returns>Todo o texto, inclusive o separador, a partir da parte inicial</returns>
    ''' <remarks></remarks>
    Function GetPieces(ByVal texto As String, separador As String, parteInicial As Integer, Optional parteFinal As Integer = -1) As String
        Dim textoRet As String = ""
        Dim cont As Integer = 0
        For Each parte As String In texto.Split({separador}, StringSplitOptions.None)
            cont += 1
            If cont >= parteInicial AndAlso (cont <= parteFinal OrElse parteFinal = -1) Then
                If textoRet <> "" Then
                    textoRet &= separador
                End If
                textoRet &= parte
            End If
        Next
        Return textoRet
    End Function

    Public Function ObterIP()
        Dim host As System.Net.IPHostEntry
        Dim localIP As String = "?"
        host = System.Net.Dns.GetHostEntry(System.Net.Dns.GetHostName())
        For Each ip As System.Net.IPAddress In host.AddressList
            If (ip.AddressFamily = System.Net.Sockets.AddressFamily.InterNetwork) Then
                localIP = ip.ToString()
            End If
        Next
        Return localIP
    End Function

    Public Function GetIPServidor() As String
        Return getParametroStr("IPSERVIDOR")
    End Function

    Function ContarFeriadoFDS(conexao As MvtConnection.MvtConnection, ByVal dataInicial As Date, ByVal dataFinal As Date) As Integer
        Dim dataConta As Date = dataInicial
        Dim contaDias As Integer = 0
        While dataConta <= dataFinal
            If Not VerificaDiaUtilFeriados(dataConta, conexao) Then
                contaDias += 1
            End If
            dataConta = DateAdd(DateInterval.Day, 1, dataConta)
        End While
        Return contaDias
    End Function

    Public Function ObterServidor(codEmpresa As Integer, conexao As MvtConnection.MvtConnection) As String
        strSQL = "SELECT servidorSistema" & Chr(13) & Chr(10)
        strSQL = strSQL & "FROM Mvt_Menu.Empresa" & Chr(13) & Chr(10)
        strSQL = strSQL & "WHERE codEmpresa=" & codEmpresa & Chr(13) & Chr(10)
        Using dr As IDataReader = conexao.ReturnDataReader(strSQL)
            While dr.Read
                Return "" & dr("servidorSistema")
            End While
        End Using
        Return Nothing
    End Function

    Public Function IsDecimal(value As Object) As Boolean
        Return ((value - Math.Floor(value)) > 0.0)
    End Function

    Public Function GetAllFormNames(Optional ByVal type As Type = Nothing) As List(Of String)
        If type Is Nothing Then type = FormMenuType
        Dim mylist As New List(Of String)

        For Each t As Type In Assembly.GetEntryAssembly().GetTypes
            If type Is Nothing OrElse type.IsAssignableFrom(t) Then
                mylist.Add(t.Name)
            End If
        Next

        Return mylist
    End Function

    Public Function GetFormByName(ByVal formName As String) As Form
        Dim assemblyName As String = Assembly.GetEntryAssembly().GetName.Name.Replace(" ", "_")
        Dim myType As Type = Type.GetType(assemblyName & "." & formName)

        Try
            Return CType(Activator.CreateInstance(myType), Form)
        Catch ex As Exception
            Debug.WriteLine(ex)
            Return Nothing
        End Try
    End Function

    Public Function GetStringConectIni(nomeString As String) As String
        Dim strConn As String = String.Empty
        If System.IO.File.Exists("conect.xml") OrElse System.IO.File.Exists(Application.StartupPath & "\conect.xml") Then
            If Conect Is Nothing Then
                'Conect = MvtConnection.Conect.Iniciar("")
                fINIConexao()
            End If
            For Each prop As PropertyDescriptor In TypeDescriptor.GetProperties(Conect)
                If prop.Name = nomeString.Replace("[", "").Replace("]", "") Then
                    strConn = prop.GetValue(Conect)
                    Exit For
                End If
            Next
            If String.IsNullOrEmpty(strConn) Then
                strConn = Conect.GetCustomEntry(nomeString.Replace("[", "").Replace("]", ""))
            End If
        ElseIf IO.File.Exists(My.Computer.FileSystem.CurrentDirectory & "\Conect.ini") Then
            Dim strRead As New IO.StreamReader(My.Computer.FileSystem.CurrentDirectory & "\Conect.ini")
            Dim linha As String = strRead.ReadLine
            While linha <> ""
                If linha.StartsWith(nomeString) Then
                    strConn = linha.Replace(nomeString, "")
                    Exit While
                End If
                linha = strRead.ReadLine
            End While
        End If
        Return strConn
    End Function

    Public Function IsNullOrEmpty(value As Object) As Boolean
        Return String.IsNullOrEmpty(value & "")
    End Function

    Public Sub FormatarGrafico(grf)
        grf.ChartAreas(0).AxisX.Interval = 1
        grf.ChartAreas(0).AxisX.LabelStyle.Interval = 1
        grf.ChartAreas(0).AxisX.LabelStyle.IntervalOffset = 1
        For count As Integer = 0 To grf.Legends.Count - 1
            grf.Legends(count).Alignment = StringAlignment.Center
            grf.Legends(count).Docking = 1 'Dundas.Charting.WinControl.LegendDocking.Right
            grf.Legends(count).LegendStyle = 2 'Dundas.Charting.WinControl.LegendStyle.Table
            grf.Legends(count).TableStyle = 2 'Dundas.Charting.WinControl.LegendTableStyle.Tall
        Next
        grf.UI.Toolbar.Docking = 1 'Dundas.Charting.WinControl.ToolbarDocking.Bottom
    End Sub

    Public Sub AjustarGrafico(grf As Object, tresD As Boolean, seriesSaoValores As Boolean)
        grf.Palette = 12 'Dundas.Charting.WinControl.ChartColorPalette.Dundas
        grf.UI.Toolbar.BorderColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(105, Byte), Integer))
        grf.UI.Toolbar.BorderSkin.PageColor = System.Drawing.Color.Transparent
        grf.UI.Toolbar.BorderSkin.SkinStyle = 1 'Dundas.Charting.WinControl.BorderSkinStyle.Emboss
        grf.UI.Toolbar.Enabled = True
        For Each chartArea As Object In grf.ChartAreas
            If tresD Then
                chartArea.Area3DStyle.Enable3D = True
            End If
            chartArea.Area3DStyle.Light = 2 'Dundas.Charting.WinControl.LightStyle.Realistic
            chartArea.AxisX.MajorGrid.Enabled = False
        Next
        For Each serie As Object In grf.Series
            If seriesSaoValores Then
                serie.XValueType = 1 'Dundas.Charting.WinControl.ChartValueTypes.Double
            End If
        Next
        grf.ChartAreas(0).AxisX.IntervalType = 5 'Dundas.Charting.WinControl.DateTimeIntervalType.Days
        grf.ChartAreas(0).AxisX.IntervalOffsetType = 5 'Dundas.Charting.WinControl.DateTimeIntervalType.Days
        grf.ChartAreas(0).AxisX.Interval = 1
        grf.ChartAreas(0).AxisX.LabelStyle.Interval = 1
        grf.ChartAreas(0).AxisX.LabelStyle.IntervalOffset = 1
        grf.ChartAreas(0).AxisY.IntervalType = 1 'Dundas.Charting.WinControl.DateTimeIntervalType.Number
        'chtGeral.ChartAreas(0).AxisY.LabelStyle.Format = "C"
        grf.ChartAreas(0).AxisY.LabelStyle.Interval = 1
        grf.ChartAreas(0).AxisY.LabelStyle.IntervalOffset = 1
        grf.ChartAreas(0).AxisY.MinorGrid.IntervalOffset = grf.ChartAreas(0).AxisY.LabelStyle.IntervalOffset
        grf.ChartAreas(0).AxisY.MinorGrid.Interval = grf.ChartAreas(0).AxisY.LabelStyle.Interval
        grf.ChartAreas(0).AxisY.MajorGrid.IntervalOffset = grf.ChartAreas(0).AxisY.LabelStyle.IntervalOffset
        grf.ChartAreas(0).AxisY.MajorGrid.Interval = grf.ChartAreas(0).AxisY.LabelStyle.Interval
    End Sub

    Public Function listToSQLFilter(Of T)(lista As List(Of T), Optional useValueSqlString As Boolean = True) As String
        Dim filtro As String = String.Empty

        For Each item As T In lista
            Dim value As String = item.ToString
            If useValueSqlString Then
                value = ValueSQLString(value)
            End If

            If String.IsNullOrEmpty(filtro) Then
                filtro = value
            Else
                filtro = String.Format("{0},{1}", filtro, value)
            End If
        Next
        If Not String.IsNullOrEmpty(filtro) Then
            filtro = String.Format("({0})", filtro)
        End If

        Return filtro
    End Function

    Public Sub EnableDisableControls(obj As Object, enabled As Boolean)
        For Each item As Control In obj.Controls
            item.Enabled = enabled
        Next
    End Sub

    Public Function VerificaDiaUtilFeriadosMensagem(data As Date, Optional campo As String = "")
        If Not VerificaDiaUtilFeriados(data, conexaoPadrao, True) Then
            If Not String.IsNullOrEmpty(campo) Then
                campo = " no campo " & Replace(campo, ":", "")
            End If
            If data.DayOfWeek = DayOfWeek.Saturday Then
                mMensagemErro("Data informada" & campo & " È um s·bado")
            ElseIf data.DayOfWeek = DayOfWeek.Sunday Then
                mMensagemErro("Data informada" & campo & " È um domingo")
            Else
                mMensagemErro("Data informada" & campo & " È um feriado")
            End If
            Return False
        End If
        Return True
    End Function

    Public Sub ClonarTreeGridView(noOuTreeGridViewOrigem As Object, noOuTreeGridViewDestino As Object)
        If noOuTreeGridViewDestino.GetType.GetProperty("ColumnCount") IsNot Nothing AndAlso noOuTreeGridViewDestino.ColumnCount = 0 Then
            For Each colunaOrigem As Object In noOuTreeGridViewOrigem.Columns
                noOuTreeGridViewDestino.Columns.Add(colunaOrigem.Clone)
            Next
        End If
        For Each noOrigem As Object In noOuTreeGridViewOrigem.Nodes
            Dim noDestino As Object = CType(noOrigem.Clone, Object)
            noOuTreeGridViewDestino.Nodes.Add(noDestino)
            For Each cell As Object In noOrigem.Cells
                noDestino.Cells(cell.ColumnIndex).Value = cell.value
            Next
            ClonarTreeGridView(noOrigem, noDestino)
        Next
    End Sub

    Sub ChecaVersaoNova()
        Try
            Dim strSQL As String
            strSQL = "SELECT * FROM (" & Chr(13) & Chr(10)
            If conexaoPadrao.ActiveConnection <> MvtConnection.DataBase.ORACLE _
                AndAlso conexaoPadrao.ActiveConnection <> MvtConnection.DataBase.ORACLECLIENT Then
                strSQL = strSQL & "SELECT TOP 1 codVersao," & Chr(13) & Chr(10)
            Else
                strSQL = strSQL & "SELECT codVersao," & Chr(13) & Chr(10)
            End If
            strSQL = strSQL & "       data," & Chr(13) & Chr(10)
            strSQL = strSQL & "       hora" & Chr(13) & Chr(10)
            strSQL = strSQL & "FROM Mvt_Acesso.Versao" & Chr(13) & Chr(10)
            strSQL = strSQL & "ORDER BY data DESC, hora DESC" & Chr(13) & Chr(10)
            strSQL = strSQL & ") DADOS" & Chr(13) & Chr(10)
            If conexaoPadrao.ActiveConnection = MvtConnection.DataBase.ORACLE _
                OrElse conexaoPadrao.ActiveConnection = MvtConnection.DataBase.ORACLECLIENT Then
                strSQL = strSQL & "WHERE ROWNUM<=1" & Chr(13) & Chr(10)
            End If

            Using dr As IDataReader = conexaoPadrao.ReturnDataReader(strSQL)
                While dr.Read
                    strVersao = dr("codVersao") & ""
                    If IsDate(dr("data")) Then
                        strVersaoData = mCDate(dr("data"))
                    End If
                    Exit While
                End While
                dr.Close()
            End Using
        Catch ex As Exception
        End Try
    End Sub

    Function Ping(ByVal hostNameOrAddress As String, ByVal throwError As Boolean) As Boolean
        Dim result As Boolean = False
        Try
            result = My.Computer.Network.Ping(hostNameOrAddress)
        Catch ex As Exception
            Trace.WriteLine(ex)
            If throwError Then
                Throw
            End If
        End Try
        Return result
    End Function

    Sub ChecaArquivoNovo(nome As String)

        nome = Split(nome, " ")(0)
        If strRepositorio = "" Then
            Exit Sub
        End If
        If strRepositorio.ToUpper = Application.StartupPath.ToUpper Then
            Exit Sub
        End If

        If Not strRepositorio.ToLower.Contains("30.2") And Not strRepositorio.ToLower.Contains("28.10") Then
            Dim caminho As New Uri(strRepositorio)
            If Not modFuncoes.Ping(caminho.Host, False) Then
                Exit Sub
            End If
        End If

        If Not Directory.Exists(strRepositorio) Then
            Exit Sub
        End If

        If Not (nome.ToUpper Like "*BK*") And Not (nome Like "Atualizador*Movtech*") Then

            Dim dadosArqServidor As New System.IO.FileInfo(strRepositorio & "\" & nome)

            nome = Split(nome, "\")(UBound(Split(nome, "\")))

            If System.IO.File.Exists(Application.StartupPath & "\" & nome) Then

                Dim dadosArqLocal As New System.IO.FileInfo(Application.StartupPath & "\" & nome)
                If dadosArqLocal.LastWriteTime < dadosArqServidor.LastWriteTime Then
                    Try
                        System.IO.File.Delete(Application.StartupPath & "\" & nome)
                    Catch ex As Exception

                    End Try
                    Try
                        System.IO.File.Copy(strRepositorio & "\" & nome, Application.StartupPath & "\" & nome)

                    Catch ex As Exception

                    End Try
                End If
            Else
                Try
                    System.IO.File.Copy(strRepositorio & "\" & nome, Application.StartupPath & "\" & nome)

                Catch ex As Exception

                End Try

            End If
        End If

    End Sub

    Sub ShellMovtech(diretorio As String, nome As String, Optional Style As AppWinStyle = AppWinStyle.NormalFocus, Optional wait As Boolean = False, Optional timeout As Integer = -1)

        Dim nomeSemParametros As String = nome
        'se for passado diretorio em branco ser· usado o local do aplicativo
        If diretorio = "" Then
            diretorio = Application.StartupPath
        End If
        If nome.ToLower Like "*.exe *" Then
            nomeSemParametros = Split(nome, ".exe ")(0) & ".exe"
        End If
        'atualiza arquivo novo
        ChecaArquivoNovo(nomeSemParametros)

        Try
            Shell(Application.StartupPath & "\" & nome, Style, wait, timeout)
        Catch ex As Exception
            mMensagemErro("Aplicativo necess·rio n„o encontrado!")
        End Try

    End Sub

    Public Sub EhData(ByRef data As String, UseToday As Boolean)
        On Error Resume Next
        If data.Length > 10 Then
            data = ""
            Exit Sub
        End If
        If data = "" And UseToday = True Then
            data = Today
            Exit Sub
        End If
        If data = "" Then
            Exit Sub
        End If
        If data.IndexOf("/") < 0 Then
            If data.Length <= 2 Then
                data = data & "/" & Today.Month & "/" & Today.Year
            Else
                If data.Length = 3 Or data.Length = 5 Or data.Length = 7 Then
                    data = ""
                    Exit Sub
                Else
                    If data.Length = 4 Then
                        data = (Strings.Left(data, 2) & "/" & Strings.Right(data, 2) & "/" & Today.Year)
                    Else
                        If data.Length = 6 Then
                            data = (Strings.Left(data, 2) & "/" & Strings.Right(Strings.Left(data, 4), 2) & "/" & Strings.Right(data, 2))
                        Else

                            If data.Length = 8 Then
                                data = (Strings.Left(data, 2) & "/" & Strings.Right(Strings.Left(data, 4), 2) & "/" & Strings.Right(data, 4))
                            End If
                        End If
                    End If
                End If
            End If
        End If
        data = mCDate(data)
        If Err.Description <> "" Then
            data = ""
        End If
    End Sub

    Public Sub AjustaDataGridImpressao(tamanhoMinimo As Integer, ParamArray datagridsAjustar() As DataGridView)
        For Each dtgAjustar As DataGridView In datagridsAjustar
            If dtgAjustar.ColumnCount > 0 Then
                Dim totalWidth As Integer = dtgAjustar.Columns.GetColumnsWidth(DataGridViewElementStates.Displayed)
                If totalWidth < tamanhoMinimo Then
                    Dim diferenca As Integer = tamanhoMinimo - totalWidth
                    Dim ajustePorColuna As Integer = Math.Ceiling(diferenca / dtgAjustar.ColumnCount)
                    For Each dtgColuna As DataGridViewColumn In dtgAjustar.Columns
                        dtgColuna.Width += ajustePorColuna
                    Next
                End If
            End If
        Next
    End Sub

    ''' <summary>
    ''' Cria uma inst‚ncia de um execut·vel, assim n„o precisa criar o link do fonte
    ''' Assim quando for atualizado o execut·vel n„o precisa atualizar tambÈm os exe que ele t· linkado
    ''' </summary>
    ''' <param name="caminhoExecutavel">caminho do execut·vel</param>
    ''' <param name="nomeForm">nome do form a ser retornado</param>
    ''' <returns>o form</returns>
    ''' <remarks></remarks>
    Public Function CriarInstanciaExecutavel(caminhoExecutavel As String, nomeForm As String) As Object
        Dim infoArquivo As New FileInfo(caminhoExecutavel)
        If infoArquivo.Exists Then
            'readallbytes es la gambita para n„o precisar colocar como confi·vel nas configuraÁıes de internet
            Dim ass As Reflection.Assembly = Assembly.Load(System.IO.File.ReadAllBytes(caminhoExecutavel)) 'Reflection.Assembly.LoadFile(infoArquivo.FullName)
            Return ass.CreateInstance(nomeForm)
        Else
            MsgBox("Arquivo " & infoArquivo.Name & " n„o encontrado!", MsgBoxStyle.Critical, "MOV.TECH")
            Return Nothing
        End If
    End Function

    Public Sub SalvarOrdenacaoColunaGrid(grid As MvtWindowsForms.MvtDataGridView, Optional nomePrograma As String = "")
        If String.IsNullOrEmpty(nomePrograma) Then
            nomePrograma = My.Application.Info.AssemblyName
        End If
        conexaoPadrao.NewTable("Mvt_Menu.OrdemColunaGrid", True)
        conexaoPadrao.InsertKey("nomePrograma", ValueSQLString(nomePrograma))
        conexaoPadrao.InsertKey("nomeGrid", ValueSQLString(grid.Name))
        conexaoPadrao.InsertKey("usuario", ValueSQLString(strUsuarioLogado))
        conexaoPadrao.ExecuteDelete(False)
        For Each column As DataGridViewColumn In grid.Columns
            conexaoPadrao.NewTable("Mvt_Menu.OrdemColunaGrid", False)
            conexaoPadrao.InsertKey("nomePrograma", ValueSQLString(nomePrograma))
            conexaoPadrao.InsertKey("nomeGrid", ValueSQLString(grid.Name))
            conexaoPadrao.InsertKey("usuario", ValueSQLString(strUsuarioLogado))
            conexaoPadrao.InsertKey("nomeColuna", ValueSQLString(column.Name))
            conexaoPadrao.InsertField("displayIndex", column.DisplayIndex)
            conexaoPadrao.InsertField("visivel", getBinaryIntegerFromBoolean(column.Visible))
            conexaoPadrao.ExecuteInsertUpDate(False)
        Next
    End Sub

    Public Sub OrdenarColunaGrid(grid As MvtWindowsForms.MvtDataGridView, Optional nomePrograma As String = "")
        If String.IsNullOrEmpty(nomePrograma) Then
            nomePrograma = My.Application.Info.AssemblyName
        End If
        grid.AllowUserToOrderColumns = True
        Dim strSQL As String = "SELECT nomeColuna," & Chr(13) & Chr(10)
        strSQL = strSQL & "       displayIndex," & Chr(13) & Chr(10)
        strSQL = strSQL & "       visivel" & Chr(13) & Chr(10)
        strSQL = strSQL & "FROM Mvt_Menu.OrdemColunaGrid" & Chr(13) & Chr(10)
        strSQL = strSQL & "WHERE nomePrograma='" & nomePrograma & "'" & Chr(13) & Chr(10)
        strSQL = strSQL & "AND nomeGrid='" & grid.Name & "'" & Chr(13) & Chr(10)
        strSQL = strSQL & "AND usuario='" & strUsuarioLogado & "'" & Chr(13) & Chr(10)
        strSQL = strSQL & "ORDER BY displayIndex" & Chr(13) & Chr(10)
        Dim dt As DataTable = conexaoPadrao.ReturnDataTable(strSQL)
        Dim i As Integer = 0 'pra n„o saltear caso mude exclua uma coluna
        For Each row As DataRow In dt.Rows
            If grid.Columns.Contains(row("nomeColuna")) Then
                grid.Columns((row("nomeColuna") & "").ToString).DisplayIndex = i
                grid.Columns((row("nomeColuna") & "").ToString).Visible = getBooleanFromBinaryInteger(mCInt(row("visivel")))
                i += 1
            End If
        Next
    End Sub

    Public Sub ApagarOrdenacaoGrid(grid As MvtWindowsForms.MvtDataGridView, Optional nomePrograma As String = "")
        If String.IsNullOrEmpty(nomePrograma) Then
            nomePrograma = My.Application.Info.AssemblyName
        End If
        conexaoPadrao.NewTable("Mvt_Menu.OrdemColunaGrid", True)
        conexaoPadrao.InsertKey("nomePrograma", ValueSQLString(nomePrograma))
        conexaoPadrao.InsertKey("nomeGrid", ValueSQLString(grid.Name))
        conexaoPadrao.InsertKey("usuario", ValueSQLString(strUsuarioLogado))
        conexaoPadrao.ExecuteDelete(False)
    End Sub

    Public Function getVisibleDataGrids(parent As Object, Optional tagText As String = Nothing) As List(Of MvtWindowsForms.MvtDataGridView)
        Dim dtgs As New List(Of MvtWindowsForms.MvtDataGridView)
        For Each child As Object In parent.Controls
            Dim stringType As String = child.GetType.ToString
            If stringType = "MvtWindowsForms.MvtDataGridView" Then
                If child.Visible Then
                    If tagText = String.Empty OrElse tagText = child.Tag.ToString() Then
                        dtgs.Add(child)
                    End If
                End If
            ElseIf stringType = "MvtWindowsForms.TreeGridView" Then

                If child.Visible Then
                    If tagText = String.Empty OrElse tagText = child.Tag.ToString() Then
                        dtgs.Add(getDataGridFromDataGridTreeView(child))
                    End If
                End If
            Else
                dtgs.AddRange(getVisibleDataGrids(child))
            End If
        Next

        dtgs.Reverse()

        Return dtgs
    End Function

    Public Function GetValidFileName(fileName As String) As String
        Dim ret = Regex.Replace(fileName.Trim(), "[^A-Za-z0-9_. ]+", "")
        Return ret.Replace(" ", String.Empty)
    End Function

    Private _usuarioERP As String = String.Empty
    Public ReadOnly Property UsuarioERPUsuarioLogado As String
        Get
            If String.IsNullOrEmpty(_usuarioERP) Then
                _usuarioERP = ObterUsuarioERP(conexaoPadrao, strUsuarioLogado)
            End If
            If String.IsNullOrEmpty(_usuarioERP) Then
                Throw New Exception(String.Format("Usu·rio ERP n„o configurado para o usu·rio {0}", strUsuarioLogado))
            End If
            Return _usuarioERP
        End Get
    End Property

    Private Function ObterUsuarioERP(conexao As MvtConnection.MvtConnection, usuario As String) As String
        Dim strSQL As String = "SELECT codUsuarioERP" & Chr(13) & Chr(10)
        strSQL = strSQL & "FROM Mvt_Acesso.UsuarioERP" & Chr(13) & Chr(10)
        strSQL = strSQL & "WHERE usuario=" & ValueSQLString(usuario) & Chr(13) & Chr(10)
        Dim codUsuarioERP As String = String.Empty
        Using dr As IDataReader = conexao.ReturnDataReader(strSQL)
            If dr.Read Then
                codUsuarioERP = dr("codUsuarioERP") & ""
            End If
            dr.Close()
        End Using
        Return codUsuarioERP
    End Function

    Public Function ObterFantasiaEmpresa(Optional codEmpresa As Integer = 0) As String
        If codEmpresa <= 0 Then
            codEmpresa = modFuncoes.codEmpresa
        End If
        Dim fantasia As String = String.Empty
        Using dr As IDataReader = conexaoPadrao.ReturnDataReader("SELECT fantasia FROM Mvt_Menu.Empresa WHERE codEmpresa=" & codEmpresa)
            If dr.Read Then
                fantasia = dr("fantasia") & ""
            End If
            dr.Close()
        End Using
        Return fantasia
    End Function

    Public Function AddGridColumnIntegerID(dtg As DataGridView, nome As String, header As String, [readOnly] As Boolean) As Integer
        Return AddGridColumnDecimal(dtg, nome, header, -1, [readOnly], False)
    End Function

    Public Function AddGridColumnIntegerID(dtg As DataGridView, nome As String, header As String, [readOnly] As Boolean, frozen As Boolean) As Integer
        Return AddGridColumnDecimal(dtg, nome, header, -1, [readOnly], frozen)
    End Function

    Public Function AddGridColumnIntegerIDCentered(dtg As DataGridView, nome As String, header As String, [readOnly] As Boolean) As Integer
        Return AddGridColumnDecimal(dtg, nome, header, -1, [readOnly], False, DataGridViewContentAlignment.MiddleCenter)
    End Function

    Public Function AddGridColumnIntegerIDCentered(dtg As DataGridView, nome As String, header As String, [readOnly] As Boolean, frozen As Boolean) As Integer
        Return AddGridColumnDecimal(dtg, nome, header, -1, [readOnly], frozen, DataGridViewContentAlignment.MiddleCenter)
    End Function

    Public Function AddGridColumnInteger(dtg As DataGridView, nome As String, header As String, [readOnly] As Boolean) As Integer
        Return AddGridColumnDecimal(dtg, nome, header, 0, [readOnly], False)
    End Function

    Public Function AddGridColumnInteger(dtg As DataGridView, nome As String, header As String, [readOnly] As Boolean, frozen As Boolean) As Integer
        Return AddGridColumnDecimal(dtg, nome, header, 0, [readOnly], frozen)
    End Function

    Public Function AddGridColumnDecimal(dtg As DataGridView, nome As String, header As String, casasDecimais As Integer, [readOnly] As Boolean, Optional alignment As DataGridViewContentAlignment = DataGridViewContentAlignment.MiddleRight) As Integer
        Return AddGridColumnDecimal(dtg, nome, header, casasDecimais, [readOnly], False, alignment)
    End Function

    Public Function AddGridColumnDecimal(dtg As DataGridView, nome As String, header As String, casasDecimais As Integer, [readOnly] As Boolean, frozen As Boolean, Optional alignment As DataGridViewContentAlignment = DataGridViewContentAlignment.MiddleRight) As Integer
        Dim clmIdx = dtg.Columns.Add(nome, header)
        dtg.Columns(clmIdx).DefaultCellStyle.Alignment = alignment
        If casasDecimais <> -1 Then dtg.Columns(clmIdx).DefaultCellStyle.Format = String.Format("N{0}", casasDecimais)
        dtg.Columns(clmIdx).ReadOnly = [readOnly]
        dtg.Columns(clmIdx).Frozen = frozen
        Return clmIdx
    End Function

    Public Function AddGridColumnPercentage(dtg As DataGridView, nome As String, header As String, casasDecimais As Integer, [readOnly] As Boolean) As Integer
        Dim clmIdx = dtg.Columns.Add(nome, header)
        dtg.Columns(clmIdx).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dtg.Columns(clmIdx).DefaultCellStyle.Format = String.Format("P{0}", casasDecimais)
        dtg.Columns(clmIdx).ReadOnly = [readOnly]
        Return clmIdx
    End Function

    Public Function AddGridColumnDate(dtg As DataGridView, nome As String, header As String, [readOnly] As Boolean, Optional alignment As DataGridViewContentAlignment = DataGridViewContentAlignment.MiddleRight) As Integer
        Dim clmIdx = dtg.Columns.Add(nome, header)
        dtg.Columns(clmIdx).DefaultCellStyle.Alignment = alignment
        dtg.Columns(clmIdx).DefaultCellStyle.Format = "dd/MM/yyyy"
        dtg.Columns(clmIdx).ReadOnly = [readOnly]
        Return clmIdx
    End Function

    Public Function AddGridColumnDateTime(dtg As DataGridView, nome As String, header As String, [readOnly] As Boolean, Optional alignment As DataGridViewContentAlignment = DataGridViewContentAlignment.MiddleRight, Optional format As String = "dd/MM/yyyy hh:mm:ss") As Integer
        Dim clmIdx = dtg.Columns.Add(nome, header)
        dtg.Columns(clmIdx).DefaultCellStyle.Alignment = alignment
        dtg.Columns(clmIdx).DefaultCellStyle.Format = format
        dtg.Columns(clmIdx).ReadOnly = [readOnly]
        Return clmIdx
    End Function

    Public Function AddGridColumnText(dtg As DataGridView, nome As String, header As String, [readOnly] As Boolean) As Integer
        Return AddGridColumnText(dtg, nome, header, [readOnly], False)
    End Function

    Public Function AddGridColumnText(dtg As DataGridView, nome As String, header As String, [readOnly] As Boolean, frozen As Boolean) As Integer
        Dim clmIdx = dtg.Columns.Add(nome, header)
        dtg.Columns(clmIdx).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dtg.Columns(clmIdx).ReadOnly = [readOnly]
        dtg.Columns(clmIdx).Frozen = frozen
        Return clmIdx
    End Function

    Public Function AddGridColumnCode(dtg As DataGridView, nome As String, header As String, [readOnly] As Boolean, frozen As Boolean) As Integer
        Return AddGridColumnDecimal(dtg, nome, header, 0, [readOnly], frozen)
    End Function

    Public Function AddGridColumnCheckBox(dtg As DataGridView, nome As String, header As String, [readOnly] As Boolean) As Integer
        Dim chkClm As New DataGridViewCheckBoxColumn
        chkClm.Name = nome
        chkClm.HeaderText = header
        chkClm.ReadOnly = [readOnly]
        Return dtg.Columns.Add(chkClm)
    End Function

    Public Function AddGridColumnComboBox(dtg As DataGridView, nome As String, header As String, [readOnly] As Boolean, Optional items As Array = Nothing) As Integer
        Dim cbxClm As New DataGridViewComboBoxColumn
        cbxClm.Name = nome
        cbxClm.HeaderText = header
        cbxClm.ReadOnly = [readOnly]
        If items IsNot Nothing Then
            For Each item As Object In items
                cbxClm.Items.Add(item)
            Next
        End If
        Return dtg.Columns.Add(cbxClm)
    End Function

    Public Function AddGridColumnButton(dtg As DataGridView, nome As String, header As String) As Integer
        Return AddGridColumnButton(dtg, nome, header, "")
    End Function

    Public Function AddGridColumnButton(dtg As DataGridView, nome As String, header As String, defaultText As String) As Integer
        Dim btnClm As New DataGridViewButtonColumn
        btnClm.Name = nome
        btnClm.HeaderText = header
        AddHandler dtg.RowsAdded, Sub(sender As Object, e As DataGridViewRowsAddedEventArgs)
                                      If Not String.IsNullOrEmpty(defaultText) Then
                                          For i As Integer = e.RowIndex To e.RowIndex + e.RowCount - 1
                                              dtg(nome, i).Value = defaultText
                                          Next
                                      End If
                                  End Sub
        Return dtg.Columns.Add(btnClm)
    End Function

    Private Sub dtgButtonRowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs)
    End Sub

    Public Function RandomColor() As System.Drawing.Color
        Dim rand = New Random
        Dim r = rand.Next(0, 256)
        Threading.Thread.Sleep(10)
        Dim g = rand.Next(0, 256)
        Threading.Thread.Sleep(10)
        Dim b = rand.Next(0, 256)
        Return System.Drawing.Color.FromArgb(255, r, g, b)
    End Function

    Public Function ExecutarScriptCache(conexaoPadrao As MvtConnection.MvtConnection, script As String) As String
        Dim ret As String = -1
        Using dr As IDataReader = conexaoPadrao.ReturnDataReader("SELECT Mvt_Menu.Sys_ExecutaScript('" & script & "')")
            If dr.Read Then
                ret = dr(0) & ""
            End If
            dr.Close()
        End Using
        Return ret
    End Function

    Public Function ValidaCNPJCPF(ByVal cnpjcpf As String) As Boolean

        If ValidaCPF(cnpjcpf) Then
            Return True
        ElseIf ValidaCNPJ(cnpjcpf) Then
            Return True
        End If

        Return False
    End Function

    Public Function ValidaCPF(ByVal CPF As String) As Boolean
        Dim dadosArray() As String = {"11111111111", "22222222222", "33333333333", "44444444444", "55555555555", "66666666666", "77777777777", "88888888888", "99999999999"}
        Dim i, x, n1, n2 As Integer

        CPF = CPF.Trim
        CPF = CPF.Replace(".", "").Replace("-", "").Replace("/", "").Replace(" ", "")

        For i = 0 To dadosArray.Length - 1
            If CPF.Length <> 11 Or dadosArray(i).Equals(CPF) Then
                Return False
            End If
        Next
        For x = 0 To 1
            n1 = 0
            For i = 0 To 8 + x
                n1 = n1 + Val(CPF.Substring(i, 1)) * (10 + x - i)
            Next
            n2 = 11 - (n1 - (Int(n1 / 11) * 11))
            If n2 = 10 Or n2 = 11 Then n2 = 0

            If n2 <> Val(CPF.Substring(9 + x, 1)) Then
                Return False
            End If
        Next

        Return True
    End Function

    Private Function ValidaCNPJ(ByVal cnpj As String)
        Dim Numero(13) As Integer
        Dim soma As Integer
        Dim i As Integer
        Dim resultado1 As Integer
        Dim resultado2 As Integer
        Dim dadosArray() As String = {"11111111111", "22222222222", "33333333333", "44444444444", "55555555555", "66666666666", "77777777777", "88888888888", "99999999999"}

        cnpj = cnpj.Trim
        cnpj = cnpj.Replace(".", "").Replace("-", "").Replace("/", "").Replace(" ", "")
        For i = 0 To dadosArray.Length - 1
            If cnpj.Length <> 14 Or dadosArray(i).Equals(cnpj) Then
                Return False
            End If
        Next

        For i = 0 To Numero.Length - 1
            Numero(i) = CInt(cnpj.Substring(i, 1))
        Next
        soma = Numero(0) * 5 + Numero(1) * 4 + Numero(2) * 3 + Numero(3) * 2 + Numero(4) * 9 + Numero(5) * 8 + Numero(6) * 7 +
                   Numero(7) * 6 + Numero(8) * 5 + Numero(9) * 4 + Numero(10) * 3 + Numero(11) * 2
        soma = soma - (11 * (Int(soma / 11)))
        If soma = 0 Or soma = 1 Then
            resultado1 = 0
        Else
            resultado1 = 11 - soma
        End If

        If resultado1 = Numero(12) Then
            soma = Numero(0) * 6 + Numero(1) * 5 + Numero(2) * 4 + Numero(3) * 3 + Numero(4) * 2 + Numero(5) * 9 + Numero(6) * 8 +
                       Numero(7) * 7 + Numero(8) * 6 + Numero(9) * 5 + Numero(10) * 4 + Numero(11) * 3 + Numero(12) * 2
            soma = soma - (11 * (Int(soma / 11)))
            If soma = 0 Or soma = 1 Then
                resultado2 = 0
            Else
                resultado2 = 11 - soma
            End If
            If resultado2 = Numero(13) Then
                Return True
            Else
                Return False
            End If
        Else
            Return False
        End If

    End Function

#Region "Constantes"
    Public Const xlThemeColorDark1 As Integer = 1
    Public Const xl24HourClock As Integer = 33
    Public Const xl3DArea As Integer = -4098
    Public Const xl3DAreaStacked As Integer = 78
    Public Const xl3DAreaStacked100 As Integer = 79
    Public Const xl3DBar As Integer = -4099
    Public Const xl3DBarClustered As Integer = 60
    Public Const xl3DBarStacked As Integer = 61
    Public Const xl3DBarStacked100 As Integer = 62
    Public Const xl3DColumn As Integer = -4100
    Public Const xl3DColumnClustered As Integer = 54
    Public Const xl3DColumnStacked As Integer = 55
    Public Const xl3DColumnStacked100 As Integer = 56
    Public Const xl3DEffects1 As Integer = 13
    Public Const xl3DEffects2 As Integer = 14
    Public Const xl3DLine As Integer = -4101
    Public Const xl3DPie As Integer = -4102
    Public Const xl3DPieExploded As Integer = 70
    Public Const xl3DSurface As Integer = -4103
    Public Const xl4DigitYears As Integer = 43
    Public Const xlA1 As Integer = 1
    Public Const xlAbove As Integer = 0
    Public Const xlAbsolute As Integer = 1
    Public Const xlAbsRowRelColumn As Integer = 2
    Public Const xlAccounting1 As Integer = 4
    Public Const xlAccounting2 As Integer = 5
    Public Const xlAccounting3 As Integer = 6
    Public Const xlAccounting4 As Integer = 17
    Public Const xlAdd As Integer = 2
    Public Const xlAddIn As Integer = 18
    Public Const xlAll As Integer = -4104
    Public Const xlAllAtOnce As Integer = 2
    Public Const xlAllChanges As Integer = 2
    Public Const xlAllExceptBorders As Integer = 6
    Public Const xlAllFaces As Integer = 7
    Public Const xlAlternateArraySeparator As Integer = 16
    Public Const xlAnd As Integer = 1
    Public Const xlAnyGallery As Integer = 23
    Public Const xlArea As Integer = 1
    Public Const xlAreaStacked As Integer = 76
    Public Const xlAreaStacked100 As Integer = 77
    Public Const xlArrangeStyleCascade As Integer = 7
    Public Const xlArrangeStyleHorizontal As Integer = -4128
    Public Const xlArrangeStyleTiled As Integer = 1
    Public Const xlArrangeStyleVertical As Integer = -4166
    Public Const xlArrowHeadLengthLong As Integer = 3
    Public Const xlArrowHeadLengthMedium As Integer = -4138
    Public Const xlArrowHeadLengthShort As Integer = 1
    Public Const xlArrowHeadStyleClosed As Integer = 3
    Public Const xlArrowHeadStyleDoubleClosed As Integer = 5
    Public Const xlArrowHeadStyleDoubleOpen As Integer = 4
    Public Const xlArrowHeadStyleNone As Integer = -4142
    Public Const xlArrowHeadStyleOpen As Integer = 2
    Public Const xlArrowHeadWidthMedium As Integer = -4138
    Public Const xlArrowHeadWidthNarrow As Integer = 1
    Public Const xlArrowHeadWidthWide As Integer = 3
    Public Const xlAscending As Integer = 1
    Public Const xlAutoActivate As Integer = 3
    Public Const xlAutoClose As Integer = 2
    Public Const xlAutoDeactivate As Integer = 4
    Public Const xlAutoFill As Integer = 4
    Public Const xlAutomatic As Integer = -4105
    Public Const xlAutomaticScale As Integer = -4105
    Public Const xlAutomaticUpdate As Integer = 4
    Public Const xlAutoOpen As Integer = 1
    Public Const xlAverage As Integer = -4106
    Public Const xlAxis As Integer = 21
    Public Const xlAxisCrossesAutomatic As Integer = -4105
    Public Const xlAxisCrossesCustom As Integer = -4114
    Public Const xlAxisCrossesMaximum As Integer = 2
    Public Const xlAxisCrossesMinimum As Integer = 4
    Public Const xlAxisTitle As Integer = 17
    Public Const xlBackgroundAutomatic As Integer = -4105
    Public Const xlBackgroundOpaque As Integer = 3
    Public Const xlBackgroundTransparent As Integer = 2
    Public Const xlBar As Integer = 2
    Public Const xlBarClustered As Integer = 57
    Public Const xlBarOfPie As Integer = 71
    Public Const xlBarStacked As Integer = 58
    Public Const xlBarStacked100 As Integer = 59
    Public Const xlBelow As Integer = 1
    Public Const xlBetween As Integer = 1
    Public Const xlBidi As Integer = -5000
    Public Const xlBidiCalendar As Integer = 3
    Public Const xlBIFF As Integer = 2
    Public Const xlBitmap As Integer = 2
    Public Const xlBlanks As Integer = 4
    Public Const xlBMP As Integer = 1
    Public Const xlBoth As Integer = 1
    Public Const xlBottom As Integer = -4107
    Public Const xlBottom10Items As Integer = 4
    Public Const xlBottom10Percent As Integer = 6
    Public Const xlBox As Integer = 0
    Public Const xlBubble As Integer = 15
    Public Const xlBubble3DEffect As Integer = 87
    Public Const xlBuiltIn As Integer = 21
    Public Const xlButton As Integer = 15
    Public Const xlButtonControl As Integer = 0
    Public Const xlByColumns As Integer = 2
    Public Const xlByRows As Integer = 1
    Public Const xlCalculationAutomatic As Integer = -4105
    Public Const xlCalculationManual As Integer = -4135
    Public Const xlCalculationSemiautomatic As Integer = 2
    Public Const xlCancel As Integer = 1
    Public Const xlCap As Integer = 1
    Public Const xlCascade As Integer = 7
    Public Const xlCategory As Integer = 1
    Public Const xlCategoryScale As Integer = 2
    Public Const xlCellTypeAllFormatConditions As Integer = -4172
    Public Const xlCellTypeAllValidation As Integer = -4174
    Public Const xlCellTypeBlanks As Integer = 4
    Public Const xlCellTypeComments As Integer = -4144
    Public Const xlCellTypeConstants As Integer = 2
    Public Const xlCellTypeFormulas As Integer = -4123
    Public Const xlCellTypeLastCell As Integer = 11
    Public Const xlCellTypeSameFormatConditions As Integer = -4173
    Public Const xlCellTypeSameValidation As Integer = -4175
    Public Const xlCellTypeVisible As Integer = 12
    Public Const xlCellValue As Integer = 1
    Public Const xlCenter As Integer = -4108
    Public Const xlCenterAcrossSelection As Integer = 7
    Public Const xlCGM As Integer = 7
    Public Const xlChangeAttributes As Integer = 6
    Public Const xlChart As Integer = -4109
    Public Const xlChart4 As Integer = 2
    Public Const xlChartArea As Integer = 2
    Public Const xlChartAsWindow As Integer = 5
    Public Const xlChartInPlace As Integer = 4
    Public Const xlChartSeries As Integer = 17
    Public Const xlChartShort As Integer = 6
    Public Const xlChartTitle As Integer = 4
    Public Const xlChartTitles As Integer = 18
    Public Const xlCheckBox As Integer = 1
    Public Const xlChecker As Integer = 9
    Public Const xlChronological As Integer = 3
    Public Const xlCircle As Integer = 8
    Public Const xlClassic1 As Integer = 1
    Public Const xlClassic2 As Integer = 2
    Public Const xlClassic3 As Integer = 3
    Public Const xlClipboard As Integer = 3
    Public Const xlClipboardFormatBIFF As Integer = 8
    Public Const xlClipboardFormatBIFF2 As Integer = 18
    Public Const xlClipboardFormatBIFF3 As Integer = 20
    Public Const xlClipboardFormatBIFF4 As Integer = 30
    Public Const xlClipboardFormatBinary As Integer = 15
    Public Const xlClipboardFormatBitmap As Integer = 9
    Public Const xlClipboardFormatCGM As Integer = 13
    Public Const xlClipboardFormatCSV As Integer = 5
    Public Const xlClipboardFormatDIF As Integer = 4
    Public Const xlClipboardFormatDspText As Integer = 12
    Public Const xlClipboardFormatEmbeddedObject As Integer = 21
    Public Const xlClipboardFormatEmbedSource As Integer = 22
    Public Const xlClipboardFormatLink As Integer = 11
    Public Const xlClipboardFormatLinkSource As Integer = 23
    Public Const xlClipboardFormatLinkSourceDesc As Integer = 32
    Public Const xlClipboardFormatMovie As Integer = 24
    Public Const xlClipboardFormatNative As Integer = 14
    Public Const xlClipboardFormatObjectDesc As Integer = 31
    Public Const xlClipboardFormatObjectLink As Integer = 19
    Public Const xlClipboardFormatOwnerLink As Integer = 17
    Public Const xlClipboardFormatPICT As Integer = 2
    Public Const xlClipboardFormatPrintPICT As Integer = 3
    Public Const xlClipboardFormatRTF As Integer = 7
    Public Const xlClipboardFormatScreenPICT As Integer = 29
    Public Const xlClipboardFormatStandardFont As Integer = 28
    Public Const xlClipboardFormatStandardScale As Integer = 27
    Public Const xlClipboardFormatSYLK As Integer = 6
    Public Const xlClipboardFormatTable As Integer = 16
    Public Const xlClipboardFormatText As Integer = 0
    Public Const xlClipboardFormatToolFace As Integer = 25
    Public Const xlClipboardFormatToolFacePICT As Integer = 26
    Public Const xlClipboardFormatVALU As Integer = 1
    Public Const xlClipboardFormatWK1 As Integer = 10
    Public Const xlClosed As Integer = 3
    Public Const xlCodePage As Integer = 2
    Public Const xlColor1 As Integer = 7
    Public Const xlColor2 As Integer = 8
    Public Const xlColor3 As Integer = 9
    Public Const xlColorIndexAutomatic As Integer = -4105
    Public Const xlColorIndexNone As Integer = -4142
    Public Const xlColumn As Integer = 3
    Public Const xlColumnClustered As Integer = 51
    Public Const xlColumnField As Integer = 2
    Public Const xlColumnHeader As Integer = -4110
    Public Const xlColumnItem As Integer = 5
    Public Const xlColumnLabels As Integer = 2
    Public Const xlColumns As Integer = 2
    Public Const xlColumnSeparator As Integer = 14
    Public Const xlColumnStacked As Integer = 52
    Public Const xlColumnStacked100 As Integer = 53
    Public Const xlColumnThenRow As Integer = 2
    Public Const xlCombination As Integer = -4111
    Public Const xlCommand As Integer = 2
    Public Const xlCommandUnderlinesAutomatic As Integer = -4105
    Public Const xlCommandUnderlinesOff As Integer = -4146
    Public Const xlCommandUnderlinesOn As Integer = 1
    Public Const xlCommentAndIndicator As Integer = 1
    Public Const xlCommentIndicatorOnly As Integer = -1
    Public Const xlComments As Integer = -4144
    Public Const xlComplete As Integer = 4
    Public Const xlConeBarClustered As Integer = 102
    Public Const xlConeBarStacked As Integer = 103
    Public Const xlConeBarStacked100 As Integer = 104
    Public Const xlConeCol As Integer = 105
    Public Const xlConeColClustered As Integer = 99
    Public Const xlConeColStacked As Integer = 100
    Public Const xlConeColStacked100 As Integer = 101
    Public Const xlConeToMax As Integer = 5
    Public Const xlConeToPoint As Integer = 4
    Public Const xlConsolidation As Integer = 3
    Public Const xlConstant As Integer = 1
    Public Const xlConstants As Integer = 2
    Public Const xlContents As Integer = 2
    Public Const xlContext As Integer = -5002
    Public Const xlContinuous As Integer = 1
    Public Const xlCopy As Integer = 1
    Public Const xlCorner As Integer = 2
    Public Const xlCorners As Integer = 6
    Public Const xlCount As Integer = -4112
    Public Const xlCountNums As Integer = -4113
    Public Const xlCountryCode As Integer = 1
    Public Const xlCountrySetting As Integer = 2
    Public Const xlCreatorCode As Integer = 1480803660
    Public Const xlCrissCross As Integer = 16
    Public Const xlCross As Integer = 4
    Public Const xlCSV As Integer = 6
    Public Const xlCSVMac As Integer = 22
    Public Const xlCSVMSDOS As Integer = 24
    Public Const xlCSVWindows As Integer = 23
    Public Const xlCurrencyBefore As Integer = 37
    Public Const xlCurrencyCode As Integer = 25
    Public Const xlCurrencyDigits As Integer = 27
    Public Const xlCurrencyLeadingZeros As Integer = 40
    Public Const xlCurrencyMinusSign As Integer = 38
    Public Const xlCurrencyNegative As Integer = 28
    Public Const xlCurrencySpaceBefore As Integer = 36
    Public Const xlCurrencyTrailingZeros As Integer = 39
    Public Const xlCurrentPlatformText As Integer = -4158
    Public Const xlCustom As Integer = -4114
    Public Const xlCut As Integer = 2
    Public Const xlCylinder As Integer = 3
    Public Const xlCylinderBarClustered As Integer = 95
    Public Const xlCylinderBarStacked As Integer = 96
    Public Const xlCylinderBarStacked100 As Integer = 97
    Public Const xlCylinderCol As Integer = 98
    Public Const xlCylinderColClustered As Integer = 92
    Public Const xlCylinderColStacked As Integer = 93
    Public Const xlCylinderColStacked100 As Integer = 94
    Public Const xlDash As Integer = -4115
    Public Const xlDashDot As Integer = 4
    Public Const xlDashDotDot As Integer = 5
    Public Const xlDataAndLabel As Integer = 0
    Public Const xlDatabase As Integer = 1
    Public Const xlDataField As Integer = 4
    Public Const xlDataHeader As Integer = 3
    Public Const xlDataItem As Integer = 7
    Public Const xlDataLabel As Integer = 0
    Public Const xlDataLabelsShowBubbleSizes As Integer = 6
    Public Const xlDataLabelsShowLabel As Integer = 4
    Public Const xlDataLabelsShowLabelAndPercent As Integer = 5
    Public Const xlDataLabelsShowNone As Integer = -4142
    Public Const xlDataLabelsShowPercent As Integer = 3
    Public Const xlDataLabelsShowValue As Integer = 2
    Public Const xlDataOnly As Integer = 2
    Public Const xlDataSeriesLinear As Integer = -4132
    Public Const xlDataTable As Integer = 7
    Public Const xlDate As Integer = 2
    Public Const xlDateOrder As Integer = 32
    Public Const xlDateSeparator As Integer = 17
    Public Const xlDay As Integer = 1
    Public Const xlDayCode As Integer = 21
    Public Const xlDayLeadingZero As Integer = 42
    Public Const xlDays As Integer = 0
    Public Const xlDBF2 As Integer = 7
    Public Const xlDBF3 As Integer = 8
    Public Const xlDBF4 As Integer = 11
    Public Const xlDebugCodePane As Integer = 13
    Public Const xlDecimalSeparator As Integer = 3
    Public Const xlDefault As Integer = -4143
    Public Const xlDefaultAutoFormat As Integer = -1
    Public Const xlDelimited As Integer = 1
    Public Const xlDescending As Integer = 2
    Public Const xlDesktop As Integer = 9
    Public Const xlDiagonalDown As Integer = 5
    Public Const xlDiagonalUp As Integer = 6
    Public Const xlDialogActivate As Integer = 103
    Public Const xlDialogActiveCellFont As Integer = 476
    Public Const xlDialogAddChartAutoformat As Integer = 390
    Public Const xlDialogAddinManager As Integer = 321
    Public Const xlDialogAlignment As Integer = 43
    Public Const xlDialogApplyNames As Integer = 133
    Public Const xlDialogApplyStyle As Integer = 212
    Public Const xlDialogAppMove As Integer = 170
    Public Const xlDialogAppSize As Integer = 171
    Public Const xlDialogArrangeAll As Integer = 12
    Public Const xlDialogAssignToObject As Integer = 213
    Public Const xlDialogAssignToTool As Integer = 293
    Public Const xlDialogAttachText As Integer = 80
    Public Const xlDialogAttachToolbars As Integer = 323
    Public Const xlDialogAutoCorrect As Integer = 485
    Public Const xlDialogAxes As Integer = 78
    Public Const xlDialogBorder As Integer = 45
    Public Const xlDialogCalculation As Integer = 32
    Public Const xlDialogCellProtection As Integer = 46
    Public Const xlDialogChangeLink As Integer = 166
    Public Const xlDialogChartAddData As Integer = 392
    Public Const xlDialogChartLocation As Integer = 527
    Public Const xlDialogChartOptionsDataLabels As Integer = 505
    Public Const xlDialogChartOptionsDataTable As Integer = 506
    Public Const xlDialogChartSourceData As Integer = 541
    Public Const xlDialogChartTrend As Integer = 350
    Public Const xlDialogChartType As Integer = 526
    Public Const xlDialogChartWizard As Integer = 288
    Public Const xlDialogCheckboxProperties As Integer = 435
    Public Const xlDialogClear As Integer = 52
    Public Const xlDialogColorPalette As Integer = 161
    Public Const xlDialogColumnWidth As Integer = 47
    Public Const xlDialogCombination As Integer = 73
    Public Const xlDialogConditionalFormatting As Integer = 583
    Public Const xlDialogConsolidate As Integer = 191
    Public Const xlDialogCopyChart As Integer = 147
    Public Const xlDialogCopyPicture As Integer = 108
    Public Const xlDialogCreateNames As Integer = 62
    Public Const xlDialogCreatePublisher As Integer = 217
    Public Const xlDialogCustomizeToolbar As Integer = 276
    Public Const xlDialogCustomViews As Integer = 493
    Public Const xlDialogDataDelete As Integer = 36
    Public Const xlDialogDataLabel As Integer = 379
    Public Const xlDialogDataSeries As Integer = 40
    Public Const xlDialogDataValidation As Integer = 525
    Public Const xlDialogDefineName As Integer = 61
    Public Const xlDialogDefineStyle As Integer = 229
    Public Const xlDialogDeleteFormat As Integer = 111
    Public Const xlDialogDeleteName As Integer = 110
    Public Const xlDialogDemote As Integer = 203
    Public Const xlDialogDisplay As Integer = 27
    Public Const xlDialogEditboxProperties As Integer = 438
    Public Const xlDialogEditColor As Integer = 223
    Public Const xlDialogEditDelete As Integer = 54
    Public Const xlDialogEditionOptions As Integer = 251
    Public Const xlDialogEditSeries As Integer = 228
    Public Const xlDialogErrorbarX As Integer = 463
    Public Const xlDialogErrorbarY As Integer = 464
    Public Const xlDialogExtract As Integer = 35
    Public Const xlDialogFileDelete As Integer = 6
    Public Const xlDialogFileSharing As Integer = 481
    Public Const xlDialogFillGroup As Integer = 200
    Public Const xlDialogFillWorkgroup As Integer = 301
    Public Const xlDialogFilter As Integer = 447
    Public Const xlDialogFilterAdvanced As Integer = 370
    Public Const xlDialogFindFile As Integer = 475
    Public Const xlDialogFont As Integer = 26
    Public Const xlDialogFontProperties As Integer = 381
    Public Const xlDialogFormatAuto As Integer = 269
    Public Const xlDialogFormatChart As Integer = 465
    Public Const xlDialogFormatCharttype As Integer = 423
    Public Const xlDialogFormatFont As Integer = 150
    Public Const xlDialogFormatLegend As Integer = 88
    Public Const xlDialogFormatMain As Integer = 225
    Public Const xlDialogFormatMove As Integer = 128
    Public Const xlDialogFormatNumber As Integer = 42
    Public Const xlDialogFormatOverlay As Integer = 226
    Public Const xlDialogFormatSize As Integer = 129
    Public Const xlDialogFormatText As Integer = 89
    Public Const xlDialogFormulaFind As Integer = 64
    Public Const xlDialogFormulaGoto As Integer = 63
    Public Const xlDialogFormulaReplace As Integer = 130
    Public Const xlDialogFunctionWizard As Integer = 450
    Public Const xlDialogGallery3dArea As Integer = 193
    Public Const xlDialogGallery3dBar As Integer = 272
    Public Const xlDialogGallery3dColumn As Integer = 194
    Public Const xlDialogGallery3dLine As Integer = 195
    Public Const xlDialogGallery3dPie As Integer = 196
    Public Const xlDialogGallery3dSurface As Integer = 273
    Public Const xlDialogGalleryArea As Integer = 67
    Public Const xlDialogGalleryBar As Integer = 68
    Public Const xlDialogGalleryColumn As Integer = 69
    Public Const xlDialogGalleryCustom As Integer = 388
    Public Const xlDialogGalleryDoughnut As Integer = 344
    Public Const xlDialogGalleryLine As Integer = 70
    Public Const xlDialogGalleryPie As Integer = 71
    Public Const xlDialogGalleryRadar As Integer = 249
    Public Const xlDialogGalleryScatter As Integer = 72
    Public Const xlDialogGoalSeek As Integer = 198
    Public Const xlDialogGridlines As Integer = 76
    Public Const xlDialogInsert As Integer = 55
    Public Const xlDialogInsertHyperlink As Integer = 596
    Public Const xlDialogInsertNameLabel As Integer = 496
    Public Const xlDialogInsertObject As Integer = 259
    Public Const xlDialogInsertPicture As Integer = 342
    Public Const xlDialogInsertTitle As Integer = 380
    Public Const xlDialogLabelProperties As Integer = 436
    Public Const xlDialogListboxProperties As Integer = 437
    Public Const xlDialogMacroOptions As Integer = 382
    Public Const xlDialogMailEditMailer As Integer = 470
    Public Const xlDialogMailLogon As Integer = 339
    Public Const xlDialogMailNextLetter As Integer = 378
    Public Const xlDialogMainChart As Integer = 85
    Public Const xlDialogMainChartType As Integer = 185
    Public Const xlDialogMenuEditor As Integer = 322
    Public Const xlDialogMove As Integer = 262
    Public Const xlDialogNew As Integer = 119
    Public Const xlDialogNote As Integer = 154
    Public Const xlDialogObjectProperties As Integer = 207
    Public Const xlDialogObjectProtection As Integer = 214
    Public Const xlDialogOpen As Integer = 1
    Public Const xlDialogOpenLinks As Integer = 2
    Public Const xlDialogOpenMail As Integer = 188
    Public Const xlDialogOpenText As Integer = 441
    Public Const xlDialogOptionsCalculation As Integer = 318
    Public Const xlDialogOptionsChart As Integer = 325
    Public Const xlDialogOptionsEdit As Integer = 319
    Public Const xlDialogOptionsGeneral As Integer = 356
    Public Const xlDialogOptionsListsAdd As Integer = 458
    Public Const xlDialogOptionsTransition As Integer = 355
    Public Const xlDialogOptionsView As Integer = 320
    Public Const xlDialogOutline As Integer = 142
    Public Const xlDialogOverlay As Integer = 86
    Public Const xlDialogOverlayChartType As Integer = 186
    Public Const xlDialogPageSetup As Integer = 7
    Public Const xlDialogParse As Integer = 91
    Public Const xlDialogPasteNames As Integer = 58
    Public Const xlDialogPasteSpecial As Integer = 53
    Public Const xlDialogPatterns As Integer = 84
    Public Const xlDialogPhonetic As Integer = 538
    Public Const xlDialogPivotCalculatedField As Integer = 570
    Public Const xlDialogPivotCalculatedItem As Integer = 572
    Public Const xlDialogPivotFieldGroup As Integer = 433
    Public Const xlDialogPivotFieldProperties As Integer = 313
    Public Const xlDialogPivotFieldUngroup As Integer = 434
    Public Const xlDialogPivotShowPages As Integer = 421
    Public Const xlDialogPivotSolveOrder As Integer = 568
    Public Const xlDialogPivotTableOptions As Integer = 567
    Public Const xlDialogPivotTableWizard As Integer = 312
    Public Const xlDialogPlacement As Integer = 300
    Public Const xlDialogPrint As Integer = 8
    Public Const xlDialogPrinterSetup As Integer = 9
    Public Const xlDialogPrintPreview As Integer = 222
    Public Const xlDialogPromote As Integer = 202
    Public Const xlDialogProperties As Integer = 474
    Public Const xlDialogProtectDocument As Integer = 28
    Public Const xlDialogProtectSharing As Integer = 620
    Public Const xlDialogPushbuttonProperties As Integer = 445
    Public Const xlDialogReplaceFont As Integer = 134
    Public Const xlDialogRoutingSlip As Integer = 336
    Public Const xlDialogRowHeight As Integer = 127
    Public Const xlDialogRun As Integer = 17
    Public Const xlDialogSaveAs As Integer = 5
    Public Const xlDialogSaveCopyAs As Integer = 456
    Public Const xlDialogSaveNewObject As Integer = 208
    Public Const xlDialogSaveWorkbook As Integer = 145
    Public Const xlDialogSaveWorkspace As Integer = 285
    Public Const xlDialogScale As Integer = 87
    Public Const xlDialogScenarioAdd As Integer = 307
    Public Const xlDialogScenarioCells As Integer = 305
    Public Const xlDialogScenarioEdit As Integer = 308
    Public Const xlDialogScenarioMerge As Integer = 473
    Public Const xlDialogScenarioSummary As Integer = 311
    Public Const xlDialogScrollbarProperties As Integer = 420
    Public Const xlDialogSelectSpecial As Integer = 132
    Public Const xlDialogSendMail As Integer = 189
    Public Const xlDialogSeriesAxes As Integer = 460
    Public Const xlDialogSeriesOptions As Integer = 557
    Public Const xlDialogSeriesOrder As Integer = 466
    Public Const xlDialogSeriesShape As Integer = 504
    Public Const xlDialogSeriesX As Integer = 461
    Public Const xlDialogSeriesY As Integer = 462
    Public Const xlDialogSetBackgroundPicture As Integer = 509
    Public Const xlDialogSetPrintTitles As Integer = 23
    Public Const xlDialogSetUpdateStatus As Integer = 159
    Public Const xlDialogSheet As Integer = -4116
    Public Const xlDialogShowDetail As Integer = 204
    Public Const xlDialogShowToolbar As Integer = 220
    Public Const xlDialogSize As Integer = 261
    Public Const xlDialogSort As Integer = 39
    Public Const xlDialogSortSpecial As Integer = 192
    Public Const xlDialogSplit As Integer = 137
    Public Const xlDialogStandardFont As Integer = 190
    Public Const xlDialogStandardWidth As Integer = 472
    Public Const xlDialogStyle As Integer = 44
    Public Const xlDialogSubscribeTo As Integer = 218
    Public Const xlDialogSubtotalCreate As Integer = 398
    Public Const xlDialogSummaryInfo As Integer = 474
    Public Const xlDialogTable As Integer = 41
    Public Const xlDialogTabOrder As Integer = 394
    Public Const xlDialogTextToColumns As Integer = 422
    Public Const xlDialogUnhide As Integer = 94
    Public Const xlDialogUpdateLink As Integer = 201
    Public Const xlDialogVbaInsertFile As Integer = 328
    Public Const xlDialogVbaMakeAddin As Integer = 478
    Public Const xlDialogVbaProcedureDefinition As Integer = 330
    Public Const xlDialogView3d As Integer = 197
    Public Const xlDialogWindowMove As Integer = 14
    Public Const xlDialogWindowSize As Integer = 13
    Public Const xlDialogWorkbookAdd As Integer = 281
    Public Const xlDialogWorkbookCopy As Integer = 283
    Public Const xlDialogWorkbookInsert As Integer = 354
    Public Const xlDialogWorkbookMove As Integer = 282
    Public Const xlDialogWorkbookName As Integer = 386
    Public Const xlDialogWorkbookNew As Integer = 302
    Public Const xlDialogWorkbookOptions As Integer = 284
    Public Const xlDialogWorkbookProtect As Integer = 417
    Public Const xlDialogWorkbookTabSplit As Integer = 415
    Public Const xlDialogWorkbookUnhide As Integer = 384
    Public Const xlDialogWorkgroup As Integer = 199
    Public Const xlDialogWorkspace As Integer = 95
    Public Const xlDialogZoom As Integer = 256
    Public Const xlDiamond As Integer = 2
    Public Const xlDIF As Integer = 9
    Public Const xlDifferenceFrom As Integer = 2
    Public Const xlDirect As Integer = 1
    Public Const xlDisabled As Integer = 0
    Public Const xlDisplayShapes As Integer = -4104
    Public Const xlDistributed As Integer = -4117
    Public Const xlDivide As Integer = 5
    Public Const xlDoNotSaveChanges As Integer = 2
    Public Const xlDot As Integer = -4118
    Public Const xlDouble As Integer = -4119
    Public Const xlDoubleAccounting As Integer = 5
    Public Const xlDoubleClosed As Integer = 5
    Public Const xlDoubleOpen As Integer = 4
    Public Const xlDoubleQuote As Integer = 1
    Public Const xlDoughnut As Integer = -4120
    Public Const xlDoughnutExploded As Integer = 80
    Public Const xlDown As Integer = -4121
    Public Const xlDownBars As Integer = 20
    Public Const xlDownThenOver As Integer = 1
    Public Const xlDownward As Integer = -4170
    Public Const xlDrawingObject As Integer = 14
    Public Const xlDropDown As Integer = 2
    Public Const xlDropLines As Integer = 26
    Public Const xlDRW As Integer = 4
    Public Const xlDXF As Integer = 5
    Public Const xlEdgeBottom As Integer = 9
    Public Const xlEdgeLeft As Integer = 7
    Public Const xlEdgeRight As Integer = 10
    Public Const xlEdgeTop As Integer = 8
    Public Const xlEditBox As Integer = 3
    Public Const xlEditionDate As Integer = 2
    Public Const xlEnd As Integer = 2
    Public Const xlEndSides As Integer = 3
    Public Const xlEntireChart As Integer = 20
    Public Const xlEPS As Integer = 8
    Public Const xlEqual As Integer = 3
    Public Const xlErrDiv0 As Integer = 2007
    Public Const xlErrNA As Integer = 2042
    Public Const xlErrName As Integer = 2029
    Public Const xlErrNull As Integer = 2000
    Public Const xlErrNum As Integer = 2036
    Public Const xlErrorBarIncludeBoth As Integer = 1
    Public Const xlErrorBarIncludeMinusValues As Integer = 3
    Public Const xlErrorBarIncludeNone As Integer = -4142
    Public Const xlErrorBarIncludePlusValues As Integer = 2
    Public Const xlErrorBars As Integer = 9
    Public Const xlErrorBarTypeCustom As Integer = -4114
    Public Const xlErrorBarTypeFixedValue As Integer = 1
    Public Const xlErrorBarTypePercent As Integer = 2
    Public Const xlErrorBarTypeStDev As Integer = -4155
    Public Const xlErrorBarTypeStError As Integer = 4
    Public Const xlErrorHandler As Integer = 2
    Public Const xlErrors As Integer = 16
    Public Const xlErrRef As Integer = 2023
    Public Const xlErrValue As Integer = 2015
    Public Const xlExcel2 As Integer = 16
    Public Const xlExcel2FarEast As Integer = 27
    Public Const xlExcel3 As Integer = 29
    Public Const xlExcel4 As Integer = 33
    Public Const xlExcel4IntlMacroSheet As Integer = 4
    Public Const xlExcel4MacroSheet As Integer = 3
    Public Const xlExcel4Workbook As Integer = 35
    Public Const xlExcel5 As Integer = 39
    Public Const xlExcel7 As Integer = 39
    Public Const xlExcel9795 As Integer = 43
    Public Const xlExcelLinks As Integer = 1
    Public Const xlExcelMenus As Integer = 1
    Public Const xlExclusive As Integer = 3
    Public Const xlExponential As Integer = 5
    Public Const xlExpression As Integer = 2
    Public Const xlExtended As Integer = 3
    Public Const xlExternal As Integer = 2
    Public Const xlFill As Integer = 5
    Public Const xlFillCopy As Integer = 1
    Public Const xlFillDays As Integer = 5
    Public Const xlFillDefault As Integer = 0
    Public Const xlFillFormats As Integer = 3
    Public Const xlFillMonths As Integer = 7
    Public Const xlFillSeries As Integer = 2
    Public Const xlFillValues As Integer = 4
    Public Const xlFillWeekdays As Integer = 6
    Public Const xlFillWithAll As Integer = -4104
    Public Const xlFillWithContents As Integer = 2
    Public Const xlFillWithFormats As Integer = -4122
    Public Const xlFillYears As Integer = 8
    Public Const xlFilterCopy As Integer = 2
    Public Const xlFilterInPlace As Integer = 1
    Public Const xlFirst As Integer = 0
    Public Const xlFitToPage As Integer = 2
    Public Const xlFixedValue As Integer = 1
    Public Const xlFixedWidth As Integer = 2
    Public Const xlFloating As Integer = 5
    Public Const xlFloor As Integer = 23
    Public Const xlFormats As Integer = -4122
    Public Const xlFormula As Integer = 5
    Public Const xlFormulas As Integer = -4123
    Public Const xlFreeFloating As Integer = 3
    Public Const xlFront As Integer = 4
    Public Const xlFrontEnd As Integer = 6
    Public Const xlFrontSides As Integer = 5
    Public Const xlFullPage As Integer = 3
    Public Const xlFunction As Integer = 1
    Public Const xlGeneral As Integer = 1
    Public Const xlGeneralFormatName As Integer = 26
    Public Const xlGray16 As Integer = 17
    Public Const xlGray25 As Integer = -4124
    Public Const xlGray50 As Integer = -4125
    Public Const xlGray75 As Integer = -4126
    Public Const xlGray8 As Integer = 18
    Public Const xlGreater As Integer = 5
    Public Const xlGreaterEqual As Integer = 7
    Public Const xlGregorian As Integer = 2
    Public Const xlGrid As Integer = 15
    Public Const xlGridline As Integer = 22
    Public Const xlGroupBox As Integer = 4
    Public Const xlGrowth As Integer = 2
    Public Const xlGrowthTrend As Integer = 10
    Public Const xlGuess As Integer = 0
    Public Const xlHairline As Integer = 1
    Public Const xlHAlignCenter As Integer = -4108
    Public Const xlHAlignCenterAcrossSelection As Integer = 7
    Public Const xlHAlignDistributed As Integer = -4117
    Public Const xlHAlignFill As Integer = 5
    Public Const xlHAlignGeneral As Integer = 1
    Public Const xlHAlignJustify As Integer = -4130
    Public Const xlHAlignLeft As Integer = -4131
    Public Const xlHAlignRight As Integer = -4152
    Public Const xlHGL As Integer = 6
    Public Const xlHidden As Integer = 0
    Public Const xlHide As Integer = 3
    Public Const xlHigh As Integer = -4127
    Public Const xlHiLoLines As Integer = 25
    Public Const xlHindiNumerals As Integer = 3
    Public Const xlHiragana As Integer = 2
    Public Const xlHorizontal As Integer = -4128
    Public Const xlHourCode As Integer = 22
    Public Const xlIBeam As Integer = 3
    Public Const xlIcons As Integer = 1
    Public Const xlIMEModeAlpha As Integer = 8
    Public Const xlIMEModeAlphaFull As Integer = 7
    Public Const xlIMEModeDisable As Integer = 3
    Public Const xlIMEModeHangul As Integer = 10
    Public Const xlIMEModeHangulFull As Integer = 9
    Public Const xlIMEModeHiragana As Integer = 4
    Public Const xlIMEModeKatakana As Integer = 5
    Public Const xlIMEModeKatakanaHalf As Integer = 6
    Public Const xlIMEModeNoControl As Integer = 0
    Public Const xlIMEModeOff As Integer = 2
    Public Const xlIMEModeOn As Integer = 1
    Public Const xlImmediatePane As Integer = 12
    Public Const xlIndex As Integer = 9
    Public Const xlInfo As Integer = -4129
    Public Const xlInsertDeleteCells As Integer = 1
    Public Const xlInsertEntireRows As Integer = 2
    Public Const xlInside As Integer = 2
    Public Const xlInsideHorizontal As Integer = 12
    Public Const xlInsideVertical As Integer = 11
    Public Const xlInteger As Integer = 2
    Public Const xlInterpolated As Integer = 3
    Public Const xlInterrupt As Integer = 1
    Public Const xlIntlAddIn As Integer = 26
    Public Const xlIntlMacro As Integer = 25
    Public Const xlJustify As Integer = -4130
    Public Const xlKatakana As Integer = 1
    Public Const xlKatakanaHalf As Integer = 0
    Public Const xlLabel As Integer = 5
    Public Const xlLabelOnly As Integer = 1
    Public Const xlLabelPositionAbove As Integer = 0
    Public Const xlLabelPositionBelow As Integer = 1
    Public Const xlLabelPositionBestFit As Integer = 5
    Public Const xlLabelPositionCenter As Integer = -4108
    Public Const xlLabelPositionCustom As Integer = 7
    Public Const xlLabelPositionInsideBase As Integer = 4
    Public Const xlLabelPositionInsideEnd As Integer = 3
    Public Const xlLabelPositionLeft As Integer = -4131
    Public Const xlLabelPositionMixed As Integer = 6
    Public Const xlLabelPositionOutsideEnd As Integer = 2
    Public Const xlLabelPositionRight As Integer = -4152
    Public Const xlLandscape As Integer = 2
    Public Const xlLast As Integer = 1
    Public Const xlLastCell As Integer = 11
    Public Const xlLatin As Integer = -5001
    Public Const xlLeaderLines As Integer = 29
    Public Const xlLeft As Integer = -4131
    Public Const xlLeftBrace As Integer = 12
    Public Const xlLeftBracket As Integer = 10
    Public Const xlLeftToRight As Integer = 2
    Public Const xlLegend As Integer = 24
    Public Const xlLegendEntry As Integer = 12
    Public Const xlLegendKey As Integer = 13
    Public Const xlLegendPositionBottom As Integer = -4107
    Public Const xlLegendPositionCorner As Integer = 2
    Public Const xlLegendPositionLeft As Integer = -4131
    Public Const xlLegendPositionRight As Integer = -4152
    Public Const xlLegendPositionTop As Integer = -4160
    Public Const xlLess As Integer = 6
    Public Const xlLessEqual As Integer = 8
    Public Const xlLightDown As Integer = 13
    Public Const xlLightHorizontal As Integer = 11
    Public Const xlLightUp As Integer = 14
    Public Const xlLightVertical As Integer = 12
    Public Const xlLine As Integer = 4
    Public Const xlLinear As Integer = -4132
    Public Const xlLinearTrend As Integer = 9
    Public Const xlLineMarkers As Integer = 65
    Public Const xlLineMarkersStacked As Integer = 66
    Public Const xlLineMarkersStacked100 As Integer = 67
    Public Const xlLineStacked As Integer = 63
    Public Const xlLineStacked100 As Integer = 64
    Public Const xlLineStyleNone As Integer = -4142
    Public Const xlLinkInfoOLELinks As Integer = 2
    Public Const xlLinkInfoPublishers As Integer = 5
    Public Const xlLinkInfoSubscribers As Integer = 6
    Public Const xlLinkTypeExcelLinks As Integer = 1
    Public Const xlLinkTypeOLELinks As Integer = 2
    Public Const xlList1 As Integer = 10
    Public Const xlList2 As Integer = 11
    Public Const xlList3 As Integer = 12
    Public Const xlListBox As Integer = 6
    Public Const xlListSeparator As Integer = 5
    Public Const xlLocalFormat1 As Integer = 15
    Public Const xlLocalFormat2 As Integer = 16
    Public Const xlLocalSessionChanges As Integer = 2
    Public Const xlLocationAsNewSheet As Integer = 1
    Public Const xlLocationAsObject As Integer = 2
    Public Const xlLocationAutomatic As Integer = 3
    Public Const xlLogarithmic As Integer = -4133
    Public Const xlLogical As Integer = 4
    Public Const xlLogicalCursor As Integer = 1
    Public Const xlLong As Integer = 3
    Public Const xlLotusHelp As Integer = 2
    Public Const xlLow As Integer = -4134
    Public Const xlLowerCaseColumnLetter As Integer = 9
    Public Const xlLowerCaseRowLetter As Integer = 8
    Public Const xlLTR As Integer = -5003
    Public Const xlMacintosh As Integer = 1
    Public Const xlMacrosheetCell As Integer = 7
    Public Const xlMajorGridlines As Integer = 15
    Public Const xlManual As Integer = -4135
    Public Const xlManualUpdate As Integer = 5
    Public Const xlMAPI As Integer = 1
    Public Const xlMarkerStyleAutomatic As Integer = -4105
    Public Const xlMarkerStyleCircle As Integer = 8
    Public Const xlMarkerStyleDash As Integer = -4115
    Public Const xlMarkerStyleDiamond As Integer = 2
    Public Const xlMarkerStyleDot As Integer = -4118
    Public Const xlMarkerStyleNone As Integer = -4142
    Public Const xlMarkerStylePicture As Integer = -4147
    Public Const xlMarkerStylePlus As Integer = 9
    Public Const xlMarkerStyleSquare As Integer = 1
    Public Const xlMarkerStyleStar As Integer = 5
    Public Const xlMarkerStyleTriangle As Integer = 3
    Public Const xlMarkerStyleX As Integer = -4168
    Public Const xlMax As Integer = -4136
    Public Const xlMaximized As Integer = -4137
    Public Const xlMaximum As Integer = 2
    Public Const xlMDY As Integer = 44
    Public Const xlMedium As Integer = -4138
    Public Const xlMetric As Integer = 35
    Public Const xlMicrosoftAccess As Integer = 4
    Public Const xlMicrosoftFoxPro As Integer = 5
    Public Const xlMicrosoftMail As Integer = 3
    Public Const xlMicrosoftPowerPoint As Integer = 2
    Public Const xlMicrosoftProject As Integer = 6
    Public Const xlMicrosoftSchedulePlus As Integer = 7
    Public Const xlMicrosoftWord As Integer = 1
    Public Const xlMin As Integer = -4139
    Public Const xlMinimized As Integer = -4140
    Public Const xlMinimum As Integer = 4
    Public Const xlMinorGridlines As Integer = 16
    Public Const xlMinusValues As Integer = 3
    Public Const xlMinuteCode As Integer = 23
    Public Const xlMixed As Integer = 2
    Public Const xlMixedLabels As Integer = 3
    Public Const xlModule As Integer = -4141
    Public Const xlMonth As Integer = 3
    Public Const xlMonthCode As Integer = 20
    Public Const xlMonthLeadingZero As Integer = 41
    Public Const xlMonthNameChars As Integer = 30
    Public Const xlMonths As Integer = 1
    Public Const xlMove As Integer = 2
    Public Const xlMoveAndSize As Integer = 1
    Public Const xlMovingAvg As Integer = 6
    Public Const xlMSDOS As Integer = 3
    Public Const xlMultiply As Integer = 4
    Public Const xlNarrow As Integer = 1
    Public Const xlNext As Integer = 1
    Public Const xlNextToAxis As Integer = 4
    Public Const xlNo As Integer = 2
    Public Const xlNoAdditionalCalculation As Integer = -4143
    Public Const xlNoButton As Integer = 0
    Public Const xlNoButtonChanges As Integer = 1
    Public Const xlNoCap As Integer = 2
    Public Const xlNoChange As Integer = 1
    Public Const xlNoChanges As Integer = 4
    Public Const xlNoConversion As Integer = 3
    Public Const xlNoDockingChanges As Integer = 3
    Public Const xlNoDocuments As Integer = 3
    Public Const xlNoIndicator As Integer = 0
    Public Const xlNoLabels As Integer = -4142
    Public Const xlNoMailSystem As Integer = 0
    Public Const xlNoncurrencyDigits As Integer = 29
    Public Const xlNone As Integer = -4142
    Public Const xlNonEnglishFunctions As Integer = 34
    Public Const xlNoRestrictions As Integer = 0
    Public Const xlNormal As Integer = -4143
    Public Const xlNormalView As Integer = 1
    Public Const xlNorthwestArrow As Integer = 1
    Public Const xlNoSelection As Integer = -4142
    Public Const xlNoShapeChanges As Integer = 2
    Public Const xlNotBetween As Integer = 2
    Public Const xlNotEqual As Integer = 4
    Public Const xlNotes As Integer = -4144
    Public Const xlNothing As Integer = 28
    Public Const xlNotPlotted As Integer = 1
    Public Const xlNotpublic As Integer = 3
    Public Const xlNotYetReviewed As Integer = 3
    Public Const xlNotYetRouted As Integer = 0
    Public Const xlNumber As Integer = -4145
    Public Const xlNumbers As Integer = 1
    Public Const xlOff As Integer = -4146
    Public Const xlOLEControl As Integer = 2
    Public Const xlOLEEmbed As Integer = 1
    Public Const xlOLELink As Integer = 0
    Public Const xlOLELinks As Integer = 2
    Public Const xlOn As Integer = 1
    Public Const xlOneAfterAnother As Integer = 1
    Public Const xlOpaque As Integer = 3
    Public Const xlOpen As Integer = 2
    Public Const xlOpenSource As Integer = 3
    Public Const xlOptionButton As Integer = 7
    Public Const xlOr As Integer = 2
    Public Const xlOrigin As Integer = 3
    Public Const xlOtherSessionChanges As Integer = 3
    Public Const xlOutside As Integer = 3
    Public Const xlOverThenDown As Integer = 2
    Public Const xlOverwriteCells As Integer = 0
    Public Const xlPageBreakAutomatic As Integer = -4105
    Public Const xlPageBreakFull As Integer = 1
    Public Const xlPageBreakManual As Integer = -4135
    Public Const xlPageBreakPartial As Integer = 2
    Public Const xlPageBreakPreview As Integer = 2
    Public Const xlPageField As Integer = 3
    Public Const xlPageHeader As Integer = 2
    Public Const xlPageItem As Integer = 6
    Public Const xlPaper10x14 As Integer = 16
    Public Const xlPaper11x17 As Integer = 17
    Public Const xlPaperA3 As Integer = 8
    Public Const xlPaperA4 As Integer = 9
    Public Const xlPaperA4Small As Integer = 10
    Public Const xlPaperA5 As Integer = 11
    Public Const xlPaperB4 As Integer = 12
    Public Const xlPaperB5 As Integer = 13
    Public Const xlPaperCsheet As Integer = 24
    Public Const xlPaperDsheet As Integer = 25
    Public Const xlPaperEnvelope10 As Integer = 20
    Public Const xlPaperEnvelope11 As Integer = 21
    Public Const xlPaperEnvelope12 As Integer = 22
    Public Const xlPaperEnvelope14 As Integer = 23
    Public Const xlPaperEnvelope9 As Integer = 19
    Public Const xlPaperEnvelopeB4 As Integer = 33
    Public Const xlPaperEnvelopeB5 As Integer = 34
    Public Const xlPaperEnvelopeB6 As Integer = 35
    Public Const xlPaperEnvelopeC3 As Integer = 29
    Public Const xlPaperEnvelopeC4 As Integer = 30
    Public Const xlPaperEnvelopeC5 As Integer = 28
    Public Const xlPaperEnvelopeC6 As Integer = 31
    Public Const xlPaperEnvelopeC65 As Integer = 32
    Public Const xlPaperEnvelopeDL As Integer = 27
    Public Const xlPaperEnvelopeItaly As Integer = 36
    Public Const xlPaperEnvelopeMonarch As Integer = 37
    Public Const xlPaperEnvelopePersonal As Integer = 38
    Public Const xlPaperEsheet As Integer = 26
    Public Const xlPaperExecutive As Integer = 7
    Public Const xlPaperFanfoldLegalGerman As Integer = 41
    Public Const xlPaperFanfoldStdGerman As Integer = 40
    Public Const xlPaperFanfoldUS As Integer = 39
    Public Const xlPaperFolio As Integer = 14
    Public Const xlPaperLedger As Integer = 4
    Public Const xlPaperLegal As Integer = 5
    Public Const xlPaperLetter As Integer = 1
    Public Const xlPaperLetterSmall As Integer = 2
    Public Const xlPaperNote As Integer = 18
    Public Const xlPaperQuarto As Integer = 15
    Public Const xlPaperStatement As Integer = 6
    Public Const xlPaperTabloid As Integer = 3
    Public Const xlPaperUser As Integer = 256
    Public Const xlParamTypeBigInt As Integer = -5
    Public Const xlParamTypeBinary As Integer = -2
    Public Const xlParamTypeBit As Integer = -7
    Public Const xlParamTypeChar As Integer = 1
    Public Const xlParamTypeDate As Integer = 9
    Public Const xlParamTypeDecimal As Integer = 3
    Public Const xlParamTypeDouble As Integer = 8
    Public Const xlParamTypeFloat As Integer = 6
    Public Const xlParamTypeInteger As Integer = 4
    Public Const xlParamTypeLongVarBinary As Integer = -4
    Public Const xlParamTypeLongVarChar As Integer = -1
    Public Const xlParamTypeNumeric As Integer = 2
    Public Const xlParamTypeReal As Integer = 7
    Public Const xlParamTypeSmallInt As Integer = 5
    Public Const xlParamTypeTime As Integer = 10
    Public Const xlParamTypeTimestamp As Integer = 11
    Public Const xlParamTypeTinyInt As Integer = -6
    Public Const xlParamTypeUnknown As Integer = 0
    Public Const xlParamTypeVarBinary As Integer = -3
    Public Const xlParamTypeVarChar As Integer = 12
    Public Const xlPart As Integer = 2
    Public Const xlPartial As Integer = 3
    Public Const xlPasteAll As Integer = -4104
    Public Const xlPasteAllExceptBorders As Integer = 6
    Public Const xlPasteComments As Integer = -4144
    Public Const xlPasteFormats As Integer = -4122
    Public Const xlPasteFormulas As Integer = -4123
    Public Const xlPasteSpecialOperationAdd As Integer = 2
    Public Const xlPasteSpecialOperationDivide As Integer = 5
    Public Const xlPasteSpecialOperationMultiply As Integer = 4
    Public Const xlPasteSpecialOperationNone As Integer = -4142
    Public Const xlPasteSpecialOperationSubtract As Integer = 3
    Public Const xlPasteValues As Integer = -4163
    Public Const xlPatternAutomatic As Integer = -4105
    Public Const xlPatternChecker As Integer = 9
    Public Const xlPatternCrissCross As Integer = 16
    Public Const xlPatternDown As Integer = -4121
    Public Const xlPatternGray16 As Integer = 17
    Public Const xlPatternGray25 As Integer = -4124
    Public Const xlPatternGray50 As Integer = -4125
    Public Const xlPatternGray75 As Integer = -4126
    Public Const xlPatternGray8 As Integer = 18
    Public Const xlPatternGrid As Integer = 15
    Public Const xlPatternHorizontal As Integer = -4128
    Public Const xlPatternLightDown As Integer = 13
    Public Const xlPatternLightHorizontal As Integer = 11
    Public Const xlPatternLightUp As Integer = 14
    Public Const xlPatternLightVertical As Integer = 12
    Public Const xlPatternNone As Integer = -4142
    Public Const xlPatternSemiGray75 As Integer = 10
    Public Const xlPatternSolid As Integer = 1
    Public Const xlPatternUp As Integer = -4162
    Public Const xlPatternVertical As Integer = -4166
    Public Const xlPCT As Integer = 13
    Public Const xlPCX As Integer = 10
    Public Const xlPercent As Integer = 2
    Public Const xlPercentDifferenceFrom As Integer = 4
    Public Const xlPercentOf As Integer = 3
    Public Const xlPercentOfColumn As Integer = 7
    Public Const xlPercentOfRow As Integer = 6
    Public Const xlPercentOfTotal As Integer = 8
    Public Const xlPhoneticAlignCenter As Integer = 2
    Public Const xlPhoneticAlignDistributed As Integer = 3
    Public Const xlPhoneticAlignLeft As Integer = 1
    Public Const xlPhoneticAlignNoControl As Integer = 0
    Public Const xlPIC As Integer = 11
    Public Const xlPICT As Integer = 1
    Public Const xlPicture As Integer = -4147
    Public Const xlPie As Integer = 5
    Public Const xlPieExploded As Integer = 69
    Public Const xlPieOfPie As Integer = 68
    Public Const xlPinYin As Integer = 1
    Public Const xlPivotTable As Integer = -4148
    Public Const xlPlaceholders As Integer = 2
    Public Const xlPlotArea As Integer = 19
    Public Const xlPLT As Integer = 12
    Public Const xlPlus As Integer = 9
    Public Const xlPlusValues As Integer = 2
    Public Const xlPolynomial As Integer = 3
    Public Const xlPortrait As Integer = 1
    Public Const xlPower As Integer = 4
    Public Const xlPowerTalk As Integer = 2
    Public Const xlPrevious As Integer = 2
    Public Const xlPrimary As Integer = 1
    Public Const xlPrimaryButton As Integer = 1
    Public Const xlPrinter As Integer = 2
    Public Const xlPrintInPlace As Integer = 16
    Public Const xlPrintNoComments As Integer = -4142
    Public Const xlPrintSheetEnd As Integer = 1
    Public Const xlPriorityHigh As Integer = -4127
    Public Const xlPriorityLow As Integer = -4134
    Public Const xlPriorityNormal As Integer = -4143
    Public Const xlProduct As Integer = -4149
    Public Const xlPrompt As Integer = 0
    Public Const xlPublisher As Integer = 1
    Public Const xlPublishers As Integer = 5
    Public Const xlPyramidBarClustered As Integer = 109
    Public Const xlPyramidBarStacked As Integer = 110
    Public Const xlPyramidBarStacked100 As Integer = 111
    Public Const xlPyramidCol As Integer = 112
    Public Const xlPyramidColClustered As Integer = 106
    Public Const xlPyramidColStacked As Integer = 107
    Public Const xlPyramidColStacked100 As Integer = 108
    Public Const xlPyramidToMax As Integer = 2
    Public Const xlPyramidToPoint As Integer = 1
    Public Const xlR1C1 As Integer = -4150
    Public Const xlRadar As Integer = -4151
    Public Const xlRadarAxisLabels As Integer = 27
    Public Const xlRadarFilled As Integer = 82
    Public Const xlRadarMarkers As Integer = 81
    Public Const xlRange As Integer = 2
    Public Const xlRangeAutoFormat3DEffects1 As Integer = 13
    Public Const xlRangeAutoFormat3DEffects2 As Integer = 14
    Public Const xlRangeAutoFormatAccounting1 As Integer = 4
    Public Const xlRangeAutoFormatAccounting2 As Integer = 5
    Public Const xlRangeAutoFormatAccounting3 As Integer = 6
    Public Const xlRangeAutoFormatAccounting4 As Integer = 17
    Public Const xlRangeAutoFormatClassic1 As Integer = 1
    Public Const xlRangeAutoFormatClassic2 As Integer = 2
    Public Const xlRangeAutoFormatClassic3 As Integer = 3
    Public Const xlRangeAutoFormatColor1 As Integer = 7
    Public Const xlRangeAutoFormatColor2 As Integer = 8
    Public Const xlRangeAutoFormatColor3 As Integer = 9
    Public Const xlRangeAutoFormatList1 As Integer = 10
    Public Const xlRangeAutoFormatList2 As Integer = 11
    Public Const xlRangeAutoFormatList3 As Integer = 12
    Public Const xlRangeAutoFormatLocalFormat1 As Integer = 15
    Public Const xlRangeAutoFormatLocalFormat2 As Integer = 16
    Public Const xlRangeAutoFormatLocalFormat3 As Integer = 19
    Public Const xlRangeAutoFormatLocalFormat4 As Integer = 20
    Public Const xlRangeAutoFormatNone As Integer = -4142
    Public Const xlRangeAutoFormatSimple As Integer = -4154
    Public Const xlReadOnly As Integer = 3
    Public Const xlReadWrite As Integer = 2
    Public Const xlReference As Integer = 4
    Public Const xlRelative As Integer = 4
    Public Const xlRelRowAbsColumn As Integer = 3
    Public Const xlRight As Integer = -4152
    Public Const xlRightBrace As Integer = 13
    Public Const xlRightBracket As Integer = 11
    Public Const xlRoutingComplete As Integer = 2
    Public Const xlRoutingInProgress As Integer = 1
    Public Const xlRowField As Integer = 1
    Public Const xlRowHeader As Integer = -4153
    Public Const xlRowItem As Integer = 4
    Public Const xlRowLabels As Integer = 1
    Public Const xlRows As Integer = 1
    Public Const xlRowSeparator As Integer = 15
    Public Const xlRowThenColumn As Integer = 1
    Public Const xlRTF As Integer = 4
    Public Const xlRTL As Integer = -5004
    Public Const xlRunningTotal As Integer = 5
    Public Const xlSaveChanges As Integer = 1
    Public Const xlScale As Integer = 3
    Public Const xlScaleLinear As Integer = -4132
    Public Const xlScaleLogarithmic As Integer = -4133
    Public Const xlScreen As Integer = 1
    Public Const xlScreenSize As Integer = 1
    Public Const xlScrollBar As Integer = 8
    Public Const xlSecondary As Integer = 2
    Public Const xlSecondaryButton As Integer = 2
    Public Const xlSecondCode As Integer = 24
    Public Const xlSelect As Integer = 3
    Public Const xlSemiautomatic As Integer = 2
    Public Const xlSemiGray75 As Integer = 10
    Public Const xlSendPublisher As Integer = 2
    Public Const xlSeries As Integer = 3
    Public Const xlSeriesAxis As Integer = 3
    Public Const xlSeriesLines As Integer = 22
    Public Const xlShape As Integer = 14
    Public Const xlShared As Integer = 2
    Public Const xlSheetHidden As Integer = 0
    Public Const xlSheetVeryHidden As Integer = 2
    Public Const xlSheetVisible As Integer = -1
    Public Const xlShiftDown As Integer = -4121
    Public Const xlShiftToLeft As Integer = -4159
    Public Const xlShiftToRight As Integer = -4161
    Public Const xlShiftUp As Integer = -4162
    Public Const xlShort As Integer = 1
    Public Const xlShowLabel As Integer = 4
    Public Const xlShowLabelAndPercent As Integer = 5
    Public Const xlShowPercent As Integer = 3
    Public Const xlShowValue As Integer = 2
    Public Const xlSides As Integer = 1
    Public Const xlSimple As Integer = -4154
    Public Const xlSinceMyLastSave As Integer = 1
    Public Const xlSingle As Integer = 2
    Public Const xlSingleAccounting As Integer = 4
    Public Const xlSingleQuote As Integer = 2
    Public Const xlSizeIsArea As Integer = 1
    Public Const xlSizeIsWidth As Integer = 2
    Public Const xlSlantDashDot As Integer = 13
    Public Const xlSolid As Integer = 1
    Public Const xlSortColumns As Integer = 1
    Public Const xlSortLabels As Integer = 2
    Public Const xlSortRows As Integer = 2
    Public Const xlSortValues As Integer = 1
    Public Const xlSpinner As Integer = 9
    Public Const xlSplitByCustomSplit As Integer = 4
    Public Const xlSplitByPercentValue As Integer = 3
    Public Const xlSplitByPosition As Integer = 1
    Public Const xlSplitByValue As Integer = 2
    Public Const xlSquare As Integer = 1
    Public Const xlStack As Integer = 2
    Public Const xlStackScale As Integer = 3
    Public Const xlStandardSummary As Integer = 1
    Public Const xlStar As Integer = 5
    Public Const xlStDev As Integer = -4155
    Public Const xlStDevP As Integer = -4156
    Public Const xlStError As Integer = 4
    Public Const xlStockHLC As Integer = 88
    Public Const xlStockOHLC As Integer = 89
    Public Const xlStockVHLC As Integer = 90
    Public Const xlStockVOHLC As Integer = 91
    Public Const xlStretch As Integer = 1
    Public Const xlStrict As Integer = 2
    Public Const xlStroke As Integer = 2
    Public Const xlSubscriber As Integer = 2
    Public Const xlSubscribers As Integer = 6
    Public Const xlSubscribeToPicture As Integer = -4147
    Public Const xlSubscribeToText As Integer = -4158
    Public Const xlSubtract As Integer = 3
    Public Const xlSum As Integer = -4157
    Public Const xlSummaryAbove As Integer = 0
    Public Const xlSummaryBelow As Integer = 1
    Public Const xlSummaryOnLeft As Integer = -4131
    Public Const xlSummaryOnRight As Integer = -4152
    Public Const xlSummaryPivotTable As Integer = -4148
    Public Const xlSurface As Integer = 83
    Public Const xlSurfaceTopView As Integer = 85
    Public Const xlSurfaceTopViewWireframe As Integer = 86
    Public Const xlSurfaceWireframe As Integer = 84
    Public Const xlSYLK As Integer = 2
    Public Const xlSyllabary As Integer = 1
    Public Const xlSystem As Integer = 1
    Public Const xlTableBody As Integer = 8
    Public Const xlTabPositionFirst As Integer = 0
    Public Const xlTabPositionLast As Integer = 1
    Public Const xlTemplate As Integer = 17
    Public Const xlText As Integer = -4158
    Public Const xlTextBox As Integer = 16
    Public Const xlTextMac As Integer = 19
    Public Const xlTextMSDOS As Integer = 21
    Public Const xlTextPrinter As Integer = 36
    Public Const xlTextQualifierDoubleQuote As Integer = 1
    Public Const xlTextQualifierNone As Integer = -4142
    Public Const xlTextQualifierSingleQuote As Integer = 2
    Public Const xlTextValues As Integer = 2
    Public Const xlTextWindows As Integer = 20
    Public Const xlThick As Integer = 4
    Public Const xlThin As Integer = 2
    Public Const xlThousandsSeparator As Integer = 4
    Public Const xlTickLabelOrientationAutomatic As Integer = -4105
    Public Const xlTickLabelOrientationDownward As Integer = -4170
    Public Const xlTickLabelOrientationHorizontal As Integer = -4128
    Public Const xlTickLabelOrientationUpward As Integer = -4171
    Public Const xlTickLabelOrientationVertical As Integer = -4166
    Public Const xlTickLabelPositionHigh As Integer = -4127
    Public Const xlTickLabelPositionLow As Integer = -4134
    Public Const xlTickLabelPositionNextToAxis As Integer = 4
    Public Const xlTickLabelPositionNone As Integer = -4142
    Public Const xlTickMarkCross As Integer = 4
    Public Const xlTickMarkInside As Integer = 2
    Public Const xlTickMarkNone As Integer = -4142
    Public Const xlTickMarkOutside As Integer = 3
    Public Const xlTIF As Integer = 9
    Public Const xlTiled As Integer = 1
    Public Const xlTimeLeadingZero As Integer = 45
    Public Const xlTimeScale As Integer = 3
    Public Const xlTimeSeparator As Integer = 18
    Public Const xlTitleBar As Integer = 8
    Public Const xlToLeft As Integer = -4159
    Public Const xlToolbar As Integer = 1
    Public Const xlToolbarButton As Integer = 2
    Public Const xlToolbarProtectionNone As Integer = -4143
    Public Const xlTop As Integer = -4160
    Public Const xlTop10Items As Integer = 3
    Public Const xlTop10Percent As Integer = 5
    Public Const xlTopToBottom As Integer = 1
    Public Const xlToRight As Integer = -4161
    Public Const xlTransparent As Integer = 2
    Public Const xlTrendline As Integer = 8
    Public Const xlTriangle As Integer = 3
    Public Const xlUnderlineStyleDouble As Integer = -4119
    Public Const xlUnderlineStyleDoubleAccounting As Integer = 5
    Public Const xlUnderlineStyleNone As Integer = -4142
    Public Const xlUnderlineStyleSingle As Integer = 2
    Public Const xlUnderlineStyleSingleAccounting As Integer = 4
    Public Const xlUnlockedCells As Integer = 1
    Public Const xlUp As Integer = -4162
    Public Const xlUpBars As Integer = 18
    Public Const xlUpdateState As Integer = 1
    Public Const xlUpdateSubscriber As Integer = 2
    Public Const xlUpperCaseColumnLetter As Integer = 7
    Public Const xlUpperCaseRowLetter As Integer = 6
    Public Const xlUpward As Integer = -4171
    Public Const xlUserDefined As Integer = 22
    Public Const xlUserResolution As Integer = 1
    Public Const xlValidAlertInformation As Integer = 3
    Public Const xlValidAlertStop As Integer = 1
    Public Const xlValidAlertWarning As Integer = 2
    Public Const xlValidateCustom As Integer = 7
    Public Const xlValidateDate As Integer = 4
    Public Const xlValidateDecimal As Integer = 2
    Public Const xlValidateInputOnly As Integer = 0
    Public Const xlValidateList As Integer = 3
    Public Const xlValidateTextLength As Integer = 6
    Public Const xlValidateTime As Integer = 5
    Public Const xlValidateWholeNumber As Integer = 1
    Public Const xlVAlignBottom As Integer = -4107
    Public Const xlVAlignCenter As Integer = -4108
    Public Const xlVAlignDistributed As Integer = -4117
    Public Const xlVAlignJustify As Integer = -4130
    Public Const xlVAlignTop As Integer = -4160
    Public Const xlVALU As Integer = 8
    Public Const xlValue As Integer = 2
    Public Const xlValues As Integer = -4163
    Public Const xlVar As Integer = -4164
    Public Const xlVarP As Integer = -4165
    Public Const xlVerbOpen As Integer = 2
    Public Const xlVerbPrimary As Integer = 1
    Public Const xlVertical As Integer = -4166
    Public Const xlVeryHidden As Integer = 2
    Public Const xlVisible As Integer = 12
    Public Const xlVisualCursor As Integer = 2
    Public Const xlWait As Integer = 2
    Public Const xlWalls As Integer = 5
    Public Const xlWatchPane As Integer = 11
    Public Const xlWBATChart As Integer = -4109
    Public Const xlWBATExcel4IntlMacroSheet As Integer = 4
    Public Const xlWBATExcel4MacroSheet As Integer = 3
    Public Const xlWBATWorksheet As Integer = -4167
    Public Const xlWeekday As Integer = 2
    Public Const xlWeekdayNameChars As Integer = 31
    Public Const xlWhole As Integer = 1
    Public Const xlWide As Integer = 3
    Public Const xlWindows As Integer = 2
    Public Const xlWJ2WD1 As Integer = 14
    Public Const xlWJ3 As Integer = 40
    Public Const xlWJ3FJ3 As Integer = 41
    Public Const xlWK1 As Integer = 5
    Public Const xlWK1ALL As Integer = 31
    Public Const xlWK1FMT As Integer = 30
    Public Const xlWK3 As Integer = 15
    Public Const xlWK3FM3 As Integer = 32
    Public Const xlWK4 As Integer = 38
    Public Const xlWKS As Integer = 4
    Public Const xlWMF As Integer = 2
    Public Const xlWorkbook As Integer = 1
    Public Const xlWorkbookNormal As Integer = -4143
    Public Const xlWorkbookTab As Integer = 6
    Public Const xlWorks2FarEast As Integer = 28
    Public Const xlWorksheet As Integer = -4167
    Public Const xlWorksheet4 As Integer = 1
    Public Const xlWorksheetCell As Integer = 3
    Public Const xlWorksheetShort As Integer = 5
    Public Const xlWPG As Integer = 3
    Public Const xlWQ1 As Integer = 34
    Public Const xlX As Integer = -4168
    Public Const xlXErrorBars As Integer = 10
    Public Const xlXYScatter As Integer = -4169
    Public Const xlXYScatterLines As Integer = 74
    Public Const xlXYScatterLinesNoMarkers As Integer = 75
    Public Const xlXYScatterSmooth As Integer = 72
    Public Const xlXYScatterSmoothNoMarkers As Integer = 73
    Public Const xlY As Integer = 1
    Public Const xlYear As Integer = 4
    Public Const xlYearCode As Integer = 19
    Public Const xlYears As Integer = 2
    Public Const xlYErrorBars As Integer = 11
    Public Const xlYes As Integer = 1
    Public Const xlZero As Integer = 2
#End Region

End Module

Public Class ConfiguracaoEmail
    Private codEmpresaI As Integer = Nothing
    Private servidorI As String = Nothing
    Private enderecoI As String = Nothing
    Private exigeAutenticacaoI As Boolean = Nothing
    'Private senhaI As Security.SecureString = Nothing
    Private senhaI As String = Nothing

    Public Property CodEmpresa As Integer
        Get
            Return Me.codEmpresaI
        End Get
        Set(ByVal value As Integer)
            Me.codEmpresaI = value
        End Set
    End Property

    Public Property Servidor As String
        Get
            Return Me.servidorI
        End Get
        Set(ByVal value As String)
            Me.servidorI = value
        End Set
    End Property

    Public Property Endereco As String
        Get
            Return Me.enderecoI
        End Get
        Set(ByVal value As String)
            Me.enderecoI = value
        End Set
    End Property

    Public Property ExigeAutenticacao As Boolean
        Get
            Return Me.exigeAutenticacaoI
        End Get
        Set(ByVal value As Boolean)
            Me.exigeAutenticacaoI = value
        End Set
    End Property

    Public Property Senha As String
        Get
            Return Me.senhaI
        End Get
        Set(ByVal value As String)
            Me.senhaI = value
        End Set
    End Property

    Public Sub Validar()
        Dim erros As String = ""
        If Me.CodEmpresa = Nothing Then
            erros &= "CÛd. empresa n„o informado" & vbCrLf
        End If
        If Me.Servidor Is Nothing Or Me.Servidor = "" Then
            erros &= "Servidor n„o informado" & vbCrLf
        End If
        If Me.Endereco Is Nothing Or Me.Endereco = "" Then
            erros &= "EndereÁo n„o informado" & vbCrLf
        End If
        If Me.ExigeAutenticacao = Nothing Then
            erros &= "ExigÍncia de autenticaÁ„o n„o informada" & vbCrLf
        End If
        If Me.Senha Is Nothing Then
            erros &= "Senha n„o informada" & vbCrLf
        End If
        If erros <> "" Then
            Throw New MvtException(erros, False)
        End If
    End Sub

End Class

Public Class MvtException
    Inherits Exception

    Private isSQLExceptionI As Boolean

    Sub New(ByVal message As String)
        MyBase.New(message)
    End Sub

    Sub New(ByVal message As String, ByVal isSQLException As Boolean)
        MyBase.New(message)
        Me.IsSQLException = isSQLException
    End Sub

    Sub New(ByVal message As String, ByVal innerException As Exception)
        MyBase.New(message, innerException)
    End Sub

    Public Property IsSQLException As Boolean
        Get
            Return isSQLExceptionI
        End Get
        Set(ByVal value As Boolean)
            Me.isSQLExceptionI = value
        End Set
    End Property

End Class

Public Enum Genero
    Masculino
    Feminino
End Enum

Public Class MvtUsuario
    Property Usuario As String
    Property Nome As String
    Property Email As String
    Property CodGrupo As Integer
    Property NomeGrupo As String
    Property Tipo As String
    Property UsuarioAD As String
    Property Situacao As String
    Property Grupos As New Dictionary(Of Integer, String)
End Class