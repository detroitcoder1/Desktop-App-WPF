using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdPosterLibrary.Presenter
{
    Logo CodeTranslator: Code Translation From VB.NET<-> C# <-> TypeScript <-> Java
  |   Contact  
Home > Tools > Code Translator
Tools
Code Translator
WebChart Control
Windows Live Writer Code Colorizer Plugin
IIS 7 MRU Module
CodeColorizer
IIS 7 Reports
XGrid
X-Map Editor
ExcelXmlWriter
DbDiagrams
Forum Colorizer
UmlDiagrams
Drawing Board
PowerApps
PowerApps Connectors Reference
Articles
Enable CORS in IIS using URL Rewrite
Creating your own VS Template
Configuring COM+
Writing Simple Matrix Add-Ins
Generating Charts in ASP.NET
Writing Data Add-Ins for Matrix
Writing Code Builders for Matrix
Whidbey
WebParts Connections
Intranet Sample
Some FAQ
Another WebParts Sample
CatalogPart WebPart Sample
Connection Transformers
Games
NEW!!! Sudoku
Domino
Backgammon
Connect4
Windows Mobile
NEW!!! Sudoku Mobile
NEW!!! Tetris Mobile
NEW!!! Backgammon Mobile
NEW!!! Connect4 Mobile
Home
Home
My Blog
About Me

Make payments with PayPal - it's fast, free and secure!
Code Translation for .NET(C#<->VB.NET<->TypeScript<->Java)
Code Translator This service will translate the code for you, just start typing the code or upload a file to convert it. 
Supports converting code from VB.NET to C#, from C# to VB.NET, from C# to TypeScript and from VB.NET to TypeScript and Java to all others. 
To use it you can either:
Start typing your code.
Copy and Paste the code in the Code Text Box.
Translate an entire file using the file upload.
Disclaimer: No copy is done whatsoever of the code that you either type, or upload for translation.Everything is processed in the server in memory and returned immediately to the browser.
If you want to give feedback on the translation, please send me an email including the code you used and the desired translation to me@carlosag.net.
Options
Select Language:         |     Colorize Output
Translate
Code:  
Public Class Add_Cat
    Dim strFileName(5) As String
    Dim strPath As String
    Dim CtextBoxes() As TextBox

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        PostHome.Show()
        Me.Visible = False
    End Sub

    Private Sub Add_Cat_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim States() As String = { "Alaska", "Arizona", "Alabama", "Arkansas", "California", "Colorado", "Connecticut", "Delaware", "District of Columbia", "Florida", "Georgia", "Hawaii", "Idaho", "Illinois", "Indiana", "Iowa", "Kansas", "Kentucky", "Louisiana", "Maine", "Maryland", "Michigan", "Minnesota", "Mississippi", "Missouri", "Montana", "Nebraska", "Nevada", "NewHampshire", "New Jersey", "New Mexico", "New York", "North Carolina", "North Dakota", "Ohio", "Oklahoma", "Oregon", "Pennsylvania", "Rhode Island", "South Carolina", "South Dakota", "Tennessee", "Texas", "Utah", "Vermont", "Washington", "West Virginia", "Wisconsin", "Wyoming"}
    For i = 0 To States.Length - 1
            cboState.Items.Add(States(i).ToString)
        Next
        ' '' add all textbox names here whose value you want to persist.
        CtextBoxes = New TextBox() { txtEmail, txtPassword}



    Me.Activate()
    With My.Settings
        If.CTextBoxValues Is Nothing Then.CTextBoxValues = New System.Collections.Specialized.StringCollection
        For i = 0 To CtextBoxes.Length - 1

            If.CTextBoxValues.Count <= i Then .CTextBoxValues.Add("")
                CtextBoxes(i).Text = .CTextBoxValues(i)
            Next
            If My.Settings.ComboBoxValues Is Nothing Then.ComboBoxValues = New System.Collections.Specialized.StringCollection
            Try

                If cboState.FindString("Select State") AndAlso.ComboBoxValues(0).Contains("") Then
                   cboState.Text = .ComboBoxValues(0).ToString
               End If

               If cboCity.FindString("Select City") AndAlso.ComboBoxValues(1).Contains("") Then
                  cboCity.Text = .ComboBoxValues(1).ToString
              End If

          Catch ex As Exception
              Exit Try
          End Try

      End With
        'Adds files from post folder to windwow
        Try
            Dim Name As String, Path As String
            Path = "C:\Users\Public\Documents\AdBlazer\Post\"

            Name = Dir(Path, vbNormal)
            Do While Name<> ""
                cboCategory.Items.Add(System.IO.Path.GetFileNameWithoutExtension(Path & Name))
                Name = Dir()
            Loop
        Catch ex As Exception
            MessageBox.Show("Folder not located")
        End Try

    End Sub

    Private Sub TestTextBox()
        CtextBoxes = New TextBox() { txtEmail, txtPassword}
    For i = 0 To CtextBoxes.Length - 1
            If CtextBoxes(i).Text = String.Empty Then
            MessageBox.Show(CtextBoxes(i).Text.ToString + "Must contain a value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        Next


    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            'TestTextBox()
            Me.ReplaceText()
            Dim category As String
            category = cboCategory.SelectedItem.ToString
            If Not SchRun.chkSelect.Items.Contains(category) Then
                SchRun.chkSelect.Items.Add(category)
            End If
            AddremoveItems()

        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Public Sub ReplaceText()

        Dim category As String = ""
        Dim postfix As String = ".iim"
        Dim city As String
        Dim email As String
        Dim password As String

        Dim testCheck As String
        Dim testCheck2 As String

        testCheck = "SET !VAR1"
        testCheck2 = "SET !VAR2"
        Dim list As New ArrayList

        CtextBoxes = New TextBox() { txtEmail, txtPassword}
    For i = 0 To CtextBoxes.Length - 1
            If CtextBoxes(i).Text = String.Empty Then
            MessageBox.Show(CtextBoxes(i).Text.ToString + "Must contain a value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        Next
        Try
            If cboCity.Text.Contains("Select") Or cboState.Text.Contains("Select") Then
                MessageBox.Show("All fields contain a value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If


        Catch ex As Exception

        End Try
        Try
            email = txtEmail.Text.ToString
            city = cboCity.Text.ToString
            password = txtPassword.Text.ToString


            category = cboCategory.SelectedItem.ToString + postfix
            '//shorten the category string to use in saving the .csv file
            Dim cat = category.Substring(8)
            'cat = cat.Remove(" ")
            Dim inputFile As String = "C:\Users\Public\Documents\AdBlazer\Post\" + category 'template file
            Dim outputFile As String = "C:\Users\Public\Documents\AdBlazer\Post\" + category 'output file
            If Not IO.File.Exists(inputFile) Then MessageBox.Show("Input file does not exist")

            Using r As StreamReader = New StreamReader(inputFile)
                Dim line As String
                line = r.ReadLine
                If category.StartsWith("mail") Or category.Contains("delete") Then
                    Do While(Not line Is Nothing)
                        If line.Contains(testCheck) Then
                            line = "SET !VAR1 " + password
                        ElseIf line.Contains(testCheck2) Then
                            line = "SET !VAR2 " + email
                        End If
                        'For number As Integer = 0 To 10
                        list.Add(line & vbNewLine)
                        line = r.ReadLine
                        'Next
                    Loop

                Else
                    Do While(Not line Is Nothing)
                        If line.Contains(testCheck) Then
                            line = "SET !VAR1 " + city
                        ElseIf line.Contains(testCheck2) Then
                            line = "SET !VAR2 " + email
                        End If
                        list.Add(line & vbNewLine)
                        line = r.ReadLine
                    Loop
                End If

            End Using

            Using writer As StreamWriter = New StreamWriter(outputFile)
                For Each l As String In list
                    writer.Write(l)
                Next
            End Using
            MessageBox.Show("Settings Saved")
        Catch ex As Exception
            MessageBox.Show("Please select the correct file")
        End Try

    End Sub

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        ' Text and Cbo values persist
        For i = 0 To CtextBoxes.Length - 1
            My.Settings.CTextBoxValues(i) = CtextBoxes(i).Text
        Next
        My.Settings.ComboBoxValues.Clear()
        If My.Settings.ComboBoxValues Is Nothing Then My.Settings.ComboBoxValues = New System.Collections.Specialized.StringCollection
        Try
            My.Settings.ComboBoxValues.Add(cboState.SelectedItem.ToString)
            My.Settings.ComboBoxValues.Add(cboCity.SelectedItem.ToString)
        Catch ex As Exception
            Exit Try
        End Try
        My.Settings.Save()

    End Sub

    Private Sub AddremoveItems()
        Try
            Remove.cboRemove.Items.Add(cboCategory.SelectedItem.ToString)
        Catch ex As Exception
            MessageBox.Show("No file selected")
        End Try
    End Sub


    Private Sub txtEmail_Leave(sender As Object, e As EventArgs) Handles txtEmail.Leave
        Dim Valid As Boolean
        Try
            Valid = Regex.IsMatch(txtEmail.Text, "\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase)
        Catch ex As Exception
        End Try

        If Not Valid Then
            MsgBox("Invalid Email Address")
            txtEmail.Clear()
        End If
    End Sub


    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboState.SelectedIndexChanged
        State.DoCity()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("chrome.exe", "https://adblazer.wistia.com/medias/62pfy7ypax")
    End Sub

    Private Sub cboCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCategory.SelectedIndexChanged

    End Sub
End Class

File:  
public class Add_Cat
    {

        private string strPath;

        private TextBox[] CtextBoxes;

        private void btnBack_Click(object sender, EventArgs e)
        {
            PostHome.Show();
            this.Visible = false;
        }

        private void Add_Cat_Load(object sender, EventArgs e)
        {
            string[] States;
            "Alaska";
            "Arizona";
            "Alabama";
            "Arkansas";
            "California";
            "Colorado";
            "Connecticut";
            "Delaware";
            "District of Columbia";
            "Florida";
            "Georgia";
            "Hawaii";
            "Idaho";
            "Illinois";
            "Indiana";
            "Iowa";
            "Kansas";
            "Kentucky";
            "Louisiana";
            "Maine";
            "Maryland";
            "Michigan";
            "Minnesota";
            "Mississippi";
            "Missouri";
            "Montana";
            "Nebraska";
            "Nevada";
            "NewHampshire";
            "New Jersey";
            "New Mexico";
            "New York";
            "North Carolina";
            "North Dakota";
            "Ohio";
            "Oklahoma";
            "Oregon";
            "Pennsylvania";
            "Rhode Island";
            "South Carolina";
            "South Dakota";
            "Tennessee";
            "Texas";
            "Utah";
            "Vermont";
            "Washington";
            "West Virginia";
            "Wisconsin";
            "Wyoming";
            for (i = 0; (i
                        <= (States.Length - 1)); i++)
            {
                cboState.Items.Add(States[i].ToString);
            }

            //  '' add all textbox names here whose value you want to persist.
            CtextBoxes = new TextBox[] {
                txtEmail,
                txtPassword};
            this.Activate();
            // With...
            if ((My.Settings.CTextBoxValues == null))
            {
                My.Settings.CTextBoxValues = new System.Collections.Specialized.StringCollection();
            }

            for (i = 0; (i
                        <= (CtextBoxes.Length - 1)); i++)
            {
                if ((My.Settings.CTextBoxValues.Count <= i))
                {
                    My.Settings.CTextBoxValues.Add;
                }

                "";
                CtextBoxes[i].Text = My.Settings.CTextBoxValues;
                i;
            }

            if ((My.Settings.ComboBoxValues == null))
            {
                My.Settings.ComboBoxValues = new System.Collections.Specialized.StringCollection();
            }

            try
            {
                if ((cboState.FindString("Select State") && My.Settings.ComboBoxValues))
                {
                    0.Contains("");
                    cboState.Text = My.Settings.ComboBoxValues;
                    0.ToString;
                }

                if ((cboCity.FindString("Select City") && My.Settings.ComboBoxValues))
                {
                    1.Contains("");
                    cboCity.Text = My.Settings.ComboBoxValues;
                    1.ToString;
                }

            }
            catch (Exception ex)
            {
                // TODO: Exit Try: Warning!!! cannot be translated
            }

            // Adds files from post folder to windwow
            try
            {
                string Name;
                string Path;
                Path = "C:\\Users\\Public\\Documents\\AdBlazer\\Post\\";
                Name = Dir(Path, vbNormal);
                while ((Name != ""))
                {
                    cboCategory.Items.Add(System.IO.Path.GetFileNameWithoutExtension((Path + Name)));
                    Name = Dir();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Folder not located");
            }

        }

        private void TestTextBox()
        {
            CtextBoxes = new TextBox[] {
                txtEmail,
                txtPassword};
            for (i = 0; (i
                        <= (CtextBoxes.Length - 1)); i++)
            {
                if ((CtextBoxes[i].Text == String.Empty))
                {
                    MessageBox.Show((CtextBoxes[i].Text.ToString + "Must contain a value"), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                // TestTextBox()
                this.ReplaceText();
                string category;
                category = cboCategory.SelectedItem.ToString;
                if (!SchRun.chkSelect.Items.Contains(category))
                {
                    SchRun.chkSelect.Items.Add(category);
                }

                AddremoveItems();
            }
            catch (Exception ex)
            {
                return;
            }

        }

        public void ReplaceText()
        {
            string category = "";
            string postfix = ".iim";
            string city;
            string email;
            string password;
            string testCheck;
            string testCheck2;
            testCheck = "SET !VAR1";
            testCheck2 = "SET !VAR2";
            ArrayList list = new ArrayList();
            CtextBoxes = new TextBox[] {
                txtEmail,
                txtPassword};
            for (i = 0; (i
                        <= (CtextBoxes.Length - 1)); i++)
            {
                if ((CtextBoxes[i].Text == String.Empty))
                {
                    MessageBox.Show((CtextBoxes[i].Text.ToString + "Must contain a value"), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }

            try
            {
                if ((cboCity.Text.Contains("Select") || cboState.Text.Contains("Select")))
                {
                    MessageBox.Show("All fields contain a value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }
            catch (Exception ex)
            {
            }

            try
            {
                email = txtEmail.Text.ToString;
                city = cboCity.Text.ToString;
                password = txtPassword.Text.ToString;
                category = (cboCategory.SelectedItem.ToString + postfix);
                // //shorten the category string to use in saving the .csv file
                object cat = category.Substring(8);
                // cat = cat.Remove(" ")
                string inputFile = ("C:\\Users\\Public\\Documents\\AdBlazer\\Post\\" + category);
                // template file
                string outputFile = ("C:\\Users\\Public\\Documents\\AdBlazer\\Post\\" + category);
                // output file
                if (!IO.File.Exists(inputFile))
                {
                    MessageBox.Show("Input file does not exist");
                }

                Using;
                ((StreamReader)(r)) = new StreamReader(inputFile);
                string line;
                line = r.ReadLine;
                if ((category.StartsWith("mail") || category.Contains("delete")))
                {
                    while (!(line == null))
                    {
                        if (line.Contains(testCheck))
                        {
                            line = ("SET !VAR1 " + password);
                        }
                        else if (line.Contains(testCheck2))
                        {
                            line = ("SET !VAR2 " + email);
                        }

                        // For number As Integer = 0 To 10
                        list.Add((line + "\r\n"));
                        line = r.ReadLine;
                        // Next
                    }

                }
                else
                {
                    while (!(line == null))
                    {
                        if (line.Contains(testCheck))
                        {
                            line = ("SET !VAR1 " + city);
                        }
                        else if (line.Contains(testCheck2))
                        {
                            line = ("SET !VAR2 " + email);
                        }

                        list.Add((line + "\r\n"));
                        line = r.ReadLine;
                    }

                }

            }


        Using;
            ((StreamWriter)(writer)) = new StreamWriter(outputFile);
            foreach (string l in list)
            {
                writer.Write(l);
            }

        }

        private Exception ex;
    }
    EndSubEndclass Unknown
    {
    }


    private void Form1_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
    {
        //  Text and Cbo values persist
        for (i = 0; (i
                    <= (CtextBoxes.Length - 1)); i++)
        {
            My.Settings.CTextBoxValues(i) = CtextBoxes[i].Text;
        }

        My.Settings.ComboBoxValues.Clear();
        if ((My.Settings.ComboBoxValues == null))
        {
            My.Settings.ComboBoxValues = new System.Collections.Specialized.StringCollection();
        }

        try
        {
            My.Settings.ComboBoxValues.Add(cboState.SelectedItem.ToString);
            My.Settings.ComboBoxValues.Add(cboCity.SelectedItem.ToString);
        }
        catch (Exception ex)
        {
            // TODO: Exit Try: Warning!!! cannot be translated
        }

        My.Settings.Save();
    }

    private void AddremoveItems()
    {
        try
        {
            Remove.cboRemove.Items.Add(cboCategory.SelectedItem.ToString);
        }
        catch (Exception ex)
        {
            MessageBox.Show("No file selected");
        }

    }

    private void txtEmail_Leave(object sender, EventArgs e)
    {
        bool Valid;
        try
        {
            Valid = Regex.IsMatch(txtEmail.Text, "\\A(?:[a-z0-9!#$%&\'*+/=?^_`{|}~-]+(?:\\.[a-z0-9!#$%&\'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9]" +
                ")?\\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\\Z", RegexOptions.IgnoreCase);
        }
        catch (Exception ex)
        {
        }

        if (!Valid)
        {
            MsgBox("Invalid Email Address");
            txtEmail.Clear();
        }

    }

    private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
    {
        State.DoCity();
    }

    private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        Process.Start("chrome.exe", "https://adblazer.wistia.com/medias/62pfy7ypax");
    }

    private void cboCategory_SelectedIndexChanged(object sender, EventArgs e)
    {
    }
    Colorized by: CarlosAg.CodeColorizer


    Carlos Aguilar Mares © 2017
Make payments with PayPal - it's fast, free and secure!

}
