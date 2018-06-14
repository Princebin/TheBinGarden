using Autofac;

namespace autofacTest
{
    class Program
    {
        private static IContainer Container { get; set; }
        static void Main(string[] args)
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<AddressService>().As<IAddressService>();
            Container = builder.Build();
            AddressService addressService = Container.Resolve<AddressService>();
            addressService.GetAddress(123);
        }
    }
}
