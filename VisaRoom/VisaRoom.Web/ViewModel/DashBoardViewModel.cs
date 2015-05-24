using BusinessLogic.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VisaRoom.Common.Helper;
using VisaRoom.Common.Models;
namespace VisaRoom.Web.ViewModel
{
   
    public class DashBoardViewModel : VisaRoom.Web.Helper.HelperVisaRoomLogError
    {
        public UserTo CurrentUser { get; set; }
        private QuestionTo _newQuestion;
        public QuestionTo NewQuestion
        {
            get
            {
                if (_newQuestion == null)
                {
                    _newQuestion = new QuestionTo();
                }
              
                return _newQuestion;
            }
            set
            {
                this._newQuestion = value;
            }
        }
        private int _notificationQuestion;
        public int NotificationQuestion
        {
            get { return _notificationQuestion; }
            set { this._notificationQuestion = value; }
        }
        BLUser bussines;
        public DashBoardViewModel(UserTo user)
        {
            this.CurrentUser = user;
            bussines = new BLUser(this.LogError.SLogPath);
            GetQuestion();
        }

        public DashBoardViewModel()
        {           
           
        }

        private void GetQuestion()
        {
            if (this.CurrentUser != null)
            {
                this.CurrentUser.Questions = bussines.GetUserQuestions(this.CurrentUser.UserId, false);
                _notificationQuestion = this.CurrentUser.Questions.Count(x => x.Status == enumStatus.Answered_Not_Read);
            }
        }

        public void RefreshQuestions()
        {
            if (this.CurrentUser != null)
            {
                this.CurrentUser.Questions = bussines.GetUserQuestions(this.CurrentUser.UserId,true);
                _notificationQuestion = this.CurrentUser.Questions.Count(x => x.Status == enumStatus.Answered_Not_Read);
            }
        }
    }
}