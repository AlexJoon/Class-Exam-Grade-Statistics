Option Explicit On
Option Strict On

Public Class Form1

    ' Creating a length to be used for our array later on.
    Const MaxGradeLength As Integer = 99

    ' Changing the scope of this variable to refer to the whole class.
    Dim ClassFile As String = "Final.txt"

    ' Class-level variables.
    Dim NumIncrement As Integer = 0

    Dim FirstNum As Integer = 0
    Dim SecondNum As Integer = 0
    Dim ThirdNum As Integer = 0
    Dim FourthNum As Integer = 0
    Dim FifthNum As Integer = 0

    Dim HighestGrade As Double
    Dim LowestGrade As Double = 200
    Dim TotalAmount As Double
    Dim AboveGradeNum As Integer = 0
    '

    ' Subroutine that handles the clearing of all textboxes of the program.
    Sub TextClearing()

        txtA.Clear()
        txtB.Clear()
        txtC.Clear()
        txtD.Clear()
        txtF.Clear()
        txtHS.Clear()
        txtLS.Clear()
        txtAvg.Clear()
        txtGAvg.Clear()
        txtStudent.Clear()
        lstPassFail.Items.Clear()


    End Sub

    ' Button Click event that calls the TextClearing method to clear all text boxes.
    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        TextClearing()

    End Sub


    ' Button Click event that ends the program. The user is prompted with a dialog box stating if they want to exit the program,
    ' If yes is chosen, the program is exited.
    Private Sub BtnEnd_Click(sender As Object, e As EventArgs) Handles btnEnd.Click

        Dim ButtonSelected As Integer
        ButtonSelected = MessageBox.Show("Are you sure you want to exit?", "Exiting...", MessageBoxButtons.YesNo, MessageBoxIcon.Error)
        If ButtonSelected = DialogResult.Yes Then
            Me.Close()
        End If

    End Sub

    ' Subroutine that reads in the .txt file that holds all grades and tryparses the string to a double.
    ' When the strings have been tryparsed to doubles, each individual grade will then be categorized from A-F letter grades
    ' based off the student's number grade. Once that the letter grades has incremented.
    Sub ProgramCalculations()

        Dim sr As IO.StreamReader

        Try

            ' Array that stores each .txt line into an array index. Each index is a double data type.
            Dim Grades(MaxGradeLength) As Double

            sr = IO.File.OpenText(ClassFile)

            ' Do Until Loop that reads every line of the .txt file.
            Do Until sr.EndOfStream

                Double.TryParse(sr.ReadLine().Trim, Grades(NumIncrement))

                ' Increments each letter grade based on the student's number grade and displayed into letter grade textboxes.
                If Grades(NumIncrement) >= 90 Then
                    FirstNum += 1
                    txtA.Text = FirstNum.ToString()

                ElseIf Grades(NumIncrement) >= 80 Then
                    SecondNum += 1
                    txtB.Text = SecondNum.ToString()

                ElseIf Grades(NumIncrement) >= 70 Then
                    ThirdNum += 1
                    txtC.Text = ThirdNum.ToString()

                ElseIf Grades(NumIncrement) >= 60 Then
                    FourthNum += 1
                    txtD.Text = FourthNum.ToString()

                ElseIf Grades(NumIncrement) >= 50 Then
                    FifthNum += 1
                    txtF.Text = FifthNum.ToString()

                ElseIf Grades(NumIncrement) >= 40 Then
                    FifthNum += 1
                    txtF.Text = FifthNum.ToString()

                End If

                ' Getting the Highest Grade of the class.
                If HighestGrade < Grades(NumIncrement) Then
                    HighestGrade = Grades(NumIncrement)
                End If

                ' Getting the Lowest Grade of the class.
                If LowestGrade > Grades(NumIncrement) Then
                    LowestGrade = Grades(NumIncrement)
                End If

                ' Getting the total amount of class grades for the average.
                TotalAmount = TotalAmount + Grades(NumIncrement)

                ' Incrementing each element of the array with a number. 
                ' This increment will tell us how many elements are in the array, that was imported from the .txt file.
                NumIncrement += 1

            Loop

            ' Closing the file when the loop has finished reading all lines and doing the calculations.
            sr.Close()


            ' Displaying how many students have passed based on their letter grades.
            Dim PassingStudents As Integer = FirstNum + SecondNum + ThirdNum
            lstPassFail.Items.Add(PassingStudents.ToString() & " Students Passed")

            ' Displaying how many students have failed based on the letter grades.
            Dim FailingStudents As Integer = FourthNum + FifthNum
            lstPassFail.Items.Add(FailingStudents.ToString() & " Students Failed")

            Dim Average As Double = TotalAmount / NumIncrement

            ' Getting the Highest Score of the grades.
            txtHS.Text = (HighestGrade.ToString() & " %")

            ' Getting the Lowest Score of the Grades.
            txtLS.Text = (LowestGrade.ToString() & " %")

            ' Getting the Average of the Grades.
            txtAvg.Text = (Average.ToString() & " %")


            ' Using this for loop to calculate the percentage of how many students are ABOVE average of the averaged number grades.
            For k As Integer = 0 To NumIncrement - 1
                If Grades(k) > Average Then ' Taking all the grades that are higher than the average (75.2) and adding them all together.

                    AboveGradeNum += 1

                End If
            Next k

            ' Taking all the grades that are higher than the average, and dividing them by the counter that was incremented in the Do Until Loop.
            Dim AboveAverage As Double = AboveGradeNum / NumIncrement

            ' Outputting the percentage of above average students.
            txtGAvg.Text = (AboveAverage.ToString("p"))

            ' Outputting the # of how many students are above average.
            txtStudent.Text = (AboveGradeNum.ToString() & " Students")

        Catch ex As Exception

            ' If the try is not able to execute, it will go to this catch.
            ' This catch prompts the user with a file dialog box for them to re-enter a .txt file to try again.
            MessageBox.Show("You have not entered a file. " & ex.Message)
            OpenFileDialog1.ShowDialog()

            ClassFile = OpenFileDialog1.FileName

        End Try

    End Sub

    ' Button event that runs the ProgramCalculations subroutine and displays the calculations to the screen.
    Private Sub BtnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click

        ProgramCalculations()

    End Sub

    ' Subroutine that handles the importing of another .txt file that has 25 grades.
    Sub ImportingClassFile()

        Try

            OpenFileDialog1.InitialDirectory = "C:\"

            OpenFileDialog1.FileName = ""
            OpenFileDialog1.Filter = "Text files|*.txt|Log files|*.log"
            OpenFileDialog1.ShowDialog()

            ClassFile = OpenFileDialog1.FileName


        Catch ex As Exception

            ' In case the user tries to find a way to enter a file that isnt a .log, or .txt file.
            ' For example, a file with a .csv or .docx file extension.
            MessageBox.Show("You have entered the wrong type of file. " & ex.Message)
            OpenFileDialog1.ShowDialog()

            ClassFile = OpenFileDialog1.FileName

        End Try

    End Sub

    ' Button click event that clears all current text box fields and executes the ImportingClassFile subroutine
    ' where a new file open dialog box will open to the user prompting them to find a new .txt file to load into the program.
    Private Sub BtnImport_Click(sender As Object, e As EventArgs) Handles btnImport.Click

        TextClearing()
        ImportingClassFile()

    End Sub

End Class
