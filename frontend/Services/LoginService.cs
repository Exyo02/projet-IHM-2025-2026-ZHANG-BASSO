namespace frontend.Services
{
    public class LoginService
    {
        private string adressmail = "mail@mail.com";
        private string motdepasse = "motdepasse";
        public bool state =false;
        public event Action? OnChange;

        public bool verification(string mail,string mdp)
        {
            state = adressmail==mail && motdepasse==mdp;
            if (state)
            {
                NotifyStateChanged();
            }
            return state;
        }

        private void NotifyStateChanged()=>OnChange?.Invoke();

        public void deconnection()
        {
            state = false;
            NotifyStateChanged();
        }
    }
}
