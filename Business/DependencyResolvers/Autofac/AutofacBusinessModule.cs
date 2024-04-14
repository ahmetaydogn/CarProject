using Autofac;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;

namespace Business.DependencyResolvers.Autofac;

public class AutofacBusinessModule : Module
{
    protected override void Load(ContainerBuilder builder)
    {
        // Products
        builder.RegisterType<ProductManager>().As<IProductService>();
        builder.RegisterType<EfProductDal>().As<IProductDal>();

        // Customers
        builder.RegisterType<CustomerManager>().As<ICustomerService>();
        builder.RegisterType<EfCustomerDal>().As<ICustomerDal>();

        // Sales
        builder.RegisterType<SaleManager>().As<ISaleService>();
        builder.RegisterType<EfSaleDal>().As<ISaleDal>();

        // Bills
        builder.RegisterType<BillManager>().As<IBillService>();
        builder.RegisterType<EfBillDal>().As<IBillDal>();
    }
}
