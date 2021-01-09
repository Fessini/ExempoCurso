Imports System.Windows.Forms
Imports System.Drawing
Imports System.IO
Imports System.Security.Cryptography
Imports Newtonsoft.Json
Imports System.Net
Imports System.Text

Public Class Utils
    ''' <summary>
    ''' Rotina padrão de mensagem de erro.
    ''' </summary>
    ''' <param name="mensagem">Mensagem de erro.</param>
    ''' <param name="ex">Erro.</param>
    Public Shared Sub TrataErro(ByVal mensagem As String, ByVal ex As Exception)
        MessageBox.Show(mensagem & vbNewLine & "Erro:" & vbNewLine &
                        ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub
    ''' <summary>
    ''' Transforma imagem para base 64.
    ''' </summary>
    ''' <param name="caminho">Caminho da imagem a ser transformada.</param>
    ''' <returns></returns>
    Public Shared Function ArquivoParaBase64(ByVal caminho As String) As String
        Try
            'LER O ARQUIVO PARA BYTES
            Dim arquivoBytes As Byte() = File.ReadAllBytes(caminho)

            'TRANSFORME EM BASE64
            Dim arquivoBase64 As String = Convert.ToBase64String(arquivoBytes)

            Return arquivoBase64

        Catch ex As Exception
            Throw ex
        End Try
    End Function
    ''' <summary>
    ''' Converte base 64 para imagem.
    ''' </summary>
    ''' <param name="base64">Base 64 a ser convertido.</param>
    ''' <returns></returns>
    Public Shared Function AbrirArquvioBase64(ByVal base64 As String) As Image
        Try
            'TRANSFORMA O TEXTO BASE64 EM BYTES
            Dim arquivoByte() As Byte = Convert.FromBase64String(base64)

            'TRANSFORMO O BYTES EM STREAM E DEPOIS E IMAGEM
            Dim ms As New MemoryStream(arquivoByte)
            Dim imagem As Image = Image.FromStream(ms)

            Return imagem
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    ''' <summary>
    ''' Busca um CEP.
    ''' </summary>
    ''' <param name="cep">Informe o CEP.</param>
    Public Shared Function PesquisaCEP(ByVal cep As String) As BUSCA_CEP
        Dim strEnd As String = String.Format("https://viacep.com.br/ws/{0}/json/", cep)
        Dim result As BUSCA_CEP

        Try
            Dim wc As New WebClient
            wc.Encoding = Encoding.UTF8
            Dim strJson As String = wc.DownloadString(strEnd)

            result = JsonConvert.DeserializeObject(Of BUSCA_CEP)(strJson)

            Return result
        Catch ex As Exception
            Throw ex
        End Try
    End Function
End Class
