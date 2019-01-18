
Public Class Animal
    Dim m_MouseIsDown As Boolean
    Public Language As Boolean
    Dim Picture, Blank, Ocean(2), OceanB(2), Forest(2), ForestB(2), Jungle(2), JungleB(2), Mountains(2), MountainsB(2) As Bitmap
    Dim PBoxSticker(2), PBoxBlank(11), PBoxLevel(3) As PictureBox
    Dim int, Level, Save(11) As Integer
    Dim saveFiles(2), WavE(11), WavC(11), nameText(11), NameE, NameC(11) As String
    Dim LblName(11) As Label
    Public Slot As Integer

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As  _
System.EventArgs) Handles MyBase.Load
        'save slot locations
        saveFiles(0) = "C:\Users\Selina\Documents\Visual Studio 2012\Projects\PictureBook\PictureBook\Resources\Animals\Animals1.txt"
        saveFiles(1) = "C:\Users\Selina\Documents\Visual Studio 2012\Projects\PictureBook\PictureBook\Resources\Animals\Animals2.txt"
        saveFiles(2) = "C:\Users\Selina\Documents\Visual Studio 2012\Projects\PictureBook\PictureBook\Resources\Animals\Animals3.txt"
        'nameText file locations
        NameE = "C:\Users\Selina\Documents\Visual Studio 2012\Projects\PictureBook\PictureBook\Resources\Animals\NameE.txt"
        NameC(0) = "企鹅 "
        NameC(1) = "章鱼"
        NameC(2) = "寄居蟹"
        NameC(3) = "熊"
        NameC(4) = "猫头鹰"
        NameC(5) = "狐狸"
        NameC(6) = "猴"
        NameC(7) = "大象"
        NameC(8) = "鹦鹉"
        NameC(9) = "老鹰"
        NameC(10) = "驯鹿"
        NameC(11) = "狼"
        'audio files
        WavE(0) = "D:\ITGS_selina\Animals\penguinE.wav"
        WavE(1) = "D:\ITGS_selina\Animals\octopusE.wav"
        WavE(2) = "D:\ITGS_selina\Animals\hermitE.wav"
        WavE(3) = "D:\ITGS_selina\Animals\bearE.wav"
        WavE(4) = "D:\ITGS_selina\Animals\owlE.wav"
        WavE(5) = "D:\ITGS_selina\Animals\foxE.wav"
        WavE(6) = "D:\ITGS_selina\Animals\monkeyE.wav"
        WavE(7) = "D:\ITGS_selina\Animals\elephantE.wav"
        WavE(8) = "D:\ITGS_selina\Animals\parrotE.wav"
        WavE(9) = "D:\ITGS_selina\Animals\eagleE.wav"
        WavE(10) = "D:\ITGS_selina\Animals\caribouE.wav"
        WavE(11) = "D:\ITGS_selina\Animals\wolfE.wav"
        WavC(0) = "D:\ITGS_selina\Animals\penguinC.wav"
        WavC(1) = "D:\ITGS_selina\Animals\octopusC.wav"
        WavC(2) = "D:\ITGS_selina\Animals\hermitC.wav"
        WavC(3) = "D:\ITGS_selina\Animals\bearC.wav"
        WavC(4) = "D:\ITGS_selina\Animals\owlC.wav"
        WavC(5) = "D:\ITGS_selina\Animals\foxC.wav"
        WavC(6) = "D:\ITGS_selina\Animals\monkeyC.wav"
        WavC(7) = "D:\ITGS_selina\Animals\elephantC.wav"
        WavC(8) = "D:\ITGS_selina\Animals\parrotC.wav"
        WavC(9) = "D:\ITGS_selina\Animals\eagleC.wav"
        WavC(10) = "D:\ITGS_selina\Animals\caribouC.wav"
        WavC(11) = "D:\ITGS_selina\Animals\wolfC.wav"
        'Levels
        PBoxLevel(0) = PBoxL1
        PBoxLevel(1) = PBoxL2
        PBoxLevel(2) = PBoxL3
        PBoxLevel(3) = PBoxL4

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
        PBoxBlank(9) = PBox10
        PBoxBlank(10) = PBox11
        PBoxBlank(11) = PBox12
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
        LblName(9) = Lbl10
        LblName(10) = Lbl11
        LblName(11) = Lbl12
        'Photos
        Ocean(0) = System.Drawing.Bitmap.FromFile("C:\Users\Selina\Documents\Visual Studio 2012\Projects\PictureBook\PictureBook\Resources\Animals\ocean_animals_penguins.png")
        Ocean(1) = System.Drawing.Bitmap.FromFile("C:\Users\Selina\Documents\Visual Studio 2012\Projects\PictureBook\PictureBook\Resources\Animals\ocean_animals_octopus.png")
        Ocean(2) = System.Drawing.Bitmap.FromFile("C:\Users\Selina\Documents\Visual Studio 2012\Projects\PictureBook\PictureBook\Resources\Animals\ocean_animals_hermit.png")
        OceanB(0) = System.Drawing.Bitmap.FromFile("C:\Users\Selina\Documents\Visual Studio 2012\Projects\PictureBook\PictureBook\Resources\Animals\ocean_animals_penguins_blank.png")
        OceanB(1) = System.Drawing.Bitmap.FromFile("C:\Users\Selina\Documents\Visual Studio 2012\Projects\PictureBook\PictureBook\Resources\Animals\ocean_animals_octopus_blank.png")
        OceanB(2) = System.Drawing.Bitmap.FromFile("C:\Users\Selina\Documents\Visual Studio 2012\Projects\PictureBook\PictureBook\Resources\Animals\ocean_animals_hermit_blank.png")

        Forest(0) = System.Drawing.Bitmap.FromFile("C:\Users\Selina\Documents\Visual Studio 2012\Projects\PictureBook\PictureBook\Resources\Animals\forest_animals_bear.png")
        Forest(1) = System.Drawing.Bitmap.FromFile("C:\Users\Selina\Documents\Visual Studio 2012\Projects\PictureBook\PictureBook\Resources\Animals\forest_animals_owl.png")
        Forest(2) = System.Drawing.Bitmap.FromFile("C:\Users\Selina\Documents\Visual Studio 2012\Projects\PictureBook\PictureBook\Resources\Animals\forest_animals_fox.png")
        ForestB(0) = System.Drawing.Bitmap.FromFile("C:\Users\Selina\Documents\Visual Studio 2012\Projects\PictureBook\PictureBook\Resources\Animals\forest_animals_bear_blank.png")
        ForestB(1) = System.Drawing.Bitmap.FromFile("C:\Users\Selina\Documents\Visual Studio 2012\Projects\PictureBook\PictureBook\Resources\Animals\forest_animals_owl_blank.png")
        ForestB(2) = System.Drawing.Bitmap.FromFile("C:\Users\Selina\Documents\Visual Studio 2012\Projects\PictureBook\PictureBook\Resources\Animals\forest_animals_fox_blank.png")

        Jungle(0) = System.Drawing.Bitmap.FromFile("C:\Users\Selina\Documents\Visual Studio 2012\Projects\PictureBook\PictureBook\Resources\Animals\jungle_animals_monkey.png")
        Jungle(1) = System.Drawing.Bitmap.FromFile("C:\Users\Selina\Documents\Visual Studio 2012\Projects\PictureBook\PictureBook\Resources\Animals\jungle_animals_elephant.png")
        Jungle(2) = System.Drawing.Bitmap.FromFile("C:\Users\Selina\Documents\Visual Studio 2012\Projects\PictureBook\PictureBook\Resources\Animals\jungle_animals_parrot.png")
        JungleB(0) = System.Drawing.Bitmap.FromFile("C:\Users\Selina\Documents\Visual Studio 2012\Projects\PictureBook\PictureBook\Resources\Animals\jungle_animals_monkey_blank.png")
        JungleB(1) = System.Drawing.Bitmap.FromFile("C:\Users\Selina\Documents\Visual Studio 2012\Projects\PictureBook\PictureBook\Resources\Animals\jungle_animals_elephant_blank.png")
        JungleB(2) = System.Drawing.Bitmap.FromFile("C:\Users\Selina\Documents\Visual Studio 2012\Projects\PictureBook\PictureBook\Resources\Animals\jungle_animals_parrot_blank.png")

        Mountains(0) = System.Drawing.Bitmap.FromFile("C:\Users\Selina\Documents\Visual Studio 2012\Projects\PictureBook\PictureBook\Resources\Animals\mountains_animals_eagle.png")
        Mountains(1) = System.Drawing.Bitmap.FromFile("C:\Users\Selina\Documents\Visual Studio 2012\Projects\PictureBook\PictureBook\Resources\Animals\mountains_animals_caribou.png")
        Mountains(2) = System.Drawing.Bitmap.FromFile("C:\Users\Selina\Documents\Visual Studio 2012\Projects\PictureBook\PictureBook\Resources\Animals\mountains_animals_wolf.png")
        MountainsB(0) = System.Drawing.Bitmap.FromFile("C:\Users\Selina\Documents\Visual Studio 2012\Projects\PictureBook\PictureBook\Resources\Animals\mountains_animals_eagle_blank.png")
        MountainsB(1) = System.Drawing.Bitmap.FromFile("C:\Users\Selina\Documents\Visual Studio 2012\Projects\PictureBook\PictureBook\Resources\Animals\mountains_animals_caribou_blank.png")
        MountainsB(2) = System.Drawing.Bitmap.FromFile("C:\Users\Selina\Documents\Visual Studio 2012\Projects\PictureBook\PictureBook\Resources\Animals\mountains_animals_wolf_blank.png")

    End Sub
    Private Sub PBoxL_Click(sender As Object, e As EventArgs) Handles PBoxL1.Click, PBoxL2.Click, PBoxL3.Click, PBoxL4.Click
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
                        PBoxSticker(x).Image = Ocean(x)
                        PBoxBlank(x).Image = OceanB(x)
                        LblName(x).Visible = True
                    Else
                        PBoxSticker(x).Image = Nothing
                        PBoxBlank(x).Image = Ocean(x)
                        LblName(x).Visible = False
                    End If
                Next
                PnlBG0.Visible = True
                PnlBG1.Visible = False
                PnlBG2.Visible = False
                PnlBG3.Visible = False
            Case 1
                For x = 0 To UBound(PBoxSticker)
                    If PBoxBlank(x + 3).AllowDrop = True Then
                        PBoxSticker(x).Image = Forest(x)
                        PBoxBlank(x + 3).Image = ForestB(x)
                        LblName(x + 3).Visible = True
                    Else
                        PBoxSticker(x).Image = Nothing
                        PBoxBlank(x + 3).Image = Forest(x)
                        LblName(x + 3).Visible = False
                    End If
                Next
                PnlBG0.Visible = False
                PnlBG1.Visible = True
                PnlBG2.Visible = False
                PnlBG3.Visible = False
            Case 2
                For x = 0 To UBound(PBoxSticker)
                    If PBoxBlank(x + 6).AllowDrop = True Then
                        PBoxSticker(x).Image = Jungle(x)
                        PBoxBlank(x + 6).Image = JungleB(x)
                        LblName(x + 6).Visible = True
                    Else
                        PBoxSticker(x).Image = Nothing
                        PBoxBlank(x + 6).Image = Jungle(x)
                        LblName(x + 6).Visible = False
                    End If
                Next
                PnlBG0.Visible = False
                PnlBG1.Visible = False
                PnlBG2.Visible = True
                PnlBG3.Visible = False
            Case 3
                For x = 0 To UBound(PBoxSticker)
                    If PBoxBlank(x + 9).AllowDrop = True Then
                        PBoxSticker(x).Image = Mountains(x)
                        PBoxBlank(x + 9).Image = MountainsB(x)
                        LblName(x + 9).Visible = True
                    Else
                        PBoxSticker(x).Image = Nothing
                        PBoxBlank(x + 9).Image = Mountains(x)
                        LblName(x + 9).Visible = False
                    End If
                Next
                PnlBG0.Visible = False
                PnlBG1.Visible = False
                PnlBG2.Visible = False
                PnlBG3.Visible = True
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
        System.Windows.Forms.DragEventArgs) Handles PBox1.DragEnter, PBox2.DragEnter, PBox3.DragEnter, PBox4.DragEnter, PBox5.DragEnter, PBox6.DragEnter, PBox7.DragEnter, PBox8.DragEnter, PBox9.DragEnter, PBox10.DragEnter, PBox11.DragEnter, PBox12.DragEnter
        'Checks if dragged info is an image
        If e.Data.GetDataPresent(DataFormats.Bitmap) Then
            e.Effect = DragDropEffects.Move
        Else
            e.Effect = DragDropEffects.None
        End If

    End Sub

    Private Sub PBoxBlank_DragDrop(ByVal sender As Object, ByVal e As  _
    System.Windows.Forms.DragEventArgs) Handles PBox1.DragDrop, PBox2.DragDrop, PBox3.DragDrop, PBox4.DragDrop, PBox5.DragDrop, PBox6.DragDrop, PBox7.DragDrop, PBox8.DragDrop, PBox9.DragDrop, PBox10.DragDrop, PBox11.DragDrop, PBox12.DragDrop
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

    Private Sub PBoxBlank_MouseClick(sender As Object, e As EventArgs) Handles PBox1.Click, PBox2.Click, PBox3.Click, PBox4.Click, PBox5.Click, PBox6.Click, PBox7.Click, PBox8.Click, PBox9.Click, PBox10.Click, PBox11.Click, PBox12.Click
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
            Picture = Ocean(0)
            Blank = OceanB(0)
        ElseIf Info = 1 Then
            Picture = Ocean(1)
            Blank = OceanB(1)
        ElseIf Info = 2 Then
            Picture = Ocean(2)
            Blank = OceanB(2)
        ElseIf Info = 3 Then
            Picture = Forest(0)
            Blank = ForestB(0)
        ElseIf Info = 4 Then
            Picture = Forest(1)
            Blank = ForestB(1)
        ElseIf Info = 5 Then
            Picture = Forest(2)
            Blank = ForestB(2)
        ElseIf Info = 6 Then
            Picture = Jungle(0)
            Blank = JungleB(0)
        ElseIf Info = 7 Then
            Picture = Jungle(1)
            Blank = JungleB(1)
        ElseIf Info = 8 Then
            Picture = Jungle(2)
            Blank = JungleB(2)
        ElseIf Info = 9 Then
            Picture = Mountains(0)
            Blank = MountainsB(0)
        ElseIf Info = 10 Then
            Picture = Mountains(1)
            Blank = MountainsB(1)
        Else
            Picture = Mountains(2)
            Blank = MountainsB(2)
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
            LblL1.Text = "海"
            LblL2.Text = "树林"
            LblL3.Text = "丛林"
            LblL4.Text = "山"

            For x = 0 To UBound(LblName) 'from an array
                LblName(x).Text = NameC(x)
            Next
            Intro.Language = False
        Else
            BtnLanguage.Text = "中文"
            BtnReturn.Text = "Return"
            BtnBack.Text = "Back"
            StickerBank.Text = "Sticker Bank"
            LblL1.Text = "Ocean"
            LblL2.Text = "Forest"
            LblL3.Text = "Jungle"
            LblL4.Text = "Mountain"

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
            LblL1.Text = "海"
            LblL2.Text = "树林"
            LblL3.Text = "丛林"
            LblL4.Text = "山"

            For x = 0 To UBound(LblName) 'from an array
                LblName(x).Text = NameC(x)
            Next
            Intro.Language = False
        Else
            BtnLanguage.Text = "中文"
            BtnReturn.Text = "Return"
            BtnBack.Text = "Back"
            StickerBank.Text = "Sticker Bank"
            LblL1.Text = "Ocean"
            LblL2.Text = "Forest"
            LblL3.Text = "Jungle"
            LblL4.Text = "Mountain"

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

