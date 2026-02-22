using AutoMapper;
using PicPaySimplificado.Communication.Requests.User.Register;
using PicPaySimplificado.Domain.Entities;
using PicPaySimplificado.Domain.Enums;

namespace PicPaySimplificado.Application.Services.AutoMapper
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            RequestToDomain();
        }

        private void RequestToDomain()
        {
            CreateMap<RequestRegisterUserCommonJson, User>()
                .ForMember(userEntity => userEntity.Password, option => option.Ignore())
                .ForMember(userEntity => userEntity.Document, option => option.MapFrom(request => request.Cpf));

            CreateMap<RequestRegisterUserMerchantJson, User>()
                .ForMember(userEntity => userEntity.Password, option => option.Ignore())
                .ForMember(userEntity => userEntity.Document, option => option.MapFrom(request => request.Cnpj))
                .ForMember(userEntity => userEntity.TypeUser, option => option.MapFrom(request => TypeUser.Merchant));
        }
    }
}
