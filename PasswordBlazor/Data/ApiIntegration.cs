using System.Net.Http;

namespace PasswordBlazor.Data
{
    public class ApiIntegration
    {
        
        //UPDATE THESE!!!
        //API Endpoint (usually your PWPush URL + "/p.json"):
        public static string PwPushAPI = "";
        //PWPush Password URL (usually your PWPush URL + "/p/")
        public static string PwPushPass = "";

        //DONT TOUCH
        public static readonly HttpClient client = new();
    }

    public class Root
    {
        public int? id { get; set; }
        public string? payload { get; set; }
        public int? expire_after_days { get; set; }
        public int? expire_after_views { get; set; }
        public bool? expired { get; set; }
        public string? url_token { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        public object? user_id { get; set; }
        public bool deleted { get; set; }
        public bool first_view { get; set; }
        public bool deletable_by_viewer { get; set; }
        public int days_remaining { get; set; }
        public int views_remaining { get; set; }
    }
}
