using System;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
/// <summary>
/// Version 1.0.0.0
/// </summary>
public class LogWriter
{
    public static void LogYaz(string log, string title = "HATA", [CallerLineNumber] int lineNumber = 0, [CallerMemberName] string caller = null)
    {
        try
        {
            //appSettings.DATA.LogsTA.Ekle(title, log + " " + lineNumber + " (" + caller + ")", "", 0, appSettings.UserID.convInt());
        }
        catch (Exception ex)
        {
            LogYaz(log + " hata mesajı yazılırken şu sorun oluştu." + ex.Message, renk.kirmizi);
        }
    }
    public static string logfolder
    {
        get
        {
            string p = Application.StartupPath + "\\Logs";
            if (!System.IO.Directory.Exists(p))
                System.IO.Directory.CreateDirectory(p);

            return p;
        }

    }

    public static string getlogpath(string filename)
    {
        return logfolder + "\\" + filename + "_" + System.DateTime.Now.ToString("dd_MM_yyyy") + ".htm";

    }
    public static string logpath
    {
        get { return logfolder + "\\Rapor_" + System.DateTime.Now.ToString("dd_MM_yyyy") + ".htm"; }

    }
    public static void LogYaz(string str, renk _renk, [CallerLineNumber] int lineNumber = 0, [CallerMemberName] string caller = null)
    {
        LogYaz(str + " " + lineNumber + " (" + caller + ")", _renk, System.DateTime.Now.ToString("dd_MM_yyyy") + ".htm");
    }

    public static void LogYaz(string str, bool lastLogs)
    {
        str = String.Format("<font color=\"#990000\" style=\"font:normal 10px arial\">{0}</font><br>", str);


        System.IO.StreamWriter sw = new System.IO.StreamWriter(logpath, false, Encoding.UTF8);
        sw.WriteLine(String.Format("{0}&nbsp; &nbsp; &nbsp;    {1}", System.DateTime.Now, str));
        sw.Close();
        sw.Dispose();
    }
    public static void LogYaz(string str, renk _renk, string filename)
    {
        try
        {
            switch (_renk)
            {
                case renk.yesil:
                    str = String.Format("<font color=\"#006600\" style=\"font:normal 10px arial\">{0}</font><br>", str);
                    break;
                case renk.sari:
                    str = String.Format("<font color=\"#A69626\" style=\"font:normal 10px arial\">{0}</font><br>", str);
                    break;
                case renk.kirmizi:
                    str = String.Format("<font color=\"#990000\" style=\"font:normal 10px arial\">{0}</font><br>", str);
                    break;
                case renk.siyah:
                    str = String.Format("<font color=\"#333333\" style=\"font:normal 10px arial\">{0}</font><br>", str);
                    break;
            }

            string logpath2 = logfolder + "\\Log_" + filename;

            System.IO.StreamWriter sw = new System.IO.StreamWriter(logpath2, true, Encoding.UTF8);
            sw.WriteLine(String.Format("{0}&nbsp; &nbsp; &nbsp;    {1}", System.DateTime.Now, str));
            sw.Close();
            sw.Dispose();
        }
        catch { }
    }
    public static void LogException(Exception ex)
    {
        if (ex == null)
        {
            LogWriter.LogYaz("Exception nesnesi null geldi");
            return;
        }
        string _msg = "";
        _msg += "<br> ------------------------------------------------------------------- <br> ";
        _msg +=
          $"<br><font color=\"#006600\">Source: {ex.Source}</font>"
        + $"<br><font color=\"#A69626\">Message: {ex.Message} </font>"
        + $"<br><font color=\"#333333\">StackTrance: {ex.StackTrace} </font>";

        if (ex.InnerException != null)
        {
            LogException(ex);
        }

        _msg += "<br> ------------------------------------------------------------------- <br> ";
        try
        {
            LogWriter.LogYaz(_msg);
        }
        catch (Exception)
        {
        }

    }

    public enum renk
    {
        yesil, kirmizi, sari, siyah
    }

}