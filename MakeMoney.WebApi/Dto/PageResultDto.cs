namespace MakeMoney.WebApi.Dto {
    public class PageResultDto {
        public const int MaxPageSize = 50;
        private int _pageSize = 10;
        public int PageIndex { get; set; } = 1;
        public int PageSize {
            get { return _pageSize; }
            set { _pageSize = (value > MaxPageSize) ? MaxPageSize : value; }
        }
    }
}
