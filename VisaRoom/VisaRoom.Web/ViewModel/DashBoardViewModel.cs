using BusinessLogic.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VisaRoom.Common.Models;
namespace VisaRoom.Web.ViewModel
{
    [System.Web.Mvc.Bind(Exclude = "List")]
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


        public DashBoardViewModel(UserTo user)
        {
            this.CurrentUser = user;
            BLUser bussines=new BLUser(this.LogError.SLogPath);            
            this.CurrentUser.Questions = bussines.GetUserQuestions(this.CurrentUser.UserId);
        }

        public DashBoardViewModel()
        {
        }
    }
}