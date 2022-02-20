using System;
namespace _21._02
{
    public class User:Admin
    {
        string username
        {
            get
            {
                return "Zehmet olmasa en az 7 simvoldan istifade edin";
            }
            set
            {
                if (value.Length>6)
                {

                }
                else
                {
                    Console.WriteLine("Zehmet olmasa yeniden cehd edin");
                }

            }
        }
         string password
        {
            get
            {
                return "Zehmet olmasa 1 eded ve 1 boyuk herfden istifade edin";
            }
            set
            {
                for (int i = 0; i < value.Length; i++)
                {
                    while (value = Int32. TryParse( , out int )
                    {

                    }
                }

            }
         }
        public User(string Username ,string Password,)
        {
            username = Username;
            password = Password.ToString();
        }
        public string UserInfo()
        {
            return $"Username:{username}\nPassword:{password}";
        }

        

    }
}
