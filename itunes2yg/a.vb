Imports System.Xml.XPath

Public Class a
    Dim array As New List(Of Info)
    Sub New(filepath As String)

        ' 此调用是设计器所必需的。
        InitializeComponent()

        ' 在 InitializeComponent() 调用之后添加任何初始化。
        Dim xEle As XElement = XElement.Load(filepath)
        Dim xA = xEle.<dict>.<dict>
        For Each xe In xA(0).<dict>
            Dim x2 = xe.<key>
            Dim nam = "", writer = "", album = ""
            For Each x3 In x2
                Select Case x3.Value
                    Case "Name"
                        nam = XElement.Parse(x3.NextNode.ToString).Value
                    Case "Artist"
                        writer = XElement.Parse(x3.NextNode.ToString).Value
                    Case "Album"
                        album = XElement.Parse(x3.NextNode.ToString).Value
                End Select
            Next
            Dim item = New ListViewItem()
            item.SubItems.Add(New ListViewItem.ListViewSubItem(item, nam))
            item.SubItems.Add(New ListViewItem.ListViewSubItem(item, writer))
            item.SubItems.Add(New ListViewItem.ListViewSubItem(item, album))
            ListView1.Items.Add(item)
            array.Add(New Info With {.songName = nam, .songAlbum = album, .songSinger = writer})
        Next

    End Sub
End Class
Public Structure Info

    '''<summary>
    '''     歌曲名称
    '''</summary>
    Property songName() As String

    '''<summary>
    '''     歌手
    '''</summary>
    Property songSinger() As String

    '''<summary>
    '''     专辑
    '''</summary>
    Property songAlbum() As String
End Structure
