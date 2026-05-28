using Supabase;

namespace MyWebApp.Auth
{
    public static class SupabaseAuthentication
    {
        private static string url = "https://ygenbnjzzzesunqatuof.supabase.co";
        private static string key = "sb_publishable_llpmf9LsrCW1j83wNmQvlw_UkEk3s3G";

        public static async Task<Supabase.Gotrue.Session> SignIn(string txtEmail, string txtPwd)
        {
            try
            {
                var client = new Client(url, key);

                await client.InitializeAsync();

                Supabase.Gotrue.Session? session = await client.Auth.SignIn(txtEmail, txtPwd);

                return session;
            }
            catch
            {
                return null;
            }
        }
    }
}
