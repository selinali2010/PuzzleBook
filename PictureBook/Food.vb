
Public Class Food
    Dim m_MouseIsDown As Boolean
    Public Language As Boolean
    Dim Picture, Blank, Fruit(2), FruitB(2), Veggie(2), VeggieB(2), Dessert(2), DessertB(2) As Bitmap
    Dim PBoxSticker(2), PBoxBlank(8), PBoxLevel(2) As PictureBox
    Dim int, Level, Save(8) As Integer
    Dim saveFiles(2), WavE(8), WavC(8), nameText(8), NameE, NameC(8) As String
    Dim LblName(8) As Label
    Public Slot As Integer

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As  _
System.EventArgs) Handles MyBase.Load

        'save slot locations
        saveFiles(0) = "C:\Users\Selina\Documents\Visual Studio 2012\Projects\PictureBook\PictureBook\Resources\Food\Food1.txt"
        saveFiles(1) = "C:\Users\Selina\Documents\Visual Studio 2012\Projects\PictureBook\PictureBook\Resources\Food\Food2.txt"
        saveFiles(2) = "C:\Users\Selina\Documents\Visual Studio 2012\Projects\PictureBook\PictureBook\Resources\Food\Food3.txt"
        'nameText file locations
        NameE = "C:\Users\Selina\Documents\Visual Studio 2012\Projects\PictureBook\PictureBook\Resources\Food\NameE.txt"
        NameC(0) = "苹果"
        NameC(1) = "西瓜"
        NameC(2) = "柠檬"
        NameC(3) = "胡萝卜"
        NameC(4) = "土豆"
        NameC(5) = "西红柿"
        NameC(6) = "冰淇淋"
        NameC(7) = "糕点"
        NameC(8) = "圣代"

        'audio files
        WavE(0) = "D:\ITGS_selina\Food\appleE.wav"
        WavE(1) = "D:\ITGS_selina\Food\watermelonE.wav"
        WavE(2) = "D:\ITGS_selina\Food\lemonE.wav"
        WavE(3) = "D:\ITGS_selina\Food\carrotE.wav"
        WavE(4) = "D:\ITGS_selina\Food\potatoE.wav"
        WavE(5) = "D:\ITGS_selina\Food\tomatoE.wav"
        WavE(6) = "D:\ITGS_selina\Food\icecreamE.wav"
        WavE(7) = "D:\ITGS_selina\Food\pastryE.wav"
        WavE(8) = "D:\ITGS_selina\Food\sundaeE.wav"

        WavC(0) = "D:\ITGS_selina\Food\appleC.wav"
        WavC(1) = "D:\ITGS_selina\Food\watermelonC.wav"
        WavC(2) = "D:\ITGS_selina\Food\lemonC.wav"
        WavC(3) = "D:\ITGS_selina\Food\carrotC.wav"
        WavC(4) = "D:\ITGS_selina\Food\potatoC.wav"
        WavC(5) = "D:\ITGS_selina\Food\tomatoC.wav"
        WavC(6) = "D:\ITGS_selina\Food\icecreamC.wav"
        WavC(7) = "D:\ITGS_selina\Food\pastryC.wav"
        WavC(8) = "D:\ITGS_selina\Food\sundaeC.wav"

        'Levels
        PBoxLevel(0) = PBoxL1
        PBoxLevel(1) = PBoxL2
        PBoxLevel(2) = PBoxL3

        'Sticker
        PBoxSticker(0) = PBoxS1
        PBoxSticker(1) = PBoxS2
        PBoxSticker(2) = PBoxS3

        'Blanks
        PBoxBlank(0) = PBox1
        PBoxBlank(1) = PBox2
        PBoxBlank(2) = PBox3
        PBoxBlank(3) = PBox4
        PBoxBlank(4) = PBox5
        PBoxBlank(5) = PBox6
        PBoxBlank(6) = PBox7
        PBoxBlank(7) = PBox8
        PBoxBlank(8) = PBox9

        'Labels
        LblName(0) = Lbl1
        LblName(1) = Lbl2
        LblName(2) = Lbl3
        LblName(3) = Lbl4
        LblName(4) = Lbl5
        LblName(5) = Lbl6
        LblName(6) = Lbl7
        LblName(7) = Lbl8
        LblName(8) = Lbl9

        'Photos
        Fruit(0) = System.Drawing.Bitmap.FromFile("C:\Users\Selina\Documents\Visual Studio 2012\Projects\PictureBook\PictureBook\Resources\Food\fruits_apple.png")
        Fruit(1) = System.Drawing.Bitmap.FromFile("C:\Users\Selina\Documents\Visual Studio 2012\Projects\PictureBook\PictureBook\Resources\Food\fruits_watermelon.png")
        Fruit(2) = System.Drawing.Bitmap.FromFile("C:\Users\Selina\Documents\Visual Studio 2012\Projects\PictureBook\PictureBook\Resources\Food\fruits_lemon.png")
        FruitB(0) = System.Drawing.Bitmap.FromFile("C:\Users\Selina\Documents\Visual Studio 2012\Projects\PictureBook\PictureBook\Resources\Food\fruits_apple_blank.png")
        FruitB(1) = System.Drawing.Bitmap.FromFile("C:\Users\Selina\Documents\Visual Studio 2012\Projects\PictureBook\PictureBook\Resources\Food\fruits_watermelon_blank.png")
        FruitB(2) = System.Drawing.Bitmap.FromFile("C:\Users\Selina\Documents\Visual Studio 2012\Projects\PictureBook\PictureBook\Resources\Food\fruits_lemon_blank.png")

        Veggie(0) = System.Drawing.Bitmap.FromFile("C:\Users\Selina\Documents\Visual Studio 2012\Projects\PictureBook\PictureBook\Resources\Food\vegetables_carrot.png")
        Veggie(1) = System.Drawing.Bitmap.FromFile("C:\Users\Selina\Documents\Visual Studio 2012\Projects\PictureBook\PictureBook\Resources\Food\vegetables_potato.png")
        Veggie(2) = System.Drawing.Bitmap.FromFile("C:\Users\Selina\Documents\Visual Studio 2012\Projects\PictureBook\PictureBook\Resources\Food\vegetables_tomato.png")
        VeggieB(0) = System.Drawing.Bitmap.FromFile("C:\Users\Selina\Documents\Visual Studio 2012\Projects\PictureBook\PictureBook\Resources\Food\vegetables_carrot_blank.png")
        VeggieB(1) = System.Drawing.Bitmap.FromFile("C:\Users\Selina\Documents\Visual Studio 2012\Projects\PictureBook\PictureBook\Resources\Food\vegetables_potato_blank.png")
        VeggieB(2) = System.Drawing.Bitmap.FromFile("C:\Users\Selina\Documents\Visual Studio 2012\Projects\PictureBook\PictureBook\Resources\Food\vegetables_tomato_blank.png")

        Dessert(0) = System.Drawing.Bitmap.FromFile("C:\Users\Selina\Documents\Visual Studio 2012\Projects\PictureBook\PictureBook\Resources\Food\desserts_icecream.png")
        Dessert(1) = System.Drawing.Bitmap.FromFile("C:\Users\Selina\Documents\Visual Studio 2012\Projects\PictureBook\PictureBook\Resources\Food\desserts_pastry.png")
        Dessert(2) = System.Drawing.Bitmap.FromFile("C:\Users\Selina\Documents\Visual Studio 2012\Projects\PictureBook\PictureBook\Resources\Food\desserts_sundae.png")
        DessertB(0) = System.Drawing.Bitmap.FromFile("C:\Users\Selina\Documents\Visual Studio 2012\Projects\PictureBook\PictureBook\Resources\Food\desserts_icecream_blank.png")
        DessertB(1) = System.Drawing.Bitmap.FromFile("C:\Users\Selina\Documents\Visual Studio 2012\Projects\PictureBook\PictureBook\Resources\Food\desserts_pastry_blank.png")
        DessertB(2) = System.Drawing.Bitmap.FromFile("C:\Users\Selina\Documents\Visual Studio 2012\Projects\PictureBook\PictureBook\Resources\Food\desserts_sundae_blank.png")

    End Sub

    Private Sub PBoxL_Click(sender As Object, e As EventArgs) Handles PBoxL1.Click, PBoxL2.Click, PBoxL3.Click
        sender.AccessibleDescription = "*"
        Dim y As Integer = 0

        'Finds which level was selected
        For x = 0 To UBound(PBoxLevel)
            If PBoxLevel(x).AccessibleDescription = "*" Then
                Level = x
                PBoxLevel(x).AccessibleDescription = ""
            End If
        Next


        Select Case Intro.Slot
            Case 0
                FileOpen(1, saveFiles(0), OpenMode.Input)
                Do While Not EOF(1)
                    Input(1, Save(y))
                    y = y + 1
                Loop
                FileClose(1)
            Case 1
                FileOpen(2, saveFiles(1), OpenMode.Input)
                Do While Not EOF(2)
                    Input(2, Save(y))
                    y = y + 1
                Loop
                FileClose(2)
            Case 2
                FileOpen(3, saveFiles(2), OpenMode.Input)
                Do While Not EOF(3)
                    Input(3, Save(y))
                    y = y + 1
                Loop
                FileClose(3)
        End Select

        ' Enable dropping.
        For x = 0 To UBound(PBoxBlank)
            If Save(x) = 0 Then
                PBoxBlank(x).AllowDrop = True
            Else
                PBoxBlank(x).AllowDrop = False
            End If
        Next

        'Displays correct picture per level
        Select Case Level
            Case 0
                For x = 0 To UBound(PBoxSticker)
                    If PBoxBlank(x).AllowDrop = True Then
                        PBoxSticker(x).Image = Fruit(x)
                        PBoxBlank(x).Image = FruitB(x)
                        LblName(x).Visible = True
                    Else
                        PBoxSticker(x).Image = Nothing
                        PBoxBlank(x).Image = Fruit(x)
                        LblName(x).Visible = False
                    End If
                Next
                PnlBG0.Visible = True
                PnlBG1.Visible = False
                PnlBG2.Visible = False
            Case 1
                For x = 0 To UBound(PBoxSticker)
                    If PBoxBlank(x + 3).AllowDrop = True Then
                        PBoxSticker(x).Image = Veggie(x)
                        PBoxBlank(x + 3).Image = VeggieB(x)
                        LblName(x + 3).Visible = True
                    Else
                        PBoxSticker(x).Image = Nothing
                        PBoxBlank(x + 3).Image = Veggie(x)
                        LblName(x + 3).Visible = False
                    End If
                Next
                PnlBG0.Visible = False
                PnlBG1.Visible = True
                PnlBG2.Visible = False
            Case 2
                For x = 0 To UBound(PBoxSticker)
                    If PBoxBlank(x + 6).AllowDrop = True Then
                        PBoxSticker(x).Image = Dessert(x)
                        PBoxBlank(x + 6).Image = DessertB(x)
                        LblName(x + 6).Visible = True
                    Else
                        PBoxSticker(x).Image = Nothing
                        PBoxBlank(x + 6).Image = Dessert(x)
                        LblName(x + 6).Visible = False
                    End If
                Next
                PnlBG0.Visible = False
                PnlBG1.Visible = False
                PnlBG2.Visible = True
        End Select

        PnlPuzzle.Visible = True
        PnlLevel.Visible = False
    End Sub

    Private Sub PBoxSticker_MouseDown(ByVal sender As Object, ByVal e As  _
    System.Windows.Forms.MouseEventArgs) Handles PBoxS1.MouseDown, PBoxS2.MouseDown, PBoxS3.MouseDown
        If Not sender.Image Is Nothing Then
            ' Set a flag to show that the mouse is down.
            m_MouseIsDown = True
        End If

        'clears accessibledescription
        For x = 0 To UBound(PBoxSticker)
            If PBoxSticker(x).AccessibleDescription = "*" Then
                PBoxSticker(x).AccessibleDescription = ""
            End If
        Next
    End Sub

    Private Sub PBoxSticker_MouseMove(ByVal sender As Object, ByVal e As  _
    System.Windows.Forms.MouseEventArgs) Handles PBoxS1.MouseMove, PBoxS2.MouseMove, PBoxS3.MouseMove
        If m_MouseIsDown Then
            ' Initiate dragging and allow either copy or move.
            sender.DoDragDrop(sender.Image, DragDropEffects.Move)
        End If
        m_MouseIsDown = False
    End Sub

    Private Sub PBoxSticker_MouseLeave(sender As Object, e As EventArgs) Handles PBoxS1.MouseLeave, PBoxS2.MouseLeave, PBoxS3.MouseLeave
        'assigns AD
        sender.AccessibleDescription = "*"
    End Sub

    Private Sub PBoxBlank_DragEnter(ByVal sender As Object, ByVal e As  _
        System.Windows.Forms.DragEventArgs) Handles PBox1.DragEnter, PBox2.DragEnter, PBox3.DragEnter, PBox4.DragEnter, PBox5.DragEnter, PBox6.DragEnter, PBox7.DragEnter, PBox8.DragEnter, PBox9.DragEnter
        'Checks if dragged info is an image
        If e.Data.GetDataPresent(DataFormats.Bitmap) Then
            e.Effect = DragDropEffects.Move
        Else
            e.Effect = DragDropEffects.None
        End If

    End Sub

    Private Sub PBoxBlank_DragDrop(ByVal sender As Object, ByVal e As  _
    System.Windows.Forms.DragEventArgs) Handles PBox1.DragDrop, PBox2.DragDrop, PBox3.DragDrop, PBox4.DragDrop, PBox5.DragDrop, PBox6.DragDrop, PBox7.DragDrop, PBox8.DragDrop, PBox9.DragDrop
        ' Assign the image to the PictureBox.
        sender.Image = e.Data.GetData(DataFormats.Bitmap)
        sender.AccessibleDescription = "*"

        For x = 0 To UBound(PBoxBlank)
            If PBoxBlank(x).AccessibleDescription = "*" Then
                int = x
                PBoxBlank(x).AccessibleDescription = ""
            End If
        Next

        'calculates correct picture
        CorrectPicture(Level, int, Picture, Blank)

        'checks if input is correct
        If AreSameImage(sender.Image, Picture) = False Then
            sender.Image = Blank
            MsgBox("Sorry, that's wrong.")
        Else
            For x = 0 To UBound(PBoxSticker)
                If PBoxSticker(x).AccessibleDescription = "*" Then
                    PBoxSticker(x).Image = Nothing
                    PBoxSticker(x).AccessibleDescription = ""

                End If
            Next
            LblName(int).Visible = False
            MsgBox("Correct!")
            sender.AllowDrop = False

        End If

    End Sub

    Private Sub PBoxBlank_MouseClick(sender As Object, e As EventArgs) Handles PBox1.Click, PBox2.Click, PBox3.Click, PBox4.Click, PBox5.Click, PBox6.Click, PBox7.Click, PBox8.Click, PBox9.Click
        'identifies clicked PBox
        sender.AccessibleDescription = "*"
        For x = 0 To UBound(PBoxBlank)
            If PBoxBlank(x).AccessibleDescription = "*" Then
                int = x
                PBoxBlank(x).AccessibleDescription = ""
            End If
        Next

        If Intro.Language = True Then
            My.Computer.Audio.Play(WavE(int))
        Else
            My.Computer.Audio.Play(WavC(int))
        End If

    End Sub

    Public Function AreSameImage(ByVal I1 As Image, ByVal BM2 As Bitmap) As Boolean
        Dim BM1 As Bitmap = I1

        For x = 0 To BM1.Width - 1
            For y = 0 To BM2.Height - 1
                If BM1.GetPixel(x, y) <> BM2.GetPixel(x, y) Then
                    Return False
                End If
            Next
        Next
        Return True
    End Function

    Public Sub CorrectPicture(ByVal Level As Integer, ByVal Info As Integer, ByRef Picture As Bitmap, ByRef Blank As Bitmap)

        If Info = 0 Then
            Picture = Fruit(0)
            Blank = FruitB(0)
        ElseIf Info = 1 Then
            Picture = Fruit(1)
            Blank = FruitB(1)
        ElseIf Info = 2 Then
            Picture = Fruit(2)
            Blank = FruitB(2)
        ElseIf Info = 3 Then
            Picture = Veggie(0)
            Blank = VeggieB(0)
        ElseIf Info = 4 Then
            Picture = Veggie(1)
            Blank = VeggieB(1)
        ElseIf Info = 5 Then
            Picture = Veggie(2)
            Blank = VeggieB(2)
        ElseIf Info = 6 Then
            Picture = Dessert(0)
            Blank = DessertB(0)
        ElseIf Info = 7 Then
            Picture = Dessert(1)
            Blank = DessertB(1)
        Else
            Picture = Dessert(2)
            Blank = DessertB(2)

        End If

    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        PnlPuzzle.Visible = False
        PnlLevel.Visible = True

        'Add save - keep track of which picboxes are correct.
        Select Case Slot
            Case 0
                FileOpen(1, saveFiles(0), OpenMode.Output)

                For x = 0 To UBound(PBoxBlank)
                    If PBoxBlank(x).AllowDrop = False Then
                        'add either 0 or 1 for each pbox, 0 - incomplete, 1 - complete
                        PrintLine(1, 1)
                    Else
                        PrintLine(1, 0)
                    End If
                Next

                FileClose(1)
            Case 1
                FileOpen(2, saveFiles(1), OpenMode.Output)

                For x = 0 To UBound(PBoxBlank)
                    If PBoxBlank(x).AllowDrop = False Then
                        'add either 0 or 1 for each pbox, 0 - incomplete, 1 - complete
                        PrintLine(2, 1)
                    Else
                        PrintLine(2, 0)
                    End If
                Next

                FileClose(2)
            Case 2
                FileOpen(3, saveFiles(2), OpenMode.Output)

                For x = 0 To UBound(PBoxBlank)
                    If PBoxBlank(x).AllowDrop = False Then
                        'add either 0 or 1 for each pbox, 0 - incomplete, 1 - complete
                        PrintLine(3, 1)
                    Else
                        PrintLine(3, 0)
                    End If
                Next

                FileClose(3)
        End Select
    End Sub

    Private Sub BtnReturn_Click(sender As Object, e As EventArgs) Handles BtnReturn.Click
        Intro.Show()
        Me.Hide()
    End Sub

    Private Sub BtnLanguage_Click(sender As Object, e As EventArgs) Handles BtnLanguage.Click
        Dim y As Integer
        If BtnLanguage.Text = "中文" Then
            BtnLanguage.Text = "English"
            BtnReturn.Text = "返回"
            BtnBack.Text = "返回"
            StickerBank.Text = "贴纸银行"
            LblL1.Text = "水果"
            LblL2.Text = "蔬菜"
            LblL3.Text = "甜点"


            For x = 0 To UBound(LblName) 'from an array
                LblName(x).Text = NameC(x)
            Next
            Intro.Language = False
        Else
            BtnLanguage.Text = "中文"
            BtnReturn.Text = "Return"
            BtnBack.Text = "Back"
            StickerBank.Text = "Sticker Bank"
            LblL1.Text = "Fruits"
            LblL2.Text = "Veggies"
            LblL3.Text = "Desserts"

            FileOpen(4, NameE, OpenMode.Input) 'from a textfile
            Do While Not EOF(4)
                Input(4, nameText(y))
                y = y + 1
            Loop
            FileClose(4)

            For x = 0 To UBound(LblName)
                LblName(x).Text = nameText(x)
            Next
            Intro.Language = True
        End If
    End Sub

    Private Sub Me_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        Dim y As Integer
        If Intro.Language = False Then
            BtnLanguage.Text = "English"
            BtnReturn.Text = "返回"
            BtnBack.Text = "返回"
            StickerBank.Text = "贴纸银行"
            LblL1.Text = "水果"
            LblL2.Text = "蔬菜"
            LblL3.Text = "甜点"

            For x = 0 To UBound(LblName) 'from an array
                LblName(x).Text = NameC(x)
            Next
            Intro.Language = False
        Else
            BtnLanguage.Text = "中文"
            BtnReturn.Text = "Return"
            BtnBack.Text = "Back"
            StickerBank.Text = "Sticker Bank"
            LblL1.Text = "Fruits"
            LblL2.Text = "Veggies"
            LblL3.Text = "Desserts"

            FileOpen(4, NameE, OpenMode.Input) 'from a textfile
            Do While Not EOF(4)
                Input(4, nameText(y))
                y = y + 1
            Loop
            FileClose(4)

            For x = 0 To UBound(LblName)
                LblName(x).Text = nameText(x)
            Next
            Intro.Language = True
        End If

    End Sub
End Class

