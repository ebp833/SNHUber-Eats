using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace SNHUber_Eats
{
    class InitialLoginVerification
    {
        public static bool Valid_Name(string name)
        {
            if (name.Length < 3)
            {
                return false;
            }
            for (int i = 0; i < name.Length; i++)
            {
                if (Char.IsDigit(name[i]))
                {
                    return false;
                }

            }
            return true;
        }
        public static bool ValidatedPassword(string p1, string p2)
        {
            if (p1.Length == p2.Length)
            {
                for (int i = 0; i < p1.Length; i++)
                {
                    if (p1[i] != p2[i])
                    {
                        return false;
                    }
                }
            }
            else
            {
                return false;
            }
            return true;
            
        }
        public static bool valid_Email(string email)
        {
            if (email.Contains("@"))
            {
                if (email.Contains("snhu.edu") || email.Contains("gmail.com"))
                {
                    return true;
                }
            }
            return false;
        }
        public static bool valid_Number(string num)
        {
            for (int i = 0; i < num.Length; i++)
            {
                if (!Char.IsDigit(num[i]))
                {
                    return false;
                }

            }
            if (num.Length != 7)
            {
                return false;
            }
            return true;
        }
        public static bool valid_Room(string room)
        {
            for(int i = 0; i < room.Length; i++)
            {
                if (!Char.IsDigit(room[i]))
                {
                    return false;
                }

            }
            if (room.Length != 3)
            {
                return false;
            }
            return true;
        }
       
        public static string[] AllUserInfo() 
        {
            string[] lines;
            var list = new List<string>();
            try
            {
                var fileStream = new FileStream(@"User_Info.txt", FileMode.Open, FileAccess.Read);


                using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
                {
                    string line;
                    while ((line = streamReader.ReadLine()) != null)
                    {
                        list.Add(line);
                    }
                }
                fileStream.Close();
            }
            catch (Exception e)
            {
            }
            lines = list.ToArray();
            return lines;

        }

        public static bool ValidCredentials(string a, string b)
        {
            string[] userInfo = AllUserInfo();
            string username = a;
            string password = b;
            for (int i = 0; i < userInfo.Count(); i++)
            {
                string[] splitLine = userInfo[i].Split(':');
                if(splitLine[0]==username)
                {
                    if (splitLine[1] == password)
                    {
                        return true;
                    }
                }
            }
            
            return false;
        }
    }
}
