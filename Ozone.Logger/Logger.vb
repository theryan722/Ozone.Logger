Public Class Logger
    'Developed by Ryan O'Day

    Private Shared defloc As String = Environment.CurrentDirectory & "\log.txt"

    ''' <summary>
    ''' Writes text to the log.
    ''' </summary>
    ''' <param name="txt">The text to write.</param>
    ''' <remarks></remarks>
    Public Shared Sub WriteToLog(ByVal txt As String)
        If LogSettings.UseDefaultLogLocation Then
            Try
                Dim objWriter As New System.IO.StreamWriter(defloc, True)
                If LogSettings.DisplayTimeStamp Then
                    objWriter.WriteLine(DateTime.Now.ToString(LogSettings.TimeStampFormat) & " | " & txt)
                Else
                    objWriter.WriteLine("| " & txt)
                End If
                objWriter.Close()
            Catch
            End Try
        Else
            If LogSettings.LogLocation <> "" Then
                Try
                    Dim objWriter As New System.IO.StreamWriter(LogSettings.LogLocation, True)
                    If LogSettings.DisplayTimeStamp Then
                        objWriter.WriteLine(DateTime.Now.ToString(LogSettings.TimeStampFormat) & " | " & txt)
                    Else
                        objWriter.WriteLine("| " & txt)
                    End If
                    objWriter.Close()
                Catch
                End Try
            End If
        End If

    End Sub

    ''' <summary>
    ''' Writes an exception to the log.
    ''' </summary>
    ''' <param name="ex">The exception to write.</param>
    ''' <remarks></remarks>
    Public Shared Sub WriteExceptionToLog(ByVal ex As Exception)
        If LogSettings.UseDefaultLogLocation Then
            Try
                Dim objWriter As New System.IO.StreamWriter(defloc, True)
                If LogSettings.DisplayTimeStamp Then
                    objWriter.WriteLine(DateTime.Now.ToString(LogSettings.TimeStampFormat) & " | " & ex.ToString)
                Else
                    objWriter.WriteLine("| " & ex.ToString)
                End If
                objWriter.Close()
            Catch
            End Try
        Else
            If LogSettings.LogLocation <> "" Then
                Try
                    Dim objWriter As New System.IO.StreamWriter(LogSettings.LogLocation, True)
                    If LogSettings.DisplayTimeStamp Then
                        objWriter.WriteLine(DateTime.Now.ToString(LogSettings.TimeStampFormat) & " | " & ex.ToString)
                    Else
                        objWriter.WriteLine("| " & ex.ToString)
                    End If
                    objWriter.Close()
                Catch
                End Try
            End If
        End If

    End Sub

    ''' <summary>
    ''' Clears the log file.
    ''' </summary>
    ''' <param name="writetimestamp">Whether or not to write a timestamp of when the log was cleared.</param>
    ''' <remarks></remarks>
    Public Shared Sub ClearLog(Optional writetimestamp As Boolean = False)
        If LogSettings.UseDefaultLogLocation Then
            Dim objWriter As New System.IO.StreamWriter(defloc)
            If writetimestamp Then
                objWriter.WriteLine(DateTime.Now.ToString() & " | " & "===PREVIOUS LOG HISTORY CLEARED===")
            Else
                objWriter.Write("")
            End If
            objWriter.Close()
        Else
            If LogSettings.LogLocation <> "" Then
                Dim objWriter As New System.IO.StreamWriter(LogSettings.LogLocation)
                If writetimestamp Then
                    objWriter.WriteLine(DateTime.Now.ToString() & " | " & "===PREVIOUS LOG HISTORY CLEARED===")
                Else
                    objWriter.Write("")
                End If
                objWriter.Close()
            End If
        End If
    End Sub

    ''' <summary>
    ''' Returns the location of the log file being written to.
    ''' </summary>
    ''' <returns>String, the location of the log file.</returns>
    ''' <remarks></remarks>
    Public Shared Function GetLocationOfLogFile() As String
        If LogSettings.UseDefaultLogLocation Then
            Return defloc
        Else
            Return LogSettings.LogLocation
        End If
    End Function

    ''' <summary>
    ''' Returns the contents of the log file.
    ''' </summary>
    ''' <returns>String, the contents of the log.</returns>
    ''' <remarks></remarks>
    Public Shared Function GetLogText() As String
        If LogSettings.UseDefaultLogLocation Then
            Return My.Computer.FileSystem.ReadAllText(defloc)
        Else
            If LogSettings.LogLocation <> "" Then
                Return My.Computer.FileSystem.ReadAllText(LogSettings.LogLocation)
            Else
                Return ""
            End If
        End If

    End Function

End Class

