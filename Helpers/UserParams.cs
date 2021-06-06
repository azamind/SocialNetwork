namespace SocialNetworkProject.Helpers
{
    public class UserParams
    {
        private const int MAXPAGESIZE = 50;
        public int PageNumber { get; set; } = 1;
        private int _pageSize = 10;

        public int PageSize
        {
            get => _pageSize;
            set => _pageSize = (value > MAXPAGESIZE) ? MAXPAGESIZE : value;
        }
        public string CurrentUsername { get; set; }
        public string Gender { get; set; }
        public int MinAge { get; set; } = 18;
        public int MaxAge { get; set; } = 150;
    }
}
