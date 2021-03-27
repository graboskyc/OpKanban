using System;
using MongoDB.Bson;
using Realms;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Text;

namespace OpKanban.Data
{
    public class Login
    {
        public string Username { get; set; }
        public Realms.Sync.App app { get; set; }
        public Realms.Sync.User user { get; set; }
        public Realms.Sync.SyncConfiguration config { get; set; }
        public Realm realm { get; set; }
        public string partition { get; set; }
        public event Action OnChange;
        public bool IsLoggedIn { get; set; } = false;
        public bool LoginFailed {get;set;} = false;
        public string Gravatar {get;set;}

        public async Task DoLogin(string email, string password)
        {
            try {
                Username = email;

                using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
                {
                    byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(email);
                    byte[] hashBytes = md5.ComputeHash(inputBytes);

                    // Convert the byte array to hexadecimal string
                    StringBuilder sb = new StringBuilder();
                    for (int i = 0; i < hashBytes.Length; i++)
                    {
                        sb.Append(hashBytes[i].ToString("X2"));
                    }
                    Gravatar = sb.ToString().ToLower();
                }
    
                app = Realms.Sync.App.Create("opkanban-lymqs");
                user = await app.LogInAsync(Realms.Sync.Credentials.EmailPassword(email, password));
                partition = $"user={ user.Id }";
                config = new Realms.Sync.SyncConfiguration(partition, user);
                realm = await Realm.GetInstanceAsync(config);
                IsLoggedIn = true;
                LoginFailed = false;
            } catch (Exception e) {
                IsLoggedIn = false;
                LoginFailed = true;
            }
            NotifyStateChanged();
        }

        private void NotifyStateChanged()
        {
            OnChange?.Invoke();
        }
    }
}
