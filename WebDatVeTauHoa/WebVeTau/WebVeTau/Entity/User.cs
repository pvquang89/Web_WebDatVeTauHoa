    using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebVeTau.Entity
{
    public class User
    {
        private string fullName;
        private string cccd;
        private string tel;
        private string email;
        private string pass;
        private string gioitinh;
        private string ngaysinh;
        
        public User()
        {
            
        }

        public User(string fullName, string cccd, string tel, string email, string pass, string gioitinh, string ngaysinh)
        {
            this.fullName = fullName;
            this.cccd = cccd;
            this.email = email;
            this.tel = tel;
            this.pass = pass;
            this.gioitinh = gioitinh;
            this.ngaysinh = ngaysinh;
        }

        public string getFullNam()
        {
            return this.fullName;
        }
        public string getCccd()
        {
            return this.cccd;
        }
        public string getTel()
        {
            return this.tel;
        }
        public string getmail()
        {
            return this.email;
        }
        public string getGioitinh()
        {
            return this.gioitinh;
        }
        public string getNgaysinh()
        {
            return this.ngaysinh;
        }
        public string getPass()
        {
            return this.pass;
        }

        public  List<User> constructor()
        {
            List<User> users = new List<User>();
            users.Add(new User("Đinh Huy Khánh", "122362416", "0383007876", "khanhdinh141@gmail.com", "123456", "nam", "28/06/2001"));
            users.Add(new User("Phạm Xuân Vinh", "122352417", "0338007777", "phamvinh2k4@gmail.com", "123456", "nam", "30/07/2001"));
            users.Add(new User("Vũ Văn Khang", "122362418", "0383007999", "khangvu2k1@gmail.com", "123456", "nam", "15/07/2001"));
            return users;
        }
    }
}