using Mango.Web.Models;
using Mango.Web.Service.IService;

namespace Mango.Web.Service;

public class CouponService : ICouopnService
{
    private readonly IBaseService _baseService;
    public CouponService(IBaseService baseService)
    {
        _baseService = baseService;
    }

    public Task<ResponseDto?> CreateCouponsAsync(CouponDTO couponDTO)
    {
        throw new NotImplementedException();
    }

    public Task<ResponseDto?> DeleteCouponsAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<ResponseDto?> GetAllCouponsAsync()
    {
        throw new NotImplementedException();
    }

    public Task<ResponseDto?> GetCouponAsync(string couponCode)
    {
        throw new NotImplementedException();
    }

    public Task<ResponseDto?> GetCouponByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<ResponseDto?> UpdateCouponsAsync(CouponDTO couponDTO)
    {
        throw new NotImplementedException();
    }
}
