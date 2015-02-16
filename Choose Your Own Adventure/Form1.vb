Imports System.IO

Public Class Form1

    Dim path As String = ""
    Dim rooms() As Room

    'Room contains all of our room data. It's great because it's easy to expand
    '   if we need to.

    Structure Room
        Dim id As Integer
        Dim name As String
        Dim scenario As String
        Dim choice1 As Integer
        Dim text1 As String
        Dim choice2 As Integer
        Dim text2 As String
        Dim choice3 As Integer
        Dim text3 As String
    End Structure

    'Load_File will load our game file into the rooms dynamic array, and define
    '   its length based on our needs

    Private Sub Load_File()

        Dim stream As New System.IO.StreamReader(path)
        Dim text As String = ""
        Dim tmp

        ReDim rooms(System.IO.File.ReadLines(path).Count()) As Room

        Dim i As Integer
        While stream.Peek() <> -1
            text = stream.ReadLine()
            tmp = Split(text, "|")
            rooms(i).id = Int(tmp(0))
            rooms(i).name = tmp(1)
            rooms(i).scenario = tmp(2)
            rooms(i).choice1 = Int(tmp(3))
            rooms(i).text1 = tmp(4)
            rooms(i).choice2 = Int(tmp(5))
            rooms(i).text2 = tmp(6)
            rooms(i).choice3 = Int(tmp(7))
            rooms(i).text3 = tmp(8)
            i += 1
        End While
    End Sub

    'Button_Click fires every time the buttons are clicked. It's used to change
    '   the room or perform other actions that require button clicks. Because
    '   the function effectively operates the same for each button, we can use
    '   the 'tag' property of the button to 

    Private Sub Button_Click(sender As Object, e As EventArgs) Handles Choice1.Click, Choice2.Click, Choice3.Click
        Load_Room(sender.tag)
    End Sub

    Private Sub Load_Room(id As Integer)

      DisplayBox.Text = rooms(id).scenario.Replace("**", vbNewLine)
      Choice1.Text = rooms(id).text1
      Choice1.Tag = rooms(id).choice1
      Choice2.Text = rooms(id).text2
      Choice2.Tag = rooms(id).choice2
      Choice3.Text = rooms(id).text3
      Choice3.Tag = rooms(id).choice3
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If System.IO.File.Exists(Application.StartupPath & "\text.txt") Then
            path = Application.StartupPath & "\text.txt"
        Else
            MsgBox("No game file found! Please put it at: " & Application.StartupPath, MsgBoxStyle.Critical, "Error")
            End
        End If

        Load_File()
        Load_Room(0)

    End Sub
End Class
