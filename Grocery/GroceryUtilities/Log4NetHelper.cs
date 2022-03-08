using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net.Repository.Hierarchy;

namespace Utilities
{
    public class Log4NetHelper
    {
        private readonly IConfiguration _configuration;
        private readonly ILoggerFactory _logger;

        public Log4NetHelper(IConfiguration configuration,ILoggerFactory logger)
        {
            _configuration = configuration;
            _logger = logger;
        }

        public void ErrorReport(CommonEnums.Log4NetType Type, Type Controller, Guid RequestID, string CandidateUser, string CandidateID, Exception Message)
        {
            string ErrorMsg = "Request ID:- " + RequestID + "Candidate UserName:- " + CandidateUser + " Candidate ID:- " + CandidateID;
            if (Type == CommonEnums.Log4NetType.DEBUG)
            {
                
                //log.Debug(ErrorMsg, Message);
            }
            else if (Type == CommonEnums.Log4NetType.INFO)
            {
                //log.Info(ErrorMsg, Message);
            }
            else if (Type == CommonEnums.Log4NetType.WARN)
            {
                //log.Warn(ErrorMsg, Message);
            }
            else if (Type == CommonEnums.Log4NetType.ERROR)
            {
                //new Task(() => ErrorEmailToAdmin(ErrorMsg, Message)).Start();
                //Logger logger = _logger.CreateLogger();
                //logger.LogInformation("Error :- {0} Message :- {1}", ErrorMsg, Message);
            }
            else if (Type == CommonEnums.Log4NetType.FATAL)
            {
                //log.Fatal(ErrorMsg, Message);
            }
            else
            {
                //log.Info(ErrorMsg, Message);
            }
        }
        public void MailSendingError(CommonEnums.Log4NetType Type, Type Controller, Guid RequestID, string CandidateUser, string CandidateID, Exception Message)
        {
            //ILog log = LogManager.GetLogger(Controller);
            string ErrorMsg = "Request ID:- " + RequestID + "Candidate UserName:- " + CandidateUser + " Candidate ID:- " + CandidateID;
            if (Type == CommonEnums.Log4NetType.DEBUG)
            {
                //log.Debug(ErrorMsg, Message);
            }
            else if (Type == CommonEnums.Log4NetType.INFO)
            {
                //log.Info(ErrorMsg, Message);
            }
            else if (Type == CommonEnums.Log4NetType.WARN)
            {
                //log.Warn(ErrorMsg, Message);
            }
            else if (Type == CommonEnums.Log4NetType.ERROR)
            {
                //log.Error(ErrorMsg, Message);
            }
            else if (Type == CommonEnums.Log4NetType.FATAL)
            {
                //log.Fatal(ErrorMsg, Message);
            }
            else
            {
                //log.Info(ErrorMsg, Message);
            }
        }

        //public bool ErrorEmailToAdmin(string ErrorMsg, Exception ExceptionMsg)
        //{
        //    var mobiles = new List<string>();
        //    MailTemplate mailTemplate = new MailTemplate()
        //    {
        //        MailBody = "Error Message:-" + ErrorMsg + "Exception Message:- " + ExceptionMsg.ToString(),
        //        MailSubject = _configuration["MailSetting:MailSubject"],
        //        MailTo = new List<string> { _configuration["MailSetting:AdminMailID"] }
        //    };
        //    return new MailService(_configuration, _logger).SendMail(mailTemplate, ref mobiles);
        //}
    }
}
