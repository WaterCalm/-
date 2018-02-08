Imports System.Net
Imports System.IO
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Imports System.Text

Public Class Form1

    Private Sub Timer_SysTime_Tick(sender As Object, e As EventArgs) Handles Timer_SysTime.Tick
        Label_Time.Text = Format(DateTime.Now, "HH : mm : ss")
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        System.Diagnostics.Process.Start("http://eye.kuyun.com/web/")
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        System.Diagnostics.Process.Start("http://www.csm-huan.com/")
    End Sub

    Function GetData(URL As String, Cookies As String) As String
        Dim Req As HttpWebRequest
        Req = CType(Net.WebRequest.Create(URL), HttpWebRequest)
        Req.Method = "GET"
        'Req.Headers.Add("Accept", "text/html, application/xhtml+xml, image/jxr, */*")
        'Req.Headers.Add("Accept-Encoding", "gzip, deflate, br")
        'Req.Headers.Add("Host", "mp.weixin.qq.com")
        'Req.Headers.Add("Connection", "Keep-Alive")
        Req.KeepAlive = True
        Req.Headers.Add("Cookie", Cookies)

        Dim Rep As HttpWebResponse
        Try
            Rep = CType(Req.GetResponse(), HttpWebResponse)
            Dim LoginPOSTReqReader As New StreamReader(Rep.GetResponseStream())
            Dim TheRep As String = LoginPOSTReqReader.ReadToEnd
            Return TheRep
        Catch ex As Exception
            GetData = ""
            MsgBox("连接失败！", , "错误")
        End Try

    End Function

    Function PostData(URL As String, Data As String) As String

        Dim encoding As New UTF8Encoding
        Dim byteData As Byte() = encoding.GetBytes(Data)

        Dim Req As HttpWebRequest
        Req = CType(Net.WebRequest.Create(URL), HttpWebRequest)
        Req.Method = "Post"
        'Req.Headers.Add("Accept", "text/html, application/xhtml+xml, image/jxr, */*")
        'Req.Headers.Add("Accept-Encoding", "gzip, deflate, br")
        'Req.Headers.Add("Host", "mp.weixin.qq.com")
        'Req.Headers.Add("Connection", "Keep-Alive")
        Req.KeepAlive = True
        Req.ContentType = "application/x-www-form-urlencoded; charset=UTF-8"
        Req.ContentLength = Data.Length

        Dim POSTReqStream As Stream = Req.GetRequestStream()
        POSTReqStream.Write(byteData, 0, byteData.Length)
        POSTReqStream.Close()

        Dim Rep As HttpWebResponse
        Try
            Rep = CType(Req.GetResponse(), HttpWebResponse)
            Dim POSTReqReader As New StreamReader(Rep.GetResponseStream())
            Dim TheRep As String = POSTReqReader.ReadToEnd
            Return TheRep
        Catch ex As Exception
            PostData = ""
            MsgBox("连接失败！", , "错误")
        End Try

    End Function

    Function ReadJsonFile(Path As String) As String
        ReadJsonFile = ""
        If IO.File.Exists(Path) = True Then
            Dim JsonReader As IO.StreamReader = New IO.StreamReader(Path, System.Text.Encoding.Default)
            ReadJsonFile = JsonReader.ReadToEnd
            JsonReader.Close()
        Else
            MsgBox("未找到节目ID配置文件"， MsgBoxStyle.OkOnly, "错误")
            ReadJsonFile = ""
        End If
    End Function

    Sub ListChannel()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox2.Text = GetData(TextBox1.Text, "")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox2.Text = PostData(TextBox_CSMLink.Text, TextBox3.Text)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox2.Text = ReadJsonFile(Application.StartupPath & "\ChannelData.json")
    End Sub
End Class
