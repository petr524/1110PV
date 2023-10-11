using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1110
{
    internal class User: IComparable<User>
    {
        private String nickname;
        private String password;

        public string Nickname { get => nickname; set => nickname = value; }
        public string Password { get => password; set => password = value; }

        public User(string nickname, string password) 
        { 
            this.nickname = nickname;
            this.password = password;
        }
        public static User CreateUser(String nickname, String password)
        {
            if (nickname.Length < 3)
            {
                throw new ArgumentException("Nickname musi mit alespon 3 znaky");
            }
            if (password.Length < 5)
            {
                throw new ArgumentException("Password musi mit alespon 5 znaku;");
            }
            return new User(nickname, password);
        }
        public int CompareTo(User u) 
        {
            if(u == null) return 1;
            return string.Compare(this.nickname, u.nickname);
        }
        public override String ToString()
        {
            return nickname+"-";
        }
    }

}
