
using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.Concrete;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using Core.Utilities.Security.Jwt;
using DataAccess.Abstract;
using DataAccess.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {



            builder.RegisterType<AuthManager>().As<IAuthService>();
            builder.RegisterType<JwtHelper>().As<ITokenHelper>();

            builder.RegisterType<UserManager>().As<IUserService>();
            builder.RegisterType<EfUserDal>().As<IUserDal>();

            builder.RegisterType<SchoolManager>().As<ISchoolService>();
            builder.RegisterType<EfSchoolDal>().As<ISchoolDal>();

            builder.RegisterType<ActivityManager>().As<IActivityService>();
            builder.RegisterType<EfActivityDal>().As<IActivityDal>();

            builder.RegisterType<AnnouncementManager>().As<IAnnouncementService>();
            builder.RegisterType<EfAnnouncementDal>().As<IAnnouncementDal>();

            builder.RegisterType<RoomManager>().As<IRoomService>();
            builder.RegisterType<EfRoomDal>().As<IRoomDal>();

            builder.RegisterType<CafeteriaManager>().As<ICafeteriaService>();
            builder.RegisterType<EfCafeteriaDal>().As<ICafeteriaDal>();

            builder.RegisterType<UserImageManager>().As<IUserImageService>();
            builder.RegisterType<EfUserImageDal>().As<IUserImageDal>();

            builder.RegisterType<RecordManager>().As<IRecordService>();
            builder.RegisterType<EfRecordDal>().As<IRecordDal>();

            //builder.RegisterType<SuggestionManager>().As<ISuggestionService>();
            //builder.RegisterType<EfSuggestionDal>().As<ISuggestionDal>();





            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();
        }
    }
}
