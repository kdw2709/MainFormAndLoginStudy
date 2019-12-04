using MainLoginStudy.DAO;
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
            string check = string.Empty;

            // 인스턴스 생성, using참조.
            TUserDao tUser = new DAO.TUserDao();

            // DAO의 TUser메서드 셀렉트문
            check = tUser.SelectTUser(id, password); // 파라미터 아이디,비밀번호

            // 맞는 아이디 비번이존재 하는지확인
            if (check != "0")
            {
                // 존재할실 true 값 리턴
                return true;
            }
            //// 실제 아이디 비번 맞는지 확인
            //if (id.Equals("admin") && password.Equals("1234"))
            //{
              
            //}

            // 맞는 아이디 비번이 존재 안할시 false 값 리턴
            return false;
        }


    }
}
