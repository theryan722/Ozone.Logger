Public Class LogSettings

    ''' <summary>
    ''' The location of the log file to use, if not using the default log location.
    ''' </summary>
    ''' <value>The file location where you want to write the log. Must include filename.</value>
    ''' <returns>String, the log location.</returns>
    ''' <remarks></remarks>
    Public Shared Property LogLocation As String = ""

    ''' <summary>
    ''' The format to use for the time stamp.
    ''' </summary>
    ''' <value>The date time format. Use the .Net format. Set blank for default.</value>
    ''' <returns>String, the format being used.</returns>
    ''' <remarks></remarks>
    Public Shared Property TimeStampFormat As String = ""

    ''' <summary>
    ''' Whether or not to use the default log location (the DLL's current directory).
    ''' </summary>
    ''' <value>Whether or not to use the default location, if false, you must specify the LogLocation</value>
    ''' <returns>Boolean, whether or not the default location is being used..</returns>
    ''' <remarks></remarks>
    Public Shared Property UseDefaultLogLocation As Boolean = True

    ''' <summary>
    ''' Whether or not to display a timestamp when text is entered into the log.
    ''' </summary>
    ''' <value>Whether to display a timestamp or not. If false, no timestamp will be displayed..</value>
    ''' <returns>Whether or not a timestamp is being displayed.</returns>
    ''' <remarks></remarks>
    Public Shared Property DisplayTimeStamp As Boolean = True

End Class
