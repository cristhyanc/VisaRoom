using BusinessLogic.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VisaRoom.Common.Models;
namespace VisaRoom.Web.ViewModel
{

    public class DashBoardViewModel : VisaRoom.Web.Helper.HelperVisaRoomLogError
    {
        public UserTo CurrentUser { get; set; }
        public DashBoardViewModel(UserTo user)
        {
            this.CurrentUser = user;
            BLUser bussines=new BLUser(this.LogError.SLogPath);

            this.CurrentUser.Questions = bussines.GetUserQuestions(this.CurrentUser.UserId);
        }
    }
}