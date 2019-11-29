using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainLoginStudy
{
    class LoginHandler
    {
        //Login DB연동 추가
        public bool LoginCheck(string id, string password)
        {
            // 실제 아이디 비번 맞는지 확인
            if(id.Equals("admin") && password.Equals("1234"))
            {
                return true;
            }
            return false;
        }


    }
}
