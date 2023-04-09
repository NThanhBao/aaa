using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BTHso_8_9_10
{
    public class User
    {

        private string firstName;
        private string lastName;
        private string email;
        private bool gender;
        private string address;
        private string userName;
        private string passWord;
        private string avatarFileName;


        public User()
        {
            firstName = "";
            lastName = "";
            email = "";
            gender = true;
            address = "";
            userName = "";
            passWord = "";
            
        }

        public User(string ten, string hodem, string mail, bool gt, string dc, string us, string pw)
        {
            firstName = ten;
            lastName = hodem;
            email = mail;
            gender = gt;
            address = dc;
            userName = us;
            passWord = pw;
           
        }

        public string FirstName { get { return firstName; } set { firstName = value; } }
        public string LastName { get { return lastName; } set { lastName = value; } }
        public string Email { get { return email; } set { email = value; } }
        public bool Gender { get { return gender; } set { gender = value; } }
        public string Address { get { return address; } set { address = value; } }
        public string UserName { get { return userName; } set { userName = value; } }
        public string PassWord { get { return passWord; } set { passWord = value; } }
        public string AvatarFileName { get { return avatarFileName; } set { avatarFileName = value; } }



    }

}