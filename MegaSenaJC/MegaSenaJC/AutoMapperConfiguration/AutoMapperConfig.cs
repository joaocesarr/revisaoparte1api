using AutoMapper;

namespace MegaSena.AutoMapperConfiguration
{
    public static class AutoMapperConfig
    {
        public static MapperConfiguration Config { get; private set; }
        public static IMapper Map { get => Config.CreateMapper(); }
        public static void Configure()
        {
            Config = new MapperConfiguration(M =>
            {
                M.AddProfile<DomainToViewModelProfile>();
                M.AddProfile<ViewModelToDomainProfile>();
            });
        }
    }
}
