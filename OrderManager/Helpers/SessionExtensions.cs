using Newtonsoft.Json;

namespace OrderManager.Helpers
{
    public static class SessionExtensions
    {
        public static void SetObjectAsJson(this ISession session, string key, object value) =>
            session.SetString(key, JsonConvert.SerializeObject(value));
    }
}