Public Class Intro

    Dim PBoxLevel(1) As PictureBox
    Dim Level As Integer
    Public Slot As Integer
    Dim BtnS(2) As Button
    Public Language As Boolean = True

    Private Sub Intro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PBoxLevel(0) = PBoxL1
        PBoxLevel(1) = PBoxL2

        PBoxL1.Image = System.Drawing.Bitmap.FromFile("C:\Users\Selina\Documents\Visual Studio 2012\Projects\PictureBook\PictureBook\Resources\noahs_ark.jpg")
        PBoxL2.Image = System.Drawing.Bitmap.FromFile("C:\Users\Selina\Documents\Visual Studio 2012\Projects\PictureBook\PictureBook\Resources\garden_of_Eden.jpg")

        BtnS(0) = BtnS1
        BtnS(1) = BtnS2
        BtnS(2) = BtnS3
    End Sub

    Private Sub BtnStart_Click(sender As Object, e As EventArgs) Handles BtnStart.Click
        PnlMenu.Visible = False
        PnlSave.Visible = True
    End Sub

    Private Sub PBoxL_Click(sender As Object, e As EventArgs) Handles PBoxL1.Click, PBoxL2.Click
        sender.AccessibleDescription = "*"
        Dim y As Integer = 0

        'Finds which level was selected
        For x = 0 To UBound(PBoxLevel)
            If PBoxLevel(x).AccessibleDescription = "*" Then
                Level = x
                PBoxLevel(x).AccessibleDescription = ""
            End If
        Next

        Select Case Level
            Case 0
                Animal.Show()
                Me.Hide()

            Case 1
                Food.Show()
                Me.Hide()
        End Select
    End Sub

    Private Sub BtnReturn_Click(sender As Object, e As EventArgs) Handles BtnReturn.Click
        PnlMenu.Visible = True
        PnlLevel.Visible = False
    End Sub

    Private Sub BtnS_Click(sender As Object, e As EventArgs) Handles BtnS1.Click, BtnS2.Click, BtnS3.Click
        sender.AccessibleDescription = "*"
        For x = 0 To UBound(BtnS)
            If BtnS(x).AccessibleDescription = "*" Then
                Slot = x
            End If
        Next

        PnlSave.Visible = False
        PnlLevel.Visible = True
    End Sub

    Private Sub LlblOMWC_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LlblOMWC.LinkClicked
        ' Change the color of the link text by setting LinkVisited to True.
        LlblOMWC.LinkVisited = True
        ' Call the Process.Start method to open the default browser 
        ' with a URL:

        If Language = True Then
            System.Diagnostics.Process.Start("http://www.omwc.net/home-eng.html")
        Else
            System.Diagnostics.Process.Start("http://www.omwc.net/index.html")
        End If

    End Sub

    Private Sub Language_Click(sender As Object, e As EventArgs) Handles BtnLanguage.Click

        If BtnLanguage.Text = "中文" Then
            BtnLanguage.Text = "English"
            BtnStart.Text = "开始"
            LblOMWC.Text = "这个游戏是为了渥太华国语卫斯理教会创建的"
            LlblOMWC.Text = "点击这里了解更多" '??????
            BtnReturn.Text = "返回"
            LblSave.Text = "选择保存位置："
            LblLevel.Text = "选择一个关卡："
            LblL1.Text = "动物" 'CHEKC THIS
            LblL2.Text = "食物"

            For x = 0 To UBound(BtnS)
                BtnS(x).Text = "保存 " & (x + 1)
            Next
            Language = False
        Else
            BtnLanguage.Text = "中文"
            BtnStart.Text = "Begin"
            LblOMWC.Text = "This game was created for the Ottawa Mandarin Wesleyan Church"
            LlblOMWC.Text = "Click here to learn more"
            BtnReturn.Text = "Return"
            LblSave.Text = "Choose a save slot:"
            LblLevel.Text = "Select a Level:"
            LblL1.Text = "Noah's Ark of Animals"
            LblL2.Text = "Food from the Garden of Eden"

            For x = 0 To UBound(BtnS)
                BtnS(x).Text = "Save " & (x + 1)
            Next
            Language = True
        End If
    End Sub

    Private Sub Me_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If Language = False Then
            BtnLanguage.Text = "English"
            BtnStart.Text = "开始"
            LblOMWC.Text = "这个游戏是为了渥太华国语卫斯理教会创建的"
            LlblOMWC.Text = "点击这里了解更多" '??????
            BtnReturn.Text = "返回"
            LblSave.Text = "选择保存位置："
            LblLevel.Text = "选择一个关卡："
            LblL1.Text = ""
            LblL2.Text = ""

            For x = 0 To UBound(BtnS)
                BtnS(x).Text = "保存 " & (x + 1)
            Next
            Language = False
        Else
            BtnLanguage.Text = "中文"
            BtnStart.Text = "Begin"
            LblOMWC.Text = "This game was created for the Ottawa Mandarin Wesleyan Church"
            LlblOMWC.Text = "Click here to learn more"
            BtnReturn.Text = "Return"
            LblSave.Text = "Choose a save slot:"
            LblLevel.Text = "Select a Level:"
            LblL1.Text = "Noah's Ark of Animals"
            LblL2.Text = "Food from the Garden of Eden"

            For x = 0 To UBound(BtnS)
                BtnS(x).Text = "Save " & (x + 1)
            Next
            Language = True
        End If
    End Sub
End Class