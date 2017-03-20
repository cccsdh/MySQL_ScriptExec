using System;
using MySql.Data.MySqlClient;
using System.Web;
using System.Web.Mail;

// namespaces...
namespace MySQL_ScriptExec
{
    // public classes...
    public class MySQL_ScriptExecCommon
    {
        // public constructors...
        public MySQL_ScriptExecCommon()
        {
        }

        // public methods...
        public static string ExecuteSQLStatement(string strConnectionString, string strSQL)
        {
            var sqlConnection = new MySqlConnection(strConnectionString);
            var sqlCommand = new MySqlCommand();
            var message = "Success";
            try
            {
                try
                {
                    strSQL = strSQL.Trim();
                    if (strSQL != string.Empty)
                    {
                        sqlCommand.CommandText = strSQL;
                        sqlCommand.CommandTimeout = 360000000;
                        sqlConnection.Open();
                        sqlCommand.Connection = sqlConnection;
                        sqlCommand.ExecuteNonQuery();
                    }
                }
                catch (MySqlException sqlException)
                {
                    message = sqlException.Message;
                }
            }
            finally
            {
                sqlConnection.Close();
            }
            return message;
        }
        public static bool IsGoStatement(string strLine)
        {
            strLine = strLine.Trim().ToUpper().Replace("\t", string.Empty);
            return (!(strLine == "GO") ? false : true);
        }
        public static string SendMail(string strEmailAddress, string strSmtpServer, string strSubject, string strBody)
        {
            string message;
            if (!(strEmailAddress == string.Empty))
            {
                try
                {
                    var mailMessage = new MailMessage()
                    { From = "roman@arianna.net",
                        To = "roman@arianna.net",
                        Subject = "strSubject",
                        Body = "strBody"
                    };
                    SmtpMail.SmtpServer = strSmtpServer;
                    SmtpMail.Send(mailMessage);
                    message = string.Empty;
                }
                catch (HttpException httpException)
                {
                    message = httpException.Message;
                }
            }
            else
            {
                message = string.Empty;
            }
            return message;
        }
    }
}
