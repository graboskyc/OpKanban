using System;
using MongoDB.Bson;
using Realms;
using System.Threading.Tasks;

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

        public async Task DoLogin(string email, string password)
        {
            try {
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
